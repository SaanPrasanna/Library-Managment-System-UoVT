using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using Salaros.Configuration;
using LMS.Utils.Core;
using LMS.Utils.Connection;
using LMS.Screens.Widgets;

namespace LMS {
    public partial class MembersActionsForm : Form {

        MainForm mf;
        private readonly Functions fn = new Functions();
        private readonly GridControlSettings dgv = new GridControlSettings();
        private readonly ConfigParser config = new ConfigParser(Application.StartupPath + @"\settings.cnf");

        public MembersActionsForm(MainForm form, string title, string mid) {
            InitializeComponent();

            this.mf = form;
            TitleLbl.Text = title;
            ActionBtn.Text = title.ToUpper();
            MIDTb.Text = mid;

            if (title == "Add Member") {

                if (config.GetValue("Numbers", "RenewDate") == null) {
                    config.SetValue("Numbers", "RenewDate", 365);
                    config.Save();
                }

                ReNewDateTb.Text = DateTime.Now.AddDays(Convert.ToInt32(config.GetValue("Numbers", "RenewDate"))).ToString("yyyy-MM-dd");
                ActionBtn.FillColor = Color.FromArgb(77, 200, 86);
                PwBtn.Text = "GENERATE";
                PasswordTB.Enabled = true;
                ShowPasswordSwitch.Enabled = true;

            } else if (title == "Modify Member") {

                LoadData(mid: mid);

                ActionBtn.FillColor = Color.FromArgb(248, 187, 0);
                PwBtn.Text = "CHANGE";
                PasswordTB.Enabled = false;
                ShowPasswordSwitch.Enabled = false;

            }
        }

        private void LoadData(string mid) {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try {
                string query = "SELECT fname, lname, address, email, telephone, password, category, renew_date  FROM members WHERE mid = @mid;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@mid", SqlDbType.VarChar, 13).Value = mid;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                CategoryCb.Text = table.Rows[0][6].ToString();
                ReNewDateTb.Text = DateTime.Parse(table.Rows[0][7].ToString()).ToString("yyyy-MM-dd");
                if (DateTime.Parse(table.Rows[0][7].ToString()) < DateTime.Now) {
                    UpdateBtn.Visible = true; // TODO: Visible only Admins or moderator
                }

                Guna2TextBox[] tb = new[] { FnameTb, LnameTb, AddressTb, EmailTB, TelephoneTB, PasswordTB };
                foreach (var textBox in tb.Select((name, index) => (name, index))) {
                    textBox.name.Text = table.Rows[0][textBox.index].ToString();
                }

            } catch (Exception ex) {
                Console.WriteLine("Error: " + ex.ToString());
            } finally {
                Console.ReadLine();
                conn.Close();
                conn.Dispose();
            }
        }

