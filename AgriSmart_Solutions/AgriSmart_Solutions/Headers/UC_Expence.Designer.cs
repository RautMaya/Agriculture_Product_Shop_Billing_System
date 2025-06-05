
namespace AgriSmart_Solutions.Headers
{
    partial class UC_Expence
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
            this.btn_Shop_Expence_Details = new System.Windows.Forms.Button();
            this.btn_Shop_Expence = new System.Windows.Forms.Button();
            this.lbl_Expence = new System.Windows.Forms.Label();
            this.btn_Show_Payment_Receipt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Shop_Expence_Details
            // 
            this.btn_Shop_Expence_Details.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Shop_Expence_Details.FlatAppearance.BorderSize = 0;
            this.btn_Shop_Expence_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Shop_Expence_Details.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shop_Expence_Details.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Shop_Expence_Details.Location = new System.Drawing.Point(443, 71);
            this.btn_Shop_Expence_Details.Name = "btn_Shop_Expence_Details";
            this.btn_Shop_Expence_Details.Size = new System.Drawing.Size(366, 45);
            this.btn_Shop_Expence_Details.TabIndex = 28;
            this.btn_Shop_Expence_Details.Text = "Shop Expence Details";
            this.btn_Shop_Expence_Details.UseVisualStyleBackColor = false;
            this.btn_Shop_Expence_Details.Click += new System.EventHandler(this.btn_Shop_Expence_Details_Click);
            // 
            // btn_Shop_Expence
            // 
            this.btn_Shop_Expence.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Shop_Expence.FlatAppearance.BorderSize = 0;
            this.btn_Shop_Expence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Shop_Expence.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shop_Expence.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Shop_Expence.Location = new System.Drawing.Point(28, 71);
            this.btn_Shop_Expence.Name = "btn_Shop_Expence";
            this.btn_Shop_Expence.Size = new System.Drawing.Size(281, 45);
            this.btn_Shop_Expence.TabIndex = 25;
            this.btn_Shop_Expence.Text = "Shop Expence";
            this.btn_Shop_Expence.UseVisualStyleBackColor = false;
            this.btn_Shop_Expence.Click += new System.EventHandler(this.btn_Shop_Expence_Click);
            // 
            // lbl_Expence
            // 
            this.lbl_Expence.AutoSize = true;
            this.lbl_Expence.BackColor = System.Drawing.Color.YellowGreen;
            this.lbl_Expence.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expence.Location = new System.Drawing.Point(519, 12);
            this.lbl_Expence.Name = "lbl_Expence";
            this.lbl_Expence.Size = new System.Drawing.Size(232, 56);
            this.lbl_Expence.TabIndex = 24;
            this.lbl_Expence.Text = "Expence";
            // 
            // btn_Show_Payment_Receipt
            // 
            this.btn_Show_Payment_Receipt.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Show_Payment_Receipt.FlatAppearance.BorderSize = 0;
            this.btn_Show_Payment_Receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Show_Payment_Receipt.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Payment_Receipt.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Show_Payment_Receipt.Location = new System.Drawing.Point(815, 71);
            this.btn_Show_Payment_Receipt.Name = "btn_Show_Payment_Receipt";
            this.btn_Show_Payment_Receipt.Size = new System.Drawing.Size(426, 45);
            this.btn_Show_Payment_Receipt.TabIndex = 29;
            this.btn_Show_Payment_Receipt.Text = "Show Payment Receipt";
            this.btn_Show_Payment_Receipt.UseVisualStyleBackColor = false;
            this.btn_Show_Payment_Receipt.Click += new System.EventHandler(this.btn_Show_Payment_Receipt_Click);
            // 
            // UC_Expence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.btn_Show_Payment_Receipt);
            this.Controls.Add(this.btn_Shop_Expence_Details);
            this.Controls.Add(this.btn_Shop_Expence);
            this.Controls.Add(this.lbl_Expence);
            this.Name = "UC_Expence";
            this.Size = new System.Drawing.Size(1291, 129);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Shop_Expence_Details;
        private System.Windows.Forms.Button btn_Shop_Expence;
        private System.Windows.Forms.Label lbl_Expence;
        private System.Windows.Forms.Button btn_Show_Payment_Receipt;
    }
}
