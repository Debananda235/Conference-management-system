namespace Database_Project
{
    partial class ReportForm2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Date_cmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Place_cmb = new System.Windows.Forms.ComboBox();
            this.crystalReportNumberConferences = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.Location = new System.Drawing.Point(498, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(846, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date:";
            // 
            // Date_cmb
            // 
            this.Date_cmb.FormattingEnabled = true;
            this.Date_cmb.Location = new System.Drawing.Point(949, 37);
            this.Date_cmb.Name = "Date_cmb";
            this.Date_cmb.Size = new System.Drawing.Size(206, 24);
            this.Date_cmb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(120, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Place:";
            // 
            // Place_cmb
            // 
            this.Place_cmb.FormattingEnabled = true;
            this.Place_cmb.Location = new System.Drawing.Point(223, 37);
            this.Place_cmb.Name = "Place_cmb";
            this.Place_cmb.Size = new System.Drawing.Size(206, 24);
            this.Place_cmb.TabIndex = 6;
            // 
            // crystalReportNumberConferences
            // 
            this.crystalReportNumberConferences.ActiveViewIndex = -1;
            this.crystalReportNumberConferences.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportNumberConferences.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportNumberConferences.Location = new System.Drawing.Point(12, 150);
            this.crystalReportNumberConferences.Name = "crystalReportNumberConferences";
            this.crystalReportNumberConferences.Size = new System.Drawing.Size(1262, 682);
            this.crystalReportNumberConferences.TabIndex = 8;
            // 
            // ReportForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 844);
            this.Controls.Add(this.crystalReportNumberConferences);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Place_cmb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date_cmb);
            this.Name = "ReportForm2";
            this.Text = "ReportForm2";
            this.Load += new System.EventHandler(this.ReportForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Date_cmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Place_cmb;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportNumberConferences;
    }
}