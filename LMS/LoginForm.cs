using System;
using System.Data;
using System.Windows.Forms;
using LMS.Utils;

namespace LMS {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        #region Button Click
        private void LoginBtn_Click(object sender, EventArgs e) {

            // Need to Update Login Form UI

            try {
                // Check the Username and Password are not empty!
                if (UsernameTB.Text != string.Empty && PasswordTB.Text != string.Empty) {

                    // Create a object to Functions.cs 
                    Functions fn = new Functions();
                    DataTable dt = fn.Authentication(username: UsernameTB.Text, password: PasswordTB.Text);

                    if (dt.Rows.Count == 1) {

                        MessageBox.Show("Access Granted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SplashForm splashForm = new SplashForm();
                        Properties.Settings.Default.sid = dt.Rows[0][0].ToString();
                        Properties.Settings.Default.username = dt.Rows[0][1].ToString();
                        Properties.Settings.Default.fname = dt.Rows[0][3].ToString();
                        Properties.Settings.Default.accountType = dt.Rows[0][6].ToString();
                        this.Hide();
                        splashForm.Show();

                    } else {
                        // Wrong username or Password
                        MessageBox.Show("Access Denied!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } else {
                    MessageBox.Show("Username or Password can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch (Exception ex) {
                MessageBox.Show("Internal Error!\nError: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } finally {
                Console.ReadLine();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Do you want to exit!", "Login Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                this.Close();
                this.Dispose();
            }
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
        protected override CreateParams CreateParams {
            get {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        #endregion Methods
    }
}
