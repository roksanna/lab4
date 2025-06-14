using System.ComponentModel;

namespace lab04.Forms.User;

partial class UserDashboardForm
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
        btnLogout = new Button();
        btnRegisterForEvent = new Button();
        label1 = new Label();
        label2 = new Label();
        lblUserName = new Label();
        lblUserLogin = new Label();
        label4 = new Label();
        dataGridViewRegistrations = new DataGridView();
        panelRegistrations = new Panel();
        ((ISupportInitialize)dataGridViewRegistrations).BeginInit();
        panelRegistrations.SuspendLayout();
        SuspendLayout();
        // 
        // btnLogout
        // 
        btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLogout.BackColor = Color.FromArgb(255, 128, 0);
        btnLogout.FlatAppearance.BorderSize = 0;
        btnLogout.FlatStyle = FlatStyle.Flat;
        btnLogout.ForeColor = Color.White;
        btnLogout.Location = new Point(12, 366);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(120, 30);
        btnLogout.TabIndex = 1;
        btnLogout.Text = "Wyloguj";
        btnLogout.UseVisualStyleBackColor = false;
        btnLogout.Click += btnLogout_Click;
        btnLogout.MouseEnter += Button_MouseEnter;
        btnLogout.MouseLeave += Button_MouseLeave;
        // 
        // btnRegisterForEvent
        // 
        btnRegisterForEvent.BackColor = Color.FromArgb(52, 152, 219);
        btnRegisterForEvent.FlatAppearance.BorderSize = 0;
        btnRegisterForEvent.FlatStyle = FlatStyle.Flat;
        btnRegisterForEvent.ForeColor = Color.White;
        btnRegisterForEvent.Location = new Point(12, 330);
        btnRegisterForEvent.Name = "btnRegisterForEvent";
        btnRegisterForEvent.Size = new Size(120, 30);
        btnRegisterForEvent.TabIndex = 0;
        btnRegisterForEvent.Text = "Zapisz";
        btnRegisterForEvent.UseVisualStyleBackColor = false;
        btnRegisterForEvent.Click += btnRegisterForEvent_Click;
        btnRegisterForEvent.MouseEnter += Button_MouseEnter;
        btnRegisterForEvent.MouseLeave += Button_MouseLeave;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(71, 23);
        label1.Name = "label1";
        label1.Size = new Size(33, 15);
        label1.TabIndex = 0;
        label1.Text = "Imię:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(205, 23);
        label2.Name = "label2";
        label2.Size = new Size(40, 15);
        label2.TabIndex = 1;
        label2.Text = "Login:";
        // 
        // lblUserName
        // 
        lblUserName.AutoSize = true;
        lblUserName.Location = new Point(110, 23);
        lblUserName.Name = "lblUserName";
        lblUserName.Size = new Size(39, 15);
        lblUserName.TabIndex = 3;
        lblUserName.Text = "Name";
        // 
        // lblUserLogin
        // 
        lblUserLogin.AutoSize = true;
        lblUserLogin.Location = new Point(251, 23);
        lblUserLogin.Name = "lblUserLogin";
        lblUserLogin.Size = new Size(37, 15);
        lblUserLogin.TabIndex = 4;
        lblUserLogin.Text = "Login";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(32, 50);
        label4.Name = "label4";
        label4.Size = new Size(73, 15);
        label4.TabIndex = 0;
        label4.Text = "Moje wizyty:";
        label4.Click += label4_Click;
        // 
        // dataGridViewRegistrations
        // 
        dataGridViewRegistrations.AllowUserToAddRows = false;
        dataGridViewRegistrations.AllowUserToDeleteRows = false;
        dataGridViewRegistrations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridViewRegistrations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewRegistrations.BackgroundColor = SystemColors.ControlLightLight;
        dataGridViewRegistrations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewRegistrations.Location = new Point(-1, -1);
        dataGridViewRegistrations.MultiSelect = false;
        dataGridViewRegistrations.Name = "dataGridViewRegistrations";
        dataGridViewRegistrations.ReadOnly = true;
        dataGridViewRegistrations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewRegistrations.Size = new Size(363, 256);
        dataGridViewRegistrations.TabIndex = 1;
        // 
        // panelRegistrations
        // 
        panelRegistrations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panelRegistrations.BackColor = Color.White;
        panelRegistrations.BorderStyle = BorderStyle.FixedSingle;
        panelRegistrations.Controls.Add(dataGridViewRegistrations);
        panelRegistrations.Location = new Point(12, 68);
        panelRegistrations.Name = "panelRegistrations";
        panelRegistrations.Size = new Size(363, 256);
        panelRegistrations.TabIndex = 1;
        panelRegistrations.Paint += panelRegistrations_Paint;
        // 
        // UserDashboardForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(236, 240, 241);
        ClientSize = new Size(800, 542);
        Controls.Add(btnLogout);
        Controls.Add(label4);
        Controls.Add(lblUserLogin);
        Controls.Add(btnRegisterForEvent);
        Controls.Add(label2);
        Controls.Add(lblUserName);
        Controls.Add(panelRegistrations);
        Controls.Add(label1);
        MinimumSize = new Size(816, 581);
        Name = "UserDashboardForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Panel użytkownika";
        Load += UserDashboardForm_Load;
        ((ISupportInitialize)dataGridViewRegistrations).EndInit();
        panelRegistrations.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button btnLogout;
    private Button btnRegisterForEvent;
    private Label label1;
    private Label label2;
    private Label lblUserName;
    private Label lblUserLogin;
    private Label label4;
    private DataGridView dataGridViewRegistrations;
    private Panel panelRegistrations;
}
