using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace WinFormsApp1
{
    public static class DatabaseConnection
    {
        private static string connectionString ="Server=localhost;Database=employee;Uid=root;Pwd=root;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}