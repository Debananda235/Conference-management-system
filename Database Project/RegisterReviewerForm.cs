using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Database_Project
{
    public partial class RegisterReviewerForm : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection con;
        public RegisterReviewerForm()
        {
            InitializeComponent();
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into REVIEWERS values (:Fname,:Lname,:UserName,:Email,:Password)";
            cmd.Parameters.Add("Fname", textBox1.Text);
            cmd.Parameters.Add("Lname", textBox2.Text);
            cmd.Parameters.Add("UserName", textBox3.Text);
            cmd.Parameters.Add("Email", textBox4.Text);
            cmd.Parameters.Add("Password", textBox5.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("New Reviwer is added");
            }
        }
    }
}
