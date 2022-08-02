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

namespace LMS {
    public partial class SecondForm : Form {

        MainForm mf;

        public SecondForm(MainForm form, string title) {
            InitializeComponent();

            this.mf = form;
            InitialForm(title);
            Console.WriteLine(title);
        }

        private void InitialForm(string title) {

            Functions fn = new Functions();
            GridControlSettings dgv = new GridControlSettings();

            RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt");
            SearchTb.PlaceholderText = "Search By Name";

            if (title == "Publishers") {

                SecondDgv.Columns.Clear();
                if (SecondDgv.ColumnCount == 0) {
                    dgv.GridButtons(dgv: SecondDgv);
                }
                dgv.ShowGrid(dgv: SecondDgv, name: "Publishers");
                dgv.GridWidth(dgv: SecondDgv, widths: new int[] { 0, 0, 150, 200, 150 });

                TitleLbl.Text = "Publishers";
                Title2Lbl.Text = "Total Publishers : " + fn.GetNumberOf(name: "Publishers").ToString();
                ActionBtn.Text = "ADD PUBLISHER";
            }
        }

        private void PublishersDgv_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            String pid = SecondDgv.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (e.ColumnIndex == 0) {

                PublishersActionsForm publisher = new PublishersActionsForm(form: this, title: "Modify Publisher", pid: pid );
                publisher.ShowDialog();

            } else if (e.ColumnIndex == 1) {

                MessageBox.Show("Publishers removed forbidden!", "Disabled Function", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void ActionBtn_Click(object sender, EventArgs e) {

            Functions fn = new Functions();
            if (ActionBtn.Text == "ADD PUBLISHER") {
                PublishersActionsForm publisherForm = new PublishersActionsForm(form: this, title: "Add Publisher", fn.GetID(name: "Publisher"));
                publisherForm.ShowDialog();
            }
        }

        private void SearchTb_KeyUp(object sender, KeyEventArgs e) {

            GridControlSettings dgv = new GridControlSettings();

            if (ActionBtn.Text == "ADD PUBLISHER") {
                dgv.ShowGrid(dgv: SecondDgv, name: "Publishers", searchQuery: SearchTb.Text);
                dgv.GridWidth(dgv: SecondDgv, widths: new int[] { 0, 0, 150, 200, 150 });
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
                this.Close();
            }
        }
    }
}
