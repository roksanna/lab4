using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using lab04.Data.Models;

namespace lab04.Forms.Admin
{
    public partial class AdminEditUserForm : Form
    {
        public Data.Models.User UpdatedUser { get; private set; }

        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblRole;
        private ComboBox cmbRole;
        private GroupBox grpPasswordReset;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmNewPassword;
        private TextBox txtConfirmNewPassword;
        private Button btnSave;
        private Button btnCancel;
        private TextBox textBoxFirstName;


        private void InitializeComponent()
        {
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            grpPasswordReset = new GroupBox();
            txtConfirmNewPassword = new TextBox();
            lblConfirmNewPassword = new Label();
            txtNewPassword = new TextBox();
            lblNewPassword = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            textBoxFirstName = new TextBox();
            labelFirstName = new Label();
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            grpPasswordReset.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsername.Location = new Point(7, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(121, 15);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "Nazwa użytkownika:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.Location = new Point(129, 6);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(276, 23);
            txtUsername.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(7, 96);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(48, 34);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 23);
            txtEmail.TabIndex = 8;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRole.Location = new Point(12, 133);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(34, 15);
            lblRole.TabIndex = 7;
            lblRole.Text = "Rola:";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 9F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "0", "1" });
            cmbRole.Location = new Point(52, 130);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(125, 23);
            cmbRole.TabIndex = 6;
            // 
            // grpPasswordReset
            // 
            grpPasswordReset.Controls.Add(txtConfirmNewPassword);
            grpPasswordReset.Controls.Add(lblConfirmNewPassword);
            grpPasswordReset.Controls.Add(txtNewPassword);
            grpPasswordReset.Controls.Add(lblNewPassword);
            grpPasswordReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpPasswordReset.Location = new Point(12, 176);
            grpPasswordReset.Name = "grpPasswordReset";
            grpPasswordReset.Size = new Size(400, 102);
            grpPasswordReset.TabIndex = 0;
            grpPasswordReset.TabStop = false;
            grpPasswordReset.Text = "Reset hasła";
            grpPasswordReset.Enter += grpPasswordReset_Enter;
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Enabled = false;
            txtConfirmNewPassword.Font = new Font("Segoe UI", 9F);
            txtConfirmNewPassword.Location = new Point(105, 54);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.PasswordChar = '*';
            txtConfirmNewPassword.Size = new Size(222, 23);
            txtConfirmNewPassword.TabIndex = 0;
            // 
            // lblConfirmNewPassword
            // 
            lblConfirmNewPassword.AutoSize = true;
            lblConfirmNewPassword.Enabled = false;
            lblConfirmNewPassword.Font = new Font("Segoe UI", 9F);
            lblConfirmNewPassword.Location = new Point(6, 57);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Size = new Size(93, 15);
            lblConfirmNewPassword.TabIndex = 1;
            lblConfirmNewPassword.Text = "Potwierdź hasło:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Enabled = false;
            txtNewPassword.Font = new Font("Segoe UI", 9F);
            txtNewPassword.Location = new Point(84, 16);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(243, 23);
            txtNewPassword.TabIndex = 2;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Enabled = false;
            lblNewPassword.Font = new Font("Segoe UI", 9F);
            lblNewPassword.Location = new Point(6, 19);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(72, 15);
            lblNewPassword.TabIndex = 3;
            lblNewPassword.Text = "Nowe hasło:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 192, 192);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(12, 284);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 30);
            btnSave.TabIndex = 1;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 255, 192);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(129, 284);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 30);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI", 9F);
            textBoxFirstName.Location = new Point(48, 93);
            textBoxFirstName.MaxLength = 100;
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(172, 23);
            textBoxFirstName.TabIndex = 13;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelFirstName.Location = new Point(7, 34);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(35, 15);
            labelFirstName.TabIndex = 14;
            labelFirstName.Text = "Imię:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 9F);
            textBoxLastName.Location = new Point(73, 67);
            textBoxLastName.MaxLength = 100;
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(291, 23);
            textBoxLastName.TabIndex = 15;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelLastName.Location = new Point(7, 70);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(60, 15);
            labelLastName.TabIndex = 16;
            labelLastName.Text = "Nazwisko";
            // 
            // AdminEditUserForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(450, 328);
            Controls.Add(btnCancel);
            Controls.Add(textBoxLastName);
            Controls.Add(btnSave);
            Controls.Add(labelLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(grpPasswordReset);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminEditUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edytuj użytkownika";
            grpPasswordReset.ResumeLayout(false);
            grpPasswordReset.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoadUserData()
        {
            txtUsername.Text = user.Login;
            txtEmail.Text = user.Email;
            cmbRole.SelectedItem = user.Permissions;
            textBoxFirstName.Text = user.FirstName;
            textBoxLastName.Text = user.LastName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    UpdatedUser = new Data.Models.User
                    {
                        Id = user.Id,
                        Login = txtUsername.Text.Trim(),
                        FirstName = textBoxFirstName.Text.Trim(),
                        LastName = textBoxLastName.Text.Trim(),
                        Password = txtNewPassword.Text.Equals("") ? txtNewPassword.Text.Trim() : user.Password,
                        Email = txtEmail.Text.Trim(),
                        Permissions = ushort.Parse(cmbRole.SelectedItem.ToString()),
                    };

                    this._userService.UpdateUser(UpdatedUser);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd podczas aktualizacji użytkownika: {ex.Message}",
                        "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            // Walidacja nazwy użytkownika
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                ShowValidationError("Nazwa użytkownika jest wymagana.", txtUsername);
                return false;
            }

            if (txtUsername.Text.Length < 3)
            {
                ShowValidationError("Nazwa użytkownika musi mieć co najmniej 3 znaki.", txtUsername);
                return false;
            }

            if (!Regex.IsMatch(txtUsername.Text, @"^[a-zA-Z0-9_]+$"))
            {
                ShowValidationError("Nazwa użytkownika może zawierać tylko litery, cyfry i podkreślenia.", txtUsername);
                return false;
            }

            // Walidacja emaila
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ShowValidationError("Email jest wymagany.", txtEmail);
                return false;
            }

            return true;
        }

        private void ShowValidationError(string message, Control control)
        {
            MessageBox.Show(message, "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        private Label labelFirstName; private TextBox textBoxLastName;
        private Label labelLastName;
    }
}
