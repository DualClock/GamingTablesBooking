using System.Drawing;
using System.Windows.Forms;

namespace GamingTablesBookingProject.Forms
{
    partial class AdminRegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private ComboBox cmbRole;
        private Button btnCreate;
        private Button btnCancel;
        private Label lblTitle;
        private Label lblLogin;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Label lblRole;
        private Panel headerPanel;
        private TableLayoutPanel mainLayout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            lblTitle = new Label();
            mainLayout = new TableLayoutPanel();
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            buttonPanel = new TableLayoutPanel();
            btnCreate = new Button();
            btnCancel = new Button();
            headerPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(45, 65, 95);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(340, 45);
            headerPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Новый пользователь";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(lblLogin, 0, 0);
            mainLayout.Controls.Add(txtLogin, 1, 0);
            mainLayout.Controls.Add(lblPassword, 0, 1);
            mainLayout.Controls.Add(txtPassword, 1, 1);
            mainLayout.Controls.Add(lblConfirmPassword, 0, 2);
            mainLayout.Controls.Add(txtConfirmPassword, 1, 2);
            mainLayout.Controls.Add(lblRole, 0, 3);
            mainLayout.Controls.Add(cmbRole, 1, 3);
            mainLayout.Controls.Add(buttonPanel, 0, 4);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 45);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(20, 15, 20, 10);
            mainLayout.RowCount = 5;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(340, 255);
            mainLayout.TabIndex = 0;
            // 
            // lblLogin
            // 
            lblLogin.Font = new Font("Segoe UI", 9F);
            lblLogin.ForeColor = Color.Black;
            lblLogin.Location = new Point(23, 15);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(94, 22);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Логин:";
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLogin.Font = new Font("Segoe UI", 10F);
            txtLogin.Location = new Point(123, 18);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(194, 25);
            txtLogin.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(23, 37);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(94, 23);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Пароль:";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(123, 40);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(194, 25);
            txtPassword.TabIndex = 3;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Font = new Font("Segoe UI", 9F);
            lblConfirmPassword.ForeColor = Color.Black;
            lblConfirmPassword.Location = new Point(23, 63);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(94, 22);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Подтверждение:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.Location = new Point(123, 66);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(194, 25);
            txtConfirmPassword.TabIndex = 5;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI", 9F);
            lblRole.ForeColor = Color.Black;
            lblRole.Location = new Point(23, 85);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(94, 23);
            lblRole.TabIndex = 6;
            lblRole.Text = "Роль:";
            // 
            // cmbRole
            // 
            cmbRole.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 9F);
            cmbRole.Items.AddRange(new object[] { "Admin", "Client" });
            cmbRole.Location = new Point(123, 88);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(194, 23);
            cmbRole.TabIndex = 7;
            // 
            // buttonPanel
            // 
            buttonPanel.ColumnCount = 2;
            mainLayout.SetColumnSpan(buttonPanel, 2);
            buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonPanel.Controls.Add(btnCreate, 0, 0);
            buttonPanel.Controls.Add(btnCancel, 1, 0);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(23, 114);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(0, 10, 0, 0);
            buttonPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buttonPanel.Size = new Size(294, 128);
            buttonPanel.TabIndex = 8;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(70, 130, 180);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(3, 13);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(110, 32);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(240, 240, 240);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(70, 130, 180);
            btnCancel.Location = new Point(150, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 32);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AdminRegisterForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(340, 300);
            Controls.Add(mainLayout);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminRegisterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Новый пользователь";
            headerPanel.ResumeLayout(false);
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel buttonPanel;
    }
}