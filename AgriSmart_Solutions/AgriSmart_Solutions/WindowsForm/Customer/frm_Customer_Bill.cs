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

namespace AgriSmart_Solutions.WindowsForm.Customer
{
    public partial class frm_Customer_Bill : Form
    {
        public frm_Customer_Bill()
        {
            InitializeComponent();
        }

        int CStock = 0, SCnt = 1 , TStock = 0 ,EStock = 0;
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
            tb_Bill_Id.Text = Convert.ToString(Shared_Class.Auto_Incr("Customer_Details", "Bill_Id", 1001));

            dtp_Bill_Date.Text = "11/12/2024";
            tb_Customer_Name.Clear();
            tb_Address.Clear();
            tb_Mobile_No.Clear();
            tb_Total_Bill.Clear();
            tb_Discount.Clear();
            tb_GST.Clear();
            tb_Final_Bill.Clear();
            cmb_Payment_Media.SelectedIndex = -1;
        }
        private void frm_Customer_Bill_Load(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("P_Type", cmb_Product_Type, "Select distinct(P_Type) from Category_Details");

            tb_Bill_Id.Text = Convert.ToString(Shared_Class.Auto_Incr("Customer_Details", "Bill_Id", 1001));
            tb_Customer_Name.Focus();
            lbl_TStock.Visible = false;
            lbl_EStock.Visible = false;
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
          Shared_Class.Bind_Date_ComboBox("E_Date", cmb_Expiry_Date, "Select Distinct(E_Date) from Expiry_Details Where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "' And Unit = '" + cmb_Unit.Text + "'And Packing = '" + cmb_Packing.Text + "' And Status = '" + 1 +"'");

       
            Connection.Con_Open();
            SqlCommand Cmd = new SqlCommand("Select S_Price ,Current_Stock From Product_Details where P_Type = '" + cmb_Product_Type.Text + "' And P_Name = '" + cmb_Product_Name.Text + "' And Unit = '" + cmb_Unit.Text + "' And Packing = '" + cmb_Packing.Text + "'");
            Cmd.Connection = Connection.DBCon;

            SqlDataReader Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Price.Text = (Dr["S_Price"].ToString());
                CStock = Convert.ToInt32((Dr["Current_Stock"].ToString()));
            }
            Cmd.Dispose();
            Dr.Close();
            Connection.Con_Close();
            tb_Price.Enabled = true;
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

        void Add_Controls_Clear()
        {
            cmb_Product_Type.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            cmb_Unit.SelectedIndex = -1;
            cmb_Packing.SelectedIndex = -1;
            cmb_Expiry_Date.SelectedIndex = -1;
            tb_Qty.Clear();
            tb_Price.Clear();
            tb_Total_Price.Clear();
            lbl_TStock.Visible = false;
            lbl_EStock.Visible = false;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cmb_Product_Type.Text != "" && cmb_Product_Name.Text != "" && cmb_Packing.Text != "" && cmb_Unit.Text != "" && tb_Price.Text != "" && tb_Qty.Text != "" && tb_Total_Price.Text != "")
            {
                int flag = -1, Qty = Convert.ToInt32(tb_Qty.Text);

                for (int i = 0; i < dgv_Send_Order_List.Rows.Count ; i++)
                {
                    if ((Convert.ToString(dgv_Send_Order_List.Rows[i].Cells[2].Value) == cmb_Product_Name.Text) && (Convert.ToString(dgv_Send_Order_List.Rows[i].Cells[3].Value) == cmb_Packing.Text) && (Convert.ToString(dgv_Send_Order_List.Rows[i].Cells[4].Value) == cmb_Unit.Text))
                    {

                        flag = 0;

                        Qty += Convert.ToInt32(dgv_Send_Order_List.Rows[i].Cells[6].Value);

                        if (CStock >= Qty)
                        {
                            double Tot_Price = Convert.ToDouble(tb_Qty.Text) * Convert.ToDouble(tb_Total_Price.Text);

                            dgv_Send_Order_List.Rows[i].Cells[6].Value = Qty;
                            dgv_Send_Order_List.Rows[i].Cells[7].Value = Tot_Price;
                        }
                        else
                        {
                            MessageBox.Show("Can't Add More Quantity", "Insufficiant Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            flag = 1;

                            Add_Controls_Clear();
                        }
                    }
                }
                if (flag == -1)
                {
                    if (CStock >= Qty)
                    {
                        dgv_Send_Order_List.Rows.Add(SCnt, cmb_Product_Type.Text, cmb_Product_Name.Text, cmb_Packing.Text, cmb_Unit.Text, tb_Price.Text, tb_Qty.Text, tb_Total_Price.Text,cmb_Expiry_Date.Text);

                        SCnt++;
                    }
                    else
                    {
                        MessageBox.Show("No Enough Stock Available", "Insufficiant Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        flag = 1;
                    }
                }
                if (flag < 1)
                {
                    double Bill = Convert.ToDouble(tb_Total_Bill.Text) + Convert.ToDouble(tb_Total_Price.Text);

                    tb_Total_Bill.Text = Convert.ToString(Bill);
                    tb_Final_Bill.Text = Convert.ToString(Bill);
                }
                Add_Controls_Clear();
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
        private void tb_GST_Leave(object sender, EventArgs e)
        {
            if (tb_GST.Text == "")
            {
                tb_GST.Text = "0";
            }
        }
        private void tb_Discount_Leave(object sender, EventArgs e)
        {
            if (tb_Discount.Text == "")
            {
                tb_Discount.Text = "0";
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection.Con_Open();

            if(tb_Customer_Name.Text != "" && tb_Address.Text != "" && tb_Mobile_No.Text != "" && tb_Total_Bill.Text != "" && tb_Discount.Text != "" && tb_GST.Text != "" && tb_Final_Bill.Text != "" && cmb_Payment_Media.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Insert Into Customer_Details (Bill_Id, Bill_Date, C_Name, Address, Mobile_No, Total_Bill, Discount, Gst, Final_Bill, Payment_Media) Values(@B_Id, @B_Date, @C_Name,@Address, @MOB, @TotalBill, @Discount, @Gst, @Final_Bill, @Payment_Media)";

                Cmd.Parameters.Add("B_Id", SqlDbType.Int).Value = tb_Bill_Id.Text;
                Cmd.Parameters.Add("B_Date", SqlDbType.Date).Value = dtp_Bill_Date.Value.Date;
                Cmd.Parameters.Add("C_Name", SqlDbType.VarChar).Value = tb_Customer_Name.Text;
                Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("MOB", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("TotalBill", SqlDbType.Money).Value = tb_Total_Bill.Text;
                Cmd.Parameters.Add("Discount", SqlDbType.Int).Value = tb_Discount.Text;
                Cmd.Parameters.Add("Gst", SqlDbType.Int).Value = tb_GST.Text;
                Cmd.Parameters.Add("Final_Bill", SqlDbType.Money).Value = tb_Final_Bill.Text;
                Cmd.Parameters.Add("Payment_Media", SqlDbType.VarChar).Value = cmb_Payment_Media.Text;

                Cmd.ExecuteNonQuery();
                Cmd.Dispose();

                for( int i = 0; i < dgv_Send_Order_List.Rows.Count ; i++)
                {
                    SqlCommand Cmd1 = new SqlCommand("Insert Into Customer_Purchase_Details Values(@Bill_Id,@P_Type,@P_Name, @Packing, @Unit,@Price,@Qty,@Total_Price)",Connection.DBCon);

                    Cmd1.Parameters.Add("Bill_Id", SqlDbType.Int).Value = tb_Bill_Id.Text;
                    Cmd1.Parameters.Add("P_Type", SqlDbType.NVarChar).Value = dgv_Send_Order_List.Rows[i].Cells[1].Value;
                    Cmd1.Parameters.Add("P_Name", SqlDbType.NVarChar).Value = dgv_Send_Order_List.Rows[i].Cells[2].Value;                    
                    Cmd1.Parameters.Add("Packing", SqlDbType.Int).Value = dgv_Send_Order_List.Rows[i].Cells[3].Value;
                    Cmd1.Parameters.Add("Unit", SqlDbType.VarChar).Value = dgv_Send_Order_List.Rows[i].Cells[4].Value;
                    Cmd1.Parameters.Add("Price", SqlDbType.Money).Value = dgv_Send_Order_List.Rows[i].Cells[5].Value;
                    Cmd1.Parameters.Add("Qty", SqlDbType.Int).Value = dgv_Send_Order_List.Rows[i].Cells[6].Value;
                    Cmd1.Parameters.Add("Total_Price", SqlDbType.Money).Value = dgv_Send_Order_List.Rows[i].Cells[7].Value;
                    
                    Cmd1.ExecuteNonQuery();
                    Cmd1.Dispose();

                    int Saled_Qty = Convert.ToInt32(dgv_Send_Order_List.Rows[i].Cells[6].Value);
                    int P_C_Stock = 0;
                    int P_ID = 0;
                    int New_Stock = 0;

                    Cmd1.CommandText = "Select P_Id, Current_Stock From Product_Details Where P_Type = '" + dgv_Send_Order_List.Rows[i].Cells[1].Value + "' And P_Name = '" + dgv_Send_Order_List.Rows[i].Cells[2].Value + "' And Packing = '" + dgv_Send_Order_List.Rows[i].Cells[3].Value + "' And Unit = '" + dgv_Send_Order_List.Rows[i].Cells[4].Value + "'";
                    Cmd1.Connection = Connection.DBCon;
                    
                    SqlDataReader SDA = Cmd1.ExecuteReader();

                    if(SDA.Read())
                    {
                        P_ID = Convert.ToInt32((SDA["P_Id"].ToString()));
                        P_C_Stock = Convert.ToInt32((SDA["Current_Stock"].ToString()));
                    }

                    New_Stock = P_C_Stock - Saled_Qty;

                    SDA.Close();
                    Cmd1.Dispose();

                    SqlDataAdapter sda = new SqlDataAdapter("Update Product_Details Set Current_Stock = " + New_Stock + " Where P_Id = " + P_ID + "", Connection.DBCon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    ////  Expiry_Stock Decriment  

                    DateTime E_Date1 ;
                    E_Date1 = DateTime.Now;
                    DateTime E_Date = E_Date1.Date;
                    int P_E_C_Stock = 0;
                    int New_Stock1 = 0;
                 
                    Cmd1.CommandText = "Select E_Date,Stock From Expiry_Details Where P_Type =@pty And P_Name =@pn And Packing =@p And Unit =@u And E_Date=@e";
                    Cmd1.Connection = Connection.DBCon;

                    Cmd1.Parameters.Add("@pty",SqlDbType.NVarChar).Value = dgv_Send_Order_List.Rows[i].Cells[1].Value;
                    Cmd1.Parameters.Add("@pn", SqlDbType.NVarChar).Value = dgv_Send_Order_List.Rows[i].Cells[2].Value;
                    Cmd1.Parameters.Add("@p", SqlDbType.Int).Value = dgv_Send_Order_List.Rows[i].Cells[3].Value;
                    Cmd1.Parameters.Add("@u", SqlDbType.NVarChar).Value = dgv_Send_Order_List.Rows[i].Cells[4].Value;
                    Cmd1.Parameters.Add("@e", SqlDbType.Date).Value = dgv_Send_Order_List.Rows[i].Cells[8].Value;

                    SqlDataReader SDA1 = Cmd1.ExecuteReader();

                    if (SDA1.Read())
                    {
                        E_Date = Convert.ToDateTime((SDA1["E_Date"].ToString()));
                        P_E_C_Stock = Convert.ToInt32((SDA1["Stock"].ToString()));
                    }
                    New_Stock1 = P_E_C_Stock - Saled_Qty;

                    SDA1.Close();
                    Cmd1.Dispose();                  

                    DateTime Val = Convert.ToDateTime(E_Date);

                    DateTime Dt = Val.Date;

                    
                    if (P_E_C_Stock == Saled_Qty)
                    {
                        SqlDataAdapter sda1 = new SqlDataAdapter("Update Expiry_Details Set Stock = @stk,Status =@S Where E_Date = @ed", Connection.DBCon);
                        sda1.SelectCommand.Parameters.Add(new SqlParameter("@stk", SqlDbType.Int)).Value = New_Stock1;
                        sda1.SelectCommand.Parameters.Add(new SqlParameter("@ed", SqlDbType.Date)).Value = Dt;
                        sda1.SelectCommand.Parameters.Add(new SqlParameter("@S", SqlDbType.VarChar)).Value = 0;
                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);
                    }
                    else 
                    {
                        SqlDataAdapter sda1 = new SqlDataAdapter("Update Expiry_Details Set Stock = @stk Where E_Date = @ed", Connection.DBCon);
                        sda1.SelectCommand.Parameters.Add(new SqlParameter("@stk", SqlDbType.Int)).Value = New_Stock1;
                        sda1.SelectCommand.Parameters.Add(new SqlParameter("@ed", SqlDbType.Date)).Value = Dt;
                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);
                    }

                }
                MessageBox.Show("Customer Details Added Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Shared_Class.C_Id = Convert.ToInt32(tb_Bill_Id.Text);

                Reports.ReportForm.frm_Single_Customer_Bill Obj = new Reports.ReportForm.frm_Single_Customer_Bill();
                Obj.Show();

                Clear_Controls();
                Connection.Con_Close();
            }
            else
            {
                MessageBox.Show("1st Fill All Fields ", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cmb_Expiry_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Expiry_Date.Text != "")
            {
                TStock = CStock;
                lbl_TStock.Text = Convert.ToString(TStock);
                lbl_TStock.Visible = true;

                Connection.Con_Open();

                SqlCommand Cmd2 = new SqlCommand();
                Cmd2.Connection = Connection.DBCon;
                Cmd2.CommandText = "Select Stock From Expiry_Details where P_Type = @pt And P_Name = @Pn And Packing = @Pk And Unit = @Un And E_Date = @Dt And Status = @S";

                Cmd2.Parameters.Add("pt", SqlDbType.NVarChar).Value = cmb_Product_Type.Text;
                Cmd2.Parameters.Add("Pn", SqlDbType.NVarChar).Value = cmb_Product_Name.Text;
                Cmd2.Parameters.Add("Pk", SqlDbType.Int).Value = cmb_Packing.Text;
                Cmd2.Parameters.Add("Un", SqlDbType.VarChar).Value = cmb_Unit.Text;
                Cmd2.Parameters.Add("Dt", SqlDbType.Date).Value = cmb_Expiry_Date.Text;
                Cmd2.Parameters.Add("S", SqlDbType.VarChar).Value = 1;

                EStock = Convert.ToInt32(Cmd2.ExecuteScalar());

                Cmd2.Dispose();
                Connection.Con_Close();


                /// To Manage Expiry Date

                /*
                DateTime Today_Date = System.DateTime.Today.Date; 
                if(cmb_Expiry_Date.Text == Convert.ToString(Today_Date))
                {
                    int eStock = CStock - EStock;
                    SqlDataAdapter sda1 = new SqlDataAdapter("Update Product Details Set Current_Stock = @stk Where P_Type = @pt,P_Name =@pn,Packing=@p,Unit=@u", Connection.DBCon);
                    sda1.SelectCommand.Parameters.Add(new SqlParameter("@stk", SqlDbType.Int)).Value = eStock;
                    sda1.SelectCommand.Parameters.Add(new SqlParameter("@ed", SqlDbType.NVarChar)).Value = cmb_Product_Type.Text;
                    sda1.SelectCommand.Parameters.Add(new SqlParameter("@ed", SqlDbType.NVarChar)).Value = cmb_Product_Name;
                    sda1.SelectCommand.Parameters.Add(new SqlParameter("@ed", SqlDbType.Int)).Value = cmb_Packing.Text;
                    sda1.SelectCommand.Parameters.Add(new SqlParameter("@ed", SqlDbType.VarChar)).Value = cmb_Unit.Text;
                    

                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);

                    SqlDataAdapter sda2 = new SqlDataAdapter("Update Expiry_Details Set Status = @s Where E_Date = @e", Connection.DBCon);
                    sda2.SelectCommand.Parameters.Add(new SqlParameter("@s", SqlDbType.Int)).Value = false;
                    sda2.SelectCommand.Parameters.Add(new SqlParameter("@R", SqlDbType.Date)).Value = cmb_Expiry_Date.Text;
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);
                }
                */

                lbl_EStock.Text = Convert.ToString(EStock);
                lbl_EStock.Visible = true;
            }             
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }                                   
    }
}
