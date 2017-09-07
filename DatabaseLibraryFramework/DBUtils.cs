using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLibraryFramework
{
    public class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            var host = "localhost";
            var port = 3306;
            var database = "dblog";
            var username = "root";
            var password = "root";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
