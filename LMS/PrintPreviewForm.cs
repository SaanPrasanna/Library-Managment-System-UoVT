using LMS.Reports;
using LMS.Utils.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS {
    public partial class PrintPreviewForm : Form {

        private readonly List<Book> _books;
        private readonly List<Member> _member;

        internal PrintPreviewForm([Optional] List<Book> books) {
            InitializeComponent();
            _books = books;
        }

        private void PrintPreviewForm_Load(object sender, EventArgs e) {
            guna2ShadowForm.SetShadowForm(this);
            this.TopMost = true;

            if (_books != null) {
                booksReport.SetDataSource(_books);
                PrintReportViewer.ReportSource = booksReport;
            } else if (false) {

            } else if (false) {
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void PrintPreviewForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }
    }
}
