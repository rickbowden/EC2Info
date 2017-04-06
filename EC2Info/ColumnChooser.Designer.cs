namespace EC2Info
{
    partial class ColumnChooser
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
            this.OK_BTN = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Save_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OK_BTN
            // 
            this.OK_BTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_BTN.Location = new System.Drawing.Point(13, 342);
            this.OK_BTN.Name = "OK_BTN";
            this.OK_BTN.Size = new System.Drawing.Size(75, 25);
            this.OK_BTN.TabIndex = 0;
            this.OK_BTN.Text = "OK";
            this.OK_BTN.UseVisualStyleBackColor = true;
            this.OK_BTN.Click += new System.EventHandler(this.OK_BTN_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(13, 13);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(319, 310);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 1;
            // 
            // Save_BTN
            // 
            this.Save_BTN.Location = new System.Drawing.Point(104, 342);
            this.Save_BTN.Name = "Save_BTN";
            this.Save_BTN.Size = new System.Drawing.Size(119, 25);
            this.Save_BTN.TabIndex = 2;
            this.Save_BTN.Text = "Save As Default";
            this.Save_BTN.UseVisualStyleBackColor = true;
            this.Save_BTN.Click += new System.EventHandler(this.Save_BTN_Click);
            // 
            // ColumnChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(346, 395);
            this.Controls.Add(this.Save_BTN);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.OK_BTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColumnChooser";
            this.Text = "ColumnChooser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK_BTN;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Save_BTN;
    }
}