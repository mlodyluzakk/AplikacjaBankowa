using System;
using System.Data.SQLite;

namespace AplikacjaBankowa
{
    public static class DBHelper
    {
        private const string ConnectionString = "Data Source=bank_app_fixed (1).sqlite;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
