
namespace AgriSmart_Solutions.Headers
{
    partial class UC_Reports
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
            this.lbl_Reports = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Reports
            // 
            this.lbl_Reports.AutoSize = true;
            this.lbl_Reports.BackColor = System.Drawing.Color.YellowGreen;
            this.lbl_Reports.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reports.Location = new System.Drawing.Point(513, 19);
            this.lbl_Reports.Name = "lbl_Reports";
            this.lbl_Reports.Size = new System.Drawing.Size(221, 56);
            this.lbl_Reports.TabIndex = 20;
            this.lbl_Reports.Text = "Reports";
            // 
            // UC_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.lbl_Reports);
            this.Name = "UC_Reports";
            this.Size = new System.Drawing.Size(1291, 129);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Reports;
    }
}
