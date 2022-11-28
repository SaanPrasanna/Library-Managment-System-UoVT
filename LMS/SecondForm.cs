using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Utils;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Guna.UI2.WinForms;

namespace LMS {
    public partial class SecondForm : Form {

        MainForm mf;
        BorrowBooksForm bbf;
        private string title, name, mID;
        public int NOB;
        readonly Functions fn = new Functions();
        readonly GridControlSettings dgv = new GridControlSettings();

        public SecondForm([Optional] MainForm form, [Optional] BorrowBooksForm bbf, [Optional] string title) {
            InitializeComponent();
            this.mf = form;
            this.bbf = bbf;
            this.title = title;
            InitialForm();
        }

        protected override CreateParams CreateParams {
            get {
                const int CS_DROPSHADOW = 0x00020000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void InitialForm() {
            RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt");
            SearchTb.PlaceholderText = "Search By Name";

            if (title == "Publishers") {

                Publishers();

                TitleLbl.Text = "Publishers";
                Title2Lbl.Text = "Total Publishers : " + fn.GetNumberOf(name: "Publishers").ToString();
                ActionBtn.Text = "ADD PUBLISHER";

            } else if (title == "Pending List") {

                PendingList();

                TitleLbl.Text = title;
                Title2Lbl.Text = "Total Pending Books : " + fn.GetNumberOf(name: "Pending Books").ToString();
                ActionBtn.Visible = false;
            } else if (title == "Choose Member") {

                Members();

                TitleLbl.Text = title;
                Title2Lbl.Text = "Total Members : " + fn.GetNumberOf(name: "Members").ToString();
                ActionBtn.Visible = false;
            } else if (title == "Choose Books") {

                Books();

                TitleLbl.Text = title;
                Title2Lbl.Text = "Total Books : " + fn.GetNumberOf(name: "Books").ToString();
                ActionBtn.Visible = false;
            }
        }
        #region Environment Change
        private void SecoundDgv_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            if (TitleLbl.Text == "Publishers") {

                String pid = SecondDgv.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (e.ColumnIndex == 0) {
                    PublishersActionsForm publisher = new PublishersActionsForm(form: this, title: "Modify Publisher", pid: pid);
                    publisher.ShowDialog();
                } else if (e.ColumnIndex == 1) {
                    MessageBox.Show("Publishers removed forbidden!", "Disabled Function", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            } else if (TitleLbl.Text == "Pending List") {

                this.mID = SecondDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                name = SecondDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                NOB = Convert.ToInt32(SecondDgv.Rows[e.RowIndex].Cells[3].Value);

                if (e.ColumnIndex == 0) {

                    PendingBooks();

                    TitleLbl.Text = "Pending Books";
                    Title2Lbl.Text = name + "'s Book(s) : " + NOB.ToString();
                    ActionBtn.Text = "RELEASE";
                    SearchTb.Text = string.Empty;
                }

            } else if (TitleLbl.Text == "Pending Books") {
                string refNo = SecondDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                string isbn = SecondDgv.Rows[e.RowIndex].Cells[3].Value.ToString();

                if (e.ColumnIndex == 0) {
                    BooksAcceptForm baf = new BooksAcceptForm(this, new string[] { refNo, isbn, mID, name, NOB.ToString() }); // 0 - RefNo, 1 - ISBN, 2 - MemberID
                    baf.ShowDialog();
                } else if (e.ColumnIndex == 1) {
                    if (MessageBox.Show("Do you want to extend for 1 Week(7 Days)?", "Extend Date", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {

                        SqlConnection conn = DBUtils.GetDBConnection();
                        conn.Open();

                        try {

                            string query = "UPDATE borrow_books SET due_date = @dueDate WHERE refno = @refNo AND mid = @mid AND isbn = @isbn;";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.Add("@dueDate", SqlDbType.Date).Value = fn.GetDueDate(refNo, isbn, mID).AddDays(7);
                            cmd.Parameters.Add("@refNo", SqlDbType.VarChar, 12).Value = refNo;
                            cmd.Parameters.Add("@mid", SqlDbType.VarChar, 6).Value = mID;
                            cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = isbn;


                            if (cmd.ExecuteNonQuery() > 0) {
                                PendingBooks();
                                MainGridRefresh();
                            }

                        } catch (Exception ex) {
                            Console.WriteLine("Error: " + ex.ToString());
                        } finally {
                            conn.Close();
                            conn.Dispose();
                            Console.ReadLine();
                        }
                    }
                }
            } else if (title == "Choose Member") {
                if (e.ColumnIndex == 0) {

                    bbf.MemberIDLbl.Text = SecondDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                    bbf.MemberNameLbl.Text = SecondDgv.Rows[e.RowIndex].Cells[2].Value.ToString();

                    SearchTb.Text = string.Empty;
                    bbf.MemberBtn.Enabled = false;
                    bbf.BooksBtn.Enabled = true;

                    this.Close();
                }
            } else if (title == "Choose Books") {
                string isbn = SecondDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (e.ColumnIndex == 0) {
                    if (!fn.IsAlreadyAdd(isbn)) {
                        if (Convert.ToInt32(SecondDgv.Rows[e.RowIndex].Cells[4].Value) > 0) {
                            SqlConnection conn = DBUtils.GetDBConnection();
                            conn.Open();
                            try {

                                string query = "INSERT INTO borrow_temp VALUES(@id, @isbn, @mid, '0');";
                                SqlCommand cmd = new SqlCommand(query, conn);
                                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(fn.GetID("Temp"));
                                cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = isbn;
                                cmd.Parameters.Add("@mid", SqlDbType.VarChar, 13).Value = bbf.MemberIDLbl.Text;
                                if (cmd.ExecuteNonQuery() > 0) {
                                    bbf.BorrowBtn.Enabled = true;
                                    bbf.ClearAllBtn.Enabled = true;
                                }

                            } catch (Exception ex) {
                                Console.WriteLine("Error: || Choose Memeber || \n" + ex.ToString());
                            } finally {
                                conn.Close();
                                conn.Dispose();
                            }
                            BorrowGridRefresh();

                            if (fn.GetNumberOf("Temp Books") >= 2) { // TODO: Properties.Settings.Default.NOB | Maximum number of books

                                SearchTb.Text = string.Empty;
                                bbf.BooksBtn.Enabled = false;

                                this.Close();
                            }
                        } else {
                            MessageBox.Show("Sorry!\n" + SecondDgv.Rows[e.RowIndex].Cells[2].Value.ToString() + " all books are empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    } else {
                        MessageBox.Show(SecondDgv.Rows[e.RowIndex].Cells[2].Value.ToString() + " is already added!", "Choose Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        #endregion Environment Change

        private void ActionBtn_Click(object sender, EventArgs e) {

            Functions fn = new Functions();
            if (ActionBtn.Text == "ADD PUBLISHER") {
                PublishersActionsForm publisherForm = new PublishersActionsForm(form: this, title: "Add Publisher", fn.GetID(name: "Publisher"));
                publisherForm.ShowDialog();
            }
        }

        private void SearchTb_KeyUp(object sender, KeyEventArgs e) {

            if (ActionBtn.Text == "ADD PUBLISHER") {
                Publishers();
            } else if (TitleLbl.Text == "Pending List") {
                PendingList();
            } else if (TitleLbl.Text == "Pending Books") {
                PendingBooks();
            } else if (title == "Choose Member") {
                Members();
            } else if (title == "Choose Books") {
                Books();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void PublishersForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {

                if (mf != null) {
                    MainGridRefresh();
                } else {
                    BorrowGridRefresh();
                }

                if (ActionBtn.Text == "RELEASE") {

                    PendingList();

                    TitleLbl.Text = title;
                    Title2Lbl.Text = "Total Pending Books : " + fn.GetNumberOf(name: "Pending Books").ToString();
                    ActionBtn.Text = "SAMPLE TEXT";
                    SearchTb.Text = string.Empty;

                } else {
                    this.Close();
                }
            }
        }

        #region Grid Methods
        public void PendingBooks() {

            SecondDgv.Columns.Clear();
            if (SecondDgv.ColumnCount == 0) {

                Color[] backColors = { Color.FromArgb(94, 148, 255), Color.FromArgb(77, 200, 86) };
                Color[] selectColors = { Color.FromArgb(120, 160, 255), Color.FromArgb(98, 222, 107) };
                string[] names = { "Release", "Extend" };

                dgv.GridButtons(dgv: SecondDgv, names: names, backColors: backColors, selectionColors: selectColors);

            }

            dgv.ShowGrid(dgv: SecondDgv, name: "Pending Books", searchQuery: SearchTb.Text, searchQuery2: this.mID);
            dgv.GridWidth(dgv: SecondDgv, widths: new int[] { 0, 0, 110, 150, 200, 150, 150 });
        }

        public void PendingList() {

            SecondDgv.Columns.Clear();
            if (SecondDgv.ColumnCount == 0) {

                Color[] backColors = { Color.FromArgb(77, 200, 86) };
                Color[] selectColors = { Color.FromArgb(98, 222, 107) };
                string[] names = { "Select Member" };

                dgv.GridButtons(dgv: SecondDgv, names: names, backColors: backColors, selectionColors: selectColors);

            }

            dgv.ShowGrid(dgv: SecondDgv, name: "Pending Members", searchQuery: SearchTb.Text);
            dgv.GridWidth(dgv: SecondDgv, widths: new int[] { 0, 150, 200, 200 });
        }

        public void Publishers() {

            SecondDgv.Columns.Clear();
            if (SecondDgv.ColumnCount == 0) {

                Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91) };
                Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91) };
                string[] names = { "Modify", "Remove" };

                dgv.GridButtons(dgv: SecondDgv, names: names, backColors: backColors, selectionColors: selectColors);

            }

            dgv.ShowGrid(dgv: SecondDgv, name: "Publishers");
            dgv.GridWidth(dgv: SecondDgv, widths: new int[] { 0, 0, 150, 200, 150 });
        }

        public void Members() {

            SecondDgv.Columns.Clear();
            if (SecondDgv.ColumnCount == 0) {

                Color[] backColors = { Color.FromArgb(77, 200, 86) };
                Color[] selectColors = { Color.FromArgb(98, 222, 107) };
                string[] names = { "Select Member" };

                dgv.GridButtons(dgv: SecondDgv, names: names, backColors: backColors, selectionColors: selectColors);

            }

            dgv.ShowGrid(dgv: SecondDgv, name: "Choose Member", searchQuery: SearchTb.Text);
            dgv.GridWidth(dgv: SecondDgv, widths: new int[] { 0, 150, 200, 200 });
        }

        public void Books() {

            SecondDgv.Columns.Clear();
            if (SecondDgv.ColumnCount == 0) {

                Color[] backColors = { Color.FromArgb(77, 200, 86) };
                Color[] selectColors = { Color.FromArgb(98, 222, 107) };
                string[] names = { "Choose Book" };

                dgv.GridButtons(dgv: SecondDgv, names: names, backColors: backColors, selectionColors: selectColors);

            }

            dgv.ShowGrid(dgv: SecondDgv, name: "Choose Book", searchQuery: SearchTb.Text);
            dgv.GridWidth(dgv: SecondDgv, widths: new int[] { 0, 150, 200, 150, 150 });
        }

        public void MainGridRefresh() {

            Title2Lbl.Text = "Total Pending Books: " + fn.GetNumberOf(name: "Pending Books");
            RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt");

            mf.MainDgv.Columns.Clear();
            dgv.ShowGrid(dgv: mf.MainDgv, name: "Borrow Books", searchQuery: SearchTb.Text, fromDate: mf.FromDtp.Value.ToString("yyyy-MM-dd"), toDate: mf.ToDtp.Value.ToString("yyyy-MM-dd"));
            dgv.GridWidth(dgv: mf.MainDgv, widths: new int[] { 200, 250, 250, 200, 200, 200 });
            if (mf.MainDgv.RowCount > 0) mf.MainDgv.CurrentCell.Selected = false;

            dgv.GridColor(mf.MainDgv);
        }

        public void BorrowGridRefresh() {
            bbf.BorrowDgv.Columns.Clear();
            if (bbf.BorrowDgv.ColumnCount == 0) {
                Color[] backColors = { Color.FromArgb(253, 98, 91) };
                Color[] selectColors = { Color.FromArgb(230, 98, 91) };
                string[] names = { "Remove" };

                dgv.GridButtons(dgv: bbf.BorrowDgv, names: names, backColors: backColors, selectionColors: selectColors);
            }
            dgv.ShowGrid(dgv: bbf.BorrowDgv, name: "Borrow Checkout");
            dgv.GridWidth(dgv: bbf.BorrowDgv, widths: new int[] { 0, 150, 250, 250, 250 });

            bbf.BorrowIDLbl.Text = "BORROW ID: " + fn.GetID("Books Borrows");
            bbf.DueDateLbl.Text = "DUE DATE: " + DateTime.Now.AddDays(7).ToString("yyyy-MM-dd"); // TODO: Need to change if want
        }
        #endregion Grid Methods
    }
}
