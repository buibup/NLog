using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLibraryFramework
{
    public class DBMySQLUtils
    {
        public static MySqlConnection
            GetDBConnection(string host, int port, string database, string username, string password)
        {
            var connString = $"Server={host}; Database={database}; port={port}; User Id={username}; password={password};";

            var conn = new MySqlConnection(connString);

            return conn;
        }
    }
}
