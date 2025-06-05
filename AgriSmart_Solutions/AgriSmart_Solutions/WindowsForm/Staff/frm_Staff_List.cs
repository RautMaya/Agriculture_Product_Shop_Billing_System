using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriSmart_Solutions.WindowsForm.Staff
{
    public partial class frm_Staff_List : Form
    {
        public frm_Staff_List()
        {
            InitializeComponent();
        }

        private void frm_Staff_List_Load(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Designation", cmb_Designation, "Select Distinct(Designation) from Staff_Details");

            if(Shared_Class.User_Role == "Admin")
            {
                Shared_Class.Bind_Grid(dgv_Staff_Details, "Select * From Staff_Details");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Staff_Details, "Select Staff_Id,Staff_Name,Joining_Date,Designation,Mob_No,Aadhar_No,Bank_Details,Account_No From Staff_Details");
            }
        }

        private void cmb_Designation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Designation.Text == "Admin")
            {
                Shared_Class.Bind_Grid(dgv_Staff_Details, "Select Staff_Id,Staff_Name,Joining_Date,Designation,Mob_No,Aadhar_No,Bank_Details,Account_No From Staff_Details Where Designation = '" + cmb_Designation.Text + "'");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Staff_Details, "Select Staff_Id,Staff_Name,Joining_Date,Designation,Mob_No,Aadhar_No,Bank_Details,Account_No From Staff_Details Where Designation = '" + cmb_Designation.Text + "'");
            }
        }
        
    }
}
