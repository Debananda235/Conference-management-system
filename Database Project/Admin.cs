using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void conferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateConferencesForm C = new UpdateConferencesForm();
            C.Show();
        }

        private void addConferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddConferencesForm C = new AddConferencesForm();
            C.Show();
        }

        private void deleteConferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteConferencesForm C = new DeleteConferencesForm();
            C.Show();
        }

        private void participantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acessReviewersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccessReviewersForm AR = new AccessReviewersForm();
            AR.Show();
        }

        private void acessParticipantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccessParticipantForm AP = new AccessParticipantForm();
            AP.Show();
        }

        private void viewAuthorsInASpecificFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAuthorsForm VA = new ViewAuthorsForm();
            VA.Show();
        }

        private void aboutDisplayingTheNumberOfConferencesReservedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm2 R1 = new ReportForm2();
            R1.Show();
        }

        private void aboutParticipantsWhoResevedInASpecificConferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm1 R2 = new ReportForm1();
            R2.Show();
        }

        private void aboutTheTotalCostAfterDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm3 R3 = new ReportForm3();
            R3.Show();
        }

        private void addAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAuthorForm R3 = new AddAuthorForm();
            R3.Show();
        }

        private void deleteAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAuthorForm R3 = new DeleteAuthorForm();
            R3.Show();
        }

        private void updateAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAuthorForm R3 = new UpdateAuthorForm();
            R3.Show();
        }

        private void showAllReviewerFiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowallEmailsReviewerForm R3 = new ShowallEmailsReviewerForm();
            R3.Show();
        }

        private void showASpecificReviewerFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSpecificReviewerFieldForm R3 = new ShowSpecificReviewerFieldForm();
            R3.Show();
        }
    }
}
