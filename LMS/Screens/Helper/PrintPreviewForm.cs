using LMS.Reports;
using LMS.Utils.Core;
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

        private readonly Functions fn = new Functions();
        private readonly List<Book> _books;
        private readonly List<Member> _member;
        private readonly List<Staff> _staff;
        private readonly List<BorrowBook> _borrowBook;
        private readonly List<ManageBooks> _manageBook;
        private readonly List<BorrowBook> _memberReport;
        private readonly string _mid, _address, _email, _tp, _name;

        internal PrintPreviewForm([Optional] List<Book> books, [Optional] List<Member> members, [Optional] List<Staff> staffs, [Optional] List<BorrowBook> borrowBooks, [Optional] List<ManageBooks> manageBooks, [Optional] List<BorrowBook> memberReport, [Optional] string mid) {
            InitializeComponent();
            _books = books;
            _member = members;
            _staff = staffs;
            _borrowBook = borrowBooks;
            _manageBook = manageBooks;
            _memberReport = memberReport;
            _mid = mid;

            // Load Heading
            _address = "Kandawala Road, Ratmalana.";
            _email = "info@rgenesis.cc";
            _tp = "+9411 666 44 11";
            _name = "LIBRARY MANAGEMENT SYSTEM";

        }

        private void PrintPreviewForm_Load(object sender, EventArgs e) {
            guna2ShadowForm.SetShadowForm(this);
            this.TopMost = true;

            if (_books != null) {
                booksReport.SetDataSource(_books);
                PrintReportViewer.ReportSource = booksReport;
            } else if (_member != null) {
                memberReport.SetDataSource(_member);
                PrintReportViewer.ReportSource = memberReport;
            } else if (_staff != null) {
                staffsReport.SetDataSource(_staff);
                PrintReportViewer.ReportSource = staffsReport;
            } else if (_borrowBook != null) {
                borrowBooksReport.SetDataSource(_borrowBook);
                PrintReportViewer.ReportSource = borrowBooksReport;
            } else if (_manageBook != null) {
                manageBooksReport.SetDataSource(_manageBook);
                PrintReportViewer.ReportSource = manageBooksReport;
            } else if (_memberReport != null) {
                memberDetailsReport.SetDataSource(_memberReport);
                PrintReportViewer.ReportSource = memberDetailsReport;

                memberDetailsReport.SetParameterValue("hName", _name);
                memberDetailsReport.SetParameterValue("hTp", _tp);
                memberDetailsReport.SetParameterValue("hAddress", _address);
                memberDetailsReport.SetParameterValue("hEmail", _email);
                memberDetailsReport.SetParameterValue("hTp", _tp);

                DataTable dt = fn.GetDataTable(name: "Member", value: _mid);
                memberDetailsReport.SetParameterValue("pEmail", dt.Rows[0][1]);
                memberDetailsReport.SetParameterValue("pFullName", dt.Rows[0][2]);
                memberDetailsReport.SetParameterValue("pTelephone", dt.Rows[0][3]);
                memberDetailsReport.SetParameterValue("pAddress", dt.Rows[0][4]);
                memberDetailsReport.SetParameterValue("pJoinedDate", dt.Rows[0][5]);
                memberDetailsReport.SetParameterValue("pMID", _mid);
                memberDetailsReport.SetParameterValue("pStaffName", Properties.Settings.Default.fullName);
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
