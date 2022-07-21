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
        }

        private void BooksBtn_Click(object sender, EventArgs e) {

            Functions fn = new Functions();
            GridControlSettings dgv = new GridControlSettings();

            DashboardPanel.Hide();
            MainPanel.Show();
            BooksBtn.Checked = true;
            DashboardBtn.Checked = false;
            MembersBtn.Checked = false;
            TitlePb.Image = Properties.Resources.Books;
            TitleLbl.Text = "All Books";
            Title2Lbl.Text = "Total Books: " + fn.GetNumberOfBooks();
            RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm tt");
            ActionBtn.Text = "ADD BOOK";
            ActionBtn.FillColor = Color.FromArgb(77, 200, 86);
            ActionBtn.ForeColor = Color.FromArgb(255, 255, 255);

            if (MainDgv.ColumnCount < 9) {
                dgv.GridButtons(dgv: MainDgv);
            }
            dgv.ShowGrid(dgv: MainDgv, name: "Books");
            dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 250, 250, 100, 250, 100, 100 });
        }

        private void DashboardDetails() {
            Functions fn = new Functions();
            BooksLbl.Text = fn.GetNumberOfBooks().ToString();
            Guna2HtmlLabel[] labels = new[] { RecentUpdate1Lbl, RecentUpdate2Lbl, RecentUpdate3Lbl, RecentUpdate4Lbl, RecentUpdate5Lbl, RecentUpdate6Lbl };
            Array.ForEach(labels, x => { x.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt"); });
            MembersLbl.Text = fn.GetNumberOfMembers().ToString();
        }

        private void MainDgv_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            if (ActionBtn.Text == "ADD BOOK") {

                String isbn = MainDgv.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (e.ColumnIndex == 0) {

                    BooksActionsForm ab = new BooksActionsForm(form: this, title: "Modify Book", isbn: isbn);
                    ab.ShowDialog();

                } else if (e.ColumnIndex == 1) {

                    if (MessageBox.Show("Do you want to delete this book[" + isbn + "]?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No) {
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

                                if (MainDgv.ColumnCount < 9) {
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
                    /*

                        if (MessageBox.Show("Do you want to delete this book[" + isbn + "]?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No) {
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

                                    if (MainDgv.ColumnCount < 9) {
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

                    */
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
            DashboardBtn.Checked = false;
            BooksBtn.Checked = false;
            MembersBtn.Checked = true;
            TitlePb.Image = Properties.Resources.Members;
            TitleLbl.Text = "All Members";
            Title2Lbl.Text = "Total Members: " + fn.GetNumberOfMembers();
            RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm tt");
            ActionBtn.Text = "ADD MEMBER";
            ActionBtn.FillColor = Color.FromArgb(77, 200, 86);
            ActionBtn.ForeColor = Color.FromArgb(255, 255, 255);


            if (MainDgv.ColumnCount < 8) {
                dgv.GridButtons(dgv: MainDgv);
            }
            dgv.ShowGrid(dgv: MainDgv, name: "Members");
            dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 200, 200, 250, 150, 150, 150 });

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
            }
        }

        private void StaffsBtn_Click(object sender, EventArgs e) {
            //check
            Functions fn = new Functions();
            GridControlSettings dgv = new GridControlSettings();

            DashboardPanel.Hide();
            MainPanel.Show();
            StaffsBtn.Checked = true;
            MembersBtn.Checked = false;
            DashboardBtn.Checked = false;
            BooksBtn.Checked = false;
            TitlePb.Image = Properties.Resources.Members;
            TitleLbl.Text = "All Staffs Members";
            Title2Lbl.Text = "Total Staffs Members: " + fn.GetNumberOfMembers();
            RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm tt");
            ActionBtn.Text = "ADD STAFF";
            ActionBtn.FillColor = Color.FromArgb(77, 200, 86);
            ActionBtn.ForeColor = Color.FromArgb(255, 255, 255);


            if (MainDgv.ColumnCount < 8) {
                dgv.GridButtons(dgv: MainDgv);
            }
            dgv.ShowGrid(dgv: MainDgv, name: "Staffs");
            dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 200, 200, 250, 150, 150, 150 });

        }
    }
}
