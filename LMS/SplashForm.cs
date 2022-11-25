using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LMS {
    public partial class SplashForm : Form {
        public SplashForm() {
            InitializeComponent();

        }

        protected override CreateParams CreateParams {
            get {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {

            ProgressBar.Increment(2);
            LoadingDigitLbl.Text = ProgressBar.Value.ToString() + " %...";

            if (ProgressBar.Value == 102) {
                timer1.Stop();
                MainForm mainForm = new MainForm();
                //mainForm.Show();
                //this.Close();
            }
        }
    }
}
