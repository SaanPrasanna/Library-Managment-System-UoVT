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

        private void LoginBtn_Click(object sender, EventArgs e) {

            // Need to Update Login Form UI
            SplashForm splashForm = new SplashForm();

            try {
                if (UsernameTB.Text != string.Empty && PasswordTB.Text != string.Empty) {

                    Functions fn = new Functions();
                    DataTable dt = fn.Authentication(username: UsernameTB.Text, password: PasswordTB.Text);

                    if (dt.Rows.Count == 1) {

                        MessageBox.Show("Access Granted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void CloseBtn_Click(object sender, EventArgs e) {
            Environment.Exit(Environment.ExitCode);
            this.Close();
            this.Dispose();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                Environment.Exit(Environment.ExitCode);
                this.Close();
                this.Dispose();
            }
        }
    }
}
