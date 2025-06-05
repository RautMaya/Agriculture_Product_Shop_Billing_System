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
    public partial class frm_Product_List_Report : Form
    {
        public frm_Product_List_Report()
        {
            InitializeComponent();
        }

        private void frm_Product_List_Report_Load(object sender, EventArgs e)
        {
            Connection.Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Product_List_Report", Connection.DBCon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Connection.Con_Close();

            Reports.CrystalReport.crpt_Product_List_Report cr_Product = new CrystalReport.crpt_Product_List_Report();
            cr_Product.Database.Tables["SP_Product_List_Report"].SetDataSource(dtbl);

            crv_Product_List_Report.ReportSource = null;

            crv_Product_List_Report.ReportSource = cr_Product;
        }
    }
}
