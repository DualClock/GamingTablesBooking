using System.Drawing;
using System.Windows.Forms;

namespace GamingTablesBookingProject.Forms
{
    partial class TableEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtName;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Button btnCancel;
        private Label lblTitle;
        private Label lblName;
        private Label lblStatus;
        private TableLayoutPanel mainLayout;
        private Panel headerPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            lblTitle = new Label();
            mainLayout = new TableLayoutPanel();
            lblName = new Label();
            txtName = new TextBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            buttonPanel = new TableLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            headerPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(45, 65, 95);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(320, 45);
            headerPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(320, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Настройки стола";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(lblName, 0, 0);
            mainLayout.Controls.Add(txtName, 1, 0);
            mainLayout.Controls.Add(lblStatus, 0, 1);
            mainLayout.Controls.Add(cmbStatus, 1, 1);
            mainLayout.Controls.Add(buttonPanel, 0, 3);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 45);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(15, 15, 15, 5);
            mainLayout.RowCount = 4;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(320, 155);
            mainLayout.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblName.Font = new Font("Segoe UI", 9F);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(18, 16);
            lblName.Name = "lblName";
            lblName.Size = new Size(74, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Название:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(98, 18);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 25);
            txtName.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(18, 42);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(74, 23);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Статус:";
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9F);
            cmbStatus.Items.AddRange(new object[] { "available", "maintenance" });
            cmbStatus.Location = new Point(98, 43);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(204, 23);
            cmbStatus.TabIndex = 3;
            // 
            // buttonPanel
            // 
            buttonPanel.ColumnCount = 2;
            mainLayout.SetColumnSpan(buttonPanel, 2);
            buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonPanel.Controls.Add(btnSave, 0, 0);
            buttonPanel.Controls.Add(btnCancel, 1, 0);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(18, 101);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buttonPanel.Size = new Size(284, 46);
            buttonPanel.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(70, 130, 180);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(39, 9);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 28);
            btnSave.TabIndex = 0;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Left;
            btnCancel.BackColor = Color.FromArgb(240, 240, 240);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(70, 130, 180);
            btnCancel.Location = new Point(145, 9);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 28);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // TableEditForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(320, 200);
            Controls.Add(mainLayout);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TableEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редактор стола";
            headerPanel.ResumeLayout(false);
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel buttonPanel;
    }
}