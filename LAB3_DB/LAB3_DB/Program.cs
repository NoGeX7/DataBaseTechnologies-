
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LAB3_DB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection ...");
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                Console.WriteLine("Openning Connection ...");

                conn.Open();
                Console.WriteLine("Connection successful!");
                QueryEmployee(conn);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            Console.Read();
        }
        private static void QueryEmployee(MySqlConnection conn)
        {
            string kod, namev, price, postachalniki;
            string sql = "Select код_вузла, назва_вузла, вартість_одиниці_продукції, Постачальники_код_постачальника from `вузли`";
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        kod = reader["код_вузла"].ToString();
                        namev = reader["назва_вузла"].ToString();
                        price = reader["вартість_одиниці_продукції"].ToString();
                        postachalniki = reader["Постачальники_код_постачальника"].ToString();

                        Console.WriteLine("----------------------------------------------------------------------------------");
                        Console.WriteLine("Код:" + kod + " Назва вузла:" + namev + " Вартiсть одиницi " + price 
                             + " Постачальник " + postachalniki);
                        Console.WriteLine("---------------------------------------------------------------------------------");
                    }
                }
            }
        }
    }
}