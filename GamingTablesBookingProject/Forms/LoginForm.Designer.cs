using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GamingTablesBookingProject.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel topPanel;
        private Panel cardPanel;
        private Label lblTitle;
        private Label lblLogin;
        private Label lblPassword;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Panel loginLine;
        private Panel passwordLine;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.topPanel = new Panel();
            this.cardPanel = new Panel();
            this.lblTitle = new Label();
            this.lblLogin = new Label();
            this.lblPassword = new Label();
            this.txtLogin = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.btnRegister = new Button();
            this.loginLine = new Panel();
            this.passwordLine = new Panel();

            this.SuspendLayout();

            this.BackColor = Color.FromArgb(236, 240, 244);
            this.ClientSize = new Size(420, 360);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

            this.topPanel.Dock = DockStyle.Top;
            this.topPanel.Height = 84;
            this.topPanel.BackColor = Color.FromArgb(54, 92, 130);
            this.topPanel.Paint += TopPanel_Paint;

            this.lblTitle.AutoSize = false;
            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.Text = "Авторизация";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.topPanel.Controls.Add(this.lblTitle);

            this.cardPanel.Size = new Size(320, 220);
            this.cardPanel.Location = new Point((this.ClientSize.Width - this.cardPanel.Width) / 2, 108);
            this.cardPanel.BackColor = Color.White;
            this.cardPanel.BorderStyle = BorderStyle.FixedSingle;

            this.lblLogin.AutoSize = false;
            this.lblLogin.Text = "Логин";
            this.lblLogin.Location = new Point(28, 22);
            this.lblLogin.Size = new Size(100, 18);
            this.lblLogin.ForeColor = Color.FromArgb(70, 70, 70);
            this.lblLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

            this.txtLogin.BorderStyle = BorderStyle.None;
            this.txtLogin.Location = new Point(28, 45);
            this.txtLogin.Size = new Size(264, 22);
            this.txtLogin.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            this.txtLogin.BackColor = Color.White;

            this.loginLine.BackColor = Color.FromArgb(150, 170, 190);
            this.loginLine.Location = new Point(28, 70);
            this.loginLine.Size = new Size(264, 1);

            this.lblPassword.AutoSize = false;
            this.lblPassword.Text = "Пароль";
            this.lblPassword.Location = new Point(28, 90);
            this.lblPassword.Size = new Size(100, 18);
            this.lblPassword.ForeColor = Color.FromArgb(70, 70, 70);
            this.lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

            this.txtPassword.BorderStyle = BorderStyle.None;
            this.txtPassword.Location = new Point(28, 113);
            this.txtPassword.Size = new Size(264, 22);
            this.txtPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.BackColor = Color.White;

            this.passwordLine.BackColor = Color.FromArgb(150, 170, 190);
            this.passwordLine.Location = new Point(28, 138);
            this.passwordLine.Size = new Size(264, 1);

            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Location = new Point(28, 160);
            this.btnLogin.Size = new Size(126, 36);
            this.btnLogin.Text = "Войти";
            this.btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.BackColor = Color.FromArgb(70, 130, 180);
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.FlatAppearance.BorderSize = 1;
            this.btnRegister.FlatAppearance.BorderColor = Color.FromArgb(70, 130, 180);
            this.btnRegister.Location = new Point(166, 160);
            this.btnRegister.Size = new Size(126, 36);
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnRegister.ForeColor = Color.FromArgb(70, 130, 180);
            this.btnRegister.BackColor = Color.White;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new EventHandler(this.btnRegister_Click);

            this.cardPanel.Controls.Add(this.lblLogin);
            this.cardPanel.Controls.Add(this.txtLogin);
            this.cardPanel.Controls.Add(this.loginLine);
            this.cardPanel.Controls.Add(this.lblPassword);
            this.cardPanel.Controls.Add(this.txtPassword);
            this.cardPanel.Controls.Add(this.passwordLine);
            this.cardPanel.Controls.Add(this.btnLogin);
            this.cardPanel.Controls.Add(this.btnRegister);

            this.Controls.Add(this.cardPanel);
            this.Controls.Add(this.topPanel);

            this.ResumeLayout(false);
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.topPanel.ClientRectangle,
                Color.FromArgb(44, 71, 102),
                Color.FromArgb(79, 133, 187),
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.topPanel.ClientRectangle);
            }
        }
    }
}