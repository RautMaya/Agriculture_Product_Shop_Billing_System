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

namespace AgriSmart_Solutions.WindowsForm.Staff
{
    public partial class frm_Add_Staff : Form
    {
        public frm_Add_Staff()
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

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;

            }
        }

        void Clear_Controls()
        {
            tb_Staff_Id.Text = Convert.ToString(Shared_Class.Auto_Incr("Staff_Details", "Staff_Id", 9001));

            tb_Staff_Name.Clear();
            dtp_Joining_Date.Text = "11/12/2024";
            cmb_Designation.SelectedIndex = -1;
            tb_Mobile_No.Clear();
            tb_Alt_Mobile_No.Clear();
            tb_Salary.Clear();
            tb_Aadhar_No.Clear();
            tb_Email_Id.Clear();
            tb_Note.Clear();
            tb_Bank_Details.Clear();
            tb_Account_No.Clear();
            
        }

        
        private void frm_Add_Staff_Load(object sender, EventArgs e)
        {
            tb_Staff_Id.Text = Convert.ToString(Shared_Class.Auto_Incr("Staff_Details", "Staff_Id", 9001));
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection.Con_Open();

            if(tb_Staff_Id.Text != "" && tb_Staff_Name.Text != "" && cmb_Designation.Text != "" && tb_Mobile_No.Text != "" && tb_Salary.Text != "" && tb_Aadhar_No.Text != "" && tb_Bank_Details.Text != "" && tb_Account_No.Text!= "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Insert Into Staff_Details (Staff_Id, Staff_Name, Joining_Date, Designation, Mob_No, Alt_Mob_No,Salary, Aadhar_No, Email_Id, Note, Bank_Details, Account_No, User_Login, Status) Values (@Id, @Name, @JoiningDate, @Designation, @MOB, @AltMOB, @Salary, @AadharNo, @Email, @Note, @BankDetails, @AccountNo, @Ul , @S)";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Staff_Id.Text;
                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Staff_Name.Text;
                Cmd.Parameters.Add("JoiningDate", SqlDbType.Date).Value = dtp_Joining_Date.Value.Date;
                Cmd.Parameters.Add("Designation", SqlDbType.VarChar).Value = cmb_Designation.Text;
                Cmd.Parameters.Add("MOB", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("AltMOB", SqlDbType.Decimal).Value = tb_Alt_Mobile_No.Text;
                Cmd.Parameters.Add("Salary", SqlDbType.Money).Value = tb_Salary.Text;
                Cmd.Parameters.Add("AadharNo", SqlDbType.Decimal).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = tb_Email_Id.Text;
                Cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;
                Cmd.Parameters.Add("BankDetails", SqlDbType.NVarChar).Value = tb_Bank_Details.Text;
                Cmd.Parameters.Add("AccountNo", SqlDbType.Decimal).Value = tb_Account_No.Text;

                Cmd.Parameters.Add("Ul", SqlDbType.NVarChar).Value = Shared_Class.User_Login;
                Cmd.Parameters.Add("S", SqlDbType.Int).Value = 1;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Staff Details Added Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

            }
            else
            {
                MessageBox.Show("1st Fill All Fields ", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Connection.Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
