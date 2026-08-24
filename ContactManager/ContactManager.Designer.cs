namespace ContactManager
{
    partial class ContactManager
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
            pnlEmployee = new Panel();
            dgvEmployees = new DataGridView();
            btnEmployeeDelete = new Button();
            btnEmployeeEdit = new Button();
            btnEmployeeAdd = new Button();
            btnEmployeeSearch = new Button();
            txtEmployeSearch = new TextBox();
            lblEmployeeSearch = new Label();
            lblEmployeeSubtitle = new Label();
            lblEmployeeTitle = new Label();
            pnlCustomer = new Panel();
            dgvCustomers = new DataGridView();
            btnCustomerDelete = new Button();
            btnCustomerEdit = new Button();
            btnCustomerAdd = new Button();
            btnCustomerSearch = new Button();
            lblCustomerSearch = new Label();
            txtCustomerSearch = new TextBox();
            lblCustomerSubtitle = new Label();
            lblCustomerTitle = new Label();
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
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            pnlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
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
            btnEmployee.Click += btnEmployee_Click;
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
            btnCustomer.Click += btnCustomer_Click;
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
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(pnlCustomer);
            pnlContent.Controls.Add(pnlEmployee);
            pnlContent.Location = new Point(0, 82);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1251, 827);
            pnlContent.TabIndex = 1;
            // 
            // pnlEmployee
            // 
            pnlEmployee.Controls.Add(dgvEmployees);
            pnlEmployee.Controls.Add(btnEmployeeDelete);
            pnlEmployee.Controls.Add(btnEmployeeEdit);
            pnlEmployee.Controls.Add(btnEmployeeAdd);
            pnlEmployee.Controls.Add(btnEmployeeSearch);
            pnlEmployee.Controls.Add(txtEmployeSearch);
            pnlEmployee.Controls.Add(lblEmployeeSearch);
            pnlEmployee.Controls.Add(lblEmployeeSubtitle);
            pnlEmployee.Controls.Add(lblEmployeeTitle);
            pnlEmployee.Dock = DockStyle.Fill;
            pnlEmployee.Location = new Point(0, 0);
            pnlEmployee.Name = "pnlEmployee";
            pnlEmployee.Size = new Size(1095, 620);
            pnlEmployee.TabIndex = 1;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 130);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(1072, 485);
            dgvEmployees.TabIndex = 8;
            // 
            // btnEmployeeDelete
            // 
            btnEmployeeDelete.Location = new Point(756, 73);
            btnEmployeeDelete.Name = "btnEmployeeDelete";
            btnEmployeeDelete.Size = new Size(111, 23);
            btnEmployeeDelete.TabIndex = 7;
            btnEmployeeDelete.Text = "Löschen";
            btnEmployeeDelete.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeEdit
            // 
            btnEmployeeEdit.Location = new Point(642, 73);
            btnEmployeeEdit.Name = "btnEmployeeEdit";
            btnEmployeeEdit.Size = new Size(111, 23);
            btnEmployeeEdit.TabIndex = 6;
            btnEmployeeEdit.Text = "Bearbeiten";
            btnEmployeeEdit.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeAdd
            // 
            btnEmployeeAdd.Location = new Point(526, 73);
            btnEmployeeAdd.Name = "btnEmployeeAdd";
            btnEmployeeAdd.Size = new Size(111, 23);
            btnEmployeeAdd.TabIndex = 5;
            btnEmployeeAdd.Text = "Neuer Mitarbeiter";
            btnEmployeeAdd.UseVisualStyleBackColor = true;
            btnEmployeeAdd.Click += btnEmployeeAdd_Click;
            // 
            // btnEmployeeSearch
            // 
            btnEmployeeSearch.Location = new Point(378, 73);
            btnEmployeeSearch.Name = "btnEmployeeSearch";
            btnEmployeeSearch.Size = new Size(75, 23);
            btnEmployeeSearch.TabIndex = 4;
            btnEmployeeSearch.Text = "Suchen";
            btnEmployeeSearch.UseVisualStyleBackColor = true;
            // 
            // txtEmployeSearch
            // 
            txtEmployeSearch.Location = new Point(137, 73);
            txtEmployeSearch.Name = "txtEmployeSearch";
            txtEmployeSearch.Size = new Size(235, 23);
            txtEmployeSearch.TabIndex = 3;
            // 
            // lblEmployeeSearch
            // 
            lblEmployeeSearch.AutoSize = true;
            lblEmployeeSearch.Location = new Point(22, 77);
            lblEmployeeSearch.Name = "lblEmployeeSearch";
            lblEmployeeSearch.Size = new Size(109, 15);
            lblEmployeeSearch.TabIndex = 2;
            lblEmployeeSearch.Text = "Mitarbeiter suchen:";
            // 
            // lblEmployeeSubtitle
            // 
            lblEmployeeSubtitle.AutoSize = true;
            lblEmployeeSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeSubtitle.Location = new Point(183, 27);
            lblEmployeeSubtitle.Name = "lblEmployeeSubtitle";
            lblEmployeeSubtitle.Size = new Size(225, 17);
            lblEmployeeSubtitle.TabIndex = 1;
            lblEmployeeSubtitle.Text = "Mitarbeiter verwalten und bearbeiten";
            // 
            // lblEmployeeTitle
            // 
            lblEmployeeTitle.AutoSize = true;
            lblEmployeeTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeTitle.Location = new Point(12, 11);
            lblEmployeeTitle.Name = "lblEmployeeTitle";
            lblEmployeeTitle.Size = new Size(165, 37);
            lblEmployeeTitle.TabIndex = 0;
            lblEmployeeTitle.Text = "Mitarbeiter";
            // 
            // pnlCustomer
            // 
            pnlCustomer.Controls.Add(dgvCustomers);
            pnlCustomer.Controls.Add(btnCustomerDelete);
            pnlCustomer.Controls.Add(btnCustomerEdit);
            pnlCustomer.Controls.Add(btnCustomerAdd);
            pnlCustomer.Controls.Add(btnCustomerSearch);
            pnlCustomer.Controls.Add(lblCustomerSearch);
            pnlCustomer.Controls.Add(txtCustomerSearch);
            pnlCustomer.Controls.Add(lblCustomerSubtitle);
            pnlCustomer.Controls.Add(lblCustomerTitle);
            pnlCustomer.Dock = DockStyle.Fill;
            pnlCustomer.Location = new Point(0, 0);
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.Size = new Size(1095, 620);
            pnlCustomer.TabIndex = 2;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(12, 130);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(1072, 485);
            dgvCustomers.TabIndex = 8;
            // 
            // btnCustomerDelete
            // 
            btnCustomerDelete.Location = new Point(756, 73);
            btnCustomerDelete.Name = "btnCustomerDelete";
            btnCustomerDelete.Size = new Size(111, 23);
            btnCustomerDelete.TabIndex = 7;
            btnCustomerDelete.Text = "Löschen";
            btnCustomerDelete.UseVisualStyleBackColor = true;
            // 
            // btnCustomerEdit
            // 
            btnCustomerEdit.Location = new Point(642, 73);
            btnCustomerEdit.Name = "btnCustomerEdit";
            btnCustomerEdit.Size = new Size(111, 23);
            btnCustomerEdit.TabIndex = 6;
            btnCustomerEdit.Text = "Bearbeiten";
            btnCustomerEdit.UseVisualStyleBackColor = true;
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.Location = new Point(526, 73);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new Size(111, 23);
            btnCustomerAdd.TabIndex = 5;
            btnCustomerAdd.Text = "Neuer Kunde";
            btnCustomerAdd.UseVisualStyleBackColor = true;
            btnCustomerAdd.Click += btnCustomerAdd_Click;
            // 
            // btnCustomerSearch
            // 
            btnCustomerSearch.Location = new Point(378, 73);
            btnCustomerSearch.Name = "btnCustomerSearch";
            btnCustomerSearch.Size = new Size(111, 23);
            btnCustomerSearch.TabIndex = 4;
            btnCustomerSearch.Text = "Suchen";
            btnCustomerSearch.UseVisualStyleBackColor = true;
            // 
            // lblCustomerSearch
            // 
            lblCustomerSearch.AutoSize = true;
            lblCustomerSearch.Location = new Point(22, 77);
            lblCustomerSearch.Name = "lblCustomerSearch";
            lblCustomerSearch.Size = new Size(92, 15);
            lblCustomerSearch.TabIndex = 3;
            lblCustomerSearch.Text = "Kunden suchen:";
            // 
            // txtCustomerSearch
            // 
            txtCustomerSearch.Location = new Point(137, 73);
            txtCustomerSearch.Name = "txtCustomerSearch";
            txtCustomerSearch.Size = new Size(235, 23);
            txtCustomerSearch.TabIndex = 2;
            // 
            // lblCustomerSubtitle
            // 
            lblCustomerSubtitle.AutoSize = true;
            lblCustomerSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerSubtitle.Location = new Point(133, 27);
            lblCustomerSubtitle.Name = "lblCustomerSubtitle";
            lblCustomerSubtitle.Size = new Size(204, 17);
            lblCustomerSubtitle.TabIndex = 1;
            lblCustomerSubtitle.Text = "Kunden verwalten und bearbeiten";
            // 
            // lblCustomerTitle
            // 
            lblCustomerTitle.AutoSize = true;
            lblCustomerTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerTitle.Location = new Point(12, 11);
            lblCustomerTitle.Name = "lblCustomerTitle";
            lblCustomerTitle.Size = new Size(115, 37);
            lblCustomerTitle.TabIndex = 0;
            lblCustomerTitle.Text = "Kunden";
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
            pnlInactiveStats.BackColor = SystemColors.GradientActiveCaption;
            pnlInactiveStats.BorderStyle = BorderStyle.FixedSingle;
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
            lblCustomerCount.AutoSize = true;
            lblCustomerCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerCount.Location = new Point(93, 34);
            lblCustomerCount.Name = "lblCustomerCount";
            lblCustomerCount.Size = new Size(34, 40);
            lblCustomerCount.TabIndex = 6;
            lblCustomerCount.Text = "0";
            // 
            // lblInactiveCount
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
            pnlEmployeeStats.BackColor = SystemColors.GradientActiveCaption;
            pnlEmployeeStats.BorderStyle = BorderStyle.FixedSingle;
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
            lblEmployeeCount.Location = new Point(87, 34);
            lblEmployeeCount.Name = "lblEmployeeCount";
            lblEmployeeCount.Size = new Size(43, 50);
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
            lblEmployeeStatsTitle.Text = "Mitarbeiter:";
            // 
            // pnlCustomerStats
            // 
            pnlCustomerStats.BackColor = SystemColors.GradientActiveCaption;
            pnlCustomerStats.BorderStyle = BorderStyle.FixedSingle;
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
            lblInactiveCount.AutoSize = true;
            lblInactiveCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInactiveCount.Location = new Point(89, 34);
            lblInactiveCount.Name = "lblInactiveCount";
            lblInactiveCount.Size = new Size(34, 40);
            lblInactiveCount.TabIndex = 1;
            lblInactiveCount.Text = "0";
            // 
            // lblCustomerStatsTitle
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 941);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Name = "Form1";
            Text = "Contact Manager";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlEmployee.ResumeLayout(false);
            pnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            pnlCustomer.ResumeLayout(false);
            pnlCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
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
        private Label lblCustomerTitle;
        private Label lblCustomerSearch;
        private TextBox txtCustomerSearch;
        private Label lblCustomerSubtitle;
        private Button btnCustomerDelete;
        private Button btnCustomerEdit;
        private Button btnCustomerAdd;
        private Button btnCustomerSearch;
        private DataGridView dgvCustomers;
        private TextBox txtEmployeSearch;
        private Label lblEmployeeSearch;
        private Label lblEmployeeSubtitle;
        private Label lblEmployeeTitle;
        private Button btnEmployeeDelete;
        private Button btnEmployeeEdit;
        private Button btnEmployeeAdd;
        private Button btnEmployeeSearch;
        private DataGridView dgvEmployees;
    }
}
