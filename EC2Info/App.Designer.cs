namespace EC2Info
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
            this.Profile_CBB = new System.Windows.Forms.ComboBox();
            this.search_TB = new System.Windows.Forms.TextBox();
            this.AWSRegion_CBB = new System.Windows.Forms.ComboBox();
            this.Submit_BTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Role_RB = new System.Windows.Forms.RadioButton();
            this.Profile_RB = new System.Windows.Forms.RadioButton();
            this.AssumeRole_CBB = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Roles = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.Status_LB = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Profile_CBB
            // 
            this.Profile_CBB.FormattingEnabled = true;
            this.Profile_CBB.Location = new System.Drawing.Point(102, 27);
            this.Profile_CBB.Name = "Profile_CBB";
            this.Profile_CBB.Size = new System.Drawing.Size(271, 24);
            this.Profile_CBB.Sorted = true;
            this.Profile_CBB.TabIndex = 2;
            this.Profile_CBB.Text = "select a role";
            // 
            // search_TB
            // 
            this.search_TB.Location = new System.Drawing.Point(18, 194);
            this.search_TB.Name = "search_TB";
            this.search_TB.Size = new System.Drawing.Size(809, 22);
            this.search_TB.TabIndex = 5;
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
            this.Submit_BTN.Location = new System.Drawing.Point(12, 234);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(75, 23);
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
            this.groupBox2.Controls.Add(this.Role_RB);
            this.groupBox2.Controls.Add(this.Profile_RB);
            this.groupBox2.Controls.Add(this.AssumeRole_CBB);
            this.groupBox2.Controls.Add(this.Profile_CBB);
            this.groupBox2.Location = new System.Drawing.Point(281, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 71);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Authentication:";
            // 
            // Role_RB
            // 
            this.Role_RB.AutoSize = true;
            this.Role_RB.Location = new System.Drawing.Point(430, 28);
            this.Role_RB.Name = "Role_RB";
            this.Role_RB.Size = new System.Drawing.Size(116, 21);
            this.Role_RB.TabIndex = 7;
            this.Role_RB.Text = "Assume Role:";
            this.Role_RB.UseVisualStyleBackColor = true;
            // 
            // Profile_RB
            // 
            this.Profile_RB.AutoSize = true;
            this.Profile_RB.Checked = true;
            this.Profile_RB.Location = new System.Drawing.Point(19, 27);
            this.Profile_RB.Name = "Profile_RB";
            this.Profile_RB.Size = new System.Drawing.Size(73, 21);
            this.Profile_RB.TabIndex = 6;
            this.Profile_RB.TabStop = true;
            this.Profile_RB.Text = "Profile:";
            this.Profile_RB.UseVisualStyleBackColor = true;
            // 
            // AssumeRole_CBB
            // 
            this.AssumeRole_CBB.FormattingEnabled = true;
            this.AssumeRole_CBB.Location = new System.Drawing.Point(552, 27);
            this.AssumeRole_CBB.Name = "AssumeRole_CBB";
            this.AssumeRole_CBB.Size = new System.Drawing.Size(399, 24);
            this.AssumeRole_CBB.Sorted = true;
            this.AssumeRole_CBB.TabIndex = 5;
            this.AssumeRole_CBB.Text = "none";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Tools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
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
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1276, 736);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Submit_BTN);
            this.Controls.Add(this.search_TB);
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
        private System.Windows.Forms.RadioButton Role_RB;
        private System.Windows.Forms.RadioButton Profile_RB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Tools;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Roles;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel Status_LB;
    }
}

