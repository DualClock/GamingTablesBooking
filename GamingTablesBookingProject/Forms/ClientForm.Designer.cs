namespace GamingTablesBookingProject.Forms
{
    partial class ClientForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvTables;
        private DataGridView dgvMyBookings;
        private DateTimePicker dtpDate;
        private ComboBox cmbTimeStart;
        private ComboBox cmbTimeEnd;
        private Button btnBook;
        private Button btnCancelBooking;
        private Button btnRefresh;
        private Button btnLogout;
        private Label lblTitle;
        private Label lblUser;
        private TabControl tabControl;
        private TabPage tabTables;
        private TabPage tabMyBookings;
        private Label lblSelectedTable;
        private Label lblDateLabel;
        private Label lblTimeStartLabel;
        private Label lblTimeEndLabel;
        private Panel panelBooking;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblUser = new Label();
            this.btnRefresh = new Button();
            this.btnLogout = new Button();
            this.tabControl = new TabControl();
            this.tabTables = new TabPage();
            this.tabMyBookings = new TabPage();
            this.dgvTables = new DataGridView();
            this.dgvMyBookings = new DataGridView();
            this.lblSelectedTable = new Label();
            this.lblDateLabel = new Label();
            this.lblTimeStartLabel = new Label();
            this.lblTimeEndLabel = new Label();
            this.dtpDate = new DateTimePicker();
            this.cmbTimeStart = new ComboBox();
            this.cmbTimeEnd = new ComboBox();
            this.btnBook = new Button();
            this.btnCancelBooking = new Button();
            this.panelBooking = new Panel();
            this.tabControl.SuspendLayout();
            this.tabTables.SuspendLayout();
            this.tabMyBookings.SuspendLayout();
            this.panelBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvTables).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dgvMyBookings).BeginInit();
            this.SuspendLayout();

            this.lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitle.Location = new Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(150, 20);
            this.lblTitle.Text = "Бронирование";

            this.lblUser.Location = new Point(10, 35);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new Size(200, 20);
            this.lblUser.Text = "Вы: ";

            this.btnRefresh.Location = new Point(650, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(80, 25);
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.Click += new EventHandler(this.btnFilter_Click);

            this.btnLogout.Location = new Point(740, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new Size(80, 25);
            this.btnLogout.Text = "Выход";
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            this.tabControl.Location = new Point(10, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new Size(810, 430);
            this.tabControl.Controls.Add(this.tabTables);
            this.tabControl.Controls.Add(this.tabMyBookings);

            this.tabTables.Controls.Add(this.dgvTables);
            this.tabTables.Controls.Add(this.panelBooking);
            this.tabTables.Location = new Point(4, 24);
            this.tabTables.Name = "tabTables";
            this.tabTables.Size = new Size(802, 402);
            this.tabTables.Text = "Свободные столы";
            this.tabTables.UseVisualStyleBackColor = true;

            this.dgvTables.AllowUserToAddRows = false;
            this.dgvTables.AllowUserToDeleteRows = false;
            this.dgvTables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Location = new Point(10, 10);
            this.dgvTables.MultiSelect = false;
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.ReadOnly = true;
            this.dgvTables.RowTemplate.Height = 25;
            this.dgvTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvTables.Size = new Size(780, 150);
            this.dgvTables.GridColor = System.Drawing.SystemColors.ControlDark;
            this.dgvTables.BorderStyle = BorderStyle.FixedSingle;

            this.panelBooking.BorderStyle = BorderStyle.FixedSingle;
            this.panelBooking.Controls.Add(this.lblSelectedTable);
            this.panelBooking.Controls.Add(this.lblDateLabel);
            this.panelBooking.Controls.Add(this.dtpDate);
            this.panelBooking.Controls.Add(this.lblTimeStartLabel);
            this.panelBooking.Controls.Add(this.cmbTimeStart);
            this.panelBooking.Controls.Add(this.lblTimeEndLabel);
            this.panelBooking.Controls.Add(this.cmbTimeEnd);
            this.panelBooking.Controls.Add(this.btnBook);
            this.panelBooking.Location = new Point(10, 170);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new Size(780, 220);

            this.lblSelectedTable.Location = new Point(10, 10);
            this.lblSelectedTable.Name = "lblSelectedTable";
            this.lblSelectedTable.Size = new Size(300, 20);
            this.lblSelectedTable.Text = "Выберите стол из списка";

            this.lblDateLabel.Location = new Point(10, 45);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new Size(50, 20);
            this.lblDateLabel.Text = "Дата:";

            this.dtpDate.Format = DateTimePickerFormat.Short;
            this.dtpDate.Location = new Point(60, 42);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new Size(120, 23);

            this.lblTimeStartLabel.Location = new Point(10, 80);
            this.lblTimeStartLabel.Name = "lblTimeStartLabel";
            this.lblTimeStartLabel.Size = new Size(60, 20);
            this.lblTimeStartLabel.Text = "Начало:";

            this.cmbTimeStart.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbTimeStart.Items.AddRange(new object[] { "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00" });
            this.cmbTimeStart.Location = new Point(70, 77);
            this.cmbTimeStart.Name = "cmbTimeStart";
            this.cmbTimeStart.Size = new Size(100, 23);
            this.cmbTimeStart.SelectedIndex = 0;

            this.lblTimeEndLabel.Location = new Point(190, 80);
            this.lblTimeEndLabel.Name = "lblTimeEndLabel";
            this.lblTimeEndLabel.Size = new Size(60, 20);
            this.lblTimeEndLabel.Text = "Конец:";

            this.cmbTimeEnd.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbTimeEnd.Items.AddRange(new object[] { "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00" });
            this.cmbTimeEnd.Location = new Point(250, 77);
            this.cmbTimeEnd.Name = "cmbTimeEnd";
            this.cmbTimeEnd.Size = new Size(100, 23);
            this.cmbTimeEnd.SelectedIndex = 0;

            this.btnBook.Location = new Point(600, 160);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new Size(160, 40);
            this.btnBook.Text = "Забронировать";
            this.btnBook.Click += new EventHandler(this.btnBook_Click);

            this.tabMyBookings.Controls.Add(this.dgvMyBookings);
            this.tabMyBookings.Controls.Add(this.btnCancelBooking);
            this.tabMyBookings.Location = new Point(4, 24);
            this.tabMyBookings.Name = "tabMyBookings";
            this.tabMyBookings.Size = new Size(802, 402);
            this.tabMyBookings.Text = "Мои бронирования";
            this.tabMyBookings.UseVisualStyleBackColor = true;

            this.dgvMyBookings.AllowUserToAddRows = false;
            this.dgvMyBookings.AllowUserToDeleteRows = false;
            this.dgvMyBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyBookings.Location = new Point(10, 10);
            this.dgvMyBookings.MultiSelect = false;
            this.dgvMyBookings.Name = "dgvMyBookings";
            this.dgvMyBookings.ReadOnly = true;
            this.dgvMyBookings.RowTemplate.Height = 25;
            this.dgvMyBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyBookings.Size = new Size(780, 300);
            this.dgvMyBookings.GridColor = System.Drawing.SystemColors.ControlDark;
            this.dgvMyBookings.BorderStyle = BorderStyle.FixedSingle;

            this.btnCancelBooking.Location = new Point(300, 320);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new Size(200, 30);
            this.btnCancelBooking.Text = "Отменить бронирование";
            this.btnCancelBooking.Click += new EventHandler(this.btnCancelBooking_Click);

            this.ClientSize = new Size(830, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Бронирование столов";
            this.tabControl.ResumeLayout(false);
            this.tabTables.ResumeLayout(false);
            this.panelBooking.ResumeLayout(false);
            this.tabMyBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dgvTables).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dgvMyBookings).EndInit();
            this.ResumeLayout(false);
        }
    }
}