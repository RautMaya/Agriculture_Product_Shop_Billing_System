
namespace AgriSmart_Solutions.Reports.ReportForm
{
    partial class frm_Monthly_Stock_Report
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
            this.crv_Monthly_Stock_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cmb_SearchByYear = new System.Windows.Forms.ComboBox();
            this.cmb_SearchByMonth = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crv_Monthly_Stock_Report
            // 
            this.crv_Monthly_Stock_Report.ActiveViewIndex = -1;
            this.crv_Monthly_Stock_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Monthly_Stock_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Monthly_Stock_Report.DisplayStatusBar = false;
            this.crv_Monthly_Stock_Report.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_Monthly_Stock_Report.Location = new System.Drawing.Point(0, 133);
            this.crv_Monthly_Stock_Report.Name = "crv_Monthly_Stock_Report";
            this.crv_Monthly_Stock_Report.Size = new System.Drawing.Size(1262, 762);
            this.crv_Monthly_Stock_Report.TabIndex = 0;
            this.crv_Monthly_Stock_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cmb_SearchByYear
            // 
            this.cmb_SearchByYear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmb_SearchByYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchByYear.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SearchByYear.FormattingEnabled = true;
            this.cmb_SearchByYear.Items.AddRange(new object[] {
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.cmb_SearchByYear.Location = new System.Drawing.Point(586, 38);
            this.cmb_SearchByYear.Name = "cmb_SearchByYear";
            this.cmb_SearchByYear.Size = new System.Drawing.Size(296, 39);
            this.cmb_SearchByYear.TabIndex = 41;
            this.cmb_SearchByYear.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchByYear_SelectedIndexChanged);
            // 
            // cmb_SearchByMonth
            // 
            this.cmb_SearchByMonth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmb_SearchByMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchByMonth.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SearchByMonth.FormattingEnabled = true;
            this.cmb_SearchByMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmb_SearchByMonth.Location = new System.Drawing.Point(234, 41);
            this.cmb_SearchByMonth.Name = "cmb_SearchByMonth";
            this.cmb_SearchByMonth.Size = new System.Drawing.Size(296, 39);
            this.cmb_SearchByMonth.TabIndex = 40;
            this.cmb_SearchByMonth.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchByMonth_SelectedIndexChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Refresh.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Location = new System.Drawing.Point(951, 31);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(214, 52);
            this.btn_Refresh.TabIndex = 42;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Monthly_Stock_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 895);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cmb_SearchByYear);
            this.Controls.Add(this.cmb_SearchByMonth);
            this.Controls.Add(this.crv_Monthly_Stock_Report);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Monthly_Stock_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Stock Report";
            this.Load += new System.EventHandler(this.frm_Monthly_Stock_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Monthly_Stock_Report;
        private System.Windows.Forms.ComboBox cmb_SearchByYear;
        private System.Windows.Forms.ComboBox cmb_SearchByMonth;
        private System.Windows.Forms.Button btn_Refresh;
    }
}