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
    public partial class frm_Current_Stock : Form
    {
        public frm_Current_Stock()
        {
            InitializeComponent();
        }

        private void frm_Current_Stock_Load(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("P_Type", cmb_Product_Type, "Select Distinct(P_Type) from Category_Details");

            if (Shared_Class.User_Role == "Admin")
            {
                Shared_Class.Bind_Grid(dgv_Received_Order, "Select * From Product_Details");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Received_Order, "Select P_Id,P_Type,P_Name,Packing,Unit,S_Price,Note,Current_Stock From Product_Details");
            }
        }

        private void cmb_Product_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("P_Name", cmb_Product_Name, "Select Distinct(P_Name) from Product_Details where P_Type = '" + cmb_Product_Type.Text + "'");


            if (Shared_Class.User_Role == "Admin")
            {
                Shared_Class.Bind_Grid(dgv_Received_Order, "Select * From Product_Details Where P_Type = '" + cmb_Product_Type.Text + "'");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Received_Order, "Select P_Id,P_Type,P_Name,Packing,Unit,S_Price,Note,Current_Stock From Product_Details Where P_Type = '" + cmb_Product_Type.Text + "'");
            }
        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Unit", cmb_Unit, "Select Distinct(Unit) from Product_Details where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "'");
            if (Shared_Class.User_Role == "Admin")
            {
                Shared_Class.Bind_Grid(dgv_Received_Order, "Select * From Product_Details Where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "'");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Received_Order, "Select P_Id,P_Type,P_Name,Packing,Unit,S_Price,Note,Current_Stock From Product_Details Where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "'");
            }
        }

        private void cmb_Unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Packing", cmb_Packing, "Select Packing from Product_Details where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "' And Unit = '" + cmb_Unit.Text + "'");

            if (Shared_Class.User_Role == "Admin")
            {
                Shared_Class.Bind_Grid(dgv_Received_Order, "Select * From Product_Details Where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "' And Unit = '" + cmb_Unit.Text + "'");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Received_Order, "Select P_Id,P_Type,P_Name,Packing,Unit,S_Price,Note,Current_Stock From Product_Details Where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "' And Unit = '" + cmb_Unit.Text + "'");
            }
        }

        private void cmb_Packing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Shared_Class.User_Role == "Admin")
            {
                Shared_Class.Bind_Grid(dgv_Received_Order, "Select * From Product_Details Where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "' And Unit = '" + cmb_Unit.Text + "' And Packing = '" + cmb_Packing.Text + "'");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Received_Order, "Select P_Id,P_Type,P_Name,Packing,Unit,S_Price,Note,Current_Stock From Product_Details Where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "' And Unit = '" + cmb_Unit.Text + "' And Packing = '" + cmb_Packing.Text + "'");
            }
        }
    }
}
