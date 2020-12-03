using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExam {
        class ConnectDB {

            SqlConnection conn;
            string connectionStr = "database=QL_BANGDIA;Server=QH;User id=sa; password=1712";

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
