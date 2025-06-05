
namespace AgriSmart_Solutions.WindowsForm.Stock
{
    partial class frm_Received_Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_Price_Details = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Final_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Final_Bill = new System.Windows.Forms.Label();
            this.tb_GST = new System.Windows.Forms.TextBox();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.tb_Total_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Total_Bill = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Order_Details = new System.Windows.Forms.GroupBox();
            this.dgv_Received_Order_List = new System.Windows.Forms.DataGridView();
            this.Sr_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Packing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_Packing = new System.Windows.Forms.ComboBox();
            this.cmb_Unit = new System.Windows.Forms.ComboBox();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.dtp_Expiry_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Packing = new System.Windows.Forms.Label();
            this.lbl_Expiry_Date = new System.Windows.Forms.Label();
            this.dtp_Manufacture_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Manufacture_Date = new System.Windows.Forms.Label();
            this.lbl_Product_Type = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Product_Type = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_Total_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.tb_Qty = new System.Windows.Forms.TextBox();
            this.lbl_Oty = new System.Windows.Forms.Label();
            this.gb_Received_Order_Details = new System.Windows.Forms.GroupBox();
            this.cmb_Supplier_Name = new System.Windows.Forms.ComboBox();
            this.tb_Supplier_Company = new System.Windows.Forms.TextBox();
            this.lbl_Supplier_Company = new System.Windows.Forms.Label();
            this.lbl_Received_Order_Date = new System.Windows.Forms.Label();
            this.dtp_Received_Order_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.tb_Received_Order_Id = new System.Windows.Forms.TextBox();
            this.lbl_Received_Order_Id = new System.Windows.Forms.Label();
            this.gb_Price_Details.SuspendLayout();
            this.gb_Order_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Received_Order_List)).BeginInit();
            this.gb_Received_Order_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Price_Details
            // 
            this.gb_Price_Details.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Price_Details.Controls.Add(this.label3);
            this.gb_Price_Details.Controls.Add(this.label2);
            this.gb_Price_Details.Controls.Add(this.tb_Final_Bill);
            this.gb_Price_Details.Controls.Add(this.lbl_Final_Bill);
            this.gb_Price_Details.Controls.Add(this.tb_GST);
            this.gb_Price_Details.Controls.Add(this.lbl_GST);
            this.gb_Price_Details.Controls.Add(this.tb_Discount);
            this.gb_Price_Details.Controls.Add(this.lbl_Discount);
            this.gb_Price_Details.Controls.Add(this.tb_Total_Bill);
            this.gb_Price_Details.Controls.Add(this.lbl_Total_Bill);
            this.gb_Price_Details.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Price_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Price_Details.Location = new System.Drawing.Point(12, 558);
            this.gb_Price_Details.Name = "gb_Price_Details";
            this.gb_Price_Details.Size = new System.Drawing.Size(1262, 95);
            this.gb_Price_Details.TabIndex = 3;
            this.gb_Price_Details.TabStop = false;
            this.gb_Price_Details.Text = "Price Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(817, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(569, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "%";
            // 
            // tb_Final_Bill
            // 
            this.tb_Final_Bill.BackColor = System.Drawing.Color.White;
            this.tb_Final_Bill.Enabled = false;
            this.tb_Final_Bill.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Final_Bill.Location = new System.Drawing.Point(1014, 31);
            this.tb_Final_Bill.MaxLength = 8;
            this.tb_Final_Bill.Name = "tb_Final_Bill";
            this.tb_Final_Bill.Size = new System.Drawing.Size(237, 33);
            this.tb_Final_Bill.TabIndex = 0;
            this.tb_Final_Bill.Text = "0";
            this.tb_Final_Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Final_Bill
            // 
            this.lbl_Final_Bill.AutoSize = true;
            this.lbl_Final_Bill.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Final_Bill.ForeColor = System.Drawing.Color.Black;
            this.lbl_Final_Bill.Location = new System.Drawing.Point(893, 35);
            this.lbl_Final_Bill.Name = "lbl_Final_Bill";
            this.lbl_Final_Bill.Size = new System.Drawing.Size(110, 27);
            this.lbl_Final_Bill.TabIndex = 33;
            this.lbl_Final_Bill.Text = "Final Bill :";
            // 
            // tb_GST
            // 
            this.tb_GST.BackColor = System.Drawing.Color.White;
            this.tb_GST.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST.Location = new System.Drawing.Point(699, 33);
            this.tb_GST.MaxLength = 2;
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(112, 33);
            this.tb_GST.TabIndex = 14;
            this.tb_GST.TextChanged += new System.EventHandler(this.tb_GST_TextChanged);
            this.tb_GST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_GST.Leave += new System.EventHandler(this.tb_GST_Leave);
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST.ForeColor = System.Drawing.Color.Black;
            this.lbl_GST.Location = new System.Drawing.Point(639, 39);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(54, 27);
            this.lbl_GST.TabIndex = 31;
            this.lbl_GST.Text = "GST";
            // 
            // tb_Discount
            // 
            this.tb_Discount.BackColor = System.Drawing.Color.White;
            this.tb_Discount.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Discount.Location = new System.Drawing.Point(459, 33);
            this.tb_Discount.MaxLength = 2;
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(104, 33);
            this.tb_Discount.TabIndex = 13;
            this.tb_Discount.TextChanged += new System.EventHandler(this.tb_Discount_TextChanged);
            this.tb_Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Discount.Leave += new System.EventHandler(this.tb_Discount_Leave);
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.ForeColor = System.Drawing.Color.Black;
            this.lbl_Discount.Location = new System.Drawing.Point(353, 35);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(100, 27);
            this.lbl_Discount.TabIndex = 29;
            this.lbl_Discount.Text = "Discount";
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.BackColor = System.Drawing.Color.White;
            this.tb_Total_Bill.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.Location = new System.Drawing.Point(112, 35);
            this.tb_Total_Bill.MaxLength = 8;
            this.tb_Total_Bill.Name = "tb_Total_Bill";
            this.tb_Total_Bill.Size = new System.Drawing.Size(205, 33);
            this.tb_Total_Bill.TabIndex = 0;
            this.tb_Total_Bill.Text = "0";
            this.tb_Total_Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.AutoSize = true;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.ForeColor = System.Drawing.Color.Black;
            this.lbl_Total_Bill.Location = new System.Drawing.Point(6, 39);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(112, 27);
            this.lbl_Total_Bill.TabIndex = 27;
            this.lbl_Total_Bill.Text = "Total Bill :";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(235, 659);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(243, 58);
            this.btn_Refresh.TabIndex = 21;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(821, 659);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(243, 58);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gb_Order_Details
            // 
            this.gb_Order_Details.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Order_Details.Controls.Add(this.dgv_Received_Order_List);
            this.gb_Order_Details.Controls.Add(this.cmb_Packing);
            this.gb_Order_Details.Controls.Add(this.cmb_Unit);
            this.gb_Order_Details.Controls.Add(this.lbl_Weight);
            this.gb_Order_Details.Controls.Add(this.dtp_Expiry_Date);
            this.gb_Order_Details.Controls.Add(this.lbl_Packing);
            this.gb_Order_Details.Controls.Add(this.lbl_Expiry_Date);
            this.gb_Order_Details.Controls.Add(this.dtp_Manufacture_Date);
            this.gb_Order_Details.Controls.Add(this.lbl_Manufacture_Date);
            this.gb_Order_Details.Controls.Add(this.lbl_Product_Type);
            this.gb_Order_Details.Controls.Add(this.lbl_Product_Name);
            this.gb_Order_Details.Controls.Add(this.cmb_Product_Name);
            this.gb_Order_Details.Controls.Add(this.cmb_Product_Type);
            this.gb_Order_Details.Controls.Add(this.btn_Add);
            this.gb_Order_Details.Controls.Add(this.tb_Total_Price);
            this.gb_Order_Details.Controls.Add(this.label1);
            this.gb_Order_Details.Controls.Add(this.tb_Price);
            this.gb_Order_Details.Controls.Add(this.lbl_Price);
            this.gb_Order_Details.Controls.Add(this.tb_Qty);
            this.gb_Order_Details.Controls.Add(this.lbl_Oty);
            this.gb_Order_Details.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Order_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Order_Details.Location = new System.Drawing.Point(12, 133);
            this.gb_Order_Details.Name = "gb_Order_Details";
            this.gb_Order_Details.Size = new System.Drawing.Size(1262, 419);
            this.gb_Order_Details.TabIndex = 2;
            this.gb_Order_Details.TabStop = false;
            this.gb_Order_Details.Text = "Order Details";
            // 
            // dgv_Received_Order_List
            // 
            this.dgv_Received_Order_List.AllowUserToAddRows = false;
            this.dgv_Received_Order_List.AllowUserToDeleteRows = false;
            this.dgv_Received_Order_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Received_Order_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Received_Order_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Received_Order_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr_No,
            this.P_Type,
            this.P_Name,
            this.Packing,
            this.Unit,
            this.Price,
            this.M_Date,
            this.E_Date,
            this.Qty,
            this.Total_Price});
            this.dgv_Received_Order_List.Location = new System.Drawing.Point(6, 204);
            this.dgv_Received_Order_List.Name = "dgv_Received_Order_List";
            this.dgv_Received_Order_List.ReadOnly = true;
            this.dgv_Received_Order_List.RowHeadersWidth = 51;
            this.dgv_Received_Order_List.RowTemplate.Height = 24;
            this.dgv_Received_Order_List.Size = new System.Drawing.Size(1245, 209);
            this.dgv_Received_Order_List.TabIndex = 62;
            // 
            // Sr_No
            // 
            this.Sr_No.HeaderText = "Sr.No";
            this.Sr_No.MinimumWidth = 6;
            this.Sr_No.Name = "Sr_No";
            this.Sr_No.ReadOnly = true;
            // 
            // P_Type
            // 
            this.P_Type.HeaderText = "Product Type";
            this.P_Type.MinimumWidth = 6;
            this.P_Type.Name = "P_Type";
            this.P_Type.ReadOnly = true;
            // 
            // P_Name
            // 
            this.P_Name.HeaderText = "Product Name";
            this.P_Name.MinimumWidth = 6;
            this.P_Name.Name = "P_Name";
            this.P_Name.ReadOnly = true;
            // 
            // Packing
            // 
            this.Packing.HeaderText = "Packing";
            this.Packing.MinimumWidth = 6;
            this.Packing.Name = "Packing";
            this.Packing.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // M_Date
            // 
            this.M_Date.HeaderText = "Manufacture Date";
            this.M_Date.MinimumWidth = 6;
            this.M_Date.Name = "M_Date";
            this.M_Date.ReadOnly = true;
            // 
            // E_Date
            // 
            this.E_Date.HeaderText = "Expiry Date";
            this.E_Date.MinimumWidth = 6;
            this.E_Date.Name = "E_Date";
            this.E_Date.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Total_Price
            // 
            this.Total_Price.HeaderText = "Total Price";
            this.Total_Price.MinimumWidth = 6;
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.ReadOnly = true;
            // 
            // cmb_Packing
            // 
            this.cmb_Packing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Packing.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Packing.FormattingEnabled = true;
            this.cmb_Packing.Location = new System.Drawing.Point(1029, 22);
            this.cmb_Packing.Name = "cmb_Packing";
            this.cmb_Packing.Size = new System.Drawing.Size(135, 34);
            this.cmb_Packing.TabIndex = 8;
            this.cmb_Packing.SelectedIndexChanged += new System.EventHandler(this.cmb_Packing_SelectedIndexChanged);
            // 
            // cmb_Unit
            // 
            this.cmb_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Unit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Unit.FormattingEnabled = true;
            this.cmb_Unit.IntegralHeight = false;
            this.cmb_Unit.Items.AddRange(new object[] {
            "Kg",
            "Gm",
            "Ltr",
            "ML",
            "Qty"});
            this.cmb_Unit.Location = new System.Drawing.Point(1170, 22);
            this.cmb_Unit.MaxLength = 50;
            this.cmb_Unit.Name = "cmb_Unit";
            this.cmb_Unit.Size = new System.Drawing.Size(84, 34);
            this.cmb_Unit.TabIndex = 7;
            this.cmb_Unit.SelectedIndexChanged += new System.EventHandler(this.cmb_Unit_SelectedIndexChanged);
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Weight.ForeColor = System.Drawing.Color.Black;
            this.lbl_Weight.Location = new System.Drawing.Point(943, 46);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(86, 23);
            this.lbl_Weight.TabIndex = 61;
            this.lbl_Weight.Text = "(Weight)";
            // 
            // dtp_Expiry_Date
            // 
            this.dtp_Expiry_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Expiry_Date.Location = new System.Drawing.Point(647, 92);
            this.dtp_Expiry_Date.Name = "dtp_Expiry_Date";
            this.dtp_Expiry_Date.Size = new System.Drawing.Size(268, 34);
            this.dtp_Expiry_Date.TabIndex = 10;
            this.dtp_Expiry_Date.Value = new System.DateTime(2025, 2, 14, 0, 0, 0, 0);
            // 
            // lbl_Packing
            // 
            this.lbl_Packing.AutoSize = true;
            this.lbl_Packing.Font = new System.Drawing.Font("Georgia", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Packing.ForeColor = System.Drawing.Color.Black;
            this.lbl_Packing.Location = new System.Drawing.Point(942, 19);
            this.lbl_Packing.Name = "lbl_Packing";
            this.lbl_Packing.Size = new System.Drawing.Size(88, 27);
            this.lbl_Packing.TabIndex = 60;
            this.lbl_Packing.Text = "Packing";
            // 
            // lbl_Expiry_Date
            // 
            this.lbl_Expiry_Date.AutoSize = true;
            this.lbl_Expiry_Date.Font = new System.Drawing.Font("Georgia", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expiry_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Expiry_Date.Location = new System.Drawing.Point(475, 92);
            this.lbl_Expiry_Date.Name = "lbl_Expiry_Date";
            this.lbl_Expiry_Date.Size = new System.Drawing.Size(127, 27);
            this.lbl_Expiry_Date.TabIndex = 47;
            this.lbl_Expiry_Date.Text = "Expiry Date";
            // 
            // dtp_Manufacture_Date
            // 
            this.dtp_Manufacture_Date.CustomFormat = "dd-MM-yyyy";
            this.dtp_Manufacture_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Manufacture_Date.Location = new System.Drawing.Point(210, 92);
            this.dtp_Manufacture_Date.Name = "dtp_Manufacture_Date";
            this.dtp_Manufacture_Date.Size = new System.Drawing.Size(243, 34);
            this.dtp_Manufacture_Date.TabIndex = 9;
            this.dtp_Manufacture_Date.Value = new System.DateTime(2025, 2, 23, 0, 0, 0, 0);
            // 
            // lbl_Manufacture_Date
            // 
            this.lbl_Manufacture_Date.AutoSize = true;
            this.lbl_Manufacture_Date.Font = new System.Drawing.Font("Georgia", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Manufacture_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Manufacture_Date.Location = new System.Drawing.Point(6, 92);
            this.lbl_Manufacture_Date.Name = "lbl_Manufacture_Date";
            this.lbl_Manufacture_Date.Size = new System.Drawing.Size(189, 27);
            this.lbl_Manufacture_Date.TabIndex = 46;
            this.lbl_Manufacture_Date.Text = "Manufacture Date";
            // 
            // lbl_Product_Type
            // 
            this.lbl_Product_Type.AutoSize = true;
            this.lbl_Product_Type.Font = new System.Drawing.Font("Georgia", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Type.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product_Type.Location = new System.Drawing.Point(6, 22);
            this.lbl_Product_Type.Name = "lbl_Product_Type";
            this.lbl_Product_Type.Size = new System.Drawing.Size(144, 27);
            this.lbl_Product_Type.TabIndex = 58;
            this.lbl_Product_Type.Text = "Product Type";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Georgia", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product_Name.Location = new System.Drawing.Point(472, 22);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(153, 27);
            this.lbl_Product_Name.TabIndex = 57;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(647, 22);
            this.cmb_Product_Name.MaxLength = 30;
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(268, 34);
            this.cmb_Product_Name.TabIndex = 6;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
            // 
            // cmb_Product_Type
            // 
            this.cmb_Product_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Type.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Type.FormattingEnabled = true;
            this.cmb_Product_Type.Location = new System.Drawing.Point(210, 22);
            this.cmb_Product_Type.MaxLength = 20;
            this.cmb_Product_Type.Name = "cmb_Product_Type";
            this.cmb_Product_Type.Size = new System.Drawing.Size(243, 34);
            this.cmb_Product_Type.TabIndex = 5;
            this.cmb_Product_Type.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Type_SelectedIndexChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(1089, 124);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(167, 62);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Total_Price
            // 
            this.tb_Total_Price.BackColor = System.Drawing.Color.White;
            this.tb_Total_Price.Enabled = false;
            this.tb_Total_Price.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Price.Location = new System.Drawing.Point(866, 138);
            this.tb_Total_Price.MaxLength = 8;
            this.tb_Total_Price.Name = "tb_Total_Price";
            this.tb_Total_Price.Size = new System.Drawing.Size(206, 42);
            this.tb_Total_Price.TabIndex = 0;
            this.tb_Total_Price.Text = "0";
            this.tb_Total_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(694, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "Total Price ";
            // 
            // tb_Price
            // 
            this.tb_Price.BackColor = System.Drawing.Color.White;
            this.tb_Price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(210, 149);
            this.tb_Price.MaxLength = 8;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(216, 34);
            this.tb_Price.TabIndex = 8;
            this.tb_Price.Text = "0";
            this.tb_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.Black;
            this.lbl_Price.Location = new System.Drawing.Point(8, 154);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(82, 29);
            this.lbl_Price.TabIndex = 40;
            this.lbl_Price.Text = "Price :";
            // 
            // tb_Qty
            // 
            this.tb_Qty.BackColor = System.Drawing.Color.White;
            this.tb_Qty.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Qty.Location = new System.Drawing.Point(528, 149);
            this.tb_Qty.MaxLength = 6;
            this.tb_Qty.Name = "tb_Qty";
            this.tb_Qty.Size = new System.Drawing.Size(136, 34);
            this.tb_Qty.TabIndex = 11;
            this.tb_Qty.TextChanged += new System.EventHandler(this.tb_Qty_TextChanged);
            this.tb_Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Qty.Leave += new System.EventHandler(this.tb_Qty_Leave);
            // 
            // lbl_Oty
            // 
            this.lbl_Oty.AutoSize = true;
            this.lbl_Oty.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Oty.ForeColor = System.Drawing.Color.Black;
            this.lbl_Oty.Location = new System.Drawing.Point(446, 151);
            this.lbl_Oty.Name = "lbl_Oty";
            this.lbl_Oty.Size = new System.Drawing.Size(65, 29);
            this.lbl_Oty.TabIndex = 38;
            this.lbl_Oty.Text = "Qty :";
            // 
            // gb_Received_Order_Details
            // 
            this.gb_Received_Order_Details.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Received_Order_Details.Controls.Add(this.cmb_Supplier_Name);
            this.gb_Received_Order_Details.Controls.Add(this.tb_Supplier_Company);
            this.gb_Received_Order_Details.Controls.Add(this.lbl_Supplier_Company);
            this.gb_Received_Order_Details.Controls.Add(this.lbl_Received_Order_Date);
            this.gb_Received_Order_Details.Controls.Add(this.dtp_Received_Order_Date);
            this.gb_Received_Order_Details.Controls.Add(this.lbl_Supplier_Name);
            this.gb_Received_Order_Details.Controls.Add(this.tb_Received_Order_Id);
            this.gb_Received_Order_Details.Controls.Add(this.lbl_Received_Order_Id);
            this.gb_Received_Order_Details.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Received_Order_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Received_Order_Details.Location = new System.Drawing.Point(12, 9);
            this.gb_Received_Order_Details.Name = "gb_Received_Order_Details";
            this.gb_Received_Order_Details.Size = new System.Drawing.Size(1262, 118);
            this.gb_Received_Order_Details.TabIndex = 22;
            this.gb_Received_Order_Details.TabStop = false;
            this.gb_Received_Order_Details.Text = "Received Order Details";
            // 
            // cmb_Supplier_Name
            // 
            this.cmb_Supplier_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Supplier_Name.FormattingEnabled = true;
            this.cmb_Supplier_Name.Location = new System.Drawing.Point(275, 78);
            this.cmb_Supplier_Name.Name = "cmb_Supplier_Name";
            this.cmb_Supplier_Name.Size = new System.Drawing.Size(306, 34);
            this.cmb_Supplier_Name.TabIndex = 1;
            this.cmb_Supplier_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Supplier_Name_SelectedIndexChanged);
            // 
            // tb_Supplier_Company
            // 
            this.tb_Supplier_Company.BackColor = System.Drawing.Color.White;
            this.tb_Supplier_Company.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Supplier_Company.Location = new System.Drawing.Point(903, 73);
            this.tb_Supplier_Company.MaxLength = 30;
            this.tb_Supplier_Company.Name = "tb_Supplier_Company";
            this.tb_Supplier_Company.Size = new System.Drawing.Size(331, 33);
            this.tb_Supplier_Company.TabIndex = 4;
            // 
            // lbl_Supplier_Company
            // 
            this.lbl_Supplier_Company.AutoSize = true;
            this.lbl_Supplier_Company.Font = new System.Drawing.Font("Georgia", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Company.ForeColor = System.Drawing.Color.Black;
            this.lbl_Supplier_Company.Location = new System.Drawing.Point(629, 76);
            this.lbl_Supplier_Company.Name = "lbl_Supplier_Company";
            this.lbl_Supplier_Company.Size = new System.Drawing.Size(193, 27);
            this.lbl_Supplier_Company.TabIndex = 33;
            this.lbl_Supplier_Company.Text = "Supplier Company";
            // 
            // lbl_Received_Order_Date
            // 
            this.lbl_Received_Order_Date.AutoSize = true;
            this.lbl_Received_Order_Date.Font = new System.Drawing.Font("Georgia", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Received_Order_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Received_Order_Date.Location = new System.Drawing.Point(629, 26);
            this.lbl_Received_Order_Date.Name = "lbl_Received_Order_Date";
            this.lbl_Received_Order_Date.Size = new System.Drawing.Size(214, 27);
            this.lbl_Received_Order_Date.TabIndex = 31;
            this.lbl_Received_Order_Date.Text = "Received Order Date";
            // 
            // dtp_Received_Order_Date
            // 
            this.dtp_Received_Order_Date.Font = new System.Drawing.Font("Times New Roman", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Received_Order_Date.Location = new System.Drawing.Point(903, 24);
            this.dtp_Received_Order_Date.Name = "dtp_Received_Order_Date";
            this.dtp_Received_Order_Date.Size = new System.Drawing.Size(331, 32);
            this.dtp_Received_Order_Date.TabIndex = 3;
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Font = new System.Drawing.Font("Georgia", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(31, 76);
            this.lbl_Supplier_Name.Name = "lbl_Supplier_Name";
            this.lbl_Supplier_Name.Size = new System.Drawing.Size(158, 27);
            this.lbl_Supplier_Name.TabIndex = 28;
            this.lbl_Supplier_Name.Text = "Supplier Name";
            // 
            // tb_Received_Order_Id
            // 
            this.tb_Received_Order_Id.BackColor = System.Drawing.Color.White;
            this.tb_Received_Order_Id.Enabled = false;
            this.tb_Received_Order_Id.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Received_Order_Id.Location = new System.Drawing.Point(275, 26);
            this.tb_Received_Order_Id.MaxLength = 8;
            this.tb_Received_Order_Id.Name = "tb_Received_Order_Id";
            this.tb_Received_Order_Id.Size = new System.Drawing.Size(306, 33);
            this.tb_Received_Order_Id.TabIndex = 0;
            // 
            // lbl_Received_Order_Id
            // 
            this.lbl_Received_Order_Id.AutoSize = true;
            this.lbl_Received_Order_Id.Font = new System.Drawing.Font("Georgia", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Received_Order_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Received_Order_Id.Location = new System.Drawing.Point(31, 34);
            this.lbl_Received_Order_Id.Name = "lbl_Received_Order_Id";
            this.lbl_Received_Order_Id.Size = new System.Drawing.Size(190, 27);
            this.lbl_Received_Order_Id.TabIndex = 27;
            this.lbl_Received_Order_Id.Text = "Received Order Id";
            // 
            // frm_Received_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1286, 718);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Price_Details);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Order_Details);
            this.Controls.Add(this.gb_Received_Order_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Received_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Received Order";
            this.Load += new System.EventHandler(this.frm_Received_Order_Load);
            this.gb_Price_Details.ResumeLayout(false);
            this.gb_Price_Details.PerformLayout();
            this.gb_Order_Details.ResumeLayout(false);
            this.gb_Order_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Received_Order_List)).EndInit();
            this.gb_Received_Order_Details.ResumeLayout(false);
            this.gb_Received_Order_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Price_Details;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Final_Bill;
        private System.Windows.Forms.Label lbl_Final_Bill;
        private System.Windows.Forms.TextBox tb_GST;
        private System.Windows.Forms.Label lbl_GST;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.TextBox tb_Total_Bill;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox gb_Order_Details;
        private System.Windows.Forms.Label lbl_Packing;
        private System.Windows.Forms.Label lbl_Expiry_Date;
        private System.Windows.Forms.DateTimePicker dtp_Manufacture_Date;
        private System.Windows.Forms.Label lbl_Manufacture_Date;
        private System.Windows.Forms.Label lbl_Product_Type;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Product_Type;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_Total_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox tb_Qty;
        private System.Windows.Forms.Label lbl_Oty;
        private System.Windows.Forms.GroupBox gb_Received_Order_Details;
        private System.Windows.Forms.Label lbl_Received_Order_Date;
        private System.Windows.Forms.DateTimePicker dtp_Received_Order_Date;
        private System.Windows.Forms.Label lbl_Supplier_Name;
        private System.Windows.Forms.TextBox tb_Received_Order_Id;
        private System.Windows.Forms.Label lbl_Received_Order_Id;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.Label lbl_Supplier_Company;
        private System.Windows.Forms.ComboBox cmb_Unit;
        private System.Windows.Forms.TextBox tb_Supplier_Company;
        private System.Windows.Forms.ComboBox cmb_Supplier_Name;
        private System.Windows.Forms.ComboBox cmb_Packing;
        private System.Windows.Forms.DataGridView dgv_Received_Order_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Packing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn E_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Price;
        private System.Windows.Forms.DateTimePicker dtp_Expiry_Date;
    }
}