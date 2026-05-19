using GamingTablesBookingProject.Data;
using GamingTablesBookingProject.Models;

namespace GamingTablesBookingProject.Forms
{
    public partial class TableEditForm : Form
    {
        private readonly int? _existingTableId;

        public TableEditForm()
        {
            _existingTableId = null;
            InitializeComponent();
            lblTitle.Text = "Новый стол";
        }

        public TableEditForm(GameTable table)
        {
            _existingTableId = table.Id;
            InitializeComponent();
            txtName.Text = table.Name;
            // Status хранится в lowercase (available/maintenance), convert for display
            cmbStatus.SelectedItem = table.Status.ToLower();
            lblTitle.Text = "Редактирование стола";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите название стола!", "Ошибка");
                return;
            }

            using var db = new AppDbContext();

            if (_existingTableId.HasValue)
            {
                var table = db.Tables.Find(_existingTableId.Value);
                if (table != null)
                {
                    table.Name = txtName.Text;
                    table.Status = cmbStatus.SelectedItem?.ToString() ?? "available";
                    db.SaveChanges();
                }
            }
            else
            {
                var table = new GameTable
                {
                    Name = txtName.Text,
                    Capacity = 4, // Значение по умолчанию
                    Status = cmbStatus.SelectedItem?.ToString() ?? "available"
                };
                db.Tables.Add(table);
                db.SaveChanges();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}