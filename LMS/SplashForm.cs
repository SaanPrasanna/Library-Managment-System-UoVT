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

        private void timer1_Tick(object sender, EventArgs e) {

            ProgressBar.Increment(2);
            LoadingDigitLbl.Text = ProgressBar.Value.ToString() + " %...";

            if (ProgressBar.Value == 100) {
                timer1.Stop();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Close();
            }
        }
    }
}
