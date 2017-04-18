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
        MyListBox m = new MyListBox();

        public ColumnChooser(StringCollection savedColumns)
        {
            InitializeComponent();

            m.CheckOnClick = true;
            m.Dock = DockStyle.Fill;
            m.ItemHeight = 20;
            m.BorderStyle = BorderStyle.None;
            groupBox1.Controls.Add(m);

            CheckedItems = new StringCollection();

            m.Items.Clear();
            if (Properties.Settings.Default.EC2Properties != null)
            {
                foreach (string item in Properties.Settings.Default.EC2Properties)
                {
                    m.Items.Add(item);
                }
            }
            if (Properties.Settings.Default.Tags != null)
            {
                foreach (string item in Properties.Settings.Default.Tags)
                {
                    m.Items.Add(item);
                }
            }


            //Tick saved columns
            foreach (string item in savedColumns)
            {
                int foundItem = m.FindStringExact(item);
                if (foundItem != -1)
                {
                    m.SetItemChecked(foundItem, true);
                }
            }
                
        }


        private void OK_BTN_Click(object sender, EventArgs e)
        {
            if (CheckedItems != null)
            {
                CheckedItems.Clear();
            }
            foreach (string item in m.CheckedItems)
            {
                CheckedItems.Add(item);
            }
            this.Close();
        }

        private void Save_BTN_Click(object sender, EventArgs e)
        {
            string temp = string.Empty;
            foreach (string item in m.CheckedItems)
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

    public sealed class MyListBox : CheckedListBox
    {
        public MyListBox()
        {
            ItemHeight = 30;
        }
        public override int ItemHeight { get; set; }
    }
}
