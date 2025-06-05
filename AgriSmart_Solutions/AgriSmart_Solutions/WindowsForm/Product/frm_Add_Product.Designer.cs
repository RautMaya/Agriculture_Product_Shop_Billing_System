
namespace AgriSmart_Solutions.WindowsForm.Product
{
    partial class frm_Add_Product
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
            this.gb_Id_Product_Type = new System.Windows.Forms.GroupBox();
            this.cmb_Product_Type = new System.Windows.Forms.ComboBox();
            this.lbl_Product_Type = new System.Windows.Forms.Label();
            this.tb_Product_Id = new System.Windows.Forms.TextBox();
            this.lbl_Product_Id = new System.Windows.Forms.Label();
            this.gb_Product_Information = new System.Windows.Forms.GroupBox();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.lbl_Packing = new System.Windows.Forms.Label();
            this.cmb_Unit = new System.Windows.Forms.ComboBox();
            this.tb_Packing = new System.Windows.Forms.TextBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.gb_Price_Information = new System.Windows.Forms.GroupBox();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.tb_Sales_Price = new System.Windows.Forms.TextBox();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.lbl_Sales_Price = new System.Windows.Forms.Label();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Id_Product_Type.SuspendLayout();
            this.gb_Product_Information.SuspendLayout();
            this.gb_Price_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Id_Product_Type
            // 
            this.gb_Id_Product_Type.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Id_Product_Type.Controls.Add(this.cmb_Product_Type);
            this.gb_Id_Product_Type.Controls.Add(this.lbl_Product_Type);
            this.gb_Id_Product_Type.Controls.Add(this.tb_Product_Id);
            this.gb_Id_Product_Type.Controls.Add(this.lbl_Product_Id);
            this.gb_Id_Product_Type.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Id_Product_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Id_Product_Type.Location = new System.Drawing.Point(12, 12);
            this.gb_Id_Product_Type.Name = "gb_Id_Product_Type";
            this.gb_Id_Product_Type.Size = new System.Drawing.Size(1256, 158);
            this.gb_Id_Product_Type.TabIndex = 1;
            this.gb_Id_Product_Type.TabStop = false;
            this.gb_Id_Product_Type.Text = "Id  and Product Type";
            // 
            // cmb_Product_Type
            // 
            this.cmb_Product_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Type.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Type.FormattingEnabled = true;
            this.cmb_Product_Type.Location = new System.Drawing.Point(824, 66);
            this.cmb_Product_Type.MaxLength = 30;
            this.cmb_Product_Type.Name = "cmb_Product_Type";
            this.cmb_Product_Type.Size = new System.Drawing.Size(352, 39);
            this.cmb_Product_Type.TabIndex = 2;
            
