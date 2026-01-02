namespace WinInvoiceSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInvoiceNo = new TextBox();
            txtClient = new TextBox();
            txtAmount = new TextBox();
            cmbCurrency = new ComboBox();
            btnGetRate = new Button();
            btnSavePdf = new Button();
            lblRate = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtInvoiceNo
            // 
            txtInvoiceNo.Location = new Point(318, 94);
            txtInvoiceNo.Name = "txtInvoiceNo";
            txtInvoiceNo.Size = new Size(125, 27);
            txtInvoiceNo.TabIndex = 0;
            // 
            // txtClient
            // 
            txtClient.Location = new Point(318, 154);
            txtClient.Name = "txtClient";
            txtClient.Size = new Size(125, 27);
            txtClient.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(318, 218);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 27);
            txtAmount.TabIndex = 2;
            // 
            // cmbCurrency
            // 
            cmbCurrency.FormattingEnabled = true;
            cmbCurrency.Items.AddRange(new object[] { "EUR", "USD", "GBP", "PLN" });
            cmbCurrency.Location = new Point(307, 273);
            cmbCurrency.Name = "cmbCurrency";
            cmbCurrency.Size = new Size(151, 28);
            cmbCurrency.TabIndex = 3;
            // 
            // btnGetRate
            // 
            btnGetRate.Location = new Point(205, 322);
            btnGetRate.Name = "btnGetRate";
            btnGetRate.Size = new Size(94, 29);
            btnGetRate.TabIndex = 4;
            btnGetRate.Text = "Pobierz kurs";
            btnGetRate.UseVisualStyleBackColor = true;
            btnGetRate.Click += btnGetRate_ClickAsync;
            // 
            // btnSavePdf
            // 
            btnSavePdf.Location = new Point(467, 322);
            btnSavePdf.Name = "btnSavePdf";
            btnSavePdf.Size = new Size(94, 29);
            btnSavePdf.TabIndex = 5;
            btnSavePdf.Text = "Zapisz PDF";
            btnSavePdf.UseVisualStyleBackColor = true;
            btnSavePdf.Click += btnSavePdf_Click;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(360, 368);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(0, 20);
            lblRate.TabIndex = 6;
            lblRate.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 94);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 7;
            label1.Text = "Numer faktury";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 154);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 8;
            label2.Text = "Klient";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 218);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 9;
            label3.Text = "Kwota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 273);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 10;
            label4.Text = "Waluta";
            label4.Click += label4_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblRate);
            Controls.Add(btnSavePdf);
            Controls.Add(btnGetRate);
            Controls.Add(cmbCurrency);
            Controls.Add(txtAmount);
            Controls.Add(txtClient);
            Controls.Add(txtInvoiceNo);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInvoiceNo;
        private TextBox txtClient;
        private TextBox txtAmount;
        private ComboBox cmbCurrency;
        private Button btnGetRate;
        private Button btnSavePdf;
        private Label lblRate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}