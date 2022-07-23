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
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        public int GetNumberOf(string name) {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try {

                string sql = "SELECT COUNT(*) FROM " + name + " WHERE is_removed = 0;";
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

        public string GetID(string name) {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try {

                string mid = "", query = "", prefix = "";
                switch (name) {
                    case "Member":
                        query = "SELECT COUNT(*) FROM members;";
                        prefix = "M";
                        break;
                    case "Staff":
                        query = "SELECT COUNT(*) FROM staffs;";
                        prefix = "S";
                        break;
                    case "Publisher":
                        query = "SELECT COUNT(*) FROM publishers;";
                        prefix = "P";
                        break;
                    default:
                        Console.WriteLine("Please double check ID name!");
                        break;
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                int cout = (Int32)cmd.ExecuteScalar() + 1;

                if (cout >= 0 && cout < 10) {
                    mid = prefix + "0000" + cout.ToString();
                } else if (cout >= 10 && cout < 100) {
                    mid = prefix + "000" + cout.ToString();
                } else if (cout >= 100 && cout < 1000) {
                    mid = prefix + "00" + cout.ToString();
                } else if (cout >= 1000 && cout < 10000) {
                    mid = prefix + "0" + cout.ToString();
                } else if (cout >= 10000 && cout < 100000) {
                    mid = prefix + cout.ToString();
                }
                return mid;

            } catch (Exception e) {
                Console.WriteLine("Error: " + e.ToString());
            } finally {
                conn.Close();
                conn.Dispose();
                Console.ReadLine();
            }
            return null;
        }
    }
}