            // 
            // lbl_Product_Type
            // 
            this.lbl_Product_Type.AutoSize = true;
            this.lbl_Product_Type.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Type.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product_Type.Location = new System.Drawing.Point(628, 65);
            this.lbl_Product_Type.Name = "lbl_Product_Type";
            this.lbl_Product_Type.Size = new System.Drawing.Size(182, 32);
            this.lbl_Product_Type.TabIndex = 31;
            this.lbl_Product_Type.Text = "Product Type";
            // 
            // tb_Product_Id
            // 
            this.tb_Product_Id.BackColor = System.Drawing.Color.White;
            this.tb_Product_Id.Enabled = false;
            this.tb_Product_Id.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Id.Location = new System.Drawing.Point(238, 65);
            this.tb_Product_Id.MaxLength = 8;
            this.tb_Product_Id.Name = "tb_Product_Id";
            this.tb_Product_Id.Size = new System.Drawing.Size(335, 39);
            this.tb_Product_Id.TabIndex = 0;
            // 
            // lbl_Product_Id
            // 
            this.lbl_Product_Id.AutoSize = true;
            this.lbl_Product_Id.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product_Id.Location = new System.Drawing.Point(24, 65);
            this.lbl_Product_Id.Name = "lbl_Product_Id";
            this.lbl_Product_Id.Size = new System.Drawing.Size(148, 32);
            this.lbl_Product_Id.TabIndex = 12;
            this.lbl_Product_Id.Text = "Product Id";
            // 
            // gb_Product_Information
            // 
            this.gb_Product_Information.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Product_Information.Controls.Add(this.lbl_Unit);
            this.gb_Product_Information.Controls.Add(this.tb_Product_Name);
            this.gb_Product_Information.Controls.Add(this.lbl_Packing);
            this.gb_Product_Information.Controls.Add(this.cmb_Unit);
            this.gb_Product_Information.Controls.Add(this.tb_Packing);
            this.gb_Product_Information.Controls.Add(this.lbl_Product_Name);
            this.gb_Product_Information.Controls.Add(this.lbl_Weight);
            this.gb_Product_Information.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Product_Information.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Product_Information.Location = new System.Drawing.Point(12, 176);
            this.gb_Product_Information.Name = "gb_Product_Information";
            this.gb_Product_Information.Size = new System.Drawing.Size(1256, 166);
            this.gb_Product_Information.TabIndex = 2;
            this.gb_Product_Information.TabStop = false;
            this.gb_Product_Information.Text = "Product Information";
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Georgia", 12.8F);
            this.lbl_Unit.ForeColor = System.Drawing.Color.Black;
            this.lbl_Unit.Location = new System.Drawing.Point(1079, 22);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(82, 27);
            this.lbl_Unit.TabIndex = 22;
            this.lbl_Unit.Text = "( Unit )";
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.BackColor = System.Drawing.Color.White;
            this.tb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(238, 54);
            this.tb_Product_Name.MaxLength = 50;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(335, 39);
            this.tb_Product_Name.TabIndex = 2;
            // 
            // lbl_Packing
            // 
            this.lbl_Packing.AutoSize = true;
            this.lbl_Packing.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Packing.ForeColor = System.Drawing.Color.Black;
            this.lbl_Packing.Location = new System.Drawing.Point(628, 51);
            this.lbl_Packing.Name = "lbl_Packing";
            this.lbl_Packing.Size = new System.Drawing.Size(120, 32);
            this.lbl_Packing.TabIndex = 21;
            this.lbl_Packing.Text = "Packing ";
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
            this.cmb_Unit.Location = new System.Drawing.Point(1063, 52);
            this.cmb_Unit.MaxLength = 50;
            this.cmb_Unit.Name = "cmb_Unit";
            this.cmb_Unit.Size = new System.Drawing.Size(113, 39);
            this.cmb_Unit.TabIndex = 5;
            // 
            // tb_Packing
            // 
            this.tb_Packing.BackColor = System.Drawing.Color.White;
            this.tb_Packing.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Packing.Location = new System.Drawing.Point(824, 52);
            this.tb_Packing.MaxLength = 6;
            this.tb_Packing.Name = "tb_Packing";
            this.tb_Packing.Size = new System.Drawing.Size(233, 39);
            this.tb_Packing.TabIndex = 4;
            this.tb_Packing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product_Name.Location = new System.Drawing.Point(19, 61);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(195, 32);
            this.lbl_Product_Name.TabIndex = 19;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.Font = new System.Drawing.Font("Georgia", 12.8F);
            this.lbl_Weight.ForeColor = System.Drawing.Color.Black;
            this.lbl_Weight.Location = new System.Drawing.Point(629, 93);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(108, 27);
            this.lbl_Weight.TabIndex = 18;
            this.lbl_Weight.Text = "( Weight )";
            // 
            // gb_Price_Information
            // 
            this.gb_Price_Information.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Price_Information.Controls.Add(this.tb_Purchase_Price);
            this.gb_Price_Information.Controls.Add(this.tb_Sales_Price);
            this.gb_Price_Information.Controls.Add(this.tb_Note);
            this.gb_Price_Information.Controls.Add(this.lbl_Note);
            this.gb_Price_Information.Controls.Add(this.lbl_Sales_Price);
            this.gb_Price_Information.Controls.Add(this.lbl_Purchase_Price);
            this.gb_Price_Information.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Price_Information.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_Price_Information.Location = new System.Drawing.Point(12, 348);
            this.gb_Price_Information.Name = "gb_Price_Information";
            this.gb_Price_Information.Size = new System.Drawing.Size(1256, 277);
            this.gb_Price_Information.TabIndex = 3;
            this.gb_Price_Information.TabStop = false;
            this.gb_Price_Information.Text = "Price Information";
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.BackColor = System.Drawing.Color.White;
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(238, 62);
            this.tb_Purchase_Price.MaxLength = 6;
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(335, 39);
            this.tb_Purchase_Price.TabIndex = 5;
            this.tb_Purchase_Price.Text = "0";
            this.tb_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Sales_Price
            // 
            this.tb_Sales_Price.BackColor = System.Drawing.Color.White;
            this.tb_Sales_Price.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Price.Location = new System.Drawing.Point(238, 174);
            this.tb_Sales_Price.MaxLength = 6;
            this.tb_Sales_Price.Name = "tb_Sales_Price";
            this.tb_Sales_Price.Size = new System.Drawing.Size(335, 39);
            this.tb_Sales_Price.TabIndex = 6;
            this.tb_Sales_Price.Text = "0";
            this.tb_Sales_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Note
            // 
            this.tb_Note.BackColor = System.Drawing.Color.White;
            this.tb_Note.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Note.Location = new System.Drawing.Point(824, 56);
            this.tb_Note.MaxLength = 250;
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(376, 152);
            this.tb_Note.TabIndex = 7;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Black;
            this.lbl_Note.Location = new System.Drawing.Point(643, 64);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(75, 32);
            this.lbl_Note.TabIndex = 19;
            this.lbl_Note.Text = "Note";
            // 
            // lbl_Sales_Price
            // 
            this.lbl_Sales_Price.AutoSize = true;
            this.lbl_Sales_Price.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_Price.ForeColor = System.Drawing.Color.Black;
            this.lbl_Sales_Price.Location = new System.Drawing.Point(24, 176);
            this.lbl_Sales_Price.Name = "lbl_Sales_Price";
            this.lbl_Sales_Price.Size = new System.Drawing.Size(149, 32);
            this.lbl_Sales_Price.TabIndex = 18;
            this.lbl_Sales_Price.Text = "Sales Price";
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.ForeColor = System.Drawing.Color.Black;
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(19, 64);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(200, 32);
            this.lbl_Purchase_Price.TabIndex = 16;
            this.lbl_Purchase_Price.Text = "Purchase Price";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(250, 644);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(243, 62);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(806, 644);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(243, 62);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1280, 718);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Price_Information);
            this.Controls.Add(this.gb_Product_Information);
            this.Controls.Add(this.gb_Id_Product_Type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.frm_Add_Product_Load);
            this.gb_Id_Product_Type.ResumeLayout(false);
            this.gb_Id_Product_Type.PerformLayout();
            this.gb_Product_Information.ResumeLayout(false);
            this.gb_Product_Information.PerformLayout();
            this.gb_Price_Information.ResumeLayout(false);
            this.gb_Price_Information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Id_Product_Type;
        private System.Windows.Forms.ComboBox cmb_Product_Type;
        private System.Windows.Forms.Label lbl_Product_Type;
        private System.Windows.Forms.TextBox tb_Product_Id;
        private System.Windows.Forms.Label lbl_Product_Id;
        private System.Windows.Forms.GroupBox gb_Product_Information;
        private System.Windows.Forms.TextBox tb_Packing;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.GroupBox gb_Price_Information;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.TextBox tb_Sales_Price;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Label lbl_Sales_Price;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cmb_Unit;
        private System.Windows.Forms.Label lbl_Packing;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.Label lbl_Unit;
    }
}