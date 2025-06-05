
namespace AgriSmart_Solutions.WindowsForm.Supplier
{
    partial class frm_Supplier_Payment_List
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
            this.gb_Supplier_List = new System.Windows.Forms.GroupBox();
            this.cmb_SearchByYear = new System.Windows.Forms.ComboBox();
            this.cmb_SearchByMonth = new System.Windows.Forms.ComboBox();
            this.lbl_Search_Supplier_Payment = new System.Windows.Forms.Label();
            this.dgv_Supplier_Payment_Details = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Supplier_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier_Payment_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Supplier_List
            // 
            this.gb_Supplier_List.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Supplier_List.Controls.Add(this.cmb_SearchByYear);
            this.gb_Supplier_List.Controls.Add(this.cmb_SearchByMonth);
            this.gb_Supplier_List.Controls.Add(this.lbl_Search_Supplier_Payment);
            this.gb_Supplier_List.Controls.Add(this.dgv_Supplier_Payment_Details);
            this.gb_Supplier_List.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Supplier_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Supplier_List.Location = new System.Drawing.Point(12, 28);
            this.gb_Supplier_List.Name = "gb_Supplier_List";
            this.gb_Supplier_List.Size = new System.Drawing.Size(1256, 617);
            this.gb_Supplier_List.TabIndex = 25;
            this.gb_Supplier_List.TabStop = false;
            this.gb_Supplier_List.Text = "Supplier List";
            // 
            // cmb_SearchByYear
            // 
            this.cmb_SearchByYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchByYear.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SearchByYear.FormattingEnabled = true;
            this.cmb_SearchByYear.Items.AddRange(new object[] {
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.cmb_SearchByYear.Location = new System.Drawing.Point(830, 44);
            this.cmb_SearchByYear.Name = "cmb_SearchByYear";
            this.cmb_SearchByYear.Size = new System.Drawing.Size(296, 39);
            this.cmb_SearchByYear.TabIndex = 39;
            this.cmb_SearchByYear.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchByYear_SelectedIndexChanged);
            // 
            // cmb_SearchByMonth
            // 
            this.cmb_SearchByMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchByMonth.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SearchByMonth.FormattingEnabled = true;
            this.cmb_SearchByMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmb_SearchByMonth.Location = new System.Drawing.Point(478, 47);
            this.cmb_SearchByMonth.Name = "cmb_SearchByMonth";
            this.cmb_SearchByMonth.Size = new System.Drawing.Size(296, 39);
            this.cmb_SearchByMonth.TabIndex = 38;
            this.cmb_SearchByMonth.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchByMonth_SelectedIndexChanged);
            // 
            // lbl_Search_Supplier_Payment
            // 
            this.lbl_Search_Supplier_Payment.AutoSize = true;
            this.lbl_Search_Supplier_Payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Search_Supplier_Payment.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Supplier_Payment.ForeColor = System.Drawing.Color.Black;
            this.lbl_Search_Supplier_Payment.Location = new System.Drawing.Point(24, 51);
            this.lbl_Search_Supplier_Payment.Name = "lbl_Search_Supplier_Payment";
            this.lbl_Search_Supplier_Payment.Size = new System.Drawing.Size(351, 35);
            this.lbl_Search_Supplier_Payment.TabIndex = 33;
            this.lbl_Search_Supplier_Payment.Text = "Search Supplier Payment";
            // 
            // dgv_Supplier_Payment_Details
            // 
            this.dgv_Supplier_Payment_Details.AllowUserToAddRows = false;
            this.dgv_Supplier_Payment_Details.AllowUserToDeleteRows = false;
            this.dgv_Supplier_Payment_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Supplier_Payment_Details.Location = new System.Drawing.Point(16, 120);
            this.dgv_Supplier_Payment_Details.Name = "dgv_Supplier_Payment_Details";
            this.dgv_Supplier_Payment_Details.ReadOnly = true;
            this.dgv_Supplier_Payment_Details.RowHeadersWidth = 51;
            this.dgv_Supplier_Payment_Details.RowTemplate.Height = 24;
            this.dgv_Supplier_Payment_Details.Size = new System.Drawing.Size(1225, 482);
            this.dgv_Supplier_Payment_Details.TabIndex = 32;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(518, 651);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(243, 59);
            this.btn_Refresh.TabIndex = 37;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Supplier_Payment_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1286, 718);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Supplier_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Supplier_Payment_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Payment List";
            this.Load += new System.EventHandler(this.frm_Supplier_Payment_List_Load);
            this.gb_Supplier_List.ResumeLayout(false);
            this.gb_Supplier_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier_Payment_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Supplier_List;
        private System.Windows.Forms.ComboBox cmb_SearchByYear;
        private System.Windows.Forms.ComboBox cmb_SearchByMonth;
        private System.Windows.Forms.Label lbl_Search_Supplier_Payment;
        private System.Windows.Forms.DataGridView dgv_Supplier_Payment_Details;
        private System.Windows.Forms.Button btn_Refresh;
    }
}