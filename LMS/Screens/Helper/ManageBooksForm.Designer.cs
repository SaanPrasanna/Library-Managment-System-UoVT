
namespace LMS {
    partial class ManageBooksForm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBooksForm));
            this.MainPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ManageBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ActionCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.DescriptionTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.FQtyTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.AQtyTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.QtyTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.TitleTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.ISBNTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SearchTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.SelectionDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.TitlePb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TitleLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionDgv)).BeginInit();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePb)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainPanel.Controls.Add(this.ManageBtn);
            this.MainPanel.Controls.Add(this.ActionCb);
            this.MainPanel.Controls.Add(this.Label8);
            this.MainPanel.Controls.Add(this.DescriptionTb);
            this.MainPanel.Controls.Add(this.FQtyTb);
            this.MainPanel.Controls.Add(this.AQtyTb);
            this.MainPanel.Controls.Add(this.QtyTb);
            this.MainPanel.Controls.Add(this.TitleTb);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.Label7);
            this.MainPanel.Controls.Add(this.ISBNTb);
            this.MainPanel.Controls.Add(this.Label1);
            this.MainPanel.Controls.Add(this.SearchTb);
            this.MainPanel.Controls.Add(this.SelectionDgv);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.FillColor = System.Drawing.Color.White;
            this.MainPanel.Location = new System.Drawing.Point(0, 68);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Radius = 10;
            this.MainPanel.ShadowColor = System.Drawing.Color.Black;
            this.MainPanel.ShadowDepth = 15;
            this.MainPanel.ShadowShift = 10;
            this.MainPanel.Size = new System.Drawing.Size(1000, 494);
            this.MainPanel.TabIndex = 0;
            // 
            // ManageBtn
            // 
            this.ManageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ManageBtn.Animated = true;
            this.ManageBtn.BorderRadius = 10;
            this.ManageBtn.CheckedState.Parent = this.ManageBtn;
            this.ManageBtn.CustomImages.Parent = this.ManageBtn;
            this.ManageBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.267326F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageBtn.ForeColor = System.Drawing.Color.White;
            this.ManageBtn.HoverState.Parent = this.ManageBtn;
            this.ManageBtn.Location = new System.Drawing.Point(878, 435);
            this.ManageBtn.Name = "ManageBtn";
            this.ManageBtn.ShadowDecoration.Parent = this.ManageBtn;
            this.ManageBtn.Size = new System.Drawing.Size(101, 38);
            this.ManageBtn.TabIndex = 4;
            this.ManageBtn.Text = "Manage";
            this.ManageBtn.Click += new System.EventHandler(this.ManageBtn_Click);
            // 
            // ActionCb
            // 
            this.ActionCb.Animated = true;
            this.ActionCb.AutoCompleteCustomSource.AddRange(new string[] {
            "Student",
            "Others"});
            this.ActionCb.BackColor = System.Drawing.Color.Transparent;
            this.ActionCb.BorderRadius = 15;
            this.ActionCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ActionCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActionCb.FocusedColor = System.Drawing.Color.Empty;
            this.ActionCb.FocusedState.Parent = this.ActionCb;
            this.ActionCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ActionCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ActionCb.FormattingEnabled = true;
            this.ActionCb.HoverState.Parent = this.ActionCb;
            this.ActionCb.ItemHeight = 30;
            this.ActionCb.Items.AddRange(new object[] {
            "Add",
            "Remove"});
            this.ActionCb.ItemsAppearance.Parent = this.ActionCb;
            this.ActionCb.Location = new System.Drawing.Point(754, 252);
            this.ActionCb.Name = "ActionCb";
            this.ActionCb.ShadowDecoration.Parent = this.ActionCb;
            this.ActionCb.Size = new System.Drawing.Size(144, 36);
            this.ActionCb.TabIndex = 1;
            this.ActionCb.SelectedIndexChanged += new System.EventHandler(this.ActionCb_SelectedIndexChanged);
            // 
            // Label8
            // 
            this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(628, 260);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(53, 20);
            this.Label8.TabIndex = 228;
            this.Label8.Text = "Action";
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTb.Animated = true;
            this.DescriptionTb.BorderRadius = 15;
            this.DescriptionTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriptionTb.DefaultText = "";
            this.DescriptionTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DescriptionTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DescriptionTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DescriptionTb.DisabledState.Parent = this.DescriptionTb;
            this.DescriptionTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DescriptionTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DescriptionTb.FocusedState.Parent = this.DescriptionTb;
            this.DescriptionTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.DescriptionTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DescriptionTb.HoverState.Parent = this.DescriptionTb;
            this.DescriptionTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.DescriptionTb.Location = new System.Drawing.Point(754, 299);
            this.DescriptionTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DescriptionTb.MaxLength = 50;
            this.DescriptionTb.Multiline = true;
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.PasswordChar = '\0';
            this.DescriptionTb.PlaceholderText = "";
            this.DescriptionTb.SelectedText = "";
            this.DescriptionTb.ShadowDecoration.Parent = this.DescriptionTb;
            this.DescriptionTb.Size = new System.Drawing.Size(225, 80);
            this.DescriptionTb.TabIndex = 2;
            // 
            // FQtyTb
            // 
            this.FQtyTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FQtyTb.Animated = true;
            this.FQtyTb.BorderRadius = 15;
            this.FQtyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FQtyTb.DefaultText = "";
            this.FQtyTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FQtyTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FQtyTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FQtyTb.DisabledState.Parent = this.FQtyTb;
            this.FQtyTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FQtyTb.Enabled = false;
            this.FQtyTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FQtyTb.FocusedState.Parent = this.FQtyTb;
            this.FQtyTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.FQtyTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FQtyTb.HoverState.Parent = this.FQtyTb;
            this.FQtyTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.FQtyTb.Location = new System.Drawing.Point(754, 387);
            this.FQtyTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FQtyTb.Name = "FQtyTb";
            this.FQtyTb.PasswordChar = '\0';
            this.FQtyTb.PlaceholderText = "";
            this.FQtyTb.SelectedText = "";
            this.FQtyTb.ShadowDecoration.Parent = this.FQtyTb;
            this.FQtyTb.Size = new System.Drawing.Size(105, 36);
            this.FQtyTb.TabIndex = 3;
            // 
            // AQtyTb
            // 
            this.AQtyTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AQtyTb.Animated = true;
            this.AQtyTb.BorderRadius = 15;
            this.AQtyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AQtyTb.DefaultText = "";
            this.AQtyTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AQtyTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AQtyTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AQtyTb.DisabledState.Parent = this.AQtyTb;
            this.AQtyTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AQtyTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AQtyTb.FocusedState.Parent = this.AQtyTb;
            this.AQtyTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.AQtyTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AQtyTb.HoverState.Parent = this.AQtyTb;
            this.AQtyTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.AQtyTb.Location = new System.Drawing.Point(754, 208);
            this.AQtyTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AQtyTb.Name = "AQtyTb";
            this.AQtyTb.PasswordChar = '\0';
            this.AQtyTb.PlaceholderText = "";
            this.AQtyTb.SelectedText = "";
            this.AQtyTb.ShadowDecoration.Parent = this.AQtyTb;
            this.AQtyTb.Size = new System.Drawing.Size(105, 36);
            this.AQtyTb.TabIndex = 0;
            this.AQtyTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AQtyTb_KeyPress);
            this.AQtyTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AQtyTb_KeyUp);
            // 
            // QtyTb
            // 
            this.QtyTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QtyTb.Animated = true;
            this.QtyTb.BorderRadius = 15;
            this.QtyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QtyTb.DefaultText = "";
            this.QtyTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QtyTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QtyTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QtyTb.DisabledState.Parent = this.QtyTb;
            this.QtyTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QtyTb.Enabled = false;
            this.QtyTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QtyTb.FocusedState.Parent = this.QtyTb;
            this.QtyTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.QtyTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QtyTb.HoverState.Parent = this.QtyTb;
            this.QtyTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.QtyTb.Location = new System.Drawing.Point(754, 162);
            this.QtyTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.PasswordChar = '\0';
            this.QtyTb.PlaceholderText = "";
            this.QtyTb.SelectedText = "";
            this.QtyTb.ShadowDecoration.Parent = this.QtyTb;
            this.QtyTb.Size = new System.Drawing.Size(105, 36);
            this.QtyTb.TabIndex = 197;
            // 
            // TitleTb
            // 
            this.TitleTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTb.Animated = true;
            this.TitleTb.BorderRadius = 15;
            this.TitleTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TitleTb.DefaultText = "";
            this.TitleTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TitleTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TitleTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TitleTb.DisabledState.Parent = this.TitleTb;
            this.TitleTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TitleTb.Enabled = false;
            this.TitleTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TitleTb.FocusedState.Parent = this.TitleTb;
            this.TitleTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.TitleTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TitleTb.HoverState.Parent = this.TitleTb;
            this.TitleTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.TitleTb.Location = new System.Drawing.Point(754, 116);
            this.TitleTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TitleTb.Name = "TitleTb";
            this.TitleTb.PasswordChar = '\0';
            this.TitleTb.PlaceholderText = "";
            this.TitleTb.SelectedText = "";
            this.TitleTb.ShadowDecoration.Parent = this.TitleTb;
            this.TitleTb.Size = new System.Drawing.Size(225, 36);
            this.TitleTb.TabIndex = 197;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(628, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 198;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(628, 395);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 198;
            this.label5.Text = "Final Quantity";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(628, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 198;
            this.label3.Text = "Adjust Quantity";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(628, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 198;
            this.label2.Text = "Quantity";
            // 
            // Label7
            // 
            this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(628, 124);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(38, 20);
            this.Label7.TabIndex = 198;
            this.Label7.Text = "Title";
            // 
            // ISBNTb
            // 
            this.ISBNTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ISBNTb.Animated = true;
            this.ISBNTb.BorderRadius = 15;
            this.ISBNTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ISBNTb.DefaultText = "";
            this.ISBNTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ISBNTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ISBNTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ISBNTb.DisabledState.Parent = this.ISBNTb;
            this.ISBNTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ISBNTb.Enabled = false;
            this.ISBNTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ISBNTb.FocusedState.Parent = this.ISBNTb;
            this.ISBNTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.ISBNTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ISBNTb.HoverState.Parent = this.ISBNTb;
            this.ISBNTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.ISBNTb.Location = new System.Drawing.Point(754, 71);
            this.ISBNTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ISBNTb.Name = "ISBNTb";
            this.ISBNTb.PasswordChar = '\0';
            this.ISBNTb.PlaceholderText = "";
            this.ISBNTb.SelectedText = "";
            this.ISBNTb.ShadowDecoration.Parent = this.ISBNTb;
            this.ISBNTb.Size = new System.Drawing.Size(225, 36);
            this.ISBNTb.TabIndex = 193;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(628, 79);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(42, 20);
            this.Label1.TabIndex = 194;
            this.Label1.Text = "ISBN";
            // 
            // SearchTb
            // 
            this.SearchTb.Animated = true;
            this.SearchTb.BorderRadius = 15;
            this.SearchTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTb.DefaultText = "";
            this.SearchTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTb.DisabledState.Parent = this.SearchTb;
            this.SearchTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTb.FocusedState.Parent = this.SearchTb;
            this.SearchTb.Font = new System.Drawing.Font("Noto Serif Sinhala", 9F);
            this.SearchTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTb.HoverState.Parent = this.SearchTb;
            this.SearchTb.IconLeftSize = new System.Drawing.Size(21, 21);
            this.SearchTb.Location = new System.Drawing.Point(28, 23);
            this.SearchTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchTb.MaxLength = 50;
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.PasswordChar = '\0';
            this.SearchTb.PlaceholderText = "Search By Name";
            this.SearchTb.SelectedText = "";
            this.SearchTb.ShadowDecoration.Parent = this.SearchTb;
            this.SearchTb.Size = new System.Drawing.Size(249, 36);
            this.SearchTb.TabIndex = 8;
            this.SearchTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchTb_KeyUp);
            // 
            // SelectionDgv
            // 
            this.SelectionDgv.AllowUserToAddRows = false;
            this.SelectionDgv.AllowUserToDeleteRows = false;
            this.SelectionDgv.AllowUserToResizeColumns = false;
            this.SelectionDgv.AllowUserToResizeRows = false;
            this.SelectionDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectionDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectionDgv.BackgroundColor = System.Drawing.Color.White;
            this.SelectionDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectionDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SelectionDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(100)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectionDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SelectionDgv.ColumnHeadersHeight = 60;
            this.SelectionDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Noto Serif Sinhala", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SelectionDgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.SelectionDgv.EnableHeadersVisualStyles = false;
            this.SelectionDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SelectionDgv.Location = new System.Drawing.Point(36, 71);
            this.SelectionDgv.MultiSelect = false;
            this.SelectionDgv.Name = "SelectionDgv";
            this.SelectionDgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectionDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SelectionDgv.RowHeadersVisible = false;
            this.SelectionDgv.RowHeadersWidth = 43;
            this.SelectionDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SelectionDgv.RowTemplate.Height = 50;
            this.SelectionDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectionDgv.ShowEditingIcon = false;
            this.SelectionDgv.ShowRowErrors = false;
            this.SelectionDgv.Size = new System.Drawing.Size(558, 397);
            this.SelectionDgv.TabIndex = 0;
            this.SelectionDgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.SelectionDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
            this.SelectionDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SelectionDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SelectionDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SelectionDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SelectionDgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SelectionDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SelectionDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SelectionDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SelectionDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SelectionDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SelectionDgv.ThemeStyle.HeaderStyle.Height = 60;
            this.SelectionDgv.ThemeStyle.ReadOnly = true;
            this.SelectionDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SelectionDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SelectionDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Noto Serif Sinhala", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.SelectionDgv.ThemeStyle.RowsStyle.Height = 50;
            this.SelectionDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SelectionDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.SelectionDgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectionDgv_CellEnter);
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
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(1000, 68);
            this.guna2ShadowPanel2.TabIndex = 1;
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
            this.TitleLbl.Size = new System.Drawing.Size(171, 37);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "Manage Books";
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
            this.CloseBtn.Location = new System.Drawing.Point(949, 17);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(35, 35);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2ShadowPanel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.SelectionDgv;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ManageBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ManageBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBooksForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManageBooksForm_KeyDown);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionDgv)).EndInit();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel MainPanel;
        public Guna.UI2.WinForms.Guna2TextBox SearchTb;
        public Guna.UI2.WinForms.Guna2DataGridView SelectionDgv;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2PictureBox TitlePb;
        public Guna.UI2.WinForms.Guna2HtmlLabel TitleLbl;
        private Guna.UI2.WinForms.Guna2CircleButton CloseBtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox ISBNTb;
        internal System.Windows.Forms.Label Label1;
        private Guna.UI2.WinForms.Guna2TextBox TitleTb;
        internal System.Windows.Forms.Label Label7;
        private Guna.UI2.WinForms.Guna2TextBox AQtyTb;
        private Guna.UI2.WinForms.Guna2TextBox QtyTb;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox ActionCb;
        internal System.Windows.Forms.Label Label8;
        private Guna.UI2.WinForms.Guna2TextBox DescriptionTb;
        private Guna.UI2.WinForms.Guna2TextBox FQtyTb;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button ManageBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}