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
    public partial class frm_Add_New_Supplier : Form
    {
        public frm_Add_New_Supplier()
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
            tb_Supplier_Id.Text = Convert.ToString(Shared_Class.Auto_Incr("Supplier_Details", "Sup_Id", 8001));

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

        private void frm_Add_New_Supplier_Load(object sender, EventArgs e)
        {
            tb_Supplier_Id.Text = Convert.ToString(Shared_Class.Auto_Incr("Supplier_Details", "Sup_Id", 8001));
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection.Con_Open();

            if(tb_Supplier_Name.Text != "" && tb_Supplier_Address.Text != "" && tb_Mobile_No.Text != "" && tb_Supplier_Company.Text != "" && tb_Company_Address.Text!= "" && tb_Aadhar_No.Text != "" && tb_Email_Id.Text != "" && tb_Bank_Details.Text != "" && tb_Account_No.Text != "" )
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Insert Into Supplier_Details (Sup_Id, Sup_Name, Sup_Address, Sup_Added_Date, Mob_No, Alt_Mob_No,Sup_Company, Company_Address,Aadhar_No, Email_Id, Bank_Details, Account_No, Note, User_Login,Status) Values(@Id, @Name, @Sup_Address, @AddedDate, @MOB, @AltMOB, @Company,  @Company_Address, @AadharNo, @Email, @BankDetails, @AccountNo, @Note,@Ul,@S)";

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

                Cmd.Parameters.Add("Ul", SqlDbType.NVarChar).Value = Shared_Class.User_Login;
                Cmd.Parameters.Add("S", SqlDbType.Int).Value = 1;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Supplier Details Added Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
