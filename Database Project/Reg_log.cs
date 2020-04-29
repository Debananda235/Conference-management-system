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
    public partial class Reg_log : Form
    {
        public static string logged_email = "";
        public Reg_log()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm L = new LoginForm();
            L.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm RF = new RegisterForm();
            RF.Show();
        }
    }
}
