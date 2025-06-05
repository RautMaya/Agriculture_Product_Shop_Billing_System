
namespace AgriSmart_Solutions.Reports.ReportForm
{
    partial class frm_Customer_Bill_Report_Datewise
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
            this.crv_Customer_Bill_Datewise_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dtp_Start_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_End_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crv_Customer_Bill_Datewise_Report
            // 
            this.crv_Customer_Bill_Datewise_Report.ActiveViewIndex = -1;
            this.crv_Customer_Bill_Datewise_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Customer_Bill_Datewise_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Customer_Bill_Datewise_Report.DisplayStatusBar = false;
            this.crv_Customer_Bill_Datewise_Report.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_Customer_Bill_Datewise_Report.Location = new System.Drawing.Point(0, 101);
            this.crv_Customer_Bill_Datewise_Report.Name = "crv_Customer_Bill_Datewise_Report";
            this.crv_Customer_Bill_Datewise_Report.Size = new System.Drawing.Size(1262, 570);
            this.crv_Customer_Bill_Datewise_Report.TabIndex = 0;
            this.crv_Customer_Bill_Datewise_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dtp_Start_Date
            // 
            this.dtp_Start_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Start_Date.Location = new System.Drawing.Point(66, 41);
            this.dtp_Start_Date.Name = "dtp_Start_Date";
            this.dtp_Start_Date.Size = new System.Drawing.Size(345, 39);
            this.dtp_Start_Date.TabIndex = 1;
            // 
            // dtp_End_Date
            // 
            this.dtp_End_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_End_Date.Location = new System.Drawing.Point(480, 41);
            this.dtp_End_Date.Name = "dtp_End_Date";
            this.dtp_End_Date.Size = new System.Drawing.Size(345, 39);
            this.dtp_End_Date.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Search.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Search.Location = new System.Drawing.Point(940, 28);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(214, 52);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Customer_Bill_Report_Datewise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 671);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dtp_End_Date);
            this.Controls.Add(this.dtp_Start_Date);
            this.Controls.Add(this.crv_Customer_Bill_Datewise_Report);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Customer_Bill_Report_Datewise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Bill Report_Datewise";
            this.Load += new System.EventHandler(this.frm_Customer_Bill_Report_Datewise_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Customer_Bill_Datewise_Report;
        private System.Windows.Forms.DateTimePicker dtp_Start_Date;
        private System.Windows.Forms.DateTimePicker dtp_End_Date;
        private System.Windows.Forms.Button btn_Search;
    }
}