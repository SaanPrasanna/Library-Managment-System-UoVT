using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LMS.Utils;
using Guna.UI2.WinForms;
using System.Security.Cryptography;

namespace LMS {
    public partial class StaffsActionsForm : Form {
        MainForm mf;
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
                ActionBtn.FillColor = Color.FromArgb(249, 217, 55);
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

                    /*
                    try {

                        string query = "INSERT INTO members VALUES(@mid, @fname, @lname, @address, @category, " +
                            "@date, @time, @renewDate, @sid, @isRemoved);";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.Add("@mid", SqlDbType.VarChar, 6).Value = MIDTb.Text;
                        cmd.Parameters.Add("@fname", SqlDbType.NVarChar, 50).Value = FnameTb.Text;
                        cmd.Parameters.Add("@lname", SqlDbType.NVarChar, 50).Value = LnameTb.Text;
                        cmd.Parameters.Add("@address", SqlDbType.VarChar, 100).Value = AddressTb.Text;
                        cmd.Parameters.Add("@category", SqlDbType.VarChar, 10).Value = CategoryCb.Text;
                        cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
                        cmd.Parameters.Add("@time", SqlDbType.Time).Value = DateTime.Now.ToString("HH:mm:ss");
                        cmd.Parameters.Add("@renewDate", SqlDbType.Date).Value = DateTime.Parse(ReNewDateTb.Text);
                        cmd.Parameters.Add("@sid", SqlDbType.VarChar, 6).Value = "S00001"; // TODO: After all functionalities are completed
                        cmd.Parameters.Add("@isRemoved", SqlDbType.TinyInt).Value = 0;

                        int rowCount = cmd.ExecuteNonQuery();
                        if (rowCount > 0) {

                            GridControlSettings dgv = new GridControlSettings();

                            if (mf.MainDgv.ColumnCount == 0) {
                                dgv.GridButtons(dgv: mf.MainDgv);
                            }
                            dgv.ShowGrid(dgv: mf.MainDgv, name: "Members");
                            dgv.GridWidth(dgv: mf.MainDgv, widths: new int[] { 0, 0, 150, 200, 200, 250, 150, 150, 150 });

                            MessageBox.Show("Member added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                    } catch (Exception ex) {
                        MessageBox.Show("Member insertion failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Console.WriteLine("Error: " + ex.ToString());
                    } finally {
                        Console.ReadLine();
                        conn.Close();
                        conn.Dispose();
                    }
                    */

                } else if (ActionBtn.Text == "MODIFY STAFF") {

                    try {

                        Functions fn = new Functions();
                        string query = "UPDATE staffs SET password = @password, fname = @fname, lname = @lname, address = @address, type = @type WHERE sid = @sid;";
                        string password = PasswordTb.Text;

                        if(PasswordTb.Enabled == true) {
                            password = fn.GetSHA1Hash(password);
                        }

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = password;
                        cmd.Parameters.Add("@fname", SqlDbType.NVarChar, 25).Value = FnameTb.Text;
                        cmd.Parameters.Add("@lname", SqlDbType.NVarChar, 25).Value = LnameTb.Text;
                        cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = AddressTb.Text;
                        cmd.Parameters.Add("@type", SqlDbType.VarChar, 10).Value = TypeCb.Text;
                        cmd.Parameters.Add("@sid", SqlDbType.VarChar, 6).Value = SIDTb.Text;

                        int rowCount = (Int32)cmd.ExecuteNonQuery();
                        if (rowCount > 0) {

                            GridControlSettings dgv = new GridControlSettings();

                            if (mf.MainDgv.ColumnCount == 0) {
                                dgv.GridButtons(dgv: mf.MainDgv);
                            }
                            dgv.ShowGrid(dgv: mf.MainDgv, name: "Staffs");
                            dgv.GridWidth(dgv: mf.MainDgv, widths: new int[] { 0, 0, 150, 150, 150, 400, 200 });

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
