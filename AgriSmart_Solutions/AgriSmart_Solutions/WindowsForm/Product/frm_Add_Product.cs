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
    public partial class frm_Add_Product : Form
    {
        public frm_Add_Product()
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
        void Clear_Controls()
        {
            tb_Product_Id.Text = Convert.ToString(Shared_Class.Auto_Incr("Product_Details", "P_Id", 101));

            cmb_Product_Type.SelectedIndex = -1;
            tb_Product_Name.Clear();
            tb_Packing.Clear();
            cmb_Unit.SelectedIndex = -1;
            tb_Purchase_Price.Clear();
            tb_Sales_Price.Clear();
            tb_Note.Clear();
        }
       
        private void frm_Add_Product_Load(object sender, EventArgs e)
        {
            tb_Product_Id.Text = Convert.ToString(Shared_Class.Auto_Incr("Product_Details", "P_Id", 101));

            Shared_Class.Bind_ComboBox("P_Type", cmb_Product_Type, "Select Distinct(P_Type) from Category_Details");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection.Con_Open();

            if(cmb_Product_Type.Text != "" && tb_Product_Name.Text != "" && tb_Packing.Text != "" && cmb_Unit.Text != "" && tb_Purchase_Price.Text != "" && tb_Sales_Price.Text != "" )
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Insert Into Product_Details (P_Id, P_Type, P_Name, Packing, Unit, P_Price, S_Price, Note,Current_Stock, User_Login, Status) Values (@PId, @PType, @PName, @Packing, @Unit, @PPrice, @SPrice, @Note , @Cs , @Ul, @S)";

                Cmd.Parameters.Add("PId", SqlDbType.Int).Value = tb_Product_Id.Text;
                Cmd.Parameters.Add("PType", SqlDbType.NVarChar).Value = cmb_Product_Type.Text;
                Cmd.Parameters.Add("PName", SqlDbType.NVarChar).Value = tb_Product_Name.Text;
                Cmd.Parameters.Add("Packing", SqlDbType.Int).Value = tb_Packing.Text;
                Cmd.Parameters.Add("Unit", SqlDbType.VarChar).Value = cmb_Unit.Text;
                Cmd.Parameters.Add("PPrice", SqlDbType.Money).Value = tb_Purchase_Price.Text;
                Cmd.Parameters.Add("SPrice", SqlDbType.Money).Value = tb_Sales_Price.Text;
                Cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;

                Cmd.Parameters.Add("Cs", SqlDbType.Int).Value = 0;
                Cmd.Parameters.Add("Ul", SqlDbType.NVarChar).Value = Shared_Class.User_Login;
                Cmd.Parameters.Add("S", SqlDbType.Int).Value = 1;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Product Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All Fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            Connection.Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        
    }
}
