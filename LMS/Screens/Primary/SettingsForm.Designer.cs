
namespace LMS.Screens.Primary {
    partial class SettingsForm {
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
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.TitlePb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TitleLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OthersTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.StudentTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.SaveFeeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DaysTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveDaysBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dropShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePb)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(425, 68);
            this.guna2ShadowPanel2.TabIndex = 8;
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
            this.TitleLbl.Size = new System.Drawing.Size(96, 37);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "Settings";
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
            this.CloseBtn.Image = global::LMS.Properties.Resources.cancel;
            this.CloseBtn.Location = new System.Drawing.Point(374, 17);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(35, 35);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(15, 75);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(395, 294);
            this.tabControl.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OthersTB);
            this.tabPage1.Controls.Add(this.StudentTB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Label6);
            this.tabPage1.Controls.Add(this.SaveFeeBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(387, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fine Fee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OthersTB
            // 
            this.OthersTB.Animated = true;
            this.OthersTB.BorderRadius = 15;
            this.OthersTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OthersTB.DefaultText = "";
            this.OthersTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OthersTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OthersTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OthersTB.DisabledState.Parent = this.OthersTB;
            this.OthersTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OthersTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OthersTB.FocusedState.Parent = this.OthersTB;
            this.OthersTB.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.OthersTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OthersTB.HoverState.Parent = this.OthersTB;
            this.OthersTB.IconLeftSize = new System.Drawing.Size(21, 21);
            this.OthersTB.Location = new System.Drawing.Point(131, 75);
            this.OthersTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OthersTB.Name = "OthersTB";
            this.OthersTB.PasswordChar = '\0';
            this.OthersTB.PlaceholderText = "";
            this.OthersTB.SelectedText = "";
            this.OthersTB.ShadowDecoration.Parent = this.OthersTB;
            this.OthersTB.Size = new System.Drawing.Size(173, 36);
            this.OthersTB.TabIndex = 194;
            this.OthersTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OthersTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OthersTB_KeyPress);
            // 
            // StudentTB
            // 
            this.StudentTB.Animated = true;
            this.StudentTB.BorderRadius = 15;
            this.StudentTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StudentTB.DefaultText = "";
            this.StudentTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StudentTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StudentTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StudentTB.DisabledState.Parent = this.StudentTB;
            this.StudentTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StudentTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentTB.FocusedState.Parent = this.StudentTB;
            this.StudentTB.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.StudentTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentTB.HoverState.Parent = this.StudentTB;
            this.StudentTB.IconLeftSize = new System.Drawing.Size(21, 21);
            this.StudentTB.Location = new System.Drawing.Point(131, 26);
            this.StudentTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StudentTB.Name = "StudentTB";
            this.StudentTB.PasswordChar = '\0';
            this.StudentTB.PlaceholderText = "";
            this.StudentTB.SelectedText = "";
            this.StudentTB.ShadowDecoration.Parent = this.StudentTB;
            this.StudentTB.Size = new System.Drawing.Size(173, 36);
            this.StudentTB.TabIndex = 194;
            this.StudentTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StudentTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentTB_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 195;
            this.label2.Text = "For Other";
            // 
            // Label6
            // 
            this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(20, 32);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(89, 20);
            this.Label6.TabIndex = 195;
            this.Label6.Text = "For Student";
            // 
            // SaveFeeBtn
            // 
            this.SaveFeeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveFeeBtn.Animated = true;
            this.SaveFeeBtn.BorderRadius = 10;
            this.SaveFeeBtn.CheckedState.Parent = this.SaveFeeBtn;
            this.SaveFeeBtn.CustomImages.Parent = this.SaveFeeBtn;
            this.SaveFeeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(200)))), ((int)(((byte)(86)))));
            this.SaveFeeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.267326F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFeeBtn.ForeColor = System.Drawing.Color.White;
            this.SaveFeeBtn.HoverState.Parent = this.SaveFeeBtn;
            this.SaveFeeBtn.Location = new System.Drawing.Point(260, 211);
            this.SaveFeeBtn.Name = "SaveFeeBtn";
            this.SaveFeeBtn.ShadowDecoration.Parent = this.SaveFeeBtn;
            this.SaveFeeBtn.Size = new System.Drawing.Size(119, 38);
            this.SaveFeeBtn.TabIndex = 10;
            this.SaveFeeBtn.Text = "SAVE";
            this.SaveFeeBtn.Click += new System.EventHandler(this.SaveFeeBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DaysTB);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.SaveDaysBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(387, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Re-New Day";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DaysTB
            // 
            this.DaysTB.Animated = true;
            this.DaysTB.BorderRadius = 15;
            this.DaysTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DaysTB.DefaultText = "";
            this.DaysTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DaysTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DaysTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DaysTB.DisabledState.Parent = this.DaysTB;
            this.DaysTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DaysTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DaysTB.FocusedState.Parent = this.DaysTB;
            this.DaysTB.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.DaysTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DaysTB.HoverState.Parent = this.DaysTB;
            this.DaysTB.IconLeftSize = new System.Drawing.Size(21, 21);
            this.DaysTB.Location = new System.Drawing.Point(103, 75);
            this.DaysTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DaysTB.Name = "DaysTB";
            this.DaysTB.PasswordChar = '\0';
            this.DaysTB.PlaceholderText = "";
            this.DaysTB.SelectedText = "";
            this.DaysTB.ShadowDecoration.Parent = this.DaysTB;
            this.DaysTB.Size = new System.Drawing.Size(184, 36);
            this.DaysTB.TabIndex = 194;
            this.DaysTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DaysTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DaysTB_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 195;
            this.label3.Text = "Membership re-new after";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 195;
            this.label1.Text = "Days";
            // 
            // SaveDaysBtn
            // 
            this.SaveDaysBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveDaysBtn.Animated = true;
            this.SaveDaysBtn.BorderRadius = 10;
            this.SaveDaysBtn.CheckedState.Parent = this.SaveDaysBtn;
            this.SaveDaysBtn.CustomImages.Parent = this.SaveDaysBtn;
            this.SaveDaysBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(200)))), ((int)(((byte)(86)))));
            this.SaveDaysBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.267326F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveDaysBtn.ForeColor = System.Drawing.Color.White;
            this.SaveDaysBtn.HoverState.Parent = this.SaveDaysBtn;
            this.SaveDaysBtn.Location = new System.Drawing.Point(260, 211);
            this.SaveDaysBtn.Name = "SaveDaysBtn";
            this.SaveDaysBtn.ShadowDecoration.Parent = this.SaveDaysBtn;
            this.SaveDaysBtn.Size = new System.Drawing.Size(119, 38);
            this.SaveDaysBtn.TabIndex = 10;
            this.SaveDaysBtn.Text = "SAVE";
            this.SaveDaysBtn.Click += new System.EventHandler(this.SaveDaysBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2ShadowPanel2;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 385);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePb)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2PictureBox TitlePb;
        private Guna.UI2.WinForms.Guna2HtmlLabel TitleLbl;
        private Guna.UI2.WinForms.Guna2CircleButton CloseBtn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Button SaveFeeBtn;
        private Guna.UI2.WinForms.Guna2Button SaveDaysBtn;
        private Guna.UI2.WinForms.Guna2TextBox OthersTB;
        private Guna.UI2.WinForms.Guna2TextBox StudentTB;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label Label6;
        private Guna.UI2.WinForms.Guna2TextBox DaysTB;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ShadowForm dropShadow;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}