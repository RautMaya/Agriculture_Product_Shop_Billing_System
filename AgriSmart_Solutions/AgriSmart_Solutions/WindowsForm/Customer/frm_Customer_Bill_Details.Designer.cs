
namespace AgriSmart_Solutions.WindowsForm.Customer
{
    partial class frm_Customer_Bill_Details
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.dgv_Customer_Bill_Details = new System.Windows.Forms.DataGridView();
            this.cmb_Month = new System.Windows.Forms.ComboBox();
            this.lbl_Search_Customer_Bill = new System.Windows.Forms.Label();
            this.gb_Customer_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Bill_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Customer_Details
            // 
            this.gb_Customer_Details.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Customer_Details.Controls.Add(this.btn_Refresh);
            this.gb_Customer_Details.Controls.Add(this.cmb_Year);
            this.gb_Customer_Details.Controls.Add(this.dgv_Customer_Bill_Details);
            this.gb_Customer_Details.Controls.Add(this.cmb_Month);
            this.gb_Customer_Details.Controls.Add(this.lbl_Search_Customer_Bill);
            this.gb_Customer_Details.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Customer_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Customer_Details.Location = new System.Drawing.Point(12, 12);
            this.gb_Customer_Details.Name = "gb_Customer_Details";
            this.gb_Customer_Details.Size = new System.Drawing.Size(1256, 694);
            this.gb_Customer_Details.TabIndex = 23;
            this.gb_Customer_Details.TabStop = false;
            this.gb_Customer_Details.Text = "Customer Details";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1037, 38);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(198, 65);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cmb_Year
            // 
            this.cmb_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Year.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Year.FormattingEnabled = true;
            this.cmb_Year.Location = new System.Drawing.Point(709, 49);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(296, 43);
            this.cmb_Year.TabIndex = 3;
            // 
            // dgv_Customer_Bill_Details
            // 
            this.dgv_Customer_Bill_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Customer_Bill_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer_Bill_Details.Location = new System.Drawing.Point(35, 163);
            this.dgv_Customer_Bill_Details.Name = "dgv_Customer_Bill_Details";
            this.dgv_Customer_Bill_Details.RowHeadersWidth = 51;
            this.dgv_Customer_Bill_Details.RowTemplate.Height = 24;
            this.dgv_Customer_Bill_Details.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgv_Customer_Bill_Details.Size = new System.Drawing.Size(1179, 469);
            this.dgv_Customer_Bill_Details.TabIndex = 4;
            // 
            // cmb_Month
            // 
            this.cmb_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Month.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Month.FormattingEnabled = true;
            this.cmb_Month.Location = new System.Drawing.Point(349, 51);
            this.cmb_Month.Name = "cmb_Month";
            this.cmb_Month.Size = new System.Drawing.Size(296, 43);
            this.cmb_Month.TabIndex = 2;
            // 
            // lbl_Search_Customer_Bill
            // 
            this.lbl_Search_Customer_Bill.AutoSize = true;
            this.lbl_Search_Customer_Bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Search_Customer_Bill.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Customer_Bill.ForeColor = System.Drawing.Color.Black;
            this.lbl_Search_Customer_Bill.Location = new System.Drawing.Point(20, 53);
            this.lbl_Search_Customer_Bill.Name = "lbl_Search_Customer_Bill";
            this.lbl_Search_Customer_Bill.Size = new System.Drawing.Size(296, 35);
            this.lbl_Search_Customer_Bill.TabIndex = 4;
            this.lbl_Search_Customer_Bill.Text = "Search Customer Bill";
            // 
            // frm_Customer_Bill_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1280, 718);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Customer_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Customer_Bill_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Bill Details";
            this.Load += new System.EventHandler(this.frm_Customer_Bill_Details_Load);
            this.gb_Customer_Details.ResumeLayout(false);
            this.gb_Customer_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Bill_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Customer_Details;
        private System.Windows.Forms.DataGridView dgv_Customer_Bill_Details;
        private System.Windows.Forms.ComboBox cmb_Month;
        private System.Windows.Forms.Label lbl_Search_Customer_Bill;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.Button btn_Refresh;
    }
}