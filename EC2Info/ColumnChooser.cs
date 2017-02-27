using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC2Info
{
    public partial class ColumnChooser : Form
    {
        public StringCollection CheckedItems { get; set; }
        
        
        public ColumnChooser(string[] savedColumns)
        {
            InitializeComponent();

            CheckedItems = new StringCollection();

            checkedListBox1.Items.Clear();
            if (Properties.Settings.Default.EC2Properties != null)
            {
                foreach (string item in Properties.Settings.Default.EC2Properties)
                {
                    checkedListBox1.Items.Add(item);
                }
            }

            //Tick saved columns
            foreach (string item in savedColumns)
            {
                int foundItem = checkedListBox1.FindStringExact(item);
                if (foundItem != null)
                {
                    checkedListBox1.SetItemChecked(foundItem, true);
                }
            }
        }


        private void OK_BTN_Click(object sender, EventArgs e)
        {
            if (CheckedItems != null)
            {
                CheckedItems.Clear();
            }
            foreach (string item in checkedListBox1.CheckedItems)
            {
                CheckedItems.Add(item);
            }
            this.Close();
        }

        private void Save_BTN_Click(object sender, EventArgs e)
        {
            string temp = string.Empty;
            foreach (string item in checkedListBox1.CheckedItems)
            {
                temp += "," + item;
            }
            if (temp.Length > 0)
            {
                Properties.Settings.Default.EC2SavedProperties = temp.Remove(0, 1);
                Properties.Settings.Default.Save();
            }
        }
    }
}
