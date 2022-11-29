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
        // Object for the Functions.cs which locate LMS/Utils
        readonly Functions fn = new Functions();
        // Object for the GridControlSettings.cs locate LMS/Utils
        readonly GridControlSettings dgv = new GridControlSettings();

        public ManageBooksForm(MainForm form) {
            InitializeComponent();
            // Main Form object storing for refresh Main Form things
            this.mf = form;
            // Call LoadGrid method to fill the DataGridView
            LoadGrid();
        }

        #region Selection DataGridView CellContentClick
        private void SelectionDgv_CellEnter(object sender, DataGridViewCellEventArgs e) {
            // Array for TextBox, those filled clicked after DataGridView Row or Cell
            Guna2TextBox[] tb = new[] { ISBNTb, TitleTb, QtyTb };
            // Filling values for those TextBox
            foreach (var textBox in tb.Select((name, index) => (name, index))) {
                textBox.name.Text = SelectionDgv.CurrentRow.Cells[textBox.index].Value.ToString();
            }
            ActionCalculation();
        }
        #endregion Selection DataGridView CellContentClick 

        #region Buttons
        // When the manage button is clicked
        private void ManageBtn_Click(object sender, EventArgs e) {
            // Check all input fields are not empty
            if (ISBNTb.Text != string.Empty && AQtyTb.Text != string.Empty && ActionCb.Text != string.Empty && FQtyTb.Text != string.Empty) {

                // Creating the Sql Connection, Which need to INSERT and UPDATE the data to the SQL Server Database 
                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();

                try {
                    // INSERT the data into the Books Manage table
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

                    // UPDATE the Books table data after adjusting the books quantity
                    string query2 = "UPDATE books SET quantity = @qty WHERE isbn = @isbn";
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    cmd2.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = ISBNTb.Text;
                    cmd2.Parameters.Add("@qty", SqlDbType.Int).Value = Int32.Parse(FQtyTb.Text);

                    // If the both queries are Executed successfully
                    if ((Int32)cmd.ExecuteNonQuery() > 0 && (Int32)cmd2.ExecuteNonQuery() > 0) {

                        MessageBox.Show("Book(s) " + ActionCb.Text + ((ActionCb.Text == "Add") ? "ed!" : "d!"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear the input fields
                        FQtyTb.Text = string.Empty;
                        AQtyTb.Text = string.Empty;
                        DescriptionTb.Text = String.Empty;
                        ActionCb.SelectedIndex = -1;

                        // Refresh the DataGridView
                        LoadGrid();
                        mf.MainDgv.Columns.Clear();
                        dgv.ShowGrid(dgv: mf.MainDgv, name: "Manage Books", searchQuery: SearchTb.Text, fromDate: mf.FromDtp.Value.ToString("yyyy-MM-dd"), toDate: mf.ToDtp.Value.ToString("yyyy-MM-dd"));
                        dgv.GridWidth(dgv: mf.MainDgv, widths: new int[] { 150, 200, 150, 150, 250, 150 });
                    }

                } catch (Exception ex) {
                    // If the exception occur
                    MessageBox.Show("Book(s) " + ActionCb.Text + ((ActionCb.Text == "Add") ? "ed!" : "d!") + " Failed : \n" + ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } finally {
                    conn.Close();
                    Console.ReadLine();
                }
            } else {
                MessageBox.Show("Fields can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        // If Close Button clicked
        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        #endregion Buttons

        #region Key Events
        // If Search TextBox Text Changed
        private void SearchTb_KeyUp(object sender, KeyEventArgs e) {
            LoadGrid();
        }

        // Catching Key Events 
        private void ManageBooksForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) { //When Pressed Key Esc
                this.Close();
            } else if (e.Control && e.KeyCode == Keys.M) { // When Pressed Key Ctrl + M
                ManageBtn_Click(sender, e);
            }
        }

        // Allow numeric characters only for quantity TextBox
        private void AQtyTb_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        // Change the Adjust Quantity TextBox Text
        private void AQtyTb_KeyUp(object sender, KeyEventArgs e) {
            ActionCalculation();
        }
        #endregion Key Events

        #region Special Event
        // Action ComboBox Value Changed
        private void ActionCb_SelectedIndexChanged(object sender, EventArgs e) {
            ActionCalculation();
        }

        #endregion Special Event

        #region Methods

        // Creating DropShadow for When Form Borader Style: None
        protected override CreateParams CreateParams {
            get {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        // For Loading the DataGridView
        private void LoadGrid() {
            // Call ShowGrid Method
            dgv.ShowGrid(dgv: SelectionDgv, name: "Books Limit Columns", searchQuery: SearchTb.Text);
            // Call GridWidth Method, which replace the DataGridView Columns width
            dgv.GridWidth(dgv: SelectionDgv, widths: new int[] { 150, 150 });
        }

        // For the Calculation Part
        private void ActionCalculation() {
            // Check the Action is selected and Adjust Quantity is not empty
            if (ActionCb.Text != string.Empty && AQtyTb.Text != string.Empty) {
                // The Action is Add then
                if (ActionCb.Text == "Add") {
                    FQtyTb.Text = (Int32.Parse(QtyTb.Text) + ((AQtyTb.Text != string.Empty) ? Int32.Parse(AQtyTb.Text) : 0)).ToString();
                } else { // The Actoin is Removed then
                    if (Int32.Parse(QtyTb.Text) >= Int32.Parse(AQtyTb.Text)) {
                        FQtyTb.Text = (Int32.Parse(QtyTb.Text) - ((AQtyTb.Text != string.Empty) ? Int32.Parse(AQtyTb.Text) : 0)).ToString();
                    } else {
                        // Not enough quantity state
                        FQtyTb.Text = string.Empty;
                        AQtyTb.Text = string.Empty;
                        ActionCb.SelectedIndex = -1;
                        MessageBox.Show("Not Enough Quantities to Remove!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        #endregion Methods
    }
}
