
namespace AgriSmart_Solutions.WindowsForm.User_Management
{
    partial class frm_Delete_User
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_Delete_User = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tb_UserRole = new System.Windows.Forms.TextBox();
            this.dgv_User_Details = new System.Windows.Forms.DataGridView();
            this.tb_Admin_Password = new System.Windows.Forms.TextBox();
            this.lbl_Admin_Password = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_User_Role = new System.Windows.Forms.Label();
            this.gb_Delete_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Delete_User
            // 
            this.gb_Delete_User.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Delete_User.Controls.Add(this.btn_Delete);
            this.gb_Delete_User.Controls.Add(this.tb_UserRole);
            this.gb_Delete_User.Controls.Add(this.dgv_User_Details);
            this.gb_Delete_User.Controls.Add(this.tb_Admin_Password);
            this.gb_Delete_User.Controls.Add(this.lbl_Admin_Password);
            this.gb_Delete_User.Controls.Add(this.tb_Username);
            this.gb_Delete_User.Controls.Add(this.lbl_Username);
            this.gb_Delete_User.Controls.Add(this.lbl_User_Role);
            this.gb_Delete_User.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Delete_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Delete_User.Location = new System.Drawing.Point(21, 27);
            this.gb_Delete_User.Name = "gb_Delete_User";
            this.gb_Delete_User.Size = new System.Drawing.Size(1247, 679);
            this.gb_Delete_User.TabIndex = 1;
            this.gb_Delete_User.TabStop = false;
            this.gb_Delete_User.Text = "Delete User";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(225, 511);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(243, 69);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // tb_UserRole
            // 
            this.tb_UserRole.BackColor = System.Drawing.Color.White;
            this.tb_UserRole.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UserRole.Location = new System.Drawing.Point(337, 128);
            this.tb_UserRole.MaxLength = 20;
            this.tb_UserRole.Name = "tb_UserRole";
            this.tb_UserRole.Size = new System.Drawing.Size(330, 42);
            this.tb_UserRole.TabIndex = 1;
            this.tb_UserRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // dgv_User_Details
            // 
            this.dgv_User_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_User_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_User_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_User_Details.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_User_Details.Location = new System.Drawing.Point(707, 69);
            this.dgv_User_Details.Name = "dgv_User_Details";
            this.dgv_User_Details.RowHeadersWidth = 51;
            this.dgv_User_Details.RowTemplate.Height = 24;
            this.dgv_User_Details.Size = new System.Drawing.Size(507, 496);
            this.dgv_User_Details.TabIndex = 18;
            this.dgv_User_Details.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_User_Details_CellDoubleClick);
            // 
            // tb_Admin_Password
            // 
            this.tb_Admin_Password.BackColor = System.Drawing.Color.White;
            this.tb_Admin_Password.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Admin_Password.Location = new System.Drawing.Point(337, 395);
            this.tb_Admin_Password.MaxLength = 8;
            this.tb_Admin_Password.Name = "tb_Admin_Password";
            this.tb_Admin_Password.Size = new System.Drawing.Size(330, 42);
            this.tb_Admin_Password.TabIndex = 3;
            this.tb_Admin_Password.TextChanged += new System.EventHandler(this.tb_Admin_Password_TextChanged);
            // 
            // lbl_Admin_Password
            // 
            this.lbl_Admin_Password.AutoSize = true;
            this.lbl_Admin_Password.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Admin_Password.ForeColor = System.Drawing.Color.Black;
            this.lbl_Admin_Password.Location = new System.Drawing.Point(34, 397);
            this.lbl_Admin_Password.Name = "lbl_Admin_Password";
            this.lbl_Admin_Password.Size = new System.Drawing.Size(245, 35);
            this.lbl_Admin_Password.TabIndex = 17;
            this.lbl_Admin_Password.Text = "Admin  Password";
            // 
            // tb_Username
            // 
            this.tb_Username.BackColor = System.Drawing.Color.White;
            this.tb_Username.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(337, 261);
            this.tb_Username.MaxLength = 20;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(330, 42);
            this.tb_Username.TabIndex = 2;
            this.tb_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Black;
            this.lbl_Username.Location = new System.Drawing.Point(34, 263);
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
            this.lbl_User_Role.Location = new System.Drawing.Point(34, 126);
            this.lbl_User_Role.Name = "lbl_User_Role";
            this.lbl_User_Role.Size = new System.Drawing.Size(146, 35);
            this.lbl_User_Role.TabIndex = 4;
            this.lbl_User_Role.Text = "User Role";
            // 
            // frm_Delete_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1280, 718);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Delete_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Delete_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete User";
            this.Load += new System.EventHandler(this.frm_Delete_User_Load);
            this.gb_Delete_User.ResumeLayout(false);
            this.gb_Delete_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Delete_User;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox tb_Admin_Password;
        private System.Windows.Forms.Label lbl_Admin_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_User_Role;
        private System.Windows.Forms.DataGridView dgv_User_Details;
        private System.Windows.Forms.TextBox tb_UserRole;
    }
}