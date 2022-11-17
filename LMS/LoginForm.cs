using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using LMS.Utils;

namespace LMS {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        protected override CreateParams CreateParams {
            get {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e) {

            // Need to Update Login Form UI

            try {
                if (UsernameTB.Text != string.Empty && PasswordTB.Text != string.Empty) {

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
                        MessageBox.Show("Access Denied!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } else {
                    MessageBox.Show("Username and Password can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch (Exception ex) {
                MessageBox.Show("Internal Error!\nError: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } finally {
                Console.ReadLine();
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                Environment.Exit(Environment.ExitCode);
                this.Close();
                this.Dispose();
            }
        }

        private void CloseBtn_Click_1(object sender, EventArgs e) {
            Environment.Exit(Environment.ExitCode);
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Do you want to exit!", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                this.Close();
                this.Dispose();
            }
        }
    }
}
