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
            pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            pnlCustomers.SuspendLayout();
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
            pnlHeader.BackColor = SystemColors.ControlLight;
            pnlHeader.Controls.Add(lblPrg);
            pnlHeader.Controls.Add(lblTitel);
            pnlHeader.Controls.Add(btnEmployee);
            pnlHeader.Controls.Add(btnCustomer);
            pnlHeader.Controls.Add(btnDashboard);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1570, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblPrg
            // 
            lblPrg.AutoSize = true;
            lblPrg.Location = new Point(1377, 45);
            lblPrg.Margin = new Padding(4, 0, 4, 0);
            lblPrg.Name = "lblPrg";
            lblPrg.Size = new Size(99, 25);
            lblPrg.TabIndex = 3;
            lblPrg.Text = "Version 1.0";
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitel.Location = new Point(17, 25);
            lblTitel.Margin = new Padding(4, 0, 4, 0);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(445, 61);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Contact Manager";
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(1031, 32);
            btnEmployee.Margin = new Padding(4, 3, 4, 3);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(216, 50);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "Mitarbeiter";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(746, 32);
            btnCustomer.Margin = new Padding(4, 3, 4, 3);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(216, 50);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Kunden";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(464, 32);
            btnDashboard.Margin = new Padding(4, 3, 4, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(216, 50);
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
            pnlContent.Location = new Point(0, 102);
            pnlContent.Margin = new Padding(4, 3, 4, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1570, 1068);
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
            pnlEmployee.Location = new Point(0, 0);
            pnlEmployee.Margin = new Padding(4, 3, 4, 3);
            pnlEmployee.Name = "pnlEmployee";
            pnlEmployee.Size = new Size(1570, 1068);
            pnlEmployee.TabIndex = 1;
            pnlEmployee.Paint += pnlEmployee_Paint;
            // 
            // dgvEmployees
            // 
            dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;  
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(64, 178);
            dgvEmployees.Margin = new Padding(4, 3, 4, 3);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersWidth = 62;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(1429, 770);
            dgvEmployees.TabIndex = 8;
            dgvEmployees.CellContentClick += dgvEmployees_CellContentClick;
            dgvEmployees.CellDoubleClick += dgvEmployees_CellDoubleClick;
            // 
            // btnEmployeeDelete
            // 
            btnEmployeeDelete.Location = new Point(1334, 110);
            btnEmployeeDelete.Margin = new Padding(4, 3, 4, 3);
            btnEmployeeDelete.Name = "btnEmployeeDelete";
            btnEmployeeDelete.Size = new Size(159, 38);
            btnEmployeeDelete.TabIndex = 7;
            btnEmployeeDelete.Text = "Löschen";
            btnEmployeeDelete.UseVisualStyleBackColor = true;
            btnEmployeeDelete.Click += btnEmployeeDelete_Click;
            // 
            // btnEmployeeEdit
            // 
            btnEmployeeEdit.Location = new Point(1167, 110);
            btnEmployeeEdit.Margin = new Padding(4, 3, 4, 3);
            btnEmployeeEdit.Name = "btnEmployeeEdit";
            btnEmployeeEdit.Size = new Size(159, 38);
            btnEmployeeEdit.TabIndex = 6;
            btnEmployeeEdit.Text = "Bearbeiten";
            btnEmployeeEdit.UseVisualStyleBackColor = true;
            btnEmployeeEdit.Click += btnEmployeeEdit_Click;
            // 
            // btnEmployeeAdd
            // 
            btnEmployeeAdd.Location = new Point(1000, 108);
            btnEmployeeAdd.Margin = new Padding(4, 3, 4, 3);
            btnEmployeeAdd.Name = "btnEmployeeAdd";
            btnEmployeeAdd.Size = new Size(159, 38);
            btnEmployeeAdd.TabIndex = 5;
            btnEmployeeAdd.Text = "Neuer Mitarbeiter";
            btnEmployeeAdd.UseVisualStyleBackColor = true;
            btnEmployeeAdd.Click += btnEmployeeAdd_Click;
            // 
            // btnEmployeeSearch
            // 
            btnEmployeeSearch.Location = new Point(510, 110);
            btnEmployeeSearch.Margin = new Padding(4, 3, 4, 3);
            btnEmployeeSearch.Name = "btnEmployeeSearch";
            btnEmployeeSearch.Size = new Size(86, 38);
            btnEmployeeSearch.TabIndex = 4;
            btnEmployeeSearch.Text = "Suchen";
            btnEmployeeSearch.UseVisualStyleBackColor = true;
            btnEmployeeSearch.Click += btnEmployeeSearch_Click;
            // 
            // txtEmployeSearch
            // 
            txtEmployeSearch.Location = new Point(237, 110);
            txtEmployeSearch.Margin = new Padding(4, 3, 4, 3);
            txtEmployeSearch.Name = "txtEmployeSearch";
            txtEmployeSearch.Size = new Size(257, 31);
            txtEmployeSearch.TabIndex = 3;
            // 
            // lblEmployeeSearch
            // 
            lblEmployeeSearch.AutoSize = true;
            lblEmployeeSearch.Location = new Point(67, 117);
            lblEmployeeSearch.Margin = new Padding(4, 0, 4, 0);
            lblEmployeeSearch.Name = "lblEmployeeSearch";
            lblEmployeeSearch.Size = new Size(162, 25);
            lblEmployeeSearch.TabIndex = 2;
            lblEmployeeSearch.Text = "Mitarbeiter suchen:";
            // 
            // lblEmployeeSubtitle
            // 
            lblEmployeeSubtitle.AutoSize = true;
            lblEmployeeSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeSubtitle.Location = new Point(261, 45);
            lblEmployeeSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblEmployeeSubtitle.Name = "lblEmployeeSubtitle";
            lblEmployeeSubtitle.Size = new Size(337, 28);
            lblEmployeeSubtitle.TabIndex = 1;
            lblEmployeeSubtitle.Text = "Mitarbeiter verwalten und bearbeiten";
            // 
            // lblEmployeeTitle
            //
            lblEmployeeTitle.AutoSize = true;
            lblEmployeeTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeTitle.Location = new Point(17, 18);
            lblEmployeeTitle.Margin = new Padding(4, 0, 4, 0);
            lblEmployeeTitle.Name = "lblEmployeeTitle";
            lblEmployeeTitle.Size = new Size(242, 55);
            lblEmployeeTitle.TabIndex = 0;
            lblEmployeeTitle.Text = "Mitarbeiter";
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
            pnlCustomers.Margin = new Padding(4, 5, 4, 5);
            pnlCustomers.Name = "pnlCustomers";
            pnlCustomers.Size = new Size(1570, 962);
            pnlCustomers.TabIndex = 3;
            // 
            // dgvCustomers
            //
            dgvCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;  
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(64, 178);
            dgvCustomers.Margin = new Padding(4, 5, 4, 5);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 62;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(1429, 770);
            dgvCustomers.TabIndex = 8;
            dgvCustomers.CellDoubleClick += dgvCustomers_CellDoubleClick;
            // 
            // btnCustomerDel
            // 
            btnCustomerDel.Location = new Point(1334, 110);
            btnCustomerDel.Margin = new Padding(4, 5, 4, 5);
            btnCustomerDel.Name = "btnCustomerDel";
            btnCustomerDel.Size = new Size(159, 38);
            btnCustomerDel.TabIndex = 7;
            btnCustomerDel.Text = "Löschen";
            btnCustomerDel.UseVisualStyleBackColor = true;
            btnCustomerDel.Click += btnCustomerDel_Click;
            // 
            // btnCustomerEdit
            // 
            btnCustomerEdit.Location = new Point(1167, 110);
            btnCustomerEdit.Margin = new Padding(4, 5, 4, 5);
            btnCustomerEdit.Name = "btnCustomerEdit";
            btnCustomerEdit.Size = new Size(159, 38);
            btnCustomerEdit.TabIndex = 6;
            btnCustomerEdit.Text = "Bearbeiten";
            btnCustomerEdit.UseVisualStyleBackColor = true;
            btnCustomerEdit.Click += btnCustomerEdit_Click;
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.Location = new Point(1000, 108);
            btnCustomerAdd.Margin = new Padding(4, 5, 4, 5);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new Size(159, 38);
            btnCustomerAdd.TabIndex = 5;
            btnCustomerAdd.Text = "Neuer Kunde";
            btnCustomerAdd.UseVisualStyleBackColor = true;
            btnCustomerAdd.Click += btnCustomerAdd_Click_1;
            // 
            // btnCustomerSearch
            // 
            btnCustomerSearch.Location = new Point(510, 110);
            btnCustomerSearch.Margin = new Padding(4, 5, 4, 5);
            btnCustomerSearch.Name = "btnCustomerSearch";
            btnCustomerSearch.Size = new Size(86, 38);
            btnCustomerSearch.TabIndex = 4;
            btnCustomerSearch.Text = "Suchen";
            btnCustomerSearch.UseVisualStyleBackColor = true;
            btnCustomerSearch.Click += btnCustomerSearch_Click;
            // 
            // txtCustomerSearch
            // 
            txtCustomerSearch.Location = new Point(237, 110);
            txtCustomerSearch.Margin = new Padding(4, 5, 4, 5);
            txtCustomerSearch.Name = "txtCustomerSearch";
            txtCustomerSearch.Size = new Size(257, 31);
            txtCustomerSearch.TabIndex = 3;
            // 
            // lblCustomerSearch
            // 
            lblCustomerSearch.AutoSize = true;
            lblCustomerSearch.Location = new Point(67, 117);
            lblCustomerSearch.Margin = new Padding(4, 0, 4, 0);
            lblCustomerSearch.Name = "lblCustomerSearch";
            lblCustomerSearch.Size = new Size(126, 25);
            lblCustomerSearch.TabIndex = 2;
            lblCustomerSearch.Text = "Kunde suchen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(277, 25);
            label2.TabIndex = 1;
            label2.Text = "Kunden verwalten und bearbeiten";
            // 
            // lblCustomersTitle
            // 
            lblCustomersTitle.AutoSize = true;
            lblCustomersTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomersTitle.Location = new Point(17, 25);
            lblCustomersTitle.Margin = new Padding(4, 0, 4, 0);
            lblCustomersTitle.Name = "lblCustomersTitle";
            lblCustomersTitle.Size = new Size(173, 55);
            lblCustomersTitle.TabIndex = 0;
            lblCustomersTitle.Text = "Kunden";
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
            pnlDashboard.Margin = new Padding(4, 5, 4, 5);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1570, 1170);
            pnlDashboard.TabIndex = 2;
            // 
            // lblRecentCustomers
            // 
            lblRecentCustomers.AutoSize = true;
            lblRecentCustomers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentCustomers.Location = new Point(29, 635);
            lblRecentCustomers.Margin = new Padding(4, 0, 4, 0);
            lblRecentCustomers.Name = "lblRecentCustomers";
            lblRecentCustomers.Size = new Size(285, 32);
            lblRecentCustomers.TabIndex = 9;
            lblRecentCustomers.Text = "Letzte Kundenkontakte:";
            // 
            // dgvRecentMutations
            // 
            dgvRecentMutations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecentMutations.AllowUserToAddRows = false;
            dgvRecentMutations.AllowUserToDeleteRows = false;
            dgvRecentMutations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentMutations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentMutations.Location = new Point(17, 352);
            dgvRecentMutations.Margin = new Padding(4, 5, 4, 5);
            dgvRecentMutations.Name = "dgvRecentMutations";
            dgvRecentMutations.RowHeadersWidth = 62;
            dgvRecentMutations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentMutations.Size = new Size(1536, 250);
            dgvRecentMutations.TabIndex = 8;
            // 
            // dgvRecentContacts
            // 
            dgvRecentContacts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecentContacts.AllowUserToAddRows = false;
            dgvRecentContacts.AllowUserToDeleteRows = false;
            dgvRecentContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentContacts.Location = new Point(17, 698);
            dgvRecentContacts.Margin = new Padding(4, 5, 4, 5);
            dgvRecentContacts.MultiSelect = false;
            dgvRecentContacts.Name = "dgvRecentContacts";
            dgvRecentContacts.ReadOnly = true;
            dgvRecentContacts.RowHeadersWidth = 62;
            dgvRecentContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentContacts.Size = new Size(1536, 250);
            dgvRecentContacts.TabIndex = 7;
            // 
            // lblRecentMutations
            // 
            lblRecentMutations.AutoSize = true;
            lblRecentMutations.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentMutations.Location = new Point(17, 312);
            lblRecentMutations.Margin = new Padding(4, 0, 4, 0);
            lblRecentMutations.Name = "lblRecentMutations";
            lblRecentMutations.Size = new Size(230, 32);
            lblRecentMutations.TabIndex = 4;
            lblRecentMutations.Text = "Letzte Mutationen:";
            // 
            // pnlInactiveStats
            // 
            pnlInactiveStats.BorderStyle = BorderStyle.FixedSingle;
            pnlInactiveStats.Controls.Add(lblInactiveCount);
            pnlInactiveStats.Controls.Add(lblInactiveStatsTitle);
            pnlInactiveStats.Location = new Point(1100, 117);
            pnlInactiveStats.Margin = new Padding(4, 5, 4, 5);
            pnlInactiveStats.Name = "pnlInactiveStats";
            pnlInactiveStats.Size = new Size(285, 165);
            pnlInactiveStats.TabIndex = 3;
            // 
            // lblInactiveCount
            // 
            lblInactiveCount.AutoSize = true;
            lblInactiveCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInactiveCount.Location = new Point(114, 60);
            lblInactiveCount.Margin = new Padding(4, 0, 4, 0);
            lblInactiveCount.Name = "lblInactiveCount";
            lblInactiveCount.Size = new Size(50, 60);
            lblInactiveCount.TabIndex = 1;
            lblInactiveCount.Text = "0";
            // 
            // lblInactiveStatsTitle
            // 
            lblInactiveStatsTitle.AutoSize = true;
            lblInactiveStatsTitle.Location = new Point(66, 5);
            lblInactiveStatsTitle.Margin = new Padding(4, 0, 4, 0);
            lblInactiveStatsTitle.Name = "lblInactiveStatsTitle";
            lblInactiveStatsTitle.Size = new Size(144, 25);
            lblInactiveStatsTitle.TabIndex = 0;
            lblInactiveStatsTitle.Text = "Inaktive Objekte:";
            // 
            // pnlEmployeeStats
            // 
            pnlEmployeeStats.BorderStyle = BorderStyle.FixedSingle;
            pnlEmployeeStats.Controls.Add(lblEmployeeCount);
            pnlEmployeeStats.Controls.Add(lblEmployeeStatsTitle);
            pnlEmployeeStats.Location = new Point(611, 117);
            pnlEmployeeStats.Margin = new Padding(4, 5, 4, 5);
            pnlEmployeeStats.Name = "pnlEmployeeStats";
            pnlEmployeeStats.Size = new Size(285, 165);
            pnlEmployeeStats.TabIndex = 2;
            // 
            // lblEmployeeCount
            // 
            lblEmployeeCount.AutoSize = true;
            lblEmployeeCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeCount.Location = new Point(116, 60);
            lblEmployeeCount.Margin = new Padding(4, 0, 4, 0);
            lblEmployeeCount.Name = "lblEmployeeCount";
            lblEmployeeCount.Size = new Size(50, 60);
            lblEmployeeCount.TabIndex = 1;
            lblEmployeeCount.Text = "0";
            // 
            // lblEmployeeStatsTitle
            // 
            lblEmployeeStatsTitle.AutoSize = true;
            lblEmployeeStatsTitle.Location = new Point(56, 5);
            lblEmployeeStatsTitle.Margin = new Padding(4, 0, 4, 0);
            lblEmployeeStatsTitle.Name = "lblEmployeeStatsTitle";
            lblEmployeeStatsTitle.Size = new Size(170, 25);
            lblEmployeeStatsTitle.TabIndex = 0;
            lblEmployeeStatsTitle.Text = "Aktuelle Mitarbeiter:";
            // 
            // pnlCustomerStats
            // 
            pnlCustomerStats.BorderStyle = BorderStyle.FixedSingle;
            pnlCustomerStats.Controls.Add(lblCustomerCount);
            pnlCustomerStats.Controls.Add(lblCustomerStatsTitle);
            pnlCustomerStats.Location = new Point(123, 117);
            pnlCustomerStats.Margin = new Padding(4, 5, 4, 5);
            pnlCustomerStats.Name = "pnlCustomerStats";
            pnlCustomerStats.Size = new Size(285, 165);
            pnlCustomerStats.TabIndex = 1;
            // 
            // lblCustomerCount
            // 
            lblCustomerCount.AutoSize = true;
            lblCustomerCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerCount.Location = new Point(113, 60);
            lblCustomerCount.Margin = new Padding(4, 0, 4, 0);
            lblCustomerCount.Name = "lblCustomerCount";
            lblCustomerCount.Size = new Size(50, 60);
            lblCustomerCount.TabIndex = 1;
            lblCustomerCount.Text = "0";
            // 
            // lblCustomerStatsTitle
            // 
            lblCustomerStatsTitle.AutoSize = true;
            lblCustomerStatsTitle.Location = new Point(66, 5);
            lblCustomerStatsTitle.Margin = new Padding(4, 0, 4, 0);
            lblCustomerStatsTitle.Name = "lblCustomerStatsTitle";
            lblCustomerStatsTitle.Size = new Size(144, 25);
            lblCustomerStatsTitle.TabIndex = 0;
            lblCustomerStatsTitle.Text = "Aktuelle Kunden:";
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.Location = new Point(17, 22);
            lblDashboardTitle.Margin = new Padding(4, 0, 4, 0);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(232, 55);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "Dashboard";
            // 
            // ContactManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 1062);
            Controls.Add(pnlHeader);
            Controls.Add(pnlContent);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ContactManager";
            Text = "Contact Manager";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlEmployee.ResumeLayout(false);
            pnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            pnlCustomers.ResumeLayout(false);
            pnlCustomers.PerformLayout();
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
