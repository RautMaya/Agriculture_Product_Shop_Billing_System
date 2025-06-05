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
    public partial class frm_Update_Staff : Form
    {
        public frm_Update_Staff()
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

        void Enable_Controls()
        {
            tb_Staff_Id.Enabled = false;
            tb_Staff_Name.Enabled = true;
            dtp_Joining_Date.Enabled = false;
            cmb_Designation.Enabled = true;            
            tb_Mobile_No.Enabled = true;
            tb_Alt_Mobile_No.Enabled = true;
            tb_Salary.Enabled = true;
            tb_Aadhar_No.Enabled = true;
            tb_Email_Id.Enabled = true;
            tb_Note.Enabled = true;
            tb_Bank_Details.Enabled = true;
            tb_Account_No.Enabled = true;
            
        }

        void Disable_Controls()
        {
            tb_Staff_Id.Enabled = true;
            tb_Staff_Name.Enabled = false;
            dtp_Joining_Date.Enabled = true;
            cmb_Designation.Enabled = false;
            tb_Mobile_No.Enabled = false;
            tb_Alt_Mobile_No.Enabled = false;
            tb_Salary.Enabled = false;
            tb_Aadhar_No.Enabled = false;
            tb_Email_Id.Enabled = false;
            tb_Note.Enabled = false;
            tb_Bank_Details.Enabled = false;
            tb_Account_No.Enabled = false;
        }

        void Clear_Controls()
        {
            tb_Staff_Id.Text = "";
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection.Con_Open();

            if(tb_Staff_Id.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Select * From Staff_Details where Staff_Id=@Id";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Staff_Id.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if(Dr.Read())
                {
                    tb_Staff_Name.Text = Dr.GetString(Dr.GetOrdinal("Staff_Name"));
                    dtp_Joining_Date.Text = (Dr["Joining_Date"].ToString());
                    cmb_Designation.Text = Dr.GetString(Dr.GetOrdinal("Designation"));
                    tb_Mobile_No.Text = (Dr["Mob_No"].ToString());
                    tb_Alt_Mobile_No.Text = (Dr["Alt_Mob_No"].ToString());
                    tb_Salary.Text = (Dr["Salary"].ToString());
                    tb_Aadhar_No.Text = (Dr["Aadhar_No"].ToString());
                    tb_Email_Id.Text = (Dr["Email_Id"].ToString());
                    tb_Note.Text = Dr.GetString(Dr.GetOrdinal("Note"));
                    tb_Bank_Details.Text = Dr.GetString(Dr.GetOrdinal("Bank_Details"));
                    tb_Account_No.Text = (Dr["Account_No"].ToString());

                    Enable_Controls();

                }
                else
                {
                    MessageBox.Show("No Staff Found", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_Staff_Id.Clear();
                    tb_Staff_Id.Focus();
                }
            }

            Connection.Con_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Connection.Con_Open();

            if (tb_Staff_Id.Text != "" && tb_Staff_Name.Text != "" && cmb_Designation.Text != "" && tb_Mobile_No.Text != "" && tb_Salary.Text != "" && tb_Aadhar_No.Text != "" && tb_Bank_Details.Text != "" && tb_Account_No.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Update Staff_Details Set   Staff_Name =@Name, Joining_Date = @JoiningDate, Designation = @Designation, Mob_No =  @MOB, Alt_Mob_No = @AltMOB ,Salary = @Salary, Aadhar_No =  @AadharNo, Email_Id =  @Email, Note = @Note, Bank_Details = @BankDetails, Account_No = @AccountNo where Staff_Id  = @Id";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Staff_Id.Text;
                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Staff_Name.Text;
                Cmd.Parameters.Add("JoiningDate", SqlDbType.Date).Value = dtp_Joining_Date.Value.Date;
                Cmd.Parameters.Add("Designation", SqlDbType.NVarChar).Value = cmb_Designation.Text;
                Cmd.Parameters.Add("MOB", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("AltMOB", SqlDbType.Decimal).Value = tb_Alt_Mobile_No.Text;
                Cmd.Parameters.Add("Salary", SqlDbType.Money).Value = tb_Salary.Text;
                Cmd.Parameters.Add("AadharNo", SqlDbType.Decimal).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = tb_Email_Id.Text;
                Cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;
                Cmd.Parameters.Add("BankDetails", SqlDbType.NVarChar).Value = tb_Bank_Details.Text;
                Cmd.Parameters.Add("AccountNo", SqlDbType.Decimal).Value = tb_Account_No.Text;


                Cmd.ExecuteNonQuery();

                MessageBox.Show("Staff Details Update Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            Enable_Controls();
        }
    }

     
 
}
