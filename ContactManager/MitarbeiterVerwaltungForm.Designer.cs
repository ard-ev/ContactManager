namespace ContactManager
{
    partial class MitarbeiterVerwaltungForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Panel pnlMVHeader;
        private Label lblMVHeaderSubtitle;
        private Label lblMVHeaderTitle;
        private TabControl tabMVHistorie;
        private TabPage tabMVNotizen;
        private DataGridView dgvMVNotizen;
        private Button btnMVNotizHinzufuegen;
        private TextBox txtMVNeueNotiz;
        private Label lblMVNeueNotiz;
        private TabPage tabMVMutationen;
        private DataGridView dgvMVMutationen;
        private Panel pnlMVFooter;
        private Button btnMVSchliessen;

        private void InitializeComponent()
        {
            pnlMVHeader = new Panel();
            lblMVHeaderSubtitle = new Label();
            lblMVHeaderTitle = new Label();
            tabMVHistorie = new TabControl();
            tabMVNotizen = new TabPage();
            dgvMVNotizen = new DataGridView();
            btnMVNotizHinzufuegen = new Button();
            txtMVNeueNotiz = new TextBox();
            lblMVNeueNotiz = new Label();
            tabMVMutationen = new TabPage();
            dgvMVMutationen = new DataGridView();
            pnlMVFooter = new Panel();
            btnMVSchliessen = new Button();
            pnlMVHeader.SuspendLayout();
            tabMVHistorie.SuspendLayout();
            tabMVNotizen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMVNotizen).BeginInit();
            tabMVMutationen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMVMutationen).BeginInit();
            pnlMVFooter.SuspendLayout();
            SuspendLayout();
            //
            // pnlMVHeader
            //
            pnlMVHeader.Controls.Add(lblMVHeaderSubtitle);
            pnlMVHeader.Controls.Add(lblMVHeaderTitle);
            pnlMVHeader.Location = new Point(0, 0);
            pnlMVHeader.Name = "pnlMVHeader";
            pnlMVHeader.Size = new Size(750, 69);
            pnlMVHeader.TabIndex = 0;
            //
            // lblMVHeaderSubtitle
            //
            lblMVHeaderSubtitle.AutoSize = true;
            lblMVHeaderSubtitle.Location = new Point(11, 36);
            lblMVHeaderSubtitle.Name = "lblMVHeaderSubtitle";
            lblMVHeaderSubtitle.Size = new Size(90, 25);
            lblMVHeaderSubtitle.TabIndex = 1;
            lblMVHeaderSubtitle.Text = "Mitarbeiter";
            //
            // lblMVHeaderTitle
            //
            lblMVHeaderTitle.AutoSize = true;
            lblMVHeaderTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMVHeaderTitle.Location = new Point(11, 8);
            lblMVHeaderTitle.Name = "lblMVHeaderTitle";
            lblMVHeaderTitle.Size = new Size(430, 28);
            lblMVHeaderTitle.TabIndex = 0;
            lblMVHeaderTitle.Text = "Mitarbeiterverwaltung - Notizen & Historie";
            //
            // tabMVHistorie
            //
            tabMVHistorie.Controls.Add(tabMVNotizen);
            tabMVHistorie.Controls.Add(tabMVMutationen);
            tabMVHistorie.Location = new Point(0, 69);
            tabMVHistorie.Name = "tabMVHistorie";
            tabMVHistorie.SelectedIndex = 0;
            tabMVHistorie.Size = new Size(750, 481);
            tabMVHistorie.TabIndex = 1;
            //
            // tabMVNotizen
            //
            tabMVNotizen.Controls.Add(dgvMVNotizen);
            tabMVNotizen.Controls.Add(btnMVNotizHinzufuegen);
            tabMVNotizen.Controls.Add(txtMVNeueNotiz);
            tabMVNotizen.Controls.Add(lblMVNeueNotiz);
            tabMVNotizen.Location = new Point(4, 34);
            tabMVNotizen.Name = "tabMVNotizen";
            tabMVNotizen.Padding = new Padding(15);
            tabMVNotizen.Size = new Size(742, 443);
            tabMVNotizen.TabIndex = 0;
            tabMVNotizen.Text = "Notizen";
            tabMVNotizen.UseVisualStyleBackColor = true;
            //
            // dgvMVNotizen
            //
            dgvMVNotizen.AllowUserToAddRows = false;
            dgvMVNotizen.AllowUserToDeleteRows = false;
            dgvMVNotizen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMVNotizen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMVNotizen.Location = new Point(18, 134);
            dgvMVNotizen.MultiSelect = false;
            dgvMVNotizen.Name = "dgvMVNotizen";
            dgvMVNotizen.ReadOnly = true;
            dgvMVNotizen.RowHeadersWidth = 30;
            dgvMVNotizen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMVNotizen.Size = new Size(706, 290);
            dgvMVNotizen.TabIndex = 3;
            //
            // btnMVNotizHinzufuegen
            //
            btnMVNotizHinzufuegen.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMVNotizHinzufuegen.Location = new Point(618, 43);
            btnMVNotizHinzufuegen.Name = "btnMVNotizHinzufuegen";
            btnMVNotizHinzufuegen.Size = new Size(106, 40);
            btnMVNotizHinzufuegen.TabIndex = 2;
            btnMVNotizHinzufuegen.Text = "Hinzufügen";
            btnMVNotizHinzufuegen.UseVisualStyleBackColor = true;
            btnMVNotizHinzufuegen.Click += btnMVNotizHinzufuegen_Click;
            //
            // txtMVNeueNotiz
            //
            txtMVNeueNotiz.Location = new Point(18, 43);
            txtMVNeueNotiz.Multiline = true;
            txtMVNeueNotiz.Name = "txtMVNeueNotiz";
            txtMVNeueNotiz.PlaceholderText = "Notiz zum Mitarbeiter erfassen...";
            txtMVNeueNotiz.Size = new Size(590, 75);
            txtMVNeueNotiz.TabIndex = 1;
            //
            // lblMVNeueNotiz
            //
            lblMVNeueNotiz.AutoSize = true;
            lblMVNeueNotiz.Location = new Point(18, 15);
            lblMVNeueNotiz.Name = "lblMVNeueNotiz";
            lblMVNeueNotiz.Size = new Size(104, 25);
            lblMVNeueNotiz.TabIndex = 0;
            lblMVNeueNotiz.Text = "Neue Notiz:";
            //
            // tabMVMutationen
            //
            tabMVMutationen.Controls.Add(dgvMVMutationen);
            tabMVMutationen.Location = new Point(4, 34);
            tabMVMutationen.Name = "tabMVMutationen";
            tabMVMutationen.Padding = new Padding(15);
            tabMVMutationen.Size = new Size(742, 443);
            tabMVMutationen.TabIndex = 1;
            tabMVMutationen.Text = "Mutationshistorie";
            tabMVMutationen.UseVisualStyleBackColor = true;
            //
            // dgvMVMutationen
            //
            dgvMVMutationen.AllowUserToAddRows = false;
            dgvMVMutationen.AllowUserToDeleteRows = false;
            dgvMVMutationen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMVMutationen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMVMutationen.Location = new Point(18, 18);
            dgvMVMutationen.MultiSelect = false;
            dgvMVMutationen.Name = "dgvMVMutationen";
            dgvMVMutationen.ReadOnly = true;
            dgvMVMutationen.RowHeadersWidth = 30;
            dgvMVMutationen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMVMutationen.Size = new Size(706, 406);
            dgvMVMutationen.TabIndex = 0;
            //
            // pnlMVFooter
            //
            pnlMVFooter.Controls.Add(btnMVSchliessen);
            pnlMVFooter.Location = new Point(0, 550);
            pnlMVFooter.Name = "pnlMVFooter";
            pnlMVFooter.Size = new Size(750, 50);
            pnlMVFooter.TabIndex = 2;
            //
            // btnMVSchliessen
            //
            btnMVSchliessen.Location = new Point(618, 6);
            btnMVSchliessen.Name = "btnMVSchliessen";
            btnMVSchliessen.Size = new Size(121, 34);
            btnMVSchliessen.TabIndex = 0;
            btnMVSchliessen.Text = "Schliessen";
            btnMVSchliessen.UseVisualStyleBackColor = true;
            btnMVSchliessen.Click += btnMVSchliessen_Click;
            //
            // MitarbeiterVerwaltungForm
            //
            ClientSize = new Size(750, 600);
            Controls.Add(tabMVHistorie);
            Controls.Add(pnlMVFooter);
            Controls.Add(pnlMVHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MitarbeiterVerwaltungForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mitarbeiterverwaltung";
            pnlMVHeader.ResumeLayout(false);
            pnlMVHeader.PerformLayout();
            tabMVHistorie.ResumeLayout(false);
            tabMVNotizen.ResumeLayout(false);
            tabMVNotizen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMVNotizen).EndInit();
            tabMVMutationen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMVMutationen).EndInit();
            pnlMVFooter.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}