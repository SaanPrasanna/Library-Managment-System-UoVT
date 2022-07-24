
namespace LMS {
    partial class PublishersActionsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublishersActionsForm));
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.TitlePanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.TitlePb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TitleLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ActionBtn = new Guna.UI2.WinForms.Guna2Button();
            this.NumberTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PIDTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePb)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.TitlePanel;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.Transparent;
            this.TitlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TitlePanel.Controls.Add(this.TitlePb);
            this.TitlePanel.Controls.Add(this.TitleLbl);
            this.TitlePanel.Controls.Add(this.CloseBtn);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.FillColor = System.Drawing.Color.White;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Radius = 5;
            this.TitlePanel.ShadowColor = System.Drawing.Color.Black;
            this.TitlePanel.ShadowDepth = 15;
            this.TitlePanel.ShadowShift = 10;
            this.TitlePanel.Size = new System.Drawing.Size(475, 68);
            this.TitlePanel.TabIndex = 4;
            // 
            // TitlePb
            // 
            this.TitlePb.Enabled = false;
            this.TitlePb.Image = global::LMS.Properties.Resources.Members;
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
            this.TitleLbl.Size = new System.Drawing.Size(109, 37);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "Title Text";
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
            this.CloseBtn.Location = new System.Drawing.Point(424, 17);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(35, 35);
            this.CloseBtn.TabIndex = 0;
            this.toolTip1.SetToolTip(this.CloseBtn, "Press Esc to close");
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // ActionBtn
            // 
            this.ActionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionBtn.Animated = true;
            this.ActionBtn.BorderRadius = 10;
            this.ActionBtn.CheckedState.Parent = this.ActionBtn;
            this.ActionBtn.CustomImages.Parent = this.ActionBtn;
            this.ActionBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(200)))), ((int)(((byte)(86)))));
            this.ActionBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.267326F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionBtn.ForeColor = System.Drawing.Color.White;
            this.ActionBtn.HoverState.Parent = this.ActionBtn;
            this.ActionBtn.Location = new System.Drawing.Point(318, 210);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.ShadowDecoration.Parent = this.ActionBtn;
            this.ActionBtn.Size = new System.Drawing.Size(141, 38);
            this.ActionBtn.TabIndex = 3;
            this.ActionBtn.Text = "Action Button";
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // NumberTb
            // 
            this.NumberTb.Animated = true;
            this.NumberTb.BorderRadius = 15;
            this.NumberTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberTb.DefaultText = "";
            this.NumberTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NumberTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NumberTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumberTb.DisabledState.Parent = this.NumberTb;
            this.NumberTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumberTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumberTb.FocusedState.Parent = this.NumberTb;
            this.NumberTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.NumberTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumberTb.HoverState.Parent = this.NumberTb;
            this.NumberTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.NumberTb.Location = new System.Drawing.Point(128, 160);
            this.NumberTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberTb.MaxLength = 10;
            this.NumberTb.Name = "NumberTb";
            this.NumberTb.PasswordChar = '\0';
            this.NumberTb.PlaceholderText = "";
            this.NumberTb.SelectedText = "";
            this.NumberTb.ShadowDecoration.Parent = this.NumberTb;
            this.NumberTb.Size = new System.Drawing.Size(247, 36);
            this.NumberTb.TabIndex = 2;
            this.NumberTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTb_KeyPress);
            // 
            // NameTb
            // 
            this.NameTb.Animated = true;
            this.NameTb.BorderRadius = 15;
            this.NameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTb.DefaultText = "";
            this.NameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTb.DisabledState.Parent = this.NameTb;
            this.NameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTb.FocusedState.Parent = this.NameTb;
            this.NameTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.NameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTb.HoverState.Parent = this.NameTb;
            this.NameTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.NameTb.Location = new System.Drawing.Point(128, 115);
            this.NameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTb.MaxLength = 100;
            this.NameTb.Name = "NameTb";
            this.NameTb.PasswordChar = '\0';
            this.NameTb.PlaceholderText = "";
            this.NameTb.SelectedText = "";
            this.NameTb.ShadowDecoration.Parent = this.NameTb;
            this.NameTb.Size = new System.Drawing.Size(331, 36);
            this.NameTb.TabIndex = 1;
            // 
            // Label7
            // 
            this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(17, 123);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(50, 20);
            this.Label7.TabIndex = 227;
            this.Label7.Text = "Name";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(17, 78);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(92, 20);
            this.Label1.TabIndex = 222;
            this.Label1.Text = "Publisher ID";
            // 
            // PIDTb
            // 
            this.PIDTb.Animated = true;
            this.PIDTb.BorderRadius = 15;
            this.PIDTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PIDTb.DefaultText = "";
            this.PIDTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PIDTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PIDTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PIDTb.DisabledState.Parent = this.PIDTb;
            this.PIDTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PIDTb.Enabled = false;
            this.PIDTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PIDTb.FocusedState.Parent = this.PIDTb;
            this.PIDTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.PIDTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PIDTb.HoverState.Parent = this.PIDTb;
            this.PIDTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.PIDTb.Location = new System.Drawing.Point(128, 70);
            this.PIDTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PIDTb.Name = "PIDTb";
            this.PIDTb.PasswordChar = '\0';
            this.PIDTb.PlaceholderText = "";
            this.PIDTb.SelectedText = "";
            this.PIDTb.ShadowDecoration.Parent = this.PIDTb;
            this.PIDTb.Size = new System.Drawing.Size(206, 36);
            this.PIDTb.TabIndex = 0;
            // 
            // Label6
            // 
            this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(17, 168);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 20);
            this.Label6.TabIndex = 223;
            this.Label6.Text = "Telephone";
            // 
            // PublishersActionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 260);
            this.Controls.Add(this.ActionBtn);
            this.Controls.Add(this.NumberTb);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.PIDTb);
            this.Controls.Add(this.Label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "PublishersActionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PublisersActionsForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PublishersActionsForm_KeyDown);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI2.WinForms.Guna2ShadowPanel TitlePanel;
        private Guna.UI2.WinForms.Guna2PictureBox TitlePb;
        private Guna.UI2.WinForms.Guna2HtmlLabel TitleLbl;
        private Guna.UI2.WinForms.Guna2CircleButton CloseBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button ActionBtn;
        private Guna.UI2.WinForms.Guna2TextBox NumberTb;
        private Guna.UI2.WinForms.Guna2TextBox NameTb;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label1;
        private Guna.UI2.WinForms.Guna2TextBox PIDTb;
        internal System.Windows.Forms.Label Label6;
    }
}