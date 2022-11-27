using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LMS.Utils;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace LMS {
    public partial class ManageBooksForm : Form {

        MainForm mf;

        public ManageBooksForm(MainForm form) {
            InitializeComponent();
            this.mf = form;
            LoadGrid();
        }

        protected override CreateParams CreateParams {
            get {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        private void LoadGrid() {
            GridControlSettings dgv = new GridControlSettings();

            dgv.ShowGrid(dgv: SelectionDgv, name: "Books Limit Columns", searchQuery: SearchTb.Text);
            dgv.GridWidth(dgv: SelectionDgv, widths: new int[] { 150, 150 });
        }

        private void SelectionDgv_CellEnter(object sender, DataGridViewCellEventArgs e) {

            Guna2TextBox[] tb = new[] { ISBNTb, TitleTb, QtyTb };
            foreach (var textBox in tb.Select((name, index) => (name, index))) {
                textBox.name.Text = SelectionDgv.CurrentRow.Cells[textBox.index].Value.ToString();
            }
            ActionCalculation();
        }

        private void ActionCalculation() {
            if (ActionCb.Text != string.Empty && AQtyTb.Text != string.Empty) {
                if (ActionCb.Text == "Add") {
                    FQtyTb.Text = (Int32.Parse(QtyTb.Text) + ((AQtyTb.Text != string.Empty) ? Int32.Parse(AQtyTb.Text) : 0)).ToString();
                } else {
                    if (Int32.Parse(QtyTb.Text) >= Int32.Parse(AQtyTb.Text)) {
                        FQtyTb.Text = (Int32.Parse(QtyTb.Text) - ((AQtyTb.Text != string.Empty) ? Int32.Parse(AQtyTb.Text) : 0)).ToString();
                    } else {
                        FQtyTb.Text = string.Empty;
                        AQtyTb.Text = string.Empty;
                        ActionCb.SelectedIndex = -1;
                        MessageBox.Show("Not Enough Quantities to Remove!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void ManageBtn_Click(object sender, EventArgs e) {

            if (ISBNTb.Text != string.Empty && AQtyTb.Text != string.Empty && ActionCb.Text != string.Empty && FQtyTb.Text != string.Empty) {

                Functions fn = new Functions();
                GridControlSettings dgv = new GridControlSettings();
                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();

                try {

                    string query = "INSERT INTO books_manage VALUES(@refID, @isbn, @sid, @qty, @action, @description, @date, @time);";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@refID", SqlDbType.VarChar, 6).Value = fn.GetID("Books Manage");
                    cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = ISBNTb.Text;
                    cmd.Parameters.Add("@sid", SqlDbType.VarChar, 6).Value = "S00001"; // TODO: Properties.Settings.Default.sid
                    cmd.Parameters.Add("@qty", SqlDbType.Int).Value = Int32.Parse(AQtyTb.Text);
                    cmd.Parameters.Add("@action", SqlDbType.VarChar, 10).Value = ActionCb.Text;
                    cmd.Parameters.Add("@description", SqlDbType.VarChar, 50).Value = DescriptionTb.Text;
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@time", SqlDbType.Time).Value = DateTime.Now.ToString("HH:mm:ss");

                    string query2 = "UPDATE books SET quantity = @qty WHERE isbn = @isbn";
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    cmd2.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = ISBNTb.Text;
                    cmd2.Parameters.Add("@qty", SqlDbType.Int).Value = Int32.Parse(FQtyTb.Text);

                    if ((Int32)cmd.ExecuteNonQuery() > 0 && (Int32)cmd2.ExecuteNonQuery() > 0) {

                        MessageBox.Show("Book(s) " + ActionCb.Text + ((ActionCb.Text == "Add") ? "ed!" : "d!"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FQtyTb.Text = string.Empty;
                        AQtyTb.Text = string.Empty;
                        DescriptionTb.Text = String.Empty;
                        ActionCb.SelectedIndex = -1;

                        LoadGrid();
                        mf.MainDgv.Columns.Clear();
                        dgv.ShowGrid(dgv: mf.MainDgv, name: "Manage Books", searchQuery: SearchTb.Text, fromDate: mf.FromDtp.Value.ToString("yyyy-MM-dd"), toDate: mf.ToDtp.Value.ToString("yyyy-MM-dd"));
                        dgv.GridWidth(dgv: mf.MainDgv, widths: new int[] { 150, 200, 150, 150, 250, 150 });
                    }

                } catch (Exception ex) {
                    MessageBox.Show("Book(s) " + ActionCb.Text + ((ActionCb.Text == "Add") ? "ed!" : "d!") + " Failed : \n" + ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } finally {
                    conn.Close();
                    Console.ReadLine();
                }
            } else {
                MessageBox.Show("Fields can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void SearchTb_KeyUp(object sender, KeyEventArgs e) {
            LoadGrid();
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ManageBooksForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }
        private void AQtyTb_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void AQtyTb_KeyUp(object sender, KeyEventArgs e) {
            ActionCalculation();
        }

        private void ActionCb_SelectedIndexChanged(object sender, EventArgs e) {
            ActionCalculation();
        }
    }
}
