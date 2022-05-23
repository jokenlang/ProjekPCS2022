using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace proyek
{
    internal class koneksi
    {
        static MySqlConnection conn = new MySqlConnection();
        static string dbname, server, username, password;

        public static void openConn(string db, string serv, string uuid, string pass)
        {
            dbname = db;
            server = serv;
            username = uuid;
            password = pass;

            conn.ConnectionString = string.Format("database={0}; server={1}; user id={2}; password={3};", dbname, server, username, password);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Console.WriteLine("Connected!");
            }
        }

        public static MySqlConnection getConn()
        {
            return conn;
        }

        public static void closeConn()
        {
            conn.Close();
        }
    }
}
