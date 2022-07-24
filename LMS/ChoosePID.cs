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
    public partial class ChoosePID : Form {
        public BooksActionsForm form;
        public ChoosePID(BooksActionsForm form) {
            InitializeComponent();
            this.form = form;

            GridControlSettings dgv = new GridControlSettings();
            dgv.ShowGrid(dgv: ChooseDgv, name: "Publishers");
        }

        private void ChooseDgv_CellEnter(object sender, DataGridViewCellEventArgs e) {
            form.PublisherTb.Text = ChooseDgv.CurrentRow.Cells[0].Value.ToString();
        }

        private void ChoosePID_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
