
namespace LMS {
    partial class ChooseForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.TitlePb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TitleLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.MainPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ChooseDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePb)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseDgv)).BeginInit();
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
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(841, 68);
            this.guna2ShadowPanel2.TabIndex = 9;
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
            this.TitleLbl.Size = new System.Drawing.Size(143, 37);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "Sample Text";
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
            this.CloseBtn.Location = new System.Drawing.Point(790, 17);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(35, 35);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainPanel.Controls.Add(this.ChooseDgv);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.FillColor = System.Drawing.Color.White;
            this.MainPanel.Location = new System.Drawing.Point(0, 68);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Radius = 10;
            this.MainPanel.ShadowColor = System.Drawing.Color.Black;
            this.MainPanel.ShadowDepth = 15;
            this.MainPanel.ShadowShift = 10;
            this.MainPanel.Size = new System.Drawing.Size(841, 506);
            this.MainPanel.TabIndex = 10;
            // 
            // ChooseDgv
            // 
            this.ChooseDgv.AllowUserToAddRows = false;
            this.ChooseDgv.AllowUserToDeleteRows = false;
            this.ChooseDgv.AllowUserToResizeColumns = false;
            this.ChooseDgv.AllowUserToResizeRows = false;
            this.ChooseDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ChooseDgv.BackgroundColor = System.Drawing.Color.White;
            this.ChooseDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChooseDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ChooseDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(100)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ChooseDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ChooseDgv.ColumnHeadersHeight = 60;
            this.ChooseDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Noto Serif Sinhala", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ChooseDgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.ChooseDgv.EnableHeadersVisualStyles = false;
            this.ChooseDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ChooseDgv.Location = new System.Drawing.Point(36, 35);
            this.ChooseDgv.MultiSelect = false;
            this.ChooseDgv.Name = "ChooseDgv";
            this.ChooseDgv.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ChooseDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ChooseDgv.RowHeadersVisible = false;
            this.ChooseDgv.RowHeadersWidth = 43;
            this.ChooseDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ChooseDgv.RowTemplate.Height = 50;
            this.ChooseDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ChooseDgv.ShowEditingIcon = false;
            this.ChooseDgv.ShowRowErrors = false;
            this.ChooseDgv.Size = new System.Drawing.Size(768, 435);
            this.ChooseDgv.TabIndex = 0;
            this.ChooseDgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ChooseDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
            this.ChooseDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ChooseDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ChooseDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ChooseDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ChooseDgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ChooseDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ChooseDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ChooseDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ChooseDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ChooseDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ChooseDgv.ThemeStyle.HeaderStyle.Height = 60;
            this.ChooseDgv.ThemeStyle.ReadOnly = true;
            this.ChooseDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ChooseDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ChooseDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Noto Serif Sinhala", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ChooseDgv.ThemeStyle.RowsStyle.Height = 50;
            this.ChooseDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ChooseDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ChooseDgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChooseDgv_CellEnter);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2ShadowPanel2;
            // 
            // ChoosePID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 574);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ChoosePID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChoosePID_KeyDown);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePb)).EndInit();
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChooseDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2PictureBox TitlePb;
        public Guna.UI2.WinForms.Guna2HtmlLabel TitleLbl;
        private Guna.UI2.WinForms.Guna2CircleButton CloseBtn;
        private Guna.UI2.WinForms.Guna2ShadowPanel MainPanel;
        public Guna.UI2.WinForms.Guna2DataGridView ChooseDgv;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}