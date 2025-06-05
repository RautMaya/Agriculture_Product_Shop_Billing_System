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
    public partial class frm_Received_Order : Form
    {
        public frm_Received_Order()
        {
            InitializeComponent();
        }
        int  SCnt = 1;

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
        private void cmb_Product_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("P_Name", cmb_Product_Name, "Select Distinct(P_Name) from Product_Details where P_Type = '" + cmb_Product_Type.Text + "'");
        }
        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Unit", cmb_Unit, "Select Distinct(Unit) from Product_Details where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "'");
        }
        private void cmb_Unit_SelectedIndexChanged(object sender, EventArgs e)
        {           
            Shared_Class.Bind_ComboBox("Packing", cmb_Packing, "Select Packing from Product_Details where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "' And Unit = '" + cmb_Unit.Text + "'");
        }
        private void cmb_Packing_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection.Con_Open();

            SqlCommand Cmd = new SqlCommand("Select S_Price From Product_Details where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "' And Unit = '" + cmb_Unit.Text + "' And Packing = '" + cmb_Packing.Text + "'");
            Cmd.Connection = Connection.DBCon;

            SqlDataReader Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Price.Text = (Dr["S_Price"].ToString());
            }

            Cmd.Dispose();
            Dr.Close();
            Connection.Con_Close();
            tb_Price.Enabled = true;
        }
        void Clear_Controls()
        {
            tb_Received_Order_Id.Text = Convert.ToString(Shared_Class.Auto_Incr("Received_Order_Details", "R_Order_Id", 20001));

            cmb_Supplier_Name.SelectedIndex = -1;
            tb_Supplier_Company.Clear();
            cmb_Product_Type.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            cmb_Unit.SelectedIndex = -1;
            cmb_Packing.SelectedIndex = -1;
            tb_Price.Clear();
            tb_Qty.Clear();
            tb_Total_Price.Clear();

            dgv_Received_Order_List.Rows.Clear();

            tb_Total_Bill.Text = "0";
            tb_GST.Text = "0";
            tb_Discount.Text = "0";
            tb_Final_Bill.Text = "0";

            tb_Qty.Enabled = true;
            btn_Add.Enabled = true;

        }
        private void frm_Received_Order_Load(object sender, EventArgs e)
        {

           /// dtp_Expiry_Date.Format = DateTimePickerFormat.Custom;
            ///dtp_Expiry_Date.CustomFormat = "dd/MM/yyyy";
           
            Shared_Class.Bind_ComboBox("Sup_Name", cmb_Supplier_Name, "Select distinct(Sup_Name) from Supplier_Details");
            Shared_Class.Bind_ComboBox("P_Type", cmb_Product_Type, "Select distinct(P_Type) from Category_Details");
            Clear_Controls();

            cmb_Supplier_Name.Focus();


           
        }
        private void tb_Qty_TextChanged(object sender, EventArgs e)
        {
            if (tb_Qty.Text != "" && tb_Price.Text != "" && Convert.ToInt32(tb_Qty.Text) > 0)
            {
                double Amount = Convert.ToDouble(tb_Qty.Text) * Convert.ToDouble(tb_Price.Text);

                tb_Total_Price.Text = Convert.ToString(Amount);
            }
            btn_Add.Enabled = true;
        }
        private void cmb_Supplier_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection.Con_Open();


            SqlCommand Cmd = new SqlCommand("Select Sup_Company  From Supplier_Details where Sup_Name = '" + cmb_Supplier_Name.Text + "'");
            Cmd.Connection = Connection.DBCon;

            SqlDataReader Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Supplier_Company.Text = (Dr["Sup_Company"].ToString());
            }

            Cmd.Dispose();
            Dr.Close();
            Connection.Con_Close();           
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(cmb_Product_Type.Text != "" && cmb_Product_Name.Text != "" && cmb_Unit.Text!= "" && cmb_Packing.Text != ""  && tb_Price.Text != "" &&  dtp_Manufacture_Date.Text != "" &&dtp_Expiry_Date.Text != "" && tb_Qty.Text != "" && tb_Total_Price.Text != "")
            {
                int flag = -1, Qty = Convert.ToInt32(tb_Qty.Text);

                for(int i=0; i < dgv_Received_Order_List.Rows.Count; i++)
                {
                    if((Convert.ToString(dgv_Received_Order_List.Rows[i].Cells[2].Value) == cmb_Product_Name.Text) && (Convert.ToString(dgv_Received_Order_List.Rows[i].Cells[3].Value) == cmb_Packing.Text) && (Convert.ToString(dgv_Received_Order_List.Rows[i].Cells[4].Value) == cmb_Unit.Text))
                    {
                        flag = 0;

                        Qty += Convert.ToInt32(dgv_Received_Order_List.Rows[i].Cells[8].Value);

                        double Tot_Price = Convert.ToDouble(Qty) * Convert.ToDouble(tb_Total_Price.Text);

                        dgv_Received_Order_List.Rows[i].Cells[8].Value = Qty;
                        dgv_Received_Order_List.Rows[i].Cells[9].Value = Tot_Price;
                    }
                }
                if (flag == -1)
                {
                    dgv_Received_Order_List.Rows.Add(SCnt, cmb_Product_Type.Text, cmb_Product_Name.Text, cmb_Packing.Text, cmb_Unit.Text, tb_Price.Text, dtp_Manufacture_Date.Text, dtp_Expiry_Date.Text, tb_Qty.Text, tb_Total_Price.Text);

                    SCnt++;                  
                
                }
                if (flag < 1)
                {
                    double Bill = Convert.ToDouble(tb_Total_Bill.Text) + Convert.ToDouble(tb_Total_Price.Text);

                    tb_Total_Bill.Text = Convert.ToString(Bill);
                    tb_Final_Bill.Text = Convert.ToString(Bill);
                }
                cmb_Product_Type.SelectedIndex = -1;
                cmb_Product_Name.SelectedIndex = -1;
                cmb_Unit.SelectedIndex = -1;
                cmb_Packing.SelectedIndex = -1;
                tb_Qty.Clear();
                tb_Price.Clear();
                tb_Total_Price.Clear();
            }
        }
        private void tb_Discount_Leave(object sender, EventArgs e)
        {
            if(tb_Discount.Text == "")
            {
                tb_Discount.Text = "0";
            }
        }
        private void tb_GST_Leave(object sender, EventArgs e)
        {
            if(tb_GST.Text == "")
            {
                tb_GST.Text = "0";
            }
        }
        private void tb_Qty_Leave(object sender, EventArgs e)
        {
            if (tb_Qty.Text == "" || tb_Qty.Text == " ")
            {
                MessageBox.Show("Invalid Quantity!!!");
                tb_Qty.Text = "0";
                tb_Qty.Focus();
                btn_Add.Enabled = false;
            }
        }       
        private void tb_GST_TextChanged(object sender, EventArgs e)
        {
            if (tb_GST.Text != "" && Convert.ToDouble(tb_GST.Text) > 10)
            {
                MessageBox.Show("Invalid Value");
                tb_GST.Text = "0";
            }
            else if (tb_Total_Bill.Text != "" && tb_Discount.Text != "")
            {
                double Disc_Amount = (Convert.ToDouble(tb_Total_Bill.Text) * Convert.ToDouble(tb_Discount.Text)) / 100;
                double GST_Amount = (Convert.ToDouble(tb_Total_Bill.Text) * Convert.ToDouble(tb_GST.Text)) / 100;

                tb_Final_Bill.Text = Convert.ToString(Convert.ToDouble(tb_Total_Bill.Text) - Disc_Amount + GST_Amount);
            }
        }

        private void tb_Discount_TextChanged(object sender, EventArgs e)
        {
            if (tb_Discount.Text != "" && Convert.ToDouble(tb_Discount.Text) > 10)
            {
                MessageBox.Show("Invalid Value");
                tb_Discount.Text = "0";
            }
            else if (tb_Total_Bill.Text != "" && tb_Discount.Text != "")
            {
                double Disc_Amount = (Convert.ToDouble(tb_Total_Bill.Text) * Convert.ToDouble(tb_Discount.Text)) / 100;
                double GST_Amount = (Convert.ToDouble(tb_Total_Bill.Text) * Convert.ToDouble(tb_GST.Text)) / 100;

                tb_Final_Bill.Text = Convert.ToString(Convert.ToDouble(tb_Total_Bill.Text) - Disc_Amount + GST_Amount);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cmb_Supplier_Name.Text != "" && tb_Supplier_Company.Text != "" && SCnt > 1 && tb_Total_Bill.Text != "" && tb_Final_Bill.Text != "" && tb_GST.Text != "" && tb_Discount.Text != "")
            {
                Connection.Con_Open();

                SqlCommand Cmd = new SqlCommand("Insert Into Received_Order_Details Values (@R_Order_Id, @R_Order_Date, @S_Name, @S_Company, @Total_Bill, @Discount, @Gst, @Final_Bill,@Paid_Amount,@Status,@User_Login)", Connection.DBCon);

                
                Cmd.Parameters.Add("R_Order_Id", SqlDbType.Int).Value = tb_Received_Order_Id.Text;
                Cmd.Parameters.Add("R_Order_Date", SqlDbType.Date).Value = dtp_Received_Order_Date.Value.Date;
                Cmd.Parameters.Add("S_Name", SqlDbType.VarChar).Value = cmb_Supplier_Name.Text;
                Cmd.Parameters.Add("S_Company", SqlDbType.VarChar).Value = tb_Supplier_Company.Text;
                Cmd.Parameters.Add("Total_Bill", SqlDbType.Money).Value = tb_Total_Bill.Text;
                Cmd.Parameters.Add("Discount", SqlDbType.Float).Value = tb_Discount.Text;
                Cmd.Parameters.Add("Gst", SqlDbType.Float).Value = tb_GST.Text;
                Cmd.Parameters.Add("Final_Bill", SqlDbType.Money).Value = tb_Final_Bill.Text;
                Cmd.Parameters.Add("Paid_Amount", SqlDbType.Money).Value = 0;
                Cmd.Parameters.Add("Status", SqlDbType.Int).Value = 1;
                Cmd.Parameters.Add("User_Login", SqlDbType.NVarChar).Value = Shared_Class.User_Login;

                Cmd.ExecuteNonQuery();
                Cmd.Dispose();

                for (int i = 0; i < dgv_Received_Order_List.Rows.Count; i++)
                {
                    SqlCommand Cmd1 = new SqlCommand("Insert Into Received_Order_Purchase_Details Values (@R_Order_Id, @P_Type, @P_Name, @Packing, @Unit, @Price , @M_Date, @E_Date, @Qty, @Total_Price)", Connection.DBCon);
                   
                    Cmd1.Parameters.Add("R_Order_Id", SqlDbType.Int).Value = tb_Received_Order_Id.Text;
                    Cmd1.Parameters.Add("P_Type", SqlDbType.NVarChar).Value = dgv_Received_Order_List.Rows[i].Cells[1].Value;
                    Cmd1.Parameters.Add("P_Name", SqlDbType.NVarChar).Value = dgv_Received_Order_List.Rows[i].Cells[2].Value;
                    Cmd1.Parameters.Add("Packing", SqlDbType.Int).Value = dgv_Received_Order_List.Rows[i].Cells[3].Value;
                    Cmd1.Parameters.Add("Unit", SqlDbType.VarChar).Value = dgv_Received_Order_List.Rows[i].Cells[4].Value;
                    Cmd1.Parameters.Add("Price", SqlDbType.Money).Value = dgv_Received_Order_List.Rows[i].Cells[5].Value;
                    Cmd1.Parameters.Add("M_Date", SqlDbType.Date).Value = dgv_Received_Order_List.Rows[i].Cells[6].Value;
                    Cmd1.Parameters.Add("E_Date", SqlDbType.Date).Value = dgv_Received_Order_List.Rows[i].Cells[7].Value;
                    Cmd1.Parameters.Add("Qty", SqlDbType.Int).Value = dgv_Received_Order_List.Rows[i].Cells[8].Value;
                    Cmd1.Parameters.Add("Total_Price", SqlDbType.Money).Value = dgv_Received_Order_List.Rows[i].Cells[9].Value;

                    Cmd1.ExecuteNonQuery();
                    Cmd1.Dispose();

                    int Purchase_Qty = Convert.ToInt32(dgv_Received_Order_List.Rows[i].Cells[8].Value);
                    int P_Stock = 0;
                    int P_ID = 0;
                    int New_Stock = 0;

                    Cmd1.CommandText = "Select P_Id, Current_Stock From Product_Details where P_Type = '" + dgv_Received_Order_List.Rows[i].Cells[1].Value + "' And P_Name = '" + dgv_Received_Order_List.Rows[i].Cells[2].Value + "' And Packing = '" + dgv_Received_Order_List.Rows[i].Cells[3].Value + "' And Unit = '" + dgv_Received_Order_List.Rows[i].Cells[4].Value + "'";
                    Cmd1.Connection = Connection.DBCon;

                    SqlDataReader SDA = Cmd1.ExecuteReader();

                    if(SDA.Read())
                    {
                        P_ID = Convert.ToInt32((SDA["P_Id"].ToString()));
                        P_Stock = Convert.ToInt32((SDA["Current_Stock"].ToString()));
                    }

                    New_Stock = P_Stock + Purchase_Qty;

                    SDA.Close();
                    Cmd1.Dispose();

                    SqlDataAdapter sda = new SqlDataAdapter("Update Product_Details Set Current_Stock = " + New_Stock + " Where P_Id = " + P_ID + "",Connection.DBCon );

                    DataTable dt = new DataTable();

                    sda.Fill(dt);

                    ///Expiry_Details Table 
                    
                    SqlCommand Cmd2 = new SqlCommand("Insert Into Expiry_Details Values (@R_Order_Id, @P_Type, @P_Name, @Packing, @Unit,@E_Date,@Stock,@Status)", Connection.DBCon);

                    Cmd2.Parameters.Add("R_Order_Id", SqlDbType.Int).Value = tb_Received_Order_Id.Text;
                    Cmd2.Parameters.Add("P_Type", SqlDbType.NVarChar).Value = dgv_Received_Order_List.Rows[i].Cells[1].Value;
                    Cmd2.Parameters.Add("P_Name", SqlDbType.NVarChar).Value = dgv_Received_Order_List.Rows[i].Cells[2].Value;
                    Cmd2.Parameters.Add("Packing", SqlDbType.Int).Value = dgv_Received_Order_List.Rows[i].Cells[3].Value;
                    Cmd2.Parameters.Add("Unit", SqlDbType.VarChar).Value = dgv_Received_Order_List.Rows[i].Cells[4].Value;
                    Cmd2.Parameters.Add("E_Date", SqlDbType.Date).Value = dgv_Received_Order_List.Rows[i].Cells[7].Value;
                    Cmd2.Parameters.Add("Stock", SqlDbType.Int).Value = dgv_Received_Order_List.Rows[i].Cells[8].Value;
                    Cmd2.Parameters.Add("Status", SqlDbType.Int).Value = 1;

                    Cmd2.ExecuteNonQuery();
                    Cmd2.Dispose();
                }

                DialogResult DR = MessageBox.Show("Order Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if(DR == DialogResult.OK)
                {
                    Shared_Class.Flag = 3;
                    int id = Convert.ToInt32(tb_Received_Order_Id.Text);
                    string date = Convert.ToString(dtp_Received_Order_Date.Text);
                    double bill = Convert.ToDouble(tb_Final_Bill.Text);
                    WindowsForm.Stock.frm_Received_Order_Payment Obj = new WindowsForm.Stock.frm_Received_Order_Payment(id,date,bill) { TopLevel = false, TopMost = true };
                    Obj.FormBorderStyle = FormBorderStyle.None;

                    WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Clear();
                    WindowsForm.MDI.MDI_AgriSmart_Solutions.pnl_Container.Controls.Add(Obj);
                    Obj.Show();
                }
                Clear_Controls();

                Connection.Con_Close();
            }
            else
            {
                MessageBox.Show("Fill Supplier & Purchase Details Properly", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}   

