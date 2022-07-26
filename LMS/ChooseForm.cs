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
using LMS.Utils;

namespace LMS {
    public partial class ChooseForm : Form {

        public BooksActionsForm booksActions;
        public MembersActionsForm membersActions;

        public ChooseForm([Optional] BooksActionsForm booksActions, [Optional] MembersActionsForm membersActions) {
            InitializeComponent();

            GridControlSettings dgv = new GridControlSettings();
            if (booksActions != null) {
                this.booksActions = booksActions;
                TitleLbl.Text = "Choose Publisher";
                SearchTb.PlaceholderText = "Search By Name";
                dgv.ShowGrid(dgv: ChooseDgv, name: "Publishers");
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

        private void ChooseDgv_CellEnter(object sender, DataGridViewCellEventArgs e) {
            if (booksActions != null) {
                booksActions.PublisherTb.Text = ChooseDgv.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void ChoosePID_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SearchTb_KeyUp(object sender, KeyEventArgs e) {

            GridControlSettings dgv = new GridControlSettings();
            if (booksActions != null) {
                dgv.ShowGrid(dgv: ChooseDgv, name: "Publishers", searchQuery: SearchTb.Text);
            }
        }
    }
}
