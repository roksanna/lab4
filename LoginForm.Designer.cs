using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab04
{
    partial class LoginForm : Form
    {
        /// <summary>
        /// Kontener komponentów używany do czyszczenia zasobów.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Zwolnij zasoby używane przez formularz.
        /// </summary>
        /// <param name="disposing">true, jeśli zarządzane zasoby powinny być zwolnione; w przeciwnym razie false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblLogin = new Label();
            lblPassword = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lnkRegister = new LinkLabel();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(12, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 15);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 32);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(40, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Hasło:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(48, 6);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(200, 23);
            txtLogin.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(48, 29);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Location = new Point(170, 58);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Zaloguj";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.LinkColor = Color.FromArgb(255, 128, 128);
            lnkRegister.Location = new Point(67, 91);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(128, 15);
            lnkRegister.TabIndex = 6;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Zarejestruj nowe konto";
            lnkRegister.LinkClicked += LnkRegister_LinkClicked;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(12, 58);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(88, 19);
            chkShowPassword.TabIndex = 5;
            chkShowPassword.Text = "Pokaż hasło";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += ChkShowPassword_CheckedChanged;
            // 
            // LoginForm
            // 
            ClientSize = new Size(314, 118);
            Controls.Add(lblLogin);
            Controls.Add(lblPassword);
            Controls.Add(txtLogin);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(lnkRegister);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logowanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private CheckBox chkShowPassword;
    }
}
