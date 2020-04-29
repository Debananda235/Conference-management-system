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
    public partial class ReportForm3 : Form
    {
        CrystalReport3 CR;
        public ReportForm3()
        {
            InitializeComponent();
        }
        private void ReportForm3_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport3();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, Convert.ToDateTime(Date_cmb.Text));
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
