using System;
using System.Data;
using System.Data.SqlClient;

public class DatabaseHelper
{
    // Замініть рядок підключення на свій (LocalDB або SQL Express)
    private string connectionString = @"Data Source=MARCHER_OV\SQLEXPRESS03;Initial Catalog=InvoiceSystemDB;Integrated Security=True;Encrypt=False;"; 
    public bool ValidateUser(string username, string password)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                // УВАГА: У реальному проекті паролі мають бути хешовані! Тут для спрощення текст.
                string query = "SELECT COUNT(1) FROM Users WHERE Username = @user AND PasswordHash = @pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception)
            {
                return false; // Помилка з'єднання
            }
        }
    }

    // Додайте цей код у клас DatabaseHelper
    public bool RegisterUser(string username, string password, string email)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();

                // 1. Перевірка, чи такий логін вже зайнятий
                string checkQuery = "SELECT COUNT(1) FROM Users WHERE Username = @user";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@user", username);
                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0) return false; // Користувач вже існує
                }

                // 2. Додавання нового користувача
                // Примітка: У реальному проекті пароль треба хешувати (SHA256), 
                // але для навчання записуємо як є, щоб працював ваш вхід.
                string insertQuery = "INSERT INTO Users (Username, PasswordHash, Email) VALUES (@user, @pass, @email)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@user", username);
                    insertCmd.Parameters.AddWithValue("@pass", password);
                    insertCmd.Parameters.AddWithValue("@email", email);
                    insertCmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    // Метод для збереження фактури можна додати тут...
}
