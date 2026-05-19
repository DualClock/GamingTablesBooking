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
            this.lblRole = new Label();
            this.txtLogin = new TextBox();
            this.txtPassword = new TextBox();
            this.txtConfirmPassword = new TextBox();
            this.cmbRole = new ComboBox();
            this.btnCreate = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();

            this.lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitle.Location = new Point(80, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(140, 20);
            this.lblTitle.Text = "Новый пользователь";

            this.lblLogin.Location = new Point(30, 55);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new Size(100, 20);
            this.lblLogin.Text = "Логин:";

            this.txtLogin.Location = new Point(30, 75);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new Size(240, 23);

            this.lblPassword.Location = new Point(30, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(100, 20);
            this.lblPassword.Text = "Пароль:";

            this.txtPassword.Location = new Point(30, 130);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new Size(240, 23);

            this.lblConfirmPassword.Location = new Point(30, 165);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new Size(140, 20);
            this.lblConfirmPassword.Text = "Подтвердите пароль:";

            this.txtConfirmPassword.Location = new Point(30, 185);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new Size(240, 23);

            this.lblRole.Location = new Point(30, 220);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new Size(100, 20);
            this.lblRole.Text = "Роль:";

            this.cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRole.Items.AddRange(new object[] { "Admin", "Client" });
            this.cmbRole.Location = new Point(30, 240);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new Size(240, 23);
            this.cmbRole.SelectedIndex = 1;

            this.btnCreate.Location = new Point(30, 290);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new Size(115, 30);
            this.btnCreate.Text = "Создать";
            this.btnCreate.Click += new EventHandler(this.btnRegister_Click);

            this.btnCancel.Location = new Point(155, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(115, 30);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            this.ClientSize = new Size(300, 350);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminRegisterForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Новый пользователь";
            this.ResumeLayout(false);
        }
    }
}