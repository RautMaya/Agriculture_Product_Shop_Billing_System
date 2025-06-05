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
    public partial class frm_Supplier_List : Form
    {
        public frm_Supplier_List()
        {
            InitializeComponent();
        }

        private void frm_Supplier_List_Load(object sender, EventArgs e)
        {
            if(Shared_Class.User_Role == "Admin")
            {
                Shared_Class.Bind_Grid(dgv_Supplier_Details, "Select * From Supplier_Details");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Supplier_Details, "Select Sup_Id,Sup_Name,Sup_Address,Sup_Added_Date,Mob_No,Sup_Company,Company_Address,Aadhar_No,Email_Id,Bank_Details,Account_No,Note From Supplier_Details");
            }
        }

        private void cmb_SearchByMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_Grid(dgv_Supplier_Details, "Select Sup_Id,Sup_Name,Sup_Address,Sup_Added_Date,Mob_No,Sup_Company,Company_Address,Aadhar_No,Email_Id,Bank_Details,Account_No,Note From Supplier_Details Where Month(Sup_Added_Date) ='" + Convert.ToInt32((cmb_SearchByMonth.SelectedIndex) + 1) + "'");
        }

        private void cmb_SearchByYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_Grid(dgv_Supplier_Details, "Select Sup_Id,Sup_Name,Sup_Address,Sup_Added_Date,Mob_No,Sup_Company,Company_Address,Aadhar_No,Email_Id,Bank_Details,Account_No,Note From Supplier_Details Where Month(Sup_Added_Date) ='" + Convert.ToInt32((cmb_SearchByMonth.SelectedIndex) + 1) + "' and Year(Sup_Added_Date) = '" + Convert.ToInt32(cmb_SearchByYear.Text) +"'");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_SearchByMonth.SelectedIndex = -1;
            cmb_SearchByYear.SelectedIndex = -1;
        }
    }
}
