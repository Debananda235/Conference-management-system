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
    public partial class ParticipantForm : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        OracleDataAdapter adapter1;
        OracleCommandBuilder builder1;
        int chour = DateTime.Now.Hour;
        int cmin = DateTime.Now.Minute;
        public ParticipantForm()
        {
            InitializeComponent();
        }

        private void ParticipantForm_Load(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            string constr = "Data Source=ORCL; User Id=hr;Password =hr ;";
            string cmdstr = @"select ID,CONFERENCE_DATE,START_TIME,FIELD,PLACE,ROOM_ID from CONFRENCE 
                             where CONFRENCE.CONFERENCE_DATE  >= TRUNC(current_date)";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            //for time checking
            int num_of_rows = dataGridView1.Rows.Count;
            int i = 0;
            for (int j = 0; j < num_of_rows; j++)
            {
                string[] str = dataGridView1["START_TIME", i].Value.ToString().Split(':');
                string[] str2 = dataGridView1["CONFERENCE_DATE", i].Value.ToString().Split('/', ' ');

                //if same day but starttime has ended
                if ((str2[1] == DateTime.Now.Day.ToString() && str2[0] == DateTime.Now.Month.ToString() && str2[2] == DateTime.Now.Year.ToString())
                    && (Int32.Parse(str[0]) < chour || (Int32.Parse(str[0]) == chour && Int32.Parse(str[1]) < cmin)))
                {
                    DataGridViewRow dgvDelRow = dataGridView1.Rows[i];
                    dataGridView1.Rows.Remove(dgvDelRow);
                }
                else i++;
            }
            dataGridView1.Refresh();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            builder1 = new OracleCommandBuilder(adapter1);
            adapter1.Update(ds.Tables[0]);
            MessageBox.Show("Reservation is done successfully :)");
            }
            catch
            {
                MessageBox.Show("You already reserved this conference :)");
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
                dataGridView1.CurrentRow.Selected = true;
                int id = int.Parse(dataGridView1["ID", dataGridView1.CurrentRow.Index].Value.ToString());
                string constr = "Data Source=ORCL; User Id=hr;Password =hr ;";
                string cmdstr = @"select ID,EMAIL from RESERVECONFRENCE
                                where RESERVECONFRENCE.ID = null";
                adapter1 = new OracleDataAdapter(cmdstr, constr);
                ds = new DataSet();
                adapter1.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];

                DataRow drToAdd = ds.Tables[0].NewRow();

                drToAdd["ID"] = id;
                drToAdd["EMAIL"] = Reg_log.logged_email;

                ds.Tables[0].Rows.Add(drToAdd);
        }
    }
}
