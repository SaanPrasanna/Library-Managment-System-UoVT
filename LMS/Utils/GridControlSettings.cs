using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace LMS.Utils {
    class GridControlSettings {
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

        public void ShowGrid(DataGridView dgv, string query) {
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

    }
}
