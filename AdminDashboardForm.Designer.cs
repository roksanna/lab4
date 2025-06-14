using lab04.Data.Models;
using System.ComponentModel;

namespace lab04;

partial class AdminDashboardForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        headerPanel = new Panel();
        titleLabel = new Label();
        logoutButton = new Button();
        mainPanel = new Panel();
        usersButton = new Button();
        eventsButton = new Button();
        registrationsButton = new Button();
        footerPanel = new Panel();
        timeLabel = new Label();
        headerPanel.SuspendLayout();
        mainPanel.SuspendLayout();
        footerPanel.SuspendLayout();
        SuspendLayout();
        // 
        // headerPanel
        // 
        headerPanel.BackColor = Color.DarkGray;
        headerPanel.Controls.Add(titleLabel);
        headerPanel.Controls.Add(logoutButton);
        headerPanel.Dock = DockStyle.Top;
        headerPanel.Location = new Point(0, 0);
        headerPanel.Name = "headerPanel";
        headerPanel.Size = new Size(294, 80);
        headerPanel.TabIndex = 0;
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        titleLabel.ForeColor = Color.White;
        titleLabel.Location = new Point(20, 15);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(86, 32);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "MENU";
        titleLabel.Click += titleLabel_Click;
        // 
        // logoutButton
        // 
        logoutButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        logoutButton.BackColor = Color.FromArgb(231, 76, 60);
        logoutButton.FlatAppearance.BorderSize = 0;
        logoutButton.FlatStyle = FlatStyle.Flat;
        logoutButton.Font = new Font("Segoe UI", 10F);
        logoutButton.ForeColor = Color.White;
        logoutButton.Location = new Point(974, 25);
        logoutButton.Name = "logoutButton";
        logoutButton.Size = new Size(100, 30);
        logoutButton.TabIndex = 2;
        logoutButton.Text = "Wyloguj";
        logoutButton.UseVisualStyleBackColor = false;
        logoutButton.Click += LogoutButton_Click;
        // 
        // mainPanel
        // 
        mainPanel.BackColor = Color.FromArgb(236, 240, 241);
        mainPanel.Controls.Add(registrationsButton);
        mainPanel.Controls.Add(eventsButton);
        mainPanel.Controls.Add(usersButton);
        mainPanel.Dock = DockStyle.Fill;
        mainPanel.Location = new Point(0, 80);
        mainPanel.Name = "mainPanel";
        mainPanel.Padding = new Padding(20);
        mainPanel.Size = new Size(294, 313);
        mainPanel.TabIndex = 1;
        // 
        // usersButton
        // 
        usersButton.BackColor = Color.Maroon;
        usersButton.FlatAppearance.BorderSize = 0;
        usersButton.FlatStyle = FlatStyle.Flat;
        usersButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        usersButton.ForeColor = Color.White;
        usersButton.ImageAlign = ContentAlignment.TopCenter;
        usersButton.Location = new Point(44, 23);
        usersButton.Name = "usersButton";
        usersButton.Size = new Size(126, 80);
        usersButton.TabIndex = 1;
        usersButton.Text = "\r\nUżytkownicy";
        usersButton.TextAlign = ContentAlignment.TopCenter;
        usersButton.UseVisualStyleBackColor = false;
        usersButton.Click += UsersButton_Click;
        usersButton.MouseEnter += Button_MouseEnter;
        usersButton.MouseLeave += Button_MouseLeave;
        // 
        // eventsButton
        // 
        eventsButton.BackColor = Color.FromArgb(255, 128, 128);
        eventsButton.FlatAppearance.BorderSize = 0;
        eventsButton.FlatStyle = FlatStyle.Flat;
        eventsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        eventsButton.ForeColor = Color.White;
        eventsButton.Location = new Point(44, 227);
        eventsButton.Name = "eventsButton";
        eventsButton.Size = new Size(126, 80);
        eventsButton.TabIndex = 2;
        eventsButton.Text = "\r\nWydarzenia";
        eventsButton.TextAlign = ContentAlignment.TopCenter;
        eventsButton.UseVisualStyleBackColor = false;
        eventsButton.Click += EventsButton_Click;
        eventsButton.MouseEnter += Button_MouseEnter;
        eventsButton.MouseLeave += Button_MouseLeave;
        // 
        // registrationsButton
        // 
        registrationsButton.BackColor = Color.FromArgb(128, 128, 255);
        registrationsButton.FlatAppearance.BorderSize = 0;
        registrationsButton.FlatStyle = FlatStyle.Flat;
        registrationsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        registrationsButton.ForeColor = Color.White;
        registrationsButton.Location = new Point(44, 123);
        registrationsButton.Name = "registrationsButton";
        registrationsButton.Size = new Size(126, 80);
        registrationsButton.TabIndex = 3;
        registrationsButton.Text = "\r\nZapisy";
        registrationsButton.TextAlign = ContentAlignment.TopCenter;
        registrationsButton.UseVisualStyleBackColor = false;
        registrationsButton.Click += RegistrationsButton_Click;
        registrationsButton.MouseEnter += Button_MouseEnter;
        registrationsButton.MouseLeave += Button_MouseLeave;
        // 
        // footerPanel
        // 
        footerPanel.BackColor = Color.Gray;
        footerPanel.Controls.Add(timeLabel);
        footerPanel.Dock = DockStyle.Bottom;
        footerPanel.Location = new Point(0, 393);
        footerPanel.Name = "footerPanel";
        footerPanel.Size = new Size(294, 30);
        footerPanel.TabIndex = 2;
        // 
        // timeLabel
        // 
        timeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        timeLabel.AutoSize = true;
        timeLabel.ForeColor = Color.White;
        timeLabel.Location = new Point(974, 8);
        timeLabel.Name = "timeLabel";
        timeLabel.Size = new Size(91, 15);
        timeLabel.TabIndex = 1;
        timeLabel.Text = "14.06.2025 02:03";
        // 
        // AdminDashboardForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(294, 423);
        Controls.Add(mainPanel);
        Controls.Add(headerPanel);
        Controls.Add(footerPanel);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "AdminDashboardForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Panel Administratora";
        Load += AdminDashboardForm_Load;
        headerPanel.ResumeLayout(false);
        headerPanel.PerformLayout();
        mainPanel.ResumeLayout(false);
        footerPanel.ResumeLayout(false);
        footerPanel.PerformLayout();
        ResumeLayout(false);
    }

    private void ReportsButton_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    #endregion

    private Panel headerPanel;
    private Label titleLabel;
    private Button logoutButton;
    private Panel mainPanel;
    private Button usersButton;
    private Button eventsButton;
    private Button registrationsButton;
    private Panel footerPanel;
    private Label timeLabel;
}
