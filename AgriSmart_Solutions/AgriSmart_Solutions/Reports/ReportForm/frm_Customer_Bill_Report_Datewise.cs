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
    public partial class frm_Customer_Bill_Report_Datewise : Form
    {
        public frm_Customer_Bill_Report_Datewise()
        {
            InitializeComponent();
        }

        void Bind_Report(DateTime Start, DateTime End)
        {
            Connection.Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Customer_Details", Connection.DBCon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@SDate", Start);
            sqlDa.SelectCommand.Parameters.AddWithValue("@EDate", End);

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Connection.Con_Close();

            Reports.CrystalReport.crpt_Customer_Bill_Datewise_Report cr_Cust = new Reports.CrystalReport.crpt_Customer_Bill_Datewise_Report();
            cr_Cust.Database.Tables["SP_Customer_Details"].SetDataSource(dtbl);

            crv_Customer_Bill_Datewise_Report.ReportSource = null;

            crv_Customer_Bill_Datewise_Report.ReportSource = cr_Cust;
        }
        private void frm_Customer_Bill_Report_Datewise_Load(object sender, EventArgs e)
        {
            dtp_Start_Date.Value = new DateTime(System.DateTime.Today.Year, System.DateTime.Today.Month, 1);

            Bind_Report(dtp_Start_Date.Value.Date, dtp_End_Date.Value.Date);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Bind_Report(dtp_Start_Date.Value.Date, dtp_End_Date.Value.Date);
        }
    }
}
