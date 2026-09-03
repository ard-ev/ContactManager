using ContactManager.Data;
using ContactManager.Services;
using ContactManager.Models;
using System.Linq;
using System.Collections.Generic;



namespace ContactManager
{
    public partial class ContactManager : Form
    {

        //Das gemeinsame Repository für die ganze Anwendung (kümmert sich ums Speichern/Laden)
        private readonly Repository _repository = new();

        // Die Kundenverwaltung arbeitet auf demselben Repository
        private readonly KundenVerwaltung _kundenVerwaltung;

        // Verwaltung für die Mitarbeiter (arbeitet auf demselben Repository)
        private readonly MitarbeiterVerwaltung _mitarbeiterVerwaltung;

        public ContactManager()
        {
            InitializeComponent();

            //Daten beim Start von der Festplatte lesen
            _repository.Load();

            //Verwaltung mit dem geladenen Kunden Repository verbinden
            _kundenVerwaltung = new KundenVerwaltung(_repository);

            //Verwaltung mit dem geladenen Mitarbeiter Repository verbinden
            _mitarbeiterVerwaltung = new MitarbeiterVerwaltung(_repository);

            // Enter im Suchfeld löst die Suche aus
            txtCustomerSearch.KeyDown += TxtCustomerSearch_KeyDown;
            dgvCustomers.ColumnHeaderMouseClick += dgvCustomers_ColumnHeaderMouseClick;
            dgvEmployees.ColumnHeaderMouseClick += dgvEmployees_ColumnHeaderMouseClick;
            txtEmployeSearch.KeyDown += TxtEmployeeSearch_KeyDown;

            pnlDashboard.BringToFront();  //Bringt das Dashboard Panel in den Vordergrund, wenn die Anwendung gestartet wird
            SetActiveNAvigationButton(btnDashboard);  // Setzt den Dashboard-Button als aktiv, wenn die Anwendung gestartet wird
            // Gespeicherte Kunden beim Start anzeigen
            KundenAnzeigen();
            // Gespeicherte Mitarbeiter beim Start anzeigen
            MitarbeiterAnzeigen();
        }

        private bool _kundenSortAufsteigend = true;

        private void dgvCustomers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string spalte = dgvCustomers.Columns[e.ColumnIndex].Name;

            IEnumerable<Kunde> sortiert = spalte switch
            {
                nameof(Kunde.Nachname) => _kundenSortAufsteigend
                    ? _kundenVerwaltung.Alle.OrderBy(k => k.Nachname)
                    : _kundenVerwaltung.Alle.OrderByDescending(k => k.Nachname),
                nameof(Kunde.Vorname) => _kundenSortAufsteigend
                    ? _kundenVerwaltung.Alle.OrderBy(k => k.Vorname)
                    : _kundenVerwaltung.Alle.OrderByDescending(k => k.Vorname),
                nameof(Kunde.Geburtsdatum) => _kundenSortAufsteigend
                    ? _kundenVerwaltung.Alle.OrderBy(k => k.Geburtsdatum)
                    : _kundenVerwaltung.Alle.OrderByDescending(k => k.Geburtsdatum),
                nameof(Kunde.Status) => _kundenSortAufsteigend
                    ? _kundenVerwaltung.Alle.OrderBy(k => k.Status)
                    : _kundenVerwaltung.Alle.OrderByDescending(k => k.Status),
                _ => _kundenVerwaltung.Alle
            };

            dgvCustomers.DataSource = sortiert.ToList();
            _kundenSortAufsteigend = !_kundenSortAufsteigend;
        }

        /// <summary>
        /// Lädt alle gespeicherten Kunden ins Kunden-Grid.
        /// </summary>
        private void KundenAnzeigen()
        {
            // Erst leeren, dann neu setzen, damit das Grid sicher aktualisiert
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = _kundenVerwaltung.Alle.ToList();
            DashboardAktualisieren(); //<- Vorher in jeder Zeile aufgerufen. Jetzt über Methode direkt mit drin.
        }

        /// <summary>Lädt alle gespeicherten Mitarbeiter ins Mitarbeiter-Grid.</summary>
        private void MitarbeiterAnzeigen()
        {
            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = _mitarbeiterVerwaltung.Alle.ToList();
            DashboardAktualisieren();
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
            // Formular öffnen und ihm die gemeinsame Mitarbeiterverwaltung mitgeben
            MitarbeiterForm mitarbeiterForm = new MitarbeiterForm(_mitarbeiterVerwaltung);
            mitarbeiterForm.ShowDialog();
            MitarbeiterAnzeigen();
        }
        private void btnEmployeeSearch_Click(object sender, EventArgs e)
        {
            MitarbeiterSuchen();
        }

        private void MitarbeiterSuchen()
        {
            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = _mitarbeiterVerwaltung.Suchen(txtEmployeSearch.Text);
        }

