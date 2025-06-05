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

namespace AgriSmart_Solutions
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Connection.Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandText = "Select Count(*) from Login_Details where User_Role = @User_Role and Username = @Username and Password=@Password";
            Cmd.Connection = Connection.DBCon;

            Cmd.Parameters.Add("User_Role", SqlDbType.VarChar).Value = cmb_User_Role.Text;
            Cmd.Parameters.Add("Username", SqlDbType.NVarChar).Value = cmb_Username.Text;
            Cmd.Parameters.Add("Password", SqlDbType.NVarChar).Value = tb_Password.Text;

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if(Cnt > 0)
            {
                Shared_Class.User_Role = cmb_User_Role.Text;
                Shared_Class.User_Login = cmb_Username.Text;
                Shared_Class.Generate_Id();

                MessageBox.Show("Login Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Shared_Class.LoginUserName = cmb_Username.Text;

                if(cmb_User_Role.SelectedIndex == 0)
                {
                    Shared_Class.User_Id = 1;
                }
                else if(cmb_User_Role.SelectedIndex == 1)
                {
                    Shared_Class.User_Id = 2;
                }
                else if(cmb_User_Role.SelectedIndex == 2)
                {
                    Shared_Class.User_Id = 3;
                }
                Shared_Class.Username = cmb_Username.Text;


                WindowsForm.MDI.MDI_AgriSmart_Solutions Obj = new WindowsForm.MDI.MDI_AgriSmart_Solutions();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter Correct Username and Password!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Designation", cmb_User_Role, "Select Distinct(Designation) from Staff_Details");

            cmb_User_Role.SelectedIndex= 0;
            cmb_Username.SelectedIndex = 0;
        }

        private void cmb_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Username", cmb_Username, "select distinct(Username) from Login_Details where User_Role = '" + cmb_User_Role.Text + "'");
        }

        
    }
}
