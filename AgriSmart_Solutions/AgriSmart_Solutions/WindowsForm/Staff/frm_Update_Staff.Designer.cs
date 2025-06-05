
namespace AgriSmart_Solutions.WindowsForm.Staff
{
    partial class frm_Update_Staff
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.gb_Bank_Details = new System.Windows.Forms.GroupBox();
            this.tb_Account_No = new System.Windows.Forms.TextBox();
            this.lbl_Account_No = new System.Windows.Forms.Label();
            this.tb_Bank_Details = new System.Windows.Forms.TextBox();
            this.lbl_Bank_Details = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_Joining_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Joining_Date = new System.Windows.Forms.Label();
            this.cmb_Designation = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Staff_Id = new System.Windows.Forms.TextBox();
            this.lbl_Staff_Id = new System.Windows.Forms.Label();
            this.lbl_Designation = new System.Windows.Forms.Label();
            this.tb_Staff_Name = new System.Windows.Forms.TextBox();
            this.lbl_Staff_Name = new System.Windows.Forms.Label();
            this.gb_More_Details = new System.Windows.Forms.GroupBox();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.tb_Aadhar_No = new System.Windows.Forms.TextBox();
            this.tb_Email_Id = new System.Windows.Forms.TextBox();
            this.lbl_Aadhar_No = new System.Windows.Forms.Label();
            this.lbl_Email_Id = new System.Windows.Forms.Label();
            this.tb_Alt_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Alternate_Mobile_Id = new System.Windows.Forms.Label();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.gb_Bank_Details.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_More_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(98, 657);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(243, 59);
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
            this.btn_Update.Location = new System.Drawing.Point(554, 656);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(243, 59);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // gb_Bank_Details
            // 
            this.gb_Bank_Details.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Bank_Details.Controls.Add(this.tb_Account_No);
            this.gb_Bank_Details.Controls.Add(this.lbl_Account_No);
            this.gb_Bank_Details.Controls.Add(this.tb_Bank_Details);
            this.gb_Bank_Details.Controls.Add(this.lbl_Bank_Details);
            this.gb_Bank_Details.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Bank_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Bank_Details.Location = new System.Drawing.Point(12, 471);
            this.gb_Bank_Details.Name = "gb_Bank_Details";
            this.gb_Bank_Details.Size = new System.Drawing.Size(1262, 167);
            this.gb_Bank_Details.TabIndex = 3;
            this.gb_Bank_Details.TabStop = false;
            this.gb_Bank_Details.Text = "Bank Details";
            // 
            // tb_Account_No
            // 
            this.tb_Account_No.BackColor = System.Drawing.Color.White;
            this.tb_Account_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Account_No.Location = new System.Drawing.Point(900, 27);
            this.tb_Account_No.MaxLength = 10;
            this.tb_Account_No.Name = "tb_Account_No";
            this.tb_Account_No.Size = new System.Drawing.Size(314, 39);
            this.tb_Account_No.TabIndex = 13;
            this.tb_Account_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Account_No
            // 
            this.lbl_Account_No.AutoSize = true;
            this.lbl_Account_No.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Account_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Account_No.Location = new System.Drawing.Point(669, 35);
            this.lbl_Account_No.Name = "lbl_Account_No";
            this.lbl_Account_No.Size = new System.Drawing.Size(155, 31);
            this.lbl_Account_No.TabIndex = 16;
            this.lbl_Account_No.Text = "Account No";
            // 
            // tb_Bank_Details
            // 
            this.tb_Bank_Details.BackColor = System.Drawing.Color.White;
            this.tb_Bank_Details.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bank_Details.Location = new System.Drawing.Point(290, 42);
            this.tb_Bank_Details.MaxLength = 30;
            this.tb_Bank_Details.Multiline = true;
            this.tb_Bank_Details.Name = "tb_Bank_Details";
            this.tb_Bank_Details.Size = new System.Drawing.Size(312, 88);
            this.tb_Bank_Details.TabIndex = 12;
            // 
            // lbl_Bank_Details
            // 
            this.lbl_Bank_Details.AutoSize = true;
            this.lbl_Bank_Details.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bank_Details.ForeColor = System.Drawing.Color.Black;
            this.lbl_Bank_Details.Location = new System.Drawing.Point(6, 50);
            this.lbl_Bank_Details.Name = "lbl_Bank_Details";
            this.lbl_Bank_Details.Size = new System.Drawing.Size(167, 31);
            this.lbl_Bank_Details.TabIndex = 4;
            this.lbl_Bank_Details.Text = "Bank Details";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox1.Controls.Add(this.dtp_Joining_Date);
            this.groupBox1.Controls.Add(this.lbl_Joining_Date);
            this.groupBox1.Controls.Add(this.cmb_Designation);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.tb_Staff_Id);
            this.groupBox1.Controls.Add(this.lbl_Staff_Id);
            this.groupBox1.Controls.Add(this.lbl_Designation);
            this.groupBox1.Controls.Add(this.tb_Staff_Name);
            this.groupBox1.Controls.Add(this.lbl_Staff_Name);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1262, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // dtp_Joining_Date
            // 
            this.dtp_Joining_Date.Font = new System.Drawing.Font("Times New Roman", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Joining_Date.Location = new System.Drawing.Point(900, 52);
            this.dtp_Joining_Date.Name = "dtp_Joining_Date";
            this.dtp_Joining_Date.Size = new System.Drawing.Size(312, 38);
            this.dtp_Joining_Date.TabIndex = 4;
            // 
            // lbl_Joining_Date
            // 
            this.lbl_Joining_Date.AutoSize = true;
            this.lbl_Joining_Date.Font = new System.Drawing.Font("Georgia", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Joining_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Joining_Date.Location = new System.Drawing.Point(671, 60);
            this.lbl_Joining_Date.Name = "lbl_Joining_Date";
            this.lbl_Joining_Date.Size = new System.Drawing.Size(159, 30);
            this.lbl_Joining_Date.TabIndex = 21;
            this.lbl_Joining_Date.Text = "Joining Date";
            // 
            // cmb_Designation
            // 
            this.cmb_Designation.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Designation.FormattingEnabled = true;
            this.cmb_Designation.Items.AddRange(new object[] {
            "Cashier",
            "Manager",
            "Worker"});
            this.cmb_Designation.Location = new System.Drawing.Point(900, 117);
            this.cmb_Designation.MaxLength = 30;
            this.cmb_Designation.Name = "cmb_Designation";
            this.cmb_Designation.Size = new System.Drawing.Size(312, 37);
            this.cmb_Designation.TabIndex = 5;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Search.Location = new System.Drawing.Point(433, 1);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(178, 53);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Staff_Id
            // 
            this.tb_Staff_Id.BackColor = System.Drawing.Color.White;
            this.tb_Staff_Id.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Staff_Id.Location = new System.Drawing.Point(290, 60);
            this.tb_Staff_Id.MaxLength = 8;
            this.tb_Staff_Id.Name = "tb_Staff_Id";
            this.tb_Staff_Id.Size = new System.Drawing.Size(312, 39);
            this.tb_Staff_Id.TabIndex = 1;
            this.tb_Staff_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Staff_Id
            // 
            this.lbl_Staff_Id.AutoSize = true;
            this.lbl_Staff_Id.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Staff_Id.Location = new System.Drawing.Point(6, 60);
            this.lbl_Staff_Id.Name = "lbl_Staff_Id";
            this.lbl_Staff_Id.Size = new System.Drawing.Size(104, 31);
            this.lbl_Staff_Id.TabIndex = 4;
            this.lbl_Staff_Id.Text = "Staff Id";
            // 
            // lbl_Designation
            // 
            this.lbl_Designation.AutoSize = true;
            this.lbl_Designation.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Designation.ForeColor = System.Drawing.Color.Black;
            this.lbl_Designation.Location = new System.Drawing.Point(670, 119);
            this.lbl_Designation.Name = "lbl_Designation";
            this.lbl_Designation.Size = new System.Drawing.Size(159, 31);
            this.lbl_Designation.TabIndex = 14;
            this.lbl_Designation.Text = "Designation";
            // 
            // tb_Staff_Name
            // 
            this.tb_Staff_Name.BackColor = System.Drawing.Color.White;
            this.tb_Staff_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Staff_Name.Location = new System.Drawing.Point(290, 119);
            this.tb_Staff_Name.MaxLength = 50;
            this.tb_Staff_Name.Name = "tb_Staff_Name";
            this.tb_Staff_Name.Size = new System.Drawing.Size(312, 39);
            this.tb_Staff_Name.TabIndex = 3;
            this.tb_Staff_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // lbl_Staff_Name
            // 
            this.lbl_Staff_Name.AutoSize = true;
            this.lbl_Staff_Name.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Staff_Name.Location = new System.Drawing.Point(6, 119);
            this.lbl_Staff_Name.Name = "lbl_Staff_Name";
            this.lbl_Staff_Name.Size = new System.Drawing.Size(149, 31);
            this.lbl_Staff_Name.TabIndex = 10;
            this.lbl_Staff_Name.Text = "Staff Name";
            // 
            // gb_More_Details
            // 
            this.gb_More_Details.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_More_Details.Controls.Add(this.tb_Note);
            this.gb_More_Details.Controls.Add(this.lbl_Note);
            this.gb_More_Details.Controls.Add(this.tb_Salary);
            this.gb_More_Details.Controls.Add(this.lbl_Salary);
            this.gb_More_Details.Controls.Add(this.tb_Aadhar_No);
            this.gb_More_Details.Controls.Add(this.tb_Email_Id);
            this.gb_More_Details.Controls.Add(this.lbl_Aadhar_No);
            this.gb_More_Details.Controls.Add(this.lbl_Email_Id);
            this.gb_More_Details.Controls.Add(this.tb_Alt_Mobile_No);
            this.gb_More_Details.Controls.Add(this.lbl_Alternate_Mobile_Id);
            this.gb_More_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_More_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_More_Details.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_More_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_More_Details.Location = new System.Drawing.Point(12, 193);
            this.gb_More_Details.Name = "gb_More_Details";
            this.gb_More_Details.Size = new System.Drawing.Size(1262, 272);
            this.gb_More_Details.TabIndex = 2;
            this.gb_More_Details.TabStop = false;
            this.gb_More_Details.Text = "More Details";
            // 
            // tb_Note
            // 
            this.tb_Note.BackColor = System.Drawing.Color.White;
            this.tb_Note.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Note.Location = new System.Drawing.Point(900, 182);
            this.tb_Note.MaxLength = 250;
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(312, 84);
            this.tb_Note.TabIndex = 11;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Black;
            this.lbl_Note.Location = new System.Drawing.Point(669, 185);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(72, 31);
            this.lbl_Note.TabIndex = 22;
            this.lbl_Note.Text = "Note";
            // 
            // tb_Salary
            // 
            this.tb_Salary.BackColor = System.Drawing.Color.White;
            this.tb_Salary.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Salary.Location = new System.Drawing.Point(290, 205);
            this.tb_Salary.MaxLength = 7;
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(312, 39);
            this.tb_Salary.TabIndex = 8;
            this.tb_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.ForeColor = System.Drawing.Color.Black;
            this.lbl_Salary.Location = new System.Drawing.Point(6, 205);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(89, 31);
            this.lbl_Salary.TabIndex = 20;
            this.lbl_Salary.Text = "Salary";
            // 
            // tb_Aadhar_No
            // 
            this.tb_Aadhar_No.BackColor = System.Drawing.Color.White;
            this.tb_Aadhar_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Aadhar_No.Location = new System.Drawing.Point(902, 37);
            this.tb_Aadhar_No.MaxLength = 12;
            this.tb_Aadhar_No.Name = "tb_Aadhar_No";
            this.tb_Aadhar_No.Size = new System.Drawing.Size(312, 39);
            this.tb_Aadhar_No.TabIndex = 9;
            this.tb_Aadhar_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Email_Id
            // 
            this.tb_Email_Id.BackColor = System.Drawing.Color.White;
            this.tb_Email_Id.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email_Id.Location = new System.Drawing.Point(900, 114);
            this.tb_Email_Id.MaxLength = 30;
            this.tb_Email_Id.Name = "tb_Email_Id";
            this.tb_Email_Id.Size = new System.Drawing.Size(312, 39);
            this.tb_Email_Id.TabIndex = 10;
            // 
            // lbl_Aadhar_No
            // 
            this.lbl_Aadhar_No.AutoSize = true;
            this.lbl_Aadhar_No.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aadhar_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Aadhar_No.Location = new System.Drawing.Point(665, 40);
            this.lbl_Aadhar_No.Name = "lbl_Aadhar_No";
            this.lbl_Aadhar_No.Size = new System.Drawing.Size(146, 31);
            this.lbl_Aadhar_No.TabIndex = 16;
            this.lbl_Aadhar_No.Text = "Aadhar No";
            // 
            // lbl_Email_Id
            // 
            this.lbl_Email_Id.AutoSize = true;
            this.lbl_Email_Id.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Email_Id.Location = new System.Drawing.Point(665, 114);
            this.lbl_Email_Id.Name = "lbl_Email_Id";
            this.lbl_Email_Id.Size = new System.Drawing.Size(120, 31);
            this.lbl_Email_Id.TabIndex = 18;
            this.lbl_Email_Id.Text = "Email Id";
            // 
            // tb_Alt_Mobile_No
            // 
            this.tb_Alt_Mobile_No.BackColor = System.Drawing.Color.White;
            this.tb_Alt_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alt_Mobile_No.Location = new System.Drawing.Point(290, 114);
            this.tb_Alt_Mobile_No.MaxLength = 10;
            this.tb_Alt_Mobile_No.Name = "tb_Alt_Mobile_No";
            this.tb_Alt_Mobile_No.Size = new System.Drawing.Size(312, 39);
            this.tb_Alt_Mobile_No.TabIndex = 7;
            this.tb_Alt_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Alternate_Mobile_Id
            // 
            this.lbl_Alternate_Mobile_Id.AutoSize = true;
            this.lbl_Alternate_Mobile_Id.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alternate_Mobile_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Alternate_Mobile_Id.Location = new System.Drawing.Point(6, 122);
            this.lbl_Alternate_Mobile_Id.Name = "lbl_Alternate_Mobile_Id";
            this.lbl_Alternate_Mobile_Id.Size = new System.Drawing.Size(259, 31);
            this.lbl_Alternate_Mobile_Id.TabIndex = 10;
            this.lbl_Alternate_Mobile_Id.Text = "Alternate Mobile No";
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.BackColor = System.Drawing.Color.White;
            this.tb_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(290, 37);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(312, 39);
            this.tb_Mobile_No.TabIndex = 6;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(6, 45);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(141, 31);
            this.lbl_Mobile_No.TabIndex = 4;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(936, 655);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(243, 60);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // frm_Update_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1286, 718);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.gb_More_Details);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.gb_Bank_Details);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Update_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Staff";
            this.gb_Bank_Details.ResumeLayout(false);
            this.gb_Bank_Details.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_More_Details.ResumeLayout(false);
            this.gb_More_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.GroupBox gb_Bank_Details;
        private System.Windows.Forms.TextBox tb_Account_No;
        private System.Windows.Forms.Label lbl_Account_No;
        private System.Windows.Forms.TextBox tb_Bank_Details;
        private System.Windows.Forms.Label lbl_Bank_Details;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Staff_Id;
        private System.Windows.Forms.Label lbl_Staff_Id;
        private System.Windows.Forms.Label lbl_Designation;
        private System.Windows.Forms.TextBox tb_Staff_Name;
        private System.Windows.Forms.Label lbl_Staff_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox gb_More_Details;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.TextBox tb_Aadhar_No;
        private System.Windows.Forms.TextBox tb_Email_Id;
        private System.Windows.Forms.Label lbl_Aadhar_No;
        private System.Windows.Forms.Label lbl_Email_Id;
        private System.Windows.Forms.TextBox tb_Alt_Mobile_No;
        private System.Windows.Forms.Label lbl_Alternate_Mobile_Id;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.ComboBox cmb_Designation;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DateTimePicker dtp_Joining_Date;
        private System.Windows.Forms.Label lbl_Joining_Date;
    }
}