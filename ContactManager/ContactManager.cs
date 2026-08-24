namespace ContactManager
{
    public partial class ContactManager : Form
    {
        public ContactManager()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlDashboard.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlCustomer.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pnlEmployee.BringToFront();
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            MitarbeiterForm mitarbeiterForm = new MitarbeiterForm();
            mitarbeiterForm.ShowDialog();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            KundenForm kundenForm = new KundenForm();
            kundenForm.ShowDialog();
        }
    }
}
