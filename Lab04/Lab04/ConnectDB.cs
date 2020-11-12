using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04 {
        class ConnectDB {

            SqlConnection conn;
            string connectionStr = "database=Northwind;Server=QH;User id=sa; password=1712";

            public SqlConnection OpenConnection() {
                conn = new SqlConnection(connectionStr);
                conn.Open();
                Console.WriteLine("Open connection successfully");
                return conn;
            }

            public void CloseConnection() {
                if (conn != null && conn.State == System.Data.ConnectionState.Open) {
                    conn.Close();
                    Console.WriteLine("Close connection successfully");
                }
            }

        }
}
