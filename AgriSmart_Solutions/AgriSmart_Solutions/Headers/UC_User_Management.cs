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
    public partial class UC_User_Management : UserControl
    {
        public UC_User_Management()
        {
            InitializeComponent();
        }

        private void btn_Update_User_Click(object sender, EventArgs e)
        {
            WindowsForm.User_Management.frm_Update_User Obj = new WindowsForm.User_Management.frm_Update_User() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Add_User_Click(object sender, EventArgs e)
        {
            WindowsForm.User_Management.frm_Add_User Obj = new WindowsForm.User_Management.frm_Add_User() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Delete_User_Click(object sender, EventArgs e)
        {
            WindowsForm.User_Management.frm_Delete_User Obj = new WindowsForm.User_Management.frm_Delete_User() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
            WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
            Obj.Show();
        }
    }
}
