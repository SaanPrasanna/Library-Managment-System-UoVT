using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using LMS.Utils;
using Guna.UI2.WinForms;
using LMS.Utils.Core;
using LMS.Utils.Connection;

namespace LMS {
    public partial class StaffsActionsForm : Form {
        MainForm mf;
        private readonly Functions fn = new Functions();
        private readonly GridControlSettings dgv = new GridControlSettings();

        public StaffsActionsForm(MainForm form, string title, string sid) {
            InitializeComponent();

            this.mf = form;
            TitleLbl.Text = title;
            ActionBtn.Text = title.ToUpper();
            SIDTb.Text = sid;

            if (title == "Add Staff") {
                ActionBtn.FillColor = Color.FromArgb(77, 200, 86);
            } else if (title == "Modify Staff") {
                LoadData(sid: sid);
                ChangeBtn.Visible = true;
                PasswordTb.Enabled = false;
                UsernameTb.Enabled = false;
                ActionBtn.FillColor = Color.FromArgb(248, 187, 0);
                TypeCb.Enabled = Properties.Settings.Default.id != SIDTb.Text;
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

        private void LoadData(string sid) {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try {
                string query = "SELECT username, password, fname, lname, address, type FROM staffs WHERE sid = @sid;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@sid", SqlDbType.VarChar, 6).Value = sid;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                Guna2TextBox[] tb = new[] { UsernameTb, PasswordTb, FnameTb, LnameTb, AddressTb };
                foreach (var textBox in tb.Select((name, index) => (name, index))) {
                    textBox.name.Text = table.Rows[0][textBox.index].ToString();
                }
                TypeCb.Text = table.Rows[0][5].ToString();

            } catch (Exception ex) {
                Console.WriteLine("Error: " + ex.ToString());
            } finally {
                Console.ReadLine();
                conn.Close();
                conn.Dispose();
            }
        }

        private void ActionBtn_Click(object sender, EventArgs e) {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            if (SIDTb.Text != string.Empty && UsernameTb.Text != string.Empty && PasswordTb.Text != string.Empty && FnameTb.Text != string.Empty && LnameTb.Text != string.Empty
                && AddressTb.Text != string.Empty && TypeCb.Text != string.Empty) {
                if (ActionBtn.Text == "ADD STAFF") {

                    try {

                        string query = "INSERT INTO staffs VALUES(@sid, @username, @password, @fname, @lname, " +
                            "@address, @type, @isRemoved);";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.Add("@sid", SqlDbType.VarChar, 6).Value = SIDTb.Text;
                        cmd.Parameters.Add("@username", SqlDbType.VarChar, 20).Value = UsernameTb.Text;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = fn.GetSHA1Hash(PasswordTb.Text);
                        cmd.Parameters.Add("@fname", SqlDbType.NVarChar, 25).Value = FnameTb.Text;
                        cmd.Parameters.Add("@lname", SqlDbType.NVarChar, 25).Value = LnameTb.Text;
                        cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = AddressTb.Text;
                        cmd.Parameters.Add("@type", SqlDbType.VarChar, 10).Value = TypeCb.Text;
                        cmd.Parameters.Add("@isRemoved", SqlDbType.TinyInt).Value = 0;

                        int rowCount = (Int32)cmd.ExecuteNonQuery();
                        if (rowCount > 0) {

                            if (mf.MainDgv.ColumnCount == 0) {

                                Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91) };
                                Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91) };
                                string[] names = { "Modify", "Remove" };

                                dgv.GridButtons(dgv: mf.MainDgv, names: names, backColors: backColors, selectionColors: selectColors);
                                //dgv.GridButtons(dgv: mf.MainDgv);
                            }
                            dgv.ShowGrid(dgv: mf.MainDgv, name: "Staffs");
                            dgv.GridWidth(dgv: mf.MainDgv, widths: new int[] { 0, 0, 150, 150, 150, 400, 200 });
                            mf.Title2Lbl.Text = "Total Staffs Members: " + fn.GetNumberOf(name: "staffs");

                            MessageBox.Show("Member added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                    } catch (Exception ex) {
                        MessageBox.Show("Member insertion failed!\nProbably username already exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Console.WriteLine("Error: " + ex.ToString());
                    } finally {
                        Console.ReadLine();
                        conn.Close();
                        conn.Dispose();
                    }

                } else if (ActionBtn.Text == "MODIFY STAFF") {

                    try {

                        string query = "UPDATE staffs SET password = @password, fname = @fname, lname = @lname, address = @address, type = @type WHERE sid = @sid;";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = (PasswordTb.Enabled == true) ? fn.GetSHA1Hash(PasswordTb.Text) : PasswordTb.Text;
                        cmd.Parameters.Add("@fname", SqlDbType.NVarChar, 25).Value = FnameTb.Text;
                        cmd.Parameters.Add("@lname", SqlDbType.NVarChar, 25).Value = LnameTb.Text;
                        cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = AddressTb.Text;
                        cmd.Parameters.Add("@type", SqlDbType.VarChar, 10).Value = TypeCb.Text;
                        cmd.Parameters.Add("@sid", SqlDbType.VarChar, 6).Value = SIDTb.Text;

                        int rowCount = (Int32)cmd.ExecuteNonQuery();
                        if (rowCount > 0) {

                            GridControlSettings dgv = new GridControlSettings();

                            if (mf.MainDgv.ColumnCount == 0) {

                                Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91) };
                                Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91) };
                                string[] names = { "Modify", "Remove" };

                                dgv.GridButtons(dgv: mf.MainDgv, names: names, backColors: backColors, selectionColors: selectColors);
                                //dgv.GridButtons(dgv: mf.MainDgv);
                            }
                            dgv.ShowGrid(dgv: mf.MainDgv, name: "Staffs");
                            dgv.GridWidth(dgv: mf.MainDgv, widths: new int[] { 0, 0, 150, 150, 150, 400, 200 });

                            if (Properties.Settings.Default.id == SIDTb.Text) {
                                Properties.Settings.Default.id = SIDTb.Text;
                                mf.FullNameLbl.Text = FnameTb.Text + " " + LnameTb.Text;
                            }
                            MessageBox.Show("Staff updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                    } catch (Exception ex) {
                        MessageBox.Show("Staff updation failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Console.WriteLine("Error: " + ex.ToString());
                    } finally {
                        Console.ReadLine();
                        conn.Close();
                        conn.Dispose();
                    }

                }
            } else {
                MessageBox.Show("Fields can't be empty!\nPlease fill all fields and submit again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void StaffsActionsForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void ChangeBtn_Click(object sender, EventArgs e) {
            PasswordTb.Enabled = true;
            PasswordTb.Text = String.Empty;
            PasswordLbl.Text = "New Password";
            ChangeBtn.Visible = false;
        }
    }
}
