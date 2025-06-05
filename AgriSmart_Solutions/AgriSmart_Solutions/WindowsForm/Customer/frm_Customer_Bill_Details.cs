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
    public partial class frm_Customer_Bill_Details : Form
    {
        public frm_Customer_Bill_Details()
        {
            InitializeComponent();
        }

        private void frm_Customer_Bill_Details_Load(object sender, EventArgs e)
        {
           
            Shared_Class.Bind_Grid(dgv_Customer_Bill_Details, "Select * From Customer_Purchase_Details");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
