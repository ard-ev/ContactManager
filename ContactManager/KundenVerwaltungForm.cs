using ContactManager.Models;
using ContactManager.Services;

namespace ContactManager
{
    /// <summary>
    /// Zeigt zu einem einzelnen Kunden das Protokoll seiner Notizen (Kontakthistorie)
    /// sowie die Mutationshistorie (alle nachvollziehbaren Änderungen an den
    /// Stammdaten). Über dieses Formular können ausserdem neue Notizen erfasst werden.
    /// </summary>
    public partial class KundenVerwaltungForm : Form
    {
        private readonly KundenVerwaltung _kundenVerwaltung;
        private readonly Kunde _kunde;

        public KundenVerwaltungForm(KundenVerwaltung kundenVerwaltung, Kunde kunde)
        {
            InitializeComponent();
            _kundenVerwaltung = kundenVerwaltung;
            _kunde = kunde;

            lblKVHeaderSubtitle.Text = $"{_kunde.Vorname} {_kunde.Nachname} (Kundennummer: {_kunde.KundenNummer})";

            NotizenLaden();
            MutationenLaden();
        }

        /// <summary>Lädt das Notizen-Protokoll (Kontakthistorie) des Kunden neu ins Grid.</summary>
        private void NotizenLaden()
        {
            dgvKVNotizen.DataSource = null;
            dgvKVNotizen.DataSource = _kundenVerwaltung.Kontakthistorie(_kunde)
                .Select(k => new
                {
                    Datum = k.KontaktDatum.ToString("dd.MM.yyyy HH:mm"),
                    Notiz = k.Notizen
                })
                .ToList();

            if (dgvKVNotizen.Columns["Datum"] != null)
                dgvKVNotizen.Columns["Datum"].FillWeight = 30;
        }

        /// <summary>Lädt die Mutationshistorie des Kunden neu ins Grid.</summary>
        private void MutationenLaden()
        {
            dgvKVMutationen.DataSource = null;
            dgvKVMutationen.DataSource = _kundenVerwaltung.Mutationshistorie(_kunde)
                .Select(m => new
                {
                    Datum = m.Zeitpunkt.ToString("dd.MM.yyyy HH:mm"),
                    Feld = m.Feld,
                    AlterWert = string.IsNullOrWhiteSpace(m.AlterWert) ? "-" : m.AlterWert,
                    NeuerWert = string.IsNullOrWhiteSpace(m.NeuerWert) ? "-" : m.NeuerWert
                })
                .ToList();

            if (dgvKVMutationen.Columns["Datum"] != null)
                dgvKVMutationen.Columns["Datum"].FillWeight = 25;
        }

