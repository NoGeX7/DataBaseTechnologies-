using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace LAB3_DB
{
    internal class DBUtils
    {
       public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string datebasa = "lab1-7";
            string username = "monty";
            string password = "some_pass";

            return DBMySQLUtils.GetDBConnection(host, port, datebasa, username, password);
        }
    }
}
