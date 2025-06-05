using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriSmart_Solutions.Headers
{
    public partial class UC_Expence : UserControl
    {
        public UC_Expence()
        {
            InitializeComponent();
        }

        private void btn_Shop_Expence_Click(object sender, EventArgs e)
        {
            WindowsForm.Expence.frm_Shop_Expence Obj = new WindowsForm.Expence.frm_Shop_Expence() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Shop_Expence_Details_Click(object sender, EventArgs e)
        {
            WindowsForm.Expence.frm_Shop_Expence_Details Obj = new WindowsForm.Expence.frm_Shop_Expence_Details() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Show_Payment_Receipt_Click(object sender, EventArgs e)
        {
            WindowsForm.Expence.frm_Show_Bill_Image Obj = new WindowsForm.Expence.frm_Show_Bill_Image() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
            Obj.Show();
        }
    }
}
