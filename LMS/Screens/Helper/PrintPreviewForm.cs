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
        private readonly string _mid;
        private string _address, _email, _tp, _name;

        internal PrintPreviewForm([Optional] List<Book> books, [Optional] List<Member> members, [Optional] List<Staff> staffs, [Optional] List<BorrowBook> borrowBooks, [Optional] List<ManageBooks> manageBooks, [Optional] List<BorrowBook> memberReport, [Optional] string mid) {
            InitializeComponent();
            _books = books;
            _member = members;
            _staff = staffs;
            _borrowBook = borrowBooks;
            _manageBook = manageBooks;
            _memberReport = memberReport;
            _mid = mid;

            // Load Heading Details
            ReportHeading();
        }

        private void ReportHeading() {
            _name = "LIBRARY MANAGEMENT SYSTEM";
            _address = "Kandawala Road, Ratmalana.";
            _email = "info@rgenesis.cc";
            _tp = "+9411 666 44 11";
        }

        private void PrintPreviewForm_Load(object sender, EventArgs e) {
            guna2ShadowForm.SetShadowForm(this);
            this.TopMost = true;

            try {
                if (_books != null) {
                    booksReport.SetDataSource(_books);

                    string[] names = { "hName", "hTp", "hAddress", "hEmail", "pStaffName" };
                    string[] values = { _name, _tp, _address, _email, Properties.Settings.Default.fullName };
                    for (int i = 0; i < names.Length; i++) { booksReport.SetParameterValue(names[i], values[i]); }

                    PrintReportViewer.ReportSource = booksReport;

                } else if (_member != null) {
                    memberReport.SetDataSource(_member);

                    string[] names = { "hName", "hTp", "hAddress", "hEmail", "pStaffName" };
                    string[] values = { _name, _tp, _address, _email, Properties.Settings.Default.fullName };
                    for (int i = 0; i < names.Length; i++) { memberReport.SetParameterValue(names[i], values[i]); }

                    PrintReportViewer.ReportSource = memberReport;

                } else if (_staff != null) {
                    staffsReport.SetDataSource(_staff);

                    string[] names = { "hName", "hTp", "hAddress", "hEmail", "pStaffName" };
                    string[] values = { _name, _tp, _address, _email, Properties.Settings.Default.fullName };
                    for (int i = 0; i < names.Length; i++) { staffsReport.SetParameterValue(names[i], values[i]); }

                    PrintReportViewer.ReportSource = staffsReport;

                } else if (_borrowBook != null) {
                    borrowBooksReport.SetDataSource(_borrowBook);

                    string[] names = { "hName", "hTp", "hAddress", "hEmail", "pStaffName" };
                    string[] values = { _name, _tp, _address, _email, Properties.Settings.Default.fullName };
                    for (int i = 0; i < names.Length; i++) { borrowBooksReport.SetParameterValue(names[i], values[i]); }

                    PrintReportViewer.ReportSource = borrowBooksReport;

                } else if (_manageBook != null) {
                    manageBooksReport.SetDataSource(_manageBook);

                    string[] names = { "hName", "hTp", "hAddress", "hEmail", "pStaffName" };
                    string[] values = { _name, _tp, _address, _email, Properties.Settings.Default.fullName };
                    for (int i = 0; i < names.Length; i++) { manageBooksReport.SetParameterValue(names[i], values[i]); }

                    PrintReportViewer.ReportSource = manageBooksReport;


                } else if (_memberReport != null) {
                    memberDetailsReport.SetDataSource(_memberReport);

                    string[] names = { "hName", "hTp", "hAddress", "hEmail", "pStaffName", "pMID" };
                    string[] values = { _name, _tp, _address, _email, Properties.Settings.Default.fullName, _mid };
                    for (int i = 0; i < names.Length; i++) { memberDetailsReport.SetParameterValue(names[i], values[i]); }

                    DataTable dt = fn.GetDataTable(name: "Member", value: _mid);
                    string[] memberDetails = { "pEmail", "pFullName", "pTelephone", "pAddress", "pJoinedDate" };
                    for (int i = 1; i <= memberDetails.Length; i++) { memberDetailsReport.SetParameterValue(memberDetails[i - 1], dt.Rows[0][i]); }

                    PrintReportViewer.ReportSource = memberDetailsReport;
                }

            } catch (Exception ex) {
                Console.WriteLine("Error: || PrintPreview ||\n" + ex.ToString());
            } finally {
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            CleanReport();
            this.Close();
        }

        private void PrintPreviewForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                CleanReport();
                this.Close();
            }
        }

        private void CleanReport() {
            try {
                if (_books != null) {
                    booksReport.Close();
                    booksReport.Dispose();

                } else if (_member != null) {
                    memberReport.Close();
                    memberReport.Dispose();

                } else if (_staff != null) {
                    staffsReport.Close();
                    staffsReport.Dispose();

                } else if (_borrowBook != null) {
                    borrowBooksReport.Close();
                    borrowBooksReport.Dispose();

                } else if (_manageBook != null) {
                    manageBooksReport.Close();
                    manageBooksReport.Dispose();

                } else if (_memberReport != null) {
                    memberDetailsReport.Close();
                    memberDetailsReport.Dispose();
                }
                PrintReportViewer.Dispose();
            } catch (Exception ex) {
                Console.WriteLine("Error: || PrintPreview Dispose ||\n" + ex.ToString());
            } finally {
            }
        }
    }
}
