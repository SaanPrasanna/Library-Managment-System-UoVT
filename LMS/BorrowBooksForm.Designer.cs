
namespace LMS {
    partial class BorrowBooksForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBooksForm));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.TitlePb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TitleLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MinimizeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.MainPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.SearchTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.BunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BorrowDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.BorrowBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.ClearAllBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.NewBorrowBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.UsernameLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FNameLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePb)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowDgv)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2ShadowPanel2.Controls.Add(this.TitlePb);
            this.guna2ShadowPanel2.Controls.Add(this.TitleLbl);
            this.guna2ShadowPanel2.Controls.Add(this.MinimizeBtn);
            this.guna2ShadowPanel2.Controls.Add(this.CloseBtn);
            this.guna2ShadowPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 5;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowDepth = 15;
            this.guna2ShadowPanel2.ShadowShift = 10;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(1617, 68);
            this.guna2ShadowPanel2.TabIndex = 2;
            // 
            // TitlePb
            // 
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
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(76, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(205, 47);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "Borrow Books";
            this.TitleLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn.Animated = true;
            this.MinimizeBtn.CheckedState.Parent = this.MinimizeBtn;
            this.MinimizeBtn.CustomImages.Parent = this.MinimizeBtn;
            this.MinimizeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(200)))), ((int)(((byte)(86)))));
            this.MinimizeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12.83168F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeBtn.HoverState.Parent = this.MinimizeBtn;
            this.MinimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.Image")));
            this.MinimizeBtn.Location = new System.Drawing.Point(1527, 17);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MinimizeBtn.ShadowDecoration.Parent = this.MinimizeBtn;
            this.MinimizeBtn.Size = new System.Drawing.Size(35, 35);
            this.MinimizeBtn.TabIndex = 0;
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
            this.CloseBtn.Location = new System.Drawing.Point(1565, 17);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(35, 35);
            this.CloseBtn.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainPanel.Controls.Add(this.SearchTB);
            this.MainPanel.Controls.Add(this.BunifuCustomLabel3);
            this.MainPanel.Controls.Add(this.BorrowDgv);
            this.MainPanel.FillColor = System.Drawing.Color.White;
            this.MainPanel.Location = new System.Drawing.Point(0, 68);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Radius = 10;
            this.MainPanel.ShadowColor = System.Drawing.Color.Black;
            this.MainPanel.ShadowDepth = 15;
            this.MainPanel.ShadowShift = 10;
            this.MainPanel.Size = new System.Drawing.Size(1171, 892);
            this.MainPanel.TabIndex = 0;
            // 
            // SearchTB
            // 
            this.SearchTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTB.Animated = true;
            this.SearchTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchTB.BorderRadius = 10;
            this.SearchTB.BorderThickness = 2;
            this.SearchTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTB.DefaultText = "";
            this.SearchTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTB.DisabledState.Parent = this.SearchTB;
            this.SearchTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTB.FocusedState.Parent = this.SearchTB;
            this.SearchTB.Font = new System.Drawing.Font("Noto Serif Sinhala", 15F);
            this.SearchTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTB.HoverState.Parent = this.SearchTB;
            this.SearchTB.IconLeftSize = new System.Drawing.Size(21, 21);
            this.SearchTB.Location = new System.Drawing.Point(230, 35);
            this.SearchTB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.PasswordChar = '\0';
            this.SearchTB.PlaceholderText = "Type here";
            this.SearchTB.SelectedText = "";
            this.SearchTB.ShadowDecoration.Parent = this.SearchTB;
            this.SearchTB.Size = new System.Drawing.Size(904, 49);
            this.SearchTB.TabIndex = 0;
            // 
            // BunifuCustomLabel3
            // 
            this.BunifuCustomLabel3.AutoSize = true;
            this.BunifuCustomLabel3.Font = new System.Drawing.Font("Proxima Nova Rg", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.BunifuCustomLabel3.Location = new System.Drawing.Point(29, 39);
            this.BunifuCustomLabel3.Name = "BunifuCustomLabel3";
            this.BunifuCustomLabel3.Size = new System.Drawing.Size(160, 41);
            this.BunifuCustomLabel3.TabIndex = 8;
            this.BunifuCustomLabel3.Text = "SEARCH";
            // 
            // BorrowDgv
            // 
            this.BorrowDgv.AllowUserToAddRows = false;
            this.BorrowDgv.AllowUserToDeleteRows = false;
            this.BorrowDgv.AllowUserToResizeColumns = false;
            this.BorrowDgv.AllowUserToResizeRows = false;
            this.BorrowDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrowDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BorrowDgv.BackgroundColor = System.Drawing.Color.White;
            this.BorrowDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BorrowDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BorrowDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(100)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BorrowDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BorrowDgv.ColumnHeadersHeight = 60;
            this.BorrowDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Noto Serif Sinhala", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BorrowDgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.BorrowDgv.EnableHeadersVisualStyles = false;
            this.BorrowDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BorrowDgv.Location = new System.Drawing.Point(36, 111);
            this.BorrowDgv.MultiSelect = false;
            this.BorrowDgv.Name = "BorrowDgv";
            this.BorrowDgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BorrowDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BorrowDgv.RowHeadersVisible = false;
            this.BorrowDgv.RowHeadersWidth = 43;
            this.BorrowDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BorrowDgv.RowTemplate.Height = 50;
            this.BorrowDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BorrowDgv.ShowEditingIcon = false;
            this.BorrowDgv.ShowRowErrors = false;
            this.BorrowDgv.Size = new System.Drawing.Size(1098, 745);
            this.BorrowDgv.TabIndex = 0;
            this.BorrowDgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.BorrowDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
            this.BorrowDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BorrowDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BorrowDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BorrowDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BorrowDgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BorrowDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BorrowDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BorrowDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BorrowDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BorrowDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BorrowDgv.ThemeStyle.HeaderStyle.Height = 60;
            this.BorrowDgv.ThemeStyle.ReadOnly = true;
            this.BorrowDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BorrowDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BorrowDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Noto Serif Sinhala", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.BorrowDgv.ThemeStyle.RowsStyle.Height = 50;
            this.BorrowDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BorrowDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2ShadowPanel1.Controls.Add(this.gunaPictureBox2);
            this.guna2ShadowPanel1.Controls.Add(this.BorrowBtn);
            this.guna2ShadowPanel1.Controls.Add(this.ClearAllBtn);
            this.guna2ShadowPanel1.Controls.Add(this.NewBorrowBtn);
            this.guna2ShadowPanel1.Controls.Add(this.guna2GroupBox1);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(1177, 68);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 15;
            this.guna2ShadowPanel1.ShadowShift = 10;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(440, 892);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Enabled = false;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(109, 568);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(233, 215);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 12;
            this.gunaPictureBox2.TabStop = false;
            // 
            // BorrowBtn
            // 
            this.BorrowBtn.Animated = true;
            this.BorrowBtn.BorderRadius = 20;
            this.BorrowBtn.CheckedState.Parent = this.BorrowBtn;
            this.BorrowBtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("BorrowBtn.CustomImages.Image")));
            this.BorrowBtn.CustomImages.ImageOffset = new System.Drawing.Point(10, -60);
            this.BorrowBtn.CustomImages.ImageSize = new System.Drawing.Size(23, 18);
            this.BorrowBtn.CustomImages.Parent = this.BorrowBtn;
            this.BorrowBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(181)))), ((int)(((byte)(74)))));
            this.BorrowBtn.Font = new System.Drawing.Font("Proxima Nova Rg", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowBtn.ForeColor = System.Drawing.Color.White;
            this.BorrowBtn.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("BorrowBtn.HoverState.Image")));
            this.BorrowBtn.HoverState.Parent = this.BorrowBtn;
            this.BorrowBtn.Image = ((System.Drawing.Image)(resources.GetObject("BorrowBtn.Image")));
            this.BorrowBtn.ImageSize = new System.Drawing.Size(70, 70);
            this.BorrowBtn.Location = new System.Drawing.Point(31, 227);
            this.BorrowBtn.Name = "BorrowBtn";
            this.BorrowBtn.ShadowDecoration.Parent = this.BorrowBtn;
            this.BorrowBtn.Size = new System.Drawing.Size(378, 180);
            this.BorrowBtn.TabIndex = 2;
            this.BorrowBtn.Text = "Borrow";
            // 
            // ClearAllBtn
            // 
            this.ClearAllBtn.Animated = true;
            this.ClearAllBtn.BorderRadius = 20;
            this.ClearAllBtn.CheckedState.Parent = this.ClearAllBtn;
            this.ClearAllBtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("ClearAllBtn.CustomImages.Image")));
            this.ClearAllBtn.CustomImages.ImageOffset = new System.Drawing.Point(10, -60);
            this.ClearAllBtn.CustomImages.ImageSize = new System.Drawing.Size(23, 18);
            this.ClearAllBtn.CustomImages.Parent = this.ClearAllBtn;
            this.ClearAllBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(199)))));
            this.ClearAllBtn.Font = new System.Drawing.Font("Proxima Nova Rg", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAllBtn.ForeColor = System.Drawing.Color.White;
            this.ClearAllBtn.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("ClearAllBtn.HoverState.Image")));
            this.ClearAllBtn.HoverState.Parent = this.ClearAllBtn;
            this.ClearAllBtn.Image = ((System.Drawing.Image)(resources.GetObject("ClearAllBtn.Image")));
            this.ClearAllBtn.ImageSize = new System.Drawing.Size(64, 64);
            this.ClearAllBtn.Location = new System.Drawing.Point(229, 29);
            this.ClearAllBtn.Name = "ClearAllBtn";
            this.ClearAllBtn.ShadowDecoration.Parent = this.ClearAllBtn;
            this.ClearAllBtn.Size = new System.Drawing.Size(180, 180);
            this.ClearAllBtn.TabIndex = 1;
            this.ClearAllBtn.Text = "Clear All";
            // 
            // NewBorrowBtn
            // 
            this.NewBorrowBtn.Animated = true;
            this.NewBorrowBtn.BorderRadius = 20;
            this.NewBorrowBtn.CheckedState.Parent = this.NewBorrowBtn;
            this.NewBorrowBtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("NewBorrowBtn.CustomImages.Image")));
            this.NewBorrowBtn.CustomImages.ImageOffset = new System.Drawing.Point(10, -60);
            this.NewBorrowBtn.CustomImages.ImageSize = new System.Drawing.Size(23, 18);
            this.NewBorrowBtn.CustomImages.Parent = this.NewBorrowBtn;
            this.NewBorrowBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(199)))));
            this.NewBorrowBtn.Font = new System.Drawing.Font("Proxima Nova Rg", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBorrowBtn.ForeColor = System.Drawing.Color.White;
            this.NewBorrowBtn.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("NewBorrowBtn.HoverState.Image")));
            this.NewBorrowBtn.HoverState.Parent = this.NewBorrowBtn;
            this.NewBorrowBtn.Image = ((System.Drawing.Image)(resources.GetObject("NewBorrowBtn.Image")));
            this.NewBorrowBtn.ImageSize = new System.Drawing.Size(64, 64);
            this.NewBorrowBtn.Location = new System.Drawing.Point(30, 29);
            this.NewBorrowBtn.Name = "NewBorrowBtn";
            this.NewBorrowBtn.ShadowDecoration.Parent = this.NewBorrowBtn;
            this.NewBorrowBtn.Size = new System.Drawing.Size(180, 180);
            this.NewBorrowBtn.TabIndex = 0;
            this.NewBorrowBtn.Text = "New Borrow";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Controls.Add(this.UsernameLbl);
            this.guna2GroupBox1.Controls.Add(this.FNameLbl);
            this.guna2GroupBox1.Controls.Add(this.guna2PictureBox1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(10, 802);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(252, 79);
            this.guna2GroupBox1.TabIndex = 8;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.ForeColor = System.Drawing.Color.Silver;
            this.UsernameLbl.Location = new System.Drawing.Point(84, 34);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(41, 19);
            this.UsernameLbl.TabIndex = 7;
            this.UsernameLbl.Text = "admin";
            this.UsernameLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FNameLbl
            // 
            this.FNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.FNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLbl.ForeColor = System.Drawing.Color.Black;
            this.FNameLbl.Location = new System.Drawing.Point(84, 12);
            this.FNameLbl.Name = "FNameLbl";
            this.FNameLbl.Size = new System.Drawing.Size(86, 25);
            this.FNameLbl.TabIndex = 6;
            this.FNameLbl.Text = "First Name";
            this.FNameLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(23, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(55, 55);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.BorrowDgv;
            // 
            // BorrowBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 960);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowBooksForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BorrowBooksForm_Load);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePb)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowDgv)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2PictureBox TitlePb;
        private Guna.UI2.WinForms.Guna2HtmlLabel TitleLbl;
        private Guna.UI2.WinForms.Guna2CircleButton MinimizeBtn;
        private Guna.UI2.WinForms.Guna2CircleButton CloseBtn;
        private Guna.UI2.WinForms.Guna2ShadowPanel MainPanel;
        public Guna.UI2.WinForms.Guna2DataGridView BorrowDgv;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2TileButton ClearAllBtn;
        private Guna.UI2.WinForms.Guna2TileButton NewBorrowBtn;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel UsernameLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel FNameLbl;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TileButton BorrowBtn;
        internal Bunifu.Framework.UI.BunifuCustomLabel BunifuCustomLabel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        public Guna.UI2.WinForms.Guna2TextBox SearchTB;
    }
}