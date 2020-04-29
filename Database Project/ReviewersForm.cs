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
    public partial class ReviewersForm : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public ReviewersForm()
        {
            InitializeComponent();
        }

        private void ReviewersForm_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=ORCL; User Id=hr;Password =hr ;";
            string cmdstr = @"select CONFRENCE.ID ,CONFRENCE.STATUS from   CONFRENCE
                             where  CONFRENCE.STATUS = :n
                                or  CONFRENCE.STATUS = :r";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("n", "waiting");
            adapter.SelectCommand.Parameters.Add("r", "modified");
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Conference Status is changed successfully :)");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
