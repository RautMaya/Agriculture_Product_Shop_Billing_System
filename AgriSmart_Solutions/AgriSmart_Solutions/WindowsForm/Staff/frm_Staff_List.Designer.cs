
namespace AgriSmart_Solutions.WindowsForm.Staff
{
    partial class frm_Staff_List
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
            this.gb_Send_Order_List = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_Designation = new System.Windows.Forms.ComboBox();
            this.dgv_Staff_Details = new System.Windows.Forms.DataGridView();
            this.lbl_Search_Staff = new System.Windows.Forms.Label();
            this.gb_Send_Order_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Send_Order_List
            // 
            this.gb_Send_Order_List.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Send_Order_List.Controls.Add(this.button1);
            this.gb_Send_Order_List.Controls.Add(this.cmb_Designation);
            this.gb_Send_Order_List.Controls.Add(this.dgv_Staff_Details);
            this.gb_Send_Order_List.Controls.Add(this.lbl_Search_Staff);
            this.gb_Send_Order_List.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Send_Order_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Send_Order_List.Location = new System.Drawing.Point(9, 24);
            this.gb_Send_Order_List.Name = "gb_Send_Order_List";
            this.gb_Send_Order_List.Size = new System.Drawing.Size(1272, 670);
            this.gb_Send_Order_List.TabIndex = 25;
            this.gb_Send_Order_List.TabStop = false;
            this.gb_Send_Order_List.Text = "Send Order List";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(960, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 59);
            this.button1.TabIndex = 33;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cmb_Designation
            // 
            this.cmb_Designation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Designation.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Designation.FormattingEnabled = true;
            this.cmb_Designation.Location = new System.Drawing.Point(462, 61);
            this.cmb_Designation.MaxLength = 8;
            this.cmb_Designation.Name = "cmb_Designation";
            this.cmb_Designation.Size = new System.Drawing.Size(296, 39);
            this.cmb_Designation.TabIndex = 34;
            this.cmb_Designation.SelectedIndexChanged += new System.EventHandler(this.cmb_Designation_SelectedIndexChanged);
            // 
            // dgv_Staff_Details
            // 
            this.dgv_Staff_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Staff_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Staff_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Staff_Details.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Staff_Details.Location = new System.Drawing.Point(6, 142);
            this.dgv_Staff_Details.Name = "dgv_Staff_Details";
            this.dgv_Staff_Details.RowHeadersWidth = 51;
            this.dgv_Staff_Details.RowTemplate.Height = 24;
            this.dgv_Staff_Details.Size = new System.Drawing.Size(1259, 489);
            this.dgv_Staff_Details.TabIndex = 4;
            // 
            // lbl_Search_Staff
            // 
            this.lbl_Search_Staff.AutoSize = true;
            this.lbl_Search_Staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Search_Staff.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Staff.ForeColor = System.Drawing.Color.Black;
            this.lbl_Search_Staff.Location = new System.Drawing.Point(51, 61);
            this.lbl_Search_Staff.Name = "lbl_Search_Staff";
            this.lbl_Search_Staff.Size = new System.Drawing.Size(342, 35);
            this.lbl_Search_Staff.TabIndex = 4;
            this.lbl_Search_Staff.Text = "Search Staff Designation";
            // 
            // frm_Staff_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1286, 718);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Send_Order_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Staff_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Staff_List";
            this.Load += new System.EventHandler(this.frm_Staff_List_Load);
            this.gb_Send_Order_List.ResumeLayout(false);
            this.gb_Send_Order_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Send_Order_List;
        private System.Windows.Forms.DataGridView dgv_Staff_Details;
        private System.Windows.Forms.Label lbl_Search_Staff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_Designation;
    }
}