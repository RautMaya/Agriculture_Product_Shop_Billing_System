using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgriSmart_Solutions.WindowsForm.Product
{
    public partial class frm_Update_Product : Form
    {
        public frm_Update_Product()
        {
            InitializeComponent();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;

            }
        }

        void Enable_Controls()
        {
            tb_Product_Id.Enabled = false;
            cmb_Product_Type.Enabled = true;
            tb_Product_Name.Enabled = true;
            tb_Packing.Enabled = true;
            cmb_Unit.Enabled = true;
            tb_Purchase_Price.Enabled = true;
            tb_Sales_Price.Enabled = true;
            tb_Note.Enabled = true;

        }

        void Disable_Controls()
        {
            tb_Product_Id.Enabled = true;
            cmb_Product_Type.Enabled = false;
            tb_Product_Name.Enabled = false;
            tb_Packing.Enabled = false;
            cmb_Unit.Enabled = false;
            tb_Purchase_Price.Enabled = false;
            tb_Sales_Price.Enabled = false;
            tb_Note.Enabled = false;
        }

        void Clear_Controls()
        {
            tb_Product_Id.Clear();
            cmb_Product_Type.SelectedIndex = -1;
            tb_Product_Name.Clear();
            tb_Packing.Clear();
            cmb_Unit.SelectedIndex = -1;
            tb_Purchase_Price.Clear();
            tb_Sales_Price.Clear();
            tb_Note.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection.Con_Open();

            if(tb_Product_Id.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Select * From Product_Details where P_Id = @PId";

                Cmd.Parameters.Add("PId", SqlDbType.Int).Value = tb_Product_Id.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if(Dr.Read())
                {
                    cmb_Product_Type.Text = Dr.GetString(Dr.GetOrdinal("P_Type"));
                    tb_Product_Name.Text = Dr.GetString(Dr.GetOrdinal("P_Name"));
                    tb_Packing.Text = (Dr["Packing"].ToString());
                    cmb_Unit.Text = Dr.GetString(Dr.GetOrdinal("Unit"));
                    tb_Purchase_Price.Text = (Dr["P_Price"].ToString());
                    tb_Sales_Price.Text = (Dr["S_Price"].ToString());
                    tb_Note.Text = Dr.GetString(Dr.GetOrdinal("Note"));

                    Enable_Controls();
                }
                else
                {
                    MessageBox.Show("No Product Details Found", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_Product_Id.Clear();
                    tb_Product_Id.Focus();
                }

            }


            Connection.Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Enable_Controls();
        }

        private void frm_Update_Product_Load(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("P_Type", cmb_Product_Type, "Select distinct(P_Type) from Category_Details");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Connection.Con_Open();

            if (cmb_Product_Type.Text != "" && tb_Product_Name.Text != "" && tb_Packing.Text != "" && cmb_Unit.Text != "" && tb_Purchase_Price.Text != "" && tb_Sales_Price.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Update Product_Details Set  P_Type = @PType, P_Name = @PName, Packing = @Packing, Unit = @Unit, P_Price = @PPrice, S_Price = @SPrice, Note = @Note  Where P_Id = @PId";

                Cmd.Parameters.Add("PId", SqlDbType.Int).Value = tb_Product_Id.Text;
                Cmd.Parameters.Add("PType", SqlDbType.NVarChar).Value = cmb_Product_Type.Text;
                Cmd.Parameters.Add("PName", SqlDbType.NVarChar).Value = tb_Product_Name.Text;
                Cmd.Parameters.Add("Packing", SqlDbType.Int).Value = tb_Packing.Text;
                Cmd.Parameters.Add("Unit", SqlDbType.VarChar).Value = cmb_Unit.Text;
                Cmd.Parameters.Add("PPrice", SqlDbType.Money).Value = tb_Purchase_Price.Text;
                Cmd.Parameters.Add("SPrice", SqlDbType.Money).Value = tb_Sales_Price.Text;
                Cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Product Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All Fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            Connection.Con_Close();
        }

        
    }
}
