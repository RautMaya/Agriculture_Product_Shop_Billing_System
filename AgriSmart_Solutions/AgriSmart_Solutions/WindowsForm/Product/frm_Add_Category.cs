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
    public partial class frm_Add_Category : Form
    {
        public frm_Add_Category()
        {
            InitializeComponent();
        }

        private void frm_Add_Category_Load(object sender, EventArgs e)
        {
            tb_Category_Id.Text = Convert.ToString(Shared_Class.Auto_Incr("Category_Details", "Category_Id", 1));

            if(Shared_Class.User_Role == "Admin")
            {
                Shared_Class.Bind_Grid(dgv_Category_Details, "Select * From Category_Details");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Category_Details, "Select Category_Id , P_Type From Category_Details");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection.Con_Open();

            if(tb_Product_Type.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Insert Into Category_Details Values(@CID , @PType ,@User_Login)";

                Cmd.Parameters.Add("CID", SqlDbType.Int).Value = tb_Category_Id.Text;
                Cmd.Parameters.Add("PType", SqlDbType.VarChar).Value = tb_Product_Type.Text;
                Cmd.Parameters.Add("User_Login", SqlDbType.NVarChar).Value = Shared_Class.User_Login;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Product Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_Product_Type.Clear();
                tb_Category_Id.Text = Convert.ToString(Shared_Class.Auto_Incr("Category_Details", "Category_Id", 1));
            }
            else
            {
                MessageBox.Show("Fill Product Type", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Connection.Con_Close();
        }
    }
}
