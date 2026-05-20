using GamingTablesBookingProject.Data;
using GamingTablesBookingProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data;

namespace GamingTablesBookingProject.Forms
{
    public partial class AdminForm : Form
    {
        private readonly User _currentUser;

        public AdminForm(User user)
        {
            _currentUser = user;
            InitializeComponent();
            LoadPCPlaces();
            LoadBookings();
            LoadUsers();
        }

        private void LoadPCPlaces()
        {
            using var db = new AppDbContext();
            var places = db.Tables.Select(t => new
            {
                t.Id,
                t.Name,
                t.Capacity,
                Status = GetStatusDisplay(t.Status)
            }).ToList();
            dgvPCPlaces.DataSource = places;
        }

        private static string GetStatusDisplay(string status)
        {
            return status switch
            {
                "available" => "Доступен",
                "maintenance" => "На обслуживании",
                "reserved" => "Забронирован",
                _ => status
            };
        }

        private void LoadBookings()
        {
            using var db = new AppDbContext();
            var bookings = db.Bookings
                .Include(b => b.User)
                .Include(b => b.GameTable)
                .Select(b => new
                {
                    b.Id,
                    Client = b.User!.Login,
                    Table = b.GameTable!.Name,
                    b.Date,
                    Start = b.TimeStart.ToString(@"hh\:mm"),
                    End = b.TimeEnd.ToString(@"hh\:mm"),
                    Status = GetBookingStatusDisplay(b.Status)
                }).ToList();
            dgvBookings.DataSource = bookings;
        }

        private static string GetBookingStatusDisplay(string status)
        {
            return status switch
            {
                "Active" => "Активно",
                "Cancelled" => "Отменено",
                "Completed" => "Завершено",
                _ => status
            };
        }

        private void LoadUsers()
        {
            using var db = new AppDbContext();
            var users = db.Users.Select(u => new
            {
                u.Id,
                u.Login,
                Role = u.Role == "Admin" ? "Администратор" : "Клиент",
                Created = u.CreatedAt
            }).ToList();
            dgvUsers.DataSource = users;
        }

        private void btnAddPCPlace_Click(object sender, EventArgs e)
        {
            var form = new TableEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadPCPlaces();
            }
        }

        private void btnEditPCPlace_Click(object sender, EventArgs e)
        {
            if (dgvPCPlaces.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите ПК-место для редактирования.");
                return;
            }
            var id = Convert.ToInt32(dgvPCPlaces.SelectedRows[0].Cells["Id"].Value);
            using var db = new AppDbContext();
            var table = db.Tables.Find(id);
            if (table != null)
            {
                var form = new TableEditForm(table);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadPCPlaces();
                }
            }
        }

        private void btnDeletePCPlace_Click(object sender, EventArgs e)
        {
            if (dgvPCPlaces.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите ПК-место для удаления.");
                return;
            }
            var id = Convert.ToInt32(dgvPCPlaces.SelectedRows[0].Cells["Id"].Value);
            if (MessageBox.Show("Удалить это ПК-место?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using var db = new AppDbContext();
                var table = db.Tables.Find(id);
                if (table != null)
                {
                    db.Tables.Remove(table);
                    db.SaveChanges();
                    LoadPCPlaces();
                }
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите бронирование для отмены.");
                return;
            }
            var id = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["Id"].Value);
            if (MessageBox.Show("Отменить это бронирование?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var connString = @"Data Source=(localdb)\MSSQLLocalDB;Database=GamingTablesBooking;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True";
                using (var conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("", conn))
                    {
                        cmd.CommandText = "DISABLE TRIGGER ALL ON dbo.Bookings";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = @"UPDATE dbo.Bookings SET status = @status WHERE id = @id";
                        cmd.Parameters.AddWithValue("@status", "Cancelled");
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        cmd.Parameters.Clear();
                        cmd.CommandText = "ENABLE TRIGGER ALL ON dbo.Bookings";
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadBookings();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var form = new AdminRegisterForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пользователя для удаления.");
                return;
            }
            var id = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["Id"].Value);
            if (id == _currentUser.Id)
            {
                MessageBox.Show("Нельзя удалить свою учётную запись.");
                return;
            }
            if (MessageBox.Show("Удалить этого пользователя?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using var db = new AppDbContext();
                var user = db.Users.Find(id);
                if (user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                    LoadUsers();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPCPlaces();
            LoadBookings();
            LoadUsers();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти из системы?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}