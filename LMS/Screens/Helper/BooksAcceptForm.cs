using LMS.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS {
    public partial class BooksAcceptForm : Form {

        SecondForm sf;
        private string[] values; // 0 - RefNo, 1 - ISBN, 2 - MemberID, 3 - Name, 4 - NOB
        readonly Functions fn = new Functions();

        public BooksAcceptForm(SecondForm sf, string[] values) {
            this.sf = sf;
            this.values = values;

            InitializeComponent();
        }

        private void RecievedTB_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (RemainTB.Text != "--") {

                    SqlConnection conn = DBUtils.GetDBConnection();
                    conn.Open();
                    try {


                        string query = "UPDATE books SET quantity = @qty WHERE isbn = @isbn;";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.Add("@qty", SqlDbType.Int).Value = (fn.GetNumberOf(name: "Specified Book", value: values[1]) + 1);
                        cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = values[1];

                        string query2 = "UPDATE borrow_books SET return_date = @returnDate, status = 'Returned', fines_fee = @finesFee WHERE refno = @refNo AND mid = @mid AND isbn = @isbn;";
                        SqlCommand cmd2 = new SqlCommand(query2, conn);
                        cmd2.Parameters.Add("@returnDate", SqlDbType.Date).Value = DateTime.Now;
                        cmd2.Parameters.Add("@finesFee", SqlDbType.Decimal).Value = Convert.ToDouble(FineFeeTB.Text);
                        cmd2.Parameters.Add("@refNo", SqlDbType.VarChar, 12).Value = values[0];
                        cmd2.Parameters.Add("@mid", SqlDbType.VarChar, 6).Value = values[2];
                        cmd2.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = values[1];



                        if (cmd.ExecuteNonQuery() > 0 && cmd2.ExecuteNonQuery() > 0) {

                            GridControlSettings dgv = new GridControlSettings();


                            sf.SecondDgv.Columns.Clear();
                            Console.WriteLine("NOB {0}", sf.NOB);
                            if (sf.NOB > 1) {
                                if (sf.SecondDgv.ColumnCount == 0) {

                                    Color[] backColors = { Color.FromArgb(94, 148, 255) };
                                    Color[] selectColors = { Color.FromArgb(120, 160, 255) };
                                    string[] names = { "Release" };

                                    dgv.GridButtons(dgv: sf.SecondDgv, names: names, backColors: backColors, selectionColors: selectColors);

                                }
                                dgv.ShowGrid(dgv: sf.SecondDgv, name: "Pending Books", searchQuery: sf.SearchTb.Text, searchQuery2: values[2]);
                                dgv.GridWidth(dgv: sf.SecondDgv, widths: new int[] { 0, 110, 150, 200, 150, 150 });

                                sf.Title2Lbl.Text = values[3] + "'s Book(s) : " + (sf.NOB -= 1);

                            } else {
                                sf.SecondDgv.Columns.Clear();
                                if (sf.SecondDgv.ColumnCount == 0) {

                                    Color[] backColors = { Color.FromArgb(77, 200, 86) };
                                    Color[] selectColors = { Color.FromArgb(98, 222, 107) };
                                    string[] names = { "Select Member" };

                                    dgv.GridButtons(dgv: sf.SecondDgv, names: names, backColors: backColors, selectionColors: selectColors);

                                }
                                dgv.ShowGrid(dgv: sf.SecondDgv, name: "Pending Members", searchQuery: sf.SearchTb.Text);
                                dgv.GridWidth(dgv: sf.SecondDgv, widths: new int[] { 0, 150, 200, 200 });

                                sf.TitleLbl.Text = "Pending List";
                                sf.Title2Lbl.Text = "Total Pending Books : " + fn.GetNumberOf(name: "Pending Books").ToString();
                                sf.ActionBtn.Visible = false;
                            }

                            MessageBox.Show("Book Released!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }


                    } catch (Exception ex) {
                        MessageBox.Show("Book updation failed!\nTry Again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Console.WriteLine("Action Book Error: " + ex.ToString());
                    } finally {
                        conn.Close();
                        conn.Dispose();
                        Console.ReadLine();
                    }

                }
            }
        }

        private void RecievedTB_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.')) {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && RecievedTB.Text.IndexOf('.') > -1) {
                e.Handled = true;
            }
        }

        protected override CreateParams CreateParams {
            get {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void BooksAcceptForm_Load(object sender, EventArgs e) {
            FineFeeTB.Text = fn.GetFine(refNo: values[0], isbn: values[1]).ToString("00.00");
        }

        private void BooksAcceptForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void RecievedTB_KeyUp(object sender, KeyEventArgs e) {
            double fineFee, recieved;
            try {
                fineFee = Convert.ToDouble(FineFeeTB.Text);
                recieved = (RecievedTB.Text != string.Empty) ? Convert.ToDouble(RecievedTB.Text) : 0;
                if (fineFee <= recieved) {
                    RemainTB.Text = (recieved - fineFee).ToString("0.00");
                } else {
                    RemainTB.Text = "--";
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            } finally {
                Console.ReadLine();
            }
        }
    }
}
