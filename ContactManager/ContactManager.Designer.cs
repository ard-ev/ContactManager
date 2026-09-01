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
            pnlCustomers = new Panel();
            dgvCustomers = new DataGridView();
            btnCustomerDel = new Button();
            btnCustomerEdit = new Button();
            btnCustomerAdd = new Button();
            btnCustomerSearch = new Button();
            txtCustomerSearch = new TextBox();
            lblCustomerSearch = new Label();
            label2 = new Label();
            lblCustomersTitle = new Label();
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
            pnlDashboard = new Panel();
            lblRecentCustomers = new Label();
            dgvRecentMutations = new DataGridView();
            dgvRecentContacts = new DataGridView();
            lblRecentMutations = new Label();
            pnlInactiveStats = new Panel();
            lblInactiveCount = new Label();
            lblInactiveStatsTitle = new Label();
            pnlEmployeeStats = new Panel();
            lblEmployeeCount = new Label();
            lblEmployeeStatsTitle = new Label();
            pnlCustomerStats = new Panel();
            lblCustomerCount = new Label();
            lblCustomerStatsTitle = new Label();
            lblDashboardTitle = new Label();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
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
            pnlHeader.BackColor = SystemColors.ControlLight;
            pnlHeader.Controls.Add(lblPrg);
            pnlHeader.Controls.Add(lblTitel);
            pnlHeader.Controls.Add(btnEmployee);
            pnlHeader.Controls.Add(btnCustomer);
            pnlHeader.Controls.Add(btnDashboard);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1099, 60);
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
            btnEmployee.Location = new Point(722, 19);
            btnEmployee.Margin = new Padding(3, 2, 3, 2);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(151, 30);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "Mitarbeiter";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(522, 19);
            btnCustomer.Margin = new Padding(3, 2, 3, 2);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(151, 30);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Kunden";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(325, 19);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(151, 30);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Übersicht";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(pnlEmployee);
            pnlContent.Controls.Add(pnlCustomers);
            pnlContent.Controls.Add(pnlDashboard);
            pnlContent.Location = new Point(0, 61);
            pnlContent.Margin = new Padding(3, 2, 3, 2);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1099, 641);
            pnlContent.TabIndex = 1;
            // 
            // pnlCustomers
            // 
            pnlCustomers.Controls.Add(dgvCustomers);
            pnlCustomers.Controls.Add(btnCustomerDel);
            pnlCustomers.Controls.Add(btnCustomerEdit);
            pnlCustomers.Controls.Add(btnCustomerAdd);
            pnlCustomers.Controls.Add(btnCustomerSearch);
            pnlCustomers.Controls.Add(txtCustomerSearch);
            pnlCustomers.Controls.Add(lblCustomerSearch);
            pnlCustomers.Controls.Add(label2);
            pnlCustomers.Controls.Add(lblCustomersTitle);
            pnlCustomers.Location = new Point(0, 0);
            pnlCustomers.Name = "pnlCustomers";
            pnlCustomers.Size = new Size(1099, 577);
            pnlCustomers.TabIndex = 3;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(45, 107);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 62;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(1000, 462);
            dgvCustomers.TabIndex = 8;
            dgvCustomers.CellDoubleClick += dgvCustomers_CellDoubleClick;
            // 
            // btnCustomerDel
            // 
            btnCustomerDel.Location = new Point(934, 66);
            btnCustomerDel.Name = "btnCustomerDel";
            btnCustomerDel.Size = new Size(111, 23);
            btnCustomerDel.TabIndex = 7;
            btnCustomerDel.Text = "Löschen";
            btnCustomerDel.UseVisualStyleBackColor = true;
            btnCustomerDel.Click += btnCustomerDel_Click;
            // 
            // btnCustomerEdit
            // 
            btnCustomerEdit.Location = new Point(817, 66);
            btnCustomerEdit.Name = "btnCustomerEdit";
            btnCustomerEdit.Size = new Size(111, 23);
            btnCustomerEdit.TabIndex = 6;
            btnCustomerEdit.Text = "Bearbeiten";
            btnCustomerEdit.UseVisualStyleBackColor = true;
            btnCustomerEdit.Click += btnCustomerEdit_Click;
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.Location = new Point(700, 65);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new Size(111, 23);
            btnCustomerAdd.TabIndex = 5;
            btnCustomerAdd.Text = "Neuer Kunde";
            btnCustomerAdd.UseVisualStyleBackColor = true;
            btnCustomerAdd.Click += btnCustomerAdd_Click_1;
            // 
            // btnCustomerSearch
            // 
            btnCustomerSearch.Location = new Point(357, 66);
            btnCustomerSearch.Name = "btnCustomerSearch";
            btnCustomerSearch.Size = new Size(60, 23);
            btnCustomerSearch.TabIndex = 4;
            btnCustomerSearch.Text = "Suchen";
            btnCustomerSearch.UseVisualStyleBackColor = true;
            btnCustomerSearch.Click += btnCustomerSearch_Click;
            // 
            // txtCustomerSearch
            // 
            txtCustomerSearch.Location = new Point(166, 66);
            txtCustomerSearch.Name = "txtCustomerSearch";
            txtCustomerSearch.Size = new Size(181, 23);
            txtCustomerSearch.TabIndex = 3;
            // 
            // lblCustomerSearch
            // 
            lblCustomerSearch.AutoSize = true;
            lblCustomerSearch.Location = new Point(47, 70);
            lblCustomerSearch.Name = "lblCustomerSearch";
            lblCustomerSearch.Size = new Size(85, 15);
            lblCustomerSearch.TabIndex = 2;
            lblCustomerSearch.Text = "Kunde suchen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 31);
            label2.Name = "label2";
            label2.Size = new Size(185, 15);
            label2.TabIndex = 1;
            label2.Text = "Kunden verwalten und bearbeiten";
            // 
            // lblCustomersTitle
            // 
            lblCustomersTitle.AutoSize = true;
            lblCustomersTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomersTitle.Location = new Point(12, 15);
            lblCustomersTitle.Name = "lblCustomersTitle";
            lblCustomersTitle.Size = new Size(115, 37);
            lblCustomersTitle.TabIndex = 0;
            lblCustomersTitle.Text = "Kunden";
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
            pnlEmployee.Location = new Point(0, 0);
            pnlEmployee.Margin = new Padding(3, 2, 3, 2);
            pnlEmployee.Name = "pnlEmployee";
            pnlEmployee.Size = new Size(1099, 577);
            pnlEmployee.TabIndex = 1;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(45, 107);
            dgvEmployees.Margin = new Padding(3, 2, 3, 2);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersWidth = 62;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(1000, 462);
            dgvEmployees.TabIndex = 8;
            dgvEmployees.CellContentClick += dgvEmployees_CellContentClick;
            // 
            // btnEmployeeDelete
            // 
            btnEmployeeDelete.Location = new Point(934, 66);
            btnEmployeeDelete.Margin = new Padding(3, 2, 3, 2);
            btnEmployeeDelete.Name = "btnEmployeeDelete";
            btnEmployeeDelete.Size = new Size(111, 23);
            btnEmployeeDelete.TabIndex = 7;
            btnEmployeeDelete.Text = "Löschen";
            btnEmployeeDelete.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeEdit
            // 
            btnEmployeeEdit.Location = new Point(817, 66);
            btnEmployeeEdit.Margin = new Padding(3, 2, 3, 2);
            btnEmployeeEdit.Name = "btnEmployeeEdit";
            btnEmployeeEdit.Size = new Size(111, 23);
            btnEmployeeEdit.TabIndex = 6;
            btnEmployeeEdit.Text = "Bearbeiten";
            btnEmployeeEdit.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeAdd
            // 
            btnEmployeeAdd.Location = new Point(700, 65);
            btnEmployeeAdd.Margin = new Padding(3, 2, 3, 2);
            btnEmployeeAdd.Name = "btnEmployeeAdd";
            btnEmployeeAdd.Size = new Size(111, 23);
            btnEmployeeAdd.TabIndex = 5;
            btnEmployeeAdd.Text = "Neuer Mitarbeiter";
            btnEmployeeAdd.UseVisualStyleBackColor = true;
            btnEmployeeAdd.Click += btnEmployeeAdd_Click;
            // 
            // btnEmployeeSearch
            // 
            btnEmployeeSearch.Location = new Point(357, 66);
            btnEmployeeSearch.Margin = new Padding(3, 2, 3, 2);
            btnEmployeeSearch.Name = "btnEmployeeSearch";
            btnEmployeeSearch.Size = new Size(60, 23);
            btnEmployeeSearch.TabIndex = 4;
            btnEmployeeSearch.Text = "Suchen";
            btnEmployeeSearch.UseVisualStyleBackColor = true;
            // 
            // txtEmployeSearch
            // 
            txtEmployeSearch.Location = new Point(166, 66);
            txtEmployeSearch.Margin = new Padding(3, 2, 3, 2);
            txtEmployeSearch.Name = "txtEmployeSearch";
            txtEmployeSearch.Size = new Size(181, 23);
            txtEmployeSearch.TabIndex = 3;
            // 
            // lblEmployeeSearch
            // 
            lblEmployeeSearch.AutoSize = true;
            lblEmployeeSearch.Location = new Point(47, 70);
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
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblRecentCustomers);
            pnlDashboard.Controls.Add(dgvRecentMutations);
            pnlDashboard.Controls.Add(dgvRecentContacts);
            pnlDashboard.Controls.Add(lblRecentMutations);
            pnlDashboard.Controls.Add(pnlInactiveStats);
            pnlDashboard.Controls.Add(pnlEmployeeStats);
            pnlDashboard.Controls.Add(pnlCustomerStats);
            pnlDashboard.Controls.Add(lblDashboardTitle);
            pnlDashboard.Location = new Point(0, 0);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1099, 702);
            pnlDashboard.TabIndex = 2;
            // 
            // lblRecentCustomers
            // 
            lblRecentCustomers.AutoSize = true;
            lblRecentCustomers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentCustomers.Location = new Point(20, 381);
            lblRecentCustomers.Name = "lblRecentCustomers";
            lblRecentCustomers.Size = new Size(191, 21);
            lblRecentCustomers.TabIndex = 9;
            lblRecentCustomers.Text = "Letzte Kundenkontakte:";
            // 
            // dgvRecentMutations
            // 
            dgvRecentMutations.AllowUserToAddRows = false;
            dgvRecentMutations.AllowUserToDeleteRows = false;
            dgvRecentMutations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentMutations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentMutations.Location = new Point(12, 211);
            dgvRecentMutations.Name = "dgvRecentMutations";
            dgvRecentMutations.RowHeadersWidth = 62;
            dgvRecentMutations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentMutations.Size = new Size(1075, 150);
            dgvRecentMutations.TabIndex = 8;
            // 
            // dgvRecentContacts
            // 
            dgvRecentContacts.AllowUserToAddRows = false;
            dgvRecentContacts.AllowUserToDeleteRows = false;
            dgvRecentContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentContacts.Location = new Point(12, 419);
            dgvRecentContacts.MultiSelect = false;
            dgvRecentContacts.Name = "dgvRecentContacts";
            dgvRecentContacts.ReadOnly = true;
            dgvRecentContacts.RowHeadersWidth = 62;
            dgvRecentContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentContacts.Size = new Size(1075, 150);
            dgvRecentContacts.TabIndex = 7;
            // 
            // lblRecentMutations
            // 
            lblRecentMutations.AutoSize = true;
            lblRecentMutations.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentMutations.Location = new Point(12, 187);
            lblRecentMutations.Name = "lblRecentMutations";
            lblRecentMutations.Size = new Size(154, 21);
            lblRecentMutations.TabIndex = 4;
            lblRecentMutations.Text = "Letzte Mutationen:";
            // 
            // pnlInactiveStats
            // 
            pnlInactiveStats.BorderStyle = BorderStyle.FixedSingle;
            pnlInactiveStats.Controls.Add(lblInactiveCount);
            pnlInactiveStats.Controls.Add(lblInactiveStatsTitle);
            pnlInactiveStats.Location = new Point(770, 70);
            pnlInactiveStats.Name = "pnlInactiveStats";
            pnlInactiveStats.Size = new Size(200, 100);
            pnlInactiveStats.TabIndex = 3;
            // 
            // lblInactiveCount
            // 
            lblInactiveCount.AutoSize = true;
            lblInactiveCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInactiveCount.Location = new Point(80, 36);
            lblInactiveCount.Name = "lblInactiveCount";
            lblInactiveCount.Size = new Size(34, 40);
            lblInactiveCount.TabIndex = 1;
            lblInactiveCount.Text = "0";
            // 
            // lblInactiveStatsTitle
            // 
            lblInactiveStatsTitle.AutoSize = true;
            lblInactiveStatsTitle.Location = new Point(46, 3);
            lblInactiveStatsTitle.Name = "lblInactiveStatsTitle";
            lblInactiveStatsTitle.Size = new Size(95, 15);
            lblInactiveStatsTitle.TabIndex = 0;
            lblInactiveStatsTitle.Text = "Inaktive Objekte:";
            // 
            // pnlEmployeeStats
            // 
            pnlEmployeeStats.BorderStyle = BorderStyle.FixedSingle;
            pnlEmployeeStats.Controls.Add(lblEmployeeCount);
            pnlEmployeeStats.Controls.Add(lblEmployeeStatsTitle);
            pnlEmployeeStats.Location = new Point(428, 70);
            pnlEmployeeStats.Name = "pnlEmployeeStats";
            pnlEmployeeStats.Size = new Size(200, 100);
            pnlEmployeeStats.TabIndex = 2;
            // 
            // lblEmployeeCount
            // 
            lblEmployeeCount.AutoSize = true;
            lblEmployeeCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeCount.Location = new Point(81, 36);
            lblEmployeeCount.Name = "lblEmployeeCount";
            lblEmployeeCount.Size = new Size(34, 40);
            lblEmployeeCount.TabIndex = 1;
            lblEmployeeCount.Text = "0";
            // 
            // lblEmployeeStatsTitle
            // 
            lblEmployeeStatsTitle.AutoSize = true;
            lblEmployeeStatsTitle.Location = new Point(39, 3);
            lblEmployeeStatsTitle.Name = "lblEmployeeStatsTitle";
            lblEmployeeStatsTitle.Size = new Size(114, 15);
            lblEmployeeStatsTitle.TabIndex = 0;
            lblEmployeeStatsTitle.Text = "Aktuelle Mitarbeiter:";
            // 
            // pnlCustomerStats
            // 
            pnlCustomerStats.BorderStyle = BorderStyle.FixedSingle;
            pnlCustomerStats.Controls.Add(lblCustomerCount);
            pnlCustomerStats.Controls.Add(lblCustomerStatsTitle);
            pnlCustomerStats.Location = new Point(86, 70);
            pnlCustomerStats.Name = "pnlCustomerStats";
            pnlCustomerStats.Size = new Size(200, 100);
            pnlCustomerStats.TabIndex = 1;
            // 
            // lblCustomerCount
            // 
            lblCustomerCount.AutoSize = true;
            lblCustomerCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerCount.Location = new Point(79, 36);
            lblCustomerCount.Name = "lblCustomerCount";
            lblCustomerCount.Size = new Size(34, 40);
            lblCustomerCount.TabIndex = 1;
            lblCustomerCount.Text = "0";
            // 
            // lblCustomerStatsTitle
            // 
            lblCustomerStatsTitle.AutoSize = true;
            lblCustomerStatsTitle.Location = new Point(46, 3);
            lblCustomerStatsTitle.Name = "lblCustomerStatsTitle";
            lblCustomerStatsTitle.Size = new Size(97, 15);
            lblCustomerStatsTitle.TabIndex = 0;
            lblCustomerStatsTitle.Text = "Aktuelle Kunden:";
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.Location = new Point(12, 13);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(157, 37);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "Dashboard";
            // 
            // ContactManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 637);
            Controls.Add(pnlHeader);
            Controls.Add(pnlContent);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ContactManager";
            Text = "Contact Manager";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlCustomers.ResumeLayout(false);
            pnlCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            pnlEmployee.ResumeLayout(false);
            pnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
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
        private Panel pnlEmployee;
        private TextBox txtEmployeSearch;
        private Label lblEmployeeSearch;
        private Label lblEmployeeSubtitle;
        private Label lblEmployeeTitle;
        private Button btnEmployeeDelete;
        private Button btnEmployeeEdit;
        private Button btnEmployeeAdd;
        private Button btnEmployeeSearch;
        private DataGridView dgvEmployees;
        private Panel pnlCustomers;
        private Label lblCustomerSearch;
        private Label label2;
        private Label lblCustomersTitle;
        private Panel pnlDashboard;
        private DataGridView dgvCustomers;
        private Button btnCustomerDel;
        private Button btnCustomerEdit;
        private Button btnCustomerAdd;
        private Button btnCustomerSearch;
        private TextBox txtCustomerSearch;
        private Panel pnlInactiveStats;
        private Panel pnlEmployeeStats;
        private Panel pnlCustomerStats;
        private Label lblCustomerCount;
        private Label lblCustomerStatsTitle;
        private Label lblDashboardTitle;
        private Label lblRecentMutations;
        private Label lblInactiveCount;
        private Label lblInactiveStatsTitle;
        private Label lblEmployeeCount;
        private Label lblEmployeeStatsTitle;
        private DataGridView dgvRecentContacts;
        private DataGridView dgvRecentMutations;
        private Label lblRecentCustomers;
    }
}
