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
    public partial class ShowSpecificReviewerFieldForm : Form
    {
        public string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public ShowSpecificReviewerFieldForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select field from REVIEWERfield where Email=:email";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("email", textBox1.Text);
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[0].ToString();

            }
            dr.Close();
        }

        private void ShowSpecificReviewerFieldForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }
}
