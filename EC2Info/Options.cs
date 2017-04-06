using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC2Info
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();

            Roles_TB.Clear();
            foreach (string item in Properties.Settings.Default.Roles)
            {
                Roles_TB.AppendText(item + Environment.NewLine);
            }

            Mfa_TB.Clear();
            foreach (string item in Properties.Settings.Default.MFADevices)
            {
                Mfa_TB.AppendText(item + Environment.NewLine);
            }
            Tags_TB.Clear();
            foreach (string item in Properties.Settings.Default.Tags)
            {
                Tags_TB.AppendText(item + Environment.NewLine);
            }

            EC2Items_TB.Clear();            
            EC2Items_TB.Text = Properties.Settings.Default.EC2SavedProperties;
            
        }

        private void Cancel_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_BTN_Click(object sender, EventArgs e)
        {
            System.Collections.Specialized.StringCollection roles = new System.Collections.Specialized.StringCollection();
            foreach (string item in Roles_TB.Lines)
            {
                if (item.Length > 0)
                {
                    roles.Add(item.Trim());
                }
            }
            Properties.Settings.Default.Roles = roles;

            System.Collections.Specialized.StringCollection mfas = new System.Collections.Specialized.StringCollection();
            foreach (string item in Mfa_TB.Lines)
            {
                if (item.Length > 0)
                {
                    mfas.Add(item.Trim());
                }
            }
            Properties.Settings.Default.MFADevices = mfas;


            System.Collections.Specialized.StringCollection tags = new System.Collections.Specialized.StringCollection();
            foreach (string item in Tags_TB.Lines)
            {
                if (item.Length > 0)
                {
                    tags.Add(item.Trim());
                }
            }
            Properties.Settings.Default.Tags = tags;


            Properties.Settings.Default.EC2SavedProperties = EC2Items_TB.Text.Trim();            

            Properties.Settings.Default.Save();

            this.Close();

        }


    }
}
