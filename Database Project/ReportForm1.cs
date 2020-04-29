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
    public partial class ReportForm1 : Form
    {
        CrystalReport1 CR;
        public ReportForm1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, Field_cmb.Text);
            CR.SetParameterValue(1, Convert.ToDateTime(Date_cmb.Text));
            crystalReportViewer1.ReportSource = CR;
        }

        private void ReportForm1_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();

            foreach (ParameterDiscreteValue V in CR.ParameterFields[0].DefaultValues)
                Field_cmb.Items.Add(V.Value);
        }
    }
}
