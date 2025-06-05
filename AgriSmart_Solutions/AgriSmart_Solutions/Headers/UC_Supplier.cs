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
    public partial class UC_Supplier : UserControl
    {
        public UC_Supplier()
        {
            InitializeComponent();
        }

        private void btn_Update_Supplier_Click(object sender, EventArgs e)
        {
            WindowsForm.Supplier.frm_Update_Supplier Obj = new WindowsForm.Supplier.frm_Update_Supplier() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Add_New_Supplier_Click(object sender, EventArgs e)
        {
            WindowsForm.Supplier.frm_Add_New_Supplier Obj = new WindowsForm.Supplier.frm_Add_New_Supplier() { TopLevel = false, TopMost=true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Supplier_List_Click(object sender, EventArgs e)
        {
            WindowsForm.Supplier.frm_Supplier_List Obj = new WindowsForm.Supplier.frm_Supplier_List() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Supplier_Payment_List_Click(object sender, EventArgs e)
        {
            WindowsForm.Supplier.frm_Supplier_Payment_List Obj = new WindowsForm.Supplier.frm_Supplier_Payment_List() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
            Obj.Show();
        }
    }
}
