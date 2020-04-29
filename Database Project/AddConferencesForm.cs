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
    public partial class AddConferencesForm : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection con;
        public AddConferencesForm()
        {
            InitializeComponent();
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxid , newid;
            OracleCommand CC = new OracleCommand();
            CC.Connection = con;
            CC.CommandText = "selectmaxid";
            CC.CommandType = CommandType.StoredProcedure;
            CC.Parameters.Add("id", OracleDbType.Int32,ParameterDirection.Output);
            CC.ExecuteNonQuery();
            try
            {
                maxid = Convert.ToInt32(CC.Parameters["id"].Value.ToString());
                newid = maxid + 1;
            }
            catch
            {
                newid = 1;
            }
                OracleCommand C = new OracleCommand();
                C.Connection = con;
                C.CommandText = "insertconference";
                C.CommandType = CommandType.StoredProcedure;
                C.Parameters.Add("id",  newid);
                C.Parameters.Add("condate", Convert.ToDateTime(textBox2.Text));
                C.Parameters.Add("ST", textBox3.Text);
                C.Parameters.Add("ET", textBox4.Text);
                C.Parameters.Add("FIELD", textBox1.Text);
                C.Parameters.Add("Place", textBox5.Text);
                C.Parameters.Add("ROOMID", int.Parse(textBox6.Text));
                C.Parameters.Add("TITLE", textBox7.Text);
                C.Parameters.Add("Authorusername", comboBox1.SelectedItem);
                C.Parameters.Add("ReviewerEmail", comboBox2.SelectedItem);
                C.Parameters.Add("Cost",   int.Parse(textBox9.Text));
                C.ExecuteNonQuery();
                MessageBox.Show("added");
           
        }

        private void AddConferencesForm_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select username from Authors";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();

            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "select email from Reviewers";
            c.CommandType = CommandType.Text;
            OracleDataReader dr2 = c.ExecuteReader();
            while (dr2.Read())
            {
                comboBox2.Items.Add(dr2[0]);
            }
            dr2.Close();

        }
    }
}