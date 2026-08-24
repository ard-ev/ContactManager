namespace ContactManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblPrg = new Label();
            lblTitel = new Label();
            btnEmployee = new Button();
            btnCustomer = new Button();
            btnDashboard = new Button();
            pnlContent = new Panel();
            pnlDashboard = new Panel();
            dgvRecentMutations = new DataGridView();
            lblRecentMutations = new Label();
            dgvRecentContacts = new DataGridView();
            lblRecentContacts = new Label();
            pnlInactiveStats = new Panel();
            lblCustomerCount = new Label();
            lblCustomerStatsTitle = new Label();
            pnlEmployeeStats = new Panel();
            lblEmployeeCount = new Label();
            lblEmployeeStatsTitle = new Label();
            pnlCustomerStats = new Panel();
            lblInactiveCount = new Label();
            lblInactiveStatsTitle = new Label();
            lblDashboardSubtitle = new Label();
            lblDashboardTitle = new Label();
            pnlCustomer = new Panel();
            pnlEmployee = new Panel();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentMutations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentContacts).BeginInit();
            pnlInactiveStats.SuspendLayout();
            pnlEmployeeStats.SuspendLayout();
            pnlCustomerStats.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblPrg);
            pnlHeader.Controls.Add(lblTitel);
            pnlHeader.Controls.Add(btnEmployee);
            pnlHeader.Controls.Add(btnCustomer);
            pnlHeader.Controls.Add(btnDashboard);
            pnlHeader.Location = new Point(0, 12);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1095, 64);
            pnlHeader.TabIndex = 0;
            // 
            // lblPrg
            // 
            lblPrg.AutoSize = true;
            lblPrg.Location = new Point(964, 27);
            lblPrg.Name = "lblPrg";
            lblPrg.Size = new Size(63, 15);
            lblPrg.TabIndex = 3;
            lblPrg.Text = "Version 1.0";
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitel.Location = new Point(12, 15);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(297, 39);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Contact Manager";
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(757, 23);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(173, 23);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "Mitarbeiter";
            btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(550, 23);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(173, 23);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Kunden";
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(343, 23);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(173, 23);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Übersicht";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(pnlDashboard);
            pnlContent.Controls.Add(pnlCustomer);
            pnlContent.Controls.Add(pnlEmployee);
            pnlContent.Location = new Point(0, 82);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1095, 620);
            pnlContent.TabIndex = 1;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(dgvRecentMutations);
            pnlDashboard.Controls.Add(lblRecentMutations);
            pnlDashboard.Controls.Add(dgvRecentContacts);
            pnlDashboard.Controls.Add(lblRecentContacts);
            pnlDashboard.Controls.Add(pnlInactiveStats);
            pnlDashboard.Controls.Add(pnlEmployeeStats);
            pnlDashboard.Controls.Add(pnlCustomerStats);
            pnlDashboard.Controls.Add(lblDashboardSubtitle);
            pnlDashboard.Controls.Add(lblDashboardTitle);
            pnlDashboard.Dock = DockStyle.Fill;
            pnlDashboard.Location = new Point(0, 0);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1095, 620);
            pnlDashboard.TabIndex = 0;
            // 
            // dgvRecentMutations
            // 
            dgvRecentMutations.AllowUserToAddRows = false;
            dgvRecentMutations.AllowUserToDeleteRows = false;
            dgvRecentMutations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentMutations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentMutations.Location = new Point(12, 435);
            dgvRecentMutations.MultiSelect = false;
            dgvRecentMutations.Name = "dgvRecentMutations";
            dgvRecentMutations.ReadOnly = true;
            dgvRecentMutations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentMutations.Size = new Size(1072, 180);
            dgvRecentMutations.TabIndex = 7;
            // 
            // lblRecentMutations
            // 
            lblRecentMutations.AutoSize = true;
            lblRecentMutations.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentMutations.Location = new Point(12, 411);
            lblRecentMutations.Name = "lblRecentMutations";
            lblRecentMutations.Size = new Size(150, 21);
            lblRecentMutations.TabIndex = 2;
            lblRecentMutations.Text = "Letzte Mutationen";
            // 
            // dgvRecentContacts
            // 
            dgvRecentContacts.AllowUserToAddRows = false;
            dgvRecentContacts.AllowUserToDeleteRows = false;
            dgvRecentContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentContacts.Location = new Point(12, 228);
            dgvRecentContacts.MultiSelect = false;
            dgvRecentContacts.Name = "dgvRecentContacts";
            dgvRecentContacts.ReadOnly = true;
            dgvRecentContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentContacts.Size = new Size(1072, 180);
            dgvRecentContacts.TabIndex = 6;
            // 
            // lblRecentContacts
            // 
            lblRecentContacts.AutoSize = true;
            lblRecentContacts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentContacts.Location = new Point(12, 204);
            lblRecentContacts.Name = "lblRecentContacts";
            lblRecentContacts.Size = new Size(187, 21);
            lblRecentContacts.TabIndex = 5;
            lblRecentContacts.Text = "Letzte Kundenkontakte";
            // 
            // pnlInactiveStats
            // 
            pnlInactiveStats.Controls.Add(lblInactiveStatsTitle);
            pnlInactiveStats.Controls.Add(lblInactiveCount);
            pnlInactiveStats.Location = new Point(775, 87);
            pnlInactiveStats.Name = "pnlInactiveStats";
            pnlInactiveStats.Size = new Size(220, 100);
            pnlInactiveStats.TabIndex = 4;
            // 
            // lblCustomerCount
            // 
            lblCustomerCount.AutoSize = true;
            lblCustomerCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerCount.Location = new Point(93, 34);
            lblCustomerCount.Name = "lblCustomerCount";
            lblCustomerCount.Size = new Size(34, 40);
            lblCustomerCount.TabIndex = 6;
            lblCustomerCount.Text = "0";
            // 
            // lblCustomerStatsTitle
            // 
            lblCustomerStatsTitle.AutoSize = true;
            lblCustomerStatsTitle.Location = new Point(3, 9);
            lblCustomerStatsTitle.Name = "lblCustomerStatsTitle";
            lblCustomerStatsTitle.Size = new Size(48, 15);
            lblCustomerStatsTitle.TabIndex = 5;
            lblCustomerStatsTitle.Text = "Kunden";
            // 
            // pnlEmployeeStats
            // 
            pnlEmployeeStats.Controls.Add(lblEmployeeCount);
            pnlEmployeeStats.Controls.Add(lblEmployeeStatsTitle);
            pnlEmployeeStats.Location = new Point(417, 87);
            pnlEmployeeStats.Name = "pnlEmployeeStats";
            pnlEmployeeStats.Size = new Size(220, 100);
            pnlEmployeeStats.TabIndex = 3;
            // 
            // lblEmployeeCount
            // 
            lblEmployeeCount.AutoSize = true;
            lblEmployeeCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeCount.Location = new Point(87, 34);
            lblEmployeeCount.Name = "lblEmployeeCount";
            lblEmployeeCount.Size = new Size(34, 40);
            lblEmployeeCount.TabIndex = 1;
            lblEmployeeCount.Text = "0";
            // 
            // lblEmployeeStatsTitle
            // 
            lblEmployeeStatsTitle.AutoSize = true;
            lblEmployeeStatsTitle.Location = new Point(3, 9);
            lblEmployeeStatsTitle.Name = "lblEmployeeStatsTitle";
            lblEmployeeStatsTitle.Size = new Size(65, 15);
            lblEmployeeStatsTitle.TabIndex = 0;
            lblEmployeeStatsTitle.Text = "Mitarbeiter";
            // 
            // pnlCustomerStats
            // 
            pnlCustomerStats.Controls.Add(lblCustomerCount);
            pnlCustomerStats.Controls.Add(lblCustomerStatsTitle);
            pnlCustomerStats.Location = new Point(59, 87);
            pnlCustomerStats.Name = "pnlCustomerStats";
            pnlCustomerStats.Size = new Size(220, 100);
            pnlCustomerStats.TabIndex = 2;
            // 
            // lblInactiveCount
            // 
            lblInactiveCount.AutoSize = true;
            lblInactiveCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInactiveCount.Location = new Point(89, 34);
            lblInactiveCount.Name = "lblInactiveCount";
            lblInactiveCount.Size = new Size(34, 40);
            lblInactiveCount.TabIndex = 1;
            lblInactiveCount.Text = "0";
            // 
            // lblInactiveStatsTitle
            // 
            lblInactiveStatsTitle.AutoSize = true;
            lblInactiveStatsTitle.Location = new Point(3, 9);
            lblInactiveStatsTitle.Name = "lblInactiveStatsTitle";
            lblInactiveStatsTitle.Size = new Size(42, 15);
            lblInactiveStatsTitle.TabIndex = 0;
            lblInactiveStatsTitle.Text = "Inaktiv";
            // 
            // lblDashboardSubtitle
            // 
            lblDashboardSubtitle.AutoSize = true;
            lblDashboardSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboardSubtitle.Location = new Point(12, 48);
            lblDashboardSubtitle.Name = "lblDashboardSubtitle";
            lblDashboardSubtitle.Size = new Size(231, 17);
            lblDashboardSubtitle.TabIndex = 1;
            lblDashboardSubtitle.Text = "Aktueller Stand des Contact Managers";
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.Location = new Point(12, 11);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(140, 37);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "Übersicht";
            // 
            // pnlCustomer
            // 
            pnlCustomer.Dock = DockStyle.Fill;
            pnlCustomer.Location = new Point(0, 0);
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.Size = new Size(1095, 620);
            pnlCustomer.TabIndex = 2;
            // 
            // pnlEmployee
            // 
            pnlEmployee.Dock = DockStyle.Fill;
            pnlEmployee.Location = new Point(0, 0);
            pnlEmployee.Name = "pnlEmployee";
            pnlEmployee.Size = new Size(1095, 620);
            pnlEmployee.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 733);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Name = "Form1";
            Text = "Contact Manager";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentMutations).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentContacts).EndInit();
            pnlInactiveStats.ResumeLayout(false);
            pnlInactiveStats.PerformLayout();
            pnlEmployeeStats.ResumeLayout(false);
            pnlEmployeeStats.PerformLayout();
            pnlCustomerStats.ResumeLayout(false);
            pnlCustomerStats.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnEmployee;
        private Button btnCustomer;
        private Button btnDashboard;
        private Label lblTitel;
        private Label lblPrg;
        private Panel pnlContent;
        private Panel pnlCustomer;
        private Panel pnlEmployee;
        private Panel pnlDashboard;
        private Panel pnlInactiveStats;
        private Panel pnlEmployeeStats;
        private Panel pnlCustomerStats;
        private Label lblDashboardSubtitle;
        private Label lblDashboardTitle;
        private Label lblCustomerCount;
        private Label lblCustomerStatsTitle;
        private Label lblEmployeeCount;
        private Label lblEmployeeStatsTitle;
        private Label label4;
        private Label lblInactiveStatsTitle;
        private Label lblInactiveCount;
        private DataGridView dgvRecentContacts;
        private Label lblRecentContacts;
        private DataGridView dgvRecentMutations;
        private Label lblRecentMutations;
    }
}
