using ContactManager.Data;
using ContactManager.Services;
using ContactManager.Models;



namespace ContactManager
{
    public partial class ContactManager : Form
    {

        //Das gemeinsame Repository für die ganze Anwendung (kümmert sich ums Speichern/Laden)
        private readonly Repository _repository = new();

        // Die Kundenverwaltung arbeitet auf demselben Repository
        private readonly KundenVerwaltung _kundenVerwaltung;
        public ContactManager()
        {
            InitializeComponent();

            //Daten beim Start von der Festplatte lesen
            _repository.Load();

            //Verwaltung mit dem geladenen Repository verbinden
            _kundenVerwaltung = new KundenVerwaltung(_repository);
            // Gespeicherte Kunden beim Start anzeigen
            KundenAnzeigen();

            // Enter im Suchfeld löst die Suche aus
            txtCustomerSearch.KeyDown += TxtCustomerSearch_KeyDown;


            pnlDashboard.BringToFront();  //Bringt das Dashboard Panel in den Vordergrund, wenn die Anwendung gestartet wird
            SetActiveNAvigationButton(btnDashboard);  // Setzt den Dashboard-Button als aktiv, wenn die Anwendung gestartet wird
        }

        /// <summary>
        /// Lädt alle gespeicherten Kunden ins Kunden-Grid.
        /// </summary>
        private void KundenAnzeigen()
        {
            // Erst leeren, dann neu setzen, damit das Grid sicher aktualisiert
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = _kundenVerwaltung.Alle.ToList();
        }

        // Methode zum Setzen des aktiven Navigationsbuttons
        private void SetActiveNAvigationButton(Button activeButton)
        {
            btnDashboard.BackColor = Color.White;
            btnCustomer.BackColor = Color.White;
            btnEmployee.BackColor = Color.White;
            activeButton.BackColor = Color.LightBlue;
        }

        //Event für Panel Dashboard aufzeigen
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlDashboard.BringToFront();
            SetActiveNAvigationButton(btnDashboard);
        }


        //Event für Panel Kunden aufzeigen
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlCustomers.BringToFront();
            SetActiveNAvigationButton(btnCustomer);
        }


        //Event für Panel Mitarbeiter aufzeigen
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pnlEmployee.BringToFront();
            SetActiveNAvigationButton(btnEmployee);
        }


        //Event für Maske öffnen (Mitarbeiter erstellen
        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            MitarbeiterForm mitarbeiterForm = new MitarbeiterForm();
            mitarbeiterForm.ShowDialog();
        }


        //Event für Maske öffnen (Kunde erstellen)

        private void btnCustomerAdd_Click_1(object sender, EventArgs e)
        {
            // Formular öffnen und ihm die gemeinsame Kundenverwaltung mitgeben
            KundenForm kundenForm = new KundenForm(_kundenVerwaltung);
            kundenForm.ShowDialog();

            // Nach dem Schliessen die Liste aktualisieren, damit neue Kunden erscheinen
            KundenAnzeigen();
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            KundenSuchen();
        }

        /// <summary>
        /// Führt die Kundensuche aus und zeigt das Ergebnis im Grid an.
        /// Wird vom Suchen-Button und von der Enter-Taste im Suchfeld genutzt.
        /// </summary>
        private void KundenSuchen()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = _kundenVerwaltung.Suchen(txtCustomerSearch.Text);
        }
        /// <summary>
        /// Löst die Suche aus, wenn im Suchfeld die Enter-Taste gedrückt wird.
        /// </summary>
        private void TxtCustomerSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KundenSuchen();
                e.SuppressKeyPress = true; // verhindert das "Ding"-Geräusch von Windows
            }
        }

        private void btnCustomerDel_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow?.DataBoundItem is not Kunde ausgewaehlterKunde)
            {
                MessageBox.Show("Bitte wählen Sie zuerst einen Kunden in der Liste aus");
                return;
            }

            var ergebnis = MessageBox.Show(
                $"Soll {ausgewaehlterKunde.Vorname} {ausgewaehlterKunde.Nachname} wirklich gelöscht werden?",
                "Kunde löschen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (ergebnis != DialogResult.Yes)
                return;

            _kundenVerwaltung.Loeschen(ausgewaehlterKunde);
            _kundenVerwaltung.Speichern();
            KundenAnzeigen();
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AusgewaehltenKundenBearbeiten();
        }

        private void btnCustomerEdit_Click(object sender, EventArgs e)
        {
            AusgewaehltenKundenBearbeiten();
        }

        /// <summary>
        /// Öffnet den ausgewählten Kunden im Bearbeiten-Modus. Wird sowohl vom
        /// Doppelklick auf die Tabelle als auch vom "Bearbeiten"-Button aufgerufen,
        /// damit die Logik nicht doppelt gepflegt werden muss.
        /// </summary>
        private void AusgewaehltenKundenBearbeiten()
        {
            if (dgvCustomers.CurrentRow?.DataBoundItem is not Kunde ausgewaehlterKunde)
            {
                MessageBox.Show("Bitte wählen Sie zuerst einen Kunden in der Liste aus.");
                return;
            }

            KundenForm kundenForm = new KundenForm(_kundenVerwaltung, ausgewaehlterKunde);
            kundenForm.ShowDialog();
            KundenAnzeigen();
        }
    }
}