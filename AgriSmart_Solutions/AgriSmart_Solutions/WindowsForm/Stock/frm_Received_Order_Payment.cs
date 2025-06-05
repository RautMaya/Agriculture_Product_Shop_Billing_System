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

namespace AgriSmart_Solutions.WindowsForm.Stock
{
    public partial class frm_Received_Order_Payment : Form
    {
        public frm_Received_Order_Payment()
        {
            InitializeComponent();
        }
        
        public frm_Received_Order_Payment(int id, string date, double bill)
        {
            InitializeComponent();
            tb_Received_Order_Id.Text = Convert.ToString(id);
            dtp_Received_Order_Date.Text = date;
            tb_Final_Bill.Text = Convert.ToString(bill);
        }
        

        private void frm_Received_Order_Payment_Load(object sender, EventArgs e)
        {
            tb_Payment_Id.Text = Convert.ToString(Shared_Class.Auto_Incr("Received_Order_Payment_Details", "Payment_Id", 1));

            if (Shared_Class.Flag == 3)
            {
                ///tb_Received_Order_Id.Text = Convert.ToString(Shared_Class.R);
                ///dtp_Received_Order_Date.Text = Shared_Class.D;
                ///tb_Final_Bill.Text = Convert.ToString(Shared_Class.B);
                btn_Search.Visible = false;
                Connection.Con_Open();

                SqlCommand Cmd = new SqlCommand("Select Paid_Amount From Received_Order_Details Where R_Order_Id = '" + tb_Received_Order_Id.Text + "'", Connection.DBCon);
                tb_Paid_Amount.Text = Convert.ToString(Cmd.ExecuteScalar());

                Connection.Con_Close();
                tb_Balanced_Amount.Text = Convert.ToString(Convert.ToDouble(tb_Final_Bill.Text) - Convert.ToDouble(tb_Paid_Amount.Text));
            }
            else
            {
                btn_Search.Enabled = true;
                tb_Received_Order_Id.Focus();
            }
           
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
            
            tb_Payment_Id.Text = Convert.ToString(Shared_Class.Auto_Incr("Received_Order_Payment_Details", "Payment_Id", 1));
            cmb_Payment_Media.SelectedIndex = -1;
            tb_Note.Clear();
            tb_Final_Bill.Clear();
            tb_Paid_Amount.Clear();
            tb_Balanced_Amount.Clear();
            tb_Payment_Amount.Clear();
        }

        void Enable_Controls()
        {
            tb_Received_Order_Id.Enabled = false;
            tb_Paid_Amount.Enabled = false;
            dtp_Received_Order_Date.Enabled = false;
            tb_Payment_Id.Enabled = false;
            dtp_Payment_Date.Enabled = true;
            cmb_Payment_Media.Enabled = true;
            tb_Note.Enabled = true;
            tb_Payment_Amount.Enabled = true;
        }

        void Disable_Controls()
        {
            tb_Received_Order_Id.Enabled = true;
            tb_Paid_Amount.Enabled = true;
            dtp_Received_Order_Date.Enabled = true;
            tb_Payment_Id.Enabled = true;
            dtp_Payment_Date.Enabled = false;
            cmb_Payment_Media.Enabled = false;
            tb_Note.Enabled = false;
            tb_Payment_Amount.Enabled = false;
        }
        private void tb_Paid_Amount_Leave(object sender, EventArgs e)
        {
            if (tb_Paid_Amount.Text == "")
            {
                tb_Paid_Amount.Text = "0";
            }
        }
        
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection.Con_Open();

