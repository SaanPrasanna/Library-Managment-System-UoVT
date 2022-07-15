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
    public partial class LoadingForm : Form {
        public LoadingForm() {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e) {
            ProgressBar.Increment(2);
            if (ProgressBar.Value == 100) {
                timer1.Stop();
            }
        }
    }
}
