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
                dgv.ShowGrid(dgv: ChooseDgv, name: "Publishers");
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
    }
}
