using LMS.Utils;
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
using System.Runtime.InteropServices;

namespace LMS {
    public partial class BorrowBooksForm : Form {

        readonly Functions fn = new Functions();
        GridControlSettings dgv = new GridControlSettings();

        public BorrowBooksForm() {
            InitializeComponent();
        }

        private void BorrowBooksForm_Load(object sender, EventArgs e) {
            // Fixed Taskbar issue
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            {
                var withBlock = Screen.PrimaryScreen.WorkingArea;
                this.SetBounds(withBlock.Left, withBlock.Top, withBlock.Width, withBlock.Height);
            }

            InitialLoad();
            ClearGrid();
            MemberIDLbl.Text = string.Empty; // TODO: if want set globle variable and set memory for after closed
            MemberNameLbl.Text = string.Empty;
            MemberBtn.Enabled = true;
            BooksBtn.Enabled = false;
            BorrowBtn.Enabled = false;
            ClearAllBtn.Enabled = false;
        }

        private void NewBorrowBtn_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Do you want to clear? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                ClearGrid();
                MemberIDLbl.Text = string.Empty;
                MemberNameLbl.Text = string.Empty;
                MemberBtn.Enabled = true;
                BooksBtn.Enabled = false;
                BorrowBtn.Enabled = false;
                ClearAllBtn.Enabled = false;
            }
        }

        public void InitialLoad([Optional] string condition) {

            // Loading DataGridView
            BorrowDgv.Columns.Clear();
            if (BorrowDgv.ColumnCount == 0) {
                Color[] backColors = { Color.FromArgb(253, 98, 91) };
                Color[] selectColors = { Color.FromArgb(230, 98, 91) };
                string[] names = { "Remove" };

                dgv.GridButtons(dgv: BorrowDgv, names: names, backColors: backColors, selectionColors: selectColors);
            }
            dgv.ShowGrid(dgv: BorrowDgv, name: "Borrow Checkout");
            dgv.GridWidth(dgv: BorrowDgv, widths: new int[] { 0, 150, 250, 250, 250 });

            if (condition == "partial") {
                BorrowIDLbl.Text = "BORROW ID: " + fn.GetID("Books Borrows");
                DueDateLbl.Text = "DUE DATE: " + DateTime.Now.AddDays(7).ToString("yyyy-MM-dd"); // TODO: Need to change if want
            }
        }

        private void MemberBtn_Click(object sender, EventArgs e) {
            SecondForm sf = new SecondForm(bbf: this, title: "Choose Member");
            sf.ShowDialog();
        }

        private void BooksBtn_Click(object sender, EventArgs e) {
            SecondForm sf = new SecondForm(bbf: this, title: "Choose Books");
            sf.ShowDialog();
        }

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
                        InitialLoad(condition: "partial");
                    }


                } catch (Exception ex) {
                    Console.WriteLine("Error: || Borrow Books Remove ||\n" + ex.ToString());
                } finally {
                    conn.Close();
                    conn.Dispose();
                }
            }
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

        private void ClearAllBtn_Click(object sender, EventArgs e) {
            ClearGrid();
            ClearAllBtn.Enabled = false;
            BooksBtn.Enabled = true;
        }

        private void BorrowBtn_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();

                try {
                    DataTable table = fn.GetDataTable("Temp Checkout");

                    for (int i = 0; i < (Convert.ToInt32(fn.GetID("Temp")) - 1); i++) {
                        if (Convert.ToInt32(table.Rows[i][3]) != 1) {
                            Console.WriteLine(table.Rows[i][1].ToString());
                        }
                    }
                } catch (Exception ex) {
                    Console.WriteLine("Error: || Borrow Books ||\n" + ex.ToString());
                } finally {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }
    }
}
