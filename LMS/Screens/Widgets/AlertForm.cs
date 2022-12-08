using LMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Screens.Widgets {
    public partial class AlertForm : Form {

        private AlertForm.EnmAction action;
        private int x, y;

        public AlertForm() {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
            this.TopMost = true;
        }

        #region Enums
        public enum EnmAction {
            wait,
            start,
            close
        }

        public enum EnmType {
            Success,
            Warning,
            Error,
            Info
        }

        #endregion

        #region Special Events
        private void CloseBtn_Click(object sender, EventArgs e) {
            Timer.Interval = 1;
            action = EnmAction.close;
        }
        private void Timer_Tick(object sender, EventArgs e) {
            switch (this.action) {
                case EnmAction.wait:
                    Timer.Interval = 4500;
                    action = EnmAction.close;
                    break;
                case AlertForm.EnmAction.start:
                    this.Timer.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X) {
                        this.Left--;
                    } else {
                        if (this.Opacity == 1.0) {
                            action = AlertForm.EnmAction.wait;
                        }
                    }
                    break;
                case EnmAction.close:
                    Timer.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0) {
                        base.Close();
                    }
                    break;
            }
        }

        #endregion

        #region Methods
        public void ShowAlert(string title, string body, EnmType type) {

            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++) {
                fname = "alert" + i.ToString();
                AlertForm frm = (AlertForm)Application.OpenForms[fname];

                if (frm == null) {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 7 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type) {
                case EnmType.Success:
                    this.IconPB.Image = Resources.SuccessAlert;
                    this.BackColor = Color.FromArgb(76, 175, 80);
                    break;
                case EnmType.Error:
                    this.IconPB.Image = Resources.ErrorAlert;
                    this.BackColor = Color.FromArgb(244, 67, 54);
                    break;
                case EnmType.Info:
                    this.IconPB.Image = Resources.InfoAlert;
                    this.BackColor = Color.FromArgb(33, 150, 243);
                    break;
                case EnmType.Warning:
                    this.IconPB.Image = Resources.WarningAlert;
                    this.BackColor = Color.FromArgb(255, 152, 0);
                    break;
            }

            this.TitleLbl.Text = title;
            this.BodyLbl.Text = body;

            this.Show();
            this.action = EnmAction.start;
            this.Timer.Interval = 1;
            this.Timer.Start();
        }

        #endregion

    }


}
