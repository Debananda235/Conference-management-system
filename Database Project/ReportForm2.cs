using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Database_Project
{
    public partial class ReportForm2 : Form
    {

        CrystalReport2 CR;
        public ReportForm2()
        {
            InitializeComponent();
        }

        private void ReportForm2_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport2();

            foreach (ParameterDiscreteValue V in CR.ParameterFields[1].DefaultValues)
                Place_cmb.Items.Add(V.Value);
            foreach (ParameterDiscreteValue V in CR.ParameterFields[0].DefaultValues)
                Date_cmb.Items.Add(V.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, Convert.ToDateTime(Date_cmb.Text));
            CR.SetParameterValue(1, Place_cmb.Text);
            crystalReportNumberConferences.ReportSource = CR;
        }
    }
}
