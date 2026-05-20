using GamingTablesBookingProject.Data;
using GamingTablesBookingProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Drawing;

namespace GamingTablesBookingProject.Forms
{
    public partial class ClientForm : Form
    {
        private readonly User _currentUser;
        private DateTime _selectedDate;
        private TimeSpan _selectedTimeStart;
        private TimeSpan _selectedTimeEnd;

        public ClientForm(User user)
        {
            _currentUser = user;
            _selectedDate = DateTime.Today;
            _selectedTimeStart = new TimeSpan(10, 0, 0);
            _selectedTimeEnd = new TimeSpan(12, 0, 0);
            InitializeComponent();
            LoadTables();
            LoadMyBookings();
            dtpDate.MinDate = DateTime.Today;
            lblUser.Text = $"Вы вошли как: {user.Login}";
        }

        private void LoadTables()
        {
            using var db = new AppDbContext();
            var bookingsOnDate = db.Bookings
                .Where(b => b.Date.Date == _selectedDate && b.Status == "Active")
                .Select(b => b.TableId)
                .ToList();

            var availableTables = db.Tables.Where(t => t.Status.ToLower() == "available" && !bookingsOnDate.Contains(t.Id)).ToList();

            dgvTables.DataSource = availableTables.Select(t => new
            {
                t.Id,
                t.Name,
                t.Capacity,
                Статус = t.Status.ToLower() == "available" ? "Доступен" : "Занят"
            }).ToList();
        }

        private void LoadMyBookings()
        {
            using var db = new AppDbContext();
            var bookings = db.Bookings
                .Include(b => b.GameTable)
                .Where(b => b.UserId == _currentUser.Id && b.Status != "Cancelled")
                .OrderByDescending(b => b.Date)
                .Select(b => new
                {
                    b.Id,
                    Стол = b.GameTable!.Name,
                    b.Date,
                    Начало = b.TimeStart.ToString(@"hh\:mm"),
                    Окончание = b.TimeEnd.ToString(@"hh\:mm"),
                    Статус = b.Status == "Active" ? "Активно" : b.Status == "Cancelled" ? "Отменено" : "Завершено"
                }).ToList();

            dgvMyBookings.DataSource = bookings;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            _selectedDate = dtpDate.Value.Date;
            LoadTables();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите стол!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tableId = Convert.ToInt32(dgvTables.SelectedRows[0].Cells["Id"].Value);

            var startStr = cmbTimeStart.SelectedItem?.ToString() ?? "10:00";
            var startHours = int.Parse(startStr.Split(':')[0]);
            _selectedTimeStart = new TimeSpan(startHours, 0, 0);

            var endStr = cmbTimeEnd.SelectedItem?.ToString() ?? "11:00";
            var endHours = int.Parse(endStr.Split(':')[0]);
            _selectedTimeEnd = new TimeSpan(endHours, 0, 0);

            if (_selectedTimeEnd <= _selectedTimeStart)
            {
                MessageBox.Show("Время о��ончания должно быть позже времени начала!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var db = new AppDbContext();
            var hasConflict = db.Bookings.Any(b =>
                b.TableId == tableId &&
                b.Date.Date == _selectedDate &&
                b.Status == "Active" &&
                ((_selectedTimeStart >= b.TimeStart && _selectedTimeStart < b.TimeEnd) ||
                 (_selectedTimeEnd > b.TimeStart && _selectedTimeEnd <= b.TimeEnd)));

            if (hasConflict)
            {
                MessageBox.Show("Стол уже забронирован на это время!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var connString = @"Data Source=(localdb)\MSSQLLocalDB;Database=GamingTablesBooking;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True";
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("", conn))
                {
                    cmd.CommandText = "DISABLE TRIGGER ALL ON dbo.Bookings";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"INSERT INTO dbo.Bookings (user_id, table_id, date, time_start, time_end, status, created_at)
                      VALUES (@uid, @tid, @date, @start, @end, @status, @created)";
                    cmd.Parameters.AddWithValue("@uid", _currentUser.Id);
                    cmd.Parameters.AddWithValue("@tid", tableId);
                    cmd.Parameters.AddWithValue("@date", _selectedDate);
                    cmd.Parameters.AddWithValue("@start", _selectedTimeStart);
                    cmd.Parameters.AddWithValue("@end", _selectedTimeEnd);
                    cmd.Parameters.AddWithValue("@status", "Active");
                    cmd.Parameters.AddWithValue("@created", DateTime.Now);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.CommandText = "ENABLE TRIGGER ALL ON dbo.Bookings";
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Бронирование успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTables();
            LoadMyBookings();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvMyBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите бронирование!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var bookingId = Convert.ToInt32(dgvMyBookings.SelectedRows[0].Cells["Id"].Value);

            var connString = @"Data Source=(localdb)\MSSQLLocalDB;Database=GamingTablesBooking;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True";
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(
                    @"UPDATE dbo.Bookings SET status = @status WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@status", "Cancelled");
                    cmd.Parameters.AddWithValue("@id", bookingId);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Бронирование отменено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTables();
            LoadMyBookings();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMyBookings();
            LoadTables();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}