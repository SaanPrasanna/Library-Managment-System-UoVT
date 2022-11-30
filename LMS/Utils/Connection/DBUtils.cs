using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LMS.Utils.Connection {
    internal class DBUtils {
        public static SqlConnection GetDBConnection() {

            string datasource = @"RGENESIS\SQLEXPRESS";
            string database = "lms";
            string username = "";
            string password = "";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);

        }
    }
}
