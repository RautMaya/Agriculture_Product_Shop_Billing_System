
namespace AgriSmart_Solutions.Headers
{
    partial class UC_User_Management
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Delete_User = new System.Windows.Forms.Button();
            this.btn_Update_User = new System.Windows.Forms.Button();
            this.btn_Add_User = new System.Windows.Forms.Button();
            this.lbl_User_Management = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Delete_User
            // 
            this.btn_Delete_User.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Delete_User.FlatAppearance.BorderSize = 0;
            this.btn_Delete_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete_User.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_User.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Delete_User.Location = new System.Drawing.Point(914, 71);
            this.btn_Delete_User.Name = "btn_Delete_User";
            this.btn_Delete_User.Size = new System.Drawing.Size(294, 45);
            this.btn_Delete_User.TabIndex = 18;
            this.btn_Delete_User.Text = "Delete User ";
            this.btn_Delete_User.UseVisualStyleBackColor = false;
            this.btn_Delete_User.Click += new System.EventHandler(this.btn_Delete_User_Click);
            // 
            // btn_Update_User
            // 
            this.btn_Update_User.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Update_User.FlatAppearance.BorderSize = 0;
            this.btn_Update_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update_User.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_User.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Update_User.Location = new System.Drawing.Point(485, 71);
            this.btn_Update_User.Name = "btn_Update_User";
            this.btn_Update_User.Size = new System.Drawing.Size(331, 45);
            this.btn_Update_User.TabIndex = 17;
            this.btn_Update_User.Text = "Update  User";
            this.btn_Update_User.UseVisualStyleBackColor = false;
            this.btn_Update_User.Click += new System.EventHandler(this.btn_Update_User_Click);
            // 
            // btn_Add_User
            // 
            this.btn_Add_User.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Add_User.FlatAppearance.BorderSize = 0;
            this.btn_Add_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_User.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_User.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Add_User.Location = new System.Drawing.Point(82, 71);
            this.btn_Add_User.Name = "btn_Add_User";
            this.btn_Add_User.Size = new System.Drawing.Size(348, 45);
            this.btn_Add_User.TabIndex = 16;
            this.btn_Add_User.Text = "Add User";
            this.btn_Add_User.UseVisualStyleBackColor = false;
            this.btn_Add_User.Click += new System.EventHandler(this.btn_Add_User_Click);
            // 
            // lbl_User_Management
            // 
            this.lbl_User_Management.AutoSize = true;
            this.lbl_User_Management.BackColor = System.Drawing.Color.YellowGreen;
            this.lbl_User_Management.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Management.Location = new System.Drawing.Point(429, 12);
            this.lbl_User_Management.Name = "lbl_User_Management";
            this.lbl_User_Management.Size = new System.Drawing.Size(476, 56);
            this.lbl_User_Management.TabIndex = 15;
            this.lbl_User_Management.Text = "User Management";
            // 
            // UC_User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.btn_Delete_User);
            this.Controls.Add(this.btn_Update_User);
            this.Controls.Add(this.btn_Add_User);
            this.Controls.Add(this.lbl_User_Management);
            this.Name = "UC_User_Management";
            this.Size = new System.Drawing.Size(1291, 129);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete_User;
        private System.Windows.Forms.Button btn_Update_User;
        private System.Windows.Forms.Button btn_Add_User;
        private System.Windows.Forms.Label lbl_User_Management;
    }
}
