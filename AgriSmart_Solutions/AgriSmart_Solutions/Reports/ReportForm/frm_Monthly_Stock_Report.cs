using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriSmart_Solutions.Reports.ReportForm
{
    public partial class frm_Monthly_Stock_Report : Form
    {
        public frm_Monthly_Stock_Report()
        {
            InitializeComponent();
        }

        void Bind_Report(int Month, int Year)
        {
            Connection.Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Monthly_Stock_Report", Connection.DBCon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Month", Month);
            sqlDa.SelectCommand.Parameters.AddWithValue("@Year", Year);

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Connection.Con_Close();

            Reports.CrystalReport.crpt_Monthly_Stock_Report cr_Stock = new Reports.CrystalReport.crpt_Monthly_Stock_Report();
            cr_Stock.Database.Tables["SP_Monthly_Stock_Report"].SetDataSource(dtbl);

            crv_Monthly_Stock_Report.ReportSource = null;

            crv_Monthly_Stock_Report.ReportSource = cr_Stock;
        }
        private void frm_Monthly_Stock_Report_Load(object sender, EventArgs e)
        {
            btn_Refresh.PerformClick();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            int C_Month = System.DateTime.Today.Month;
            int C_Year = System.DateTime.Today.Year;

            cmb_SearchByYear.Text = Convert.ToString(C_Year);
            cmb_SearchByMonth.SelectedIndex = C_Month - 1;

            Bind_Report(C_Month, C_Year);
            
        }

        private void cmb_SearchByMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int C_Month = cmb_SearchByMonth.SelectedIndex + 1;
            int C_Year = Convert.ToInt32(cmb_SearchByYear.Text);

            Bind_Report(C_Month, C_Year);
        }

        private void cmb_SearchByYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int C_Month = cmb_SearchByMonth.SelectedIndex + 1;
            int C_Year = Convert.ToInt32(cmb_SearchByYear.Text);

            Bind_Report(C_Month, C_Year);
        }
    }
}
