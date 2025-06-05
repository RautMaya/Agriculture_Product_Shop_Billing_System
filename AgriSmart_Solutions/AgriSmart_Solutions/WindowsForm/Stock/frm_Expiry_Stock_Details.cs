using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriSmart_Solutions.WindowsForm.Stock
{
    public partial class frm_Expiry_Stock_Details : Form
    {
        public frm_Expiry_Stock_Details()
        {
            InitializeComponent();
        }

        private void frm_Expiry_Stock_Details_Load(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("P_Type", cmb_Product_Type, "Select Distinct(P_Type) from Category_Details");

            
            if (Shared_Class.User_Role == "Admin")
            {
                Shared_Class.Bind_Grid(dgv_Expiry_Details, "Select * From Expiry_Details");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Expiry_Details, "Select E_Id,P_Type,P_Name,Packing,Unit,E_Date,Stock From Expiry_Details");
            }

        }

        private void cmb_Product_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("P_Name", cmb_Product_Name, "Select Distinct(P_Name) from Product_Details where P_Type = '" + cmb_Product_Type.Text + "'");

            if (Shared_Class.User_Role == "Admin")
            {
                Shared_Class.Bind_Grid(dgv_Expiry_Details, "Select * From Expiry_Details Where P_Type = '" + cmb_Product_Type.Text + "'");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Expiry_Details, "Select E_Id,P_Type,P_Name,Packing,Unit,E_Date,Stock From Expiry_Details Where P_Type = '" + cmb_Product_Type.Text + "'");
            }
        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Unit", cmb_Unit, "Select Distinct(Unit) from Product_Details where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "'");

            if (Shared_Class.User_Role == "Admin")
            {
                Shared_Class.Bind_Grid(dgv_Expiry_Details, "Select * From Expiry_Details Where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "'");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Expiry_Details, "Select E_Id,P_Type,P_Name,Packing,Unit,E_Date,Stock From Expiry_Details Where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "'");
            }
        }

        private void cmb_Unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Packing", cmb_Packing, "Select Packing from Product_Details where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "' And Unit = '" + cmb_Unit.Text + "'");

            if (Shared_Class.User_Role == "Admin")
            {
                Shared_Class.Bind_Grid(dgv_Expiry_Details, "Select * From Expiry_Details Where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "' And Unit = '" + cmb_Unit.Text + "'");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Expiry_Details, "Select E_Id,P_Type,P_Name,Packing,Unit,E_Date,Stock From Expiry_Details Where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "' And Unit = '" + cmb_Unit.Text + "'");
            }
        }

        private void cmb_Packing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Shared_Class.User_Role == "Admin")
            {
                Shared_Class.Bind_Grid(dgv_Expiry_Details, "Select * From Expiry_Details Where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "' And Unit = '" + cmb_Unit.Text + "' And Packing = '" + cmb_Packing.Text + "'");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Expiry_Details, "Select E_Id,P_Type,P_Name,Packing,Unit,E_Date,Stock From Expiry_Details Where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "' And Unit = '" + cmb_Unit.Text + "' And Packing = '" + cmb_Packing.Text + "'");
            }
        }
    }
}
