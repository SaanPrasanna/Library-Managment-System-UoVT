using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using LMS.Utils.Models;

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

        public int GetNumberOf(string name, [Optional] string value, [Optional] string value2) {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try {
                string query = "";

                switch (name) {
                    case "Members":
                    case "Books":
                    case "Staffs":
                    case "Publishers":
                        query = "SELECT COUNT(*) FROM " + name.ToLower() + " WHERE is_removed = 0;";
                        break;
                    case "Manage Books":
                        query = "SELECT COUNT(*) FROM books_manage WHERE date LIKE '%" + DateTime.Now.ToString("yyyy-MM") + "%';";
                        break;
                    case "Returned Books":
                        query = "SELECT COUNT(*) FROM borrow_books WHERE status = 'Returned'; ";
                        break;
                    case "Pending Books":
                        query = "SELECT COUNT(*) FROM borrow_books WHERE status = 'Pending';";
                        break;
                    case "Issued Books":
                        query = "SELECT COUNT(*) FROM borrow_books;";
                        break;
                    case "Specified Book":
                        query = "SELECT quantity FROM books WHERE isbn = " + value + ";";
                        break;
                    case "Temp Books":
                        query = "SELECT COUNT(*) FROM borrow_temp WHERE is_removed = 0;";
                        break;
                    case "Already Borrowed Books":
                        query = "SELECT COUNT(refno) FROM borrow_books WHERE status = 'Pending' AND mid = '" + value + "';";
                        break;
                    case "Already Choose Books":
                        query = "SELECT COUNT(*) FROM borrow_temp WHERE is_removed = '0' AND mid = '" + value + "';";
                        break;
                    case "Already Add to Borrow Temp":
                        query = "SELECT COUNT(*) FROM borrow_temp WHERE is_removed = '0' AND isbn = '" + value + "'";
                        break;
                    case "Already Add to Borrow Books":
                        query = "SELECT COUNT(*) FROM borrow_books WHERE status = 'Pending' AND isbn = '" + value + "' AND mid = '" + value2 + "'";
                        break;
                }
                SqlCommand cmd = new SqlCommand(query, conn);
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
                    case "Books Manage":
                        query = "SELECT COUNT(*) FROM books_manage;";
                        prefix = "R";
                        break;
                    case "Books Borrows":
                        query = "SELECT COUNT(DISTINCT refno) FROM borrow_books;";
                        prefix = "B";
                        break;
                    case "Temp":
                        query = "SELECT COUNT(*) FROM borrow_temp";
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

        public double GetFine(string refNo, string isbn) {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try {
                string query = "SELECT bb.due_date, mc.fine FROM borrow_books AS bb, member_category AS mc, members AS m, books AS b WHERE  bb.mid = m.mid AND bb.isbn = b.isbn AND m.category = mc.category AND bb.refno = @refNo AND b.isbn = @isbn;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@refNo", SqlDbType.VarChar, 6).Value = refNo;
                cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = isbn;

                SqlDataAdapter adupter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adupter.Fill(dt);

                DateTime dueDate = DateTime.Parse(dt.Rows[0][0].ToString());
                DateTime today = DateTime.Now;
                int TotalDays = (int)(today - dueDate).TotalDays;
                return (double)(TotalDays * double.Parse(dt.Rows[0][1].ToString()));

            } catch (Exception ex) {
                Console.WriteLine("Error: " + ex.ToString());
            } finally {
                conn.Close();
                conn.Dispose();
                Console.ReadLine();
            }

            return 0;

        }

        public DateTime GetDueDate(string refNo, string isbn, string mID) {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try {


                string query = "SELECT due_date FROM borrow_books WHERE refno = @refNo AND mid = @mid AND isbn = @isbn;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@refNo", SqlDbType.VarChar, 12).Value = refNo;
                cmd.Parameters.Add("@mid", SqlDbType.VarChar, 6).Value = mID;
                cmd.Parameters.Add("@isbn", SqlDbType.VarChar, 13).Value = isbn;

                return (DateTime)cmd.ExecuteScalar();

            } catch (Exception e) {
                Console.WriteLine("Error: " + e.ToString());
            } finally {
                conn.Close();
                conn.Dispose();
                Console.ReadLine();
            }
            return DateTime.Now;
        }

        public DataTable GetBooksNames() {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string sql = "SELECT title FROM books";

            try {

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adupter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Tables.Add(dt);
                adupter.Fill(dt);
                return dt;

            } catch {

            } finally {
                conn.Close();
                conn.Dispose();
            }

            return null;
        }

        public bool IsAlreadyAdd(string isbn, string mID) {
            try {

                int count = GetNumberOf(name: "Already Add to Borrow Temp", value: isbn) + GetNumberOf(name: "Already Add to Borrow Books", value: isbn, value2: mID);
                return (count < 1);

            } catch (Exception ex) {
                Console.WriteLine("Error: || ISAlreadyAdd || \n" + ex.ToString());
            } finally {
                Console.ReadLine();
            }
            return false;
        }

        public DataTable GetDataTable(string name) {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string query = "";

            try {
                switch (name) {
                    case "Temp Checkout":
                        query = "SELECT id, isbn, mid, is_removed FROM borrow_temp";
                        break;
                }
                SqlCommand cmd = new SqlCommand(query, conn);

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

        public SqlDataReader GetReader(string name, [Optional] string searchQuery, [Optional] string fromDate, [Optional] string toDate, [Optional] string searchQuery2) {
            string query = "";

            switch (name) {
                case "Books":
                    query = "SELECT ISBN, Title, Author, Category,  Price, Quantity, Date, Time  FROM books WHERE is_removed = 0" + ((searchQuery != string.Empty) ? " AND title LIKE '%" + searchQuery + "%';" : ";");
                    break;
                case "Members":
                    query = "SELECT m.mid AS 'Member ID', m.fname AS 'First Name', m.lname AS 'Last Name', m.Address, m.Category AS 'Account Type', Date AS 'Registered Date', m.renew_date AS 'Re-New Date', s.fname AS 'Added By' FROM members AS m, staffs AS s WHERE m.sid = s.sid AND m.is_removed = 0" + ((searchQuery != string.Empty) ? " AND  m.fname LIKE '%" + searchQuery + "%';" : ";");
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
                case "Borrow Books":
                    query = "SELECT refno AS 'Borrow Reference', b.Title AS 'Book Title', CONCAT(m.fname,' ',m.lname) AS 'Member Name', bb.issue_date AS 'Issued Date', bb.due_date As 'Due Date', return_date AS 'Returned Date', bb.Status  FROM borrow_books AS bb, members AS m, books AS b WHERE bb.mid = m.mid AND b.isbn = bb.isbn AND" + ((searchQuery != string.Empty) ? " CONCAT(m.fname,' ',m.lname) LIKE '%" + searchQuery + "%' AND " : " ") + " issue_date BETWEEN '" + fromDate + "' AND '" + toDate + "';";
                    break;
                case "Pending Members":
                    query = "SELECT m.mid AS 'Borrow Reference', CONCAT(m.fname, ' ', m.lname) AS 'Full Name', count(*) AS 'Number of Books' FROM borrow_books AS bb, members as m WHERE bb.mid = m.mid AND bb.status = 'Pending'" + ((searchQuery != string.Empty) ? " AND CONCAT(m.fname, ' ', m.lname) LIKE '%" + searchQuery + "%' " : " ") + "GROUP BY m.mid, fname, lname;";
                    break;
                case "Pending Books":
                    query = "SELECT bb.refno AS 'Ref No', bb.ISBN, b.Title, bb.issue_date AS 'Issued Date', bb.due_date AS 'Due Date' FROM borrow_books AS bb, members AS m, books AS b WHERE bb.isbn = b.isbn AND bb.mid = m.mid AND bb.status = 'Pending'  AND m.mid = '" + searchQuery2 + "'" + ((searchQuery != string.Empty) ? " AND b.title LIKE '%" + searchQuery + "%'" : ";");
                    break;
                default:
                    Console.WriteLine("Please double check Reader Name!");
                    break;
            }

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try {
                SqlCommand cmd = new SqlCommand(query, conn);

                var dataReader = cmd.ExecuteReader();
                return dataReader;

            } catch (Exception ex) {
                conn.Close();
                Console.WriteLine("Error: || GetReader ||\n" + ex.ToString());
                return null;
            }
        }

        public List<T> GetList<T>(IDataReader reader) {
            List<T> list = new List<T>();
            while (reader.Read()) {
                var type = typeof(T);
                T obj = (T)Activator.CreateInstance(type);
                foreach (var prop in type.GetProperties()) {
                    var propType = prop.PropertyType;
                    prop.SetValue(obj, Convert.ChangeType(reader[prop.Name].ToString(), propType));
                }
                list.Add(obj);
            }
            return list;
        }
    }
}
