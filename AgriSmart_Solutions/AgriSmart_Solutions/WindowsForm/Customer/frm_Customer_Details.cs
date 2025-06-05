using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriSmart_Solutions.WindowsForm.Customer
{
    public partial class frm_Customer_Details : Form
    {
        public frm_Customer_Details()
        {
            InitializeComponent();
        }

        /*void bind_grid()
        {
            int C_Month = cmb_SearchByMonth.SelectedIndex + 1;
            int C_Year = Convert.ToInt32(cmb_SearchByYear.Text);

            Shared_Class.Bind_Grid(dgv_Customer_Details, "Select Bill_Id,Bill_Date,C_Name,Address,Mobile_No,Total_Bill,Discount,Gst,Final_Bill,Payment_Media From Customer_Details Where Month(Bill_Date) = " + C_Month + " And Year(Bill_Date) " + C_Year + "");
        }
        */
        private void frm_Customer_Details_Load(object sender, EventArgs e)
        {
            btn_Refresh.PerformClick();
            ///cmb_SearchByMonth.SelectedIndex = System.DateTime.Today.Month;
            ///cmb_SearchByYear.SelectedIndex = System.DateTime.Today.Year;
        }

        private void cmb_SearchByMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int C_Month = cmb_SearchByMonth.SelectedIndex + 1;
            int C_Year = Convert.ToInt32(cmb_SearchByYear.Text);
            Shared_Class.Bind_Grid(dgv_Customer_Details, "Select Bill_Id,Bill_Date,C_Name,Address,Mobile_No,Total_Bill,Discount,Gst,Final_Bill,Payment_Media From Customer_Details Where Month(Bill_Date) ='" + Convert.ToInt32((cmb_SearchByMonth.SelectedIndex) + 1) + "' and Year(Bill_Date) = '" + Convert.ToInt32(cmb_SearchByYear.Text) + "'");
           /// Shared_Class.Bind_Grid(dgv_Customer_Details, "Select Bill_Id,Bill_Date,C_Name,Address,Mobile_No,Total_Bill,Discount,Gst,Final_Bill,Payment_Media From Customer_Details Where Month(Bill_Date) = " + C_Month + " And Year(Bill_Date) " + C_Year + "");
        }

        private void cmb_SearchByYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int C_Month = cmb_SearchByMonth.SelectedIndex + 1;
            int C_Year = Convert.ToInt32(cmb_SearchByYear.Text);

            Shared_Class.Bind_Grid(dgv_Customer_Details, "Select Bill_Id,Bill_Date,C_Name,Address,Mobile_No,Total_Bill,Discount,Gst,Final_Bill,Payment_Media From Customer_Details Where Month(Bill_Date) ='" + Convert.ToInt32((cmb_SearchByMonth.SelectedIndex) + 1) + "' and Year(Bill_Date) = '" + Convert.ToInt32(cmb_SearchByYear.Text) + "'");
            // Shared_Class.Bind_Grid(dgv_Customer_Details, "Select Bill_Id,Bill_Date,C_Name,Address,Mobile_No,Total_Bill,Discount,Gst,Final_Bill,Payment_Media From Customer_Details Where Month(Bill_Date) = " + C_Month + " And Year(Bill_Date) " + C_Year + "");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            int C_Month = System.DateTime.Today.Month;
            int C_Year = System.DateTime.Today.Year;

            cmb_SearchByYear.Text = Convert.ToString(C_Year);
            cmb_SearchByMonth.SelectedIndex = C_Month - 1;

            Shared_Class.Bind_Grid(dgv_Customer_Details, "Select Bill_Id,Bill_Date,C_Name,Address,Mobile_No,Total_Bill,Discount,Gst,Final_Bill,Payment_Media From Customer_Details Where Month(Bill_Date) ='" + Convert.ToInt32((cmb_SearchByMonth.SelectedIndex) + 1) + "' and Year(Bill_Date) = '" + Convert.ToInt32(cmb_SearchByYear.Text) + "'");

            ///Shared_Class.Bind_Grid(dgv_Customer_Details, "Select Bill_Id,Bill_Date,C_Name,Address,Mobile_No,Total_Bill,Discount,Gst,Final_Bill,Payment_Media From Customer_Details Where Month(Bill_Date) = " + C_Month + " And Year(Bill_Date) " + C_Year + "");
        }

        private void dgv_Customer_Details_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ///Shared_Class.C_Id = Convert.ToInt32(dgv_Customer_Details.CurrentRow.Cells[0].Value);

            ///Reports.ReportForm.frm_Single_Customer_Bill Obj = new Reports.ReportForm.frm_Single_Customer_Bill();
            ///Obj.Show();
        }

        private void dgv_Customer_Details_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Shared_Class.C_Id = Convert.ToInt32(dgv_Customer_Details.CurrentRow.Cells[0].Value);

            Reports.ReportForm.frm_Single_Customer_Bill Obj = new Reports.ReportForm.frm_Single_Customer_Bill();
            Obj.Show();
        }
    }
}
