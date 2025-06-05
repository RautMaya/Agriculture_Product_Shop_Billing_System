
namespace AgriSmart_Solutions.WindowsForm.Customer
{
    partial class frm_Customer_Details
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
            this.gb_Customer_Details = new System.Windows.Forms.GroupBox();
            this.cmb_SearchByYear = new System.Windows.Forms.ComboBox();
            this.cmb_SearchByMonth = new System.Windows.Forms.ComboBox();
            this.dgv_Customer_Details = new System.Windows.Forms.DataGridView();
            this.lbl_Search_Customer_Details = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Customer_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Customer_Details
            // 
            this.gb_Customer_Details.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Customer_Details.Controls.Add(this.cmb_SearchByYear);
            this.gb_Customer_Details.Controls.Add(this.cmb_SearchByMonth);
            this.gb_Customer_Details.Controls.Add(this.dgv_Customer_Details);
            this.gb_Customer_Details.Controls.Add(this.lbl_Search_Customer_Details);
            this.gb_Customer_Details.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Customer_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Customer_Details.Location = new System.Drawing.Point(12, 12);
            this.gb_Customer_Details.Name = "gb_Customer_Details";
            this.gb_Customer_Details.Size = new System.Drawing.Size(1256, 627);
            this.gb_Customer_Details.TabIndex = 24;
            this.gb_Customer_Details.TabStop = false;
            this.gb_Customer_Details.Text = "Customer Details";
            // 
            // cmb_SearchByYear
            // 
            this.cmb_SearchByYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchByYear.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SearchByYear.FormattingEnabled = true;
            this.cmb_SearchByYear.Items.AddRange(new object[] {
            "2024",
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
            this.cmb_SearchByYear.Location = new System.Drawing.Point(760, 49);
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
            this.cmb_SearchByMonth.Location = new System.Drawing.Point(408, 52);
            this.cmb_SearchByMonth.Name = "cmb_SearchByMonth";
            this.cmb_SearchByMonth.Size = new System.Drawing.Size(296, 39);
            this.cmb_SearchByMonth.TabIndex = 38;
            this.cmb_SearchByMonth.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchByMonth_SelectedIndexChanged);
            // 
            // dgv_Customer_Details
            // 
            this.dgv_Customer_Details.AllowUserToAddRows = false;
            this.dgv_Customer_Details.AllowUserToDeleteRows = false;
            this.dgv_Customer_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Customer_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer_Details.Location = new System.Drawing.Point(35, 134);
            this.dgv_Customer_Details.Name = "dgv_Customer_Details";
            this.dgv_Customer_Details.ReadOnly = true;
            this.dgv_Customer_Details.RowHeadersWidth = 51;
            this.dgv_Customer_Details.RowTemplate.Height = 24;
            this.dgv_Customer_Details.Size = new System.Drawing.Size(1179, 469);
            this.dgv_Customer_Details.TabIndex = 4;
            this.dgv_Customer_Details.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customer_Details_CellContentDoubleClick);
            this.dgv_Customer_Details.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customer_Details_CellDoubleClick);
            // 
            // lbl_Search_Customer_Details
            // 
            this.lbl_Search_Customer_Details.AutoSize = true;
            this.lbl_Search_Customer_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Search_Customer_Details.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Customer_Details.ForeColor = System.Drawing.Color.Black;
            this.lbl_Search_Customer_Details.Location = new System.Drawing.Point(20, 53);
            this.lbl_Search_Customer_Details.Name = "lbl_Search_Customer_Details";
            this.lbl_Search_Customer_Details.Size = new System.Drawing.Size(342, 35);
            this.lbl_Search_Customer_Details.TabIndex = 4;
            this.lbl_Search_Customer_Details.Text = "Search Customer Details";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(542, 645);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(233, 65);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Customer_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1280, 718);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Customer_Details);
            this.Controls.Add(this.btn_Refresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Customer_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Customer_Details";
            this.Load += new System.EventHandler(this.frm_Customer_Details_Load);
            this.gb_Customer_Details.ResumeLayout(false);
            this.gb_Customer_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Customer_Details;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_Customer_Details;
        private System.Windows.Forms.Label lbl_Search_Customer_Details;
        private System.Windows.Forms.ComboBox cmb_SearchByYear;
        private System.Windows.Forms.ComboBox cmb_SearchByMonth;
    }
}