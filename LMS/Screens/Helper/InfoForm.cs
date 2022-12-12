using System;
using System.Windows.Forms;

namespace LMS.Screens.Helper {
    public partial class InfoForm : Form {

        public InfoForm() {
            InitializeComponent();
        }

        #region Methods
        protected override CreateParams CreateParams {
            get {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        #endregion

        #region Key Events
        private void InfoForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                CloseBtn_Click(sender, e);
            }
        }
        #endregion

        #region Button Click
        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void ThanksBtn_Click(object sender, EventArgs e) {
            CloseBtn_Click(sender, e);
        }
        #endregion
    }
}
