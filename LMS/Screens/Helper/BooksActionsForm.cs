using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;
using ZXing;
using Guna.UI2.WinForms;
using LMS.Utils.Core;
using LMS.Utils.Connection;
using LMS.Screens.Widgets;

namespace LMS {
    public partial class BooksActionsForm : Form {

        private readonly MainForm Mf;
        private readonly GridControlSettings dgv = new GridControlSettings();

        public BooksActionsForm(MainForm form, string title, string isbn) {
            InitializeComponent();

            this.Mf = form;
            TitleLbl.Text = title;
            ActionBtn.Text = title.ToUpper();
            ISBNTb.Text = isbn;

            if (title == "Add Book") {
                ActionBtn.FillColor = Color.FromArgb(77, 200, 86);
                QtyLbl.Text = "Initial Quantity";
                QtyTB.Enabled = true;
            } else if (title == "Modify Book") {
                LoadData(isbn);
                ISBNTb.Enabled = false;
                ActionBtn.FillColor = Color.FromArgb(248, 187, 0);
                QtyLbl.Text = "Quantity";
                QtyTB.Enabled = false;
            }
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

        private void LoadData(string isbn) {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try {
                string query = "SELECT title, author, pid, price, quantity, category FROM books WHERE isbn = @isbn;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = isbn;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                Guna2TextBox[] tb = new[] { TitleTb, AuthorTb, PublisherTb, PriceTb, QtyTB };
                foreach (var textBox in tb.Select((name, index) => (name, index))) {
                    textBox.name.Text = table.Rows[0][textBox.index].ToString();
                }
                CategoryCb.Text = table.Rows[0][5].ToString();
            } catch (Exception ex) {
                Console.WriteLine("Error: " + ex.ToString());
            } finally {
                Console.ReadLine();
                conn.Close();
                conn.Dispose();
            }
        }

        public void Alert(string title, string body, AlertForm.EnmType type) {
            AlertForm alertForm = new AlertForm();
            alertForm.ShowAlert(title: title, body: body, type: type);
        }
        #endregion

        #region Button Click
        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ChooseBtn_Click(object sender, EventArgs e) {
            ChooseForm chooseForm = new ChooseForm(booksActions: this);
            chooseForm.ShowDialog();
        }

        private void ActionBtn_Click(object sender, EventArgs e) {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            if (ISBNTb.Text != string.Empty && TitleTb.Text != string.Empty && AuthorTb.Text != string.Empty
                && CategoryCb.Text != string.Empty && PriceTb.Text != string.Empty && PublisherTb.Text != string.Empty && QtyTB.Text != string.Empty) {

                if (ActionBtn.Text == "ADD BOOK") {

                    try {
                        SqlCommand cmd = new SqlCommand("addBook", conn) {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = ISBNTb.Text;
                        cmd.Parameters.Add("@title", SqlDbType.NVarChar, 150).Value = TitleTb.Text;
                        cmd.Parameters.Add("@author", SqlDbType.NVarChar, 100).Value = AuthorTb.Text;
                        cmd.Parameters.Add("@category", SqlDbType.VarChar, 20).Value = CategoryCb.Text;
                        cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = PriceTb.Text;
                        cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = Convert.ToInt32(QtyTB.Text);
                        cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
                        cmd.Parameters.Add("@time", SqlDbType.Time).Value = DateTime.Now.ToString("HH:mm:ss");
                        cmd.Parameters.Add("@sid", SqlDbType.VarChar, 6).Value = Properties.Settings.Default.id;
                        cmd.Parameters.Add("@pid", SqlDbType.VarChar, 6).Value = PublisherTb.Text;
                        cmd.Parameters.Add("@isRemoved", SqlDbType.TinyInt).Value = 0;

                        int rowCount = cmd.ExecuteNonQuery();
                        if (rowCount > 0) {

                            dgv.ShowGrid(dgv: Mf.MainDgv, name: "Books");
                            if (Mf.MainDgv.ColumnCount == 0) {

                                Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91) };
                                Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91) };
                                string[] names = { "Modify", "Remove" };

                                dgv.GridButtons(dgv: Mf.MainDgv, names: names, backColors: backColors, selectionColors: selectColors);
                            }
                            dgv.GridWidth(dgv: Mf.MainDgv, widths: new int[] { 0, 0, 150, 250, 250, 100, 250, 100, 100 });

                            this.Alert("Process Success!", "Book Added Successfully!", AlertForm.EnmType.Success);
                            this.Close();
                        }

                    } catch (Exception ex) {
                        this.Alert("Process Failed!", "Book already exist", AlertForm.EnmType.Warning);
                        Console.WriteLine("Action Book Error: " + ex.ToString());
                    } finally {
                        conn.Close();
                        conn.Dispose();
                        Console.ReadLine();
                    }

                } else if (ActionBtn.Text == "MODIFY BOOK") {

                    try {
                        SqlCommand cmd = new SqlCommand("modifyBook", conn) {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.Add("@title", SqlDbType.NVarChar, 150).Value = TitleTb.Text;
                        cmd.Parameters.Add("@author", SqlDbType.NVarChar, 100).Value = AuthorTb.Text;
                        cmd.Parameters.Add("@category", SqlDbType.VarChar, 20).Value = CategoryCb.Text;
                        cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = PriceTb.Text;
                        cmd.Parameters.Add("@pid", SqlDbType.VarChar, 6).Value = PublisherTb.Text;
                        cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = ISBNTb.Text;

                        int rowCount = cmd.ExecuteNonQuery();
                        if (rowCount > 0) {

                            dgv.ShowGrid(dgv: Mf.MainDgv, name: "Books");
                            if (Mf.MainDgv.ColumnCount == 0) {

                                Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91) };
                                Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91) };
                                string[] names = { "Modify", "Remove" };

                                dgv.GridButtons(dgv: Mf.MainDgv, names: names, backColors: backColors, selectionColors: selectColors);
                            }
                            dgv.GridWidth(dgv: Mf.MainDgv, widths: new int[] { 0, 0, 150, 250, 250, 100, 250, 100, 100 });

                            this.Alert("Process Success!", "Book Updated Successfully!", AlertForm.EnmType.Success);
                            this.Close();
                            Mf.Show();
                        }

                    } catch (Exception ex) {
                        this.Alert("Process Failed!", "Book Updation Failed!", AlertForm.EnmType.Error);
                        Console.WriteLine("Action Book Error: " + ex.ToString());
                    } finally {
                        Mf.SearchTb.Text = string.Empty;
                        conn.Close();
                        conn.Dispose();
                        Console.ReadLine();
                    }

                }

            } else {
                this.Alert("Warning!", "Fields can't be empty!\nPlease fill all fields and submit again.!", AlertForm.EnmType.Warning);
            }
        }
        #endregion

        #region Key Events

        private void UsernameTb_TextChanged(object sender, EventArgs e) {
            try {
                var writer = new BarcodeWriter {
                    Format = BarcodeFormat.CODE_128
                };
                ISBNPb.Image = writer.Write(ISBNTb.Text);
            } catch (Exception ex) {
                Console.WriteLine("Error: " + ex.ToString());
            } finally {
                Console.ReadLine();
            }
        }

        private void BooksActions_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            } else if (e.Control && e.KeyCode == Keys.S || e.KeyCode == Keys.Enter) {
                ActionBtn_Click(sender, e);
            }
        }

        private void PriceTb_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }


        private void ISBNTb_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void QtyTB_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        #endregion

    }
}
