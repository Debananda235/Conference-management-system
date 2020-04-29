namespace Database_Project
{
    partial class Admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addConferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteConferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessReviewersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllReviewerFiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showASpecificReviewerFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAuthorsInASpecificFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessParticipantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutParticipantsWhoResevedInASpecificConferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDisplayingTheNumberOfConferencesReservedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheTotalCostAfterDiscountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conferencesToolStripMenuItem,
            this.reviewersToolStripMenuItem,
            this.authorsToolStripMenuItem,
            this.participantToolStripMenuItem,
            this.viewReportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conferencesToolStripMenuItem
            // 
            this.conferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addConferencesToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteConferencesToolStripMenuItem});
            this.conferencesToolStripMenuItem.Name = "conferencesToolStripMenuItem";
            this.conferencesToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.conferencesToolStripMenuItem.Text = "Conferences";
            this.conferencesToolStripMenuItem.Click += new System.EventHandler(this.conferencesToolStripMenuItem_Click);
            // 
            // addConferencesToolStripMenuItem
            // 
            this.addConferencesToolStripMenuItem.Name = "addConferencesToolStripMenuItem";
            this.addConferencesToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.addConferencesToolStripMenuItem.Text = "Add Conferences";
            this.addConferencesToolStripMenuItem.Click += new System.EventHandler(this.addConferencesToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.updateToolStripMenuItem.Text = "Update Conferences";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteConferencesToolStripMenuItem
            // 
            this.deleteConferencesToolStripMenuItem.Name = "deleteConferencesToolStripMenuItem";
            this.deleteConferencesToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.deleteConferencesToolStripMenuItem.Text = "Delete Conferences";
            this.deleteConferencesToolStripMenuItem.Click += new System.EventHandler(this.deleteConferencesToolStripMenuItem_Click);
            // 
            // reviewersToolStripMenuItem
            // 
            this.reviewersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessReviewersToolStripMenuItem,
            this.showAllReviewerFiToolStripMenuItem,
            this.showASpecificReviewerFieldToolStripMenuItem});
            this.reviewersToolStripMenuItem.Name = "reviewersToolStripMenuItem";
            this.reviewersToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.reviewersToolStripMenuItem.Text = "Reviewers";
            // 
            // acessReviewersToolStripMenuItem
            // 
            this.acessReviewersToolStripMenuItem.Name = "acessReviewersToolStripMenuItem";
            this.acessReviewersToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.acessReviewersToolStripMenuItem.Text = "Acess Reviewers";
            this.acessReviewersToolStripMenuItem.Click += new System.EventHandler(this.acessReviewersToolStripMenuItem_Click);
            // 
            // showAllReviewerFiToolStripMenuItem
            // 
            this.showAllReviewerFiToolStripMenuItem.Name = "showAllReviewerFiToolStripMenuItem";
            this.showAllReviewerFiToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.showAllReviewerFiToolStripMenuItem.Text = "Show all Reviewer Emails";
            this.showAllReviewerFiToolStripMenuItem.Click += new System.EventHandler(this.showAllReviewerFiToolStripMenuItem_Click);
            // 
            // showASpecificReviewerFieldToolStripMenuItem
            // 
            this.showASpecificReviewerFieldToolStripMenuItem.Name = "showASpecificReviewerFieldToolStripMenuItem";
            this.showASpecificReviewerFieldToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.showASpecificReviewerFieldToolStripMenuItem.Text = "Show a Specific Reviewer Field";
            this.showASpecificReviewerFieldToolStripMenuItem.Click += new System.EventHandler(this.showASpecificReviewerFieldToolStripMenuItem_Click);
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAuthorsInASpecificFieldsToolStripMenuItem,
            this.addAuthorsToolStripMenuItem,
            this.deleteAuthorsToolStripMenuItem,
            this.updateAuthorsToolStripMenuItem});
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.authorsToolStripMenuItem.Text = "Authors";
            // 
            // viewAuthorsInASpecificFieldsToolStripMenuItem
            // 
            this.viewAuthorsInASpecificFieldsToolStripMenuItem.Name = "viewAuthorsInASpecificFieldsToolStripMenuItem";
            this.viewAuthorsInASpecificFieldsToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.viewAuthorsInASpecificFieldsToolStripMenuItem.Text = "View Authors in a specific fields";
            this.viewAuthorsInASpecificFieldsToolStripMenuItem.Click += new System.EventHandler(this.viewAuthorsInASpecificFieldsToolStripMenuItem_Click);
            // 
            // addAuthorsToolStripMenuItem
            // 
            this.addAuthorsToolStripMenuItem.Name = "addAuthorsToolStripMenuItem";
            this.addAuthorsToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.addAuthorsToolStripMenuItem.Text = "Add Authors";
            this.addAuthorsToolStripMenuItem.Click += new System.EventHandler(this.addAuthorsToolStripMenuItem_Click);
            // 
            // deleteAuthorsToolStripMenuItem
            // 
            this.deleteAuthorsToolStripMenuItem.Name = "deleteAuthorsToolStripMenuItem";
            this.deleteAuthorsToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.deleteAuthorsToolStripMenuItem.Text = "Delete Authors";
            this.deleteAuthorsToolStripMenuItem.Click += new System.EventHandler(this.deleteAuthorsToolStripMenuItem_Click);
            // 
            // updateAuthorsToolStripMenuItem
            // 
            this.updateAuthorsToolStripMenuItem.Name = "updateAuthorsToolStripMenuItem";
            this.updateAuthorsToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.updateAuthorsToolStripMenuItem.Text = "Update Authors";
            this.updateAuthorsToolStripMenuItem.Click += new System.EventHandler(this.updateAuthorsToolStripMenuItem_Click);
            // 
            // participantToolStripMenuItem
            // 
            this.participantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessParticipantToolStripMenuItem});
            this.participantToolStripMenuItem.Name = "participantToolStripMenuItem";
            this.participantToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.participantToolStripMenuItem.Text = "Participant";
            this.participantToolStripMenuItem.Click += new System.EventHandler(this.participantToolStripMenuItem_Click);
            // 
            // acessParticipantToolStripMenuItem
            // 
            this.acessParticipantToolStripMenuItem.Name = "acessParticipantToolStripMenuItem";
            this.acessParticipantToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.acessParticipantToolStripMenuItem.Text = "Acess Participant Data";
            this.acessParticipantToolStripMenuItem.Click += new System.EventHandler(this.acessParticipantToolStripMenuItem_Click);
            // 
            // viewReportsToolStripMenuItem
            // 
            this.viewReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutParticipantsWhoResevedInASpecificConferenceToolStripMenuItem,
            this.aboutDisplayingTheNumberOfConferencesReservedToolStripMenuItem,
            this.aboutTheTotalCostAfterDiscountToolStripMenuItem});
            this.viewReportsToolStripMenuItem.Name = "viewReportsToolStripMenuItem";
            this.viewReportsToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.viewReportsToolStripMenuItem.Text = "View Reports";
            // 
            // aboutParticipantsWhoResevedInASpecificConferenceToolStripMenuItem
            // 
            this.aboutParticipantsWhoResevedInASpecificConferenceToolStripMenuItem.Name = "aboutParticipantsWhoResevedInASpecificConferenceToolStripMenuItem";
            this.aboutParticipantsWhoResevedInASpecificConferenceToolStripMenuItem.Size = new System.Drawing.Size(451, 26);
            this.aboutParticipantsWhoResevedInASpecificConferenceToolStripMenuItem.Text = "about participants who reseved in a specific conference";
            this.aboutParticipantsWhoResevedInASpecificConferenceToolStripMenuItem.Click += new System.EventHandler(this.aboutParticipantsWhoResevedInASpecificConferenceToolStripMenuItem_Click);
            // 
            // aboutDisplayingTheNumberOfConferencesReservedToolStripMenuItem
            // 
            this.aboutDisplayingTheNumberOfConferencesReservedToolStripMenuItem.Name = "aboutDisplayingTheNumberOfConferencesReservedToolStripMenuItem";
            this.aboutDisplayingTheNumberOfConferencesReservedToolStripMenuItem.Size = new System.Drawing.Size(451, 26);
            this.aboutDisplayingTheNumberOfConferencesReservedToolStripMenuItem.Text = "about displaying the number of conferences reserved";
            this.aboutDisplayingTheNumberOfConferencesReservedToolStripMenuItem.Click += new System.EventHandler(this.aboutDisplayingTheNumberOfConferencesReservedToolStripMenuItem_Click);
            // 
            // aboutTheTotalCostAfterDiscountToolStripMenuItem
            // 
            this.aboutTheTotalCostAfterDiscountToolStripMenuItem.Name = "aboutTheTotalCostAfterDiscountToolStripMenuItem";
            this.aboutTheTotalCostAfterDiscountToolStripMenuItem.Size = new System.Drawing.Size(451, 26);
            this.aboutTheTotalCostAfterDiscountToolStripMenuItem.Text = "about the total cost after discount";
            this.aboutTheTotalCostAfterDiscountToolStripMenuItem.Click += new System.EventHandler(this.aboutTheTotalCostAfterDiscountToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome to the Admin Page : )";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addConferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteConferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessReviewersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAuthorsInASpecificFieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessParticipantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutParticipantsWhoResevedInASpecificConferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDisplayingTheNumberOfConferencesReservedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheTotalCostAfterDiscountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllReviewerFiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showASpecificReviewerFieldToolStripMenuItem;
    }
}