
namespace AgriSmart_Solutions.WindowsForm.Expence
{
    partial class frm_Shop_Expence_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_Shop_Expence_Details = new System.Windows.Forms.GroupBox();
            this.cmb_SearchByYear = new System.Windows.Forms.ComboBox();
            this.cmb_SearchByMonth = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dgv_Expence_Details = new System.Windows.Forms.DataGridView();
            this.lbl_Search_Shop_Expence = new System.Windows.Forms.Label();
            this.gb_Shop_Expence_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expence_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Shop_Expence_Details
            // 
            this.gb_Shop_Expence_Details.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Shop_Expence_Details.Controls.Add(this.cmb_SearchByYear);
            this.gb_Shop_Expence_Details.Controls.Add(this.cmb_SearchByMonth);
            this.gb_Shop_Expence_Details.Controls.Add(this.btn_Refresh);
            this.gb_Shop_Expence_Details.Controls.Add(this.dgv_Expence_Details);
            this.gb_Shop_Expence_Details.Controls.Add(this.lbl_Search_Shop_Expence);
            this.gb_Shop_Expence_Details.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Shop_Expence_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Shop_Expence_Details.Location = new System.Drawing.Point(15, 24);
            this.gb_Shop_Expence_Details.Name = "gb_Shop_Expence_Details";
            this.gb_Shop_Expence_Details.Size = new System.Drawing.Size(1256, 670);
            this.gb_Shop_Expence_Details.TabIndex = 24;
            this.gb_Shop_Expence_Details.TabStop = false;
            this.gb_Shop_Expence_Details.Text = "Shop Expence Details";
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
            this.cmb_SearchByYear.Location = new System.Drawing.Point(720, 57);
            this.cmb_SearchByYear.Name = "cmb_SearchByYear";
            this.cmb_SearchByYear.Size = new System.Drawing.Size(296, 39);
            this.cmb_SearchByYear.TabIndex = 37;
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
            this.cmb_SearchByMonth.Location = new System.Drawing.Point(368, 60);
            this.cmb_SearchByMonth.Name = "cmb_SearchByMonth";
            this.cmb_SearchByMonth.Size = new System.Drawing.Size(296, 39);
            this.cmb_SearchByMonth.TabIndex = 36;
            this.cmb_SearchByMonth.SelectedIndexChanged += new System.EventHandler(this.cmb_Month_SelectedIndexChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1033, 43);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(201, 67);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // dgv_Expence_Details
            // 
            this.dgv_Expence_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Expence_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Expence_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Expence_Details.Location = new System.Drawing.Point(35, 163);
            this.dgv_Expence_Details.Name = "dgv_Expence_Details";
            this.dgv_Expence_Details.RowHeadersWidth = 51;
            this.dgv_Expence_Details.RowTemplate.Height = 24;
            this.dgv_Expence_Details.Size = new System.Drawing.Size(1179, 469);
            this.dgv_Expence_Details.TabIndex = 4;
            // 
            // lbl_Search_Shop_Expence
            // 
            this.lbl_Search_Shop_Expence.AutoSize = true;
            this.lbl_Search_Shop_Expence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Search_Shop_Expence.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Shop_Expence.ForeColor = System.Drawing.Color.Black;
            this.lbl_Search_Shop_Expence.Location = new System.Drawing.Point(6, 61);
            this.lbl_Search_Shop_Expence.Name = "lbl_Search_Shop_Expence";
            this.lbl_Search_Shop_Expence.Size = new System.Drawing.Size(335, 38);
            this.lbl_Search_Shop_Expence.TabIndex = 4;
            this.lbl_Search_Shop_Expence.Text = "Search Shop Expence";
            // 
            // frm_Shop_Expence_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1286, 718);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Shop_Expence_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Shop_Expence_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shop Expence Details";
            this.Load += new System.EventHandler(this.frm_Shop_Expence_Details_Load);
            this.gb_Shop_Expence_Details.ResumeLayout(false);
            this.gb_Shop_Expence_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expence_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Shop_Expence_Details;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_Expence_Details;
        private System.Windows.Forms.Label lbl_Search_Shop_Expence;
        private System.Windows.Forms.ComboBox cmb_SearchByYear;
        private System.Windows.Forms.ComboBox cmb_SearchByMonth;
    }
}