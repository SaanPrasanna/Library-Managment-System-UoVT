using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace LMS.Utils {
    class Functions {
        public DataTable Authentication(string username, string password) {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string sql = "SELECT * FROM staffs WHERE username = @username AND password = @password AND is_removed = 0";
            password = GetSHA1Hash(input: password).ToLower();

            try {

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 20).Value = username;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = password;

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

        public string GetSHA1Hash(string input) {
            using (SHA1Managed sha1 = new SHA1Managed()) {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash) {
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }

        public int GetNumberOfBooks() {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try {

                string sql = "SELECT COUNT(*) FROM books WHERE is_removed = 0;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return (Int32)cmd.ExecuteScalar();

            } catch (Exception e) {
                Console.WriteLine("Error: " + e.ToString());
            } finally {
                conn.Close();
                conn.Dispose();
                Console.ReadLine();
            }
            return 0;
        }
    }
}
