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
    public partial class UpdateConferencesForm : Form
    {

        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection con;


        public UpdateConferencesForm()
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
            C.Parameters.Add("f", comboBox1.SelectedItem.ToString());
            C.Parameters.Add("ID", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = C.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);
            }

            dr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand C = new OracleCommand();
            C.Connection = con;
            C.CommandText = "selectSpecificCON";
            C.CommandType = CommandType.StoredProcedure;
            C.Parameters.Add("id", comboBox2.SelectedItem.ToString());
            C.Parameters.Add("ST", OracleDbType.Int64, ParameterDirection.Output);
            C.Parameters.Add("ET", OracleDbType.Int64, ParameterDirection.Output);
            C.ExecuteNonQuery();
            textBox1.Text = C.Parameters["ST"].Value.ToString();
            textBox2.Text = C.Parameters["ET"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand C = new OracleCommand();
            C.Connection = con;
            C.CommandText = "updatetime";
            C.CommandType = CommandType.StoredProcedure;
            C.Parameters.Add("id", comboBox2.SelectedItem.ToString());
            C.Parameters.Add("ST", textBox1.Text);
            C.Parameters.Add("ET", textBox2.Text);
            C.ExecuteNonQuery();
            MessageBox.Show("Updated");
        }

        private void UpdateConferencesForm_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select distinct Field from confrence";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
        }
    }
}
