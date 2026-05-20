using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GamingTablesBookingProject.Forms
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl;
        private TabPage tabPCPlaces;
        private TabPage tabBookings;
        private TabPage tabUsers;
        private DataGridView dgvPCPlaces;
        private DataGridView dgvBookings;
        private DataGridView dgvUsers;
        private Button btnAddPCPlace;
        private Button btnEditPCPlace;
        private Button btnDeletePCPlace;
        private Button btnCancelBooking;
        private Button btnDeleteUser;
        private Button btnAddUser;
        private Button btnRefresh;
        private Button btnLogout;
        private Panel headerPanel;
        private Label lblUser;

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
            this.tabPCPlaces = new TabPage();
            this.tabBookings = new TabPage();
            this.tabUsers = new TabPage();
            this.dgvPCPlaces = new DataGridView();
            this.dgvBookings = new DataGridView();
            this.dgvUsers = new DataGridView();
            this.btnAddPCPlace = new Button();
            this.btnEditPCPlace = new Button();
            this.btnDeletePCPlace = new Button();
            this.btnCancelBooking = new Button();
            this.btnDeleteUser = new Button();
            this.btnAddUser = new Button();

            this.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPCPlaces.SuspendLayout();
            this.tabBookings.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvPCPlaces).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dgvBookings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dgvUsers).BeginInit();

            this.BackColor = Color.FromArgb(235, 239, 244);
            this.ClientSize = new Size(850, 510);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

            this.headerPanel.Location = new Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new Size(850, 50);
            this.headerPanel.Paint += new PaintEventHandler(this.HeaderPanel_Paint);

            this.lblUser.Font = new Font("Segoe UI", 9F);
            this.lblUser.ForeColor = Color.FromArgb(225, 235, 245);
            this.lblUser.Location = new Point(20, 26);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new Size(260, 18);
            this.lblUser.Text = "Вы: ";
            this.lblUser.BackColor = Color.Transparent;

            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.BackColor = Color.White;
            this.btnRefresh.ForeColor = Color.FromArgb(45, 65, 95);
            this.btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnRefresh.Location = new Point(640, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(90, 30);
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);

            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.BackColor = Color.FromArgb(220, 80, 80);
            this.btnLogout.ForeColor = Color.White;
            this.btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnLogout.Location = new Point(745, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new Size(90, 30);
            this.btnLogout.Text = "Выход";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            this.headerPanel.Controls.Add(this.lblUser);
            this.headerPanel.Controls.Add(this.btnRefresh);
            this.headerPanel.Controls.Add(this.btnLogout);

            this.tabControl.Location = new Point(10, 58);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new Size(830, 445);
            this.tabControl.Controls.Add(this.tabPCPlaces);
            this.tabControl.Controls.Add(this.tabBookings);
            this.tabControl.Controls.Add(this.tabUsers);
            this.tabControl.Padding = new Point(12, 6);

            StyleTabPage(this.tabPCPlaces, "ПК-места");
            SetupDataGridView(this.dgvPCPlaces, new Point(8, 8), new Size(808, 280));
            StyleButton(this.btnAddPCPlace, "Добавить", new Point(8, 300), Color.FromArgb(76, 175, 80));
            StyleButton(this.btnEditPCPlace, "Изменить", new Point(148, 300), Color.FromArgb(70, 130, 180));
            StyleButton(this.btnDeletePCPlace, "Удалить", new Point(288, 300), Color.FromArgb(220, 80, 80));
            this.btnAddPCPlace.Click += new EventHandler(this.btnAddPCPlace_Click);
            this.btnEditPCPlace.Click += new EventHandler(this.btnEditPCPlace_Click);
            this.btnDeletePCPlace.Click += new EventHandler(this.btnDeletePCPlace_Click);
            this.tabPCPlaces.Controls.Add(this.dgvPCPlaces);
            this.tabPCPlaces.Controls.Add(this.btnAddPCPlace);
            this.tabPCPlaces.Controls.Add(this.btnEditPCPlace);
            this.tabPCPlaces.Controls.Add(this.btnDeletePCPlace);

            StyleTabPage(this.tabBookings, "Бронирования");
            SetupDataGridView(this.dgvBookings, new Point(8, 8), new Size(808, 280));
            StyleButton(this.btnCancelBooking, "Отменить", new Point(8, 300), Color.FromArgb(255, 152, 0));
            this.btnCancelBooking.Click += new EventHandler(this.btnCancelBooking_Click);
            this.tabBookings.Controls.Add(this.dgvBookings);
            this.tabBookings.Controls.Add(this.btnCancelBooking);

            StyleTabPage(this.tabUsers, "Пользователи");
            SetupDataGridView(this.dgvUsers, new Point(8, 8), new Size(808, 280));
            StyleButton(this.btnAddUser, "Добавить", new Point(8, 300), Color.FromArgb(76, 175, 80));
            StyleButton(this.btnDeleteUser, "Удалить", new Point(148, 300), Color.FromArgb(220, 80, 80));
            this.btnAddUser.Click += new EventHandler(this.btnAddUser_Click);
            this.btnDeleteUser.Click += new EventHandler(this.btnDeleteUser_Click);
            this.tabUsers.Controls.Add(this.dgvUsers);
            this.tabUsers.Controls.Add(this.btnAddUser);
            this.tabUsers.Controls.Add(this.btnDeleteUser);

            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.tabControl);

            this.headerPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPCPlaces.ResumeLayout(false);
            this.tabBookings.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dgvPCPlaces).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dgvBookings).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dgvUsers).EndInit();
            this.ResumeLayout(false);
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (LinearGradientBrush gradient = new LinearGradientBrush(
                this.headerPanel.ClientRectangle,
                Color.FromArgb(45, 65, 95),
                Color.FromArgb(70, 130, 180),
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(gradient, this.headerPanel.ClientRectangle);
            }

            TextRenderer.DrawText(
                e.Graphics,
                "Панель администратора",
                new Font("Segoe UI", 13F, FontStyle.Bold),
                new Point(20, 12),
                Color.White);
        }

        private void StyleTabPage(TabPage tab, string text)
        {
            tab.Text = text;
            tab.BackColor = Color.FromArgb(240, 240, 245);
        }

        private void SetupDataGridView(DataGridView dgv, Point loc, Size sz)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.BackgroundColor = Color.White;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.GridColor = Color.FromArgb(230, 230, 235);
            dgv.Location = loc;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 28;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = sz;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 65, 95);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 250);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 225, 240);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 30, 30);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void StyleButton(Button btn, string text, Point loc, Color color)
        {
            btn.BackColor = color;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.ForeColor = Color.White;
            btn.Location = loc;
            btn.Size = new Size(130, 32);
            btn.Text = text;
            btn.UseVisualStyleBackColor = false;
        }
    }
}