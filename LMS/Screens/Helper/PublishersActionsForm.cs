using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using LMS.Utils;
using Guna.UI2.WinForms;
using LMS.Utils.Core;
using LMS.Utils.Connection;
using LMS.Screens.Widgets;

namespace LMS {
    public partial class PublishersActionsForm : Form {
        SecondForm pf;
        private readonly Functions fn = new Functions();
        private readonly GridControlSettings dgv = new GridControlSettings();

        public PublishersActionsForm(SecondForm form, string title, string pid) {
            InitializeComponent();

            this.pf = form;
            TitleLbl.Text = title;
            ActionBtn.Text = title.ToUpper();
            PIDTb.Text = pid;

            if (title == "Add Publisher") {
                ActionBtn.FillColor = Color.FromArgb(77, 200, 86);
            } else if (title == "Modify Publisher") {
                LoadData(pid: pid);
                ActionBtn.FillColor = Color.FromArgb(248, 187, 0);
            }
        }

        private void LoadData(string pid) {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try {
                string query = "SELECT p.Name, pn.Number FROM publishers AS p, publishers_number AS pn WHERE p.pid = pn.pid AND p.pid = @pid;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@pid", SqlDbType.VarChar, 6).Value = pid;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                Guna2TextBox[] tb = new[] { NameTb, NumberTb };
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

        protected override CreateParams CreateParams {
            get {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void ActionBtn_Click(object sender, EventArgs e) {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            if (PIDTb.Text != string.Empty && NameTb.Text != string.Empty && NumberTb.Text != string.Empty) {

                if (ActionBtn.Text == "ADD PUBLISHER") {

                    try {

                        SqlCommand cmd = new SqlCommand("INSERT INTO publishers VALUES(@pid, @name, @isRemoved);", conn);
                        cmd.Parameters.Add("@pid", SqlDbType.VarChar, 6).Value = PIDTb.Text;
                        cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = NameTb.Text;
                        cmd.Parameters.Add("@isRemoved", SqlDbType.TinyInt).Value = 0;

                        SqlCommand cmd2 = new SqlCommand("INSERT INTO publishers_number VALUES(@pid, @number)", conn);
                        cmd2.Parameters.Add("@number", SqlDbType.Char, 10).Value = NumberTb.Text;
                        cmd2.Parameters.Add("@pid", SqlDbType.VarChar, 6).Value = PIDTb.Text;

                        if ((Int32)cmd.ExecuteNonQuery() > 0 && (Int32)cmd2.ExecuteNonQuery() > 0) {

                            if (pf.SecondDgv.ColumnCount == 0) {

                                Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91) };
                                Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91) };
                                string[] names = { "Modify", "Remove" };

                                dgv.GridButtons(dgv: pf.SecondDgv, names: names, backColors: backColors, selectionColors: selectColors);
                                //dgv.GridButtons(dgv: pf.SecondDgv);
                            }
                            dgv.ShowGrid(dgv: pf.SecondDgv, name: "Publishers");
                            dgv.GridWidth(dgv: pf.SecondDgv, widths: new int[] { 0, 0, 150, 200, 150 });

                            pf.Title2Lbl.Text = "Total Publishers : " + fn.GetNumberOf(name: "Publishers").ToString();
                            pf.RecentUpdateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt");

                            this.Alert("Process Success!", "Publisher inserted successfully!", AlertForm.EnmType.Success);
                            //MessageBox.Show("Publisher inserted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                    } catch (Exception ex) {
                        this.Alert("Process Failed!", "Publisher insertion failed!\nHint: Mobile number can't be same.", AlertForm.EnmType.Error);
                        //MessageBox.Show("Publisher insertion failed!\nHint: Mobile number can't be same.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Console.WriteLine("Error: " + ex.ToString());
                    } finally {
                        Console.ReadLine();
                        conn.Close();
                        conn.Dispose();
                    }

                } else if (ActionBtn.Text == "MODIFY PUBLISHER") {
                    try {

                        SqlCommand cmd = new SqlCommand("UPDATE publishers SET name = @name WHERE pid = @pid;", conn);
                        cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = NameTb.Text;
                        cmd.Parameters.Add("@pid", SqlDbType.VarChar, 6).Value = PIDTb.Text;

                        SqlCommand cmd2 = new SqlCommand("UPDATE publishers_number SET number = @number WHERE pid = @pid;", conn);
                        cmd2.Parameters.Add("@number", SqlDbType.Char, 10).Value = NumberTb.Text;
                        cmd2.Parameters.Add("@pid", SqlDbType.VarChar, 6).Value = PIDTb.Text;

                        if ((Int32)cmd.ExecuteNonQuery() > 0 && (Int32)cmd2.ExecuteNonQuery() > 0) {

                            GridControlSettings dgv = new GridControlSettings();

                            if (pf.SecondDgv.ColumnCount == 0) {

                                Color[] backColors = { Color.FromArgb(249, 217, 55), Color.FromArgb(253, 98, 91) };
                                Color[] selectColors = { Color.FromArgb(249, 200, 55), Color.FromArgb(230, 98, 91) };
                                string[] names = { "Modify", "Remove" };

                                dgv.GridButtons(dgv: pf.SecondDgv, names: names, backColors: backColors, selectionColors: selectColors);
                                //dgv.GridButtons(dgv: pf.SecondDgv);
                            }
                            dgv.ShowGrid(dgv: pf.SecondDgv, name: "Publishers");
                            dgv.GridWidth(dgv: pf.SecondDgv, widths: new int[] { 0, 0, 150, 200, 150 });

                            this.Alert("Process Success!","Publisher updated successfully!",AlertForm.EnmType.Success);
                            //MessageBox.Show("Publisher updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                    } catch (Exception ex) {
                        this.Alert("Process Failed","Publisher updation failed!", AlertForm.EnmType.Error);
                        //MessageBox.Show("Publisher updation failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Console.WriteLine("Error: " + ex.ToString());
                    } finally {
                        Console.ReadLine();
                        conn.Close();
                        conn.Dispose();
                    }
                }

            } else {
                this.Alert("Warning!", "Fields can't be empty!\nPlease fill all fields and submit again.", AlertForm.EnmType.Warning);
                //MessageBox.Show("Fields can't be empty!\nPlease fill all fields and submit again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void PublishersActionsForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void NumberTb_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        public void Alert(string title, string body, AlertForm.EnmType type) {
            AlertForm alertForm = new AlertForm();
            alertForm.ShowAlert(title: title, body: body, type: type);
        }
    }
}
