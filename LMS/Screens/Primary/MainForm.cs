using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using LMS.Utils;
using Guna.UI2.WinForms;
using LMS.Utils.Models;
using LMS.Screens.Primary;
using LMS.Utils.Core;
using LMS.Utils.Connection;
using LMS.Screens.Widgets;

namespace LMS {
    public partial class MainForm : Form {

        private readonly Functions fn = new Functions();
        private readonly GridControlSettings dgv = new GridControlSettings();

        public MainForm() {
            InitializeComponent();
        }

        #region Form Load
        private void MainForm_Load(object sender, EventArgs e) {

            // Fixed Taskbar issue
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            {
                var withBlock = Screen.PrimaryScreen.WorkingArea;
                this.SetBounds(withBlock.Left, withBlock.Top, withBlock.Width, withBlock.Height);
            }

            TitlePb.Image = Properties.Resources.Dashboard;
            MainPanel.Hide();
            DashboardDetails();
            guna2ShadowPanel10.Hide(); // TODO: 
            MemberHiddenWidgets();

            if (!fn.IsStaff()) {
                MemberDashboard(visible: true);
            }
        }
        #endregion Form Load

        #region Navigation Buttons

        private void DashboardBtn_Click(object sender, EventArgs e) {
            DashboardBtn.Checked = true;
            TitleLbl.Text = "Dashboard Oveview";
            TitlePb.Image = Properties.Resources.Dashboard;

            if (fn.IsStaff()) {
                MainPanel.Hide();
                DashboardPanel.Show();

                Guna2Button[] menuBtn = new[] { BorrowBooksBtn, MangeBooksBtn, BooksBtn, MembersBtn, StaffsBtn };
                Array.ForEach(menuBtn, btn => { btn.Checked = false; });

                DashboardDetails();
            } else {
                Guna2Button[] menuBtns = new[] { BorrowBooksBtn, BooksBtn };
                Array.ForEach(menuBtns, btn => { btn.Checked = false; });

                MemberHiddenWidgets();
                MemberDashboard(visible: true);
            }
        }

