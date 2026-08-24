namespace ContactManager
{
    public partial class ContactManager : Form
    {
        public ContactManager()
        {
            InitializeComponent();
        }


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
            pnlCustomer.BringToFront();
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
        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            KundenForm kundenForm = new KundenForm();
            kundenForm.ShowDialog();
        }
    }
}
