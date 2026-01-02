using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinInvoiceSystem
{
    public partial class MainForm : Form
    {
        private NbpService nbpService = new NbpService();
        private PdfService pdfService = new PdfService();
        private decimal currentRate = 1.0m;
        public MainForm()
        {
            InitializeComponent();
            cmbCurrency.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnGetRate_ClickAsync(object sender, EventArgs e)
        {
            string currency = cmbCurrency.Text;
            try
            {
                currentRate = await nbpService.GetExchangeRateAsync(currency);
                lblRate.Text = $"Kurs: {currentRate}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania kursu: " + ex.Message);
            }
        }

        private void btnSavePdf_Click(object sender, EventArgs e)
        {
            // 1. Спочатку валідація
            if (string.IsNullOrWhiteSpace(txtInvoiceNo.Text) || string.IsNullOrWhiteSpace(txtClient.Text))
            {
                MessageBox.Show("Заповніть номер фактури та клієнта!");
                return;
            }

            // Перевірка курсу (щоб не було 1.0 для Євро, як у вашому PDF)
            if (cmbCurrency.Text != "PLN" && currentRate == 1.0m)
            {
                var result = MessageBox.Show("Увага! Курс валюти дорівнює 1.0. Ви забули натиснути 'Pobierz kurs'? Продовжити?", "Перевірка курсу", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf";
            sfd.FileName = $"Faktura_{txtInvoiceNo.Text}.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    decimal amount = 0;
                    decimal.TryParse(txtAmount.Text, out amount);

                    // --- БЛОК 1: ГЕНЕРАЦІЯ PDF ---
                    pdfService.GenerateInvoice(sfd.FileName, txtInvoiceNo.Text, txtClient.Text, amount, cmbCurrency.Text, currentRate);

                    // --- БЛОК 2: ЗБЕРЕЖЕННЯ В БД (SQL) ---
                    SaveInvoiceToDb(txtInvoiceNo.Text, txtClient.Text, amount, cmbCurrency.Text, currentRate);

                    MessageBox.Show("Фактура збережена в БД та експортована в PDF!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private void SaveInvoiceToDb(string number, string clientName, decimal amount, string currency, decimal rate)
        {
            string connString = @"Data Source=MARCHER_OV\SQLEXPRESS03;Initial Catalog=InvoiceSystemDB;Integrated Security=True;Encrypt=False;";

            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString))
            {
                conn.Open();

                // 1. Спочатку додамо/знайдемо контрагента (спрощено - просто вставляємо, якщо немає перевірки)
                // Для спрощення завдання запишемо ID контрагента як 1 або створимо фіктивного.
                // Але краще записати саму фактуру.

                string query = @"
            INSERT INTO Invoices (InvoiceNumber, ContractorId, CurrencyCode, ExchangeRate, TotalAmount, IssueDate)
            VALUES (@Num, 1, @Curr, @Rate, @Amt, @Date)";
                // Примітка: ContractorId=1 означає, що у вас в таблиці Contractors має бути хоча б один запис.
                // Якщо його немає, виконайте в SQL: INSERT INTO Contractors (Name) VALUES ('Default Client');

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Num", number);
                    cmd.Parameters.AddWithValue("@Curr", currency);
                    cmd.Parameters.AddWithValue("@Rate", rate);
                    cmd.Parameters.AddWithValue("@Amt", amount);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
