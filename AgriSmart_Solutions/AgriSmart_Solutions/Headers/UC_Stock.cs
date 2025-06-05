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
    public partial class UC_Stock : UserControl
    {
        public UC_Stock()
        {
            InitializeComponent();
        }

        private void btn_Received_Order_Click(object sender, EventArgs e)
        {

            WindowsForm.Stock.frm_Received_Order Obj = new WindowsForm.Stock.frm_Received_Order() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
            Obj.Show();
        }



        private void btn_Current_Stock_Click(object sender, EventArgs e)
        {
            WindowsForm.Stock.frm_Current_Stock Obj = new WindowsForm.Stock.frm_Current_Stock() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Received_Order_Payment_Click(object sender, EventArgs e)
        {
            WindowsForm.Stock.frm_Received_Order_Payment Obj=new WindowsForm.Stock.frm_Received_Order_Payment() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Expiry_Stock_Details_Click(object sender, EventArgs e)
        {
            WindowsForm.Stock.frm_Expiry_Stock_Details Obj = new WindowsForm.Stock.frm_Expiry_Stock_Details() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Expired_Dispatch_Stock_Click(object sender, EventArgs e)
        {
            WindowsForm.Stock.frm_Expired_Dispatch_Stock Obj = new WindowsForm.Stock.frm_Expired_Dispatch_Stock() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
            Obj.Show();
        }
    }
}
