
namespace LMS {
    partial class MembersActionsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembersActionsForm));
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CloseBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ActionBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddressTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.LnameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.FnameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.MIDTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TitlePb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TitleLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TitlePanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.CategoryCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ReNewDateTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePb)).BeginInit();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 209;
            this.label2.Text = "Address";
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
            this.CloseBtn.Location = new System.Drawing.Point(429, 17);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(35, 35);
            this.CloseBtn.TabIndex = 0;
            this.toolTip1.SetToolTip(this.CloseBtn, "Press Esc to close");
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
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
            this.ActionBtn.Location = new System.Drawing.Point(342, 342);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.ShadowDecoration.Parent = this.ActionBtn;
            this.ActionBtn.Size = new System.Drawing.Size(119, 38);
            this.ActionBtn.TabIndex = 5;
            this.ActionBtn.Text = "Action Button";
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
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
            this.AddressTb.Location = new System.Drawing.Point(127, 205);
            this.AddressTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.PasswordChar = '\0';
            this.AddressTb.PlaceholderText = "";
            this.AddressTb.SelectedText = "";
            this.AddressTb.ShadowDecoration.Parent = this.AddressTb;
            this.AddressTb.Size = new System.Drawing.Size(334, 36);
            this.AddressTb.TabIndex = 3;
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
            this.LnameTb.Location = new System.Drawing.Point(128, 160);
            this.LnameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LnameTb.Name = "LnameTb";
            this.LnameTb.PasswordChar = '\0';
            this.LnameTb.PlaceholderText = "";
            this.LnameTb.SelectedText = "";
            this.LnameTb.ShadowDecoration.Parent = this.LnameTb;
            this.LnameTb.Size = new System.Drawing.Size(307, 36);
            this.LnameTb.TabIndex = 2;
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
            this.FnameTb.Location = new System.Drawing.Point(128, 115);
            this.FnameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FnameTb.Name = "FnameTb";
            this.FnameTb.PasswordChar = '\0';
            this.FnameTb.PlaceholderText = "";
            this.FnameTb.SelectedText = "";
            this.FnameTb.ShadowDecoration.Parent = this.FnameTb;
            this.FnameTb.Size = new System.Drawing.Size(307, 36);
            this.FnameTb.TabIndex = 1;
            // 
            // MIDTb
            // 
            this.MIDTb.Animated = true;
            this.MIDTb.BorderRadius = 15;
            this.MIDTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MIDTb.DefaultText = "";
            this.MIDTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MIDTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MIDTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MIDTb.DisabledState.Parent = this.MIDTb;
            this.MIDTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MIDTb.Enabled = false;
            this.MIDTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MIDTb.FocusedState.Parent = this.MIDTb;
            this.MIDTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.MIDTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MIDTb.HoverState.Parent = this.MIDTb;
            this.MIDTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.MIDTb.Location = new System.Drawing.Point(128, 70);
            this.MIDTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MIDTb.Name = "MIDTb";
            this.MIDTb.PasswordChar = '\0';
            this.MIDTb.PlaceholderText = "";
            this.MIDTb.SelectedText = "";
            this.MIDTb.ShadowDecoration.Parent = this.MIDTb;
            this.MIDTb.Size = new System.Drawing.Size(206, 36);
            this.MIDTb.TabIndex = 0;
            // 
            // Label8
            // 
            this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(17, 258);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(72, 20);
            this.Label8.TabIndex = 211;
            this.Label8.Text = "Category";
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
            this.Label7.Size = new System.Drawing.Size(83, 20);
            this.Label7.TabIndex = 212;
            this.Label7.Text = "First Name";
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
            this.Label6.TabIndex = 208;
            this.Label6.Text = "Last Name";
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
            this.Label1.Size = new System.Drawing.Size(86, 20);
            this.Label1.TabIndex = 207;
            this.Label1.Text = "Member ID";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
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
            this.TitleLbl.Size = new System.Drawing.Size(109, 37);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "Title Text";
            this.TitleLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.TitlePanel.TabIndex = 6;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.TitlePanel;
            // 
            // CategoryCb
            // 
            this.CategoryCb.Animated = true;
            this.CategoryCb.AutoCompleteCustomSource.AddRange(new string[] {
            "Student",
            "Others"});
            this.CategoryCb.BackColor = System.Drawing.Color.Transparent;
            this.CategoryCb.BorderRadius = 15;
            this.CategoryCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CategoryCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCb.FocusedColor = System.Drawing.Color.Empty;
            this.CategoryCb.FocusedState.Parent = this.CategoryCb;
            this.CategoryCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CategoryCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CategoryCb.FormattingEnabled = true;
            this.CategoryCb.HoverState.Parent = this.CategoryCb;
            this.CategoryCb.ItemHeight = 30;
            this.CategoryCb.Items.AddRange(new object[] {
            "Student",
            "Other"});
            this.CategoryCb.ItemsAppearance.Parent = this.CategoryCb;
            this.CategoryCb.Location = new System.Drawing.Point(128, 250);
            this.CategoryCb.Name = "CategoryCb";
            this.CategoryCb.ShadowDecoration.Parent = this.CategoryCb;
            this.CategoryCb.Size = new System.Drawing.Size(206, 36);
            this.CategoryCb.TabIndex = 4;
            // 
            // ReNewDateTb
            // 
            this.ReNewDateTb.Animated = true;
            this.ReNewDateTb.BorderRadius = 15;
            this.ReNewDateTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReNewDateTb.DefaultText = "";
            this.ReNewDateTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ReNewDateTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ReNewDateTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReNewDateTb.DisabledState.Parent = this.ReNewDateTb;
            this.ReNewDateTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReNewDateTb.Enabled = false;
            this.ReNewDateTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReNewDateTb.FocusedState.Parent = this.ReNewDateTb;
            this.ReNewDateTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.ReNewDateTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReNewDateTb.HoverState.Parent = this.ReNewDateTb;
            this.ReNewDateTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.ReNewDateTb.Location = new System.Drawing.Point(127, 295);
            this.ReNewDateTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReNewDateTb.Name = "ReNewDateTb";
            this.ReNewDateTb.PasswordChar = '\0';
            this.ReNewDateTb.PlaceholderText = "";
            this.ReNewDateTb.SelectedText = "";
            this.ReNewDateTb.ShadowDecoration.Parent = this.ReNewDateTb;
            this.ReNewDateTb.Size = new System.Drawing.Size(207, 36);
            this.ReNewDateTb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 209;
            this.label3.Text = "Re-New Date";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateBtn.Animated = true;
            this.UpdateBtn.BorderRadius = 10;
            this.UpdateBtn.CheckedState.Parent = this.UpdateBtn;
            this.UpdateBtn.CustomImages.Parent = this.UpdateBtn;
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.267326F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.HoverState.Parent = this.UpdateBtn;
            this.UpdateBtn.Location = new System.Drawing.Point(341, 293);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.ShadowDecoration.Parent = this.UpdateBtn;
            this.UpdateBtn.Size = new System.Drawing.Size(120, 38);
            this.UpdateBtn.TabIndex = 213;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.Visible = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // MembersActionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 389);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.CategoryCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReNewDateTb);
            this.Controls.Add(this.ActionBtn);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.LnameTb);
            this.Controls.Add(this.FnameTb);
            this.Controls.Add(this.MIDTb);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MembersActionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberActionsForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MemberActionsForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.TitlePb)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2CircleButton CloseBtn;
        private Guna.UI2.WinForms.Guna2Button ActionBtn;
        private Guna.UI2.WinForms.Guna2TextBox AddressTb;
        private Guna.UI2.WinForms.Guna2TextBox LnameTb;
        private Guna.UI2.WinForms.Guna2TextBox FnameTb;
        private Guna.UI2.WinForms.Guna2TextBox MIDTb;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox TitlePb;
        private Guna.UI2.WinForms.Guna2HtmlLabel TitleLbl;
        private Guna.UI2.WinForms.Guna2ShadowPanel TitlePanel;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI2.WinForms.Guna2ComboBox CategoryCb;
        internal System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox ReNewDateTb;
        private Guna.UI2.WinForms.Guna2Button UpdateBtn;
    }
}