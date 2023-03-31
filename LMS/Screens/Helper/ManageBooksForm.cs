using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using LMS.Utils.Core;
using LMS.Utils.Connection;
using LMS.Screens.Widgets;

namespace LMS {
    public partial class ManageBooksForm : Form {

        private readonly MainForm mf;
        readonly Functions fn = new Functions();
        readonly GridControlSettings dgv = new GridControlSettings();

        public ManageBooksForm(MainForm form) {
            InitializeComponent();
            this.mf = form;
            LoadGrid();
        }

        #region Selection DataGridView CellContentClick
        private void SelectionDgv_CellEnter(object sender, DataGridViewCellEventArgs e) {
            Guna2TextBox[] tb = new[] { ISBNTb, TitleTb, QtyTb };
            foreach (var textBox in tb.Select((name, index) => (name, index))) {
                textBox.name.Text = SelectionDgv.CurrentRow.Cells[textBox.index].Value.ToString();
            }
            ActionCalculation();
        }
        #endregion Selection DataGridView CellContentClick 

        #region Buttons
        private void ManageBtn_Click(object sender, EventArgs e) {
            if (ISBNTb.Text != string.Empty && AQtyTb.Text != string.Empty && ActionCb.Text != string.Empty && FQtyTb.Text != string.Empty) {

                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();

                try {
                    SqlCommand cmd = new SqlCommand("addBooksManage", conn) {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@refID", SqlDbType.VarChar, 6).Value = fn.GetID("Books Manage");
                    cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = ISBNTb.Text;
                    cmd.Parameters.Add("@sid", SqlDbType.VarChar, 6).Value = Properties.Settings.Default.id; // Implemented SID
                    cmd.Parameters.Add("@qty", SqlDbType.Int).Value = Int32.Parse(AQtyTb.Text);
                    cmd.Parameters.Add("@action", SqlDbType.VarChar, 10).Value = ActionCb.Text;
                    cmd.Parameters.Add("@description", SqlDbType.VarChar, 50).Value = DescriptionTb.Text;
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@time", SqlDbType.Time).Value = DateTime.Now.ToString("HH:mm:ss");

                    SqlCommand cmd2 = new SqlCommand("updateQty", conn) {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd2.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = ISBNTb.Text;
                    cmd2.Parameters.Add("@qty", SqlDbType.Int).Value = Int32.Parse(FQtyTb.Text);

                    if ((Int32)cmd.ExecuteNonQuery() > 0 && (Int32)cmd2.ExecuteNonQuery() > 0) {

                        this.Alert("Process Success!", "Book(s) " + ActionCb.Text + ((ActionCb.Text == "Add") ? "ed!" : "d!"), AlertForm.EnmType.Success);

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
                    this.Alert("Process Failed!", "Book(s) " + ActionCb.Text + ((ActionCb.Text == "Add") ? "ed!" : "d!") + " Failed", AlertForm.EnmType.Error);
                    Console.WriteLine("Error: || ManageBOoks ||\n" + ex.ToString());
                } finally {
                    conn.Close();
                    Console.ReadLine();
                }
            } else {
                this.Alert("Warning!", "Fields can't be empty!", AlertForm.EnmType.Warning);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        #endregion Buttons

        #region Key Events
        private void SearchTb_KeyUp(object sender, KeyEventArgs e) {
            LoadGrid();
        }

        private void ManageBooksForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            } else if (e.Control && e.KeyCode == Keys.M) {
                ManageBtn_Click(sender, e);
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
        #endregion Key Events

        #region Special Event
        private void ActionCb_SelectedIndexChanged(object sender, EventArgs e) {
            ActionCalculation();
        }

        #endregion Special Event

        #region Methods

        protected override CreateParams CreateParams {
            get {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void LoadGrid() {
            dgv.ShowGrid(dgv: SelectionDgv, name: "Books Limit Columns", searchQuery: SearchTb.Text);
            dgv.GridWidth(dgv: SelectionDgv, widths: new int[] { 150, 280, 120 });
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
                        this.Alert("Warning!", "Not Enough Quantities to Remove!", AlertForm.EnmType.Warning);
                    }
                }
            }
        }
        public void Alert(string title, string body, AlertForm.EnmType type) {
            AlertForm alertForm = new AlertForm();
            alertForm.ShowAlert(title: title, body: body, type: type);
        }
        #endregion Methods
    }
}
