
namespace AgriSmart_Solutions.WindowsForm.Stock
{
    partial class frm_Expiry_Stock_Details
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
            this.dgv_Expiry_Details = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_Id_Product_Type = new System.Windows.Forms.GroupBox();
            this.cmb_Packing = new System.Windows.Forms.ComboBox();
            this.cmb_Unit = new System.Windows.Forms.ComboBox();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.lbl_Packing = new System.Windows.Forms.Label();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Product_Type = new System.Windows.Forms.ComboBox();
            this.lbl_Product_Type = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expiry_Details)).BeginInit();
            this.panel1.SuspendLayout();
            this.gb_Id_Product_Type.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Expiry_Details
            // 
            this.dgv_Expiry_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Expiry_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Expiry_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Expiry_Details.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Expiry_Details.Location = new System.Drawing.Point(13, 23);
            this.dgv_Expiry_Details.Name = "dgv_Expiry_Details";
            this.dgv_Expiry_Details.RowHeadersWidth = 51;
            this.dgv_Expiry_Details.RowTemplate.Height = 24;
            this.dgv_Expiry_Details.Size = new System.Drawing.Size(1229, 478);
            this.dgv_Expiry_Details.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.dgv_Expiry_Details);
            this.panel1.Location = new System.Drawing.Point(12, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 525);
            this.panel1.TabIndex = 1;
            // 
            // gb_Id_Product_Type
            // 
            this.gb_Id_Product_Type.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Id_Product_Type.Controls.Add(this.cmb_Packing);
            this.gb_Id_Product_Type.Controls.Add(this.cmb_Unit);
            this.gb_Id_Product_Type.Controls.Add(this.lbl_Weight);
            this.gb_Id_Product_Type.Controls.Add(this.lbl_Packing);
            this.gb_Id_Product_Type.Controls.Add(this.cmb_Product_Name);
            this.gb_Id_Product_Type.Controls.Add(this.cmb_Product_Type);
            this.gb_Id_Product_Type.Controls.Add(this.lbl_Product_Type);
            this.gb_Id_Product_Type.Controls.Add(this.lbl_Product_Name);
            this.gb_Id_Product_Type.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Id_Product_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Id_Product_Type.Location = new System.Drawing.Point(12, 25);
            this.gb_Id_Product_Type.Name = "gb_Id_Product_Type";
            this.gb_Id_Product_Type.Size = new System.Drawing.Size(1256, 138);
            this.gb_Id_Product_Type.TabIndex = 38;
            this.gb_Id_Product_Type.TabStop = false;
            this.gb_Id_Product_Type.Text = "Id  and Product Type";
            // 
            // cmb_Packing
            // 
            this.cmb_Packing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Packing.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Packing.FormattingEnabled = true;
            this.cmb_Packing.Location = new System.Drawing.Point(826, 76);
            this.cmb_Packing.Name = "cmb_Packing";
            this.cmb_Packing.Size = new System.Drawing.Size(135, 39);
            this.cmb_Packing.TabIndex = 57;
            this.cmb_Packing.SelectedIndexChanged += new System.EventHandler(this.cmb_Packing_SelectedIndexChanged);
            // 
            // cmb_Unit
            // 
            this.cmb_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Unit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Unit.FormattingEnabled = true;
            this.cmb_Unit.IntegralHeight = false;
            this.cmb_Unit.Items.AddRange(new object[] {
            "Kg",
            "Gm",
            "Ltr",
            "ML",
            "Qty"});
            this.cmb_Unit.Location = new System.Drawing.Point(994, 76);
            this.cmb_Unit.MaxLength = 50;
            this.cmb_Unit.Name = "cmb_Unit";
            this.cmb_Unit.Size = new System.Drawing.Size(130, 39);
            this.cmb_Unit.TabIndex = 56;
            this.cmb_Unit.SelectedIndexChanged += new System.EventHandler(this.cmb_Unit_SelectedIndexChanged);
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Weight.ForeColor = System.Drawing.Color.Black;
            this.lbl_Weight.Location = new System.Drawing.Point(957, 44);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(86, 23);
            this.lbl_Weight.TabIndex = 59;
            this.lbl_Weight.Text = "(Weight)";
            // 
            // lbl_Packing
            // 
            this.lbl_Packing.AutoSize = true;
            this.lbl_Packing.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Packing.ForeColor = System.Drawing.Color.Black;
            this.lbl_Packing.Location = new System.Drawing.Point(838, 35);
            this.lbl_Packing.Name = "lbl_Packing";
            this.lbl_Packing.Size = new System.Drawing.Size(113, 32);
            this.lbl_Packing.TabIndex = 58;
            this.lbl_Packing.Text = "Packing";
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(436, 76);
            this.cmb_Product_Name.MaxLength = 50;
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(335, 39);
            this.cmb_Product_Name.TabIndex = 32;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
            // 
            // cmb_Product_Type
            // 
            this.cmb_Product_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Type.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Type.FormattingEnabled = true;
            this.cmb_Product_Type.Location = new System.Drawing.Point(23, 76);
            this.cmb_Product_Type.MaxLength = 30;
            this.cmb_Product_Type.Name = "cmb_Product_Type";
            this.cmb_Product_Type.Size = new System.Drawing.Size(335, 39);
            this.cmb_Product_Type.TabIndex = 30;
            this.cmb_Product_Type.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Type_SelectedIndexChanged);
            // 
            // lbl_Product_Type
            // 
            this.lbl_Product_Type.AutoSize = true;
            this.lbl_Product_Type.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Type.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product_Type.Location = new System.Drawing.Point(87, 41);
            this.lbl_Product_Type.Name = "lbl_Product_Type";
            this.lbl_Product_Type.Size = new System.Drawing.Size(182, 32);
            this.lbl_Product_Type.TabIndex = 31;
            this.lbl_Product_Type.Text = "Product Type";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product_Name.Location = new System.Drawing.Point(486, 41);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(195, 32);
            this.lbl_Product_Name.TabIndex = 33;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // frm_Expiry_Stock_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1280, 718);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Id_Product_Type);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Expiry_Stock_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expiry Stock Details";
            this.Load += new System.EventHandler(this.frm_Expiry_Stock_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expiry_Details)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gb_Id_Product_Type.ResumeLayout(false);
            this.gb_Id_Product_Type.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Expiry_Details;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb_Id_Product_Type;
        private System.Windows.Forms.ComboBox cmb_Packing;
        private System.Windows.Forms.ComboBox cmb_Unit;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.Label lbl_Packing;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Product_Type;
        private System.Windows.Forms.Label lbl_Product_Type;
        private System.Windows.Forms.Label lbl_Product_Name;
    }
}