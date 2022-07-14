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

        }

        private void DashboardBtn_Click(object sender, EventArgs e) {
            MainPanel.Hide();
            BooksBtn.Checked = false;
            DashboardBtn.Checked = true;
            TitlePb.Image = Properties.Resources.Dashboard;
            TitleLbl.Text = "Dashboard Oveview";

        }

        private void BooksBtn_Click(object sender, EventArgs e) {

            Functions fn = new Functions();
            GridControlSettings dgv = new GridControlSettings();

            MainPanel.Show();
            DashboardBtn.Checked = false;
            BooksBtn.Checked = true;
            TitlePb.Image = Properties.Resources.Books;
            TitleLbl.Text = "All Books";
            Title2Lbl.Text = "Total Books: " + fn.GetNumberOfBooks();
            RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm tt");
            ActionBtn.Text = "ADD BOOK";
            ActionBtn.FillColor = Color.FromArgb(77, 200, 86);
            ActionBtn.ForeColor = Color.FromArgb(255, 255, 255);

            string query = "SELECT ISBN, Title, Author, Category, publishers.name AS Publisher, Price, Quantity, Date, Time  FROM books, publishers  WHERE books.pid = publishers.pid AND books.is_removed = 0;";

            dgv.ShowGrid(dgv: MainDgv, query: query);
            if (MainDgv.ColumnCount <= 9) {
                dgv.GridButtons(dgv: MainDgv);
            }
            dgv.GridWidth(dgv: MainDgv, widths: new int[] { 150, 250, 250, 100, 250, 100, 100 });
        }

        private void MainDgv_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (ActionBtn.Text == "ADD BOOK") {
                String isbn = MainDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (e.ColumnIndex == 9) {
                    // Modify
                }else if(e.ColumnIndex == 10) {
                    // Remove
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
    }
}
