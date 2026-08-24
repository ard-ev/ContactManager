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
            lblInactiveStatsTitle = new Label();
            lblInactiveCount = new Label();
            pnlEmployeeStats = new Panel();
            lblEmployeeCount = new Label();
            lblEmployeeStatsTitle = new Label();
            pnlCustomerStats = new Panel();
            lblCustomerCount = new Label();
            lblCustomerStatsTitle = new Label();
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
            pnlHeader.Location = new Point(0, 16);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1251, 85);
            pnlHeader.TabIndex = 0;
            // 
            // lblPrg
            // 
            lblPrg.AutoSize = true;
            lblPrg.Location = new Point(1102, 36);
            lblPrg.Name = "lblPrg";
            lblPrg.Size = new Size(80, 20);
            lblPrg.TabIndex = 3;
            lblPrg.Text = "Version 1.0";
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitel.Location = new Point(14, 20);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(371, 52);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Contact Manager";
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(865, 31);
            btnEmployee.Margin = new Padding(3, 4, 3, 4);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(198, 31);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "Mitarbeiter";
            btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(629, 31);
            btnCustomer.Margin = new Padding(3, 4, 3, 4);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(198, 31);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Kunden";
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(392, 31);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(198, 31);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Übersicht";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(pnlDashboard);
            pnlContent.Controls.Add(pnlCustomer);
            pnlContent.Controls.Add(pnlEmployee);
            pnlContent.Location = new Point(0, 109);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1251, 827);
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
            pnlDashboard.Margin = new Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1251, 827);
            pnlDashboard.TabIndex = 0;
            // 
            // dgvRecentMutations
            // 
            dgvRecentMutations.AllowUserToAddRows = false;
            dgvRecentMutations.AllowUserToDeleteRows = false;
            dgvRecentMutations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentMutations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentMutations.Location = new Point(14, 580);
            dgvRecentMutations.Margin = new Padding(3, 4, 3, 4);
            dgvRecentMutations.MultiSelect = false;
            dgvRecentMutations.Name = "dgvRecentMutations";
            dgvRecentMutations.ReadOnly = true;
            dgvRecentMutations.RowHeadersWidth = 51;
            dgvRecentMutations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentMutations.Size = new Size(1225, 240);
            dgvRecentMutations.TabIndex = 7;
            // 
            // lblRecentMutations
            // 
            lblRecentMutations.AutoSize = true;
            lblRecentMutations.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentMutations.Location = new Point(14, 548);
            lblRecentMutations.Name = "lblRecentMutations";
            lblRecentMutations.Size = new Size(187, 28);
            lblRecentMutations.TabIndex = 2;
            lblRecentMutations.Text = "Letzte Mutationen";
            // 
            // dgvRecentContacts
            // 
            dgvRecentContacts.AllowUserToAddRows = false;
            dgvRecentContacts.AllowUserToDeleteRows = false;
            dgvRecentContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentContacts.Location = new Point(14, 304);
            dgvRecentContacts.Margin = new Padding(3, 4, 3, 4);
            dgvRecentContacts.MultiSelect = false;
            dgvRecentContacts.Name = "dgvRecentContacts";
            dgvRecentContacts.ReadOnly = true;
            dgvRecentContacts.RowHeadersWidth = 51;
            dgvRecentContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentContacts.Size = new Size(1225, 240);
            dgvRecentContacts.TabIndex = 6;
            // 
            // lblRecentContacts
            // 
            lblRecentContacts.AutoSize = true;
            lblRecentContacts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentContacts.Location = new Point(14, 272);
            lblRecentContacts.Name = "lblRecentContacts";
            lblRecentContacts.Size = new Size(232, 28);
            lblRecentContacts.TabIndex = 5;
            lblRecentContacts.Text = "Letzte Kundenkontakte";
            // 
            // pnlInactiveStats
            // 
            pnlInactiveStats.Controls.Add(lblInactiveStatsTitle);
            pnlInactiveStats.Controls.Add(lblInactiveCount);
            pnlInactiveStats.Location = new Point(886, 116);
            pnlInactiveStats.Margin = new Padding(3, 4, 3, 4);
            pnlInactiveStats.Name = "pnlInactiveStats";
            pnlInactiveStats.Size = new Size(251, 133);
            pnlInactiveStats.TabIndex = 4;
            // 
            // lblInactiveStatsTitle
            // 
            lblInactiveStatsTitle.AutoSize = true;
            lblInactiveStatsTitle.Location = new Point(3, 12);
            lblInactiveStatsTitle.Name = "lblInactiveStatsTitle";
            lblInactiveStatsTitle.Size = new Size(52, 20);
            lblInactiveStatsTitle.TabIndex = 0;
            lblInactiveStatsTitle.Text = "Inaktiv";
            // 
            // lblInactiveCount
            // 
            lblInactiveCount.AutoSize = true;
            lblInactiveCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInactiveCount.Location = new Point(102, 45);
            lblInactiveCount.Name = "lblInactiveCount";
            lblInactiveCount.Size = new Size(43, 50);
            lblInactiveCount.TabIndex = 1;
            lblInactiveCount.Text = "0";
            // 
            // pnlEmployeeStats
            // 
            pnlEmployeeStats.Controls.Add(lblEmployeeCount);
            pnlEmployeeStats.Controls.Add(lblEmployeeStatsTitle);
            pnlEmployeeStats.Location = new Point(477, 116);
            pnlEmployeeStats.Margin = new Padding(3, 4, 3, 4);
            pnlEmployeeStats.Name = "pnlEmployeeStats";
            pnlEmployeeStats.Size = new Size(251, 133);
            pnlEmployeeStats.TabIndex = 3;
            // 
            // lblEmployeeCount
            // 
            lblEmployeeCount.AutoSize = true;
            lblEmployeeCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeCount.Location = new Point(99, 45);
            lblEmployeeCount.Name = "lblEmployeeCount";
            lblEmployeeCount.Size = new Size(43, 50);
            lblEmployeeCount.TabIndex = 1;
            lblEmployeeCount.Text = "0";
            // 
            // lblEmployeeStatsTitle
            // 
            lblEmployeeStatsTitle.AutoSize = true;
            lblEmployeeStatsTitle.Location = new Point(3, 12);
            lblEmployeeStatsTitle.Name = "lblEmployeeStatsTitle";
            lblEmployeeStatsTitle.Size = new Size(83, 20);
            lblEmployeeStatsTitle.TabIndex = 0;
            lblEmployeeStatsTitle.Text = "Mitarbeiter";
            // 
            // pnlCustomerStats
            // 
            pnlCustomerStats.Controls.Add(lblCustomerCount);
            pnlCustomerStats.Controls.Add(lblCustomerStatsTitle);
            pnlCustomerStats.Location = new Point(67, 116);
            pnlCustomerStats.Margin = new Padding(3, 4, 3, 4);
            pnlCustomerStats.Name = "pnlCustomerStats";
            pnlCustomerStats.Size = new Size(251, 133);
            pnlCustomerStats.TabIndex = 2;
            // 
            // lblCustomerCount
            // 
            lblCustomerCount.AutoSize = true;
            lblCustomerCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerCount.Location = new Point(106, 45);
            lblCustomerCount.Name = "lblCustomerCount";
            lblCustomerCount.Size = new Size(43, 50);
            lblCustomerCount.TabIndex = 6;
            lblCustomerCount.Text = "0";
            // 
            // lblCustomerStatsTitle
            // 
            lblCustomerStatsTitle.AutoSize = true;
            lblCustomerStatsTitle.Location = new Point(3, 12);
            lblCustomerStatsTitle.Name = "lblCustomerStatsTitle";
            lblCustomerStatsTitle.Size = new Size(59, 20);
            lblCustomerStatsTitle.TabIndex = 5;
            lblCustomerStatsTitle.Text = "Kunden";
            // 
            // lblDashboardSubtitle
            // 
            lblDashboardSubtitle.AutoSize = true;
            lblDashboardSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboardSubtitle.Location = new Point(14, 64);
            lblDashboardSubtitle.Name = "lblDashboardSubtitle";
            lblDashboardSubtitle.Size = new Size(301, 23);
            lblDashboardSubtitle.TabIndex = 1;
            lblDashboardSubtitle.Text = "Aktueller Stand des Contact Managers";
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.Location = new Point(14, 15);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(172, 46);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "Übersicht";
            // 
            // pnlCustomer
            // 
            pnlCustomer.Dock = DockStyle.Fill;
            pnlCustomer.Location = new Point(0, 0);
            pnlCustomer.Margin = new Padding(3, 4, 3, 4);
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.Size = new Size(1251, 827);
            pnlCustomer.TabIndex = 2;
            // 
            // pnlEmployee
            // 
            pnlEmployee.Dock = DockStyle.Fill;
            pnlEmployee.Location = new Point(0, 0);
            pnlEmployee.Margin = new Padding(3, 4, 3, 4);
            pnlEmployee.Name = "pnlEmployee";
            pnlEmployee.Size = new Size(1251, 827);
            pnlEmployee.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 941);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
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
