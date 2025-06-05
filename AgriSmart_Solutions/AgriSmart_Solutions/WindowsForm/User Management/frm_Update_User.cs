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
    public partial class frm_Update_User : Form
    {
        public frm_Update_User()
        {
            InitializeComponent();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;

            }
        }

        void Clear_Controls()
        {
            cmb_User_Role.SelectedIndex = -1;
            cmb_User_Role.SelectedIndex = -1;
            tb_Password.Clear();
            cmb_User_Role.Focus();
            
        }


        private void frm_Update_User_Load(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Designation", cmb_User_Role, "Select Distinct(Designation) from Staff_Details");

            cmb_User_Role.Focus();
        }

        private void cmb_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Username", cmb_Username, "select distinct(Username) from Login_Details where User_Role = '" + cmb_User_Role.Text + "'");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Connection.Con_Open();

            if(cmb_User_Role.Text != "" && cmb_Username.Text != "" && tb_Password.Text != "" )
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Update Login_Details Set  Password = @Password where User_Role = @User_Role and Username = @Username";

                Cmd.Parameters.Add("User_Role", SqlDbType.VarChar).Value = cmb_User_Role.Text;
                Cmd.Parameters.Add("Username", SqlDbType.NVarChar).Value = cmb_Username.Text;
                Cmd.Parameters.Add("Password", SqlDbType.NVarChar).Value = tb_Password.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("User Update Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill All Fields !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Connection.Con_Close();
        }
    }
}
