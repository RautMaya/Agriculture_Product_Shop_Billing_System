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

namespace AgriSmart_Solutions.WindowsForm.Expence
{
    public partial class frm_Shop_Expence : Form
    {
        public frm_Shop_Expence()
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
            tb_Expence_Id.Text = Convert.ToString(Shared_Class.Auto_Incr("Expence_Details", "Exp_Id", 30001));

            
            dtp_Expence_Date.ResetText();
            tb_Expence_Details.Clear();
            pb_Bill_Image.Image = null;
            tb_Total_Amount.Clear();
            tb_Paid_By.Clear();
            cmb_Payment_Media.SelectedIndex = -1;
        }

        private void frm_Shop_Expence_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            dtp_Expence_Date.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection.Con_Open();

            if (tb_Expence_Details.Text != "" && tb_Total_Amount.Text != "" && cmb_Payment_Media.Text != "" && tb_Paid_By.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Insert Into Expence_Details Values(@Exp_Id,@Exp_Date,@Exp_Details,@Bill_Image,@Total_Amount,@Payment_Media,@Paid_By,@User_Login,@Status)";

                Cmd.Parameters.Add("Exp_Id", SqlDbType.Int).Value = tb_Expence_Id.Text;
                Cmd.Parameters.Add("Exp_Date", SqlDbType.Date).Value = dtp_Expence_Date.Value.Date;
                Cmd.Parameters.Add("Exp_Details", SqlDbType.NVarChar).Value = tb_Expence_Details.Text;
                Cmd.Parameters.Add("Total_Amount", SqlDbType.Money).Value = tb_Total_Amount.Text;
                Cmd.Parameters.Add("Payment_Media", SqlDbType.VarChar).Value = cmb_Payment_Media.Text;
                Cmd.Parameters.Add("Paid_By", SqlDbType.VarChar).Value = tb_Paid_By.Text;
                Cmd.Parameters.Add("User_Login", SqlDbType.NVarChar).Value = Shared_Class.User_Login;
                Cmd.Parameters.Add("Status", SqlDbType.Int).Value = 1;

                ImageConverter IC = new ImageConverter();
                byte[] imgArray = (byte[])IC.ConvertTo(pb_Bill_Image.Image, typeof(byte[]));

                Cmd.Parameters.Add("@Bill_Image", SqlDbType.Image).Value = imgArray;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Expence Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill All Fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Connection.Con_Close();
        }

        private void btn_Add_Bill_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Image Files(*.jpg; *.png; *.gif; *.ico; *.bmp)| *.jpg; *.png; *.gif; *.ico; *.bmp";

            if(OFD.ShowDialog() == DialogResult.OK)
            {
                pb_Bill_Image.Image = new Bitmap(OFD.FileName);
            }
        }
    }
}
