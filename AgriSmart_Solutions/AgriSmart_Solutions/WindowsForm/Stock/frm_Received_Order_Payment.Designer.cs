
namespace AgriSmart_Solutions.WindowsForm.Stock
{
    partial class frm_Received_Order_Payment
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
            this.gb_Payment_Details = new System.Windows.Forms.GroupBox();
            this.tb_Payment_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Payment_Amount = new System.Windows.Forms.Label();
            this.tb_Payment_Id = new System.Windows.Forms.TextBox();
            this.lbl_Payment_Id = new System.Windows.Forms.Label();
            this.lbl_Payment_Date = new System.Windows.Forms.Label();
            this.dtp_Payment_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.cmb_Payment_Media = new System.Windows.Forms.ComboBox();
            this.tb_Balanced_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Payment_Media = new System.Windows.Forms.Label();
            this.lbl_Balanced_Amount = new System.Windows.Forms.Label();
            this.tb_Paid_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Paid_Amount = new System.Windows.Forms.Label();
            this.tb_Final_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Final_Bill = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Received_Order_Details = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_Received_Order_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Received_Order_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Payment_Details.SuspendLayout();
            this.gb_Received_Order_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Payment_Details
            // 
            this.gb_Payment_Details.BackColor = System.Drawing.Color.PeachPuff;
            this.gb_Payment_Details.Controls.Add(this.tb_Payment_Amount);
            this.gb_Payment_Details.Controls.Add(this.lbl_Payment_Amount);
            this.gb_Payment_Details.Controls.Add(this.tb_Payment_Id);
            this.gb_Payment_Details.Controls.Add(this.lbl_Payment_Id);
            this.gb_Payment_Details.Controls.Add(this.lbl_Payment_Date);
            this.gb_Payment_Details.Controls.Add(this.dtp_Payment_Date);
            this.gb_Payment_Details.Controls.Add(this.tb_Note);
            this.gb_Payment_Details.Controls.Add(this.lbl_Note);
            this.gb_Payment_Details.Controls.Add(this.cmb_Payment_Media);
            this.gb_Payment_Details.Controls.Add(this.tb_Balanced_Amount);
            this.gb_Payment_Details.Controls.Add(this.lbl_Payment_Media);
            this.gb_Payment_Details.Controls.Add(this.lbl_Balanced_Amount);
            this.gb_Payment_Details.Controls.Add(this.tb_Paid_Amount);
            this.gb_Payment_Details.Controls.Add(this.lbl_Paid_Amount);
            this.gb_Payment_Details.Controls.Add(this.tb_Final_Bill);
            this.gb_Payment_Details.Controls.Add(this.lbl_Final_Bill);
            this.gb_Payment_Details.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Payment_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Payment_Details.Location = new System.Drawing.Point(12, 169);
            this.gb_Payment_Details.Name = "gb_Payment_Details";
            this.gb_Payment_Details.Size = new System.Drawing.Size(1256, 473);
            this.gb_Payment_Details.TabIndex = 2;
            this.gb_Payment_Details.TabStop = false;
            this.gb_Payment_Details.Text = "Payment Details";
            // 
            // tb_Payment_Amount
            // 
            this.tb_Payment_Amount.BackColor = System.Drawing.Color.White;
            this.tb_Payment_Amount.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Payment_Amount.Location = new System.Drawing.Point(940, 255);
            this.tb_Payment_Amount.MaxLength = 8;
            this.tb_Payment_Amount.Name = "tb_Payment_Amount";
            this.tb_Payment_Amount.Size = new System.Drawing.Size(290, 37);
            this.tb_Payment_Amount.TabIndex = 3;
            this.tb_Payment_Amount.Text = "0";
            this.tb_Payment_Amount.TextChanged += new System.EventHandler(this.tb_Payment_Amount_TextChanged);
            this.tb_Payment_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Payment_Amount.Leave += new System.EventHandler(this.tb_Payment_Amount_Leave);
            // 
            // lbl_Payment_Amount
            // 
            this.lbl_Payment_Amount.AutoSize = true;
            this.lbl_Payment_Amount.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Amount.ForeColor = System.Drawing.Color.Black;
            this.lbl_Payment_Amount.Location = new System.Drawing.Point(661, 248);
            this.lbl_Payment_Amount.Name = "lbl_Payment_Amount";
            this.lbl_Payment_Amount.Size = new System.Drawing.Size(236, 32);
            this.lbl_Payment_Amount.TabIndex = 51;
            this.lbl_Payment_Amount.Text = "Payment Amount";
            // 
            // tb_Payment_Id
            // 
            this.tb_Payment_Id.BackColor = System.Drawing.Color.White;
            this.tb_Payment_Id.Enabled = false;
            this.tb_Payment_Id.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Payment_Id.Location = new System.Drawing.Point(307, 52);
            this.tb_Payment_Id.MaxLength = 8;
            this.tb_Payment_Id.Name = "tb_Payment_Id";
            this.tb_Payment_Id.Size = new System.Drawing.Size(284, 37);
            this.tb_Payment_Id.TabIndex = 49;
            // 
            // lbl_Payment_Id
            // 
            this.lbl_Payment_Id.AutoSize = true;
            this.lbl_Payment_Id.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Payment_Id.Location = new System.Drawing.Point(34, 57);
            this.lbl_Payment_Id.Name = "lbl_Payment_Id";
            this.lbl_Payment_Id.Size = new System.Drawing.Size(160, 32);
            this.lbl_Payment_Id.TabIndex = 50;
            this.lbl_Payment_Id.Text = "Payment Id";
            // 
            // lbl_Payment_Date
            // 
            this.lbl_Payment_Date.AutoSize = true;
            this.lbl_Payment_Date.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Payment_Date.Location = new System.Drawing.Point(661, 54);
            this.lbl_Payment_Date.Name = "lbl_Payment_Date";
            this.lbl_Payment_Date.Size = new System.Drawing.Size(192, 32);
            this.lbl_Payment_Date.TabIndex = 48;
            this.lbl_Payment_Date.Text = "Payment Date";
            // 
            // dtp_Payment_Date
            // 
            this.dtp_Payment_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Payment_Date.Location = new System.Drawing.Point(940, 54);
            this.dtp_Payment_Date.Name = "dtp_Payment_Date";
            this.dtp_Payment_Date.Size = new System.Drawing.Size(290, 34);
            this.dtp_Payment_Date.TabIndex = 0;
            // 
            // tb_Note
            // 
            this.tb_Note.BackColor = System.Drawing.Color.White;
            this.tb_Note.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Note.Location = new System.Drawing.Point(307, 328);
            this.tb_Note.MaxLength = 250;
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(284, 82);
            this.tb_Note.TabIndex = 4;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Black;
            this.lbl_Note.Location = new System.Drawing.Point(41, 328);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(75, 32);
            this.lbl_Note.TabIndex = 42;
            this.lbl_Note.Text = "Note";
            // 
            // cmb_Payment_Media
            // 
            this.cmb_Payment_Media.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Payment_Media.FormattingEnabled = true;
            this.cmb_Payment_Media.Items.AddRange(new object[] {
            "Cash",
            "Online",
            "Cheque"});
            this.cmb_Payment_Media.Location = new System.Drawing.Point(940, 345);
            this.cmb_Payment_Media.MaxLength = 20;
            this.cmb_Payment_Media.Name = "cmb_Payment_Media";
            this.cmb_Payment_Media.Size = new System.Drawing.Size(290, 39);
            this.cmb_Payment_Media.TabIndex = 5;
            // 
            // tb_Balanced_Amount
            // 
            this.tb_Balanced_Amount.BackColor = System.Drawing.Color.White;
            this.tb_Balanced_Amount.Enabled = false;
            this.tb_Balanced_Amount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Balanced_Amount.Location = new System.Drawing.Point(940, 150);
            this.tb_Balanced_Amount.MaxLength = 8;
            this.tb_Balanced_Amount.Name = "tb_Balanced_Amount";
            this.tb_Balanced_Amount.Size = new System.Drawing.Size(290, 39);
            this.tb_Balanced_Amount.TabIndex = 11;
            this.tb_Balanced_Amount.Text = "0";
            this.tb_Balanced_Amount.TextChanged += new System.EventHandler(this.tb_Balanced_Amount_TextChanged);
            this.tb_Balanced_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Balanced_Amount.Leave += new System.EventHandler(this.tb_Balanced_Amount_Leave);
            // 
            // lbl_Payment_Media
            // 
            this.lbl_Payment_Media.AutoSize = true;
            this.lbl_Payment_Media.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Media.ForeColor = System.Drawing.Color.Black;
            this.lbl_Payment_Media.Location = new System.Drawing.Point(661, 347);
            this.lbl_Payment_Media.Name = "lbl_Payment_Media";
            this.lbl_Payment_Media.Size = new System.Drawing.Size(211, 32);
            this.lbl_Payment_Media.TabIndex = 39;
            this.lbl_Payment_Media.Text = "Payment Media";
            // 
            // lbl_Balanced_Amount
            // 
            this.lbl_Balanced_Amount.AutoSize = true;
            this.lbl_Balanced_Amount.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balanced_Amount.ForeColor = System.Drawing.Color.Black;
            this.lbl_Balanced_Amount.Location = new System.Drawing.Point(661, 150);
            this.lbl_Balanced_Amount.Name = "lbl_Balanced_Amount";
            this.lbl_Balanced_Amount.Size = new System.Drawing.Size(272, 32);
            this.lbl_Balanced_Amount.TabIndex = 37;
            this.lbl_Balanced_Amount.Text = "Balanced Amount";
            // 
            // tb_Paid_Amount
            // 
            this.tb_Paid_Amount.BackColor = System.Drawing.Color.White;
            this.tb_Paid_Amount.Enabled = false;
            this.tb_Paid_Amount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Paid_Amount.Location = new System.Drawing.Point(307, 241);
            this.tb_Paid_Amount.MaxLength = 8;
            this.tb_Paid_Amount.Name = "tb_Paid_Amount";
            this.tb_Paid_Amount.Size = new System.Drawing.Size(284, 39);
            this.tb_Paid_Amount.TabIndex = 10;
            this.tb_Paid_Amount.Text = "0";
            this.tb_Paid_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Paid_Amount.Leave += new System.EventHandler(this.tb_Paid_Amount_Leave);
            // 
            // lbl_Paid_Amount
            // 
            this.lbl_Paid_Amount.AutoSize = true;
            this.lbl_Paid_Amount.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paid_Amount.ForeColor = System.Drawing.Color.Black;
            this.lbl_Paid_Amount.Location = new System.Drawing.Point(34, 243);
            this.lbl_Paid_Amount.Name = "lbl_Paid_Amount";
            this.lbl_Paid_Amount.Size = new System.Drawing.Size(204, 32);
            this.lbl_Paid_Amount.TabIndex = 35;
            this.lbl_Paid_Amount.Text = "Paid Amount";
            // 
            // tb_Final_Bill
            // 
            this.tb_Final_Bill.BackColor = System.Drawing.Color.White;
            this.tb_Final_Bill.Enabled = false;
            this.tb_Final_Bill.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Final_Bill.Location = new System.Drawing.Point(307, 152);
            this.tb_Final_Bill.MaxLength = 8;
            this.tb_Final_Bill.Name = "tb_Final_Bill";
            this.tb_Final_Bill.Size = new System.Drawing.Size(284, 37);
            this.tb_Final_Bill.TabIndex = 9;
            this.tb_Final_Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Final_Bill
            // 
            this.lbl_Final_Bill.AutoSize = true;
            this.lbl_Final_Bill.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Final_Bill.ForeColor = System.Drawing.Color.Black;
            this.lbl_Final_Bill.Location = new System.Drawing.Point(34, 157);
            this.lbl_Final_Bill.Name = "lbl_Final_Bill";
            this.lbl_Final_Bill.Size = new System.Drawing.Size(135, 32);
            this.lbl_Final_Bill.TabIndex = 33;
            this.lbl_Final_Bill.Text = "Final Bill ";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(767, 657);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(243, 58);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gb_Received_Order_Details
            // 
            this.gb_Received_Order_Details.BackColor = System.Drawing.Color.PeachPuff;
            this.gb_Received_Order_Details.Controls.Add(this.btn_Search);
            this.gb_Received_Order_Details.Controls.Add(this.label1);
            this.gb_Received_Order_Details.Controls.Add(this.dtp_Received_Order_Date);
            this.gb_Received_Order_Details.Controls.Add(this.tb_Received_Order_Id);
            this.gb_Received_Order_Details.Controls.Add(this.label2);
            this.gb_Received_Order_Details.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Received_Order_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Received_Order_Details.Location = new System.Drawing.Point(12, 12);
            this.gb_Received_Order_Details.Name = "gb_Received_Order_Details";
            this.gb_Received_Order_Details.Size = new System.Drawing.Size(1256, 138);
            this.gb_Received_Order_Details.TabIndex = 1;
            this.gb_Received_Order_Details.TabStop = false;
            this.gb_Received_Order_Details.Text = "Received Order Details";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Search.Location = new System.Drawing.Point(361, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(188, 54);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(646, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Received Order Date";
            // 
            // dtp_Received_Order_Date
            // 
            this.dtp_Received_Order_Date.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Received_Order_Date.Location = new System.Drawing.Point(932, 69);
            this.dtp_Received_Order_Date.Name = "dtp_Received_Order_Date";
            this.dtp_Received_Order_Date.Size = new System.Drawing.Size(279, 37);
            this.dtp_Received_Order_Date.TabIndex = 4;
            // 
            // tb_Received_Order_Id
            // 
            this.tb_Received_Order_Id.BackColor = System.Drawing.Color.White;
            this.tb_Received_Order_Id.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Received_Order_Id.Location = new System.Drawing.Point(307, 73);
            this.tb_Received_Order_Id.MaxLength = 8;
            this.tb_Received_Order_Id.Name = "tb_Received_Order_Id";
            this.tb_Received_Order_Id.Size = new System.Drawing.Size(284, 34);
            this.tb_Received_Order_Id.TabIndex = 1;
            this.tb_Received_Order_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Received Order Id";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(258, 657);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(243, 58);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Received_Order_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1280, 718);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Received_Order_Details);
            this.Controls.Add(this.gb_Payment_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Received_Order_Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Received_Order_Payment";
            this.Load += new System.EventHandler(this.frm_Received_Order_Payment_Load);
            this.gb_Payment_Details.ResumeLayout(false);
            this.gb_Payment_Details.PerformLayout();
            this.gb_Received_Order_Details.ResumeLayout(false);
            this.gb_Received_Order_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Payment_Details;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.ComboBox cmb_Payment_Media;
        private System.Windows.Forms.TextBox tb_Balanced_Amount;
        private System.Windows.Forms.Label lbl_Payment_Media;
        private System.Windows.Forms.Label lbl_Balanced_Amount;
        private System.Windows.Forms.TextBox tb_Paid_Amount;
        private System.Windows.Forms.Label lbl_Paid_Amount;
        private System.Windows.Forms.TextBox tb_Final_Bill;
        private System.Windows.Forms.Label lbl_Final_Bill;
        private System.Windows.Forms.Label lbl_Payment_Date;
        private System.Windows.Forms.DateTimePicker dtp_Payment_Date;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox gb_Received_Order_Details;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Received_Order_Date;
        private System.Windows.Forms.TextBox tb_Received_Order_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Payment_Id;
        private System.Windows.Forms.Label lbl_Payment_Id;
        private System.Windows.Forms.TextBox tb_Payment_Amount;
        private System.Windows.Forms.Label lbl_Payment_Amount;
        private System.Windows.Forms.Button btn_Refresh;
    }
}