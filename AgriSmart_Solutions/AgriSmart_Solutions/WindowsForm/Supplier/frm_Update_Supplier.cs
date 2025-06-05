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

namespace AgriSmart_Solutions.WindowsForm.Supplier
{
    public partial class frm_Update_Supplier : Form
    {
        public frm_Update_Supplier()
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
            tb_Supplier_Id.Enabled = false;
            tb_Supplier_Name.Enabled = true;
            tb_Supplier_Address.Enabled = true;
            dtp_Supplier_Added_Date.Enabled = false;
            tb_Mobile_No.Enabled = true;
            tb_Alt_Mobile_No.Enabled = true;
            tb_Supplier_Company.Enabled = true;
            tb_Company_Address.Enabled = true;
            tb_Aadhar_No.Enabled = true;
            tb_Email_Id.Enabled = true;
            tb_Bank_Details.Enabled = true;
            tb_Account_No.Enabled = true;
            tb_Note.Enabled = true;
        }

        void Disable_Controls()
        {
            tb_Supplier_Id.Enabled = true;
            tb_Supplier_Name.Enabled = false;
            tb_Supplier_Address.Enabled = false;
            dtp_Supplier_Added_Date.Enabled = true;
            tb_Mobile_No.Enabled = false;
            tb_Alt_Mobile_No.Enabled = false;
            tb_Supplier_Company.Enabled = false;
            tb_Company_Address.Enabled = false;
            tb_Aadhar_No.Enabled = false;
            tb_Email_Id.Enabled = false;
            tb_Bank_Details.Enabled = false;
            tb_Account_No.Enabled = false;
            tb_Note.Enabled = false;
        }

        void Clear_Controls()
        {
            tb_Supplier_Id.Text = "";
            tb_Supplier_Name.Clear();
            tb_Supplier_Address.Clear();
            dtp_Supplier_Added_Date.Text = "11/12/2024";
            tb_Mobile_No.Clear();
            tb_Alt_Mobile_No.Clear();
            tb_Supplier_Company.Clear();
            tb_Company_Address.Clear();
            tb_Aadhar_No.Clear();
            tb_Email_Id.Clear();
            tb_Bank_Details.Clear();
            tb_Account_No.Clear();
            tb_Note.Clear();
        }

        

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Connection.Con_Open();

            if (tb_Supplier_Name.Text != "" && tb_Supplier_Address.Text != "" && tb_Mobile_No.Text != "" && tb_Supplier_Company.Text != "" && tb_Company_Address.Text != "" && tb_Aadhar_No.Text != "" && tb_Email_Id.Text != "" && tb_Bank_Details.Text != "" && tb_Account_No.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Update Supplier_Details Set  Sup_Name = @Name, Sup_Address = @Sup_Address, Sup_Added_Date =  @AddedDate, Mob_No = @MOB, Alt_Mob_No = @AltMOB,Sup_Company =  @Company, Company_Address = @Company_Address,Aadhar_No = @AadharNo, Email_Id = @Email, Bank_Details = @BankDetails, Account_No = @AccountNo, Note =  @Note Where Sup_Id = @Id";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Supplier_Id.Text;
                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Supplier_Name.Text;
                Cmd.Parameters.Add("Sup_Address", SqlDbType.NVarChar).Value = tb_Supplier_Address.Text;
                Cmd.Parameters.Add("AddedDate", SqlDbType.Date).Value = dtp_Supplier_Added_Date.Value.Date;
                Cmd.Parameters.Add("MOB", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("AltMOB", SqlDbType.Decimal).Value = tb_Alt_Mobile_No.Text;
                Cmd.Parameters.Add("Company", SqlDbType.VarChar).Value = tb_Supplier_Company.Text;
                Cmd.Parameters.Add("Company_Address", SqlDbType.NVarChar).Value = tb_Company_Address.Text;
                Cmd.Parameters.Add("AadharNo", SqlDbType.Decimal).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = tb_Email_Id.Text;
                Cmd.Parameters.Add("BankDetails", SqlDbType.NVarChar).Value = tb_Bank_Details.Text;
                Cmd.Parameters.Add("AccountNo", SqlDbType.Decimal).Value = tb_Account_No.Text;
                Cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Supplier Details Update Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All Fields ", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Connection.Con_Close();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection.Con_Open();

            if (tb_Supplier_Id.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Select * From Supplier_Details where Sup_Id = @Id";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Supplier_Id.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Supplier_Name.Text = Dr.GetString(Dr.GetOrdinal("Sup_Name"));
                    tb_Supplier_Address.Text = Dr.GetString(Dr.GetOrdinal("Sup_Address"));
                    dtp_Supplier_Added_Date.Text = (Dr["Sup_Added_Date"].ToString());
                    tb_Mobile_No.Text = (Dr["Mob_No"].ToString());
                    tb_Alt_Mobile_No.Text = (Dr["Alt_Mob_No"].ToString());
                    tb_Supplier_Company.Text = Dr.GetString(Dr.GetOrdinal("Sup_Company"));
                    tb_Company_Address.Text = Dr.GetString(Dr.GetOrdinal("Company_Address"));
                    tb_Aadhar_No.Text = (Dr["Aadhar_No"].ToString());
                    tb_Email_Id.Text = Dr.GetString(Dr.GetOrdinal("Email_Id"));
                    tb_Bank_Details.Text = Dr.GetString(Dr.GetOrdinal("Bank_Details"));
                    tb_Account_No.Text = (Dr["Account_No"].ToString());
                    tb_Note.Text = Dr.GetString(Dr.GetOrdinal("Note"));

                    Enable_Controls();
                }
                else
                {
                    MessageBox.Show("No Supplier Found", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_Supplier_Id.Clear();
                    tb_Supplier_Id.Focus();
                }

                Connection.Con_Close();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Enable_Controls();
        }
    }
}
