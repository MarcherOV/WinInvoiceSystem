namespace WinInvoiceSystem
{
    partial class RegisterForm
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
            txtRegUser = new TextBox();
            txtRegPass = new TextBox();
            txtRegEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRegisterConfirm = new Button();
            SuspendLayout();
            // 
            // txtRegUser
            // 
            txtRegUser.Location = new Point(322, 104);
            txtRegUser.Name = "txtRegUser";
            txtRegUser.Size = new Size(125, 27);
            txtRegUser.TabIndex = 0;
            // 
            // txtRegPass
            // 
            txtRegPass.Location = new Point(322, 166);
            txtRegPass.Name = "txtRegPass";
            txtRegPass.Size = new Size(125, 27);
            txtRegPass.TabIndex = 1;
            // 
            // txtRegEmail
            // 
            txtRegEmail.Location = new Point(322, 223);
            txtRegEmail.Name = "txtRegEmail";
            txtRegEmail.Size = new Size(125, 27);
            txtRegEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 111);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 173);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 230);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // btnRegisterConfirm
            // 
            btnRegisterConfirm.Location = new Point(336, 288);
            btnRegisterConfirm.Name = "btnRegisterConfirm";
            btnRegisterConfirm.Size = new Size(94, 29);
            btnRegisterConfirm.TabIndex = 6;
            btnRegisterConfirm.Text = "Sign up";
            btnRegisterConfirm.UseVisualStyleBackColor = true;
            btnRegisterConfirm.Click += btnRegisterConfirm_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegisterConfirm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRegEmail);
            Controls.Add(txtRegPass);
            Controls.Add(txtRegUser);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRegUser;
        private TextBox txtRegPass;
        private TextBox txtRegEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRegisterConfirm;
    }
}