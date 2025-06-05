using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriSmart_Solutions.WindowsForm.Expence
{
    public partial class frm_Shop_Expence_Details : Form
    {
        public frm_Shop_Expence_Details()
        {
            InitializeComponent();
        }

        private void frm_Shop_Expence_Details_Load(object sender, EventArgs e)
        {
            if (Shared_Class.User_Role == "Admin")
            {
                Shared_Class.Bind_Grid(dgv_Expence_Details, "Select Exp_Id,Exp_Date,Exp_Details,Total_Amount,Payment_Media,Paid_By,User_Login,Status From Expence_Details");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Expence_Details, "Select Exp_Id,Exp_Date,Exp_Details,Total_Amount,Payment_Media From Expence_Details");
            }
        }

        private void cmb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_Grid(dgv_Expence_Details, "Select Exp_Id,Exp_Date,Exp_Details,Total_Amount,Payment_Media From Expence_Details Where Month(Exp_Date) ='" + Convert.ToInt32((cmb_SearchByMonth.SelectedIndex) + 1) + "'");
        }

        private void cmb_SearchByYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_Grid(dgv_Expence_Details, "Select Exp_Id,Exp_Date,Exp_Details,Total_Amount,Payment_Media From Expence_Details Where Month(Exp_Date) ='" + Convert.ToInt32((cmb_SearchByMonth.SelectedIndex) + 1) + "' and Year(Exp_Date) = '" + Convert.ToInt32(cmb_SearchByYear.Text) + "'");
        }
    }
}
