
namespace AgriSmart_Solutions.Headers
{
    partial class UC_Product
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
            this.btn_Add_Product = new System.Windows.Forms.Button();
            this.btn_Add_Category = new System.Windows.Forms.Button();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.btn_Update_Product = new System.Windows.Forms.Button();
            this.btn_Product_List = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Add_Product
            // 
            this.btn_Add_Product.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Add_Product.FlatAppearance.BorderSize = 0;
            this.btn_Add_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Product.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Product.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Add_Product.Location = new System.Drawing.Point(300, 70);
            this.btn_Add_Product.Name = "btn_Add_Product";
            this.btn_Add_Product.Size = new System.Drawing.Size(294, 45);
            this.btn_Add_Product.TabIndex = 18;
            this.btn_Add_Product.Text = "Add Product";
            this.btn_Add_Product.UseVisualStyleBackColor = false;
            this.btn_Add_Product.Click += new System.EventHandler(this.btn_Add_Product_Click);
            // 
            // btn_Add_Category
            // 
            this.btn_Add_Category.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Add_Category.FlatAppearance.BorderSize = 0;
            this.btn_Add_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Category.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Category.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Add_Category.Location = new System.Drawing.Point(0, 72);
            this.btn_Add_Category.Name = "btn_Add_Category";
            this.btn_Add_Category.Size = new System.Drawing.Size(294, 45);
            this.btn_Add_Category.TabIndex = 16;
            this.btn_Add_Category.Text = "Add Category";
            this.btn_Add_Category.UseVisualStyleBackColor = false;
            this.btn_Add_Category.Click += new System.EventHandler(this.btn_Add_Category_Click);
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.BackColor = System.Drawing.Color.YellowGreen;
            this.lbl_Product.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product.Location = new System.Drawing.Point(479, 11);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(409, 56);
            this.lbl_Product.TabIndex = 15;
            this.lbl_Product.Text = "Product Details";
            // 
            // btn_Update_Product
            // 
            this.btn_Update_Product.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Update_Product.FlatAppearance.BorderSize = 0;
            this.btn_Update_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update_Product.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Product.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Update_Product.Location = new System.Drawing.Point(626, 72);
            this.btn_Update_Product.Name = "btn_Update_Product";
            this.btn_Update_Product.Size = new System.Drawing.Size(294, 45);
            this.btn_Update_Product.TabIndex = 19;
            this.btn_Update_Product.Text = "Update Product";
            this.btn_Update_Product.UseVisualStyleBackColor = false;
            this.btn_Update_Product.Click += new System.EventHandler(this.btn_Update_Product_Click);
            // 
            // btn_Product_List
            // 
            this.btn_Product_List.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Product_List.FlatAppearance.BorderSize = 0;
            this.btn_Product_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Product_List.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product_List.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Product_List.Location = new System.Drawing.Point(970, 72);
            this.btn_Product_List.Name = "btn_Product_List";
            this.btn_Product_List.Size = new System.Drawing.Size(294, 45);
            this.btn_Product_List.TabIndex = 20;
            this.btn_Product_List.Text = "Product List";
            this.btn_Product_List.UseVisualStyleBackColor = false;
            this.btn_Product_List.Click += new System.EventHandler(this.btn_Product_List_Click);
            // 
            // UC_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.btn_Product_List);
            this.Controls.Add(this.btn_Update_Product);
            this.Controls.Add(this.btn_Add_Product);
            this.Controls.Add(this.btn_Add_Category);
            this.Controls.Add(this.lbl_Product);
            this.Name = "UC_Product";
            this.Size = new System.Drawing.Size(1291, 129);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_Product;
        private System.Windows.Forms.Button btn_Add_Category;
        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.Button btn_Update_Product;
        private System.Windows.Forms.Button btn_Product_List;
    }
}
