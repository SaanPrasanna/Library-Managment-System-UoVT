using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using ZXing;
using LMS.Utils;

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

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            if (ISBNTb.Text != string.Empty && TitleTb.Text != string.Empty && AuthorTb.Text != string.Empty
                && CategoryTb.Text != string.Empty && PriceTb.Text != string.Empty && PublisherTb.Text != string.Empty) {

                string query = "INSERT INTO books VALUES(@isbn, @title, @author, @category, @price, @quantity, @date, @time, @sid, @pid, @isRemoved);";

                try {

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = ISBNTb.Text;
                    cmd.Parameters.Add("@title", SqlDbType.VarChar, 150).Value = TitleTb.Text;
                    cmd.Parameters.Add("@author", SqlDbType.VarChar, 100).Value = AuthorTb.Text;
                    cmd.Parameters.Add("@category", SqlDbType.VarChar, 20).Value = CategoryTb.Text;
                    cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = PriceTb.Text;
                    cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@time", SqlDbType.Time).Value = DateTime.Now.ToString("HH:mm:ss");
                    cmd.Parameters.Add("@sid", SqlDbType.VarChar, 6).Value = "S00001"; // TODO: After all functionalities are completed
                    cmd.Parameters.Add("@pid", SqlDbType.VarChar, 6).Value = "P00001";// TODO: After creating the Publisher form
                    cmd.Parameters.Add("@isRemoved", SqlDbType.TinyInt).Value = 0;

                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount > 0) {

                        GridControlSettings dgv = new GridControlSettings();

                        if (Mf.MainDgv.ColumnCount < 9) {
                            dgv.GridButtons(dgv: Mf.MainDgv);
                        }
                        dgv.ShowGrid(dgv: Mf.MainDgv, name: "Books");
                        dgv.GridWidth(dgv: Mf.MainDgv, widths: new int[] { 0, 0, 150, 250, 250, 100, 250, 100, 100 });

                        MessageBox.Show("Book added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        Mf.Show();
                    }


                } catch (Exception ex) {
                    Console.WriteLine("Add Book Error: " + ex.ToString());
                } finally {
                    conn.Close();
                    conn.Dispose();
                    Console.ReadLine();
                }

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

        private void PriceTb_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }

        private void ChooseBtn_Click(object sender, EventArgs e) {
            // TODO: After creating the Publisher form
        }
    }
}
