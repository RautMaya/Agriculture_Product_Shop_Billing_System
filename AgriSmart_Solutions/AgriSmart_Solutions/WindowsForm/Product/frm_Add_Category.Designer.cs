
namespace AgriSmart_Solutions.WindowsForm.Product
{
    partial class frm_Add_Category
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
            this.gb_Add_Category = new System.Windows.Forms.GroupBox();
            this.dgv_Category_Details = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Product_Type = new System.Windows.Forms.TextBox();
            this.lbl_Product_Type = new System.Windows.Forms.Label();
            this.tb_Category_Id = new System.Windows.Forms.TextBox();
            this.lbl_Category_Id = new System.Windows.Forms.Label();
            this.gb_Add_Category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Add_Category
            // 
            this.gb_Add_Category.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Add_Category.Controls.Add(this.dgv_Category_Details);
            this.gb_Add_Category.Controls.Add(this.btn_Save);
            this.gb_Add_Category.Controls.Add(this.tb_Product_Type);
            this.gb_Add_Category.Controls.Add(this.lbl_Product_Type);
            this.gb_Add_Category.Controls.Add(this.tb_Category_Id);
            this.gb_Add_Category.Controls.Add(this.lbl_Category_Id);
            this.gb_Add_Category.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Add_Category.Location = new System.Drawing.Point(12, 12);
            this.gb_Add_Category.Name = "gb_Add_Category";
            this.gb_Add_Category.Size = new System.Drawing.Size(1256, 694);
            this.gb_Add_Category.TabIndex = 1;
            this.gb_Add_Category.TabStop = false;
            this.gb_Add_Category.Text = "Add Category";
            // 
            // dgv_Category_Details
            // 
            this.dgv_Category_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Category_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Category_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Category_Details.Location = new System.Drawing.Point(148, 354);
            this.dgv_Category_Details.Name = "dgv_Category_Details";
            this.dgv_Category_Details.RowHeadersWidth = 51;
            this.dgv_Category_Details.RowTemplate.Height = 24;
            this.dgv_Category_Details.Size = new System.Drawing.Size(988, 273);
            this.dgv_Category_Details.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(506, 260);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(243, 58);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Product_Type
            // 
            this.tb_Product_Type.BackColor = System.Drawing.Color.White;
            this.tb_Product_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Type.Location = new System.Drawing.Point(636, 163);
            this.tb_Product_Type.MaxLength = 30;
            this.tb_Product_Type.Name = "tb_Product_Type";
            this.tb_Product_Type.Size = new System.Drawing.Size(378, 41);
            this.tb_Product_Type.TabIndex = 1;
            // 
            // lbl_Product_Type
            // 
            this.lbl_Product_Type.AutoSize = true;
            this.lbl_Product_Type.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Type.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product_Type.Location = new System.Drawing.Point(292, 168);
            this.lbl_Product_Type.Name = "lbl_Product_Type";
            this.lbl_Product_Type.Size = new System.Drawing.Size(198, 39);
            this.lbl_Product_Type.TabIndex = 14;
            this.lbl_Product_Type.Text = "Product Type";
            // 
            // tb_Category_Id
            // 
            this.tb_Category_Id.BackColor = System.Drawing.Color.White;
            this.tb_Category_Id.Enabled = false;
            this.tb_Category_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_Id.Location = new System.Drawing.Point(636, 65);
            this.tb_Category_Id.MaxLength = 5;
            this.tb_Category_Id.Name = "tb_Category_Id";
            this.tb_Category_Id.Size = new System.Drawing.Size(378, 41);
            this.tb_Category_Id.TabIndex = 0;
            // 
            // lbl_Category_Id
            // 
            this.lbl_Category_Id.AutoSize = true;
            this.lbl_Category_Id.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Category_Id.Location = new System.Drawing.Point(292, 66);
            this.lbl_Category_Id.Name = "lbl_Category_Id";
            this.lbl_Category_Id.Size = new System.Drawing.Size(178, 39);
            this.lbl_Category_Id.TabIndex = 12;
            this.lbl_Category_Id.Text = "Category Id";
            // 
            // frm_Add_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1280, 718);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Add_Category);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.frm_Add_Category_Load);
            this.gb_Add_Category.ResumeLayout(false);
            this.gb_Add_Category.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Add_Category;
        private System.Windows.Forms.DataGridView dgv_Category_Details;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Product_Type;
        private System.Windows.Forms.Label lbl_Product_Type;
        private System.Windows.Forms.TextBox tb_Category_Id;
        private System.Windows.Forms.Label lbl_Category_Id;
    }
}