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
            this.lblConfirmPassword = new Label();
            this.txtLogin = new TextBox();
            this.txtPassword = new TextBox();
            this.txtConfirmPassword = new TextBox();
            this.btnRegister = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();

            this.lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitle.Location = new Point(90, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(120, 20);
            this.lblTitle.Text = "Регистрация";

            this.lblLogin.Location = new Point(30, 60);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new Size(100, 20);
            this.lblLogin.Text = "Логин:";

            this.txtLogin.Location = new Point(30, 80);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new Size(240, 23);

            this.lblPassword.Location = new Point(30, 115);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(100, 20);
            this.lblPassword.Text = "Пароль:";

            this.txtPassword.Location = new Point(30, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new Size(240, 23);

            this.lblConfirmPassword.Location = new Point(30, 170);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new Size(140, 20);
            this.lblConfirmPassword.Text = "Подтвердите пароль:";

            this.txtConfirmPassword.Location = new Point(30, 190);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new Size(240, 23);

            this.btnRegister.Location = new Point(30, 240);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new Size(115, 30);
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.Click += new EventHandler(this.btnRegister_Click);

            this.btnCancel.Location = new Point(155, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(115, 30);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            this.ClientSize = new Size(300, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
        }
    }
}