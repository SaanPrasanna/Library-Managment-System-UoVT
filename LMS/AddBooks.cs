using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace LMS {
    public partial class AddBooks : Form {
        MainForm Mf;
        public AddBooks(MainForm mf) {
            InitializeComponent();
            this.Mf = mf;
        }

        private void UsernameTb_TextChanged(object sender, EventArgs e) {
            try {
                var writer = new BarcodeWriter();
                writer.Format = BarcodeFormat.CODE_128;
                ISBNPb.Image = writer.Write(ISBNTb.Text);
            } catch (Exception ex) {
                Console.WriteLine("Error: " + ex.ToString());
            } finally {
                Console.ReadLine();
            }
        }
        private void AddBooksBtn_Click(object sender, EventArgs e) {
            if (ISBNTb.Text != string.Empty && TitleTb.Text != string.Empty && AuthorTb.Text != string.Empty
                && CategoryTb.Text != string.Empty && PriceTb.Text != string.Empty && PublisherTb.Text != string.Empty) {
                string query = "INSERT INTO books VALUES(@isbn, @title, @author, @category, @price, @quantity, @date, @time, @sid, @pid, @isRemoved );";
            }
        }

        private void AddBooks_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
                this.Dispose();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
            this.Dispose();
        }

    }
}
