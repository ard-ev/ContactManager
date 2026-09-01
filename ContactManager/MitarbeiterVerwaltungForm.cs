using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager.Models;
using ContactManager.Services;

namespace ContactManager
{
    /// <summary>
    /// Zeigt zu einem einzelnen Mitarbeiter das Protokoll seiner Notizen
    /// sowie die Mutationshistorie (alle nachvollziehbaren Änderungen an den
    /// Stammdaten). Über dieses Formular können ausserdem neue Notizen erfasst werden.
    /// </summary>
    public partial class MitarbeiterVerwaltungForm : Form
    {
        private readonly MitarbeiterVerwaltung _mitarbeiterVerwaltung;
        private readonly Mitarbeiter _mitarbeiter;

        public MitarbeiterVerwaltungForm(MitarbeiterVerwaltung mitarbeiterVerwaltung, Mitarbeiter mitarbeiter)
        {
            InitializeComponent();
            _mitarbeiterVerwaltung = mitarbeiterVerwaltung;
            _mitarbeiter = mitarbeiter;

            lblMVHeaderSubtitle.Text = $"{_mitarbeiter.Vorname} {_mitarbeiter.Nachname} (Mitarbeiternummer: {_mitarbeiter.MitarbeiterNummer})";

            NotizenLaden();
            MutationenLaden();
        }

        /// <summary>Lädt das Notizen-Protokoll des Mitarbeiters neu ins Grid.</summary>
        private void NotizenLaden()
        {
            dgvMVNotizen.DataSource = null;
            dgvMVNotizen.DataSource = _mitarbeiterVerwaltung.Notizhistorie(_mitarbeiter)
                .Select(n => new
                {
                    Datum = n.KontaktDatum.ToString("dd.MM.yyyy HH:mm"),
                    Notiz = n.Notizen
                })
                .ToList();

            if (dgvMVNotizen.Columns["Datum"] != null)
                dgvMVNotizen.Columns["Datum"].FillWeight = 30;
        }

        /// <summary>Lädt die Mutationshistorie des Mitarbeiters neu ins Grid.</summary>
        private void MutationenLaden()
        {
            dgvMVMutationen.DataSource = null;
            dgvMVMutationen.DataSource = _mitarbeiterVerwaltung.Mutationshistorie(_mitarbeiter)
                .Select(m => new
                {
                    Datum = m.Zeitpunkt.ToString("dd.MM.yyyy HH:mm"),
                    Feld = m.Feld,
                    AlterWert = string.IsNullOrWhiteSpace(m.AlterWert) ? "-" : m.AlterWert,
                    NeuerWert = string.IsNullOrWhiteSpace(m.NeuerWert) ? "-" : m.NeuerWert
                })
                .ToList();

            if (dgvMVMutationen.Columns["Datum"] != null)
                dgvMVMutationen.Columns["Datum"].FillWeight = 25;
        }

        /// <summary>Event-Handler: neue Notiz erfassen und Protokoll aktualisieren.</summary>
        private void btnMVNotizHinzufuegen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMVNeueNotiz.Text))
            {
                MessageBox.Show("Bitte eine Notiz eingeben.");
                return;
            }

            _mitarbeiterVerwaltung.NotizHinzufuegen(_mitarbeiter, txtMVNeueNotiz.Text);
            txtMVNeueNotiz.Clear();
            NotizenLaden();
        }

        /// <summary>Event-Handler für den Schliessen-Button.</summary>
        private void btnMVSchliessen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}