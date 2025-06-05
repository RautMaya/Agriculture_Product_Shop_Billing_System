
namespace AgriSmart_Solutions.WindowsForm.Customer
{
    partial class frm_Customer_Bill
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
            this.lbl_Bill_Id = new System.Windows.Forms.Label();
            this.tb_Bill_Id = new System.Windows.Forms.TextBox();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.gb_Personal_Details = new System.Windows.Forms.GroupBox();
            this.tb_Customer_Name = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Bill_Date = new System.Windows.Forms.Label();
            this.dtp_Bill_Date = new System.Windows.Forms.DateTimePicker();
            this.cmb_Payment_Media = new System.Windows.Forms.ComboBox();
            this.lbl_Payment_Media = new System.Windows.Forms.Label();
            this.gb_Order_Details = new System.Windows.Forms.GroupBox();
            this.lbl_EStock = new System.Windows.Forms.Label();
            this.lbl_TStock = new System.Windows.Forms.Label();
            this.cmb_Expiry_Date = new System.Windows.Forms.ComboBox();
            this.cmb_Packing = new System.Windows.Forms.ComboBox();
            this.cmb_Unit = new System.Windows.Forms.ComboBox();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.lbl_Product_Type = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Packing = new System.Windows.Forms.Label();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.lbl_Expiry_Date = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_Qty = new System.Windows.Forms.TextBox();
            this.lbl_Oty = new System.Windows.Forms.Label();
            this.tb_Total_Price = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Send_Order_List = new System.Windows.Forms.DataGridView();
            this.Sr_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Packing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Product_Type = new System.Windows.Forms.ComboBox();
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
            this.gb_Personal_Details.SuspendLayout();
            this.gb_Order_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Send_Order_List)).BeginInit();
            this.gb_Price_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Bill_Id
            // 
            this.lbl_Bill_Id.AutoSize = true;
            this.lbl_Bill_Id.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Bill_Id.Location = new System.Drawing.Point(38, 23);
            this.lbl_Bill_Id.Name = "lbl_Bill_Id";
            this.lbl_Bill_Id.Size = new System.Drawing.Size(71, 27);
            this.lbl_Bill_Id.TabIndex = 4;
            this.lbl_Bill_Id.Text = "Bill Id";
            // 
            // tb_Bill_Id
            // 
            this.tb_Bill_Id.BackColor = System.Drawing.Color.White;
            this.tb_Bill_Id.Enabled = false;
            this.tb_Bill_Id.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bill_Id.Location = new System.Drawing.Point(267, 20);
            this.tb_Bill_Id.MaxLength = 10;
            this.tb_Bill_Id.Name = "tb_Bill_Id";
            this.tb_Bill_Id.Size = new System.Drawing.Size(317, 33);
            this.tb_Bill_Id.TabIndex = 0;
            this.tb_Bill_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Customer_Name.Location = new System.Drawing.Point(38, 75);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(171, 27);
            this.lbl_Customer_Name.TabIndex = 10;
            this.lbl_Customer_Name.Text = "Customer Name";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.Color.Black;
            this.lbl_Address.Location = new System.Drawing.Point(691, 70);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(93, 27);
            this.lbl_Address.TabIndex = 16;
            this.lbl_Address.Text = "Address";
            // 
            // tb_Address
            // 
            this.tb_Address.BackColor = System.Drawing.Color.White;
            this.tb_Address.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(889, 69);
            this.tb_Address.MaxLength = 200;
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(311, 81);
            this.tb_Address.TabIndex = 4;
            // 
            // gb_Personal_Details
            // 
            this.gb_Personal_Details.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Personal_Details.Controls.Add(this.tb_Customer_Name);
            this.gb_Personal_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_Personal_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_Personal_Details.Controls.Add(this.lbl_Bill_Date);
            this.gb_Personal_Details.Controls.Add(this.dtp_Bill_Date);
            this.gb_Personal_Details.Controls.Add(this.tb_Address);
            this.gb_Personal_Details.Controls.Add(this.lbl_Address);
            this.gb_Personal_Details.Controls.Add(this.lbl_Customer_Name);
            this.gb_Personal_Details.Controls.Add(this.tb_Bill_Id);
            this.gb_Personal_Details.Controls.Add(this.lbl_Bill_Id);
            this.gb_Personal_Details.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Personal_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Personal_Details.Location = new System.Drawing.Point(12, 12);
            this.gb_Personal_Details.Name = "gb_Personal_Details";
            this.gb_Personal_Details.Size = new System.Drawing.Size(1256, 164);
            this.gb_Personal_Details.TabIndex = 1;
            this.gb_Personal_Details.TabStop = false;
            this.gb_Personal_Details.Text = "Personal Details";
            // 
            // tb_Customer_Name
            // 
            this.tb_Customer_Name.BackColor = System.Drawing.Color.White;
            this.tb_Customer_Name.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Name.Location = new System.Drawing.Point(267, 70);
            this.tb_Customer_Name.MaxLength = 50;
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(317, 33);
            this.tb_Customer_Name.TabIndex = 1;
            this.tb_Customer_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.BackColor = System.Drawing.Color.White;
            this.tb_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(267, 121);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(317, 33);
            this.tb_Mobile_No.TabIndex = 2;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(38, 123);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(113, 27);
            this.lbl_Mobile_No.TabIndex = 35;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Bill_Date
            // 
            this.lbl_Bill_Date.AutoSize = true;
            this.lbl_Bill_Date.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Bill_Date.Location = new System.Drawing.Point(691, 19);
            this.lbl_Bill_Date.Name = "lbl_Bill_Date";
            this.lbl_Bill_Date.Size = new System.Drawing.Size(95, 27);
            this.lbl_Bill_Date.TabIndex = 33;
            this.lbl_Bill_Date.Text = "Bill Date";
            // 
            // dtp_Bill_Date
            // 
            this.dtp_Bill_Date.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Bill_Date.Location = new System.Drawing.Point(889, 15);
            this.dtp_Bill_Date.Name = "dtp_Bill_Date";
            this.dtp_Bill_Date.Size = new System.Drawing.Size(311, 33);
            this.dtp_Bill_Date.TabIndex = 3;
            // 
            // cmb_Payment_Media
            // 
            this.cmb_Payment_Media.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Payment_Media.FormattingEnabled = true;
            this.cmb_Payment_Media.Items.AddRange(new object[] {
            "Cash",
            "Online",
            "Cheque"});
            this.cmb_Payment_Media.Location = new System.Drawing.Point(983, 17);
            this.cmb_Payment_Media.MaxLength = 30;
            this.cmb_Payment_Media.Name = "cmb_Payment_Media";
            this.cmb_Payment_Media.Size = new System.Drawing.Size(267, 33);
            this.cmb_Payment_Media.TabIndex = 16;
            // 
            // lbl_Payment_Media
            // 
            this.lbl_Payment_Media.AutoSize = true;
            this.lbl_Payment_Media.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Media.ForeColor = System.Drawing.Color.Black;
            this.lbl_Payment_Media.Location = new System.Drawing.Point(796, 19);
            this.lbl_Payment_Media.Name = "lbl_Payment_Media";
            this.lbl_Payment_Media.Size = new System.Drawing.Size(164, 27);
            this.lbl_Payment_Media.TabIndex = 36;
            this.lbl_Payment_Media.Text = "Payment Media";
            // 
            // gb_Order_Details
            // 
            this.gb_Order_Details.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Order_Details.Controls.Add(this.lbl_EStock);
            this.gb_Order_Details.Controls.Add(this.lbl_TStock);
            this.gb_Order_Details.Controls.Add(this.cmb_Expiry_Date);
            this.gb_Order_Details.Controls.Add(this.cmb_Packing);
            this.gb_Order_Details.Controls.Add(this.cmb_Unit);
            this.gb_Order_Details.Controls.Add(this.lbl_Weight);
            this.gb_Order_Details.Controls.Add(this.lbl_Product_Type);
            this.gb_Order_Details.Controls.Add(this.lbl_Product_Name);
            this.gb_Order_Details.Controls.Add(this.lbl_Packing);
            this.gb_Order_Details.Controls.Add(this.tb_Price);
            this.gb_Order_Details.Controls.Add(this.lbl_Expiry_Date);
            this.gb_Order_Details.Controls.Add(this.btn_Add);
            this.gb_Order_Details.Controls.Add(this.tb_Qty);
            this.gb_Order_Details.Controls.Add(this.lbl_Oty);
            this.gb_Order_Details.Controls.Add(this.tb_Total_Price);
            this.gb_Order_Details.Controls.Add(this.lbl_Price);
            this.gb_Order_Details.Controls.Add(this.label1);
            this.gb_Order_Details.Controls.Add(this.dgv_Send_Order_List);
            this.gb_Order_Details.Controls.Add(this.cmb_Product_Name);
            this.gb_Order_Details.Controls.Add(this.cmb_Product_Type);
            this.gb_Order_Details.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Order_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Order_Details.Location = new System.Drawing.Point(12, 182);
            this.gb_Order_Details.Name = "gb_Order_Details";
            this.gb_Order_Details.Size = new System.Drawing.Size(1256, 341);
            this.gb_Order_Details.TabIndex = 2;
            this.gb_Order_Details.TabStop = false;
            this.gb_Order_Details.Text = "Order Details";
            // 
            // lbl_EStock
            // 
            this.lbl_EStock.AutoSize = true;
            this.lbl_EStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_EStock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EStock.ForeColor = System.Drawing.Color.Green;
            this.lbl_EStock.Location = new System.Drawing.Point(755, 120);
            this.lbl_EStock.Name = "lbl_EStock";
            this.lbl_EStock.Size = new System.Drawing.Size(73, 25);
            this.lbl_EStock.TabIndex = 52;
            this.lbl_EStock.Text = "EStock";
            // 
            // lbl_TStock
            // 
            this.lbl_TStock.AutoSize = true;
            this.lbl_TStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TStock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TStock.ForeColor = System.Drawing.Color.Red;
            this.lbl_TStock.Location = new System.Drawing.Point(829, 119);
            this.lbl_TStock.Name = "lbl_TStock";
            this.lbl_TStock.Size = new System.Drawing.Size(73, 25);
            this.lbl_TStock.TabIndex = 36;
            this.lbl_TStock.Text = "TStock";
            // 
            // cmb_Expiry_Date
            // 
            this.cmb_Expiry_Date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Expiry_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Expiry_Date.FormattingEnabled = true;
            this.cmb_Expiry_Date.Location = new System.Drawing.Point(173, 81);
            this.cmb_Expiry_Date.Name = "cmb_Expiry_Date";
            this.cmb_Expiry_Date.Size = new System.Drawing.Size(226, 34);
            this.cmb_Expiry_Date.TabIndex = 9;
            this.cmb_Expiry_Date.SelectedIndexChanged += new System.EventHandler(this.cmb_Expiry_Date_SelectedIndexChanged);
            // 
            // cmb_Packing
            // 
            this.cmb_Packing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Packing.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Packing.FormattingEnabled = true;
            this.cmb_Packing.Location = new System.Drawing.Point(989, 26);
            this.cmb_Packing.Name = "cmb_Packing";
            this.cmb_Packing.Size = new System.Drawing.Size(135, 34);
            this.cmb_Packing.TabIndex = 8;
            this.cmb_Packing.SelectedIndexChanged += new System.EventHandler(this.cmb_Packing_SelectedIndexChanged);
            this.cmb_Packing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
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
            this.cmb_Unit.Location = new System.Drawing.Point(1140, 26);
            this.cmb_Unit.MaxLength = 50;
            this.cmb_Unit.Name = "cmb_Unit";
            this.cmb_Unit.Size = new System.Drawing.Size(98, 34);
            this.cmb_Unit.TabIndex = 7;
            this.cmb_Unit.SelectedIndexChanged += new System.EventHandler(this.cmb_Unit_SelectedIndexChanged);
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Weight.ForeColor = System.Drawing.Color.Black;
            this.lbl_Weight.Location = new System.Drawing.Point(892, 50);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(68, 18);
            this.lbl_Weight.TabIndex = 51;
            this.lbl_Weight.Text = "(Weight)";
            // 
            // lbl_Product_Type
            // 
            this.lbl_Product_Type.AutoSize = true;
            this.lbl_Product_Type.Font = new System.Drawing.Font("Georgia", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Type.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product_Type.Location = new System.Drawing.Point(6, 34);
            this.lbl_Product_Type.Name = "lbl_Product_Type";
            this.lbl_Product_Type.Size = new System.Drawing.Size(144, 27);
            this.lbl_Product_Type.TabIndex = 50;
            this.lbl_Product_Type.Text = "Product Type";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Georgia", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product_Name.Location = new System.Drawing.Point(429, 31);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(153, 27);
            this.lbl_Product_Name.TabIndex = 49;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Packing
            // 
            this.lbl_Packing.AutoSize = true;
            this.lbl_Packing.Font = new System.Drawing.Font("Georgia", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Packing.ForeColor = System.Drawing.Color.Black;
            this.lbl_Packing.Location = new System.Drawing.Point(884, 23);
            this.lbl_Packing.Name = "lbl_Packing";
            this.lbl_Packing.Size = new System.Drawing.Size(88, 27);
            this.lbl_Packing.TabIndex = 48;
            this.lbl_Packing.Text = "Packing";
            // 
            // tb_Price
            // 
            this.tb_Price.BackColor = System.Drawing.Color.White;
            this.tb_Price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(517, 83);
            this.tb_Price.MaxLength = 5;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(151, 34);
            this.tb_Price.TabIndex = 10;
            this.tb_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Expiry_Date
            // 
            this.lbl_Expiry_Date.AutoSize = true;
            this.lbl_Expiry_Date.Font = new System.Drawing.Font("Georgia", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expiry_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Expiry_Date.Location = new System.Drawing.Point(6, 81);
            this.lbl_Expiry_Date.Name = "lbl_Expiry_Date";
            this.lbl_Expiry_Date.Size = new System.Drawing.Size(127, 27);
            this.lbl_Expiry_Date.TabIndex = 47;
            this.lbl_Expiry_Date.Text = "Expiry Date";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(1095, 195);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(155, 64);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Qty
            // 
            this.tb_Qty.BackColor = System.Drawing.Color.White;
            this.tb_Qty.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Qty.Location = new System.Drawing.Point(774, 83);
            this.tb_Qty.MaxLength = 5;
            this.tb_Qty.Name = "tb_Qty";
            this.tb_Qty.Size = new System.Drawing.Size(126, 34);
            this.tb_Qty.TabIndex = 11;
            this.tb_Qty.Text = "0";
            this.tb_Qty.TextChanged += new System.EventHandler(this.tb_Qty_TextChanged);
            this.tb_Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Qty.Leave += new System.EventHandler(this.tb_Qty_Leave);
            // 
            // lbl_Oty
            // 
            this.lbl_Oty.AutoSize = true;
            this.lbl_Oty.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Oty.ForeColor = System.Drawing.Color.Black;
            this.lbl_Oty.Location = new System.Drawing.Point(703, 83);
            this.lbl_Oty.Name = "lbl_Oty";
            this.lbl_Oty.Size = new System.Drawing.Size(65, 29);
            this.lbl_Oty.TabIndex = 38;
            this.lbl_Oty.Text = "Qty :";
            // 
            // tb_Total_Price
            // 
            this.tb_Total_Price.BackColor = System.Drawing.Color.White;
            this.tb_Total_Price.Enabled = false;
            this.tb_Total_Price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Price.Location = new System.Drawing.Point(1083, 88);
            this.tb_Total_Price.MaxLength = 8;
            this.tb_Total_Price.Name = "tb_Total_Price";
            this.tb_Total_Price.Size = new System.Drawing.Size(167, 34);
            this.tb_Total_Price.TabIndex = 12;
            this.tb_Total_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.Black;
            this.lbl_Price.Location = new System.Drawing.Point(429, 83);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(82, 29);
            this.lbl_Price.TabIndex = 40;
            this.lbl_Price.Text = "Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(942, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Price ";
            // 
            // dgv_Send_Order_List
            // 
            this.dgv_Send_Order_List.AllowUserToAddRows = false;
            this.dgv_Send_Order_List.AllowUserToDeleteRows = false;
            this.dgv_Send_Order_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Send_Order_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr_No,
            this.P_Type,
            this.P_Name,
            this.Packing,
            this.Unit,
            this.Price,
            this.Qty,
            this.Total_Price,
            this.E_Date});
            this.dgv_Send_Order_List.Location = new System.Drawing.Point(11, 145);
            this.dgv_Send_Order_List.Name = "dgv_Send_Order_List";
            this.dgv_Send_Order_List.ReadOnly = true;
            this.dgv_Send_Order_List.RowHeadersWidth = 51;
            this.dgv_Send_Order_List.RowTemplate.Height = 24;
            this.dgv_Send_Order_List.Size = new System.Drawing.Size(1066, 190);
            this.dgv_Send_Order_List.TabIndex = 0;
            // 
            // Sr_No
            // 
            this.Sr_No.HeaderText = "Sr.No";
            this.Sr_No.MinimumWidth = 6;
            this.Sr_No.Name = "Sr_No";
            this.Sr_No.ReadOnly = true;
            this.Sr_No.Width = 80;
            // 
            // P_Type
            // 
            this.P_Type.HeaderText = "Product Type";
            this.P_Type.MinimumWidth = 6;
            this.P_Type.Name = "P_Type";
            this.P_Type.ReadOnly = true;
            this.P_Type.Width = 140;
            // 
            // P_Name
            // 
            this.P_Name.HeaderText = "Product Name";
            this.P_Name.MinimumWidth = 6;
            this.P_Name.Name = "P_Name";
            this.P_Name.ReadOnly = true;
            this.P_Name.Width = 150;
            // 
            // Packing
            // 
            this.Packing.HeaderText = "Packing";
            this.Packing.MinimumWidth = 6;
            this.Packing.Name = "Packing";
            this.Packing.ReadOnly = true;
            this.Packing.Width = 125;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 125;
            // 
            // Total_Price
            // 
            this.Total_Price.HeaderText = "Total Price";
            this.Total_Price.MinimumWidth = 6;
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.ReadOnly = true;
            this.Total_Price.Width = 145;
            // 
            // E_Date
            // 
            this.E_Date.HeaderText = "Expiry_Date";
            this.E_Date.MinimumWidth = 6;
            this.E_Date.Name = "E_Date";
            this.E_Date.ReadOnly = true;
            this.E_Date.Visible = false;
            this.E_Date.Width = 125;
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(596, 28);
            this.cmb_Product_Name.MaxLength = 30;
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(232, 34);
            this.cmb_Product_Name.TabIndex = 6;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
            // 
            // cmb_Product_Type
            // 
            this.cmb_Product_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Type.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Type.FormattingEnabled = true;
            this.cmb_Product_Type.Location = new System.Drawing.Point(173, 28);
            this.cmb_Product_Type.MaxLength = 20;
            this.cmb_Product_Type.Name = "cmb_Product_Type";
            this.cmb_Product_Type.Size = new System.Drawing.Size(232, 34);
            this.cmb_Product_Type.TabIndex = 5;
            this.cmb_Product_Type.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Type_SelectedIndexChanged);
            // 
            // gb_Price_Details
            // 
            this.gb_Price_Details.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Price_Details.Controls.Add(this.label3);
            this.gb_Price_Details.Controls.Add(this.cmb_Payment_Media);
            this.gb_Price_Details.Controls.Add(this.lbl_Payment_Media);
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
            this.gb_Price_Details.Location = new System.Drawing.Point(12, 529);
            this.gb_Price_Details.Name = "gb_Price_Details";
            this.gb_Price_Details.Size = new System.Drawing.Size(1256, 113);
            this.gb_Price_Details.TabIndex = 3;
            this.gb_Price_Details.TabStop = false;
            this.gb_Price_Details.Text = "Price Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(688, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(688, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "%";
            // 
            // tb_Final_Bill
            // 
            this.tb_Final_Bill.BackColor = System.Drawing.Color.White;
            this.tb_Final_Bill.Enabled = false;
            this.tb_Final_Bill.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Final_Bill.Location = new System.Drawing.Point(983, 65);
            this.tb_Final_Bill.MaxLength = 8;
            this.tb_Final_Bill.Name = "tb_Final_Bill";
            this.tb_Final_Bill.Size = new System.Drawing.Size(205, 33);
            this.tb_Final_Bill.TabIndex = 0;
            this.tb_Final_Bill.Text = "0";
            this.tb_Final_Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Final_Bill
            // 
            this.lbl_Final_Bill.AutoSize = true;
            this.lbl_Final_Bill.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Final_Bill.ForeColor = System.Drawing.Color.Black;
            this.lbl_Final_Bill.Location = new System.Drawing.Point(796, 67);
            this.lbl_Final_Bill.Name = "lbl_Final_Bill";
            this.lbl_Final_Bill.Size = new System.Drawing.Size(110, 27);
            this.lbl_Final_Bill.TabIndex = 33;
            this.lbl_Final_Bill.Text = "Final Bill :";
            // 
            // tb_GST
            // 
            this.tb_GST.BackColor = System.Drawing.Color.White;
            this.tb_GST.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST.Location = new System.Drawing.Point(558, 17);
            this.tb_GST.MaxLength = 2;
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(124, 33);
            this.tb_GST.TabIndex = 14;
            this.tb_GST.Text = "0";
            this.tb_GST.TextChanged += new System.EventHandler(this.tb_GST_TextChanged);
            this.tb_GST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_GST.Leave += new System.EventHandler(this.tb_GST_Leave);
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST.ForeColor = System.Drawing.Color.Black;
            this.lbl_GST.Location = new System.Drawing.Point(416, 18);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(54, 27);
            this.lbl_GST.TabIndex = 31;
            this.lbl_GST.Text = "GST";
            // 
            // tb_Discount
            // 
            this.tb_Discount.BackColor = System.Drawing.Color.White;
            this.tb_Discount.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Discount.Location = new System.Drawing.Point(558, 65);
            this.tb_Discount.MaxLength = 2;
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(124, 33);
            this.tb_Discount.TabIndex = 15;
            this.tb_Discount.Text = "0";
            this.tb_Discount.TextChanged += new System.EventHandler(this.tb_Discount_TextChanged);
            this.tb_Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Discount.Leave += new System.EventHandler(this.tb_Discount_Leave);
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.ForeColor = System.Drawing.Color.Black;
            this.lbl_Discount.Location = new System.Drawing.Point(416, 65);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(100, 27);
            this.lbl_Discount.TabIndex = 29;
            this.lbl_Discount.Text = "Discount";
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.BackColor = System.Drawing.Color.White;
            this.tb_Total_Bill.Enabled = false;
            this.tb_Total_Bill.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.Location = new System.Drawing.Point(162, 18);
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
            this.lbl_Total_Bill.Location = new System.Drawing.Point(20, 26);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(112, 27);
            this.lbl_Total_Bill.TabIndex = 0;
            this.lbl_Total_Bill.Text = "Total Bill :";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(265, 648);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(243, 58);
            this.btn_Refresh.TabIndex = 18;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(846, 648);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(243, 57);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Customer_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1280, 718);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Price_Details);
            this.Controls.Add(this.gb_Order_Details);
            this.Controls.Add(this.gb_Personal_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Customer_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Customer_Bill";
            this.Load += new System.EventHandler(this.frm_Customer_Bill_Load);
            this.gb_Personal_Details.ResumeLayout(false);
            this.gb_Personal_Details.PerformLayout();
            this.gb_Order_Details.ResumeLayout(false);
            this.gb_Order_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Send_Order_List)).EndInit();
            this.gb_Price_Details.ResumeLayout(false);
            this.gb_Price_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Bill_Id;
        private System.Windows.Forms.TextBox tb_Bill_Id;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.GroupBox gb_Personal_Details;
        private System.Windows.Forms.Label lbl_Bill_Date;
        private System.Windows.Forms.DateTimePicker dtp_Bill_Date;
        private System.Windows.Forms.ComboBox cmb_Payment_Media;
        private System.Windows.Forms.Label lbl_Payment_Media;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.GroupBox gb_Order_Details;
        private System.Windows.Forms.Label lbl_Expiry_Date;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_Total_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Send_Order_List;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox tb_Qty;
        private System.Windows.Forms.Label lbl_Oty;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Product_Type;
        private System.Windows.Forms.GroupBox gb_Price_Details;
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
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label lbl_Product_Type;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Packing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Customer_Name;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.ComboBox cmb_Unit;
        private System.Windows.Forms.ComboBox cmb_Packing;
        private System.Windows.Forms.ComboBox cmb_Expiry_Date;
        private System.Windows.Forms.Label lbl_TStock;
        private System.Windows.Forms.Label lbl_EStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Packing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn E_Date;
    }
}