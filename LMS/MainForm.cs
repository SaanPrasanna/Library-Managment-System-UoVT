using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using LMS.Utils;
using System.Threading;
using Guna.UI2.WinForms;

namespace LMS {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

            // Fixed Taskbar issue
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            {
                var withBlock = Screen.PrimaryScreen.WorkingArea;
                this.SetBounds(withBlock.Left, withBlock.Top, withBlock.Width, withBlock.Height);
            }

            MainPanel.Hide();
            DashboardDetails();
        }

        private void DashboardBtn_Click(object sender, EventArgs e) {
            MainPanel.Hide();
            DashboardBtn.Checked = true;
            BooksBtn.Checked = false;
            MembersBtn.Checked = false;
            TitlePb.Image = Properties.Resources.Dashboard;
            TitleLbl.Text = "Dashboard Oveview";
            DashboardPanel.Show();
            DashboardDetails();
            FNameLbl.Text = Properties.Settings.Default.fname;
            UsernameLbl.Text = Properties.Settings.Default.username;
        }

        private void BooksBtn_Click(object sender, EventArgs e) {

            Functions fn = new Functions();
            GridControlSettings dgv = new GridControlSettings();

            DashboardPanel.Hide();
            MainPanel.Show();
            BooksBtn.Checked = true;
            Action2Btn.Visible = true;
            MangeBooksBtn.Checked = false;
            DashboardBtn.Checked = false;
            MembersBtn.Checked = false;
            StaffsBtn.Checked = false;
            TitlePb.Image = Properties.Resources.Books;
            SearchTb.PlaceholderText = "Search By Title";
            SearchTb.Text = string.Empty;
            TitleLbl.Text = "All Books";
            Title2Lbl.Text = "Total Books: " + fn.GetNumberOf(name: "books");
            RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt");

            ActionBtn.Text = "ADD BOOK";
            ActionBtn.FillColor = Color.FromArgb(77, 200, 86);
            ActionBtn.ForeColor = Color.FromArgb(255, 255, 255);

            Action2Btn.Text = "PUBLISHERS";
            DateTimePickers(isVisible: false);

            MainDgv.Refresh();
            if (MainDgv.ColumnCount == 0) {
                dgv.GridButtons(dgv: MainDgv);
            }
            dgv.ShowGrid(dgv: MainDgv, name: "Books");
            dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 250, 250, 100, 250, 100, 100 });
        }

        private void DashboardDetails() {
            Functions fn = new Functions();
            BooksLbl.Text = fn.GetNumberOf(name: "books").ToString();
            Guna2HtmlLabel[] labels = new[] { RecentUpdate1Lbl, RecentUpdate2Lbl, RecentUpdate3Lbl, RecentUpdate4Lbl, RecentUpdate5Lbl, RecentUpdate6Lbl };
            Array.ForEach(labels, x => { x.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt"); });
            MembersLbl.Text = fn.GetNumberOf(name: "members").ToString();
        }

        private void MainDgv_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            if (ActionBtn.Text == "ADD BOOK") {

                String isbn = MainDgv.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (e.ColumnIndex == 0) {

                    BooksActionsForm ab = new BooksActionsForm(form: this, title: "Modify Book", isbn: isbn);
                    ab.ShowDialog();

                } else if (e.ColumnIndex == 1) {

                    if (MessageBox.Show("Do you want to delete this book [" + isbn + "]?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No) {
                        SqlConnection conn = DBUtils.GetDBConnection();
                        conn.Open();
                        String query = "UPDATE books SET is_removed = @number WHERE isbn = @isbn;";

                        try {

                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.Add("@number", SqlDbType.TinyInt).Value = 1;
                            cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = isbn;

                            int rowCount = cmd.ExecuteNonQuery();
                            if (rowCount > 0) {

                                GridControlSettings dgv = new GridControlSettings();
                                Console.WriteLine(MainDgv.ColumnCount);

                                if (MainDgv.ColumnCount == 0) {
                                    dgv.GridButtons(dgv: MainDgv);
                                }
                                dgv.ShowGrid(dgv: MainDgv, name: "Books");
                                dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 250, 250, 100, 250, 100, 100 });
                                RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm tt");

                            } else {
                                MessageBox.Show("Something was going wrong!", "Exception Occure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        } catch (Exception ex) {
                            Console.WriteLine("Book Remove Error: " + ex.ToString());
                        } finally {
                            conn.Close();
                            conn.Dispose();
                            Console.Read();
                        }
                    }

                }
            } else if (ActionBtn.Text == "ADD MEMBER") {
                String mid = MainDgv.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (e.ColumnIndex == 0) {

                    MembersActionsForm membersForm = new MembersActionsForm(form: this, title: "Modify Member", mid: mid);
                    membersForm.ShowDialog();

                } else if (e.ColumnIndex == 1) {

                    if (MessageBox.Show("Do you want to delete this member [" + mid + "]?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No) {
                        SqlConnection conn = DBUtils.GetDBConnection();
                        conn.Open();
                        String query = "UPDATE members SET is_removed = @number WHERE mid = @mid;";

                        try {

                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.Add("@number", SqlDbType.TinyInt).Value = 1;
                            cmd.Parameters.Add("@mid", SqlDbType.VarChar, 13).Value = mid;

                            int rowCount = cmd.ExecuteNonQuery();
                            if (rowCount > 0) {

                                GridControlSettings dgv = new GridControlSettings();
                                Console.WriteLine(MainDgv.ColumnCount);

                                if (MainDgv.ColumnCount == 0) {
                                    dgv.GridButtons(dgv: MainDgv);
                                }
                                dgv.ShowGrid(dgv: MainDgv, name: "Members");
                                dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 200, 200, 250, 150, 150, 150 });

                            } else {
                                MessageBox.Show("Something was went wrong!", "Exception Occure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        } catch (Exception ex) {
                            Console.WriteLine("Member Removed Error: " + ex.ToString());
                        } finally {
                            conn.Close();
                            conn.Dispose();
                            Console.Read();
                        }
                    }
                }
            } else if (ActionBtn.Text == "ADD STAFF") {
                String sid = MainDgv.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (e.ColumnIndex == 0) {

                    StaffsActionsForm staffForm = new StaffsActionsForm(form: this, title: "Modify Staff", sid: sid);
                    staffForm.ShowDialog();

                } else if (e.ColumnIndex == 1) {

                    if (Properties.Settings.Default.accountType.ToLower() == "admin" && Properties.Settings.Default.sid != sid) {
                        if (MessageBox.Show("Do you want to delete this staff member [" + sid + "]?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No) {

                            Functions fn = new Functions();
                            SqlConnection conn = DBUtils.GetDBConnection();
                            conn.Open();
                            String query = "UPDATE staffs SET is_removed = @number WHERE sid = @sid;";

                            try {

                                SqlCommand cmd = new SqlCommand(query, conn);
                                cmd.Parameters.Add("@number", SqlDbType.TinyInt).Value = 1;
                                cmd.Parameters.Add("@sid", SqlDbType.VarChar, 6).Value = sid;

                                int rowCount = (Int32)cmd.ExecuteNonQuery();
                                if (rowCount > 0) {

                                    GridControlSettings dgv = new GridControlSettings();

                                    if (MainDgv.ColumnCount == 0) {
                                        dgv.GridButtons(dgv: MainDgv);
                                    }
                                    dgv.ShowGrid(dgv: MainDgv, name: "Staffs");
                                    dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 150, 150, 400, 200 });
                                    Title2Lbl.Text = "Total Staffs Members: " + fn.GetNumberOf(name: "staffs");

                                } else {
                                    MessageBox.Show("Something was went wrong!", "Exception Occur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            } catch (Exception ex) {
                                Console.WriteLine("Member Removed Error: " + ex.ToString());
                            } finally {
                                conn.Close();
                                conn.Dispose();
                                Console.Read();
                            }
                        }
                    } else if (Properties.Settings.Default.sid == sid && Properties.Settings.Default.accountType.ToLower() == "admin") {
                        MessageBox.Show("Sorry, you can't delete your account!", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else if (Properties.Settings.Default.accountType.ToLower() == "moderator") {
                        MessageBox.Show("You doesn't have permission to delete accounts!", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void MinimizeBtn_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            LoginForm lf = new LoginForm();
            this.Hide();
            this.Dispose();
            lf.Show();
        }

        private void MembersBtn_Click(object sender, EventArgs e) {
            Functions fn = new Functions();
            GridControlSettings dgv = new GridControlSettings();

            DashboardPanel.Hide();
            MainPanel.Show();
            MembersBtn.Checked = true;
            MangeBooksBtn.Checked = false;
            DashboardBtn.Checked = false;
            BooksBtn.Checked = false;
            StaffsBtn.Checked = false;
            Action2Btn.Visible = false;
            TitlePb.Image = Properties.Resources.Members;
            SearchTb.PlaceholderText = "Search By First Name";
            SearchTb.Text = string.Empty;
            TitleLbl.Text = "All Members";
            Title2Lbl.Text = "Total Members: " + fn.GetNumberOf(name: "members");
            RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt");
            ActionBtn.Text = "ADD MEMBER";
            ActionBtn.FillColor = Color.FromArgb(77, 200, 86);
            ActionBtn.ForeColor = Color.FromArgb(255, 255, 255);
            DateTimePickers(isVisible: false);

            MainDgv.Refresh();
            if (MainDgv.ColumnCount == 0) {
                dgv.GridButtons(dgv: MainDgv);
            }
            dgv.ShowGrid(dgv: MainDgv, name: "Members");
            dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 150, 200, 200, 250, 150, 150, 150 });

        }

        private void ActionBtn_Click(object sender, EventArgs e) {

            Functions fn = new Functions();

            switch (ActionBtn.Text) {
                case "ADD BOOK":
                    BooksActionsForm booksForm = new BooksActionsForm(form: this, title: "Add Book", "");
                    booksForm.ShowDialog();
                    break;
                case "ADD MEMBER":
                    MembersActionsForm membersForm = new MembersActionsForm(form: this, title: "Add Member", fn.GetID("Member"));
                    membersForm.ShowDialog();
                    break;
                case "ADD STAFF":
                    StaffsActionsForm staffsForm = new StaffsActionsForm(form: this, title: "Add Staff", fn.GetID("Staff"));
                    staffsForm.ShowDialog();
                    break;
            }
        }

        private void StaffsBtn_Click(object sender, EventArgs e) {

            Functions fn = new Functions();
            GridControlSettings dgv = new GridControlSettings();

            DashboardPanel.Hide();
            MainPanel.Show();
            StaffsBtn.Checked = true;
            MangeBooksBtn.Checked = false;
            MembersBtn.Checked = false;
            DashboardBtn.Checked = false;
            BooksBtn.Checked = false;
            Action2Btn.Visible = false;
            TitlePb.Image = Properties.Resources.Members;
            SearchTb.PlaceholderText = "Search By Username";
            SearchTb.Text = string.Empty;
            TitleLbl.Text = "All Staffs Members";
            Title2Lbl.Text = "Total Staffs Members: " + fn.GetNumberOf(name: "staffs");
            RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt");
            ActionBtn.Text = "ADD STAFF";
            ActionBtn.FillColor = Color.FromArgb(77, 200, 86);
            ActionBtn.ForeColor = Color.FromArgb(255, 255, 255);
            DateTimePickers(isVisible: false);

            if (MainDgv.ColumnCount == 0) {
                dgv.GridButtons(dgv: MainDgv);
            }
            dgv.ShowGrid(dgv: MainDgv, name: "Staffs");
            dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 150, 150, 400, 200 });

        }

        private void Action2Btn_Click(object sender, EventArgs e) {
            if (Action2Btn.Text == "PUBLISHERS") {
                PublishersForm publisherForm = new PublishersForm();
                publisherForm.ShowDialog();
            }
        }

        private void SearchTb_KeyUp(object sender, KeyEventArgs e) {

            GridControlSettings dgv = new GridControlSettings();

            if (ActionBtn.Text == "ADD BOOK") {
                dgv.ShowGrid(dgv: MainDgv, name: "Books", searchQuery: SearchTb.Text);
                dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 250, 250, 100, 250, 100, 100 });
            } else if (ActionBtn.Text == "ADD MEMBER") {
                dgv.ShowGrid(dgv: MainDgv, name: "Members", searchQuery: SearchTb.Text);
                dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 150, 200, 200, 250, 150, 150, 150 });
            } else if (ActionBtn.Text == "ADD STAFF") {
                dgv.ShowGrid(dgv: MainDgv, name: "Staffs", searchQuery: SearchTb.Text);
                dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 150, 150, 400, 200 });
            }
        }

        private void DateTimePickers(bool isVisible) {
            FromDtp.Visible = isVisible;
            ToDtp.Visible = isVisible;
            FromLbl.Visible = isVisible;
            ToLbl.Visible = isVisible;
        }

        private void MangeBooksBtn_Click(object sender, EventArgs e) {

            Functions fn = new Functions();
            GridControlSettings dgv = new GridControlSettings();

            DateTimePickers(isVisible: true);
            DashboardPanel.Hide();
            MainPanel.Show();
            MangeBooksBtn.Checked = true;
            StaffsBtn.Checked = false;
            MembersBtn.Checked = false;
            DashboardBtn.Checked = false;
            BooksBtn.Checked = false;
            Action2Btn.Visible = false;
            TitlePb.Image = Properties.Resources.Members;
            SearchTb.PlaceholderText = "Search By Name";
            SearchTb.Text = string.Empty;
            TitleLbl.Text = "Manage Books";
            Title2Lbl.Text = "Today Manage Books: " + fn.GetNumberOf(name: "staffs");
            RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt");
            ActionBtn.Text = "MANAGE BOOK";
            ActionBtn.FillColor = Color.FromArgb(248, 187, 0);
            ActionBtn.ForeColor = Color.FromArgb(255, 255, 255);
            DateTimePickers(isVisible: true);

            if (MainDgv.ColumnCount == 0) {
                dgv.GridButtons(dgv: MainDgv);
            }
            dgv.ShowGrid(dgv: MainDgv, name: "Staffs");
            dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 150, 150, 400, 200 });
        }
    }
}
