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

namespace EC2Info
{
    public partial class App : Form
    {
        static AWSCredentials creds;

        static Dictionary<string, string> roles;
        public static string mfacode = "";
               
        public App()
        {
            InitializeComponent();
                             
     

            PopulateRegionDropDown();
            PopulateProfileDropDown();
            PopulateRoleDropDown();

            //Set default region
            AWSConfigs.AWSRegion = Properties.Settings.Default.AWSDefaultRegion;
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

            foreach (string role in Properties.Settings.Default.Roles)	
            {
              string[]a=role.Split('|');
              ComboboxItem item = new ComboboxItem();
              item.Name = a[0];
              item.Role = a[1];
              item.MFA = a[2];
              AssumeRole_CBB.Items.Add(item);
            }
            
            //XDocument xdoc = XDocument.Load("roles.xml");            
            //roles = xdoc.Descendants("roles").Elements().ToDictionary(n => (n.Attribute("name").Value), n => n.Value);
            //foreach (var item in roles)
            //{
            //    AssumeRole_CBB.Items.Add(item.Key);
            //}
        }

        DescribeInstancesResponse GetInstances(List<string> instanceIds)
        {
            DescribeInstancesResponse result = null;

            using (AmazonEC2Client EC2client = new AmazonEC2Client(creds))
            {
                DescribeInstancesRequest rq = new DescribeInstancesRequest();
                rq.InstanceIds = instanceIds;
                result = EC2client.DescribeInstances(rq);

                
            }

            return result;
        }


        //void DisplayResult(Instance s)
        //{
        //    if (s == null) { return; }

        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("InstanceId: " + s.InstanceId);
        //    var a = s.Tags.Find(n => n != null && n.Value == "Name");
        //    if (a != null) { sb.AppendLine("Name: " + a.Value); }
        //    //Result_TB.Text = sb.ToString();
        //}

        private void SetCreds()
        {
            if (creds == null)
            {
                if (Profile_RB.Checked)
                {
                    creds = new StoredProfileAWSCredentials(Profile_CBB.Text);
                }
                else if (Role_RB.Checked)
                {
                    ComboboxItem o = (ComboboxItem)AssumeRole_CBB.SelectedItem;
                    
                    
                    Amazon.SecurityToken.Model.AssumeRoleRequest assumeRequest = new Amazon.SecurityToken.Model.AssumeRoleRequest();
                    assumeRequest.RoleArn = o.Role;// "arn:aws:iam::640467343547:role/CA_KCOM_ADM"; //Target Role (atocrarsdev)            
                    assumeRequest.RoleSessionName = "ec2info";
                    assumeRequest.SerialNumber = o.MFA;//"arn:aws:iam::049793823615:mfa/rbowden.kcom.adm"; //MFA arn

                    assumeRequest.RoleArn = "arn:aws:iam::690933247543:role/CA_KCOM_ADM";
                    assumeRequest.SerialNumber = "arn:aws:iam::049793823615:mfa/rbowden.kcom.adm";

                    mfa m = new mfa();
                    m.ShowDialog();
                    
                    assumeRequest.TokenCode = mfacode.Trim(); //MFA code
                    
                    Amazon.SecurityToken.AmazonSecurityTokenServiceClient secClient = new Amazon.SecurityToken.AmazonSecurityTokenServiceClient();
                    Amazon.SecurityToken.Model.AssumeRoleResponse assumeResponse = secClient.AssumeRole(assumeRequest);

                    creds = assumeResponse.Credentials;
                }
            }
        }


        static List<string> BuildSearchString(string inputString)
        {
            List<string> result = new List<string>();

            string[] a = inputString.Split(',');
            result = a.ToList();

            return result;
        }


        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            if (search_TB.Text == null | search_TB.Text.Length <= 1) { return; }
            
            //Set region
            AWSConfigs.AWSRegion = AWSRegion_CBB.Text;

            //Set Creds
            SetCreds();

            backgroundWorker1.RunWorkerAsync();
            
            

            
        }




        //######################################################################



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DescribeInstancesResponse dir = GetInstances(BuildSearchString(search_TB.Text));

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }



    }

    // Custom ComboBox Class
    public class ComboboxItem
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string MFA { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
