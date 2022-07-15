using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Utils.Components {
    public class DoubleBufferedTableLayoutPanel : TableLayoutPanel {
        public DoubleBufferedTableLayoutPanel()
            : base() {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }
    }
}
