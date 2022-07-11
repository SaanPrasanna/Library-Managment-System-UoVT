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
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e) {
            //UsernameTB.Text = "Username  ";
            //PasswordTB.Text = "Password  ";

            //UsernameTB.GotFocus += UsernameRemoveText;
            //UsernameTB.LostFocus += UsernameAddText;
            //PasswordTB.GotFocus += PasswordRemoveText;
            //PasswordTB.LostFocus += PasswordAddText;
        }

        public void UsernameRemoveText(object sender, EventArgs e) {
            if (UsernameTB.Text == "Username  ") {
                UsernameTB.Text = "";
            }
        }

        public void PasswordRemoveText(object sender, EventArgs e) {
            if (PasswordTB.Text == "Password  ") {
                PasswordTB.Text = "";
                PasswordTB.PasswordChar = '●';
            }
        }

        public void UsernameAddText(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(UsernameTB.Text))
                UsernameTB.Text = "Username  ";
        }

        public void PasswordAddText(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(PasswordTB.Text)) {
                PasswordTB.Text = "Password  ";
                PasswordTB.PasswordChar = '\0';
            }

        }

        private void LoginBtn_Click(object sender, EventArgs e) {
            try {

                if (UsernameTB.Text != string.Empty && PasswordTB.Text != string.Empty) {
                    Functions fn = new Functions();
                    DataTable dt = fn.StaffAuthenticate(username: UsernameTB.Text, password: PasswordTB.Text);

                    // TODO: If credentials are wrong, show error message
                    // TODO: Redirection
                    Console.WriteLine(dt.Rows.Count);
                } else {
                    MessageBox.Show("Username and Password can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch (Exception ex) {
                // TODO: Error message
            } finally {
                Console.ReadLine();
            }
        }
    }
}
