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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string select = this.comboBox1.SelectedItem.ToString();
            switch (select)
            {
                case "Reviewer":
                    {

                        RegisterReviewerForm RF = new RegisterReviewerForm();
                        RF.Show();
                        break;
                    }
                case "Participant":
                    {
                        RegisterParticipantForm PF = new RegisterParticipantForm();
                        PF.Show();

                        break;
                    }
                case "Author":
                    {
                        RegisterAuthorForm AF = new RegisterAuthorForm();
                        AF.Show();
                        break;
                    }
            }
        }
    }
}
