
namespace AgriSmart_Solutions.Headers
{
    partial class UC_Staff
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
            this.btn_Staff_List = new System.Windows.Forms.Button();
            this.btn_Update_Staff = new System.Windows.Forms.Button();
            this.btn_Add_Staff = new System.Windows.Forms.Button();
            this.lbl_Staff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Staff_List
            // 
            this.btn_Staff_List.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Staff_List.FlatAppearance.BorderSize = 0;
            this.btn_Staff_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Staff_List.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff_List.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Staff_List.Location = new System.Drawing.Point(909, 71);
            this.btn_Staff_List.Name = "btn_Staff_List";
            this.btn_Staff_List.Size = new System.Drawing.Size(294, 45);
            this.btn_Staff_List.TabIndex = 18;
            this.btn_Staff_List.Text = "Staff List";
            this.btn_Staff_List.UseVisualStyleBackColor = false;
            this.btn_Staff_List.Click += new System.EventHandler(this.btn_Staff_List_Click);
            // 
            // btn_Update_Staff
            // 
            this.btn_Update_Staff.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Update_Staff.FlatAppearance.BorderSize = 0;
            this.btn_Update_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update_Staff.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Staff.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Update_Staff.Location = new System.Drawing.Point(501, 71);
            this.btn_Update_Staff.Name = "btn_Update_Staff";
            this.btn_Update_Staff.Size = new System.Drawing.Size(294, 45);
            this.btn_Update_Staff.TabIndex = 17;
            this.btn_Update_Staff.Text = "Update / Delete Staff";
            this.btn_Update_Staff.UseVisualStyleBackColor = false;
            this.btn_Update_Staff.Click += new System.EventHandler(this.btn_Update_Staff_Click);
            // 
            // btn_Add_Staff
            // 
            this.btn_Add_Staff.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Add_Staff.FlatAppearance.BorderSize = 0;
            this.btn_Add_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Staff.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Staff.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Add_Staff.Location = new System.Drawing.Point(77, 71);
            this.btn_Add_Staff.Name = "btn_Add_Staff";
            this.btn_Add_Staff.Size = new System.Drawing.Size(348, 45);
            this.btn_Add_Staff.TabIndex = 16;
            this.btn_Add_Staff.Text = "Add Staff";
            this.btn_Add_Staff.UseVisualStyleBackColor = false;
            this.btn_Add_Staff.Click += new System.EventHandler(this.btn_Add_Staff_Click);
            // 
            // lbl_Staff
            // 
            this.lbl_Staff.AutoSize = true;
            this.lbl_Staff.BackColor = System.Drawing.Color.YellowGreen;
            this.lbl_Staff.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff.Location = new System.Drawing.Point(580, 12);
            this.lbl_Staff.Name = "lbl_Staff";
            this.lbl_Staff.Size = new System.Drawing.Size(141, 56);
            this.lbl_Staff.TabIndex = 15;
            this.lbl_Staff.Text = "Staff";
            // 
            // UC_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.btn_Staff_List);
            this.Controls.Add(this.btn_Update_Staff);
            this.Controls.Add(this.btn_Add_Staff);
            this.Controls.Add(this.lbl_Staff);
            this.Name = "UC_Staff";
            this.Size = new System.Drawing.Size(1291, 129);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Staff_List;
        private System.Windows.Forms.Button btn_Update_Staff;
        private System.Windows.Forms.Button btn_Add_Staff;
        private System.Windows.Forms.Label lbl_Staff;
    }
}
