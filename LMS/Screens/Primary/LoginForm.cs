using LMS.Screens.Widgets;
using LMS.Utils.Core;
using System;
using System.Data;
using System.Windows.Forms;

namespace LMS.Screens.Primary {
    public partial class LoginForm : Form {

        private readonly Functions fn = new Functions();

        public LoginForm() {
            InitializeComponent();
        }

        #region Form Load
        private void Login_Load(object sender, EventArgs e) {
            guna2ShadowForm1.SetShadowForm(this);
        }
        #endregion Form Load

        #region Button Click
        private void LoginBtn_Click(object sender, EventArgs e) {
            try {
                if (UsernameTB.Text != string.Empty && PasswordTB.Text != string.Empty) {

                    DataTable dt = fn.Authentication(username: UsernameTB.Text, password: PasswordTB.Text);

                    if (dt.Rows.Count == 1) {

                        Properties.Settings.Default.sid = dt.Rows[0][0].ToString();
                        Properties.Settings.Default.username = dt.Rows[0][1].ToString();
                        Properties.Settings.Default.fname = dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString();
                        Properties.Settings.Default.accountType = dt.Rows[0][6].ToString();
                        this.Alert("Information!", "Access Granted for " + Properties.Settings.Default.fname + "!", AlertForm.EnmType.Info);

                        SplashForm splashForm = new SplashForm();
                        this.Hide();
                        splashForm.Show();

                    } else {
                        this.Alert("Warning!", "Invalid Username or Password!", AlertForm.EnmType.Warning);
                    }
                } else {
                    this.Alert("Warning!", "Username or Password can't be empty!", AlertForm.EnmType.Warning);
                }
            } catch (Exception ex) {
                this.Alert("Error", "Internal Error!", AlertForm.EnmType.Error);
            } finally {
                Console.ReadLine();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Do you want to exit!", "Login Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                this.Close();
                this.Dispose();
            }
        }

        private void InfoBtn_Click(object sender, EventArgs e) {
            // TODO
            this.Alert("Success Alert", "Testing Body here", AlertForm.EnmType.Info);
        }
        #endregion Button Click

        #region Key Events
        private void Login_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                if (MessageBox.Show("Do you want to exit!", "Login Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    Environment.Exit(Environment.ExitCode);
                    this.Close();
                    this.Dispose();
                }
            }
        }
        #endregion Key Events

        #region Methods
        public void Alert(string title, string body, AlertForm.EnmType type) {
            AlertForm alertForm = new AlertForm();
            alertForm.ShowAlert(title: title, body: body, type: type);
        }
        #endregion
    }
}
