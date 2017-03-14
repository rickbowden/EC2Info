using Amazon.Runtime;
using Amazon.EC2;
using Amazon.EC2.Model;
using Amazon.EC2.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon;
using System.Xml.Linq;
using System.Collections.Specialized;

namespace EC2Info
{
    public partial class App : Form
    {
        static AWSCredentials creds;               
        static Dictionary<string, string> MfaDevices = new Dictionary<string,string>();
        public static string mfacode = string.Empty;
        static DateTime mfaExpires;
        static string UpdateUrl = Properties.Settings.Default.UpdateUrl;
        static double ThisVersion = Convert.ToDouble(Properties.Settings.Default.Version);
        static string UserName = Environment.UserName;
        static string AppName = "EC2Info";
        static StringCollection ColumnItems = new StringCollection();
               
        public App()
        {
            InitializeComponent();
                        
            try
            {
                if (Properties.Settings.Default.UpgradeRequired)
                {
                    Properties.Settings.Default.Upgrade();
                    Properties.Settings.Default.UpgradeRequired = false;
                    Properties.Settings.Default.Save();
                }

                PopulateMfaDevicesDic();
                PopulateRegionDropDown();
                PopulateProfileDropDown();
                PopulateRoleDropDown();
                LoadSavedColumnItems();
                PopulateGridColumns();
                
                //Set default region
                AWSConfigs.AWSRegion = Properties.Settings.Default.AWSDefaultRegion;

                dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;

                CheckForUpdates();
            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }

        }



        //-------------------------------------------------------------------------
        // Control Events (Start)
        //-------------------------------------------------------------------------

        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            if (Profile_CBB.Text == "select a profile") { return; }
            try
            {
                //Set region
                AWSConfigs.AWSRegion = AWSRegion_CBB.Text;

                //Set Creds
                SetCreds();

                //Reset Grid 
                PopulateGridColumns();
                dataGridView1.Rows.Clear();

                Submit_BTN.Enabled = false;
                ProcessSG_BTN.Enabled = false;

                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form options = new Options();
                options.ShowDialog();
                //Reload role dropdown
                PopulateRoleDropDown();
            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
        }

