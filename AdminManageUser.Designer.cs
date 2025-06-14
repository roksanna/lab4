namespace lab04.Forms.Admin
{
    partial class AdminManageUsersForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            labelTitle = new Label();
            panelButtons = new Panel();
            btnAddUser = new Button();
            btnDeleteUser = new Button();
            btnResetPassword = new Button();
            btnRefresh = new Button();
            dataGridViewUsers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colPassword = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(64, 64, 64);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(784, 60);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(20, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(144, 30);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Zarządzanie ";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.White;
            panelButtons.Controls.Add(btnAddUser);
            panelButtons.Controls.Add(btnDeleteUser);
            panelButtons.Controls.Add(btnResetPassword);
            panelButtons.Controls.Add(btnRefresh);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 60);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(784, 214);
            panelButtons.TabIndex = 1;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Black;
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUser.Location = new Point(20, 15);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Padding = new Padding(10, 0, 10, 0);
            btnAddUser.Size = new Size(150, 40);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "  Dodaj użytkownika";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.Black;
            btnDeleteUser.Enabled = false;
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(20, 107);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(150, 40);
            btnDeleteUser.TabIndex = 1;
            btnDeleteUser.Text = "Usuń użytkownika";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = Color.Black;
            btnResetPassword.Enabled = false;
            btnResetPassword.FlatAppearance.BorderSize = 0;
            btnResetPassword.FlatStyle = FlatStyle.Flat;
            btnResetPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Location = new Point(20, 153);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(150, 40);
            btnResetPassword.TabIndex = 2;
            btnResetPassword.Text = "Reset hasła";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Black;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(20, 61);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 40);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Odśwież";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsers.ColumnHeadersHeight = 35;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewUsers.Columns.AddRange(new DataGridViewColumn[] { colId, colUsername, colEmail, colRole, colFirstName, colLastName, colPassword });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(173, 216, 230);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.EnableHeadersVisualStyles = false;
            dataGridViewUsers.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewUsers.Location = new Point(0, 274);
            dataGridViewUsers.MultiSelect = false;
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersVisible = false;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(784, 102);
            dataGridViewUsers.TabIndex = 2;
            dataGridViewUsers.SelectionChanged += dataGridViewUsers_SelectionChanged;
            dataGridViewUsers.DoubleClick += dataGridViewUsers_DoubleClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 50;
            // 
            // colUsername
            // 
            colUsername.DataPropertyName = "Login";
            colUsername.HeaderText = "Nazwa użytkownika";
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            colUsername.Width = 150;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 200;
            // 
            // colRole
            // 
            colRole.DataPropertyName = "Permissions";
            colRole.HeaderText = "Rola";
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            // 
            // colFirstName
            // 
            colFirstName.DataPropertyName = "FirstName";
            colFirstName.HeaderText = "Imie";
            colFirstName.Name = "colFirstName";
            colFirstName.ReadOnly = true;
            // 
            // colLastName
            // 
            colLastName.DataPropertyName = "LastName";
            colLastName.HeaderText = "Nazwisko";
            colLastName.Name = "colLastName";
            colLastName.ReadOnly = true;
            // 
            // colPassword
            // 
            colPassword.DataPropertyName = "Password";
            colPassword.HeaderText = "Password";
            colPassword.Name = "colPassword";
            colPassword.ReadOnly = true;
            colPassword.Visible = false;
            // 
            // AdminManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 376);
            Controls.Add(dataGridViewUsers);
            Controls.Add(panelButtons);
            Controls.Add(panelHeader);
            MinimumSize = new Size(800, 400);
            Name = "AdminManageUsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zarządzanie Użytkownikami";
            Load += AdminManageUsersForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelButtons;
        private Button btnAddUser;
        private Button btnDeleteUser;
        private Button btnResetPassword;
        private Button btnRefresh;
        private DataGridView dataGridViewUsers;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colPassword;
    }
}
