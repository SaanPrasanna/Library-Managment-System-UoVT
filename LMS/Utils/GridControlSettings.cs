using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace LMS.Utils {
    class GridControlSettings {

        public void ShowGrid(DataGridView dgv, string name, [Optional] string searchQuery, [Optional] string fromDate, [Optional] string toDate) {

            string query = "";
            switch (name) {
                case "Books":
                    query = "SELECT ISBN, Title, Author, Category, publishers.name AS Publisher, Price, Quantity, Date, Time  FROM books, publishers  WHERE books.pid = publishers.pid AND books.is_removed = 0" + ((searchQuery != string.Empty) ? " AND books.title LIKE '%" + searchQuery + "%';" : ";");
                    break;
                case "Members":
                    query = "SELECT m.mid AS 'Member ID', m.fname AS 'First Name', m.lname AS 'Last Name', m.Address, m.Category AS 'Account Type', Date AS 'Registered Date', m.renew_date AS 'Re-New Date', s.fname AS 'Added By' FROM members AS m, staffs AS s WHERE m.sid = s.sid AND m.is_removed = 0" + ((searchQuery != string.Empty) ? " AND  m.fname LIKE '%" + searchQuery + "%';" : ";");
                    break;
                case "ManageBooks":
                    break;
                case "Staffs":
                    query = "SELECT sid AS 'Staff ID', Username, fname AS 'First Name', lname AS 'Last Name', Address, type AS 'Account Type' FROM staffs WHERE is_removed = 0" + ((searchQuery != string.Empty) ? " AND username LIKE '%" + searchQuery + "%';" : ";");
                    break;
                case "Publishers":
                    query = "SELECT p.pid AS 'Publisher ID', p.Name, pn.Number FROM publishers AS p, publishers_number AS pn WHERE p.pid = pn.pid AND is_removed = 0" + ((searchQuery != string.Empty) ? "AND p.name LIKE '%" + searchQuery + "%';" : ";");
                    break;
                case "Manage Books":
                    query = "SELECT bm.ISBN, b.Title, bm.Quantity, Action, Description, bm.Date, bm.Time, s.Username  FROM books_manage AS bm, staffs AS s, books AS b WHERE bm.sid=s.sid AND bm.isbn = b.isbn AND" + ((searchQuery != string.Empty) ? " b.title LIKE '%" + searchQuery + "%' AND" : " ") + " bm.date BETWEEN '" + fromDate + "' AND '" + toDate + "';";
                    break;
                case "Books Limit Columns":
                    query = "SELECT ISBN, Title, Quantity FROM books  WHERE books.is_removed = 0" + ((searchQuery != string.Empty) ? " AND books.title LIKE '%" + searchQuery + "%';" : ";");
                    break;
                default:
                    Console.WriteLine("Please double check Grid Name!");
                    break;
            }

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try {

                SqlDataAdapter adupter = new SqlDataAdapter(query, conn);
                using (SqlDataAdapter adapter = adupter) {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgv.DataSource = ds.Tables[0];
                }

            } catch (Exception ex) {
                Console.WriteLine("Error: " + ex.ToString());
            } finally {
                conn.Close();
                conn.Dispose();
                Console.Read();
            }
        }

        public void GridButtons(DataGridView dgv) {

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.Name = "";
            btn.Text = "Modify";
            btn.FlatStyle = FlatStyle.Popup;
            btn.InheritedStyle.SelectionForeColor = Color.White;
            btn.InheritedStyle.SelectionBackColor = Color.FromArgb(249, 200, 55);
            btn.InheritedStyle.BackColor = Color.FromArgb(249, 217, 55);
            btn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns.Add(btn);

            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.UseColumnTextForButtonValue = true;
            btn2.Name = "";
            btn2.Text = "Remove";
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.InheritedStyle.SelectionForeColor = Color.White;
            btn2.InheritedStyle.SelectionBackColor = Color.FromArgb(230, 98, 91);
            btn2.InheritedStyle.BackColor = Color.FromArgb(253, 98, 91);
            btn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns.Add(btn2);
        }

        public void GridWidth(DataGridView dgv, int[] widths) {
            for (int i = 0; i < widths.Length; i++) {
                dgv.Columns[i].Width = widths[i];
            }
        }

    }
}
