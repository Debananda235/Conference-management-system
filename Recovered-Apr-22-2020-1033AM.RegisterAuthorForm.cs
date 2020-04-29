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
    public partial class RegisterAuthorForm : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection con;
        public RegisterAuthorForm()
        {
            InitializeComponent();
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Email from AUTHORS where Email = :Email";
            cmd.CommandType = CommandType.Text;
            int count = 0;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                count++;
            }
            if (count == 0)
            {
                cmd.CommandText = "insert into AUTHORS values (:Fname,:Lname,:UserName,:Email,:Password)";
                cmd.Parameters.Add("Fname", txt_fname.Text);
                cmd.Parameters.Add("Lname", txt_lname.Text);
                cmd.Parameters.Add("UserName", txt_username.Text);
                cmd.Parameters.Add("Email", txt_email.Text);
                cmd.Parameters.Add("Password", txt_password.Text);
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {

                    MessageBox.Show("New Author is added");
                }
            }
            else
                MessageBox.Show("Email is already taken");

            dr.Close();
        }
    }
}
