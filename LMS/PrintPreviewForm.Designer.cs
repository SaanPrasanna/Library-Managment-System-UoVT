
namespace LMS {
    partial class PrintPreviewForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintPreviewForm));
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.TitlePb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TitleLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PrintReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.guna2ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.memberReport = new LMS.Reports.MemberReport();
            this.staffsReport = new LMS.Reports.StaffsReport();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.booksReport = new LMS.Reports.BooksReport();
            this.borrowBooksReport = new LMS.Reports.BorrowBooksReport();
            this.manageBooksReport = new LMS.Reports.ManageBooksReport();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePb)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2ShadowPanel2.Controls.Add(this.TitlePb);
            this.guna2ShadowPanel2.Controls.Add(this.TitleLbl);
            this.guna2ShadowPanel2.Controls.Add(this.CloseBtn);
            this.guna2ShadowPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 5;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowDepth = 15;
            this.guna2ShadowPanel2.ShadowShift = 10;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(902, 68);
            this.guna2ShadowPanel2.TabIndex = 2;
            // 
            // TitlePb
            // 
            this.TitlePb.Enabled = false;
            this.TitlePb.Image = global::LMS.Properties.Resources.Books;
            this.TitlePb.Location = new System.Drawing.Point(23, 17);
            this.TitlePb.Name = "TitlePb";
            this.TitlePb.ShadowDecoration.Parent = this.TitlePb;
            this.TitlePb.Size = new System.Drawing.Size(40, 35);
            this.TitlePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitlePb.TabIndex = 4;
            this.TitlePb.TabStop = false;
            // 
            // TitleLbl
            // 
            this.TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Enabled = false;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.IsSelectionEnabled = false;
            this.TitleLbl.Location = new System.Drawing.Point(69, 17);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(58, 37);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "Print";
            this.TitleLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.Animated = true;
            this.CloseBtn.CheckedState.Parent = this.CloseBtn;
            this.CloseBtn.CustomImages.Parent = this.CloseBtn;
            this.CloseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12.83168F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.HoverState.Parent = this.CloseBtn;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(851, 17);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(35, 35);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // PrintReportViewer
            // 
            this.PrintReportViewer.ActiveViewIndex = -1;
            this.PrintReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrintReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.PrintReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintReportViewer.Location = new System.Drawing.Point(0, 68);
            this.PrintReportViewer.Name = "PrintReportViewer";
            this.PrintReportViewer.ShowCloseButton = false;
            this.PrintReportViewer.ShowCopyButton = false;
            this.PrintReportViewer.ShowGroupTreeButton = false;
            this.PrintReportViewer.ShowLogo = false;
            this.PrintReportViewer.ShowParameterPanelButton = false;
            this.PrintReportViewer.Size = new System.Drawing.Size(902, 906);
            this.PrintReportViewer.TabIndex = 3;
            this.PrintReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2ShadowPanel2;
            // 
            // PrintPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 974);
            this.Controls.Add(this.PrintReportViewer);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "PrintPreviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintPreviewForm";
            this.Load += new System.EventHandler(this.PrintPreviewForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrintPreviewForm_KeyDown);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2PictureBox TitlePb;
        public Guna.UI2.WinForms.Guna2HtmlLabel TitleLbl;
        private Guna.UI2.WinForms.Guna2CircleButton CloseBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer PrintReportViewer;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm;
        private Reports.BooksReport booksReport;
        private Reports.MemberReport memberReport;
        private Reports.StaffsReport staffsReport;
        private Reports.BorrowBooksReport borrowBooksReport;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Reports.ManageBooksReport manageBooksReport;
    }
}