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
        private string title, name, mID;
        public int NOB;
        readonly Functions fn = new Functions();
        readonly GridControlSettings dgv = new GridControlSettings();

        public SecondForm(MainForm form, string title) {
            InitializeComponent();

            this.mf = form;
            this.title = title;
            InitialForm();
        }

        private void InitialForm() {


            RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt");
            SearchTb.PlaceholderText = "Search By Name";

            if (title == "Publishers") {

                SecondDgv.Columns.Clear();
                if (SecondDgv.ColumnCount == 0) {

                    Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91) };
                    Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91) };
                    string[] names = { "Modify", "Remove" };

                    dgv.GridButtons(dgv: SecondDgv, names: names, backColors: backColors, selectionColors: selectColors);

                }
                dgv.ShowGrid(dgv: SecondDgv, name: "Publishers");
                dgv.GridWidth(dgv: SecondDgv, widths: new int[] { 0, 0, 150, 200, 150 });

                TitleLbl.Text = "Publishers";
                Title2Lbl.Text = "Total Publishers : " + fn.GetNumberOf(name: "Publishers").ToString();
                ActionBtn.Text = "ADD PUBLISHER";

            } else if (title == "Pending List") {

                SecondDgv.Columns.Clear();
                if (SecondDgv.ColumnCount == 0) {

                    Color[] backColors = { Color.FromArgb(77, 200, 86) };
                    Color[] selectColors = { Color.FromArgb(98, 222, 107) };
                    string[] names = { "Select Member" };

                    dgv.GridButtons(dgv: SecondDgv, names: names, backColors: backColors, selectionColors: selectColors);

                }
                dgv.ShowGrid(dgv: SecondDgv, name: "Pending Members", searchQuery: SearchTb.Text);
                dgv.GridWidth(dgv: SecondDgv, widths: new int[] { 0, 150, 200, 200 });

                TitleLbl.Text = title;
                Title2Lbl.Text = "Total Pending Books : " + fn.GetNumberOf(name: "Pending Books").ToString();
                ActionBtn.Visible = false;

            }
        }

        private void PublishersDgv_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            Functions fn = new Functions();

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

                    SecondDgv.Columns.Clear();
                    if (SecondDgv.ColumnCount == 0) {

                        Color[] backColors = { Color.FromArgb(94, 148, 255) };
                        Color[] selectColors = { Color.FromArgb(120, 160, 255) };
                        string[] names = { "Release" };

                        dgv.GridButtons(dgv: SecondDgv, names: names, backColors: backColors, selectionColors: selectColors);

                    }
                    dgv.ShowGrid(dgv: SecondDgv, name: "Pending Books", searchQuery: SearchTb.Text, searchQuery2: this.mID);
                    dgv.GridWidth(dgv: SecondDgv, widths: new int[] { 0, 110, 150, 200, 150, 150 });

                    TitleLbl.Text = "Pending Books";
                    Title2Lbl.Text = name + "'s Book(s) : " + NOB.ToString();
                    ActionBtn.Visible = true;
                    ActionBtn.Text = "RELEASE ALL";
                    SearchTb.Text = string.Empty;

                }

            } else if (TitleLbl.Text == "Pending Books") {
                string refNo = SecondDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                string isbn = SecondDgv.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (e.ColumnIndex == 0) {

                    BooksAcceptForm baf = new BooksAcceptForm(this, new string[] { refNo, isbn, mID, name, NOB.ToString() }); // 0 - RefNo, 1 - ISBN, 2 - MemberID
                    baf.ShowDialog();

                }

            }
        }

        private void ActionBtn_Click(object sender, EventArgs e) {

            Functions fn = new Functions();
            if (ActionBtn.Text == "ADD PUBLISHER") {
                PublishersActionsForm publisherForm = new PublishersActionsForm(form: this, title: "Add Publisher", fn.GetID(name: "Publisher"));
                publisherForm.ShowDialog();
            } else if (ActionBtn.Text == "RELEASE ALL") {
            }
        }

        private void SearchTb_KeyUp(object sender, KeyEventArgs e) {

            GridControlSettings dgv = new GridControlSettings();

            if (ActionBtn.Text == "ADD PUBLISHER") {

                SecondDgv.Columns.Clear();
                if (SecondDgv.ColumnCount == 0) {

                    Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91) };
                    Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91) };
                    string[] names = { "Modify", "Remove" };

                    dgv.GridButtons(dgv: SecondDgv, names: names, backColors: backColors, selectionColors: selectColors);
                    //dgv.GridButtons(dgv: SecondDgv);
                }
                dgv.ShowGrid(dgv: SecondDgv, name: "Publishers", searchQuery: SearchTb.Text);
                dgv.GridWidth(dgv: SecondDgv, widths: new int[] { 0, 0, 150, 200, 150 });

            } else if (TitleLbl.Text == "Pending List") {

                SecondDgv.Columns.Clear();
                if (SecondDgv.ColumnCount == 0) {

                    Color[] backColors = { Color.FromArgb(77, 200, 86) };
                    Color[] selectColors = { Color.FromArgb(98, 222, 107) };
                    string[] names = { "Select Member" };

                    dgv.GridButtons(dgv: SecondDgv, names: names, backColors: backColors, selectionColors: selectColors);

                }
                dgv.ShowGrid(dgv: SecondDgv, name: "Pending Members", searchQuery: SearchTb.Text);
                dgv.GridWidth(dgv: SecondDgv, widths: new int[] { 0, 150, 200, 200 });

            } else if (TitleLbl.Text == "Pending Books") {
                SecondDgv.Columns.Clear();
                if (SecondDgv.ColumnCount == 0) {

                    Color[] backColors = { Color.FromArgb(94, 148, 255) };
                    Color[] selectColors = { Color.FromArgb(120, 160, 255) };
                    string[] names = { "Release" };

                    dgv.GridButtons(dgv: SecondDgv, names: names, backColors: backColors, selectionColors: selectColors);

                }
                dgv.ShowGrid(dgv: SecondDgv, name: "Pending Books", searchQuery: SearchTb.Text, searchQuery2: this.mID);
                dgv.GridWidth(dgv: SecondDgv, widths: new int[] { 0, 110, 150, 200, 150, 150 });
            }

        }

        protected override CreateParams CreateParams {
            get {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void PublishersForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                if (ActionBtn.Text == "RELEASE ALL" && ActionBtn.Visible == true) {
                    SecondDgv.Columns.Clear();
                    if (SecondDgv.ColumnCount == 0) {

                        Color[] backColors = { Color.FromArgb(77, 200, 86) };
                        Color[] selectColors = { Color.FromArgb(98, 222, 107) };
                        string[] names = { "Select Member" };

                        dgv.GridButtons(dgv: SecondDgv, names: names, backColors: backColors, selectionColors: selectColors);

                    }
                    dgv.ShowGrid(dgv: SecondDgv, name: "Pending Members", searchQuery: SearchTb.Text);
                    dgv.GridWidth(dgv: SecondDgv, widths: new int[] { 0, 150, 200, 200 });

                    TitleLbl.Text = title;
                    Title2Lbl.Text = "Total Pending Books : " + fn.GetNumberOf(name: "Pending Books").ToString();
                    ActionBtn.Visible = false;
                    SearchTb.Text = string.Empty;

                } else {
                    this.Close();
                }
            }
        }
    }
}
