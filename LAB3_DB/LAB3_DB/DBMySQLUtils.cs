using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace LAB3_DB
{
    internal class DBMySQLUtils
    {
         public static MySqlConnection 
            GetDBConnection(string host, int port, string database, string username, string password)
         {
             string connString = "Server =" + host + ";Database =" + database + ";port =" + port + 
                ";User Id = " + username + ";password =" + password;

             MySqlConnection conn = new MySqlConnection(connString); 
            return conn;
         }
    }
}
