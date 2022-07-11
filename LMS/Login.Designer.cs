
namespace LMS
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UsernameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PasswordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.LoginBtnElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.ExitBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.ExitBtnElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.LoginDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameTB
            // 
            this.UsernameTB.Animated = true;
            this.UsernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTB.DefaultText = "";
            this.UsernameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTB.DisabledState.Parent = this.UsernameTB;
            this.UsernameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTB.FocusedState.Parent = this.UsernameTB;
            this.UsernameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTB.HoverState.Parent = this.UsernameTB;
            this.UsernameTB.IconLeftSize = new System.Drawing.Size(21, 21);
            this.UsernameTB.IconRight = ((System.Drawing.Image)(resources.GetObject("UsernameTB.IconRight")));
            this.UsernameTB.Location = new System.Drawing.Point(300, 169);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.PasswordChar = '\0';
            this.UsernameTB.PlaceholderText = "Username";
            this.UsernameTB.SelectedText = "";
            this.UsernameTB.ShadowDecoration.Parent = this.UsernameTB;
            this.UsernameTB.Size = new System.Drawing.Size(271, 36);
            this.UsernameTB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.UsernameTB.TabIndex = 4;
            // 
            // LoginElipse
            // 
            this.LoginElipse.BorderRadius = 30;
            this.LoginElipse.TargetControl = this;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Animated = true;
            this.PasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTB.DefaultText = "";
            this.PasswordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTB.DisabledState.Parent = this.PasswordTB;
            this.PasswordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTB.FocusedState.Parent = this.PasswordTB;
            this.PasswordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTB.HoverState.Parent = this.PasswordTB;
            this.PasswordTB.IconRight = ((System.Drawing.Image)(resources.GetObject("PasswordTB.IconRight")));
            this.PasswordTB.IconRightSize = new System.Drawing.Size(18, 23);
            this.PasswordTB.Location = new System.Drawing.Point(300, 222);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '●';
            this.PasswordTB.PlaceholderText = "Password";
            this.PasswordTB.SelectedText = "";
            this.PasswordTB.ShadowDecoration.Parent = this.PasswordTB;
            this.PasswordTB.Size = new System.Drawing.Size(271, 36);
            this.PasswordTB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.PasswordTB.TabIndex = 4;
            // 
            // LoginBtn
            // 
            this.LoginBtn.AnimationHoverSpeed = 0.07F;
            this.LoginBtn.AnimationSpeed = 0.03F;
            this.LoginBtn.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.LoginBtn.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.LoginBtn.BorderColor = System.Drawing.Color.Black;
            this.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginBtn.FocusedColor = System.Drawing.Color.Empty;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Image = ((System.Drawing.Image)(resources.GetObject("LoginBtn.Image")));
            this.LoginBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.LoginBtn.Location = new System.Drawing.Point(300, 275);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.LoginBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.LoginBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoginBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.LoginBtn.OnHoverImage = null;
            this.LoginBtn.OnPressedColor = System.Drawing.Color.Black;
            this.LoginBtn.Size = new System.Drawing.Size(180, 42);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginBtnElipse
            // 
            this.LoginBtnElipse.TargetControl = this.LoginBtn;
            // 
            // ExitBtn
            // 
            this.ExitBtn.AnimationHoverSpeed = 0.07F;
            this.ExitBtn.AnimationSpeed = 0.03F;
            this.ExitBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ExitBtn.BorderColor = System.Drawing.Color.Black;
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.ExitBtn.Location = new System.Drawing.Point(486, 275);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.ExitBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.ExitBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ExitBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ExitBtn.OnHoverImage = null;
            this.ExitBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ExitBtn.Size = new System.Drawing.Size(85, 42);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            // 
            // ExitBtnElipse
            // 
            this.ExitBtnElipse.BorderRadius = 4;
            this.ExitBtnElipse.TargetControl = this.ExitBtn;
            // 
            // LoginDragControl
            // 
            this.LoginDragControl.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Secure Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Make sure your account is secure";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 87);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(275, 234);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 9;
            this.gunaPictureBox1.TabStop = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.CheckedState.Parent = this.CloseBtn;
            this.CloseBtn.CustomImages.Parent = this.CloseBtn;
            this.CloseBtn.FillColor = System.Drawing.Color.Red;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.HoverState.Parent = this.CloseBtn;
            this.CloseBtn.Location = new System.Drawing.Point(545, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(42, 42);
            this.CloseBtn.TabIndex = 10;
            this.CloseBtn.Text = "X";
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(371, 10);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(134, 132);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 11;
            this.gunaPictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 332);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox UsernameTB;
        private Guna.UI2.WinForms.Guna2Elipse LoginElipse;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTB;
        private Guna.UI.WinForms.GunaGradientButton LoginBtn;
        private Guna.UI.WinForms.GunaElipse LoginBtnElipse;
        private Guna.UI.WinForms.GunaGradientButton ExitBtn;
        private Guna.UI2.WinForms.Guna2Elipse ExitBtnElipse;
        private Guna.UI2.WinForms.Guna2DragControl LoginDragControl;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI2.WinForms.Guna2Button CloseBtn;
    }
}

