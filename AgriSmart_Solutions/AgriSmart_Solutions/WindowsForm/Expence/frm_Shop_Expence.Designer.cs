
namespace AgriSmart_Solutions.WindowsForm.Expence
{
    partial class frm_Shop_Expence
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
            this.gb_Expence_Id_and_Date = new System.Windows.Forms.GroupBox();
            this.lbl_Expence_Date = new System.Windows.Forms.Label();
            this.dtp_Expence_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Expence_Id = new System.Windows.Forms.TextBox();
            this.lbl_Expence_Id = new System.Windows.Forms.Label();
            this.cmb_Payment_Media = new System.Windows.Forms.ComboBox();
            this.lbl_Payment_Media = new System.Windows.Forms.Label();
            this.gb_Expence_Details = new System.Windows.Forms.GroupBox();
            this.lbl_Payment_Receipt = new System.Windows.Forms.Label();
            this.btn_Add_Bill = new System.Windows.Forms.Button();
            this.pb_Bill_Image = new System.Windows.Forms.PictureBox();
            this.lbl_Bill_Image = new System.Windows.Forms.Label();
            this.tb_Expence_Details = new System.Windows.Forms.TextBox();
            this.lbl_Expence_Details = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Payment_Details = new System.Windows.Forms.GroupBox();
            this.tb_Paid_By = new System.Windows.Forms.TextBox();
            this.lbl_Paid_By = new System.Windows.Forms.Label();
            this.tb_Total_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Total_Amount = new System.Windows.Forms.Label();
            this.gb_Expence_Id_and_Date.SuspendLayout();
            this.gb_Expence_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Image)).BeginInit();
            this.gb_Payment_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Expence_Id_and_Date
            // 
            this.gb_Expence_Id_and_Date.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Expence_Id_and_Date.Controls.Add(this.lbl_Expence_Date);
            this.gb_Expence_Id_and_Date.Controls.Add(this.dtp_Expence_Date);
            this.gb_Expence_Id_and_Date.Controls.Add(this.tb_Expence_Id);
            this.gb_Expence_Id_and_Date.Controls.Add(this.lbl_Expence_Id);
            this.gb_Expence_Id_and_Date.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Expence_Id_and_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Expence_Id_and_Date.Location = new System.Drawing.Point(12, 12);
            this.gb_Expence_Id_and_Date.Name = "gb_Expence_Id_and_Date";
            this.gb_Expence_Id_and_Date.Size = new System.Drawing.Size(1256, 119);
            this.gb_Expence_Id_and_Date.TabIndex = 1;
            this.gb_Expence_Id_and_Date.TabStop = false;
            this.gb_Expence_Id_and_Date.Text = "Expence Id and Date";
            // 
            // lbl_Expence_Date
            // 
            this.lbl_Expence_Date.AutoSize = true;
            this.lbl_Expence_Date.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expence_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Expence_Date.Location = new System.Drawing.Point(666, 46);
            this.lbl_Expence_Date.Name = "lbl_Expence_Date";
            this.lbl_Expence_Date.Size = new System.Drawing.Size(187, 32);
            this.lbl_Expence_Date.TabIndex = 33;
            this.lbl_Expence_Date.Text = "Expence Date";
            // 
            // dtp_Expence_Date
            // 
            this.dtp_Expence_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Expence_Date.Location = new System.Drawing.Point(889, 46);
            this.dtp_Expence_Date.Name = "dtp_Expence_Date";
            this.dtp_Expence_Date.Size = new System.Drawing.Size(352, 39);
            this.dtp_Expence_Date.TabIndex = 1;
            // 
            // tb_Expence_Id
            // 
            this.tb_Expence_Id.BackColor = System.Drawing.Color.White;
            this.tb_Expence_Id.Enabled = false;
            this.tb_Expence_Id.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Expence_Id.Location = new System.Drawing.Point(266, 48);
            this.tb_Expence_Id.MaxLength = 8;
            this.tb_Expence_Id.Name = "tb_Expence_Id";
            this.tb_Expence_Id.Size = new System.Drawing.Size(352, 39);
            this.tb_Expence_Id.TabIndex = 0;
            this.tb_Expence_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Expence_Id
            // 
            this.lbl_Expence_Id.AutoSize = true;
            this.lbl_Expence_Id.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expence_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Expence_Id.Location = new System.Drawing.Point(27, 55);
            this.lbl_Expence_Id.Name = "lbl_Expence_Id";
            this.lbl_Expence_Id.Size = new System.Drawing.Size(155, 32);
            this.lbl_Expence_Id.TabIndex = 4;
            this.lbl_Expence_Id.Text = "Expence Id";
            // 
            // cmb_Payment_Media
            // 
            this.cmb_Payment_Media.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Payment_Media.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Payment_Media.FormattingEnabled = true;
            this.cmb_Payment_Media.Items.AddRange(new object[] {
            "Cash",
            "Online",
            "Cheque"});
            this.cmb_Payment_Media.Location = new System.Drawing.Point(901, 41);
            this.cmb_Payment_Media.Name = "cmb_Payment_Media";
            this.cmb_Payment_Media.Size = new System.Drawing.Size(340, 39);
            this.cmb_Payment_Media.TabIndex = 6;
            // 
            // lbl_Payment_Media
            // 
            this.lbl_Payment_Media.AutoSize = true;
            this.lbl_Payment_Media.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Media.ForeColor = System.Drawing.Color.Black;
            this.lbl_Payment_Media.Location = new System.Drawing.Point(666, 41);
            this.lbl_Payment_Media.Name = "lbl_Payment_Media";
            this.lbl_Payment_Media.Size = new System.Drawing.Size(211, 32);
            this.lbl_Payment_Media.TabIndex = 36;
            this.lbl_Payment_Media.Text = "Payment Media";
            // 
            // gb_Expence_Details
            // 
            this.gb_Expence_Details.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Expence_Details.Controls.Add(this.lbl_Payment_Receipt);
            this.gb_Expence_Details.Controls.Add(this.btn_Add_Bill);
            this.gb_Expence_Details.Controls.Add(this.pb_Bill_Image);
            this.gb_Expence_Details.Controls.Add(this.lbl_Bill_Image);
            this.gb_Expence_Details.Controls.Add(this.tb_Expence_Details);
            this.gb_Expence_Details.Controls.Add(this.lbl_Expence_Details);
            this.gb_Expence_Details.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Expence_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Expence_Details.Location = new System.Drawing.Point(12, 137);
            this.gb_Expence_Details.Name = "gb_Expence_Details";
            this.gb_Expence_Details.Size = new System.Drawing.Size(1256, 283);
            this.gb_Expence_Details.TabIndex = 2;
            this.gb_Expence_Details.TabStop = false;
            this.gb_Expence_Details.Text = "Expence Details";
            // 
            // lbl_Payment_Receipt
            // 
            this.lbl_Payment_Receipt.AutoSize = true;
            this.lbl_Payment_Receipt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Receipt.ForeColor = System.Drawing.Color.Black;
            this.lbl_Payment_Receipt.Location = new System.Drawing.Point(651, 122);
            this.lbl_Payment_Receipt.Name = "lbl_Payment_Receipt";
            this.lbl_Payment_Receipt.Size = new System.Drawing.Size(177, 24);
            this.lbl_Payment_Receipt.TabIndex = 35;
            this.lbl_Payment_Receipt.Text = "(Payment Receipt)";
            // 
            // btn_Add_Bill
            // 
            this.btn_Add_Bill.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Add_Bill.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Bill.ForeColor = System.Drawing.Color.Black;
            this.btn_Add_Bill.Location = new System.Drawing.Point(889, 217);
            this.btn_Add_Bill.Name = "btn_Add_Bill";
            this.btn_Add_Bill.Size = new System.Drawing.Size(334, 49);
            this.btn_Add_Bill.TabIndex = 3;
            this.btn_Add_Bill.Text = "Add Bill ";
            this.btn_Add_Bill.UseVisualStyleBackColor = false;
            this.btn_Add_Bill.Click += new System.EventHandler(this.btn_Add_Bill_Click);
            // 
            // pb_Bill_Image
            // 
            this.pb_Bill_Image.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pb_Bill_Image.Location = new System.Drawing.Point(889, 25);
            this.pb_Bill_Image.Name = "pb_Bill_Image";
            this.pb_Bill_Image.Size = new System.Drawing.Size(334, 186);
            this.pb_Bill_Image.TabIndex = 34;
            this.pb_Bill_Image.TabStop = false;
            // 
            // lbl_Bill_Image
            // 
            this.lbl_Bill_Image.AutoSize = true;
            this.lbl_Bill_Image.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill_Image.ForeColor = System.Drawing.Color.Black;
            this.lbl_Bill_Image.Location = new System.Drawing.Point(666, 80);
            this.lbl_Bill_Image.Name = "lbl_Bill_Image";
            this.lbl_Bill_Image.Size = new System.Drawing.Size(149, 32);
            this.lbl_Bill_Image.TabIndex = 33;
            this.lbl_Bill_Image.Text = "Bill Image ";
            // 
            // tb_Expence_Details
            // 
            this.tb_Expence_Details.BackColor = System.Drawing.Color.White;
            this.tb_Expence_Details.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Expence_Details.Location = new System.Drawing.Point(266, 42);
            this.tb_Expence_Details.MaxLength = 80;
            this.tb_Expence_Details.Multiline = true;
            this.tb_Expence_Details.Name = "tb_Expence_Details";
            this.tb_Expence_Details.Size = new System.Drawing.Size(352, 182);
            this.tb_Expence_Details.TabIndex = 2;
            // 
            // lbl_Expence_Details
            // 
            this.lbl_Expence_Details.AutoSize = true;
            this.lbl_Expence_Details.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expence_Details.ForeColor = System.Drawing.Color.Black;
            this.lbl_Expence_Details.Location = new System.Drawing.Point(27, 80);
            this.lbl_Expence_Details.Name = "lbl_Expence_Details";
            this.lbl_Expence_Details.Size = new System.Drawing.Size(215, 32);
            this.lbl_Expence_Details.TabIndex = 4;
            this.lbl_Expence_Details.Text = "Expence Details";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(278, 646);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(243, 60);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(841, 645);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(243, 60);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gb_Payment_Details
            // 
            this.gb_Payment_Details.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Payment_Details.Controls.Add(this.tb_Paid_By);
            this.gb_Payment_Details.Controls.Add(this.lbl_Paid_By);
            this.gb_Payment_Details.Controls.Add(this.tb_Total_Amount);
            this.gb_Payment_Details.Controls.Add(this.lbl_Total_Amount);
            this.gb_Payment_Details.Controls.Add(this.cmb_Payment_Media);
            this.gb_Payment_Details.Controls.Add(this.lbl_Payment_Media);
            this.gb_Payment_Details.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Payment_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Payment_Details.Location = new System.Drawing.Point(12, 426);
            this.gb_Payment_Details.Name = "gb_Payment_Details";
            this.gb_Payment_Details.Size = new System.Drawing.Size(1262, 204);
            this.gb_Payment_Details.TabIndex = 3;
            this.gb_Payment_Details.TabStop = false;
            this.gb_Payment_Details.Text = "Payment Details";
            // 
            // tb_Paid_By
            // 
            this.tb_Paid_By.BackColor = System.Drawing.Color.White;
            this.tb_Paid_By.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Paid_By.Location = new System.Drawing.Point(260, 120);
            this.tb_Paid_By.MaxLength = 30;
            this.tb_Paid_By.Name = "tb_Paid_By";
            this.tb_Paid_By.Size = new System.Drawing.Size(352, 39);
            this.tb_Paid_By.TabIndex = 5;
            this.tb_Paid_By.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // lbl_Paid_By
            // 
            this.lbl_Paid_By.AutoSize = true;
            this.lbl_Paid_By.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paid_By.ForeColor = System.Drawing.Color.Black;
            this.lbl_Paid_By.Location = new System.Drawing.Point(27, 127);
            this.lbl_Paid_By.Name = "lbl_Paid_By";
            this.lbl_Paid_By.Size = new System.Drawing.Size(109, 32);
            this.lbl_Paid_By.TabIndex = 40;
            this.lbl_Paid_By.Text = "Paid By";
            // 
            // tb_Total_Amount
            // 
            this.tb_Total_Amount.BackColor = System.Drawing.Color.White;
            this.tb_Total_Amount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Amount.Location = new System.Drawing.Point(260, 43);
            this.tb_Total_Amount.MaxLength = 8;
            this.tb_Total_Amount.Name = "tb_Total_Amount";
            this.tb_Total_Amount.Size = new System.Drawing.Size(352, 39);
            this.tb_Total_Amount.TabIndex = 4;
            this.tb_Total_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Total_Amount
            // 
            this.lbl_Total_Amount.AutoSize = true;
            this.lbl_Total_Amount.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Amount.ForeColor = System.Drawing.Color.Black;
            this.lbl_Total_Amount.Location = new System.Drawing.Point(21, 50);
            this.lbl_Total_Amount.Name = "lbl_Total_Amount";
            this.lbl_Total_Amount.Size = new System.Drawing.Size(189, 32);
            this.lbl_Total_Amount.TabIndex = 37;
            this.lbl_Total_Amount.Text = "Total Amount";
            // 
            // frm_Shop_Expence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1286, 718);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Payment_Details);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Expence_Details);
            this.Controls.Add(this.gb_Expence_Id_and_Date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Shop_Expence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shop Expence";
            this.Load += new System.EventHandler(this.frm_Shop_Expence_Load);
            this.gb_Expence_Id_and_Date.ResumeLayout(false);
            this.gb_Expence_Id_and_Date.PerformLayout();
            this.gb_Expence_Details.ResumeLayout(false);
            this.gb_Expence_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Image)).EndInit();
            this.gb_Payment_Details.ResumeLayout(false);
            this.gb_Payment_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Expence_Id_and_Date;
        private System.Windows.Forms.ComboBox cmb_Payment_Media;
        private System.Windows.Forms.Label lbl_Payment_Media;
        private System.Windows.Forms.Label lbl_Expence_Date;
        private System.Windows.Forms.DateTimePicker dtp_Expence_Date;
        private System.Windows.Forms.TextBox tb_Expence_Id;
        private System.Windows.Forms.Label lbl_Expence_Id;
        private System.Windows.Forms.GroupBox gb_Expence_Details;
        private System.Windows.Forms.PictureBox pb_Bill_Image;
        private System.Windows.Forms.Label lbl_Bill_Image;
        private System.Windows.Forms.TextBox tb_Expence_Details;
        private System.Windows.Forms.Label lbl_Expence_Details;
        private System.Windows.Forms.Button btn_Add_Bill;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox gb_Payment_Details;
        private System.Windows.Forms.Label lbl_Paid_By;
        private System.Windows.Forms.TextBox tb_Total_Amount;
        private System.Windows.Forms.Label lbl_Total_Amount;
        private System.Windows.Forms.TextBox tb_Paid_By;
        private System.Windows.Forms.Label lbl_Payment_Receipt;
    }
}