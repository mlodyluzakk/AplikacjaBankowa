using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Data.SQLite;

namespace AplikacjaBankowa
{
    public static class UserService
    {
        public static bool IsValidPassword(string password)
            => Regex.IsMatch(password, @"^(?=.*\d)(?=.*\W).+$");

        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        public static string GenerateAccountNumber()
        {
            var rnd = new Random();
            var sb = new StringBuilder();
            for (int i = 0; i < 26; i++)
                sb.Append(rnd.Next(0, 10));
            return sb.ToString();
        }

        // Teraz 5 parametrów: zwraca out errorMessage
        public static bool RegisterUser(
            string username,
            string password,
            string firstName,
            string lastName,
            out string errorMessage)
        {
            errorMessage = null;

            if (!IsValidPassword(password))
            {
                errorMessage = "Has³o musi zawieraæ cyfrê i znak specjalny.";
                return false;
            }

            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    using (var cmd = new SQLiteCommand(
                        "INSERT INTO users(username,password_hash,role_id) VALUES(@u,@p,4);",
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", HashPassword(password));
                        cmd.ExecuteNonQuery();
                    }

                    long userId;
                    using (var cmd = new SQLiteCommand(
                        "SELECT last_insert_rowid();", conn))
                        userId = (long)cmd.ExecuteScalar();

                    using (var cmd = new SQLiteCommand(
                        "INSERT INTO clients(user_id,first_name,last_name) VALUES(@uid,@fn,@ln);",
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", userId);
                        cmd.Parameters.AddWithValue("@fn", firstName);
                        cmd.Parameters.AddWithValue("@ln", lastName);
                        cmd.ExecuteNonQuery();
                    }

                    long clientId;
                    using (var cmd = new SQLiteCommand(
                        "SELECT last_insert_rowid();", conn))
                        clientId = (long)cmd.ExecuteScalar();

                    using (var cmd = new SQLiteCommand(
                        "INSERT INTO bank_accounts(client_id,account_number,balance) VALUES(@cid,@acc,0);",
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@cid", clientId);
                        cmd.Parameters.AddWithValue("@acc", GenerateAccountNumber());
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
    }
}
