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
using System.IO;
using static LMS.Utils.Core.Functions;

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
                EmailTB.Enabled = false;
                CategoryCb.Enabled = fn.IsStaff();
            }
        }

        #region Methods
        private void LoadData(string mid) {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try {
                string query = "SELECT fname, lname, address, email, telephone, password, category, renew_date, img, gender FROM members WHERE mid = @mid;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@mid", SqlDbType.VarChar, 13).Value = mid;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                CategoryCb.Text = table.Rows[0][6].ToString();
                ReNewDateTb.Text = DateTime.Parse(table.Rows[0][7].ToString()).ToString("yyyy-MM-dd");
                if (DateTime.Parse(table.Rows[0][7].ToString()) < DateTime.Now) {
                    if (fn.IsStaff()) { UpdateBtn.Visible = true; }
                }

                if (table.Rows[0][8] != DBNull.Value) {
                    MemoryStream ms = new MemoryStream((Byte[])table.Rows[0][8]);
                    ProfilePicPb.Image = Image.FromStream(ms);
                } else {
                    ProfilePicPb.Image = null;
                }

                if (table.Rows[0][9].ToString() == "M") {
                    MRb.Checked = true;
                } else if (table.Rows[0][9].ToString() == "F") {
                    FRb.Checked = true;
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

        public string CreatePassword() {
            int length = 10;
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
        #endregion

        #region Button Click
        private void ActionBtn_Click(object sender, EventArgs e) {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            if (MIDTb.Text != string.Empty && FnameTb.Text != string.Empty && LnameTb.Text != string.Empty
                && AddressTb.Text != string.Empty && CategoryCb.Text != string.Empty && !string.IsNullOrEmpty(EmailTB.Text)
                && !string.IsNullOrEmpty(PasswordTB.Text) && !string.IsNullOrEmpty(TelephoneTB.Text) && (MRb.Checked || FRb.Checked)) {
                if (fn.IsPhoneNumber(number: TelephoneTB.Text)) {
                    if (fn.IsEmail(email: EmailTB.Text)) {
                        if (fn.CheckPasswordStrength(password: PasswordTB.Text, needToReview: PasswordTB.Enabled)) {
                            if (ActionBtn.Text == "ADD MEMBER") {
                                if (fn.GetNumberOf(name: "Member by Email", value: EmailTB.Text) == 0) {
                                    try {

                                        string query = "INSERT INTO members VALUES(@mid, @fname, @lname, @address, @category, " +
                                            "@date, @time, @renewDate, @sid, @email, @password, @telephone, @isRemoved, @img, @gender);";

                                        SqlCommand cmd = new SqlCommand(query, conn);
                                        cmd.Parameters.Add("@mid", SqlDbType.VarChar, 6).Value = MIDTb.Text;
                                        cmd.Parameters.Add("@fname", SqlDbType.NVarChar, 50).Value = FnameTb.Text;
                                        cmd.Parameters.Add("@lname", SqlDbType.NVarChar, 50).Value = LnameTb.Text;
                                        cmd.Parameters.Add("@address", SqlDbType.VarChar, 100).Value = AddressTb.Text;
                                        cmd.Parameters.Add("@category", SqlDbType.VarChar, 10).Value = CategoryCb.Text;
                                        cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
                                        cmd.Parameters.Add("@time", SqlDbType.Time).Value = DateTime.Now.ToString("HH:mm:ss");
                                        cmd.Parameters.Add("@renewDate", SqlDbType.Date).Value = DateTime.Parse(ReNewDateTb.Text);
                                        cmd.Parameters.Add("@sid", SqlDbType.VarChar, 6).Value = Properties.Settings.Default.id;
                                        cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = EmailTB.Text;
                                        cmd.Parameters.Add("@password", SqlDbType.VarChar, 100).Value = fn.GetSHA1Hash(PasswordTB.Text);
                                        cmd.Parameters.Add("@telephone", SqlDbType.Char, 10).Value = TelephoneTB.Text;
                                        cmd.Parameters.Add("@isRemoved", SqlDbType.TinyInt).Value = 0;

                                        if (ProfilePicPb.Image != null) {
                                            ImageConverter converter = new ImageConverter();
                                            cmd.Parameters.Add("@img", SqlDbType.Image).Value = (byte[])converter.ConvertTo(ProfilePicPb.Image, typeof(byte[]));/*File.ReadAllBytes(ProfilePicPb.ImageLocation)*/
                                        } else {
                                            cmd.Parameters.Add("@img", SqlDbType.Image).Value = DBNull.Value;
                                        }
                                        cmd.Parameters.Add("@gender", SqlDbType.Char).Value = (MRb.Checked) ? "M" : "F";

                                        int rowCount = cmd.ExecuteNonQuery();
                                        if (rowCount > 0) {

                                            if (mf.MainDgv.ColumnCount == 0) {

                                                Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91), Color.FromArgb(94, 148, 255) };
                                                Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91), Color.FromArgb(94, 120, 255) };
                                                string[] names = { "Modify", "Remove", "Print Report" };

                                                dgv.GridButtons(dgv: mf.MainDgv, names: names, backColors: backColors, selectionColors: selectColors);
                                            }
                                            dgv.ShowGrid(dgv: mf.MainDgv, name: "Members");
                                            dgv.GridWidth(dgv: mf.MainDgv, widths: new int[] { 0, 0, 0, 150, 150, 200, 200, 250, 150, 150, 150 });

                                            this.Alert("Process Success!", "Member added successfully!", AlertForm.EnmType.Info);
                                            this.Close();
                                        }

                                    } catch (Exception ex) {
                                        this.Alert("Process Failed!", "Ohh, something going wrong!\nMember insertion failed!", AlertForm.EnmType.Error);
                                        Console.WriteLine("Error: " + ex.ToString());
                                    } finally {
                                        Console.ReadLine();
                                        conn.Close();
                                        conn.Dispose();
                                    }
                                } else {
                                    this.Alert("Error!", "Duplicate Email Found!\nTry again with different email address.", AlertForm.EnmType.Error);
                                }
                            } else if (ActionBtn.Text == "MODIFY MEMBER") {
                                try {

                                    string query = "UPDATE members SET fname = @fname, lname = @lname, address = @address, category = @category, " +
                                        "renew_date = @renewDate, email = @email, telephone = @telephone, password = @passowrd, img = @img, gender = @gender" +
                                        " WHERE mid = @mid;";

                                    SqlCommand cmd = new SqlCommand(query, conn);
                                    cmd.Parameters.Add("@fname", SqlDbType.NVarChar, 50).Value = FnameTb.Text;
                                    cmd.Parameters.Add("@lname", SqlDbType.NVarChar, 50).Value = LnameTb.Text;
                                    cmd.Parameters.Add("@address", SqlDbType.VarChar, 100).Value = AddressTb.Text;
                                    cmd.Parameters.Add("@category", SqlDbType.VarChar, 10).Value = CategoryCb.Text;
                                    cmd.Parameters.Add("@renewDate", SqlDbType.Date).Value = DateTime.Parse(ReNewDateTb.Text);
                                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = EmailTB.Text;
                                    cmd.Parameters.Add("@telephone", SqlDbType.Char, 10).Value = TelephoneTB.Text;
                                    cmd.Parameters.Add("@passowrd", SqlDbType.Char, 50).Value = (PasswordTB.Enabled == true) ? fn.GetSHA1Hash(PasswordTB.Text) : PasswordTB.Text;
                                    if (ProfilePicPb.Image != null) {
                                        ImageConverter converter = new ImageConverter();
                                        cmd.Parameters.Add("@img", SqlDbType.Image).Value = (byte[])converter.ConvertTo(ProfilePicPb.Image, typeof(byte[]));/*File.ReadAllBytes(ProfilePicPb.ImageLocation)*/
                                    } else {
                                        cmd.Parameters.Add("@img", SqlDbType.Image).Value = DBNull.Value;
                                    }
                                    cmd.Parameters.Add("@gender", SqlDbType.Char).Value = (MRb.Checked) ? "M" : "F";
                                    cmd.Parameters.Add("@mid", SqlDbType.VarChar, 6).Value = MIDTb.Text;

                                    int rowCount = cmd.ExecuteNonQuery();
                                    Console.WriteLine("Success");

                                    if (rowCount > 0) {

                                        if (mf.MainDgv.ColumnCount == 0) {

                                            Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91), Color.FromArgb(94, 148, 255) };
                                            Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91), Color.FromArgb(94, 120, 255) };
                                            string[] names = { "Modify", "Remove", "Print Report" };

                                            dgv.GridButtons(dgv: mf.MainDgv, names: names, backColors: backColors, selectionColors: selectColors);
                                        }
                                        dgv.ShowGrid(dgv: mf.MainDgv, name: "Members");
                                        dgv.GridWidth(dgv: mf.MainDgv, widths: new int[] { 0, 0, 0, 150, 150, 200, 200, 250, 150, 150, 150 });

                                        if (Properties.Settings.Default.id == MIDTb.Text) {
                                            mf.MemberDashboard(visible: true);
                                        }
                                        this.Alert("Process Success!", "Member updated successfully!", AlertForm.EnmType.Info);
                                        this.Close();
                                    }

                                } catch (Exception ex) {
                                    this.Alert("Process Failed!", "Ohh, something going wrong!\nMember updation failed!", AlertForm.EnmType.Error);
                                    Console.WriteLine("Error: " + ex.ToString());
                                } finally {
                                    Console.ReadLine();
                                    conn.Close();
                                    conn.Dispose();
                                }
                            }
                        } else {
                            this.Alert("Warning!", "Please enter Strong Password!", AlertForm.EnmType.Warning);
                        }
                    } else {
                        this.Alert("Warning!", "Please enter valid email address!", AlertForm.EnmType.Warning);
                    }
                } else {
                    this.Alert("Warning!", "Please enter valid Phone Number!", AlertForm.EnmType.Warning);
                }
            } else {
                this.Alert("Warning!", "Fields can't be empty!\nPlease fill all fields and submit again.!", AlertForm.EnmType.Warning);
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

        private void ChooseImgBtn_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog {
                Filter = "JPG Files(Files|*.jpg;*.jpeg;*.png;"
            };
            if (dialog.ShowDialog() == DialogResult.OK) {
                ProfilePicPb.ImageLocation = dialog.FileName.ToString();
            }
        }

        private void ClearImgBtn_Click(object sender, EventArgs e) {
            ProfilePicPb.Image = null;
        }

        private void MLbl_Click(object sender, EventArgs e) {
            MRb.Checked = true;
        }

        private void FLbl_Click(object sender, EventArgs e) {
            FRb.Checked = true;
        }

        private void PwBtn_Click(object sender, EventArgs e) {
            if (PwBtn.Text == "GENERATE") {
                PasswordTB.Text = CreatePassword();
            } else if (PwBtn.Text == "CHANGE") {
                PasswordTB.Text = string.Empty;
                PasswordTB.Enabled = true;
            }
            ShowPasswordSwitch.Enabled = true;
        }

        #endregion

        #region Special Key Events

        private void MemberActionsForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }


        private void ShowPasswordSwitch_CheckedChanged(object sender, EventArgs e) {
            PasswordTB.PasswordChar = ShowPasswordSwitch.Checked ? '\0' : '●';
        }

        private void TelephoneTB_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        #endregion
    }
}
