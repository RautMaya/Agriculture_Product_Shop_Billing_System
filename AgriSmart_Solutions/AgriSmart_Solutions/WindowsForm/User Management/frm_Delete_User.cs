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
    public partial class frm_Delete_User : Form
    {
        public frm_Delete_User()
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
            tb_UserRole.Clear();
            tb_Username.Clear();
            tb_Admin_Password.Clear();
            btn_Delete.Enabled = false;
        }

        private void frm_Delete_User_Load(object sender, EventArgs e)
        {
            Shared_Class.Bind_Grid(dgv_User_Details, "Select User_Role,Username From Login_Details Where Status = 'true'");
            tb_UserRole.Focus();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
          if(tb_UserRole.Text != "" && tb_Username.Text != "" && tb_Admin_Password.Text == "p")
            {
                btn_Delete.Enabled = true;
                DialogResult DR = MessageBox.Show("Are You Sure To Delete This User !!!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(DR == DialogResult.Yes)
                {
                    MessageBox.Show("User Delete Successfully !!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Shared_Class.Bind_Grid(dgv_User_Details, "Select User_Role , Username From Login_Details Where Username <> '" + tb_Username.Text + "'");

                    Clear_Controls();
                }
                else
                {
                    Clear_Controls();
                }
            }
        }

        private void tb_Admin_Password_TextChanged(object sender, EventArgs e)
        {
            if (tb_UserRole.Text != "" && tb_Username.Text != "" && tb_Admin_Password.Text == "p")
            {
                btn_Delete.Enabled = true;
            }
        }

        private void dgv_User_Details_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectRowCount = dgv_User_Details.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (SelectRowCount == 1)
            {
                int Row_Index = dgv_User_Details.SelectedCells[0].RowIndex;
                string UserRole = Convert.ToString(dgv_User_Details.Rows[Row_Index].Cells[0].Value);
                string Username = Convert.ToString(dgv_User_Details.Rows[Row_Index].Cells[1].Value);

                tb_UserRole.Text = UserRole;
                tb_Username.Text = Username;
            }
        }
    }
}
