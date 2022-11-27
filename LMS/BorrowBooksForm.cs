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

namespace LMS {
    public partial class BorrowBooksForm : Form {

        readonly Functions fn = new Functions();
        readonly SqlConnection conn = DBUtils.GetDBConnection();
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
        }

        private void NewBorrowBtn_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Do you want to clear? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                try {
                    conn.Open();
                    string query = "DELETE FROM borrow_temp;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                } catch (Exception ex) {
                    Console.WriteLine("Error: " + ex.ToString());
                } finally {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        public void InitialLoad() {

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

            BorrowIDLbl.Text = "BORROW ID: " + fn.GetID("Books Borrows");
            DueDateLbl.Text = "DUE DATE: " + DateTime.Now.AddDays(7).ToString("yyyy-MM-dd"); // TODO: Need to change
        }

        private void MemberBtn_Click(object sender, EventArgs e) {
            SecondForm sf = new SecondForm(bbf: this, title: "Choose Member");
            sf.ShowDialog();
        }
    }
}
