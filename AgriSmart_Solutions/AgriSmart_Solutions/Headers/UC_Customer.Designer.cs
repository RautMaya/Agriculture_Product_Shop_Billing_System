
namespace AgriSmart_Solutions.Headers
{
    partial class UC_Customer
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
            this.btn_Customer_Bill = new System.Windows.Forms.Button();
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.btn_Customer_Details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Customer_Bill
            // 
            this.btn_Customer_Bill.BackColor = System.Drawing.Color.Teal;
            this.btn_Customer_Bill.FlatAppearance.BorderSize = 0;
            this.btn_Customer_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Customer_Bill.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer_Bill.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Customer_Bill.Location = new System.Drawing.Point(30, 71);
            this.btn_Customer_Bill.Name = "btn_Customer_Bill";
            this.btn_Customer_Bill.Size = new System.Drawing.Size(259, 45);
            this.btn_Customer_Bill.TabIndex = 21;
            this.btn_Customer_Bill.Text = "Customer Bill";
            this.btn_Customer_Bill.UseVisualStyleBackColor = false;
            this.btn_Customer_Bill.Click += new System.EventHandler(this.btn_Customer_Bill_Click);
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.AutoSize = true;
            this.lbl_Customer.BackColor = System.Drawing.Color.YellowGreen;
            this.lbl_Customer.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer.Location = new System.Drawing.Point(492, 13);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(266, 56);
            this.lbl_Customer.TabIndex = 19;
            this.lbl_Customer.Text = "Customer";
            // 
            // btn_Customer_Details
            // 
            this.btn_Customer_Details.BackColor = System.Drawing.Color.Teal;
            this.btn_Customer_Details.FlatAppearance.BorderSize = 0;
            this.btn_Customer_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Customer_Details.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer_Details.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Customer_Details.Location = new System.Drawing.Point(904, 71);
            this.btn_Customer_Details.Name = "btn_Customer_Details";
            this.btn_Customer_Details.Size = new System.Drawing.Size(294, 45);
            this.btn_Customer_Details.TabIndex = 23;
            this.btn_Customer_Details.Text = "Customer Details";
            this.btn_Customer_Details.UseVisualStyleBackColor = false;
            this.btn_Customer_Details.Click += new System.EventHandler(this.btn_Customer_Details_Click);
            // 
            // UC_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.btn_Customer_Details);
            this.Controls.Add(this.btn_Customer_Bill);
            this.Controls.Add(this.lbl_Customer);
            this.Name = "UC_Customer";
            this.Size = new System.Drawing.Size(1291, 129);
            this.Load += new System.EventHandler(this.UC_Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Customer_Bill;
        private System.Windows.Forms.Label lbl_Customer;
        private System.Windows.Forms.Button btn_Customer_Details;
    }
}
