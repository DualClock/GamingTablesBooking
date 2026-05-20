using GamingTablesBookingProject.Data;
using GamingTablesBookingProject.Models;

namespace GamingTablesBookingProject.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var user = db.Users.FirstOrDefault(u => u.Login == txtLogin.Text);
            if (user != null && txtPassword.Text == user.PasswordHash)
            {
                this.Hide();
                Form? userForm = null;
                if (user.Role == "Admin")
                {
                    userForm = new AdminForm(user);
                }
                else
                {
                    userForm = new ClientForm(user);
                }
                userForm.ShowDialog();
                txtPassword.Clear();
                this.Show();
                this.Activate();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}