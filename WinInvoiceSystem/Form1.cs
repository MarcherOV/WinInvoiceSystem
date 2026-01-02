using System;
using System.Windows.Forms;
using System.Net;       // Потрібно для NetworkCredential
using System.Net.Mail;  // Потрібно для відправки листів

namespace WinInvoiceSystem
{
    public partial class LoginForm : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private string generatedCode;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            // 1. Перевірка в базі даних
            if (dbHelper.ValidateUser(user, pass))
            {
                // 2. Генерація коду 2FA
                Random rnd = new Random();
                generatedCode = rnd.Next(1000, 9999).ToString();

                // Отримуємо email користувача.
                // У реальному додатку ви б дістали його з бази даних по логіну.
                // Для прикладу припустимо, що логін і є email, або вкажемо жорстко:
                string userEmail = user.Contains("@") ? user : "recipient@example.com";

                try
                {
                    // 3. Відправка реального Email
                    SendEmail(userEmail, generatedCode);

                    // Повідомляємо, що лист пішов (але не показуємо код!)
                    MessageBox.Show($"Kod weryfikacyjny został wysłany na adres: {userEmail}", "Weryfikacja");

                    // 4. Запит коду у користувача
                    string inputCode = Microsoft.VisualBasic.Interaction.InputBox("Podaj kod z Email:", "Weryfikacja 2FA", "");

                    if (inputCode == generatedCode)
                    {
                        MainForm mainForm = new MainForm();
                        this.Hide();
                        mainForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Niepoprawny kod 2FA!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Nie udało się wysłać e-maila. Błąd: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Błędny login lub hasło.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)

        {



        }

        // Метод для конфігурації та відправки листа
        private void SendEmail(string recipientEmail, string code)
        {
            // НАЛАШТУВАННЯ SMTP (приклад для Gmail)
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("vova.disnamar@gmail.com", "rhayyhnxolihwgbf"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("vova.disnamar@gmail.com", "System Faktur"),
                Subject = "Twój kod weryfikacyjny",
                Body = $"Twój kod do logowania to: <b>{code}</b>",
                IsBodyHtml = true,
            };

            mailMessage.To.Add(recipientEmail);

            smtpClient.Send(mailMessage);
        }

        private void btnOpenRegister_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }
    }
}