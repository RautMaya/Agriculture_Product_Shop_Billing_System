using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriSmart_Solutions.WindowsForm.MDI
{
    public partial class MDI_AgriSmart_Solutions : Form
    {
        public MDI_AgriSmart_Solutions()
        {
            InitializeComponent();
        }

        private void btn_Supplier_Click(object sender, EventArgs e)
        {
            WindowsForm.Supplier.frm_Add_New_Supplier Obj = new Supplier.frm_Add_New_Supplier() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(Obj);
            Obj.Show();

            Headers.UC_Supplier UC = new Headers.UC_Supplier();
            pnl_Head.Controls.Clear();
            this.pnl_Head.Controls.Add(UC);
            UC.Show();
        }
        private void btn_Stock_Click(object sender, EventArgs e)
        {
            WindowsForm.Stock.frm_Received_Order Obj = new Stock.frm_Received_Order() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(Obj);
            Obj.Show();

            Headers.UC_Stock UC = new Headers.UC_Stock();
            pnl_Head.Controls.Clear();
            this.pnl_Head.Controls.Add(UC);
            UC.Show();
        }

        private void btn_User_Management_Click(object sender, EventArgs e)
        {
            WindowsForm.User_Management.frm_Add_User Obj = new User_Management.frm_Add_User() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(Obj);
            Obj.Show();

            Headers.UC_User_Management UC = new Headers.UC_User_Management();
            pnl_Head.Controls.Clear();
            this.pnl_Head.Controls.Add(UC);
            UC.Show();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            WindowsForm.Customer.frm_Customer_Bill Obj = new Customer.frm_Customer_Bill() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(Obj);
            Obj.Show();

            Headers.UC_Customer UC = new Headers.UC_Customer();
            pnl_Head.Controls.Clear();
            this.pnl_Head.Controls.Add(UC);
            UC.Show();

        }

        private void MDI_AgriSmart_Solutions_Load(object sender, EventArgs e)
        {
            lbl_LoginUserName.Text = "Welcome " + Shared_Class.LoginUserName;

            if(Shared_Class.User_Role == "Cashier")
            {
                btn_User_Management.Visible = false;
               /// btn_Stock.Visible = false;
               ///btn_Staff.Visible = false;
                ///btn_Expence.Visible = false;
                btn_Report.Visible = false;

            }
            else if(Shared_Class.User_Role == "Manager")
            {
                btn_User_Management.Visible = false;
                btn_Report.Visible = false;
            }
            else if(Shared_Class.User_Role == "Worker")
            {
                btn_User_Management.Visible = false;
                btn_Report.Visible = false;
                btn_Expence.Visible = false;
                btn_Staff.Visible = false;
            }
        }

        private void btn_Expence_Click(object sender, EventArgs e)
        {
            WindowsForm.Expence.frm_Shop_Expence Obj = new Expence.frm_Shop_Expence() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(Obj);
            Obj.Show();

            Headers.UC_Expence UC = new Headers.UC_Expence();
            pnl_Head.Controls.Clear();
            this.pnl_Head.Controls.Add(UC);
            UC.Show();
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            WindowsForm.Staff.frm_Add_Staff Obj = new Staff.frm_Add_Staff() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(Obj);
            Obj.Show();

            Headers.UC_Staff UC = new Headers.UC_Staff();
            pnl_Head.Controls.Clear();
            this.pnl_Head.Controls.Add(UC);
            UC.Show();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            WindowsForm.Product.frm_Add_Category Obj = new Product.frm_Add_Category() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(Obj);
            Obj.Show();

            Headers.UC_Product UC = new Headers.UC_Product();
            pnl_Head.Controls.Clear();
            this.pnl_Head.Controls.Add(UC);
            UC.Show();
        }

       

        private void btn_Report_Click(object sender, EventArgs e)
        {
            WindowsForm.ReportMaster.frm_Report Obj = new WindowsForm.ReportMaster.frm_Report() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(Obj);
            Obj.Show();          
        }

        private void pb_Shop_Icon_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are You Want To LogOut ", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (DR == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();
                this.Hide();
            }
        }
    }
}
