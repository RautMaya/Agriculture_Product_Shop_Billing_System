
namespace AgriSmart_Solutions.WindowsForm.Expence
{
    partial class frm_Show_Bill_Image
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
            this.gb_Bill_Image = new System.Windows.Forms.GroupBox();
            this.pb_Bill_Image = new System.Windows.Forms.PictureBox();
            this.dgv_Bill_Image = new System.Windows.Forms.DataGridView();
            this.gb_Bill_Image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Bill_Image
            // 
            this.gb_Bill_Image.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_Bill_Image.Controls.Add(this.pb_Bill_Image);
            this.gb_Bill_Image.Controls.Add(this.dgv_Bill_Image);
            this.gb_Bill_Image.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Bill_Image.Location = new System.Drawing.Point(12, 12);
            this.gb_Bill_Image.Name = "gb_Bill_Image";
            this.gb_Bill_Image.Size = new System.Drawing.Size(1262, 694);
            this.gb_Bill_Image.TabIndex = 0;
            this.gb_Bill_Image.TabStop = false;
            this.gb_Bill_Image.Text = "Bill Image";
            // 
            // pb_Bill_Image
            // 
            this.pb_Bill_Image.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pb_Bill_Image.ErrorImage = null;
            this.pb_Bill_Image.Location = new System.Drawing.Point(149, 168);
            this.pb_Bill_Image.Name = "pb_Bill_Image";
            this.pb_Bill_Image.Size = new System.Drawing.Size(433, 363);
            this.pb_Bill_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Bill_Image.TabIndex = 1;
            this.pb_Bill_Image.TabStop = false;
            // 
            // dgv_Bill_Image
            // 
            this.dgv_Bill_Image.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Bill_Image.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bill_Image.Location = new System.Drawing.Point(699, 168);
            this.dgv_Bill_Image.Name = "dgv_Bill_Image";
            this.dgv_Bill_Image.RowHeadersWidth = 51;
            this.dgv_Bill_Image.RowTemplate.Height = 24;
            this.dgv_Bill_Image.Size = new System.Drawing.Size(482, 363);
            this.dgv_Bill_Image.TabIndex = 0;
            this.dgv_Bill_Image.SelectionChanged += new System.EventHandler(this.dgv_Bill_Image_SelectionChanged);
            // 
            // frm_Show_Bill_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1286, 718);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Bill_Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Show_Bill_Image";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Bill Image";
            this.Load += new System.EventHandler(this.frm_Show_Bill_Image_Load);
            this.gb_Bill_Image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Bill_Image;
        private System.Windows.Forms.DataGridView dgv_Bill_Image;
        private System.Windows.Forms.PictureBox pb_Bill_Image;
    }
}