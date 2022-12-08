using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using LMS.Utils.Connection;
using System.Net.Mail;

namespace LMS.Utils.Core {
    class Functions {
        public DataTable Authentication(string type, string username, string password) {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "";

            switch (type) {
                case "Staff":
                    sql = "SELECT sid, username, fname, lname, type FROM staffs WHERE username = @username AND password = @password AND is_removed = '0'";
                    break;
                case "Member":
                    sql = "SELECT mid, email, fname, lname, category FROM members WHERE email = @username AND password = @password AND is_removed = '0';";
                    break;
            }
            password = GetSHA1Hash(input: password).ToLower();

            try {

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 100).Value = username;
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
                    case "Monthly FineFees":
                        query = "SELECT fines_fee FROM borrow_books WHERE return_date LIKE '%" + DateTime.Now.ToString("yyyy-MM") + "%'";
                        break;
                    case "Monthly Books":
                        query = "SELECT COUNT(*) FROM books WHERE date LIKE '%" + DateTime.Now.ToString("yyyy-MM") + "%'";
                        break;
                    case "Member by Email":
                        query = "SELECT COUNT(*) FROM members WHERE is_removed = '0' AND email = '" + value + "'";
                        break;
                }
                SqlCommand cmd = new SqlCommand(query, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());

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
                int TotalDays = (dueDate <= today) ? (int)(today - dueDate).TotalDays : 0;
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

        public DataTable GetDataTable(string name, [Optional] string value) {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string query = "";

            try {
                switch (name) {
                    case "Temp Checkout":
                        query = "SELECT id, isbn, mid, is_removed FROM borrow_temp";
                        break;
                    case "Member":
                        query = "SELECT mid, email, CONCAT(fname, ' ', lname), telephone, address, date FROM members WHERE mid = '" + value + "';";
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
                    query = "SELECT mid, CONCAT(fname,' ',lname) AS 'FullName', Address, Email, Telephone, Category, renew_date AS 'RenewDate' FROM members WHERE is_removed = 0" + ((searchQuery != string.Empty) ? " AND  CONCAT(fname,' ',lname) LIKE '%" + searchQuery + "%';" : ";");
                    break;
                case "Staffs":
                    query = "SELECT sid, Username, CONCAT(fname,' ',lname) AS 'FullName', Address, Type FROM staffs WHERE is_removed = 0" + ((searchQuery != string.Empty) ? " AND username LIKE '%" + searchQuery + "%';" : ";");
                    break;
                case "Publishers":
                    query = "SELECT p.pid AS 'Publisher ID', p.Name, pn.Number FROM publishers AS p, publishers_number AS pn WHERE p.pid = pn.pid AND is_removed = 0" + ((searchQuery != string.Empty) ? "AND p.name LIKE '%" + searchQuery + "%';" : ";");
                    break;
                case "Manage Books":
                    query = "SELECT b.Title, bm.Quantity, Action, Description, bm.Date, s.Username  FROM books_manage AS bm, staffs AS s, books AS b WHERE bm.sid=s.sid AND bm.isbn = b.isbn AND" + ((searchQuery != string.Empty) ? " b.title LIKE '%" + searchQuery + "%' AND" : " ") + " bm.date BETWEEN '" + fromDate + "' AND '" + toDate + "';";
                    break;
                case "Borrow Books":
                    query = "SELECT refno, m.mid, b.Title, CONCAT(m.fname,' ',m.lname) AS 'FullName', bb.issue_date AS 'IssuedDate', bb.due_date As 'DueDate', return_date AS 'ReturnedDate', bb.Status FROM borrow_books AS bb, members AS m, books AS b WHERE bb.mid = m.mid AND b.isbn = bb.isbn AND" + ((searchQuery != string.Empty) ? " CONCAT(m.fname,' ',m.lname) LIKE '%" + searchQuery + "%' AND " : " ") + " issue_date BETWEEN '" + fromDate + "' AND '" + toDate + "';";
                    break;
                case "Pending Members":
                    query = "SELECT m.mid AS 'Borrow Reference', CONCAT(m.fname, ' ', m.lname) AS 'Full Name', count(*) AS 'Number of Books' FROM borrow_books AS bb, members as m WHERE bb.mid = m.mid AND bb.status = 'Pending'" + ((searchQuery != string.Empty) ? " AND CONCAT(m.fname, ' ', m.lname) LIKE '%" + searchQuery + "%' " : " ") + "GROUP BY m.mid, fname, lname;";
                    break;
                case "Pending Books":
                    query = "SELECT bb.refno AS 'Ref No', bb.ISBN, b.Title, bb.issue_date AS 'Issued Date', bb.due_date AS 'Due Date' FROM borrow_books AS bb, members AS m, books AS b WHERE bb.isbn = b.isbn AND bb.mid = m.mid AND bb.status = 'Pending'  AND m.mid = '" + searchQuery2 + "'" + ((searchQuery != string.Empty) ? " AND b.title LIKE '%" + searchQuery + "%'" : ";");
                    break;
                case "FineFee":
                    query = "SELECT category, fine FROM member_category;";
                    break;
                case "Member Report":
                    query = "SELECT bb.refno AS 'RefNo', m.mid, b.Title, CONCAT(fname, ' ', lname ) As 'FullName', bb.issue_date AS 'IssuedDate', bb.due_date AS 'DueDate', bb.return_date AS 'ReturnedDate', bb.status FROM borrow_books AS bb, members AS m, books AS b WHERE bb.isbn = b.isbn AND bb.mid = m.mid AND m.mid = '" + searchQuery + "';";
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

        public bool IsEmail(string email) {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith(".")) {
                return false;
            }
            try {
                var addr = new MailAddress(email);
                return addr.Address == trimmedEmail;
            } catch {
                return false;
            }
        }

        public bool IsStaff() {
            return (Properties.Settings.Default.accountType == "Admin" || Properties.Settings.Default.accountType == "Moderator");
        }

        public bool IsAdmin() {
            return Properties.Settings.Default.accountType == "Admin";
        }
        public bool IsModerator() {
            return Properties.Settings.Default.accountType == "Moderator";
        }
    }
}
