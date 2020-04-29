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
    public partial class DeleteAuthorForm : Form
    {
        public string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public DeleteAuthorForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "Delete from AUTHORS where Email=:Email";
            c.Parameters.Add("Email", txt_email.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Actor deleted");
                txt_email.Text = "";
            }
        }

        private void DeleteAuthorForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }
}
