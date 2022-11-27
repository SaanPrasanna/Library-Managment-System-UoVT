using LMS.Utils;
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
    public partial class BorrowBooksForm : Form {

        Functions fn = new Functions();

        public BorrowBooksForm() {
            InitializeComponent();
        }

        private void BorrowBooksForm_Load(object sender, EventArgs e) {
            // Fixed Taskbar issue
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;
            {
                var withBlock = Screen.PrimaryScreen.WorkingArea;
                this.SetBounds(withBlock.Left, withBlock.Top, withBlock.Width, withBlock.Height);
            }
            LoadData();

        }

        public void LoadData() {

            DataTable table = fn.GetBooksNames();
            SearchTB.AutoCompleteCustomSource.Clear();
            foreach (DataRow row in table.Rows) {
                SearchTB.AutoCompleteCustomSource.Add(row.ItemArray[0].ToString());
            }

        }
    }
}
