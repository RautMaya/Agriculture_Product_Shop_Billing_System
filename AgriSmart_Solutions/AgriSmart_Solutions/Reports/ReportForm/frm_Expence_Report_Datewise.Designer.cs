
namespace AgriSmart_Solutions.Reports.ReportForm
{
    partial class frm_Expence_Report_Datewise
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
            this.crv_Expence_Report_Datewise = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_End_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_Start_Date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // crv_Expence_Report_Datewise
            // 
            this.crv_Expence_Report_Datewise.ActiveViewIndex = -1;
            this.crv_Expence_Report_Datewise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Expence_Report_Datewise.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Expence_Report_Datewise.DisplayStatusBar = false;
            this.crv_Expence_Report_Datewise.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_Expence_Report_Datewise.Location = new System.Drawing.Point(0, 100);
            this.crv_Expence_Report_Datewise.Name = "crv_Expence_Report_Datewise";
            this.crv_Expence_Report_Datewise.Size = new System.Drawing.Size(1262, 571);
            this.crv_Expence_Report_Datewise.TabIndex = 0;
            this.crv_Expence_Report_Datewise.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Search.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Search.Location = new System.Drawing.Point(943, 25);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(214, 52);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtp_End_Date
            // 
            this.dtp_End_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_End_Date.Location = new System.Drawing.Point(483, 38);
            this.dtp_End_Date.Name = "dtp_End_Date";
            this.dtp_End_Date.Size = new System.Drawing.Size(345, 39);
            this.dtp_End_Date.TabIndex = 5;
            // 
            // dtp_Start_Date
            // 
            this.dtp_Start_Date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Start_Date.Location = new System.Drawing.Point(69, 38);
            this.dtp_Start_Date.Name = "dtp_Start_Date";
            this.dtp_Start_Date.Size = new System.Drawing.Size(345, 39);
            this.dtp_Start_Date.TabIndex = 4;
            // 
            // frm_Expence_Report_Datewise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 671);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dtp_End_Date);
            this.Controls.Add(this.dtp_Start_Date);
            this.Controls.Add(this.crv_Expence_Report_Datewise);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Expence_Report_Datewise";
            this.Text = "Expence Report Datewise";
            this.Load += new System.EventHandler(this.frm_Expence_Report_Datewise_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Expence_Report_Datewise;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_End_Date;
        private System.Windows.Forms.DateTimePicker dtp_Start_Date;
    }
}