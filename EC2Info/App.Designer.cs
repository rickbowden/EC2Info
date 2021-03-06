﻿namespace EC2Info
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.Profile_CBB = new System.Windows.Forms.ComboBox();
            this.search_TB = new System.Windows.Forms.TextBox();
            this.AWSRegion_CBB = new System.Windows.Forms.ComboBox();
            this.Submit_BTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AssumeRole_CBB = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Roles = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.Status_LB = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.searchPrivateIp_RB = new System.Windows.Forms.RadioButton();
            this.searchName_RB = new System.Windows.Forms.RadioButton();
            this.searchInstance_RB = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.WrapCells_CB = new System.Windows.Forms.CheckBox();
            this.ColumnChooser_LNK = new System.Windows.Forms.LinkLabel();
            this.CopyStyle_CB = new System.Windows.Forms.CheckBox();
            this.ProcessSG_BTN = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorkerUpdate = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Profile_CBB
            // 
            this.Profile_CBB.FormattingEnabled = true;
            this.Profile_CBB.Location = new System.Drawing.Point(76, 26);
            this.Profile_CBB.Name = "Profile_CBB";
            this.Profile_CBB.Size = new System.Drawing.Size(322, 24);
            this.Profile_CBB.Sorted = true;
            this.Profile_CBB.TabIndex = 2;
            this.Profile_CBB.Text = "select a profile";
            this.toolTip1.SetToolTip(this.Profile_CBB, "Select a profile.\r\nProfiles are stored in the .NET SDK.\r\nThey can be added using " +
        "Visual Studio or PowerShell.");
            // 
            // search_TB
            // 
            this.search_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_TB.Location = new System.Drawing.Point(17, 47);
            this.search_TB.Name = "search_TB";
            this.search_TB.Size = new System.Drawing.Size(1202, 22);
            this.search_TB.TabIndex = 5;
            this.toolTip1.SetToolTip(this.search_TB, "A comma seperated list of items to search for.\r\nIf this is blank then all instanc" +
        "es will be retrieved.");
            // 
            // AWSRegion_CBB
            // 
            this.AWSRegion_CBB.FormattingEnabled = true;
            this.AWSRegion_CBB.Location = new System.Drawing.Point(17, 26);
            this.AWSRegion_CBB.Name = "AWSRegion_CBB";
            this.AWSRegion_CBB.Size = new System.Drawing.Size(197, 24);
            this.AWSRegion_CBB.Sorted = true;
            this.AWSRegion_CBB.TabIndex = 7;
            this.AWSRegion_CBB.Text = "select";
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.Location = new System.Drawing.Point(16, 31);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(75, 25);
            this.Submit_BTN.TabIndex = 9;
            this.Submit_BTN.Text = "Submit";
            this.Submit_BTN.UseVisualStyleBackColor = true;
            this.Submit_BTN.Click += new System.EventHandler(this.Submit_BTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AWSRegion_CBB);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 71);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Region:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.AssumeRole_CBB);
            this.groupBox2.Controls.Add(this.Profile_CBB);
            this.groupBox2.Location = new System.Drawing.Point(281, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 71);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Authentication:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Assume Role:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Profile:";
            // 
            // AssumeRole_CBB
            // 
            this.AssumeRole_CBB.FormattingEnabled = true;
            this.AssumeRole_CBB.Location = new System.Drawing.Point(542, 27);
            this.AssumeRole_CBB.Name = "AssumeRole_CBB";
            this.AssumeRole_CBB.Size = new System.Drawing.Size(408, 24);
            this.AssumeRole_CBB.TabIndex = 5;
            this.AssumeRole_CBB.Text = "none";
            this.toolTip1.SetToolTip(this.AssumeRole_CBB, "Select a role to assume.\r\nFirst select a profile then a role that can be assumed " +
        "using that profile.\r\nAdd roles using the \'Tools/Options\' menu.");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_Tools
            // 
            this.ToolStripMenuItem_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Roles});
            this.ToolStripMenuItem_Tools.Name = "ToolStripMenuItem_Tools";
            this.ToolStripMenuItem_Tools.Size = new System.Drawing.Size(57, 24);
            this.ToolStripMenuItem_Tools.Text = "Tools";
            // 
            // ToolStripMenuItem_Roles
            // 
            this.ToolStripMenuItem_Roles.Name = "ToolStripMenuItem_Roles";
            this.ToolStripMenuItem_Roles.Size = new System.Drawing.Size(114, 24);
            this.ToolStripMenuItem_Roles.Text = "Roles";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar1,
            this.Status_LB});
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1276, 25);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(200, 19);
            // 
            // Status_LB
            // 
            this.Status_LB.Name = "Status_LB";
            this.Status_LB.Size = new System.Drawing.Size(49, 20);
            this.Status_LB.Text = "Status";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(16, 71);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1202, 380);
            this.dataGridView1.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.searchPrivateIp_RB);
            this.groupBox3.Controls.Add(this.searchName_RB);
            this.groupBox3.Controls.Add(this.searchInstance_RB);
            this.groupBox3.Controls.Add(this.search_TB);
            this.groupBox3.Location = new System.Drawing.Point(12, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1241, 89);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search (Optional)";
            // 
            // searchPrivateIp_RB
            // 
            this.searchPrivateIp_RB.AutoSize = true;
            this.searchPrivateIp_RB.Location = new System.Drawing.Point(220, 20);
            this.searchPrivateIp_RB.Name = "searchPrivateIp_RB";
            this.searchPrivateIp_RB.Size = new System.Drawing.Size(89, 21);
            this.searchPrivateIp_RB.TabIndex = 8;
            this.searchPrivateIp_RB.Text = "Private IP";
            this.searchPrivateIp_RB.UseVisualStyleBackColor = true;
            // 
            // searchName_RB
            // 
            this.searchName_RB.AutoSize = true;
            this.searchName_RB.Location = new System.Drawing.Point(131, 20);
            this.searchName_RB.Name = "searchName_RB";
            this.searchName_RB.Size = new System.Drawing.Size(66, 21);
            this.searchName_RB.TabIndex = 7;
            this.searchName_RB.Text = "Name";
            this.searchName_RB.UseVisualStyleBackColor = true;
            // 
            // searchInstance_RB
            // 
            this.searchInstance_RB.AutoSize = true;
            this.searchInstance_RB.Checked = true;
            this.searchInstance_RB.Location = new System.Drawing.Point(17, 20);
            this.searchInstance_RB.Name = "searchInstance_RB";
            this.searchInstance_RB.Size = new System.Drawing.Size(93, 21);
            this.searchInstance_RB.TabIndex = 6;
            this.searchInstance_RB.TabStop = true;
            this.searchInstance_RB.Text = "InstanceId";
            this.searchInstance_RB.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.WrapCells_CB);
            this.groupBox4.Controls.Add(this.ColumnChooser_LNK);
            this.groupBox4.Controls.Add(this.CopyStyle_CB);
            this.groupBox4.Controls.Add(this.ProcessSG_BTN);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.Submit_BTN);
            this.groupBox4.Location = new System.Drawing.Point(13, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1240, 471);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results";
            // 
            // WrapCells_CB
            // 
            this.WrapCells_CB.AutoSize = true;
            this.WrapCells_CB.Location = new System.Drawing.Point(450, 34);
            this.WrapCells_CB.Name = "WrapCells_CB";
            this.WrapCells_CB.Size = new System.Drawing.Size(149, 21);
            this.WrapCells_CB.TabIndex = 18;
            this.WrapCells_CB.Text = "Wrap muliple items";
            this.toolTip1.SetToolTip(this.WrapCells_CB, resources.GetString("WrapCells_CB.ToolTip"));
            this.WrapCells_CB.UseVisualStyleBackColor = true;
            this.WrapCells_CB.CheckedChanged += new System.EventHandler(this.WrapCells_CB_CheckedChanged);
            // 
            // ColumnChooser_LNK
            // 
            this.ColumnChooser_LNK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnChooser_LNK.AutoSize = true;
            this.ColumnChooser_LNK.LinkColor = System.Drawing.Color.Blue;
            this.ColumnChooser_LNK.Location = new System.Drawing.Point(1104, 35);
            this.ColumnChooser_LNK.Name = "ColumnChooser_LNK";
            this.ColumnChooser_LNK.Size = new System.Drawing.Size(114, 17);
            this.ColumnChooser_LNK.TabIndex = 17;
            this.ColumnChooser_LNK.TabStop = true;
            this.ColumnChooser_LNK.Text = "Choose Columns";
            this.ColumnChooser_LNK.VisitedLinkColor = System.Drawing.Color.Blue;
            this.ColumnChooser_LNK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CopyStyle_CB
            // 
            this.CopyStyle_CB.AutoSize = true;
            this.CopyStyle_CB.Location = new System.Drawing.Point(245, 34);
            this.CopyStyle_CB.Name = "CopyStyle_CB";
            this.CopyStyle_CB.Size = new System.Drawing.Size(184, 21);
            this.CopyStyle_CB.TabIndex = 16;
            this.CopyStyle_CB.Text = "Include Headers in Copy";
            this.CopyStyle_CB.UseVisualStyleBackColor = true;
            this.CopyStyle_CB.CheckedChanged += new System.EventHandler(this.CopyStyle_CB_CheckedChanged);
            // 
            // ProcessSG_BTN
            // 
            this.ProcessSG_BTN.Location = new System.Drawing.Point(111, 31);
            this.ProcessSG_BTN.Name = "ProcessSG_BTN";
            this.ProcessSG_BTN.Size = new System.Drawing.Size(102, 25);
            this.ProcessSG_BTN.TabIndex = 15;
            this.ProcessSG_BTN.Text = "SG Arrange";
            this.toolTip1.SetToolTip(this.ProcessSG_BTN, "This will arrange multiple security groups into seperate columns.");
            this.ProcessSG_BTN.UseVisualStyleBackColor = true;
            this.ProcessSG_BTN.Click += new System.EventHandler(this.ProcessSG_BTN_Click);
            // 
            // backgroundWorkerUpdate
            // 
            this.backgroundWorkerUpdate.WorkerReportsProgress = true;
            this.backgroundWorkerUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUpdate_DoWork);
            this.backgroundWorkerUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerUpdate_RunWorkerCompleted);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1276, 736);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "App";
            this.Text = "EC2Info";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Profile_CBB;
        private System.Windows.Forms.TextBox search_TB;
        private System.Windows.Forms.ComboBox AWSRegion_CBB;
        private System.Windows.Forms.Button Submit_BTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox AssumeRole_CBB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Tools;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Roles;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel Status_LB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button ProcessSG_BTN;
        private System.Windows.Forms.CheckBox CopyStyle_CB;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUpdate;
        private System.Windows.Forms.LinkLabel ColumnChooser_LNK;
        private System.Windows.Forms.RadioButton searchName_RB;
        private System.Windows.Forms.RadioButton searchInstance_RB;
        private System.Windows.Forms.RadioButton searchPrivateIp_RB;
        private System.Windows.Forms.CheckBox WrapCells_CB;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
    }
}

