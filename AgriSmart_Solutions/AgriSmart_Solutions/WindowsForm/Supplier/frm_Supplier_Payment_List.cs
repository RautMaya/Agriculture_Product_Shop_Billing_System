using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriSmart_Solutions.WindowsForm.Supplier
{
    public partial class frm_Supplier_Payment_List : Form
    {
        public frm_Supplier_Payment_List()
        {
            InitializeComponent();
        }
        private void frm_Supplier_Payment_List_Load(object sender, EventArgs e)
        {
            if (Shared_Class.User_Role == "Admin")
            {
                Shared_Class.Bind_Grid(dgv_Supplier_Payment_Details, "Select * From Received_Order_Details");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Supplier_Payment_Details, "Select R_Order_Id,R_Order_Date,S_Name,S_Company,Total_Bill,Discount,Gst,Final_Bill,Paid_Amount From Received_Order_Details");
            }
        }

        private void cmb_SearchByMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_Grid(dgv_Supplier_Payment_Details, "Select R_Order_Id,R_Order_Date,S_Name,S_Company,Total_Bill,Discount,Gst,Final_Bill,Paid_Amount From Received_Order_Details Where Month(R_Order_Date) ='" + Convert.ToInt32((cmb_SearchByMonth.SelectedIndex) + 1) + "'");
        }

        private void cmb_SearchByYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_Grid(dgv_Supplier_Payment_Details, "Select R_Order_Id,R_Order_Date,S_Name,S_Company,Total_Bill,Discount,Gst,Final_Bill,Paid_Amount From Received_Order_Details Where Month(R_Order_Date) ='" + Convert.ToInt32((cmb_SearchByMonth.SelectedIndex) + 1) + "' and Year(R_Order_Date) = '" + Convert.ToInt32(cmb_SearchByYear.Text) + "'");
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_SearchByMonth.SelectedIndex = -1;
            cmb_SearchByYear.SelectedIndex = -1;
        }
    }
}
