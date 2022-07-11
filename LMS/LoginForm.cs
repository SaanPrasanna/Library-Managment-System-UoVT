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

            MainForm mf = new MainForm();

            try {
                if (UsernameTB.Text != string.Empty && PasswordTB.Text != string.Empty) {

                    Functions fn = new Functions();
                    DataTable dt = fn.Authentication(username: UsernameTB.Text, password: PasswordTB.Text);

                    if (dt.Rows.Count == 1) {
                        MessageBox.Show("Access Granted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        mf.Show();
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
