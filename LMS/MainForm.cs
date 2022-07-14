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
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            {
                var withBlock = Screen.PrimaryScreen.WorkingArea;
                this.SetBounds(withBlock.Left, withBlock.Top, withBlock.Width, withBlock.Height);
            }

            //BooksPanel.Hide();
            TitlePb.Image = Properties.Resources.Dashboard;

            // Demo coding for format the DGV
            GridControlSettings dgv = new GridControlSettings();
            dgv.ShowGrid(dgv: BooksDgv, gridName: "BooksGrid", query: "SELECT ISBN, Title, Author, Category, publishers.name AS Publisher, Price, Quantity, Date, Time  FROM books, publishers  WHERE books.pid = publishers.pid AND books.is_removed = 0;");
            if (BooksDgv.ColumnCount <= 9) {
                dgv.GridButtons(dgv: BooksDgv);
            }
            dgv.GridWidth(dgv: BooksDgv, widths: new int[] { 150, 250, 250, 100, 250, 100, 100 });
        }

        private void BooksBtn_Click(object sender, EventArgs e) {
            BooksPanel.Show();
            DashboardBtn.Checked = false;
            BooksBtn.Checked = true;

        }

        private void DashboardBtn_Click(object sender, EventArgs e) {
            BooksPanel.Hide();
            BooksBtn.Checked = false;
            DashboardBtn.Checked = true;

        }
    }
}