        private void ProcessSG_BTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                try
                {
                    ProcessSecurityGroups();
                }
                catch (Exception ex)
                {
                    DisplayError(ex.Message);
                }
            }
        }

        private void CopyStyle_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (CopyStyle_CB.Checked)
            {
                dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            }
            else
            {
                dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   
            using (ColumnChooser cc = new ColumnChooser(ColumnItems))
            {                
                cc.StartPosition = FormStartPosition.CenterParent;
                var result = cc.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ColumnItems = cc.CheckedItems;
                    //PopulateGridColumns();
                    UpdateGridColumns();
                }                
            }
            
        }
        
        //-------------------------------------------------------------------------
        // Control Events (End)
        //-------------------------------------------------------------------------


        void DisplayError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);            
        }

              
        void PopulateMfaDevicesDic()
        {
            if (MfaDevices != null)
            {
                MfaDevices.Clear();
            }
            foreach (string item in Properties.Settings.Default.MFADevices)
            {
                string[] items = item.Split('|');
                if (items.Length == 2)
                { 
                    MfaDevices.Add(items[0], items[1]);
                }
            }
        }
        
        void PopulateRegionDropDown()
        {
            AWSRegion_CBB.Items.Clear();
            foreach (string s in Properties.Settings.Default.AWSRegion)
            {
                AWSRegion_CBB.Items.Add(s);
            }
            if (Properties.Settings.Default.AWSDefaultRegion != null)
            {
                AWSRegion_CBB.Text = Properties.Settings.Default.AWSDefaultRegion;
            }
        }

        void PopulateProfileDropDown()
        {
            Profile_CBB.Items.Clear();
            foreach (var item in Amazon.Util.ProfileManager.ListProfiles())
            {
                Profile_CBB.Items.Add(item.Name);
            }
        }

        void PopulateRoleDropDown()
        {
            AssumeRole_CBB.Items.Clear();
            AssumeRole_CBB.Sorted = true;
            foreach (string role in Properties.Settings.Default.Roles)	
            {
              string[] a = role.Split('|');
              if (a.Length > 1)
              {
                  ComboboxItem item = new ComboboxItem();
                  item.Name = a[0];
                  item.Role = a[1];
                  AssumeRole_CBB.Items.Add(item);
              }
            }
            AssumeRole_CBB.Sorted = false;
            ComboboxItem item0 = new ComboboxItem();
            item0.Name = "none";
            item0.Role = "none";
            AssumeRole_CBB.Items.Insert(0, item0);            
        }

        void PopulateGridColumns()
        {
            if (ColumnItems.Count > 0)
            {
                // Clear Grid
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();                
                for (int i = 0; i < ColumnItems.Count; i++)
                {
                    dataGridView1.Columns.Add(ColumnItems[i], ColumnItems[i]);
                }
            }            
        }

        void UpdateGridColumns()
        {
            if (ColumnItems.Count > 0)
            {                
                for (int i = 0; i < ColumnItems.Count; i++)
                {
                    if (!(dataGridView1.Columns.Contains(ColumnItems[i])))
                    {
                        dataGridView1.Columns.Add(ColumnItems[i], ColumnItems[i]);
                    }
                }
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (!(ColumnItems.Contains(dataGridView1.Columns[i].Name)))
                    {
                        if (!(dataGridView1.Columns[i].Name.StartsWith("sg-")))
                        {
                            dataGridView1.Columns.Remove(dataGridView1.Columns[i].Name);
                        }
                    }
                }

                if (dataGridView1.Columns.Contains("SecurityGroups"))
                {
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        if (dataGridView1.Columns[i].Name.StartsWith("sg-"))
                        {
                            dataGridView1.Columns.Remove("SecurityGroups");
                            return;
                        }
                    }
                }
            }
        }

        void LoadSavedColumnItems()
        {
            if (Properties.Settings.Default.EC2SavedProperties != null)
            {
                ColumnItems.AddRange(Properties.Settings.Default.EC2SavedProperties.Split(','));
                
            }
        }


        DescribeInstancesResponse GetInstances(List<string> instanceIds)
        {
            DescribeInstancesResponse result = null;

            using (AmazonEC2Client EC2client = new AmazonEC2Client(creds))
            {
                DescribeInstancesRequest rq = new DescribeInstancesRequest();                
                rq.InstanceIds = instanceIds;
                if (instanceIds.Count == 0)
                {
                    result = EC2client.DescribeInstances();
                }
                else
                {
                    result = EC2client.DescribeInstances(rq);
                }                
            }

            return result;
        }
        DescribeInstancesResponse GetInstances(List<Filter> searchFilters)
        {
            DescribeInstancesResponse result = null;

            using (AmazonEC2Client EC2client = new AmazonEC2Client(creds))
            {
                DescribeInstancesRequest rq = new DescribeInstancesRequest();                
                rq.Filters = searchFilters;                
                if (searchFilters == null)
                {
                    result = EC2client.DescribeInstances();
                }
                else
                {
                    result = EC2client.DescribeInstances(rq);
                }
            }

            return result;
        }


        static List<Filter> BuildFilter(string inputString, string searchItem)
        {
            List<Filter> filterList = new List<Filter>();
            Filter f = new Filter();
            string[] a = inputString.Split(',');
            if (a.Length > 0)
            {               
                f.Name = searchItem;
                for (int i = 0; i < a.Length; i++)
                {
                    f.Values.Add(a[i].Trim());
                }               
                
            }
            filterList.Add(f);

            return filterList;
        }

        static List<string> BuildSearchString(string inputString)
        {
            List<string> result = new List<string>();

            
                string[] a = inputString.Split(',');
                result = a.ToList();
            

            return result;
        }
       

        private void SetCreds()
        {
            if (creds == null || DateTime.Now >= mfaExpires || AWSConfigs.AWSProfileName != Profile_CBB.Text)
            {
                AWSConfigs.AWSProfileName = Profile_CBB.Text;
                creds = new StoredProfileAWSCredentials(Profile_CBB.Text);
                
                
                if (AssumeRole_CBB.Text != "none")
                {
                    //Get selected role to assume
                    ComboboxItem o = (ComboboxItem)AssumeRole_CBB.SelectedItem;
                    //Create AssumeRole request
                    Amazon.SecurityToken.Model.AssumeRoleRequest assumeRequest = new Amazon.SecurityToken.Model.AssumeRoleRequest();
                    assumeRequest.RoleArn = o.Role;
                    assumeRequest.RoleSessionName = UserName + "@" + AppName;

                    //Get MFA Device
                    Amazon.IdentityManagement.AmazonIdentityManagementServiceClient imc = new Amazon.IdentityManagement.AmazonIdentityManagementServiceClient(creds);
                    Amazon.IdentityManagement.Model.ListMFADevicesRequest mfaRequest = new Amazon.IdentityManagement.Model.ListMFADevicesRequest();
                    Amazon.IdentityManagement.Model.ListMFADevicesResponse mfaResponse = imc.ListMFADevices(mfaRequest);
                    if (mfaResponse != null)
                    {
                        if (mfaResponse.MFADevices.Count > 0)
                        {
                            assumeRequest.SerialNumber = mfaResponse.MFADevices[0].SerialNumber;
                        }
                    }

                    //If MFA Device was not obtained
                    if (assumeRequest.SerialNumber == string.Empty)
                    {
                        //Get mfa associated with selected profile
                        if (MfaDevices.ContainsKey(Profile_CBB.Text))
                        {
                            assumeRequest.SerialNumber = MfaDevices[Profile_CBB.Text];
                        }
                        else
                        {
                            assumeRequest.SerialNumber = MfaDevices["default"];
                        }
                    }

                                        
                    //Get MFA code
                    mfa m = new mfa();
                    m.ShowDialog();                    
                    assumeRequest.TokenCode = mfacode.Trim(); //MFA code
                    
                    Amazon.SecurityToken.AmazonSecurityTokenServiceClient secClient = new Amazon.SecurityToken.AmazonSecurityTokenServiceClient();
                    Amazon.SecurityToken.Model.AssumeRoleResponse assumeResponse = secClient.AssumeRole(assumeRequest);

                    mfaExpires = assumeResponse.Credentials.Expiration;

                    creds = assumeResponse.Credentials;
                }
            }
        }




        void DisplayResults(DescribeInstancesResponse describeInstanceResponse)
        {                 
            

            if (describeInstanceResponse != null && describeInstanceResponse.Reservations.Count > 0)
            {
                foreach (Reservation reservations in describeInstanceResponse.Reservations)
                {
                    foreach (Instance instance in reservations.Instances)
                    {                                                
                        DataGridViewRow row = new DataGridViewRow();                        
                        int rowNumber = dataGridView1.Rows.Add(row);

                        for (int i = 0; i < ColumnItems.Count; i++)
                        {
                            dataGridView1.Rows[rowNumber].Cells[ColumnItems[i]].Value = Utils.GetEC2PropFromString(ColumnItems[i], instance);
                        }
                    }
                }
            }

            
        }

        void SetGridColumns(string[] colHeaders)
        {
            
            
        }

        void ProcessSecurityGroups()
        {
            List<int> newColumns = new List<int>();
            if (dataGridView1.Columns.Contains("SecurityGroups"))
            {                
                int colIndex = dataGridView1.Columns.Count - 1;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1["SecurityGroups", i].Value != null)
                    {
                        string[] sgColData = dataGridView1["SecurityGroups", i].Value.ToString().Split(',');
                        foreach (string item in sgColData)
                        {
                            if (!(IsAcolumn(item, dataGridView1)))
                            {
                                dataGridView1.Columns.Add(item, item);
                            }
                            dataGridView1.Rows[i].Cells[item].Value = item;
                        }
                    }
                }
                dataGridView1.Columns.Remove("SecurityGroups");
            }
        }

        bool IsAcolumn(string input, DataGridView dgv)
        {
            bool result = false;
            if (dataGridView1.Columns.Contains(input))
            {
                result = true;
            }
            return result;
        }

        bool IsInRow(string input, DataGridView dgv)
        {
            bool result = false;
            
            return result;
        }

        //######################################################################

        

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string searchItem = string.Empty;
            if (searchInstance_RB.Checked)
            {
                searchItem = "instance-id";
            }
            else if (searchName_RB.Checked)
            {
                searchItem = "tag:Name";
            }
            else if (searchPrivateIp_RB.Checked)
            {
                searchItem = "private-ip-address";
            }

            
            backgroundWorker1.ReportProgress(1, 1);
            DescribeInstancesResponse dir = GetInstances(BuildFilter(search_TB.Text, searchItem));            
            e.Result = dir;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch ((int)e.UserState)
            {
                case 0:
                    ProgressBar1.Style = ProgressBarStyle.Continuous;                    
                    break;
                case 1:
                    ProgressBar1.Style = ProgressBarStyle.Marquee;
                    Status_LB.Text = "Getting Information";
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                DisplayError(e.Error.Message);
            }
            else
            {
                if (e.Result != null)
                {
                    if (e.Result is DescribeInstancesResponse)
                    {
                        DisplayResults((DescribeInstancesResponse)e.Result);
                    }
                }
            }

            ProgressBar1.Style = ProgressBarStyle.Continuous;
            ProgressBar1.Value = 0;
            Submit_BTN.Enabled = true;
            ProcessSG_BTN.Enabled = true;
            Status_LB.Text = "Finished";
        }


        void CheckForUpdates()
        {
            try
            {
                backgroundWorkerUpdate.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                DisplayError("Error during update check." + Environment.NewLine + ex.Message);
            }
        }


        private void backgroundWorkerUpdate_DoWork(object sender, DoWorkEventArgs e)
        {            
            try
            {
                rab_update.Version v = new rab_update.Version(Properties.Settings.Default.Version, Properties.Settings.Default.UpdateUrl);
                v.CheckForNewVersion();
                e.Result = v;
            }
            catch (Exception ex)
            {
                DisplayError("Error during update check." + Environment.NewLine + ex.Message);                
            }
            
        }


        private void backgroundWorkerUpdate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {            
            if (e.Result is rab_update.Version)
            {
                rab_update.Version v = e.Result as rab_update.Version;
                if (v.UpdateAvailable)
                {                    
                    rab_update.UpdateForm uf = new rab_update.UpdateForm(v.NewVersionString, v.CurrentVersion, v.DownloadUrl, AppName);
                    uf.ShowDialog();
                }
            }
        }

        





    }

    // Custom ComboBox Class
    public class ComboboxItem
    {
        public string Name { get; set; }
        public string Role { get; set; }        
        public override string ToString()
        {
            return Name;
        }
    }
}
