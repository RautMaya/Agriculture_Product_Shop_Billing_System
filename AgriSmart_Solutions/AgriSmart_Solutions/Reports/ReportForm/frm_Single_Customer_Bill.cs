using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgriSmart_Solutions.Reports.ReportForm
{
    public partial class frm_Single_Customer_Bill : Form
    {
        public frm_Single_Customer_Bill()
        {
            InitializeComponent();
        }

        private void frm_Single_Customer_Bill_Load(object sender, EventArgs e)
        {
            Connection.Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Single_Customer_Bill", Connection.DBCon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@C_Id", Shared_Class.C_Id);

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Connection.Con_Close();

            Reports.CrystalReport.crpt_Single_Customer_Bill cr_Cust = new Reports.CrystalReport.crpt_Single_Customer_Bill();
            cr_Cust.Database.Tables["SP_Single_Customer_Bill"].SetDataSource(dtbl);

            crv_Single_Customer_Bill.ReportSource = null;

            crv_Single_Customer_Bill.ReportSource = cr_Cust;
        }
    }
}
