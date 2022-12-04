
namespace LMS.Screens.Widgets {
    partial class AlertForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertForm));
            this.BodyLbl = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2VSeparator = new Guna.UI2.WinForms.Guna2VSeparator();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.IconPB = new System.Windows.Forms.PictureBox();
            this.BorderRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IconPB)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyLbl
            // 
            this.BodyLbl.Font = new System.Drawing.Font("Proxima Nova Rg", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyLbl.ForeColor = System.Drawing.Color.White;
            this.BodyLbl.Location = new System.Drawing.Point(77, 36);
            this.BodyLbl.Name = "BodyLbl";
            this.BodyLbl.Size = new System.Drawing.Size(281, 45);
            this.BodyLbl.TabIndex = 6;
            this.BodyLbl.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // guna2VSeparator
            // 
            this.guna2VSeparator.FillColor = System.Drawing.Color.White;
            this.guna2VSeparator.FillThickness = 2;
            this.guna2VSeparator.Location = new System.Drawing.Point(60, 5);
            this.guna2VSeparator.Name = "guna2VSeparator";
            this.guna2VSeparator.Size = new System.Drawing.Size(10, 65);
            this.guna2VSeparator.TabIndex = 10;
            // 
            // TitleLbl
            // 
            this.TitleLbl.Font = new System.Drawing.Font("Proxima Nova Rg", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.White;
            this.TitleLbl.Location = new System.Drawing.Point(77, 7);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(267, 28);
            this.TitleLbl.TabIndex = 7;
            this.TitleLbl.Text = "Message Text";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.Animated = true;
            this.CloseBtn.CheckedState.Parent = this.CloseBtn;
            this.CloseBtn.CustomImages.Parent = this.CloseBtn;
            this.CloseBtn.FillColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.HoverState.Image = global::LMS.Properties.Resources.cancelW;
            this.CloseBtn.HoverState.Parent = this.CloseBtn;
            this.CloseBtn.Image = global::LMS.Properties.Resources.cancelH;
            this.CloseBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.CloseBtn.Location = new System.Drawing.Point(364, 18);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(40, 40);
            this.CloseBtn.TabIndex = 9;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // IconPB
            // 
            this.IconPB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IconPB.Image = ((System.Drawing.Image)(resources.GetObject("IconPB.Image")));
            this.IconPB.Location = new System.Drawing.Point(7, 16);
            this.IconPB.Name = "IconPB";
            this.IconPB.Size = new System.Drawing.Size(50, 45);
            this.IconPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPB.TabIndex = 8;
            this.IconPB.TabStop = false;
            // 
            // BorderRadius
            // 
            this.BorderRadius.ElipseRadius = 15;
            this.BorderRadius.TargetControl = this;
            // 
            // AlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 78);
            this.Controls.Add(this.BodyLbl);
            this.Controls.Add(this.guna2VSeparator);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.IconPB);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlertForm";
            this.Text = "AlertForm";
            ((System.ComponentModel.ISupportInitialize)(this.IconPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BodyLbl;
        internal System.Windows.Forms.Timer Timer;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator;
        private Guna.UI2.WinForms.Guna2CircleButton CloseBtn;
        private System.Windows.Forms.PictureBox IconPB;
        private System.Windows.Forms.Label TitleLbl;
        private Bunifu.Framework.UI.BunifuElipse BorderRadius;
    }
}