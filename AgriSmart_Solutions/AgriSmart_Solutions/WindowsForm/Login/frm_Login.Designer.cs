
namespace AgriSmart_Solutions
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.pb_Agri_Image = new System.Windows.Forms.PictureBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_User_Role = new System.Windows.Forms.Label();
            this.cmb_User_Role = new System.Windows.Forms.ComboBox();
            this.cmb_Username = new System.Windows.Forms.ComboBox();
            this.pnl_Login_Header = new System.Windows.Forms.Panel();
            this.lbl_Akshay_Krushi_Seva_Kendra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Agri_Image)).BeginInit();
            this.pnl_Login_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Agri_Image
            // 
            this.pb_Agri_Image.BackColor = System.Drawing.Color.ForestGreen;
            this.pb_Agri_Image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Agri_Image.BackgroundImage")));
            this.pb_Agri_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Agri_Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Agri_Image.Location = new System.Drawing.Point(27, 138);
            this.pb_Agri_Image.Name = "pb_Agri_Image";
            this.pb_Agri_Image.Size = new System.Drawing.Size(500, 486);
            this.pb_Agri_Image.TabIndex = 1;
            this.pb_Agri_Image.TabStop = false;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Submit.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Submit.Location = new System.Drawing.Point(717, 567);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(224, 71);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.SystemColors.Info;
            this.tb_Password.Font = new System.Drawing.Font("Times New Roman", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(818, 434);
            this.tb_Password.MaxLength = 8;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(281, 44);
            this.tb_Password.TabIndex = 3;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Brown;
            this.lbl_Password.Location = new System.Drawing.Point(557, 434);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(147, 32);
            this.lbl_Password.TabIndex = 9;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Brown;
            this.lbl_Username.Location = new System.Drawing.Point(557, 314);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(153, 32);
            this.lbl_Username.TabIndex = 8;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_User_Role
            // 
            this.lbl_User_Role.AutoSize = true;
            this.lbl_User_Role.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_User_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Role.ForeColor = System.Drawing.Color.Brown;
            this.lbl_User_Role.Location = new System.Drawing.Point(557, 197);
            this.lbl_User_Role.Name = "lbl_User_Role";
            this.lbl_User_Role.Size = new System.Drawing.Size(149, 32);
            this.lbl_User_Role.TabIndex = 13;
            this.lbl_User_Role.Text = "User Role";
            // 
            // cmb_User_Role
            // 
            this.cmb_User_Role.BackColor = System.Drawing.SystemColors.Info;
            this.cmb_User_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_User_Role.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_User_Role.FormattingEnabled = true;
            this.cmb_User_Role.Location = new System.Drawing.Point(818, 197);
            this.cmb_User_Role.MaxLength = 40;
            this.cmb_User_Role.Name = "cmb_User_Role";
            this.cmb_User_Role.Size = new System.Drawing.Size(281, 42);
            this.cmb_User_Role.TabIndex = 1;
            this.cmb_User_Role.SelectedIndexChanged += new System.EventHandler(this.cmb_User_Role_SelectedIndexChanged);
            // 
            // cmb_Username
            // 
            this.cmb_Username.BackColor = System.Drawing.SystemColors.Info;
            this.cmb_Username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Username.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Username.FormattingEnabled = true;
            this.cmb_Username.Location = new System.Drawing.Point(818, 314);
            this.cmb_Username.MaxLength = 40;
            this.cmb_Username.Name = "cmb_Username";
            this.cmb_Username.Size = new System.Drawing.Size(281, 42);
            this.cmb_Username.TabIndex = 2;
            // 
            // pnl_Login_Header
            // 
            this.pnl_Login_Header.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnl_Login_Header.Controls.Add(this.lbl_Akshay_Krushi_Seva_Kendra);
            this.pnl_Login_Header.Location = new System.Drawing.Point(-2, -4);
            this.pnl_Login_Header.Name = "pnl_Login_Header";
            this.pnl_Login_Header.Size = new System.Drawing.Size(1115, 121);
            this.pnl_Login_Header.TabIndex = 14;
            // 
            // lbl_Akshay_Krushi_Seva_Kendra
            // 
            this.lbl_Akshay_Krushi_Seva_Kendra.AutoSize = true;
            this.lbl_Akshay_Krushi_Seva_Kendra.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Akshay_Krushi_Seva_Kendra.ForeColor = System.Drawing.Color.White;
            this.lbl_Akshay_Krushi_Seva_Kendra.Location = new System.Drawing.Point(195, 34);
            this.lbl_Akshay_Krushi_Seva_Kendra.Name = "lbl_Akshay_Krushi_Seva_Kendra";
            this.lbl_Akshay_Krushi_Seva_Kendra.Size = new System.Drawing.Size(748, 54);
            this.lbl_Akshay_Krushi_Seva_Kendra.TabIndex = 0;
            this.lbl_Akshay_Krushi_Seva_Kendra.Text = "Akshay Krushi Seva Kendra";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 674);
            this.Controls.Add(this.pnl_Login_Header);
            this.Controls.Add(this.cmb_Username);
            this.Controls.Add(this.cmb_User_Role);
            this.Controls.Add(this.lbl_User_Role);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.pb_Agri_Image);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Agri_Image)).EndInit();
            this.pnl_Login_Header.ResumeLayout(false);
            this.pnl_Login_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Agri_Image;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_User_Role;
        private System.Windows.Forms.ComboBox cmb_User_Role;
        private System.Windows.Forms.ComboBox cmb_Username;
        private System.Windows.Forms.Panel pnl_Login_Header;
        private System.Windows.Forms.Label lbl_Akshay_Krushi_Seva_Kendra;
    }
}

