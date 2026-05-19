namespace GamingTablesBookingProject.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Label lblTitle;
        private Label lblLogin;
        private Label lblPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblLogin = new Label();
            this.lblPassword = new Label();
            this.txtLogin = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.btnRegister = new Button();
            this.SuspendLayout();

            this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitle.Location = new Point(80, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(140, 25);
            this.lblTitle.Text = "Авторизация";

            this.lblLogin.Location = new Point(30, 80);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new Size(100, 20);
            this.lblLogin.Text = "Логин:";

            this.txtLogin.Location = new Point(30, 100);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new Size(240, 23);

            this.lblPassword.Location = new Point(30, 140);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(100, 20);
            this.lblPassword.Text = "Пароль:";

            this.txtPassword.Location = new Point(30, 160);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new Size(240, 23);

            this.btnLogin.Location = new Point(30, 210);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(115, 30);
            this.btnLogin.Text = "Войти";
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

            this.btnRegister.Location = new Point(155, 210);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new Size(115, 30);
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.Click += new EventHandler(this.btnRegister_Click);

            this.ClientSize = new Size(300, 280);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.ResumeLayout(false);
        }
    }
}