
namespace AgriSmart_Solutions.WindowsForm.Supplier
{
    partial class frm_Update_Supplier
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.gb_Bank_Details = new System.Windows.Forms.GroupBox();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.tb_Account_No = new System.Windows.Forms.TextBox();
            this.lbl_Account_No = new System.Windows.Forms.Label();
            this.tb_Bank_Details = new System.Windows.Forms.TextBox();
            this.lbl_Bank_Deatils = new System.Windows.Forms.Label();
            this.gb_More_Details = new System.Windows.Forms.GroupBox();
            this.tb_Aadhar_No = new System.Windows.Forms.TextBox();
            this.lbl_Aadhar_No = new System.Windows.Forms.Label();
            this.tb_Company_Address = new System.Windows.Forms.TextBox();
            this.lbl_Company_Address = new System.Windows.Forms.Label();
            this.tb_Email_Id = new System.Windows.Forms.TextBox();
            this.lbl_Email_Id = new System.Windows.Forms.Label();
            this.tb_Supplier_Company = new System.Windows.Forms.TextBox();
            this.lbl_Supplier_Company = new System.Windows.Forms.Label();
            this.gb_Personal_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Supplier_Added_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Supplier_Added_Date = new System.Windows.Forms.Label();
            this.tb_Alt_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Alt_Mobile_No = new System.Windows.Forms.Label();
            this.tb_Supplier_Name = new System.Windows.Forms.TextBox();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.tb_Supplier_Address = new System.Windows.Forms.TextBox();
            this.lbl_Supplier_Address = new System.Windows.Forms.Label();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Supplier_Id = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Supplier_Id = new System.Windows.Forms.Label();
            this.gb_Bank_Details.SuspendLayout();
            this.gb_More_Details.SuspendLayout();
            this.gb_Personal_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Search.Location = new System.Drawing.Point(387, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(198, 54);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(259, 654);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(243, 58);
            this.btn_Refresh.TabIndex = 16;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(828, 654);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(243, 58);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // gb_Bank_Details
            // 
            this.gb_Bank_Details.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Bank_Details.Controls.Add(this.tb_Note);
            this.gb_Bank_Details.Controls.Add(this.lbl_Note);
            this.gb_Bank_Details.Controls.Add(this.tb_Account_No);
            this.gb_Bank_Details.Controls.Add(this.lbl_Account_No);
            this.gb_Bank_Details.Controls.Add(this.tb_Bank_Details);
            this.gb_Bank_Details.Controls.Add(this.lbl_Bank_Deatils);
            this.gb_Bank_Details.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Bank_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Bank_Details.Location = new System.Drawing.Point(12, 481);
            this.gb_Bank_Details.Name = "gb_Bank_Details";
            this.gb_Bank_Details.Size = new System.Drawing.Size(1262, 173);
            this.gb_Bank_Details.TabIndex = 38;
            this.gb_Bank_Details.TabStop = false;
            this.gb_Bank_Details.Text = "Bank Details";
            // 
            // tb_Note
            // 
            this.tb_Note.BackColor = System.Drawing.Color.White;
            this.tb_Note.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Note.Location = new System.Drawing.Point(907, 46);
            this.tb_Note.MaxLength = 300;
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(312, 97);
            this.tb_Note.TabIndex = 14;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Georgia", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Black;
            this.lbl_Note.Location = new System.Drawing.Point(668, 49);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(69, 30);
            this.lbl_Note.TabIndex = 18;
            this.lbl_Note.Text = "Note";
            // 
            // tb_Account_No
            // 
            this.tb_Account_No.BackColor = System.Drawing.Color.White;
            this.tb_Account_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Account_No.Location = new System.Drawing.Point(267, 128);
            this.tb_Account_No.MaxLength = 10;
            this.tb_Account_No.Name = "tb_Account_No";
            this.tb_Account_No.Size = new System.Drawing.Size(312, 39);
            this.tb_Account_No.TabIndex = 13;
            this.tb_Account_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Account_No
            // 
            this.lbl_Account_No.AutoSize = true;
            this.lbl_Account_No.Font = new System.Drawing.Font("Georgia", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Account_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Account_No.Location = new System.Drawing.Point(16, 134);
            this.lbl_Account_No.Name = "lbl_Account_No";
            this.lbl_Account_No.Size = new System.Drawing.Size(147, 30);
            this.lbl_Account_No.TabIndex = 16;
            this.lbl_Account_No.Text = "Account No";
            // 
            // tb_Bank_Details
            // 
            this.tb_Bank_Details.BackColor = System.Drawing.Color.White;
            this.tb_Bank_Details.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bank_Details.Location = new System.Drawing.Point(267, 40);
            this.tb_Bank_Details.MaxLength = 30;
            this.tb_Bank_Details.Multiline = true;
            this.tb_Bank_Details.Name = "tb_Bank_Details";
            this.tb_Bank_Details.Size = new System.Drawing.Size(312, 65);
            this.tb_Bank_Details.TabIndex = 11;
            // 
            // lbl_Bank_Deatils
            // 
            this.lbl_Bank_Deatils.AutoSize = true;
            this.lbl_Bank_Deatils.Font = new System.Drawing.Font("Georgia", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bank_Deatils.ForeColor = System.Drawing.Color.Black;
            this.lbl_Bank_Deatils.Location = new System.Drawing.Point(16, 46);
            this.lbl_Bank_Deatils.Name = "lbl_Bank_Deatils";
            this.lbl_Bank_Deatils.Size = new System.Drawing.Size(158, 30);
            this.lbl_Bank_Deatils.TabIndex = 4;
            this.lbl_Bank_Deatils.Text = "Bank Details";
            // 
            // gb_More_Details
            // 
            this.gb_More_Details.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_More_Details.Controls.Add(this.tb_Aadhar_No);
            this.gb_More_Details.Controls.Add(this.lbl_Aadhar_No);
            this.gb_More_Details.Controls.Add(this.tb_Company_Address);
            this.gb_More_Details.Controls.Add(this.lbl_Company_Address);
            this.gb_More_Details.Controls.Add(this.tb_Email_Id);
            this.gb_More_Details.Controls.Add(this.lbl_Email_Id);
            this.gb_More_Details.Controls.Add(this.tb_Supplier_Company);
            this.gb_More_Details.Controls.Add(this.lbl_Supplier_Company);
            this.gb_More_Details.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_More_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_More_Details.Location = new System.Drawing.Point(12, 296);
            this.gb_More_Details.Name = "gb_More_Details";
            this.gb_More_Details.Size = new System.Drawing.Size(1262, 179);
            this.gb_More_Details.TabIndex = 37;
            this.gb_More_Details.TabStop = false;
            this.gb_More_Details.Text = "More Details";
            // 
            // tb_Aadhar_No
            // 
            this.tb_Aadhar_No.BackColor = System.Drawing.Color.White;
            this.tb_Aadhar_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Aadhar_No.Location = new System.Drawing.Point(907, 27);
            this.tb_Aadhar_No.MaxLength = 12;
            this.tb_Aadhar_No.Name = "tb_Aadhar_No";
            this.tb_Aadhar_No.Size = new System.Drawing.Size(312, 39);
            this.tb_Aadhar_No.TabIndex = 9;
            this.tb_Aadhar_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Aadhar_No
            // 
            this.lbl_Aadhar_No.AutoSize = true;
            this.lbl_Aadhar_No.Font = new System.Drawing.Font("Georgia", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aadhar_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Aadhar_No.Location = new System.Drawing.Point(656, 37);
            this.lbl_Aadhar_No.Name = "lbl_Aadhar_No";
            this.lbl_Aadhar_No.Size = new System.Drawing.Size(137, 30);
            this.lbl_Aadhar_No.TabIndex = 16;
            this.lbl_Aadhar_No.Text = "Aadhar No";
            // 
            // tb_Company_Address
            // 
            this.tb_Company_Address.BackColor = System.Drawing.Color.White;
            this.tb_Company_Address.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Company_Address.Location = new System.Drawing.Point(267, 105);
            this.tb_Company_Address.MaxLength = 80;
            this.tb_Company_Address.Name = "tb_Company_Address";
            this.tb_Company_Address.Size = new System.Drawing.Size(312, 39);
            this.tb_Company_Address.TabIndex = 8;
            // 
            // lbl_Company_Address
            // 
            this.lbl_Company_Address.AutoSize = true;
            this.lbl_Company_Address.Font = new System.Drawing.Font("Georgia", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Company_Address.ForeColor = System.Drawing.Color.Black;
            this.lbl_Company_Address.Location = new System.Drawing.Point(11, 109);
            this.lbl_Company_Address.Name = "lbl_Company_Address";
            this.lbl_Company_Address.Size = new System.Drawing.Size(222, 30);
            this.lbl_Company_Address.TabIndex = 17;
            this.lbl_Company_Address.Text = "Company Address";
            // 
            // tb_Email_Id
            // 
            this.tb_Email_Id.BackColor = System.Drawing.Color.White;
            this.tb_Email_Id.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email_Id.Location = new System.Drawing.Point(907, 104);
            this.tb_Email_Id.MaxLength = 30;
            this.tb_Email_Id.Name = "tb_Email_Id";
            this.tb_Email_Id.Size = new System.Drawing.Size(312, 39);
            this.tb_Email_Id.TabIndex = 10;
            // 
            // lbl_Email_Id
            // 
            this.lbl_Email_Id.AutoSize = true;
            this.lbl_Email_Id.Font = new System.Drawing.Font("Georgia", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Email_Id.Location = new System.Drawing.Point(656, 113);
            this.lbl_Email_Id.Name = "lbl_Email_Id";
            this.lbl_Email_Id.Size = new System.Drawing.Size(112, 30);
            this.lbl_Email_Id.TabIndex = 10;
            this.lbl_Email_Id.Text = "Email Id";
            // 
            // tb_Supplier_Company
            // 
            this.tb_Supplier_Company.BackColor = System.Drawing.Color.White;
            this.tb_Supplier_Company.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Supplier_Company.Location = new System.Drawing.Point(267, 37);
            this.tb_Supplier_Company.MaxLength = 50;
            this.tb_Supplier_Company.Name = "tb_Supplier_Company";
            this.tb_Supplier_Company.Size = new System.Drawing.Size(312, 39);
            this.tb_Supplier_Company.TabIndex = 7;
            this.tb_Supplier_Company.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // lbl_Supplier_Company
            // 
            this.lbl_Supplier_Company.AutoSize = true;
            this.lbl_Supplier_Company.Font = new System.Drawing.Font("Georgia", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Company.ForeColor = System.Drawing.Color.Black;
            this.lbl_Supplier_Company.Location = new System.Drawing.Point(11, 37);
            this.lbl_Supplier_Company.Name = "lbl_Supplier_Company";
            this.lbl_Supplier_Company.Size = new System.Drawing.Size(228, 30);
            this.lbl_Supplier_Company.TabIndex = 16;
            this.lbl_Supplier_Company.Text = "Supplier Company";
            // 
            // gb_Personal_Details
            // 
            this.gb_Personal_Details.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Personal_Details.Controls.Add(this.dtp_Supplier_Added_Date);
            this.gb_Personal_Details.Controls.Add(this.lbl_Supplier_Added_Date);
            this.gb_Personal_Details.Controls.Add(this.tb_Alt_Mobile_No);
            this.gb_Personal_Details.Controls.Add(this.lbl_Alt_Mobile_No);
            this.gb_Personal_Details.Controls.Add(this.tb_Supplier_Name);
            this.gb_Personal_Details.Controls.Add(this.btn_Search);
            this.gb_Personal_Details.Controls.Add(this.lbl_Supplier_Name);
            this.gb_Personal_Details.Controls.Add(this.tb_Supplier_Address);
            this.gb_Personal_Details.Controls.Add(this.lbl_Supplier_Address);
            this.gb_Personal_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_Personal_Details.Controls.Add(this.tb_Supplier_Id);
            this.gb_Personal_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_Personal_Details.Controls.Add(this.lbl_Supplier_Id);
            this.gb_Personal_Details.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Personal_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Personal_Details.Location = new System.Drawing.Point(12, 12);
            this.gb_Personal_Details.Name = "gb_Personal_Details";
            this.gb_Personal_Details.Size = new System.Drawing.Size(1262, 278);
            this.gb_Personal_Details.TabIndex = 36;
            this.gb_Personal_Details.TabStop = false;
            this.gb_Personal_Details.Text = "Personal Details";
            // 
            // dtp_Supplier_Added_Date
            // 
            this.dtp_Supplier_Added_Date.Font = new System.Drawing.Font("Times New Roman", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Supplier_Added_Date.Location = new System.Drawing.Point(907, 54);
            this.dtp_Supplier_Added_Date.Name = "dtp_Supplier_Added_Date";
            this.dtp_Supplier_Added_Date.Size = new System.Drawing.Size(312, 38);
            this.dtp_Supplier_Added_Date.TabIndex = 22;
            // 
            // lbl_Supplier_Added_Date
            // 
            this.lbl_Supplier_Added_Date.AutoSize = true;
            this.lbl_Supplier_Added_Date.Font = new System.Drawing.Font("Georgia", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Added_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Supplier_Added_Date.Location = new System.Drawing.Point(648, 54);
            this.lbl_Supplier_Added_Date.Name = "lbl_Supplier_Added_Date";
            this.lbl_Supplier_Added_Date.Size = new System.Drawing.Size(253, 30);
            this.lbl_Supplier_Added_Date.TabIndex = 23;
            this.lbl_Supplier_Added_Date.Text = "Supplier Added Date";
            // 
            // tb_Alt_Mobile_No
            // 
            this.tb_Alt_Mobile_No.BackColor = System.Drawing.Color.White;
            this.tb_Alt_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alt_Mobile_No.Location = new System.Drawing.Point(907, 196);
            this.tb_Alt_Mobile_No.MaxLength = 10;
            this.tb_Alt_Mobile_No.Name = "tb_Alt_Mobile_No";
            this.tb_Alt_Mobile_No.Size = new System.Drawing.Size(312, 39);
            this.tb_Alt_Mobile_No.TabIndex = 6;
            this.tb_Alt_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Alt_Mobile_No
            // 
            this.lbl_Alt_Mobile_No.AutoSize = true;
            this.lbl_Alt_Mobile_No.Font = new System.Drawing.Font("Georgia", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alt_Mobile_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Alt_Mobile_No.Location = new System.Drawing.Point(656, 205);
            this.lbl_Alt_Mobile_No.Name = "lbl_Alt_Mobile_No";
            this.lbl_Alt_Mobile_No.Size = new System.Drawing.Size(186, 30);
            this.lbl_Alt_Mobile_No.TabIndex = 21;
            this.lbl_Alt_Mobile_No.Text = "Alt . Mobile No";
            // 
            // tb_Supplier_Name
            // 
            this.tb_Supplier_Name.BackColor = System.Drawing.Color.White;
            this.tb_Supplier_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Supplier_Name.Location = new System.Drawing.Point(273, 132);
            this.tb_Supplier_Name.MaxLength = 50;
            this.tb_Supplier_Name.Name = "tb_Supplier_Name";
            this.tb_Supplier_Name.Size = new System.Drawing.Size(312, 39);
            this.tb_Supplier_Name.TabIndex = 3;
            this.tb_Supplier_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Font = new System.Drawing.Font("Georgia", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(16, 132);
            this.lbl_Supplier_Name.Name = "lbl_Supplier_Name";
            this.lbl_Supplier_Name.Size = new System.Drawing.Size(187, 30);
            this.lbl_Supplier_Name.TabIndex = 10;
            this.lbl_Supplier_Name.Text = "Supplier Name";
            // 
            // tb_Supplier_Address
            // 
            this.tb_Supplier_Address.BackColor = System.Drawing.Color.White;
            this.tb_Supplier_Address.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Supplier_Address.Location = new System.Drawing.Point(270, 209);
            this.tb_Supplier_Address.MaxLength = 80;
            this.tb_Supplier_Address.Name = "tb_Supplier_Address";
            this.tb_Supplier_Address.Size = new System.Drawing.Size(315, 39);
            this.tb_Supplier_Address.TabIndex = 4;
            // 
            // lbl_Supplier_Address
            // 
            this.lbl_Supplier_Address.AutoSize = true;
            this.lbl_Supplier_Address.Font = new System.Drawing.Font("Georgia", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Address.ForeColor = System.Drawing.Color.Black;
            this.lbl_Supplier_Address.Location = new System.Drawing.Point(16, 205);
            this.lbl_Supplier_Address.Name = "lbl_Supplier_Address";
            this.lbl_Supplier_Address.Size = new System.Drawing.Size(211, 30);
            this.lbl_Supplier_Address.TabIndex = 14;
            this.lbl_Supplier_Address.Text = "Supplier Address";
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.BackColor = System.Drawing.Color.White;
            this.tb_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(907, 124);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(312, 39);
            this.tb_Mobile_No.TabIndex = 5;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Supplier_Id
            // 
            this.tb_Supplier_Id.BackColor = System.Drawing.Color.White;
            this.tb_Supplier_Id.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Supplier_Id.Location = new System.Drawing.Point(273, 62);
            this.tb_Supplier_Id.MaxLength = 8;
            this.tb_Supplier_Id.Name = "tb_Supplier_Id";
            this.tb_Supplier_Id.Size = new System.Drawing.Size(312, 39);
            this.tb_Supplier_Id.TabIndex = 1;
            this.tb_Supplier_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Georgia", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(656, 124);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(134, 30);
            this.lbl_Mobile_No.TabIndex = 4;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Supplier_Id
            // 
            this.lbl_Supplier_Id.AutoSize = true;
            this.lbl_Supplier_Id.Font = new System.Drawing.Font("Georgia", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Supplier_Id.Location = new System.Drawing.Point(16, 65);
            this.lbl_Supplier_Id.Name = "lbl_Supplier_Id";
            this.lbl_Supplier_Id.Size = new System.Drawing.Size(143, 30);
            this.lbl_Supplier_Id.TabIndex = 4;
            this.lbl_Supplier_Id.Text = "Supplier Id";
            // 
            // frm_Update_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1286, 718);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.gb_Bank_Details);
            this.Controls.Add(this.gb_More_Details);
            this.Controls.Add(this.gb_Personal_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Update_Supplier";
            this.Text = "frm_Update_Supplier";
            this.gb_Bank_Details.ResumeLayout(false);
            this.gb_Bank_Details.PerformLayout();
            this.gb_More_Details.ResumeLayout(false);
            this.gb_More_Details.PerformLayout();
            this.gb_Personal_Details.ResumeLayout(false);
            this.gb_Personal_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.GroupBox gb_Bank_Details;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.TextBox tb_Account_No;
        private System.Windows.Forms.Label lbl_Account_No;
        private System.Windows.Forms.TextBox tb_Bank_Details;
        private System.Windows.Forms.Label lbl_Bank_Deatils;
        private System.Windows.Forms.GroupBox gb_More_Details;
        private System.Windows.Forms.TextBox tb_Aadhar_No;
        private System.Windows.Forms.Label lbl_Aadhar_No;
        private System.Windows.Forms.TextBox tb_Company_Address;
        private System.Windows.Forms.Label lbl_Company_Address;
        private System.Windows.Forms.TextBox tb_Email_Id;
        private System.Windows.Forms.Label lbl_Email_Id;
        private System.Windows.Forms.TextBox tb_Supplier_Company;
        private System.Windows.Forms.Label lbl_Supplier_Company;
        private System.Windows.Forms.GroupBox gb_Personal_Details;
        private System.Windows.Forms.TextBox tb_Alt_Mobile_No;
        private System.Windows.Forms.Label lbl_Alt_Mobile_No;
        private System.Windows.Forms.TextBox tb_Supplier_Name;
        private System.Windows.Forms.Label lbl_Supplier_Name;
        private System.Windows.Forms.TextBox tb_Supplier_Address;
        private System.Windows.Forms.Label lbl_Supplier_Address;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Supplier_Id;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Supplier_Id;
        private System.Windows.Forms.DateTimePicker dtp_Supplier_Added_Date;
        private System.Windows.Forms.Label lbl_Supplier_Added_Date;
    }
}