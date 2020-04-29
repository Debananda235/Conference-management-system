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
    public partial class AddAuthorForm : Form
    {
        public string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public AddAuthorForm()
        {
            InitializeComponent();
        }

        private void AddAuthorForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into AUTHORS values (:Fname,:Lname,:UserName,:Email,:Password)";
                cmd.Parameters.Add("Fname", textBox1.Text);
                cmd.Parameters.Add("Lname", textBox2.Text);
                cmd.Parameters.Add("UserName", textBox3.Text);
                cmd.Parameters.Add("Email", textBox4.Text);
                cmd.Parameters.Add("Password", textBox5.Text);
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {

                    MessageBox.Show("New Author is added");
                }
            }
            catch
            {
                MessageBox.Show("This Author is already exist :) ");

            }
        }
    }
}