        protected override CreateParams CreateParams {
            get {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void ActionBtn_Click(object sender, EventArgs e) {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            if (MIDTb.Text != string.Empty && FnameTb.Text != string.Empty && LnameTb.Text != string.Empty
                && AddressTb.Text != string.Empty && CategoryCb.Text != string.Empty && !string.IsNullOrEmpty(EmailTB.Text)
                && !string.IsNullOrEmpty(PasswordTB.Text) && !string.IsNullOrEmpty(TelephoneTB.Text)) {
                if (ActionBtn.Text == "ADD MEMBER") {

                    try {

                        string query = "INSERT INTO members VALUES(@mid, @fname, @lname, @address, @category, " +
                            "@date, @time, @renewDate, @sid, @email, @password, @telephone, @isRemoved);";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.Add("@mid", SqlDbType.VarChar, 6).Value = MIDTb.Text;
                        cmd.Parameters.Add("@fname", SqlDbType.NVarChar, 50).Value = FnameTb.Text;
                        cmd.Parameters.Add("@lname", SqlDbType.NVarChar, 50).Value = LnameTb.Text;
                        cmd.Parameters.Add("@address", SqlDbType.VarChar, 100).Value = AddressTb.Text;
                        cmd.Parameters.Add("@category", SqlDbType.VarChar, 10).Value = CategoryCb.Text;
                        cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
                        cmd.Parameters.Add("@time", SqlDbType.Time).Value = DateTime.Now.ToString("HH:mm:ss");
                        cmd.Parameters.Add("@renewDate", SqlDbType.Date).Value = DateTime.Parse(ReNewDateTb.Text);
                        cmd.Parameters.Add("@sid", SqlDbType.VarChar, 6).Value = Properties.Settings.Default.id; //Implemented
                        cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = EmailTB.Text;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar, 100).Value = PasswordTB.Text;
                        cmd.Parameters.Add("@telephone", SqlDbType.Char, 10).Value = TelephoneTB.Text;
                        cmd.Parameters.Add("@isRemoved", SqlDbType.TinyInt).Value = 0;

                        int rowCount = cmd.ExecuteNonQuery();
                        if (rowCount > 0) {

                            if (mf.MainDgv.ColumnCount == 0) {

                                Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91) };
                                Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91) };
                                string[] names = { "Modify", "Remove" };

                                dgv.GridButtons(dgv: mf.MainDgv, names: names, backColors: backColors, selectionColors: selectColors);
                                //dgv.GridButtons(dgv: mf.MainDgv);
                            }
                            dgv.ShowGrid(dgv: mf.MainDgv, name: "Members");
                            dgv.GridWidth(dgv: mf.MainDgv, widths: new int[] { 0, 0, 150, 200, 200, 250, 150, 150, 150 });

                            this.Alert("Information!", "Member added!", AlertForm.EnmType.Info);
                            //MessageBox.Show("Member added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                    } catch (Exception ex) {
                        this.Alert("Warning!", "Ohh, something going wrong!\nMember insertion failed!", AlertForm.EnmType.Error);
                        //MessageBox.Show("Member insertion failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Console.WriteLine("Error: " + ex.ToString());
                    } finally {
                        Console.ReadLine();
                        conn.Close();
                        conn.Dispose();
                    }

                } else if (ActionBtn.Text == "MODIFY MEMBER") {
                    try {

                        string query = "UPDATE members SET fname = @fname, lname = @lname, address = @address, category = @category, " +
                            "renew_date = @renewDate, email = @email, telephone = @telephone, password = @passowrd WHERE mid = @mid;";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.Add("@fname", SqlDbType.NVarChar, 50).Value = FnameTb.Text;
                        cmd.Parameters.Add("@lname", SqlDbType.NVarChar, 50).Value = LnameTb.Text;
                        cmd.Parameters.Add("@address", SqlDbType.VarChar, 100).Value = AddressTb.Text;
                        cmd.Parameters.Add("@category", SqlDbType.VarChar, 10).Value = CategoryCb.Text;
                        cmd.Parameters.Add("@renewDate", SqlDbType.Date).Value = DateTime.Parse(ReNewDateTb.Text);
                        cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = EmailTB.Text;
                        cmd.Parameters.Add("@telephone", SqlDbType.Char, 10).Value = TelephoneTB.Text;
                        cmd.Parameters.Add("@passowrd", SqlDbType.Char, 50).Value = (PasswordTB.Enabled == true) ? fn.GetSHA1Hash(PasswordTB.Text) : PasswordTB.Text;
                        cmd.Parameters.Add("@mid", SqlDbType.VarChar, 6).Value = MIDTb.Text;

                        int rowCount = cmd.ExecuteNonQuery();
                        if (rowCount > 0) {

                            if (mf.MainDgv.ColumnCount == 0) {

                                Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91) };
                                Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91) };
                                string[] names = { "Modify", "Remove" };

                                dgv.GridButtons(dgv: mf.MainDgv, names: names, backColors: backColors, selectionColors: selectColors);
                                //dgv.GridButtons(dgv: mf.MainDgv);
                            }
                            dgv.ShowGrid(dgv: mf.MainDgv, name: "Members");
                            dgv.GridWidth(dgv: mf.MainDgv, widths: new int[] { 0, 0, 150, 200, 200, 250, 150, 150, 150 });

                            this.Alert("Information!", "Member updated!", AlertForm.EnmType.Info);
                            //MessageBox.Show("Member updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                    } catch (Exception ex) {
                        this.Alert("Warning!", "Ohh, something going wrong!\nMember updation failed!", AlertForm.EnmType.Error);
                        //MessageBox.Show("Member updation failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Console.WriteLine("Error: " + ex.ToString());
                    } finally {
                        Console.ReadLine();
                        conn.Close();
                        conn.Dispose();
                    }
                }
            } else {
                this.Alert("Warning!", "Fields can't be empty!\nPlease fill all fields and submit again.!", AlertForm.EnmType.Warning);
                //MessageBox.Show("Fields can't be empty!\nPlease fill all fields and submit again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MemberActionsForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e) {
            if (config.GetValue("Numbers", "RenewDate") == null) {
                config.SetValue("Numbers", "RenewDate", 365);
                config.Save();
            }

            ReNewDateTb.Text = DateTime.Now.AddDays(Convert.ToInt32(config.GetValue("Numbers", "RenewDate"))).ToString("yyyy-MM-dd");
            UpdateBtn.Enabled = false;
        }
        private void PwBtn_Click(object sender, EventArgs e) {
            if (PwBtn.Text == "GENERATE") {
                PasswordTB.Text = CreatePassword();
            } else if (PwBtn.Text == "CHANGE") {
                PasswordTB.Text = string.Empty;
                PasswordTB.Enabled = true;
            }
        }

        private void ShowPasswordSwitch_CheckedChanged(object sender, EventArgs e) {
            PasswordTB.PasswordChar = ShowPasswordSwitch.Checked ? '\0' : '●';
        }

        public string CreatePassword() {
            int length = 7;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--) {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public void Alert(string title, string body, AlertForm.EnmType type) {
            AlertForm alertForm = new AlertForm();
            alertForm.ShowAlert(title: title, body: body, type: type);
        }
    }
}
