using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GamingTablesBookingProject.Forms
{
    partial class ClientForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel headerPanel;
        private Label lblUser;
        private Button btnRefresh;
        private Button btnLogout;
        private TabControl tabControl;
        private TabPage tabTables;
        private TabPage tabMyBookings;
        private DataGridView dgvTables;
        private DataGridView dgvMyBookings;
        private Panel bookingPanel;
        private Label lblSelectedTable;
        private Label lblDateLabel;
        private DateTimePicker dtpDate;
        private Label lblTimeStartLabel;
        private ComboBox cmbTimeStart;
        private Label lblTimeEndLabel;
        private ComboBox cmbTimeEnd;
        private Button btnBook;
        private Button btnCancelBooking;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerPanel = new Panel();
            this.lblUser = new Label();
            this.btnRefresh = new Button();
            this.btnLogout = new Button();
            this.tabControl = new TabControl();
            this.tabTables = new TabPage();
            this.tabMyBookings = new TabPage();
            this.dgvTables = new DataGridView();
            this.dgvMyBookings = new DataGridView();
            this.bookingPanel = new Panel();
            this.lblSelectedTable = new Label();
            this.lblDateLabel = new Label();
            this.dtpDate = new DateTimePicker();
            this.lblTimeStartLabel = new Label();
            this.cmbTimeStart = new ComboBox();
            this.lblTimeEndLabel = new Label();
            this.cmbTimeEnd = new ComboBox();
            this.btnBook = new Button();
            this.btnCancelBooking = new Button();

            this.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabTables.SuspendLayout();
            this.tabMyBookings.SuspendLayout();
            this.bookingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvTables).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dgvMyBookings).BeginInit();

            this.BackColor = Color.FromArgb(235, 239, 244);
            this.ClientSize = new Size(900, 620);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Бронирование столов";
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

            this.headerPanel.Dock = DockStyle.Top;
            this.headerPanel.Height = 74;
            this.headerPanel.Paint += new PaintEventHandler(this.HeaderPanel_Paint);

            this.lblUser.AutoSize = false;
            this.lblUser.Location = new Point(20, 43);
            this.lblUser.Size = new Size(420, 20);
            this.lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.lblUser.ForeColor = Color.FromArgb(225, 235, 245);
            this.lblUser.BackColor = Color.Transparent;
            this.lblUser.Text = "Вы: ";

            this.btnRefresh.Size = new Size(96, 30);
            this.btnRefresh.Location = new Point(690, 22);
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.BackColor = Color.White;
            this.btnRefresh.ForeColor = Color.FromArgb(45, 65, 95);
            this.btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new EventHandler(this.btnFilter_Click);

            this.btnLogout.Size = new Size(96, 30);
            this.btnLogout.Location = new Point(796, 22);
            this.btnLogout.Text = "Выход";
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.BackColor = Color.FromArgb(220, 85, 85);
            this.btnLogout.ForeColor = Color.White;
            this.btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            this.headerPanel.Controls.Add(this.lblUser);
            this.headerPanel.Controls.Add(this.btnRefresh);
            this.headerPanel.Controls.Add(this.btnLogout);

            this.tabControl.Location = new Point(16, 88);
            this.tabControl.Size = new Size(868, 516);
            this.tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.tabControl.Appearance = TabAppearance.Normal;
            this.tabControl.Padding = new Point(12, 6);

            this.tabTables.Text = "Свободные столы";
            this.tabTables.BackColor = Color.FromArgb(240, 243, 247);

            this.tabMyBookings.Text = "Мои бронирования";
            this.tabMyBookings.BackColor = Color.FromArgb(240, 243, 247);

            SetupDataGridView(this.dgvTables);
            this.dgvTables.Location = new Point(12, 14);
            this.dgvTables.Size = new Size(828, 200);

            this.bookingPanel.BackColor = Color.White;
            this.bookingPanel.Location = new Point(12, 228);
            this.bookingPanel.Size = new Size(828, 210);
            this.bookingPanel.BorderStyle = BorderStyle.FixedSingle;
            this.bookingPanel.Paint += new PaintEventHandler(this.BookingPanel_Paint);

            this.lblSelectedTable.Location = new Point(20, 18);
            this.lblSelectedTable.Size = new Size(350, 22);
            this.lblSelectedTable.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblSelectedTable.ForeColor = Color.FromArgb(45, 65, 95);
            this.lblSelectedTable.Text = "Выберите стол из списка";

            this.lblDateLabel.Location = new Point(20, 58);
            this.lblDateLabel.Size = new Size(60, 18);
            this.lblDateLabel.Text = "Дата:";
            this.lblDateLabel.ForeColor = Color.FromArgb(70, 70, 70);
            this.lblDateLabel.BackColor = Color.White;

            this.dtpDate.Location = new Point(86, 54);
            this.dtpDate.Size = new Size(138, 23);
            this.dtpDate.Format = DateTimePickerFormat.Short;

            this.lblTimeStartLabel.Location = new Point(20, 96);
            this.lblTimeStartLabel.Size = new Size(60, 18);
            this.lblTimeStartLabel.Text = "Начало:";
            this.lblTimeStartLabel.ForeColor = Color.FromArgb(70, 70, 70);
            this.lblTimeStartLabel.BackColor = Color.White;

            this.cmbTimeStart.Location = new Point(86, 92);
            this.cmbTimeStart.Size = new Size(110, 23);
            this.cmbTimeStart.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbTimeStart.Font = new Font("Segoe UI", 9F);
            this.cmbTimeStart.Items.AddRange(new object[]
            {
                "10:00","11:00","12:00","13:00","14:00","15:00",
                "16:00","17:00","18:00","19:00","20:00","21:00"
            });
            this.cmbTimeStart.SelectedIndex = 0;

            this.lblTimeEndLabel.Location = new Point(220, 96);
            this.lblTimeEndLabel.Size = new Size(60, 18);
            this.lblTimeEndLabel.Text = "Конец:";
            this.lblTimeEndLabel.ForeColor = Color.FromArgb(70, 70, 70);
            this.lblTimeEndLabel.BackColor = Color.White;

            this.cmbTimeEnd.Location = new Point(285, 92);
            this.cmbTimeEnd.Size = new Size(110, 23);
            this.cmbTimeEnd.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbTimeEnd.Font = new Font("Segoe UI", 9F);
            this.cmbTimeEnd.Items.AddRange(new object[]
            {
                "11:00","12:00","13:00","14:00","15:00","16:00",
                "17:00","18:00","19:00","20:00","21:00","22:00"
            });
            this.cmbTimeEnd.SelectedIndex = 0;

            this.btnBook.Location = new Point(586, 148);
            this.btnBook.Size = new Size(220, 38);
            this.btnBook.Text = "Забронировать";
            this.btnBook.FlatStyle = FlatStyle.Flat;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.BackColor = Color.FromArgb(70, 130, 180);
            this.btnBook.ForeColor = Color.White;
            this.btnBook.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new EventHandler(this.btnBook_Click);

            this.bookingPanel.Controls.Add(this.lblSelectedTable);
            this.bookingPanel.Controls.Add(this.lblDateLabel);
            this.bookingPanel.Controls.Add(this.dtpDate);
            this.bookingPanel.Controls.Add(this.lblTimeStartLabel);
            this.bookingPanel.Controls.Add(this.cmbTimeStart);
            this.bookingPanel.Controls.Add(this.lblTimeEndLabel);
            this.bookingPanel.Controls.Add(this.cmbTimeEnd);
            this.bookingPanel.Controls.Add(this.btnBook);

            this.tabTables.Controls.Add(this.dgvTables);
            this.tabTables.Controls.Add(this.bookingPanel);

            SetupDataGridView(this.dgvMyBookings);
            this.dgvMyBookings.Location = new Point(12, 14);
            this.dgvMyBookings.Size = new Size(828, 390);

            this.btnCancelBooking.Location = new Point(312, 420);
            this.btnCancelBooking.Size = new Size(240, 36);
            this.btnCancelBooking.Text = "Отменить бронирование";
            this.btnCancelBooking.FlatStyle = FlatStyle.Flat;
            this.btnCancelBooking.FlatAppearance.BorderSize = 0;
            this.btnCancelBooking.BackColor = Color.FromArgb(255, 152, 0);
            this.btnCancelBooking.ForeColor = Color.White;
            this.btnCancelBooking.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            this.btnCancelBooking.Click += new EventHandler(this.btnCancelBooking_Click);

            this.tabMyBookings.Controls.Add(this.dgvMyBookings);
            this.tabMyBookings.Controls.Add(this.btnCancelBooking);

            this.tabControl.Controls.Add(this.tabTables);
            this.tabControl.Controls.Add(this.tabMyBookings);

            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.headerPanel);

            this.headerPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabTables.ResumeLayout(false);
            this.tabMyBookings.ResumeLayout(false);
            this.bookingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dgvTables).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dgvMyBookings).EndInit();
            this.ResumeLayout(false);
        }

        private void SetupDataGridView(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.FromArgb(230, 233, 238);
            dgv.ColumnHeadersHeight = 34;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 65, 95);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.RowsDefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 225, 240);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 30, 30);
            dgv.RowTemplate.Height = 28;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.headerPanel.ClientRectangle,
                Color.FromArgb(45, 65, 95),
                Color.FromArgb(70, 130, 180),
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, this.headerPanel.ClientRectangle);
            }

            TextRenderer.DrawText(
                e.Graphics,
                "Бронирование столов",
                new Font("Segoe UI", 14F, FontStyle.Bold),
                new Point(20, 18),
                Color.White,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }

        private void BookingPanel_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(220, 225, 230), 1))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawRectangle(pen, 0, 0, this.bookingPanel.Width - 1, this.bookingPanel.Height - 1);
            }
        }
    }
}