        private void BooksBtn_Click(object sender, EventArgs e) {

            DashboardPanel.Hide();
            MainPanel.Show();
            BooksBtn.Checked = true;
            SearchTb.PlaceholderText = "Search By Title";
            SearchTb.Text = string.Empty;
            TitleLbl.Text = "All Books";
            Title2Lbl.Text = "Total Books: " + fn.GetNumberOf(name: "Books");
            TitlePb.Image = Properties.Resources.Books;
            RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt");

            if (fn.IsStaff()) {
                Action2Btn.Visible = true;
                Action3Btn.Visible = true;

                Guna2Button[] menuBtn = new[] { BorrowBooksBtn, MangeBooksBtn, DashboardBtn, MembersBtn, StaffsBtn };
                Array.ForEach(menuBtn, btn => { btn.Checked = false; });

                CustomizeButton(btn: ActionBtn, name: "ADD BOOK", fillColor: Color.FromArgb(77, 200, 86));
                CustomizeButton(btn: Action2Btn, name: "PUBLISHERS", fillColor: Color.FromArgb(94, 148, 255));

                DateTimePickers(isVisible: false);

                MainDgv.Columns.Clear();

                Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91) };
                Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91) };
                string[] names = { "Modify", "Remove" };
                int[] widths = new int[] { 0, 0, 150, 250, 250, 100, 250, 100, 100 };

                if (MainDgv.ColumnCount == 0) {
                    dgv.GridButtons(dgv: MainDgv, names: names, backColors: backColors, selectionColors: selectColors);
                }
                dgv.ShowGrid(dgv: MainDgv, name: "Books");
                dgv.GridWidth(dgv: MainDgv, widths: widths);

            } else {
                Guna2Button[] menuBtns = new[] { BorrowBooksBtn, DashboardBtn };
                Array.ForEach(menuBtns, btn => { btn.Checked = false; });

                MemberDashboard(visible: false);
                dgv.ShowGrid(dgv: MainDgv, name: "Member Books", searchQuery: SearchTb.Text);
                dgv.GridWidth(dgv: MainDgv, widths: new int[] { 100, 300, 150, 200, 200, 150 });
            }
        }

        private void BorrowBooksBtn_Click(object sender, EventArgs e) {

            TitlePb.Image = Properties.Resources.Books;
            RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt");
            MainPanel.Show();


            if (fn.IsStaff()) {
                DateTimePickers(isVisible: true);
                DashboardPanel.Hide();
                BorrowBooksBtn.Checked = true;
                Action2Btn.Visible = true;
                Action3Btn.Visible = true;

                Guna2Button[] menuBtn = new[] { MangeBooksBtn, StaffsBtn, DashboardBtn, MembersBtn, BooksBtn };
                Array.ForEach(menuBtn, btn => { btn.Checked = false; });

                SearchTb.PlaceholderText = "Search By Name";
                SearchTb.Text = string.Empty;
                TitleLbl.Text = "Borrow Books";
                Title2Lbl.Text = "Total Pending Books: " + fn.GetNumberOf(name: "Pending Books");

                CustomizeButton(btn: ActionBtn, name: "NEW BORROW", fillColor: Color.FromArgb(77, 200, 86));
                CustomizeButton(btn: Action2Btn, name: "PENDING LIST", fillColor: Color.FromArgb(248, 187, 0));

                MainDgv.Columns.Clear();
                dgv.ShowGrid(dgv: MainDgv, name: "Borrow Books", searchQuery: SearchTb.Text, fromDate: FromDtp.Value.ToString("yyyy-MM-dd"), toDate: ToDtp.Value.ToString("yyyy-MM-dd"));
                dgv.GridWidth(dgv: MainDgv, widths: new int[] { 175, 300, 250, 200, 200, 200, 150 });
                if (MainDgv.RowCount > 0) MainDgv.CurrentCell.Selected = false;

                dgv.GridColor(MainDgv);
            } else {
                Guna2Button[] menuBtns = new[] { BooksBtn, DashboardBtn };
                Array.ForEach(menuBtns, btn => { btn.Checked = false; });

                SearchTb.PlaceholderText = "Search By Title";
                SearchTb.Text = string.Empty;
                TitleLbl.Text = "My Books List";
                Title2Lbl.Text = "My Pending Books: " + fn.GetNumberOf(name: "Already Borrowed Books", value: Properties.Settings.Default.id);

                MemberDashboard(visible: false);
                dgv.ShowGrid(dgv: MainDgv, name: "Member Borrow Books", searchQuery: Properties.Settings.Default.id, searchQuery2: SearchTb.Text);
                dgv.GridWidth(dgv: MainDgv, widths: new int[] { 200, 250, 250, 200, 200, 200, 200 });
            }
        }

        private void MembersBtn_Click(object sender, EventArgs e) {

            DashboardPanel.Hide();
            MainPanel.Show();
            MembersBtn.Checked = true;
            Action2Btn.Visible = false;
            Action3Btn.Visible = true;

            Guna2Button[] menuBtn = new[] { BorrowBooksBtn, MangeBooksBtn, DashboardBtn, BooksBtn, StaffsBtn };
            Array.ForEach(menuBtn, btn => { btn.Checked = false; });

            TitlePb.Image = Properties.Resources.Members;
            SearchTb.PlaceholderText = "Search By First Name";
            SearchTb.Text = string.Empty;
            TitleLbl.Text = "All Members";
            Title2Lbl.Text = "Total Members: " + fn.GetNumberOf(name: "Members");
            RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt");

            CustomizeButton(btn: ActionBtn, name: "ADD MEMBER", fillColor: Color.FromArgb(77, 200, 86));
            DateTimePickers(isVisible: false);

            MainDgv.Columns.Clear();
            if (MainDgv.ColumnCount == 0) {

                Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91), Color.FromArgb(94, 148, 255) };
                Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91), Color.FromArgb(94, 120, 255) };
                string[] names = { "Modify", "Remove", "Print Report" };

                dgv.GridButtons(dgv: MainDgv, names: names, backColors: backColors, selectionColors: selectColors);
            }
            dgv.ShowGrid(dgv: MainDgv, name: "Members");
            dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 0, 150, 150, 200, 200, 250, 150, 150, 150 });

        }

        private void StaffsBtn_Click(object sender, EventArgs e) {
            if (fn.IsAdmin()) {
                DashboardPanel.Hide();
                MainPanel.Show();
                StaffsBtn.Checked = true;
                Action2Btn.Visible = false;
                Action3Btn.Visible = true;

                Guna2Button[] menuBtn = new[] { BorrowBooksBtn, MangeBooksBtn, DashboardBtn, MembersBtn, BooksBtn };
                Array.ForEach(menuBtn, btn => { btn.Checked = false; });

                TitlePb.Image = Properties.Resources.Members;
                SearchTb.PlaceholderText = "Search By Username";
                SearchTb.Text = string.Empty;
                TitleLbl.Text = "All Staffs Members";
                Title2Lbl.Text = "Total Staffs Members: " + fn.GetNumberOf(name: "Staffs");
                RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt");

                CustomizeButton(btn: ActionBtn, name: "ADD STAFF", fillColor: Color.FromArgb(77, 200, 86));
                DateTimePickers(isVisible: false);

                MainDgv.Columns.Clear();
                if (MainDgv.ColumnCount == 0) {

                    Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91) };
                    Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91) };
                    string[] names = { "Modify", "Remove" };

                    dgv.GridButtons(dgv: MainDgv, names: names, backColors: backColors, selectionColors: selectColors);
                }
                dgv.ShowGrid(dgv: MainDgv, name: "Staffs");
                dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 150, 150, 400, 200 });
            } else {
                this.Alert("Access Denied!", "You do not have enough privileges to access staff details!", AlertForm.EnmType.Error);
            }
        }

        private void MangeBooksBtn_Click(object sender, EventArgs e) {

            DateTimePickers(isVisible: true);
            DashboardPanel.Hide();
            MainPanel.Show();
            MangeBooksBtn.Checked = true;
            Action2Btn.Visible = false;
            Action3Btn.Visible = true;

            Guna2Button[] menuBtn = new[] { BorrowBooksBtn, StaffsBtn, DashboardBtn, MembersBtn, BooksBtn };
            Array.ForEach(menuBtn, btn => { btn.Checked = false; });

            TitlePb.Image = Properties.Resources.Members;
            SearchTb.PlaceholderText = "Search By Name";
            SearchTb.Text = string.Empty;
            TitleLbl.Text = "Manage Books";
            Title2Lbl.Text = "Monthly Manage Books: " + fn.GetNumberOf(name: "Manage Books");
            RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt");

            CustomizeButton(btn: ActionBtn, name: "MANAGE BOOK", fillColor: Color.FromArgb(248, 187, 0));
            DateTimePickers(isVisible: true);

            ManageDataGridLoad();
        }


        private void SettingsBtn_Click(object sender, EventArgs e) {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
        }
        #endregion Navigation Buttons

        #region Main Grid CellContentClick
        private void MainDgv_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            if (ActionBtn.Text == "ADD BOOK") {

                String isbn = MainDgv.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (e.ColumnIndex == 0) {

                    BooksActionsForm ab = new BooksActionsForm(form: this, title: "Modify Book", isbn: isbn);
                    ab.ShowDialog();

                } else if (e.ColumnIndex == 1) {
                    if (fn.IsAdmin()) {
                        if (MessageBox.Show("Do you want to delete this book [" + isbn + "]?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No) {
                            SqlConnection conn = DBUtils.GetDBConnection();
                            conn.Open();
                            String query = "UPDATE books SET is_removed = @number WHERE isbn = @isbn;";

                            try {

                                SqlCommand cmd = new SqlCommand(query, conn);
                                cmd.Parameters.Add("@number", SqlDbType.TinyInt).Value = 1;
                                cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = isbn;

                                int rowCount = cmd.ExecuteNonQuery();
                                if (rowCount > 0) {

                                    if (MainDgv.ColumnCount == 0) {

                                        Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91) };
                                        Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91) };
                                        string[] names = { "Modify", "Remove" };

                                        dgv.GridButtons(dgv: MainDgv, names: names, backColors: backColors, selectionColors: selectColors);
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
                    } else {
                        this.Alert("Access Denied!", "You do not have enough privilages to Remove Books!", AlertForm.EnmType.Error);
                    }
                }
            } else if (ActionBtn.Text == "ADD MEMBER") {
                String mid = MainDgv.Rows[e.RowIndex].Cells[3].Value.ToString();

                if (e.ColumnIndex == 0) {

                    MembersActionsForm membersForm = new MembersActionsForm(form: this, title: "Modify Member", mid: mid);
                    membersForm.ShowDialog();

                } else if (e.ColumnIndex == 1) {
                    if (fn.IsAdmin()) {
                        if (MessageBox.Show("Do you want to delete this member [" + mid + "]?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No) {
                            SqlConnection conn = DBUtils.GetDBConnection();
                            conn.Open();
                            String query = "UPDATE members SET is_removed = @number WHERE mid = @mid;";

                            try {

                                SqlCommand cmd = new SqlCommand(query, conn);
                                cmd.Parameters.Add("@number", SqlDbType.TinyInt).Value = 1;
                                cmd.Parameters.Add("@mid", SqlDbType.VarChar, 13).Value = mid;

                                int rowCount = cmd.ExecuteNonQuery();
                                if (rowCount > 0) {

                                    if (MainDgv.ColumnCount == 0) {

                                        Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91) };
                                        Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91) };
                                        string[] names = { "Modify", "Remove" };

                                        dgv.GridButtons(dgv: MainDgv, names: names, backColors: backColors, selectionColors: selectColors);
                                    }
                                    dgv.ShowGrid(dgv: MainDgv, name: "Members");
                                    dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 200, 200, 250, 150, 150, 150 });

                                } else {
                                    MessageBox.Show("Something was went wrong!", "Exception Occure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            } catch (Exception ex) {
                                Console.WriteLine("Member Removed Error: " + ex.ToString());
                            } finally {
                                conn.Close();
                                conn.Dispose();
                                Console.Read();
                            }
                        }
                    } else {
                        this.Alert("Access Denied!", "You do not have enough privilages to Remove Member!", AlertForm.EnmType.Error);
                    }
                } else if (e.ColumnIndex == 2) {
                    var reader = fn.GetReader(name: "Member Report", searchQuery: mid);
                    var memberDetails = fn.GetList<BorrowBook>(reader);

                    //this.Alert("Alert", memberDetails.Count.ToString(), AlertForm.EnmType.Info);
                    PrintPreviewForm ppfMemberReport = new PrintPreviewForm(memberReport: memberDetails, mid: mid);
                    ppfMemberReport.ShowDialog();
                }
            } else if (ActionBtn.Text == "ADD STAFF") {
                String sid = MainDgv.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (e.ColumnIndex == 0) {

                    StaffsActionsForm staffForm = new StaffsActionsForm(form: this, title: "Modify Staff", sid: sid);
                    staffForm.ShowDialog();

                } else if (e.ColumnIndex == 1) {

                    if (Properties.Settings.Default.accountType.ToLower() == "admin" && Properties.Settings.Default.id != sid) {
                        if (MessageBox.Show("Do you want to delete this staff member [" + sid + "]?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No) {

                            Functions fn = new Functions();
                            SqlConnection conn = DBUtils.GetDBConnection();
                            conn.Open();
                            String query = "UPDATE staffs SET is_removed = @number WHERE sid = @sid;";

                            try {

                                SqlCommand cmd = new SqlCommand(query, conn);
                                cmd.Parameters.Add("@number", SqlDbType.TinyInt).Value = 1;
                                cmd.Parameters.Add("@sid", SqlDbType.VarChar, 6).Value = sid;

                                int rowCount = (Int32)cmd.ExecuteNonQuery();
                                if (rowCount > 0) {

                                    if (MainDgv.ColumnCount == 0) {

                                        Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91) };
                                        Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91) };
                                        string[] names = { "Modify", "Remove" };

                                        dgv.GridButtons(dgv: MainDgv, names: names, backColors: backColors, selectionColors: selectColors);
                                    }
                                    dgv.ShowGrid(dgv: MainDgv, name: "Staffs");
                                    dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 150, 150, 400, 200 });
                                    Title2Lbl.Text = "Total Staffs Members: " + fn.GetNumberOf(name: "Staffs");

                                } else {
                                    MessageBox.Show("Something was went wrong!", "Exception Occur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            } catch (Exception ex) {
                                Console.WriteLine("Member Removed Error: " + ex.ToString());
                            } finally {
                                conn.Close();
                                conn.Dispose();
                                Console.Read();
                            }
                        }
                    } else if (Properties.Settings.Default.id == sid && Properties.Settings.Default.accountType.ToLower() == "admin") {
                        MessageBox.Show("Sorry, you can't delete your account!", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else if (Properties.Settings.Default.accountType.ToLower() == "moderator") {
                        MessageBox.Show("You doesn't have permission to delete accounts!", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion Main Grid CellContentClick

        #region Control Buttons

        private void MinimizeBtn_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            LoginForm lf = new LoginForm();
            this.Hide();
            this.Dispose();
            lf.Show();
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
                case "ADD STAFF":
                    StaffsActionsForm staffsForm = new StaffsActionsForm(form: this, title: "Add Staff", fn.GetID("Staff"));
                    staffsForm.ShowDialog();
                    break;
                case "MANAGE BOOK":
                    ManageBooksForm manageBooksForm = new ManageBooksForm(form: this);
                    manageBooksForm.ShowDialog();
                    break;
                case "NEW BORROW":
                    BorrowBooksForm borrowBooksForm = new BorrowBooksForm();
                    borrowBooksForm.Show();
                    break;
            }
        }

        private void Action2Btn_Click(object sender, EventArgs e) {

            switch (Action2Btn.Text) {
                case "PUBLISHERS":
                    SecondForm publisherForm = new SecondForm(form: new MainForm(), title: "Publishers");
                    publisherForm.ShowDialog();
                    break;
                case "PENDING LIST":
                    SecondForm pendingForm = new SecondForm(form: this, title: "Pending List");
                    pendingForm.ShowDialog();
                    break;
            }
        }

        private void Action3Btn_Click(object sender, EventArgs e) {
            switch (ActionBtn.Text) {
                case "NEW BORROW":
                    var reader = fn.GetReader(name: "Borrow Books", searchQuery: SearchTb.Text, fromDate: FromDtp.Value.ToString("yyyy-MM-dd"), toDate: ToDtp.Value.ToString("yyyy-MM-dd"));
                    var borrowList = fn.GetList<BorrowBook>(reader);

                    PrintPreviewForm ppfBooksBorrow = new PrintPreviewForm(borrowBooks: borrowList);
                    ppfBooksBorrow.ShowDialog();
                    break;
                case "ADD BOOK":
                    reader = fn.GetReader(name: "Books", searchQuery: SearchTb.Text);
                    var bookList = fn.GetList<Book>(reader);

                    PrintPreviewForm ppfBooks = new PrintPreviewForm(books: bookList);
                    ppfBooks.ShowDialog();
                    break;
                case "MANAGE BOOK":
                    reader = fn.GetReader(name: "Manage Books", searchQuery: SearchTb.Text, fromDate: FromDtp.Value.ToString("yyyy-MM-dd"), toDate: ToDtp.Value.ToString("yyyy-MM-dd"));
                    var manageList = fn.GetList<ManageBooks>(reader);

                    PrintPreviewForm ppfManageBooks = new PrintPreviewForm(manageBooks: manageList);
                    ppfManageBooks.ShowDialog();
                    break;
                case "ADD MEMBER":
                    reader = fn.GetReader(name: "Members", searchQuery: SearchTb.Text);
                    var memberList = fn.GetList<Member>(reader);

                    PrintPreviewForm ppfMembers = new PrintPreviewForm(members: memberList);
                    ppfMembers.ShowDialog();

                    break;
                case "ADD STAFF":
                    reader = fn.GetReader(name: "Staffs", searchQuery: SearchTb.Text);
                    var staffList = fn.GetList<Staff>(reader);

                    PrintPreviewForm ppfStaffs = new PrintPreviewForm(staffs: staffList);
                    ppfStaffs.ShowDialog();
                    break;
            }
        }
        private void ProfileGB_Click(object sender, EventArgs e) {
            if (fn.IsStaff()) {
                StaffsActionsForm saf = new StaffsActionsForm(form: this, "Modify Staff", Properties.Settings.Default.id);
                saf.ShowDialog();
            } else {
                MembersActionsForm maf = new MembersActionsForm(form: this, "Modify Member", Properties.Settings.Default.id);
                maf.ShowDialog();
            }
        }

        #endregion Control Buttons

        #region Special Events

        private void SearchTb_KeyUp(object sender, KeyEventArgs e) {

            if (BooksBtn.Checked == true) {
                if (fn.IsStaff()) {
                    dgv.ShowGrid(dgv: MainDgv, name: "Books", searchQuery: SearchTb.Text);
                    dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 250, 250, 100, 250, 100, 100 });
                } else {
                    dgv.ShowGrid(dgv: MainDgv, name: "Member Books", searchQuery: SearchTb.Text);
                    dgv.GridWidth(dgv: MainDgv, widths: new int[] { 100, 300, 150, 200, 200, 150 });
                }

            } else if (MembersBtn.Checked == true) {

                dgv.ShowGrid(dgv: MainDgv, name: "Members", searchQuery: SearchTb.Text);
                dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 0, 150, 150, 200, 200, 250, 150, 150, 150 });

            } else if (StaffsBtn.Checked == true) {

                dgv.ShowGrid(dgv: MainDgv, name: "Staffs", searchQuery: SearchTb.Text);
                dgv.GridWidth(dgv: MainDgv, widths: new int[] { 0, 0, 150, 150, 150, 400, 200 });

            } else if (MangeBooksBtn.Checked == true) {

                dgv.ShowGrid(dgv: MainDgv, name: "Manage Books", searchQuery: SearchTb.Text, fromDate: FromDtp.Value.ToString("yyyy-MM-dd"), toDate: ToDtp.Value.ToString("yyyy-MM-dd"));
                dgv.GridWidth(dgv: MainDgv, widths: new int[] { 150, 250, 150, 150, 250, 150, 150, 150 });

            } else if (BorrowBooksBtn.Checked == true) {

                if (fn.IsStaff()) {
                    dgv.ShowGrid(dgv: MainDgv, name: "Borrow Books", searchQuery: SearchTb.Text, fromDate: FromDtp.Value.ToString("yyyy-MM-dd"), toDate: ToDtp.Value.ToString("yyyy-MM-dd"));
                    dgv.GridWidth(dgv: MainDgv, widths: new int[] { 175, 300, 250, 200, 200, 200, 150 });
                    if (MainDgv.RowCount > 0) MainDgv.CurrentCell.Selected = false;
                    dgv.GridColor(MainDgv);
                } else {
                    dgv.ShowGrid(dgv: MainDgv, name: "Member Borrow Books", searchQuery: Properties.Settings.Default.id, searchQuery2: SearchTb.Text);
                    dgv.GridWidth(dgv: MainDgv, widths: new int[] { 200, 250, 250, 200, 200, 200, 200 });
                }

            }
        }

        private void FromDtp_ValueChanged(object sender, EventArgs e) {
            ManageDataGridLoad();
        }

        private void ToDtp_ValueChanged(object sender, EventArgs e) {
            ManageDataGridLoad();
        }
        #endregion Special Events

        #region Methods
        private void DashboardDetails() {

            Functions fn = new Functions();

            Guna2HtmlLabel[] labels = new[] { RecentUpdate1Lbl, RecentUpdate2Lbl, RecentUpdate3Lbl, RecentUpdate4Lbl, RecentUpdate5Lbl, RecentUpdate6Lbl, RecentUpdate7Lbl, RecentUpdate8Lbl };
            Array.ForEach(labels, x => { x.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt"); });

            Guna2HtmlLabel[] mainLabels = new[] { BooksLbl, MembersLbl, ManageBooksLbl, PendingBooksLbl, ReturnBooksLbl, IssuedBooksLbl };
            string[] names = new[] { "Books", "Members", "Manage Books", "Pending Books", "Returned Books", "Issued Books" };

            foreach (var lbl in mainLabels.Select((name, index) => (name, index))) {
                lbl.name.Text = fn.GetNumberOf(name: names[lbl.index]).ToString();
            }

            FullNameLbl.Text = Properties.Settings.Default.fullName;
            UsernameLbl.Text = Properties.Settings.Default.username;
            TypeLbl.Text = Properties.Settings.Default.accountType;
            FineFeesLbl.Text = "Rs. " + fn.GetNumberOf("Monthly FineFees").ToString("0.00");
        }

        private void ManageDataGridLoad() {

            MainDgv.Columns.Clear();

            if (ActionBtn.Text == "MANAGE BOOK") {
                dgv.ShowGrid(dgv: MainDgv, name: "Manage Books", searchQuery: SearchTb.Text, fromDate: FromDtp.Value.ToString("yyyy-MM-dd"), toDate: ToDtp.Value.ToString("yyyy-MM-dd"));
                dgv.GridWidth(dgv: MainDgv, widths: new int[] { 150, 250, 150, 150, 250, 150, 150, 150 });
            } else if (ActionBtn.Text == "NEW BORROW") {
                dgv.ShowGrid(dgv: MainDgv, name: "Borrow Books", searchQuery: SearchTb.Text, fromDate: FromDtp.Value.ToString("yyyy-MM-dd"), toDate: ToDtp.Value.ToString("yyyy-MM-dd"));
                dgv.GridWidth(dgv: MainDgv, widths: new int[] { 175, 300, 250, 200, 200, 200, 150 });
                if (MainDgv.RowCount > 0) MainDgv.CurrentCell.Selected = false;
                dgv.GridColor(MainDgv);
            }
        }

        private void CustomizeButton(Guna2Button btn, string name, Color fillColor) {
            btn.Text = name;
            btn.FillColor = fillColor;
            btn.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void DateTimePickers(bool isVisible) {
            FromDtp.Visible = isVisible;
            ToDtp.Visible = isVisible;
            FromLbl.Visible = isVisible;
            ToLbl.Visible = isVisible;

            // Changing Mainage Books DateTimePicker values
            FromDtp.Value = DateTime.Now.AddDays(-30);
            ToDtp.Value = DateTime.Now;
        }

        public void Alert(string title, string body, AlertForm.EnmType type) {
            AlertForm alertForm = new AlertForm();
            alertForm.ShowAlert(title: title, body: body, type: type);
        }

        #endregion Methods


        #region Member Area
        private void MemberDashboard(bool visible) {
            MainPanel.Show();
            MemberHiddenWidgets();
            MemberDynamicWidgets(visible: !visible);
            MDashboardPanel.Visible = visible;
            MDashboardPanel2.Visible = visible;
            MainDgv.Visible = !visible;

            // Load Data
            //mid, email, CONCAT(fname, ' ', lname), date, address, telephone
            DataTable dt = fn.GetDataTable(name: "Member", value: Properties.Settings.Default.id);

            Guna2HtmlLabel[] labels = { MIDLbl, MEmailLbl, MNameLbl, MTpLbl, MAddressLbl };
            foreach (var lbl in labels.Select((name, index) => (name, index))) {
                lbl.name.Text = dt.Rows[0][lbl.index].ToString();
            }

            MJoinDateLbl.Text = Convert.ToDateTime(dt.Rows[0][5]).ToString("yyyy-MM-dd");
            MPendingBooksLbl.Text = fn.GetNumberOf(name: "Already Borrowed Books", value: Properties.Settings.Default.id).ToString();
        }

        private void MemberDynamicWidgets(bool visible) {
            SearchTb.Visible = visible;
            guna2PictureBox2.Visible = visible;
            RecentUpdateLbl.Visible = visible;
            Title2Lbl.Visible = visible;
        }

        private void MemberHiddenWidgets() {
            if (!fn.IsStaff()) {
                BorrowBooksBtn.Text = "My Books List";
                BooksBtn.Text = "Books Details";

                Guna2Button[] btns = { MangeBooksBtn, MembersBtn, StaffsBtn, SettingsBtn, ActionBtn, Action2Btn, Action3Btn };
                foreach (var btn in btns) { btn.Visible = false; }

                DashboardPanel.Visible = false;
                DateTimePickers(isVisible: false);
            }
        }

        #endregion
    }
}