        /// <summary>Event-Handler: neue Notiz erfassen und Protokoll aktualisieren.</summary>
        private void btnKVNotizHinzufuegen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKVNeueNotiz.Text))
            {
                MessageBox.Show("Bitte eine Notiz eingeben.");
                return;
            }

            _kundenVerwaltung.NotizHinzufuegen(_kunde, txtKVNeueNotiz.Text);
            txtKVNeueNotiz.Clear();
            NotizenLaden();
        }

        /// <summary>Event-Handler für den Schliessen-Button.</summary>
        private void btnKVSchliessen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InitializeComponent()
        {
            pnlKVHeader = new Panel();
            lblKVHeaderSubtitle = new Label();
            lblKVHeaderTitle = new Label();
            tabKVHistorie = new TabControl();
            tabKVNotizen = new TabPage();
            dgvKVNotizen = new DataGridView();
            btnKVNotizHinzufuegen = new Button();
            txtKVNeueNotiz = new TextBox();
            lblKVNeueNotiz = new Label();
            tabKVMutationen = new TabPage();
            dgvKVMutationen = new DataGridView();
            pnlKVFooter = new Panel();
            btnKVSchliessen = new Button();
            pnlKVHeader.SuspendLayout();
            tabKVHistorie.SuspendLayout();
            tabKVNotizen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKVNotizen).BeginInit();
            tabKVMutationen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKVMutationen).BeginInit();
            pnlKVFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlKVHeader
            // 
            pnlKVHeader.Controls.Add(lblKVHeaderSubtitle);
            pnlKVHeader.Controls.Add(lblKVHeaderTitle);
            pnlKVHeader.Location = new Point(0, 0);
            pnlKVHeader.Name = "pnlKVHeader";
            pnlKVHeader.Size = new Size(750, 69);
            pnlKVHeader.TabIndex = 0;
            // 
            // lblKVHeaderSubtitle
            // 
            lblKVHeaderSubtitle.AutoSize = true;
            lblKVHeaderSubtitle.Location = new Point(11, 36);
            lblKVHeaderSubtitle.Name = "lblKVHeaderSubtitle";
            lblKVHeaderSubtitle.Size = new Size(62, 25);
            lblKVHeaderSubtitle.TabIndex = 1;
            lblKVHeaderSubtitle.Text = "Kunde";
            // 
            // lblKVHeaderTitle
            // 
            lblKVHeaderTitle.AutoSize = true;
            lblKVHeaderTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKVHeaderTitle.Location = new Point(11, 8);
            lblKVHeaderTitle.Name = "lblKVHeaderTitle";
            lblKVHeaderTitle.Size = new Size(374, 28);
            lblKVHeaderTitle.TabIndex = 0;
            lblKVHeaderTitle.Text = "Kundenverwaltung - Notizen & Historie";
            // 
            // tabKVHistorie
            // 
            tabKVHistorie.Controls.Add(tabKVNotizen);
            tabKVHistorie.Controls.Add(tabKVMutationen);
            tabKVHistorie.Location = new Point(0, 69);
            tabKVHistorie.Name = "tabKVHistorie";
            tabKVHistorie.SelectedIndex = 0;
            tabKVHistorie.Size = new Size(750, 481);
            tabKVHistorie.TabIndex = 1;
            // 
            // tabKVNotizen
            // 
            tabKVNotizen.Controls.Add(dgvKVNotizen);
            tabKVNotizen.Controls.Add(btnKVNotizHinzufuegen);
            tabKVNotizen.Controls.Add(txtKVNeueNotiz);
            tabKVNotizen.Controls.Add(lblKVNeueNotiz);
            tabKVNotizen.Location = new Point(4, 34);
            tabKVNotizen.Name = "tabKVNotizen";
            tabKVNotizen.Padding = new Padding(15);
            tabKVNotizen.Size = new Size(742, 443);
            tabKVNotizen.TabIndex = 0;
            tabKVNotizen.Text = "Notizen";
            tabKVNotizen.UseVisualStyleBackColor = true;
            // 
            // dgvKVNotizen
            // 
            dgvKVNotizen.AllowUserToAddRows = false;
            dgvKVNotizen.AllowUserToDeleteRows = false;
            dgvKVNotizen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKVNotizen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKVNotizen.Location = new Point(18, 134);
            dgvKVNotizen.MultiSelect = false;
            dgvKVNotizen.Name = "dgvKVNotizen";
            dgvKVNotizen.ReadOnly = true;
            dgvKVNotizen.RowHeadersWidth = 30;
            dgvKVNotizen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKVNotizen.Size = new Size(706, 290);
            dgvKVNotizen.TabIndex = 3;
            // 
            // btnKVNotizHinzufuegen
            // 
            btnKVNotizHinzufuegen.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKVNotizHinzufuegen.Location = new Point(618, 43);
            btnKVNotizHinzufuegen.Name = "btnKVNotizHinzufuegen";
            btnKVNotizHinzufuegen.Size = new Size(106, 40);
            btnKVNotizHinzufuegen.TabIndex = 2;
            btnKVNotizHinzufuegen.Text = "Hinzufügen";
            btnKVNotizHinzufuegen.UseVisualStyleBackColor = true;
            btnKVNotizHinzufuegen.Click += btnKVNotizHinzufuegen_Click;
            // 
            // txtKVNeueNotiz
            // 
            txtKVNeueNotiz.Location = new Point(18, 43);
            txtKVNeueNotiz.Multiline = true;
            txtKVNeueNotiz.Name = "txtKVNeueNotiz";
            txtKVNeueNotiz.PlaceholderText = "Notiz zum Kunden erfassen...";
            txtKVNeueNotiz.Size = new Size(590, 75);
            txtKVNeueNotiz.TabIndex = 1;
            // 
            // lblKVNeueNotiz
            // 
            lblKVNeueNotiz.AutoSize = true;
            lblKVNeueNotiz.Location = new Point(18, 15);
            lblKVNeueNotiz.Name = "lblKVNeueNotiz";
            lblKVNeueNotiz.Size = new Size(104, 25);
            lblKVNeueNotiz.TabIndex = 0;
            lblKVNeueNotiz.Text = "Neue Notiz:";
            // 
            // tabKVMutationen
            // 
            tabKVMutationen.Controls.Add(dgvKVMutationen);
            tabKVMutationen.Location = new Point(4, 34);
            tabKVMutationen.Name = "tabKVMutationen";
            tabKVMutationen.Padding = new Padding(15);
            tabKVMutationen.Size = new Size(742, 443);
            tabKVMutationen.TabIndex = 1;
            tabKVMutationen.Text = "Mutationshistorie";
            tabKVMutationen.UseVisualStyleBackColor = true;
            // 
            // dgvKVMutationen
            // 
            dgvKVMutationen.AllowUserToAddRows = false;
            dgvKVMutationen.AllowUserToDeleteRows = false;
            dgvKVMutationen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKVMutationen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKVMutationen.Location = new Point(18, 18);
            dgvKVMutationen.MultiSelect = false;
            dgvKVMutationen.Name = "dgvKVMutationen";
            dgvKVMutationen.ReadOnly = true;
            dgvKVMutationen.RowHeadersWidth = 30;
            dgvKVMutationen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKVMutationen.Size = new Size(706, 406);
            dgvKVMutationen.TabIndex = 0;
            // 
            // pnlKVFooter
            // 
            pnlKVFooter.Controls.Add(btnKVSchliessen);
            pnlKVFooter.Location = new Point(0, 550);
            pnlKVFooter.Name = "pnlKVFooter";
            pnlKVFooter.Size = new Size(750, 50);
            pnlKVFooter.TabIndex = 2;
            // 
            // btnKVSchliessen
            // 
            btnKVSchliessen.Location = new Point(618, 6);
            btnKVSchliessen.Name = "btnKVSchliessen";
            btnKVSchliessen.Size = new Size(121, 34);
            btnKVSchliessen.TabIndex = 0;
            btnKVSchliessen.Text = "Schliessen";
            btnKVSchliessen.UseVisualStyleBackColor = true;
            btnKVSchliessen.Click += btnKVSchliessen_Click;
            // 
            // KundenVerwaltungForm
            // 
            ClientSize = new Size(750, 600);
            Controls.Add(tabKVHistorie);
            Controls.Add(pnlKVFooter);
            Controls.Add(pnlKVHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "KundenVerwaltungForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kundenverwaltung";
            pnlKVHeader.ResumeLayout(false);
            pnlKVHeader.PerformLayout();
            tabKVHistorie.ResumeLayout(false);
            tabKVNotizen.ResumeLayout(false);
            tabKVNotizen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKVNotizen).EndInit();
            tabKVMutationen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKVMutationen).EndInit();
            pnlKVFooter.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}