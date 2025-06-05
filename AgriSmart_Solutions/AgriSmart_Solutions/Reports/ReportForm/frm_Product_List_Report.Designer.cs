
namespace AgriSmart_Solutions.Reports.ReportForm
{
    partial class frm_Product_List_Report
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
            this.crv_Product_List_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_Product_List_Report
            // 
            this.crv_Product_List_Report.ActiveViewIndex = -1;
            this.crv_Product_List_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Product_List_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Product_List_Report.DisplayStatusBar = false;
            this.crv_Product_List_Report.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_Product_List_Report.Location = new System.Drawing.Point(0, 3);
            this.crv_Product_List_Report.Name = "crv_Product_List_Report";
            this.crv_Product_List_Report.Size = new System.Drawing.Size(1262, 668);
            this.crv_Product_List_Report.TabIndex = 0;
            this.crv_Product_List_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Product_List_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 671);
            this.Controls.Add(this.crv_Product_List_Report);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Product_List_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product List Report";
            this.Load += new System.EventHandler(this.frm_Product_List_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Product_List_Report;
    }
}