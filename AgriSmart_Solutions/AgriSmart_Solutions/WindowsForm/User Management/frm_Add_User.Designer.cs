
namespace AgriSmart_Solutions.WindowsForm.User_Management
{
    partial class frm_Add_User
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
            this.gb_Add_New_User = new System.Windows.Forms.GroupBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.cmb_User_Role = new System.Windows.Forms.ComboBox();
            this.tb_Confirm_Password = new System.Windows.Forms.TextBox();
            this.lbl_Confirm_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_User_Role = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Add_New_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Add_New_User
            // 
            this.gb_Add_New_User.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Add_New_User.Controls.Add(this.tb_Username);
            this.gb_Add_New_User.Controls.Add(this.tb_Password);
            this.gb_Add_New_User.Controls.Add(this.lbl_Password);
            this.gb_Add_New_User.Controls.Add(this.cmb_User_Role);
            this.gb_Add_New_User.Controls.Add(this.tb_Confirm_Password);
            this.gb_Add_New_User.Controls.Add(this.lbl_Confirm_Password);
            this.gb_Add_New_User.Controls.Add(this.lbl_Username);
            this.gb_Add_New_User.Controls.Add(this.lbl_User_Role);
            this.gb_Add_New_User.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Add_New_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Add_New_User.Location = new System.Drawing.Point(26, 25);
            this.gb_Add_New_User.Name = "gb_Add_New_User";
            this.gb_Add_New_User.Size = new System.Drawing.Size(1202, 609);
            this.gb_Add_New_User.TabIndex = 22;
            this.gb_Add_New_User.TabStop = false;
            this.gb_Add_New_User.Text = "Add New User";
            // 
            // tb_Username
            // 
            this.tb_Username.BackColor = System.Drawing.Color.White;
            this.tb_Username.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(670, 241);
            this.tb_Username.MaxLength = 20;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(318, 42);
            this.tb_Username.TabIndex = 2;
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.White;
            this.tb_Password.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(670, 352);
            this.tb_Password.MaxLength = 8;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(318, 42);
            this.tb_Password.TabIndex = 3;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Black;
            this.lbl_Password.Location = new System.Drawing.Point(302, 354);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(141, 35);
            this.lbl_Password.TabIndex = 19;
            this.lbl_Password.Text = "Password";
            // 
            // cmb_User_Role
            // 
            this.cmb_User_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_User_Role.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_User_Role.FormattingEnabled = true;
            this.cmb_User_Role.Location = new System.Drawing.Point(670, 127);
            this.cmb_User_Role.MaxLength = 40;
            this.cmb_User_Role.Name = "cmb_User_Role";
            this.cmb_User_Role.Size = new System.Drawing.Size(318, 42);
            this.cmb_User_Role.TabIndex = 1;
            // 
            // tb_Confirm_Password
            // 
            this.tb_Confirm_Password.BackColor = System.Drawing.Color.White;
            this.tb_Confirm_Password.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Confirm_Password.Location = new System.Drawing.Point(670, 476);
            this.tb_Confirm_Password.MaxLength = 8;
            this.tb_Confirm_Password.Name = "tb_Confirm_Password";
            this.tb_Confirm_Password.Size = new System.Drawing.Size(318, 42);
            this.tb_Confirm_Password.TabIndex = 4;
            // 
            // lbl_Confirm_Password
            // 
            this.lbl_Confirm_Password.AutoSize = true;
            this.lbl_Confirm_Password.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm_Password.ForeColor = System.Drawing.Color.Black;
            this.lbl_Confirm_Password.Location = new System.Drawing.Point(302, 478);
            this.lbl_Confirm_Password.Name = "lbl_Confirm_Password";
            this.lbl_Confirm_Password.Size = new System.Drawing.Size(258, 35);
            this.lbl_Confirm_Password.TabIndex = 17;
            this.lbl_Confirm_Password.Text = "Confirm Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Black;
            this.lbl_Username.Location = new System.Drawing.Point(302, 238);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(152, 35);
            this.lbl_Username.TabIndex = 10;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_User_Role
            // 
            this.lbl_User_Role.AutoSize = true;
            this.lbl_User_Role.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Role.ForeColor = System.Drawing.Color.Black;
            this.lbl_User_Role.Location = new System.Drawing.Point(302, 124);
            this.lbl_User_Role.Name = "lbl_User_Role";
            this.lbl_User_Role.Size = new System.Drawing.Size(146, 35);
            this.lbl_User_Role.TabIndex = 4;
            this.lbl_User_Role.Text = "User Role";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(251, 655);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(243, 63);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(786, 654);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(243, 63);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1280, 718);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Add_New_User);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.frm_Add_User_Load);
            this.gb_Add_New_User.ResumeLayout(false);
            this.gb_Add_New_User.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Add_New_User;
        private System.Windows.Forms.ComboBox cmb_User_Role;
        private System.Windows.Forms.TextBox tb_Confirm_Password;
        private System.Windows.Forms.Label lbl_Confirm_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_User_Role;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Username;
    }
}