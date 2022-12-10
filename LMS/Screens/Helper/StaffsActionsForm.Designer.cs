
namespace LMS {
    partial class StaffsActionsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffsActionsForm));
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.TitlePanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.TitlePb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TitleLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ActionBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LnameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.FnameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SIDTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.TypeCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AddressTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ChangeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
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
            this.TitlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitlePanel.BackColor = System.Drawing.Color.Transparent;
            this.TitlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TitlePanel.Controls.Add(this.TitlePb);
            this.TitlePanel.Controls.Add(this.TitleLbl);
            this.TitlePanel.Controls.Add(this.CloseBtn);
            this.TitlePanel.FillColor = System.Drawing.Color.White;
            this.TitlePanel.Location = new System.Drawing.Point(-3, -4);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Radius = 5;
            this.TitlePanel.ShadowColor = System.Drawing.Color.Black;
            this.TitlePanel.ShadowDepth = 15;
            this.TitlePanel.ShadowShift = 10;
            this.TitlePanel.Size = new System.Drawing.Size(480, 68);
            this.TitlePanel.TabIndex = 7;
            // 
            // TitlePb
            // 
            this.TitlePb.Enabled = false;
            this.TitlePb.Image = global::LMS.Properties.Resources.Staff;
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
            this.CloseBtn.Image = global::LMS.Properties.Resources.cancel;
            this.CloseBtn.Location = new System.Drawing.Point(429, 17);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(35, 35);
            this.CloseBtn.TabIndex = 0;
            this.toolTip1.SetToolTip(this.CloseBtn, "Press Esc to close");
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 224;
            this.label2.Text = "Last Name";
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
            this.ActionBtn.Location = new System.Drawing.Point(342, 379);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.ShadowDecoration.Parent = this.ActionBtn;
            this.ActionBtn.Size = new System.Drawing.Size(119, 38);
            this.ActionBtn.TabIndex = 6;
            this.ActionBtn.Text = "Action Button";
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // LnameTb
            // 
            this.LnameTb.Animated = true;
            this.LnameTb.BorderRadius = 15;
            this.LnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LnameTb.DefaultText = "";
            this.LnameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LnameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LnameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LnameTb.DisabledState.Parent = this.LnameTb;
            this.LnameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LnameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LnameTb.FocusedState.Parent = this.LnameTb;
            this.LnameTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.LnameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LnameTb.HoverState.Parent = this.LnameTb;
            this.LnameTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.LnameTb.Location = new System.Drawing.Point(127, 248);
            this.LnameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LnameTb.MaxLength = 25;
            this.LnameTb.Name = "LnameTb";
            this.LnameTb.PasswordChar = '\0';
            this.LnameTb.PlaceholderText = "";
            this.LnameTb.SelectedText = "";
            this.LnameTb.ShadowDecoration.Parent = this.LnameTb;
            this.LnameTb.Size = new System.Drawing.Size(308, 36);
            this.LnameTb.TabIndex = 3;
            // 
            // FnameTb
            // 
            this.FnameTb.Animated = true;
            this.FnameTb.BorderRadius = 15;
            this.FnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FnameTb.DefaultText = "";
            this.FnameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FnameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FnameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FnameTb.DisabledState.Parent = this.FnameTb;
            this.FnameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FnameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FnameTb.FocusedState.Parent = this.FnameTb;
            this.FnameTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.FnameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FnameTb.HoverState.Parent = this.FnameTb;
            this.FnameTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.FnameTb.Location = new System.Drawing.Point(128, 203);
            this.FnameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FnameTb.MaxLength = 25;
            this.FnameTb.Name = "FnameTb";
            this.FnameTb.PasswordChar = '\0';
            this.FnameTb.PlaceholderText = "";
            this.FnameTb.SelectedText = "";
            this.FnameTb.ShadowDecoration.Parent = this.FnameTb;
            this.FnameTb.Size = new System.Drawing.Size(307, 36);
            this.FnameTb.TabIndex = 2;
            // 
            // PasswordTb
            // 
            this.PasswordTb.Animated = true;
            this.PasswordTb.BorderRadius = 15;
            this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.DefaultText = "";
            this.PasswordTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTb.DisabledState.Parent = this.PasswordTb;
            this.PasswordTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTb.FocusedState.Parent = this.PasswordTb;
            this.PasswordTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.PasswordTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTb.HoverState.Parent = this.PasswordTb;
            this.PasswordTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.PasswordTb.Location = new System.Drawing.Point(128, 158);
            this.PasswordTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordTb.MaxLength = 30;
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '●';
            this.PasswordTb.PlaceholderText = "";
            this.PasswordTb.SelectedText = "";
            this.PasswordTb.ShadowDecoration.Parent = this.PasswordTb;
            this.PasswordTb.Size = new System.Drawing.Size(244, 36);
            this.PasswordTb.TabIndex = 1;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(17, 166);
            this.PasswordLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(73, 20);
            this.PasswordLbl.TabIndex = 227;
            this.PasswordLbl.Text = "Password";
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
            this.Label1.Size = new System.Drawing.Size(59, 20);
            this.Label1.TabIndex = 222;
            this.Label1.Text = "Staff ID";
            // 
            // SIDTb
            // 
            this.SIDTb.Animated = true;
            this.SIDTb.BorderRadius = 15;
            this.SIDTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SIDTb.DefaultText = "";
            this.SIDTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SIDTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SIDTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SIDTb.DisabledState.Parent = this.SIDTb;
            this.SIDTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SIDTb.Enabled = false;
            this.SIDTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SIDTb.FocusedState.Parent = this.SIDTb;
            this.SIDTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.SIDTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SIDTb.HoverState.Parent = this.SIDTb;
            this.SIDTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.SIDTb.Location = new System.Drawing.Point(128, 70);
            this.SIDTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SIDTb.Name = "SIDTb";
            this.SIDTb.PasswordChar = '\0';
            this.SIDTb.PlaceholderText = "";
            this.SIDTb.SelectedText = "";
            this.SIDTb.ShadowDecoration.Parent = this.SIDTb;
            this.SIDTb.Size = new System.Drawing.Size(206, 36);
            this.SIDTb.TabIndex = 0;
            // 
            // Label6
            // 
            this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(17, 211);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(83, 20);
            this.Label6.TabIndex = 223;
            this.Label6.Text = "First Name";
            // 
            // Label8
            // 
            this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(17, 343);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(41, 20);
            this.Label8.TabIndex = 226;
            this.Label8.Text = "Type";
            // 
            // TypeCb
            // 
            this.TypeCb.Animated = true;
            this.TypeCb.AutoCompleteCustomSource.AddRange(new string[] {
            "Student",
            "Others"});
            this.TypeCb.BackColor = System.Drawing.Color.Transparent;
            this.TypeCb.BorderRadius = 15;
            this.TypeCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCb.FocusedColor = System.Drawing.Color.Empty;
            this.TypeCb.FocusedState.Parent = this.TypeCb;
            this.TypeCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TypeCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TypeCb.FormattingEnabled = true;
            this.TypeCb.HoverState.Parent = this.TypeCb;
            this.TypeCb.ItemHeight = 30;
            this.TypeCb.Items.AddRange(new object[] {
            "Admin",
            "Moderator"});
            this.TypeCb.ItemsAppearance.Parent = this.TypeCb;
            this.TypeCb.Location = new System.Drawing.Point(128, 335);
            this.TypeCb.Name = "TypeCb";
            this.TypeCb.ShadowDecoration.Parent = this.TypeCb;
            this.TypeCb.Size = new System.Drawing.Size(206, 36);
            this.TypeCb.TabIndex = 5;
            // 
            // AddressTb
            // 
            this.AddressTb.Animated = true;
            this.AddressTb.BorderRadius = 15;
            this.AddressTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressTb.DefaultText = "";
            this.AddressTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddressTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddressTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTb.DisabledState.Parent = this.AddressTb;
            this.AddressTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTb.FocusedState.Parent = this.AddressTb;
            this.AddressTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.AddressTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTb.HoverState.Parent = this.AddressTb;
            this.AddressTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.AddressTb.Location = new System.Drawing.Point(127, 292);
            this.AddressTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddressTb.MaxLength = 50;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.PasswordChar = '\0';
            this.AddressTb.PlaceholderText = "";
            this.AddressTb.SelectedText = "";
            this.AddressTb.ShadowDecoration.Parent = this.AddressTb;
            this.AddressTb.Size = new System.Drawing.Size(334, 36);
            this.AddressTb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 224;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 227;
            this.label3.Text = "Username";
            // 
            // UsernameTb
            // 
            this.UsernameTb.Animated = true;
            this.UsernameTb.BorderRadius = 15;
            this.UsernameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTb.DefaultText = "";
            this.UsernameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTb.DisabledState.Parent = this.UsernameTb;
            this.UsernameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTb.FocusedState.Parent = this.UsernameTb;
            this.UsernameTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.UsernameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTb.HoverState.Parent = this.UsernameTb;
            this.UsernameTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.UsernameTb.Location = new System.Drawing.Point(128, 114);
            this.UsernameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsernameTb.MaxLength = 20;
            this.UsernameTb.Name = "UsernameTb";
            this.UsernameTb.PasswordChar = '\0';
            this.UsernameTb.PlaceholderText = "";
            this.UsernameTb.SelectedText = "";
            this.UsernameTb.ShadowDecoration.Parent = this.UsernameTb;
            this.UsernameTb.Size = new System.Drawing.Size(244, 36);
            this.UsernameTb.TabIndex = 1;
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeBtn.Animated = true;
            this.ChangeBtn.BorderRadius = 10;
            this.ChangeBtn.CheckedState.Parent = this.ChangeBtn;
            this.ChangeBtn.CustomImages.Parent = this.ChangeBtn;
            this.ChangeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.267326F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeBtn.ForeColor = System.Drawing.Color.White;
            this.ChangeBtn.HoverState.Parent = this.ChangeBtn;
            this.ChangeBtn.Location = new System.Drawing.Point(379, 158);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.ShadowDecoration.Parent = this.ChangeBtn;
            this.ChangeBtn.Size = new System.Drawing.Size(82, 38);
            this.ChangeBtn.TabIndex = 228;
            this.ChangeBtn.Text = "CHANGE";
            this.ChangeBtn.Visible = false;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // StaffsActionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 426);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.TypeCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ActionBtn);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.LnameTb);
            this.Controls.Add(this.FnameTb);
            this.Controls.Add(this.UsernameTb);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.SIDTb);
            this.Controls.Add(this.Label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "StaffsActionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffsActoinsForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StaffsActionsForm_KeyDown);
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
        internal System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button ActionBtn;
        private Guna.UI2.WinForms.Guna2TextBox LnameTb;
        private Guna.UI2.WinForms.Guna2TextBox FnameTb;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTb;
        internal System.Windows.Forms.Label PasswordLbl;
        internal System.Windows.Forms.Label Label1;
        private Guna.UI2.WinForms.Guna2TextBox SIDTb;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label8;
        private Guna.UI2.WinForms.Guna2ComboBox TypeCb;
        private Guna.UI2.WinForms.Guna2TextBox AddressTb;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTb;
        private Guna.UI2.WinForms.Guna2Button ChangeBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}