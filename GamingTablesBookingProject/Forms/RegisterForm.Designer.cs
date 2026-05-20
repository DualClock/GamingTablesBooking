using System.Drawing;
using System.Windows.Forms;

namespace GamingTablesBookingProject.Forms
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnRegister;
        private Button btnCancel;
        private Label lblTitle;
        private Label lblLogin;
        private Label lblPassword;
        private Label lblConfirmPassword;
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
            this.headerPanel = new Panel();
            this.lblTitle = new Label();
            this.mainLayout = new TableLayoutPanel();
            this.lblLogin = new Label();
            this.txtLogin = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.lblConfirmPassword = new Label();
            this.txtConfirmPassword = new TextBox();
            this.btnRegister = new Button();
            this.btnCancel = new Button();

            this.SuspendLayout();

            // Фон
            this.BackColor = Color.White;
            this.ClientSize = new Size(340, 300);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Font = new Font("Segoe UI", 9F);

            // Header
            this.headerPanel.Dock = DockStyle.Top;
            this.headerPanel.Height = 45;
            this.headerPanel.BackColor = Color.FromArgb(45, 65, 95);

            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.Text = "Регистрация";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.headerPanel.Controls.Add(this.lblTitle);

            // Main layout
            this.mainLayout.Dock = DockStyle.Fill;
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.RowCount = 4;
            this.mainLayout.Padding = new Padding(20, 15, 20, 10);

            // Колонки
            this.mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            this.mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            // Строки
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22));
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26));
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22));
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26));

            // Добавляем пустую строку для кнопок
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            // Лейблы
            this.lblLogin.Text = "Логин:";
            this.lblLogin.Font = new Font("Segoe UI", 9F);
            this.lblLogin.ForeColor = Color.Black;

            this.lblPassword.Text = "Пароль:";
            this.lblPassword.Font = new Font("Segoe UI", 9F);
            this.lblPassword.ForeColor = Color.Black;

            this.lblConfirmPassword.Text = "Подтверждение:";
            this.lblConfirmPassword.Font = new Font("Segoe UI", 9F);
            this.lblConfirmPassword.ForeColor = Color.Black;

            // Поля ввода
            this.txtLogin.Font = new Font("Segoe UI", 10F);
            this.txtLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            this.txtPassword.Font = new Font("Segoe UI", 10F);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            this.txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            // Кнопки
            this.btnRegister.BackColor = Color.FromArgb(70, 130, 180);
            this.btnRegister.ForeColor = Color.White;
            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.Size = new Size(110, 32);
            this.btnRegister.Click += new EventHandler(this.btnRegister_Click);

            this.btnCancel.BackColor = Color.FromArgb(240, 240, 240);
            this.btnCancel.ForeColor = Color.FromArgb(70, 130, 180);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Size = new Size(110, 32);
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // Панель для кнопок
            TableLayoutPanel buttonPanel = new TableLayoutPanel();
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.ColumnCount = 2;
            buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            buttonPanel.Controls.Add(this.btnRegister, 0, 0);
            buttonPanel.Controls.Add(this.btnCancel, 1, 0);
            buttonPanel.Padding = new Padding(0, 10, 0, 0);

            // Добавляем в layout
            this.mainLayout.Controls.Add(this.lblLogin, 0, 0);
            this.mainLayout.Controls.Add(this.txtLogin, 1, 0);
            this.mainLayout.Controls.Add(this.lblPassword, 0, 1);
            this.mainLayout.Controls.Add(this.txtPassword, 1, 1);
            this.mainLayout.Controls.Add(this.lblConfirmPassword, 0, 2);
            this.mainLayout.Controls.Add(this.txtConfirmPassword, 1, 2);
            this.mainLayout.Controls.Add(buttonPanel, 0, 4);
            this.mainLayout.SetColumnSpan(buttonPanel, 2);

            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.headerPanel);

            this.ResumeLayout(false);
        }
    }
}