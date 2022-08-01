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

namespace LMS {
    public partial class ManageBooksForm : Form {
        public ManageBooksForm() {
            InitializeComponent();
            LoadGrid();
        }

        protected override CreateParams CreateParams {
            get {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void SearchTb_KeyUp(object sender, KeyEventArgs e) {
            LoadGrid();
        }

        private void LoadGrid() {
            GridControlSettings dgv = new GridControlSettings();

            dgv.ShowGrid(dgv: SelectionDgv, name: "Books Limit Columns", searchQuery: SearchTb.Text);
            dgv.GridWidth(dgv: SelectionDgv, widths: new int[] { 150, 150 });
        }

        private void SelectionDgv_CellEnter(object sender, DataGridViewCellEventArgs e) {

            ISBNTb.Text = SelectionDgv.CurrentRow.Cells[0].Value.ToString();
            TitleTb.Text = SelectionDgv.CurrentRow.Cells[1].Value.ToString();
            QtyTb.Text = SelectionDgv.CurrentRow.Cells[2].Value.ToString();
            ActionCalculation();
        }

        private void ActionCalculation() {
            if (ActionCb.Text != string.Empty) {
                if (ActionCb.Text == "ADD") {
                    FQtyTb.Text = (Int32.Parse(QtyTb.Text) + ((AQtyTb.Text != string.Empty) ? Int32.Parse(AQtyTb.Text) : 0)).ToString();
                } else {
                    if (Int32.Parse(QtyTb.Text) >= Int32.Parse(AQtyTb.Text)) {
                        FQtyTb.Text = (Int32.Parse(QtyTb.Text) - ((AQtyTb.Text != string.Empty) ? Int32.Parse(AQtyTb.Text) : 0)).ToString();
                    } else {
                        FQtyTb.Text = string.Empty;
                        AQtyTb.Text = string.Empty;
                        ActionCb.SelectedIndex = -1;
                        MessageBox.Show("Not Enough Quantities To Remove!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void AQtyTb_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void AQtyTb_KeyUp(object sender, KeyEventArgs e) {
            ActionCalculation();
        }

        private void ActionCb_SelectedIndexChanged(object sender, EventArgs e) {
            ActionCalculation();
        }

        private void ManageBtn_Click(object sender, EventArgs e) {

        }
    }
}
