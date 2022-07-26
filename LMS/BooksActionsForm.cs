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
using Guna.UI2.WinForms;
using System.Runtime.InteropServices;

namespace LMS {
    public partial class BooksActionsForm : Form {

        MainForm Mf;

        protected override CreateParams CreateParams {
            get {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public BooksActionsForm(MainForm form, string title, string isbn) {
            InitializeComponent();

            this.Mf = form;
            TitleLbl.Text = title;
            ActionBtn.Text = title.ToUpper();
            ISBNTb.Text = isbn;

            if (title == "Add Book") {
                ActionBtn.FillColor = Color.FromArgb(77, 200, 86);
            } else if (title == "Modify Book") {
                LoadData(isbn);
                ISBNTb.Enabled = false;
                ActionBtn.FillColor = Color.FromArgb(248, 187, 0);
            }
        }

        private void LoadData(string isbn) {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try {
                string query = "SELECT title, author, pid, category, price  FROM books WHERE isbn = @isbn;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = isbn;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                Guna2TextBox[] tb = new[] { TitleTb, AuthorTb, PublisherTb, CategoryTb, PriceTb };
                foreach (var textBox in tb.Select((name, index) => (name, index))) {
                    textBox.name.Text = table.Rows[0][textBox.index].ToString();
                }

            } catch (Exception ex) {
                Console.WriteLine("Error: " + ex.ToString());
            } finally {
                Console.ReadLine();
                conn.Close();
                conn.Dispose();
            }
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
        private void ActionBtn_Click(object sender, EventArgs e) {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            if (ISBNTb.Text != string.Empty && TitleTb.Text != string.Empty && AuthorTb.Text != string.Empty
                && CategoryTb.Text != string.Empty && PriceTb.Text != string.Empty && PublisherTb.Text != string.Empty) {

                if (ActionBtn.Text == "ADD BOOK") {

                    try {
                        string query = "INSERT INTO books VALUES(@isbn, @title, @author, @category, @price, @quantity, @date, @time, @sid, @pid, @isRemoved);";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = ISBNTb.Text;
                        cmd.Parameters.Add("@title", SqlDbType.NVarChar, 150).Value = TitleTb.Text;
                        cmd.Parameters.Add("@author", SqlDbType.NVarChar, 100).Value = AuthorTb.Text;
                        cmd.Parameters.Add("@category", SqlDbType.VarChar, 20).Value = CategoryTb.Text;
                        cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = PriceTb.Text;
                        cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = 0;
                        cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
                        cmd.Parameters.Add("@time", SqlDbType.Time).Value = DateTime.Now.ToString("HH:mm:ss");
                        cmd.Parameters.Add("@sid", SqlDbType.VarChar, 6).Value = "S00001"; // TODO: After all functionalities are completed
                        cmd.Parameters.Add("@pid", SqlDbType.VarChar, 6).Value = PublisherTb.Text;
                        cmd.Parameters.Add("@isRemoved", SqlDbType.TinyInt).Value = 0;

                        int rowCount = cmd.ExecuteNonQuery();
                        if (rowCount > 0) {

                            GridControlSettings dgv = new GridControlSettings();

                            dgv.ShowGrid(dgv: Mf.MainDgv, name: "Books");
                            if (Mf.MainDgv.ColumnCount == 0) {
                                dgv.GridButtons(dgv: Mf.MainDgv);
                            }
                            dgv.GridWidth(dgv: Mf.MainDgv, widths: new int[] { 0, 0, 150, 250, 250, 100, 250, 100, 100 });

                            MessageBox.Show("Book added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                    } catch (Exception ex) {
                        MessageBox.Show("Book already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Console.WriteLine("Action Book Error: " + ex.ToString());
                    } finally {
                        conn.Close();
                        conn.Dispose();
                        Console.ReadLine();
                    }

                } else if (ActionBtn.Text == "MODIFY BOOK") {

                    try {

                        string query = "UPDATE books SET title = @title, author = @author, category = @category, " +
                        "price = @price, pid = @pid WHERE isbn = @isbn;";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.Add("@title", SqlDbType.NVarChar, 150).Value = TitleTb.Text;
                        cmd.Parameters.Add("@author", SqlDbType.NVarChar, 100).Value = AuthorTb.Text;
                        cmd.Parameters.Add("@category", SqlDbType.VarChar, 20).Value = CategoryTb.Text;
                        cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = PriceTb.Text;
                        cmd.Parameters.Add("@pid", SqlDbType.VarChar, 6).Value = PublisherTb.Text;
                        cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = ISBNTb.Text;

                        int rowCount = cmd.ExecuteNonQuery();
                        if (rowCount > 0) {

                            GridControlSettings dgv = new GridControlSettings();

                            dgv.ShowGrid(dgv: Mf.MainDgv, name: "Books");
                            if (Mf.MainDgv.ColumnCount == 0) {
                                dgv.GridButtons(dgv: Mf.MainDgv);
                            }
                            dgv.GridWidth(dgv: Mf.MainDgv, widths: new int[] { 0, 0, 150, 250, 250, 100, 250, 100, 100 });

                            MessageBox.Show("Book updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            Mf.Show();
                        }

                    } catch (Exception ex) {
                        MessageBox.Show("Book updation failed!\nTry Again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Console.WriteLine("Action Book Error: " + ex.ToString());
                    } finally {
                        Mf.SearchTb.Text = string.Empty;
                        conn.Close();
                        conn.Dispose();
                        Console.ReadLine();
                    }

                }

            } else {
                MessageBox.Show("Fields can't be empty!\nPlease fill all fields and submit again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BooksActions_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
                //this.Dispose();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
            //this.Dispose();
        }

        private void PriceTb_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }

        private void ChooseBtn_Click(object sender, EventArgs e) {
            ChooseForm chooseForm = new ChooseForm(booksActions: this);
            chooseForm.ShowDialog();
        }

        private void ISBNTb_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}
