namespace WinInvoiceSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fileSystemWatcher1 = new FileSystemWatcher();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            LabelName = new Label();
            label2 = new Label();
            Login = new Button();
            btnOpenRegister = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(333, 150);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(333, 217);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 1;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(333, 127);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(75, 20);
            LabelName.TabIndex = 2;
            LabelName.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 194);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // Login
            // 
            Login.Location = new Point(347, 289);
            Login.Name = "Login";
            Login.Size = new Size(94, 29);
            Login.TabIndex = 4;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // btnOpenRegister
            // 
            btnOpenRegister.Location = new Point(347, 361);
            btnOpenRegister.Name = "btnOpenRegister";
            btnOpenRegister.Size = new Size(94, 29);
            btnOpenRegister.TabIndex = 5;
            btnOpenRegister.Text = "Sign up";
            btnOpenRegister.UseVisualStyleBackColor = true;
            btnOpenRegister.Click += btnOpenRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 365);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 6;
            label1.Text = "Nie masz konta?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnOpenRegister);
            Controls.Add(Login);
            Controls.Add(label2);
            Controls.Add(LabelName);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Label label2;
        private Label LabelName;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button Login;
        private Label label1;
        private Button btnOpenRegister;
    }
}
