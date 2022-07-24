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

namespace LMS {
    public partial class MembersActionsForm : Form {
        MainForm mf;
        public MembersActionsForm(MainForm form, string title, string mid) {
            InitializeComponent();

            this.mf = form;
            TitleLbl.Text = title;
            ActionBtn.Text = title.ToUpper();
            MIDTb.Text = mid;

            if (title == "Add Member") {
                ReNewDateTb.Text = DateTime.Now.AddDays(365).ToString("yyyy-MM-dd");
                ActionBtn.FillColor = Color.FromArgb(77, 200, 86);
            } else if (title == "Modify Member") {
                LoadData(mid: mid);

                ActionBtn.FillColor = Color.FromArgb(249, 217, 55);
            }
        }

        private void LoadData(string mid) {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try {
                string query = "SELECT fname, lname, address, category, renew_date  FROM members WHERE mid = @mid;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@mid", SqlDbType.VarChar, 13).Value = mid;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                CategoryCb.Text = table.Rows[0][3].ToString();
                ReNewDateTb.Text = DateTime.Parse(table.Rows[0][4].ToString()).ToString("yyyy-MM-dd");
                if (DateTime.Parse(table.Rows[0][4].ToString()) < DateTime.Now) {
                    UpdateBtn.Visible = true;
                }

                Guna2TextBox[] tb = new[] { FnameTb, LnameTb, AddressTb };
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
                && AddressTb.Text != string.Empty && CategoryCb.Text != string.Empty) {
                if (ActionBtn.Text == "ADD MEMBER") {

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

                } else if (ActionBtn.Text == "MODIFY MEMBER") {
                    try {

                        string query = "UPDATE members SET fname = @fname, lname = @lname, address = @address, category = @category, " +
                            "renew_date = @renewDate WHERE mid = @mid;";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.Add("@fname", SqlDbType.NVarChar, 50).Value = FnameTb.Text;
                        cmd.Parameters.Add("@lname", SqlDbType.NVarChar, 50).Value = LnameTb.Text;
                        cmd.Parameters.Add("@address", SqlDbType.VarChar, 100).Value = AddressTb.Text;
                        cmd.Parameters.Add("@category", SqlDbType.VarChar, 10).Value = CategoryCb.Text;
                        cmd.Parameters.Add("@renewDate", SqlDbType.Date).Value = DateTime.Parse(ReNewDateTb.Text);
                        cmd.Parameters.Add("@mid", SqlDbType.VarChar, 6).Value = MIDTb.Text;

                        int rowCount = cmd.ExecuteNonQuery();
                        if (rowCount > 0) {

                            GridControlSettings dgv = new GridControlSettings();

                            if (mf.MainDgv.ColumnCount == 0) {
                                dgv.GridButtons(dgv: mf.MainDgv);
                            }
                            dgv.ShowGrid(dgv: mf.MainDgv, name: "Members");
                            dgv.GridWidth(dgv: mf.MainDgv, widths: new int[] { 0, 0, 150, 200, 200, 250, 150, 150, 150 });

                            MessageBox.Show("Member updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                    } catch (Exception ex) {
                        MessageBox.Show("Member updation failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void MemberActionsForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e) {
            ReNewDateTb.Text = DateTime.Now.AddDays(365).ToString("yyyy-MM-dd");
            UpdateBtn.Enabled = false;
        }
    }
}