        private void TxtEmployeeSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MitarbeiterSuchen();
                e.SuppressKeyPress = true;
            }
        }

        //Event für Maske öffnen (Kunde erstellen)

        private void btnCustomerAdd_Click_1(object sender, EventArgs e)
        {
            // Formular öffnen und ihm die gemeinsame Kundenverwaltung mitgeben
            KundenForm kundenForm = new KundenForm(_kundenVerwaltung, _mitarbeiterVerwaltung);
            kundenForm.ShowDialog();
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

            KundenForm kundenForm = new KundenForm(_kundenVerwaltung, _mitarbeiterVerwaltung, ausgewaehlterKunde);
            kundenForm.ShowDialog();
            KundenAnzeigen();
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AusgewaehltenMitarbeiterBearbeiten();
        }

        private void btnEmployeeEdit_Click(object sender, EventArgs e)
        {
            AusgewaehltenMitarbeiterBearbeiten();
        }

        /// <summary>
        /// Öffnet den ausgewählten Mitarbeiter im Bearbeiten-Modus. Wird sowohl vom
        /// Doppelklick auf die Tabelle als auch vom "Bearbeiten"-Button aufgerufen.
        /// </summary>
        private void AusgewaehltenMitarbeiterBearbeiten()
        {
            if (dgvEmployees.CurrentRow?.DataBoundItem is not Mitarbeiter ausgewaehlterMitarbeiter)
            {
                MessageBox.Show("Bitte wählen Sie zuerst einen Mitarbeiter in der Liste aus.");
                return;
            }

            MitarbeiterForm mitarbeiterForm = new MitarbeiterForm(_mitarbeiterVerwaltung, ausgewaehlterMitarbeiter);
            mitarbeiterForm.ShowDialog();
            MitarbeiterAnzeigen();
        }

        private bool _mitarbeiterSortAufsteigend = true;

        private void dgvEmployees_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string spalte = dgvEmployees.Columns[e.ColumnIndex].Name;

            IEnumerable<Mitarbeiter> sortiert = spalte switch
            {
                nameof(Mitarbeiter.Nachname) => _mitarbeiterSortAufsteigend
                    ? _mitarbeiterVerwaltung.Alle.OrderBy(m => m.Nachname)
                    : _mitarbeiterVerwaltung.Alle.OrderByDescending(m => m.Nachname),
                nameof(Mitarbeiter.Vorname) => _mitarbeiterSortAufsteigend
                    ? _mitarbeiterVerwaltung.Alle.OrderBy(m => m.Vorname)
                    : _mitarbeiterVerwaltung.Alle.OrderByDescending(m => m.Vorname),
                nameof(Mitarbeiter.Abteilung) => _mitarbeiterSortAufsteigend
                    ? _mitarbeiterVerwaltung.Alle.OrderBy(m => m.Abteilung)
                    : _mitarbeiterVerwaltung.Alle.OrderByDescending(m => m.Abteilung),
                nameof(Mitarbeiter.Status) => _mitarbeiterSortAufsteigend
                    ? _mitarbeiterVerwaltung.Alle.OrderBy(m => m.Status)
                    : _mitarbeiterVerwaltung.Alle.OrderByDescending(m => m.Status),
                _ => _mitarbeiterVerwaltung.Alle
            };

            dgvEmployees.DataSource = sortiert.ToList();
            _mitarbeiterSortAufsteigend = !_mitarbeiterSortAufsteigend;
        }

        private void DashboardAktualisieren()
        {
            lblCustomerCount.Text = _kundenVerwaltung.Alle.Count(k => k.Status == Enums.Status.Aktiv).ToString();
            lblEmployeeCount.Text = _mitarbeiterVerwaltung.Alle.Count(m => m.Status == Enums.Status.Aktiv).ToString();
            lblInactiveCount.Text = (
                _kundenVerwaltung.Alle.Count(k => k.Status == Enums.Status.Inaktiv) +
                _mitarbeiterVerwaltung.Alle.Count(m => m.Status == Enums.Status.Inaktiv)
            ).ToString();

            var mutationen = _kundenVerwaltung.Alle
                .Select(k => new { Typ = "Kunde", Name = $"{k.Vorname} {k.Nachname}", Zeitpunkt = k.ZuletztGeaendert })
                .Concat(_mitarbeiterVerwaltung.Alle
                    .Select(m => new { Typ = "Mitarbeiter", Name = $"{m.Vorname} {m.Nachname}", Zeitpunkt = m.ZuletztGeaendert }))
                .OrderByDescending(x => x.Zeitpunkt)
                .Take(10)
                .ToList();

            dgvRecentMutations.DataSource = mutationen;

            var kontakte = _kundenVerwaltung.Alle
                .SelectMany(k => k.Kontakte.Select(kontakt => new
                {
                    Kunde = $"{k.Vorname} {k.Nachname}",
                    Wer = _mitarbeiterVerwaltung.Alle
                          .Where(m => m.MitarbeiterNummer == kontakt.MitarbeiterNummer)
                          .Select(m => $"{m.Vorname} {m.Nachname}")
                          .FirstOrDefault() ?? "Unbekannt",
                    Datum = kontakt.KontaktDatum,
                    Notiz = kontakt.Notizen
                }))
                .OrderByDescending(x => x.Datum)
                .Take(10)
                .ToList();

            dgvRecentContacts.DataSource = kontakte;
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow?.DataBoundItem is not Mitarbeiter ausgewaehlterMitarbeiter)
            {
                MessageBox.Show("Bitte wählen Sie zuerst einen Mitarbeiter in der Liste aus.");
                return;
            }

            var ergebnis = MessageBox.Show(
                $"Soll {ausgewaehlterMitarbeiter.Vorname} {ausgewaehlterMitarbeiter.Nachname} wirklich gelöscht werden?",
                "Mitarbeiter löschen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (ergebnis != DialogResult.Yes)
                return;

            _mitarbeiterVerwaltung.Loeschen(ausgewaehlterMitarbeiter);
            _mitarbeiterVerwaltung.Speichern();
            MitarbeiterAnzeigen();
        }

        private void pnlEmployee_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}