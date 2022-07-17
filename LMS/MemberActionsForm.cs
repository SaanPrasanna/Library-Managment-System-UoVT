using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS {
    public partial class MemberActionsForm : Form {
        MainForm mf;
        public MemberActionsForm(MainForm form, string title, string mid) {
            InitializeComponent();

            TitleLbl.Text = title;
            this.mf = form;
        }
    }
}
