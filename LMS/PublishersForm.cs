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

namespace LMS {
    public partial class PublishersForm : Form {
        public PublishersForm() {
            InitializeComponent();
        }

        private void PublishersForm_Load(object sender, EventArgs e) {

            Functions fn = new Functions();
            GridControlSettings dgv = new GridControlSettings();

            if (PublishersDgv.ColumnCount == 0) {
                dgv.GridButtons(dgv: PublishersDgv);
            }
            dgv.ShowGrid(dgv: PublishersDgv, name: "Publishers");
            dgv.GridWidth(dgv: PublishersDgv, widths: new int[] { 0, 0, 150, 200, 150 });

            Title2Lbl.Text = "Total Publishers : " + fn.GetNumberOf(name: "Publishers").ToString();
            RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt");
            SearchTb.PlaceholderText = "Search By Name";
        }

        private void PublishersDgv_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            String pid = PublishersDgv.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (e.ColumnIndex == 0) {

                PublishersActionsForm publisher = new PublishersActionsForm(form: this, title: "Modify Publisher", pid: pid);
                publisher.ShowDialog();

            } else if (e.ColumnIndex == 1) {

                MessageBox.Show("Publishers removed forbidden!", "Disabled Function", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void ActionBtn_Click(object sender, EventArgs e) {

            Functions fn = new Functions();
            if (ActionBtn.Text == "ADD PUBLISHER") {
                PublishersActionsForm publisherForm = new PublishersActionsForm(form: this, title: "Add Publisher", fn.GetID(name: "Publisher"));
                publisherForm.ShowDialog();
            }
        }

        private void SearchTb_KeyUp(object sender, KeyEventArgs e) {

            GridControlSettings dgv = new GridControlSettings();
            dgv.ShowGrid(dgv: PublishersDgv, name: "Publishers", searchQuery: SearchTb.Text);
            dgv.GridWidth(dgv: PublishersDgv, widths: new int[] { 0, 0, 150, 200, 150 });

        }
    }
}
