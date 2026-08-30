using ContactManager.Data;
using ContactManager.Services;



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
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = _kundenVerwaltung.Suchen(txtCustomerSearch.Text);
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
