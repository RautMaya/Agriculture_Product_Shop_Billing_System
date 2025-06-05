using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriSmart_Solutions.WindowsForm.ReportMaster
{
    public partial class frm_Report : Form
    {
        public frm_Report()
        {
            InitializeComponent();
        }

        private void btn_Customer_Bills_Datewise_Report_Click(object sender, EventArgs e)
        {
            Reports.ReportForm.frm_Customer_Bill_Report_Datewise Obj = new Reports.ReportForm.frm_Customer_Bill_Report_Datewise();
            Obj.Show();
        }

        private void btn_Expence_Datewise_Report_Click(object sender, EventArgs e)
        {
            Reports.ReportForm.frm_Expence_Report_Datewise Obj = new Reports.ReportForm.frm_Expence_Report_Datewise();
            Obj.Show();
        }

        private void btn_Monthly_Stock_Updates_Report_Click(object sender, EventArgs e)
        {
            Reports.ReportForm.frm_Monthly_Stock_Report Obj = new Reports.ReportForm.frm_Monthly_Stock_Report();
            Obj.Show();
        }

        private void btn_Product_List_Report_Click(object sender, EventArgs e)
        {
            Reports.ReportForm.frm_Product_List_Report Obj = new Reports.ReportForm.frm_Product_List_Report();
            Obj.Show();
        }
    }
}
