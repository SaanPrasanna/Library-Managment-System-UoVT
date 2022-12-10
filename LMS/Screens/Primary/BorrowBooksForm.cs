using LMS.Utils;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Guna.UI2.WinForms;
using Bunifu.Framework.UI;
using System.Threading;
using LMS.Utils.Core;
using LMS.Utils.Connection;
using LMS.Screens.Widgets;

namespace LMS {
    public partial class BorrowBooksForm : Form {

        private readonly Functions fn = new Functions();
        private readonly GridControlSettings dgv = new GridControlSettings();
        private readonly MainForm _mf;

        public BorrowBooksForm(MainForm mf) {
            InitializeComponent();
            _mf = mf;
        }

        #region Form Load
        private void BorrowBooksForm_Load(object sender, EventArgs e) {
            // Fixed Taskbar issue
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            {
                var withBlock = Screen.PrimaryScreen.WorkingArea;
                this.SetBounds(withBlock.Left, withBlock.Top, withBlock.Width, withBlock.Height);
            }

            InitialLoad(condition: "Full");
            FullNameLbl.Text = Properties.Settings.Default.fullName;
            UsernameLbl.Text = Properties.Settings.Default.username;
            ClearGrid();

            Thread initBtn = new Thread(() => InitButton());
            initBtn.Start();
        }
        #endregion Form Load

        #region Button Click
        public static void Bl_ProcessCompleted(object sender, EventArgs e) { }