            if(tb_Received_Order_Id.Text !="")
            {                
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Select R_Order_Date,Final_Bill,Paid_Amount From Received_Order_Details Where R_Order_Id = @R_Order_Id";

                Cmd.Parameters.Add("R_Order_Id", SqlDbType.Int).Value = tb_Received_Order_Id.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if(Dr.Read())
                {
                    dtp_Received_Order_Date.Text = (Dr["R_Order_Date"].ToString());
                    tb_Final_Bill.Text = (Dr["Final_Bill"].ToString());
                    tb_Paid_Amount.Text = (Dr["Paid_Amount"].ToString());

                    Enable_Controls();
                }
                else
                {
                    MessageBox.Show("No Received Order Details Found", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_Received_Order_Id.Clear();
                    tb_Received_Order_Id.Focus();
                }
                Dr.Close();

                if (tb_Final_Bill.Text != "" && tb_Paid_Amount.Text != "")
                {
                    tb_Balanced_Amount.Text = (Convert.ToString(Convert.ToDouble(tb_Final_Bill.Text) - (Convert.ToDouble(tb_Paid_Amount.Text))));
                }

                if ( tb_Paid_Amount.Text == tb_Final_Bill.Text)
                {
                    MessageBox.Show("All Paid Amount", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Clear_Controls();
                    tb_Received_Order_Id.Clear();
                    tb_Received_Order_Id.Enabled = true;
                    tb_Payment_Amount.Enabled = true;
                    tb_Note.Enabled = true;
                    cmb_Payment_Media.Enabled = true;
                }
            }
          Connection.Con_Close();

            //tb_Balanced_Amount.Text = Convert.ToString(Convert.ToDouble(tb_Final_Bill.Text) - Convert.ToDouble(tb_Paid_Amount.Text));
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection.Con_Open();
            if(tb_Received_Order_Id.Text != "" && tb_Payment_Id.Text != "" && cmb_Payment_Media.Text != "" && tb_Note.Text != "" && tb_Final_Bill.Text != "" && tb_Paid_Amount.Text != "" && tb_Balanced_Amount.Text!="" && tb_Payment_Amount.Text != "" )
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Insert Into Received_Order_Payment_Details Values(@Payment_Id,@R_Order_Id,@Pay_Date,@Payment_Media,@Note,@Final_Bill,@Paid_Amount,@Balanced_Amount,@Payment_Amount,@User_Login)";

                Cmd.Parameters.Add("Payment_Id", SqlDbType.Int).Value = tb_Payment_Id.Text;
                Cmd.Parameters.Add("R_Order_Id", SqlDbType.Int).Value = tb_Received_Order_Id.Text;
                Cmd.Parameters.Add("Pay_Date", SqlDbType.Date).Value = dtp_Payment_Date.Value.Date;
                Cmd.Parameters.Add("Payment_Media", SqlDbType.VarChar).Value = cmb_Payment_Media.Text;
                Cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;
                Cmd.Parameters.Add("Final_Bill", SqlDbType.Money).Value = tb_Final_Bill.Text;
                Cmd.Parameters.Add("Paid_Amount", SqlDbType.Money).Value = tb_Paid_Amount.Text;
                Cmd.Parameters.Add("Balanced_Amount", SqlDbType.Money).Value = tb_Balanced_Amount.Text;
                Cmd.Parameters.Add("Payment_Amount", SqlDbType.Money).Value = tb_Payment_Amount.Text;
                Cmd.Parameters.Add("User_login", SqlDbType.NVarChar).Value = Shared_Class.User_Login;

                Cmd.ExecuteNonQuery();
                Cmd.Dispose();

                double PaidAmount = (Convert.ToDouble(tb_Paid_Amount.Text) + Convert.ToDouble(tb_Payment_Amount.Text));
                

                Cmd.CommandText = "Update Received_Order_Details Set Paid_Amount = '" +PaidAmount+ "' Where R_Order_Id = '" + tb_Received_Order_Id.Text + "'";
                Cmd.ExecuteNonQuery();
                

                
                MessageBox.Show("Remeaning Payment of Received Order Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (PaidAmount == Convert.ToDouble(tb_Final_Bill.Text))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Update Received_Order_Details Set Status = @s Where R_Order_Id = @R", Connection.DBCon);
                    sda.SelectCommand.Parameters.Add(new SqlParameter("@s", SqlDbType.Int)).Value = false;
                    sda.SelectCommand.Parameters.Add(new SqlParameter("@R", SqlDbType.Int)).Value = tb_Received_Order_Id.Text;
                    DataTable dt1 = new DataTable();
                    sda.Fill(dt1);
                }
                Clear_Controls();
                tb_Received_Order_Id.Clear();
                tb_Received_Order_Id.Enabled = true;
                tb_Payment_Amount.Enabled = true;
                tb_Note.Enabled = true;
                cmb_Payment_Media.Enabled = true;
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
            tb_Received_Order_Id.Clear();
        }

        private void tb_Payment_Amount_TextChanged(object sender, EventArgs e)
        {
           if(tb_Payment_Amount.Text != "" && Convert.ToDouble(tb_Payment_Amount.Text) > Convert.ToDouble(tb_Balanced_Amount.Text))
            {
                ///tb_Payment_Amount.Text = "0";
                tb_Payment_Amount.Focus();
            }
        }

        private void tb_Balanced_Amount_Leave(object sender, EventArgs e)
        {
            if (tb_Balanced_Amount.Text == "")
            {
                tb_Balanced_Amount.Text = "0";
            }
        }
        private void tb_Payment_Amount_Leave(object sender, EventArgs e)
        {
            if (tb_Payment_Amount.Text == "")
            {
                tb_Payment_Amount.Text = "0";
            }
        }
        private void tb_Balanced_Amount_TextChanged(object sender, EventArgs e)
        {
            if (tb_Final_Bill.Text != "" && tb_Paid_Amount.Text != "" )
            {
                tb_Balanced_Amount.Text = (Convert.ToString(Convert.ToDouble(tb_Final_Bill.Text) - (Convert.ToDouble(tb_Paid_Amount.Text))));
            }
        }
    }           
}
