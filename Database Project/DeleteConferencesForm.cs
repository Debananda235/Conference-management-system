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
    public partial class DeleteConferencesForm : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection con;

        public DeleteConferencesForm()
        {
            InitializeComponent();
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand C = new OracleCommand();
            C.Connection = con;
            C.CommandText = "getconferenceID";
            C.CommandType = CommandType.StoredProcedure;
            C.Parameters.Add("f", comboBox2.SelectedItem.ToString());
            C.Parameters.Add("ID", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = C.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }

            dr.Close();
        }

        private void DeleteConferencesForm_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select distinct Field from CONFRENCE"; 
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand C = new OracleCommand();
            C.Connection = con;
            C.CommandText = "deletecon";
            C.CommandType = CommandType.StoredProcedure;
            C.Parameters.Add("id", comboBox1.SelectedItem.ToString());
            C.ExecuteNonQuery();
            MessageBox.Show("deleted");
        }
    }
}
