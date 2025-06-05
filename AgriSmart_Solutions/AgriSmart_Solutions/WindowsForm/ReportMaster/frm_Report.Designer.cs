
namespace AgriSmart_Solutions.WindowsForm.ReportMaster
{
    partial class frm_Report
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
            this.btn_Customer_Bills_Datewise_Report = new System.Windows.Forms.Button();
            this.btn_Expence_Datewise_Report = new System.Windows.Forms.Button();
            this.btn_Monthly_Stock_Updates_Report = new System.Windows.Forms.Button();
            this.btn_Product_List_Report = new System.Windows.Forms.Button();
            this.lbl_Report_Master = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Customer_Bills_Datewise_Report
            // 
            this.btn_Customer_Bills_Datewise_Report.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Customer_Bills_Datewise_Report.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer_Bills_Datewise_Report.Location = new System.Drawing.Point(316, 168);
            this.btn_Customer_Bills_Datewise_Report.Name = "btn_Customer_Bills_Datewise_Report";
            this.btn_Customer_Bills_Datewise_Report.Size = new System.Drawing.Size(711, 55);
            this.btn_Customer_Bills_Datewise_Report.TabIndex = 0;
            this.btn_Customer_Bills_Datewise_Report.Text = "Customer Bills Datewise Report";
            this.btn_Customer_Bills_Datewise_Report.UseVisualStyleBackColor = false;
            this.btn_Customer_Bills_Datewise_Report.Click += new System.EventHandler(this.btn_Customer_Bills_Datewise_Report_Click);
            // 
            // btn_Expence_Datewise_Report
            // 
            this.btn_Expence_Datewise_Report.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Expence_Datewise_Report.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Expence_Datewise_Report.Location = new System.Drawing.Point(316, 299);
            this.btn_Expence_Datewise_Report.Name = "btn_Expence_Datewise_Report";
            this.btn_Expence_Datewise_Report.Size = new System.Drawing.Size(711, 55);
            this.btn_Expence_Datewise_Report.TabIndex = 1;
            this.btn_Expence_Datewise_Report.Text = "Expence Datewise Report";
            this.btn_Expence_Datewise_Report.UseVisualStyleBackColor = false;
            this.btn_Expence_Datewise_Report.Click += new System.EventHandler(this.btn_Expence_Datewise_Report_Click);
            // 
            // btn_Monthly_Stock_Updates_Report
            // 
            this.btn_Monthly_Stock_Updates_Report.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Monthly_Stock_Updates_Report.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Monthly_Stock_Updates_Report.Location = new System.Drawing.Point(307, 434);
            this.btn_Monthly_Stock_Updates_Report.Name = "btn_Monthly_Stock_Updates_Report";
            this.btn_Monthly_Stock_Updates_Report.Size = new System.Drawing.Size(711, 55);
            this.btn_Monthly_Stock_Updates_Report.TabIndex = 2;
            this.btn_Monthly_Stock_Updates_Report.Text = "Monthly Stock Updates Report";
            this.btn_Monthly_Stock_Updates_Report.UseVisualStyleBackColor = false;
            this.btn_Monthly_Stock_Updates_Report.Click += new System.EventHandler(this.btn_Monthly_Stock_Updates_Report_Click);
            // 
            // btn_Product_List_Report
            // 
            this.btn_Product_List_Report.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Product_List_Report.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product_List_Report.Location = new System.Drawing.Point(307, 558);
            this.btn_Product_List_Report.Name = "btn_Product_List_Report";
            this.btn_Product_List_Report.Size = new System.Drawing.Size(711, 55);
            this.btn_Product_List_Report.TabIndex = 3;
            this.btn_Product_List_Report.Text = "Product List Report";
            this.btn_Product_List_Report.UseVisualStyleBackColor = false;
            this.btn_Product_List_Report.Click += new System.EventHandler(this.btn_Product_List_Report_Click);
            // 
            // lbl_Report_Master
            // 
            this.lbl_Report_Master.AutoSize = true;
            this.lbl_Report_Master.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Report_Master.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_Report_Master.Location = new System.Drawing.Point(424, 44);
            this.lbl_Report_Master.Name = "lbl_Report_Master";
            this.lbl_Report_Master.Size = new System.Drawing.Size(476, 69);
            this.lbl_Report_Master.TabIndex = 4;
            this.lbl_Report_Master.Text = "Report Master";
            // 
            // frm_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1280, 718);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Report_Master);
            this.Controls.Add(this.btn_Product_List_Report);
            this.Controls.Add(this.btn_Monthly_Stock_Updates_Report);
            this.Controls.Add(this.btn_Expence_Datewise_Report);
            this.Controls.Add(this.btn_Customer_Bills_Datewise_Report);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Customer_Bills_Datewise_Report;
        private System.Windows.Forms.Button btn_Expence_Datewise_Report;
        private System.Windows.Forms.Button btn_Monthly_Stock_Updates_Report;
        private System.Windows.Forms.Button btn_Product_List_Report;
        private System.Windows.Forms.Label lbl_Report_Master;
    }
}