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
    public partial class UC_Customer : UserControl
    {
        public UC_Customer()
        {
            InitializeComponent();
        }


        

        private void btn_Customer_Bill_Click(object sender, EventArgs e)
        {
            WindowsForm.Customer.frm_Customer_Bill Obj = new WindowsForm.Customer.frm_Customer_Bill () { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
            Obj.Show();
        }

        

        private void btn_Customer_Details_Click(object sender, EventArgs e)
        {
            WindowsForm.Customer.frm_Customer_Details Obj = new WindowsForm.Customer.frm_Customer_Details() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
            Obj.Show();
        }

        private void UC_Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
