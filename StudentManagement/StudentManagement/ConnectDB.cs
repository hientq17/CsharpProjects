using System;
//Add MySql Library
using MySql.Data.MySqlClient;

namespace StudentManagement {

    class ConnectDB {
        //MySQL localhost
        //private MySqlConnection conn;
        //private string server = "localhost";
        //private string database = "studentManagement";
        //private string uid = "root";
        //private string password = "171200";
        
        // MySQL Cpanel 
        private MySqlConnection conn;
        private string server = "103.97.125.254";
        private string database = "mrendzpc_CoffeeManagement";
        private string uid = "mrendzpc_mrend";
        private string password = "Hien1712";

        public MySqlConnection OpenConnection() {
            string connectionStr = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            conn = new MySqlConnection(connectionStr);
            conn.Open();
            Console.WriteLine("Open connection successfully");   
            return conn;
        }

        public void CloseConnection() {
            if(conn!=null && conn.State == System.Data.ConnectionState.Open) {
                conn.Close();
                Console.WriteLine("Close connection successfully");
            }         
        }
    
    }
        
   
}
