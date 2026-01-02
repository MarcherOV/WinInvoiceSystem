using PdfSharp.Quality;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinInvoiceSystem
{
    public partial class RegisterForm : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegisterConfirm_Click(object sender, EventArgs e)
        {
            string user = txtRegUser.Text.Trim();
            string pass = txtRegPass.Text.Trim();
            string email = txtRegEmail.Text.Trim();

            // Проста валідація
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione!");
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Niepoprawny format email!");
                return;
            }

            // Спроба реєстрації
            bool success = dbHelper.RegisterUser(user, pass, email);

            if (success)
            {
                MessageBox.Show("Rejestracja udana! Możesz się zalogować.");
                this.Close(); // Закриваємо форму реєстрації
            }
            else
            {
                MessageBox.Show("Rejestracja nieudana. Taki użytkownik już istnieje lub wystąpił błąd.");
            }
        }
    }
}