        private void NewBorrowBtn_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Do you want to clear? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                ClearGrid();
                MemberIDLbl.Text = string.Empty;
                MemberNameLbl.Text = string.Empty;
                MemberBtn.Enabled = true;
                Guna2TileButton[] buttons = { BooksBtn, BorrowBtn, ClearAllBtn };
                Array.ForEach(buttons, btn => { btn.Enabled = false; });
            }
        }

        private void ClearAllBtn_Click(object sender, EventArgs e) {
            ClearGrid();
            ClearAllBtn.Enabled = false;
            BooksBtn.Enabled = true;
        }

        private void MemberBtn_Click(object sender, EventArgs e) {
            SecondForm sf = new SecondForm(bbf: this, title: "Choose Member");
            sf.ShowDialog();
        }

        private void BooksBtn_Click(object sender, EventArgs e) {
            SecondForm sf = new SecondForm(bbf: this, title: "Choose Books");
            sf.ShowDialog();
        }

        private void BorrowBtn_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();

                try {
                    DataTable table = fn.GetDataTable("Temp Checkout");
                    string borrowID = fn.GetID("Books Borrows");

                    for (int i = 0; i < (Convert.ToInt32(fn.GetID("Temp")) - 1); i++) {
                        if (Convert.ToInt32(table.Rows[i][3]) != 1) {
                            string query = "INSERT INTO borrow_books VALUES (@refno, @mid, @isbn, @issueDate, @time, @dueDate, @returnDate, @status, @fineFee, @sid);";

                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.Add("@refno", SqlDbType.VarChar, 12).Value = borrowID;
                            cmd.Parameters.Add("@mid", SqlDbType.VarChar, 6).Value = MemberIDLbl.Text;
                            cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = table.Rows[i][1].ToString();
                            cmd.Parameters.Add("@issueDate", SqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
                            cmd.Parameters.Add("@time", SqlDbType.Time).Value = DateTime.Now.ToString("HH:mm:ss");
                            cmd.Parameters.Add("@dueDate", SqlDbType.Date).Value = DateTime.Now.AddDays(7).ToString(""); // TODO: Dynamic using global variable
                            cmd.Parameters.Add("@returnDate", SqlDbType.Date).Value = default(DateTime);
                            cmd.Parameters.Add("@status", SqlDbType.VarChar, 10).Value = "Pending";
                            cmd.Parameters.Add("@fineFee", SqlDbType.Decimal).Value = default(decimal);
                            cmd.Parameters.Add("@sid", SqlDbType.VarChar, 6).Value = "S00001";

                            cmd.ExecuteNonQuery();

                            string query2 = "UPDATE books SET quantity = @qty WHERE isbn = @isbn;";

                            SqlCommand cmd2 = new SqlCommand(query2, conn);
                            cmd2.Parameters.Add("@qty", SqlDbType.Int).Value = Convert.ToInt32(fn.GetNumberOf("Specified Book", value: table.Rows[i][1].ToString()).ToString()) - 1;
                            cmd2.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = table.Rows[i][1].ToString();

                            cmd2.ExecuteNonQuery();
                        }
                    }
                    ClearGrid();
                    InitialLoad(condition: "Full");

                    BorrowBtn.Enabled = false;

                    this.Alert("Book Borrow Process!", "Books Borrowed Complete!", AlertForm.EnmType.Success);
                    
                    _mf.DashboardDetailsCalled += Bl_ProcessCompleted;
                    _mf.DashboardDetails();

                    dgv.ShowGrid(dgv: _mf.MainDgv, name: "Borrow Books", searchQuery: _mf.SearchTb.Text, fromDate: _mf.FromDtp.Value.ToString("yyyy-MM-dd"), toDate: _mf.ToDtp.Value.ToString("yyyy-MM-dd"));
                    dgv.GridWidth(dgv: _mf.MainDgv, widths: new int[] { 175, 300, 250, 200, 200, 200, 150 });
                    if (_mf.MainDgv.RowCount > 0) _mf.MainDgv.CurrentCell.Selected = false;
                    dgv.GridColor(_mf.MainDgv);

                } catch (Exception ex) {
                    Console.WriteLine("Error: || Borrow Books ||\n" + ex.ToString());
                } finally {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }
        private void MinimizeBtn_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Do you want to close?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.Hide();
                this.Dispose();
            }
        }

        #endregion Button Click

        #region KeyDown
        private void BorrowBooksForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                if (MessageBox.Show("Do you want to close?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    this.Hide();
                    this.Dispose();
                }
            } else if (e.KeyCode == Keys.F1 && NewBorrowBtn.Enabled == true) {
                NewBorrowBtn_Click(sender, e);
            } else if (e.KeyCode == Keys.F2 && ClearAllBtn.Enabled == true) {
                ClearAllBtn_Click(sender, e);
            } else if (e.KeyCode == Keys.F3 && MemberBtn.Enabled == true) {
                MemberBtn_Click(sender, e);
            } else if (e.KeyCode == Keys.F4 && BooksBtn.Enabled == true) {
                BooksBtn_Click(sender, e);
            } else if (e.KeyCode == Keys.F5 && BorrowBtn.Enabled == true) {
                BorrowBtn_Click(sender, e);
            }
        }
        #endregion KeyDown

        #region Grid Cell Content Click
        private void BorrowDgv_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            string isbn = BorrowDgv.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (e.ColumnIndex == 0) {
                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                try {
                    string query = "UPDATE borrow_temp SET is_removed = '1' WHERE isbn = @isbn;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = isbn;

                    if (cmd.ExecuteNonQuery() > 0) {
                        BooksBtn.Enabled = true;
                        ClearAllBtn.Enabled = true;
                        InitialLoad(condition: "Full");
                    }


                } catch (Exception ex) {
                    Console.WriteLine("Error: || Borrow Books Remove ||\n" + ex.ToString());
                } finally {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }
        #endregion Grid Cell Content Click

        #region Method Area
        public void Alert(string title, string body, AlertForm.EnmType type) {
            AlertForm alertForm = new AlertForm();
            alertForm.ShowAlert(title: title, body: body, type: type);
        }

        private void InitButton() {
            MemberBtn.Enabled = true;
            Guna2TileButton[] buttons = { BooksBtn, BorrowBtn, ClearAllBtn };
            Array.ForEach(buttons, btn => { btn.Enabled = false; });
        }

        public void ClearGrid() {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try {
                string query = "DELETE FROM borrow_temp;";
                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() > 0) {
                    InitialLoad();
                }

            } catch (Exception ex) {
                Console.WriteLine("Error: || Delete Borrow Temp ||\n" + ex.ToString());
            } finally {
                conn.Close();
                conn.Dispose();
            }
        }
        public void InitialLoad([Optional] string condition) {

            BorrowDgv.Columns.Clear();
            if (BorrowDgv.ColumnCount == 0) {
                Color[] backColors = { Color.FromArgb(253, 98, 91) };
                Color[] selectColors = { Color.FromArgb(230, 98, 91) };
                string[] names = { "Remove" };

                dgv.GridButtons(dgv: BorrowDgv, names: names, backColors: backColors, selectionColors: selectColors);
            }
            dgv.ShowGrid(dgv: BorrowDgv, name: "Borrow Checkout");
            dgv.GridWidth(dgv: BorrowDgv, widths: new int[] { 0, 150, 250, 250, 250 });

            BunifuCustomLabel[] labels = { MemberIDLbl, MemberNameLbl, BorrowIDLbl, DueDateLbl };
            string[] values = { string.Empty, string.Empty, fn.GetID("Books Borrows"), DateTime.Now.AddDays(7).ToString("yyyy-MM-dd") }; // TODO: 7 DAYS Need to change if want
            if (condition == "Full") {
                foreach (var lbl in labels.Select((name, index) => (name, index))) {
                    lbl.name.Text = values[lbl.index];
                }
            }
        }
        #endregion Method Area

    }
}
