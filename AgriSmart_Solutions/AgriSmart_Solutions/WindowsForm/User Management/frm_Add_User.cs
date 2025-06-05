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

namespace AgriSmart_Solutions.WindowsForm.User_Management
{
    public partial class frm_Add_User : Form
    {
        public frm_Add_User()
        {
            InitializeComponent();
        }
        void Clear_Controls()
        {
            cmb_User_Role.SelectedIndex = -1;
            tb_Username.Text = "";
            tb_Password.Text = "";
            tb_Confirm_Password.Text = "";
        }
        int Check_Password()
        {
            if(tb_Password.Text != tb_Confirm_Password.Text)
            {
                tb_Confirm_Password.Text = "";
                tb_Confirm_Password.Focus();
                return 0;
            }
            return 1;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            int check = Check_Password();

            if(cmb_User_Role.Text != "" && tb_Username.Text != "" && check == 1 )
            {
                Connection.Con_Open();

                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "Insert Into Login_Details values(@User_Role , @Username, @Password,@Status)";
                Cmd.Connection = Connection.DBCon;

                Cmd.Parameters.Add("User_Role", SqlDbType.VarChar).Value = cmb_User_Role.Text;
                Cmd.Parameters.Add("Username", SqlDbType.NVarChar).Value = tb_Username.Text;
                Cmd.Parameters.Add("Password", SqlDbType.NVarChar).Value = tb_Password.Text;

                Cmd.Parameters.Add("Status", SqlDbType.VarChar).Value = true;

                Cmd.ExecuteNonQuery();
                Cmd.Dispose();

                MessageBox.Show("User Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
                

                Connection.Con_Close();
            }
            else
            {
                MessageBox.Show("Fill All Fields !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frm_Add_User_Load(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Designation", cmb_User_Role, "Select Distinct(Designation) from Staff_Details");
        }     
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
