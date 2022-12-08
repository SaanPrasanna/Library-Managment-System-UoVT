using LMS.Screens.Widgets;
using LMS.Utils;
using LMS.Utils.Connection;
using LMS.Utils.Models;
using Salaros.Configuration;
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

namespace LMS.Screens.Primary {
    public partial class SettingsForm : Form {

        private readonly ConfigParser config = new ConfigParser(Application.StartupPath + @"\settings.cnf");

        public SettingsForm() {
            InitializeComponent();
            this.TopMost = true;
        }

        #region From Load

        private void SettingsForm_Load(object sender, EventArgs e) {
            dropShadow.SetShadowForm(this);
            // Get Fine Fee
            DataTable dt = FineFee();
            StudentTB.Text = dt.Rows[0][1].ToString();
            OthersTB.Text = dt.Rows[1][1].ToString();

            // Get Renew Date
            if (config.GetValue("Numbers", "RenewDate") == null) {
                config.SetValue("Numbers", "RenewDate", 365);
                config.Save();
            }
            DaysTB.Text = config.GetValue("Numbers", "RenewDate");

        }

        #endregion

        #region Methods
        private DataTable FineFee() {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string sql = "SELECT category, fine FROM member_category;";

            try {
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adupter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adupter.Fill(dt);
                return dt;

            } catch {

            } finally {
                conn.Close();
                conn.Dispose();
            }

            return null;
        }

        private void UpdateFineFee(FineFee fineFee) {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try {

                string query = "UPDATE member_category SET fine = @student WHERE category = 'Student';";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@student", SqlDbType.Decimal).Value = fineFee.Student;

                string query2 = "UPDATE member_category SET fine = @other WHERE category = 'Other';";

                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.Parameters.Add("@other", SqlDbType.Decimal).Value = fineFee.Other;

                if (cmd.ExecuteNonQuery() > 0 && cmd2.ExecuteNonQuery() > 0) {
                    this.Alert("Process Success!", "Settings Updated!", AlertForm.EnmType.Success);
                    //MessageBox.Show("Settings Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex) {
                this.Alert("Process Failed!", "Settigs update failed!", AlertForm.EnmType.Warning);
                //MessageBox.Show("Settigs update failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        #endregion Methods

        #region Button Click
        private void SaveDaysBtn_Click(object sender, EventArgs e) {
            if (DaysTB.Text != string.Empty) {
                config.SetValue("Numbers", "RenewDate", Convert.ToInt32(DaysTB.Text));
                config.Save();
                this.Alert("Process Success!", "Settings Updated!", AlertForm.EnmType.Success);
                //MessageBox.Show("Settings Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                this.Alert("Process Failed!", "Settings update failed!", AlertForm.EnmType.Warning);
                //MessageBox.Show("Settings Updated failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void SaveFeeBtn_Click(object sender, EventArgs e) {
            FineFee fineFee = new FineFee {
                Student = Convert.ToDouble(StudentTB.Text),
                Other = Convert.ToDouble(OthersTB.Text)
            };

            UpdateFineFee(fineFee);
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
        #endregion

        #region Special Key Events
        private void SettingsForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                CloseBtn_Click(sender, e);
            }
        }

        private void StudentTB_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.')) {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && StudentTB.Text.IndexOf('.') > 0) {
                e.Handled = true;
            }
        }
        private void OthersTB_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.')) {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && OthersTB.Text.IndexOf('.') > 0) {
                e.Handled = true;
            }
        }

        private void DaysTB_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        #endregion

    }
}
