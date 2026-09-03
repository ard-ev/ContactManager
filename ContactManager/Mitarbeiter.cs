using ContactManager.Models;
using ContactManager.Services;
using System.ComponentModel;

namespace ContactManager
{
    public partial class MitarbeiterForm : Form
    {
        // Draht zur Mitarbeiterverwaltung, damit das Formular speichern kann
        private readonly MitarbeiterVerwaltung _mitarbeiterVerwaltung;
        private Mitarbeiter? _originalZustand;
        private readonly Mitarbeiter? _bearbeiteterMitarbeiter; // null = neuer Mitarbeiter, sonst Bearbeiten-Modus

        /// <summary>Konstruktor zum Anlegen eines neuen Mitarbeiters.</summary>
        public MitarbeiterForm(MitarbeiterVerwaltung mitarbeiterVerwaltung)
            : this(mitarbeiterVerwaltung, null)
        {
        }

        /// <summary>
        /// Konstruktor zum Bearbeiten eines bestehenden Mitarbeiters. Ist mitarbeiter null,
        /// verhält sich das Formular wie beim Neuanlegen.
        /// </summary>
        public MitarbeiterForm(MitarbeiterVerwaltung mitarbeiterVerwaltung, Mitarbeiter? mitarbeiter)
        {
            InitializeComponent();
            _mitarbeiterVerwaltung = mitarbeiterVerwaltung;
            _bearbeiteterMitarbeiter = mitarbeiter;
            cmbMitarbeiterKadder.DataSource = Enum.GetValues(typeof(Enums.Kaderstufe));

            var _ = dtpMitarbeiterAustritt.Handle; // Handle früh erzwingen

            if (_bearbeiteterMitarbeiter != null)
            {
                FelderAusMitarbeiterVorbefuellen(_bearbeiteterMitarbeiter);
            }
            else
            {
                lblMitarbeiterAustritt.Visible = false;
                dtpMitarbeiterAustritt.Visible = false;
                txtMitarbeiterAHV.Text = "756.";
                dtpMitarbeiterEintritt.MinDate = DateTime.Today; // nur beim Neuanlegen
            }
        }

        /// <summary>Füllt die Eingabefelder mit den Werten eines bestehenden Mitarbeiters.</summary>
        private void FelderAusMitarbeiterVorbefuellen(Mitarbeiter mitarbeiter)
        {
            lblMitarbeiterPK.Text = "Mitarbeiternummer: " + mitarbeiter.MitarbeiterNummer;
            txtMitarbeiterVorname.Text = mitarbeiter.Vorname;
            txtMitarbeiterNachname.Text = mitarbeiter.Nachname;
            cmbMitarbeiterAbteilung.Text = mitarbeiter.Abteilung;
            txtMitarbeiterRolle.Text = mitarbeiter.Rolle;
            cmbMitarbeiterKadder.SelectedItem = mitarbeiter.Kaderstufe;
            txtMitarbeiterAHV.Text = mitarbeiter.AhvNummer;
            txtMitarbeiterAdresse.Text = mitarbeiter.Adresse;
            txtMitarbeiterPLZ.Text = mitarbeiter.Plz;
            txtMitarbeiterOrt.Text = mitarbeiter.Wohnort;
            cmbMitarbeiterNationalität.Text = mitarbeiter.Nationalität;
            txtMitarbeiterMobil.Text = mitarbeiter.MobilNummer;
            numMitarbeiterPensum.Value = mitarbeiter.Pensum;
            dtpMitarbeiterEintritt.Value = mitarbeiter.EinstellungsDatum;
            rdbMitarbeiterAktiv.Checked = mitarbeiter.Status == Enums.Status.Aktiv;
            rdbMitarbeiterInaktiv.Checked = mitarbeiter.Status == Enums.Status.Inaktiv;

            if (mitarbeiter.KündigungsDatum.HasValue)
            {
                ckbMitarbeiterBefristet.Checked = true;
                lblMitarbeiterAustritt.Visible = true;
                dtpMitarbeiterAustritt.Visible = true;
                dtpMitarbeiterAustritt.Value = mitarbeiter.KündigungsDatum.Value;
            }
            else
            {
                ckbMitarbeiterBefristet.Checked = false;
                lblMitarbeiterAustritt.Visible = false;
                dtpMitarbeiterAustritt.Visible = false;
            }

            // Schnappschuss der Ausgangswerte für die Änderungserkennung
            _originalZustand = new Mitarbeiter
            {
                Vorname = mitarbeiter.Vorname,
                Nachname = mitarbeiter.Nachname,
                Abteilung = mitarbeiter.Abteilung,
                Rolle = mitarbeiter.Rolle,
                Kaderstufe = mitarbeiter.Kaderstufe,
                AhvNummer = mitarbeiter.AhvNummer,
                Adresse = mitarbeiter.Adresse,
                Plz = mitarbeiter.Plz,
                Wohnort = mitarbeiter.Wohnort,
                Nationalität = mitarbeiter.Nationalität,
                MobilNummer = mitarbeiter.MobilNummer,
                EinstellungsDatum = mitarbeiter.EinstellungsDatum,
                KündigungsDatum = mitarbeiter.KündigungsDatum,
                Pensum = mitarbeiter.Pensum,
                Status = mitarbeiter.Status
            };
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblMitarbeiterHeaderSubtitle = new Label();
            lblMitarbeiterHeaderTitel = new Label();
            pnlMitarbeiterFooter = new Panel();
            btnMitarbeiterVerwaltung = new Button();
            btnMitarbeiterFooterSpeichern = new Button();
            btnMitarbeiterCancel = new Button();
            pnlMitarbeiterContent = new Panel();
            rdbMitarbeiterInaktiv = new RadioButton();
            rdbMitarbeiterAktiv = new RadioButton();
            lblMitarbeiterStatus = new Label();
            cmbMitarbeiterAbteilung = new ComboBox();
            ckbMitarbeiterBefristet = new CheckBox();
            cmbMitarbeiterNationalität = new ComboBox();
            txtMitarbeiterRolle = new TextBox();
            txtMitarbeiterOrt = new TextBox();
            numMitarbeiterPensum = new NumericUpDown();
            lblMitarbeiterPensum = new Label();
            dtpMitarbeiterAustritt = new DateTimePicker();
            dtpMitarbeiterEintritt = new DateTimePicker();
            lblMitarbeiterAustritt = new Label();
            lblMitarbeiterEintritt = new Label();
            txtMitarbeiterMobil = new TextBox();
            lblMitarbeiterMobilnummer = new Label();
            label1 = new Label();
            lblMitarbeiterWohnort = new Label();
            txtMitarbeiterPLZ = new TextBox();
            txtMitarbeiterAdresse = new TextBox();
            lblMitarbeiterPLZ = new Label();
            lblMitarbeiterAdresse = new Label();
            txtMitarbeiterAHV = new TextBox();
            cmbMitarbeiterKadder = new ComboBox();
            lblMitarbeiterAHV = new Label();
            lblMitarbeiterKaderstufe = new Label();
            txtMitarbeiterNachname = new TextBox();
            lblMitarbeiterRolle = new Label();
            lblMitarbeiterAbteilung = new Label();
            txtMitarbeiterVorname = new TextBox();
            lblMitarbeiterNachname = new Label();
            lblMitarbeiterVorname = new Label();
            lblMitarbeiterPK = new Label();
            panel1.SuspendLayout();
            pnlMitarbeiterFooter.SuspendLayout();
            pnlMitarbeiterContent.SuspendLayout();
            ((ISupportInitialize)numMitarbeiterPensum).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMitarbeiterHeaderSubtitle);
            panel1.Controls.Add(lblMitarbeiterHeaderTitel);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 69);
            panel1.TabIndex = 0;
            // 
            // lblMitarbeiterHeaderSubtitle
            // 
            lblMitarbeiterHeaderSubtitle.AutoSize = true;
            lblMitarbeiterHeaderSubtitle.Location = new Point(11, 37);
            lblMitarbeiterHeaderSubtitle.Name = "lblMitarbeiterHeaderSubtitle";
            lblMitarbeiterHeaderSubtitle.Size = new Size(221, 25);
            lblMitarbeiterHeaderSubtitle.TabIndex = 1;
            lblMitarbeiterHeaderSubtitle.Text = "Mitarbeiterdaten eingeben";
            // 
            // lblMitarbeiterHeaderTitel
            // 
            lblMitarbeiterHeaderTitel.AutoSize = true;
            lblMitarbeiterHeaderTitel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMitarbeiterHeaderTitel.Location = new Point(10, 7);
            lblMitarbeiterHeaderTitel.Name = "lblMitarbeiterHeaderTitel";
            lblMitarbeiterHeaderTitel.Size = new Size(328, 28);
            lblMitarbeiterHeaderTitel.TabIndex = 0;
            lblMitarbeiterHeaderTitel.Text = "Mitarbeiter erfassen / bearbeiten";
            // 
            // pnlMitarbeiterFooter
            // 
            pnlMitarbeiterFooter.Controls.Add(btnMitarbeiterVerwaltung);
            pnlMitarbeiterFooter.Controls.Add(btnMitarbeiterFooterSpeichern);
            pnlMitarbeiterFooter.Controls.Add(btnMitarbeiterCancel);
            pnlMitarbeiterFooter.Location = new Point(2, 579);
            pnlMitarbeiterFooter.Name = "pnlMitarbeiterFooter";
            pnlMitarbeiterFooter.Size = new Size(598, 50);
            pnlMitarbeiterFooter.TabIndex = 1;
            // 
            // btnMitarbeiterVerwaltung
            // 
            btnMitarbeiterVerwaltung.Location = new Point(16, 6);
            btnMitarbeiterVerwaltung.Name = "btnMitarbeiterVerwaltung";
            btnMitarbeiterVerwaltung.Size = new Size(121, 34);
            btnMitarbeiterVerwaltung.TabIndex = 2;
            btnMitarbeiterVerwaltung.Text = "Logs";
            btnMitarbeiterVerwaltung.UseVisualStyleBackColor = true;
            btnMitarbeiterVerwaltung.Click += btnMitarbeiterVerwaltung_Click;
            // 
            // btnMitarbeiterFooterSpeichern
            // 
            btnMitarbeiterFooterSpeichern.Location = new Point(456, 6);
            btnMitarbeiterFooterSpeichern.Name = "btnMitarbeiterFooterSpeichern";
            btnMitarbeiterFooterSpeichern.Size = new Size(121, 34);
            btnMitarbeiterFooterSpeichern.TabIndex = 1;
            btnMitarbeiterFooterSpeichern.Text = "Speichern";
            btnMitarbeiterFooterSpeichern.UseVisualStyleBackColor = true;
            btnMitarbeiterFooterSpeichern.Click += btnMitarbeiterFooterSpeichern_Click;
            // 
            // btnMitarbeiterCancel
            // 
            btnMitarbeiterCancel.Location = new Point(320, 6);
            btnMitarbeiterCancel.Name = "btnMitarbeiterCancel";
            btnMitarbeiterCancel.Size = new Size(121, 34);
            btnMitarbeiterCancel.TabIndex = 0;
            btnMitarbeiterCancel.Text = "Abbrechen";
            btnMitarbeiterCancel.UseVisualStyleBackColor = true;
            btnMitarbeiterCancel.Click += btnMitarbeiterCancel_Click;
            // 
            // pnlMitarbeiterContent
            // 
            pnlMitarbeiterContent.AutoScroll = true;
            pnlMitarbeiterContent.Controls.Add(rdbMitarbeiterInaktiv);
            pnlMitarbeiterContent.Controls.Add(rdbMitarbeiterAktiv);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterStatus);
            pnlMitarbeiterContent.Controls.Add(cmbMitarbeiterAbteilung);
            pnlMitarbeiterContent.Controls.Add(ckbMitarbeiterBefristet);
            pnlMitarbeiterContent.Controls.Add(cmbMitarbeiterNationalität);
            pnlMitarbeiterContent.Controls.Add(txtMitarbeiterRolle);
            pnlMitarbeiterContent.Controls.Add(txtMitarbeiterOrt);
            pnlMitarbeiterContent.Controls.Add(numMitarbeiterPensum);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterPensum);
            pnlMitarbeiterContent.Controls.Add(dtpMitarbeiterAustritt);
            pnlMitarbeiterContent.Controls.Add(dtpMitarbeiterEintritt);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterAustritt);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterEintritt);
            pnlMitarbeiterContent.Controls.Add(txtMitarbeiterMobil);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterMobilnummer);
            pnlMitarbeiterContent.Controls.Add(label1);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterWohnort);
            pnlMitarbeiterContent.Controls.Add(txtMitarbeiterPLZ);
            pnlMitarbeiterContent.Controls.Add(txtMitarbeiterAdresse);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterPLZ);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterAdresse);
            pnlMitarbeiterContent.Controls.Add(txtMitarbeiterAHV);
            pnlMitarbeiterContent.Controls.Add(cmbMitarbeiterKadder);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterAHV);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterKaderstufe);
            pnlMitarbeiterContent.Controls.Add(txtMitarbeiterNachname);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterRolle);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterAbteilung);
            pnlMitarbeiterContent.Controls.Add(txtMitarbeiterVorname);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterNachname);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterVorname);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterPK);
            pnlMitarbeiterContent.Location = new Point(75, 77);
            pnlMitarbeiterContent.Name = "pnlMitarbeiterContent";
            pnlMitarbeiterContent.Size = new Size(449, 502);
            pnlMitarbeiterContent.TabIndex = 2;
            // 
            // rdbMitarbeiterInaktiv
            // 
            rdbMitarbeiterInaktiv.AutoSize = true;
            rdbMitarbeiterInaktiv.Location = new Point(317, 460);
            rdbMitarbeiterInaktiv.Name = "rdbMitarbeiterInaktiv";
            rdbMitarbeiterInaktiv.Size = new Size(89, 29);
            rdbMitarbeiterInaktiv.TabIndex = 13;
            rdbMitarbeiterInaktiv.TabStop = true;
            rdbMitarbeiterInaktiv.Text = "Inaktiv";
            rdbMitarbeiterInaktiv.UseVisualStyleBackColor = true;
            // 
            // rdbMitarbeiterAktiv
            // 
            rdbMitarbeiterAktiv.AutoSize = true;
            rdbMitarbeiterAktiv.Location = new Point(247, 460);
            rdbMitarbeiterAktiv.Name = "rdbMitarbeiterAktiv";
            rdbMitarbeiterAktiv.Size = new Size(77, 29);
            rdbMitarbeiterAktiv.TabIndex = 12;
            rdbMitarbeiterAktiv.TabStop = true;
            rdbMitarbeiterAktiv.Text = "Aktiv";
            rdbMitarbeiterAktiv.UseVisualStyleBackColor = true;
            // 
            // lblMitarbeiterStatus
            // 
            lblMitarbeiterStatus.AutoSize = true;
            lblMitarbeiterStatus.Location = new Point(247, 433);
            lblMitarbeiterStatus.Name = "lblMitarbeiterStatus";
            lblMitarbeiterStatus.Size = new Size(64, 25);
            lblMitarbeiterStatus.TabIndex = 31;
            lblMitarbeiterStatus.Text = "Status:";
            // 
            // cmbMitarbeiterAbteilung
            // 
            cmbMitarbeiterAbteilung.FormattingEnabled = true;
            cmbMitarbeiterAbteilung.Items.AddRange(new object[] { "Geschäftsleitung", "Verkauf & Marketing", "Finanzen & Buchhaltung", "IT & Support", "Personalwesen (HR)", "Produktion & Logistik" });
            cmbMitarbeiterAbteilung.Location = new Point(7, 159);
            cmbMitarbeiterAbteilung.Name = "cmbMitarbeiterAbteilung";
            cmbMitarbeiterAbteilung.Size = new Size(182, 33);
            cmbMitarbeiterAbteilung.TabIndex = 2;
            // 
            // ckbMitarbeiterBefristet
            // 
            ckbMitarbeiterBefristet.AutoSize = true;
            ckbMitarbeiterBefristet.Location = new Point(247, 543);
            ckbMitarbeiterBefristet.Name = "ckbMitarbeiterBefristet";
            ckbMitarbeiterBefristet.Size = new Size(102, 29);
            ckbMitarbeiterBefristet.TabIndex = 16;
            ckbMitarbeiterBefristet.Text = "Befristet";
            ckbMitarbeiterBefristet.UseVisualStyleBackColor = true;
            ckbMitarbeiterBefristet.CheckedChanged += ckbMitarbeiterBefristet_CheckedChanged;
            // 
            // cmbMitarbeiterNationalität
            // 
            cmbMitarbeiterNationalität.Font = new Font("Segoe UI Light", 9F);
            cmbMitarbeiterNationalität.FormattingEnabled = true;
            cmbMitarbeiterNationalität.Items.AddRange(new object[] { "Afghanistan", "Ägypten", "Albanien", "Algerien", "Andorra", "Angola", "Antigua und Barbuda", "Äquatorialguinea", "Argentinien", "Armenien", "Aserbaidschan", "Äthiopien", "Australien", "Bahamas", "Bahrain", "Bangladesch", "Barbados", "Belarus", "Belgien", "Belize", "Benin", "Bhutan", "Bolivien", "Bosnien und Herzegowina", "Botswana", "Brasilien", "Brunei", "Bulgarien", "Burkina Faso", "Burundi", "Chile", "China", "Costa Rica", "Dänemark", "Deutschland", "Dominica", "Dominikanische Republik", "Dschibuti", "Ecuador", "El Salvador", "Elfenbeinküste", "Eritrea", "Estland", "Eswatini", "Fidschi", "Finnland", "Frankreich", "Gabun", "Gambia", "Georgien", "Ghana", "Grenada", "Griechenland", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Indien", "Indonesien", "Irak", "Iran", "Irland", "Island", "Israel", "Italien", "Jamaika", "Japan", "Jemen", "Jordanien", "Kambodscha", "Kamerun", "Kanada", "Kap Verde", "Kasachstan", "Katar", "Kenia", "Kirgisistan", "Kiribati", "Kolumbien", "Komoren", "Kongo, Demokratische Republik", "Kongo, Republik", "Kroatien", "Kuba", "Kuwait", "Laos", "Lesotho", "Lettland", "Libanon", "Liberia", "Libyen", "Liechtenstein", "Litauen", "Luxemburg", "Madagaskar", "Malawi", "Malaysia", "Malediven", "Mali", "Malta", "Marokko", "Marshallinseln", "Mauretanien", "Mauritius", "Mexiko", "Mikronesien", "Moldau", "Monaco", "Mongolei", "Montenegro", "Mosambik", "Myanmar", "Namibia", "Nauru", "Nepal", "Neuseeland", "Nicaragua", "Niederlande", "Niger", "Nigeria", "Nordkorea", "Nordmazedonien", "Norwegen", "Oman", "Österreich", "Pakistan", "Palästina", "Palau", "Panama", "Papua-Neuguinea", "Paraguay", "Peru", "Philippinen", "Polen", "Portugal", "Ruanda", "Rumänien", "Russland", "Salomonen", "Sambia", "Samoa", "San Marino", "São Tomé und Príncipe", "Saudi-Arabien", "Schweden", "Schweiz", "Senegal", "Serbien", "Seychellen", "Sierra Leone", "Simbabwe", "Singapur", "Slowakei", "Slowenien", "Somalia", "Spanien", "Sri Lanka", "St. Kitts und Nevis", "St. Lucia", "St. Vincent und die Grenadinen", "Südafrika", "Sudan", "Südkorea", "Südsudan", "Suriname", "Syrien", "Tadschikistan", "Tansania", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad und Tobago", "Tschad", "Tschechien", "Tunesien", "Türkei", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "Ungarn", "Uruguay", "Usbekistan", "Vanuatu", "Vatikanstadt", "Venezuela", "Vereinigte Arabische Emirate", "Vereinigte Staaten", "Vereinigtes Königreich", "Vietnam", "Zentralafrikanische Republik", "Zypern" });
            cmbMitarbeiterNationalität.Location = new Point(247, 381);
            cmbMitarbeiterNationalität.Name = "cmbMitarbeiterNationalität";
            cmbMitarbeiterNationalität.Size = new Size(182, 33);
            cmbMitarbeiterNationalität.TabIndex = 10;
            cmbMitarbeiterNationalität.Text = "Nationalität";
            // 
            // txtMitarbeiterRolle
            // 
            txtMitarbeiterRolle.Location = new Point(247, 159);
            txtMitarbeiterRolle.Name = "txtMitarbeiterRolle";
            txtMitarbeiterRolle.Size = new Size(182, 31);
            txtMitarbeiterRolle.TabIndex = 4;
            // 
            // txtMitarbeiterOrt
            // 
            txtMitarbeiterOrt.Location = new Point(7, 381);
            txtMitarbeiterOrt.Name = "txtMitarbeiterOrt";
            txtMitarbeiterOrt.PlaceholderText = "Wohnort";
            txtMitarbeiterOrt.Size = new Size(182, 31);
            txtMitarbeiterOrt.TabIndex = 9;
            // 
            // numMitarbeiterPensum
            // 
            numMitarbeiterPensum.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numMitarbeiterPensum.Location = new Point(7, 607);
            numMitarbeiterPensum.Name = "numMitarbeiterPensum";
            numMitarbeiterPensum.Size = new Size(182, 31);
            numMitarbeiterPensum.TabIndex = 15;
            numMitarbeiterPensum.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // lblMitarbeiterPensum
            // 
            lblMitarbeiterPensum.AutoSize = true;
            lblMitarbeiterPensum.Location = new Point(7, 584);
            lblMitarbeiterPensum.Name = "lblMitarbeiterPensum";
            lblMitarbeiterPensum.Size = new Size(78, 25);
            lblMitarbeiterPensum.TabIndex = 29;
            lblMitarbeiterPensum.Text = "Pensum:";
            // 
            // dtpMitarbeiterAustritt
            // 
            dtpMitarbeiterAustritt.Format = DateTimePickerFormat.Short;
            dtpMitarbeiterAustritt.Location = new Point(247, 607);
            dtpMitarbeiterAustritt.Name = "dtpMitarbeiterAustritt";
            dtpMitarbeiterAustritt.Size = new Size(182, 31);
            dtpMitarbeiterAustritt.TabIndex = 17;
            // 
            // dtpMitarbeiterEintritt
            // 
            dtpMitarbeiterEintritt.Format = DateTimePickerFormat.Short;
            dtpMitarbeiterEintritt.Location = new Point(7, 543);
            dtpMitarbeiterEintritt.Name = "dtpMitarbeiterEintritt";
            dtpMitarbeiterEintritt.Size = new Size(178, 31);
            dtpMitarbeiterEintritt.TabIndex = 14;
            dtpMitarbeiterEintritt.Value = new DateTime(2026, 8, 30, 14, 9, 14, 0);
            // 
            // lblMitarbeiterAustritt
            // 
            lblMitarbeiterAustritt.AutoSize = true;
            lblMitarbeiterAustritt.Location = new Point(247, 584);
            lblMitarbeiterAustritt.Name = "lblMitarbeiterAustritt";
            lblMitarbeiterAustritt.Size = new Size(74, 25);
            lblMitarbeiterAustritt.TabIndex = 25;
            lblMitarbeiterAustritt.Text = "Austritt:";
            // 
            // lblMitarbeiterEintritt
            // 
            lblMitarbeiterEintritt.AutoSize = true;
            lblMitarbeiterEintritt.Location = new Point(7, 520);
            lblMitarbeiterEintritt.Name = "lblMitarbeiterEintritt";
            lblMitarbeiterEintritt.Size = new Size(67, 25);
            lblMitarbeiterEintritt.TabIndex = 24;
            lblMitarbeiterEintritt.Text = "Eintritt:";
            // 
            // txtMitarbeiterMobil
            // 
            txtMitarbeiterMobil.Location = new Point(7, 456);
            txtMitarbeiterMobil.Name = "txtMitarbeiterMobil";
            txtMitarbeiterMobil.PlaceholderText = "0791234567";
            txtMitarbeiterMobil.Size = new Size(178, 31);
            txtMitarbeiterMobil.TabIndex = 11;
            // 
            // lblMitarbeiterMobilnummer
            // 
            lblMitarbeiterMobilnummer.AutoSize = true;
            lblMitarbeiterMobilnummer.Location = new Point(7, 433);
            lblMitarbeiterMobilnummer.Name = "lblMitarbeiterMobilnummer";
            lblMitarbeiterMobilnummer.Size = new Size(129, 25);
            lblMitarbeiterMobilnummer.TabIndex = 22;
            lblMitarbeiterMobilnummer.Text = "Mobilnummer:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 358);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 19;
            label1.Text = "Nationalität:";
            // 
            // lblMitarbeiterWohnort
            // 
            lblMitarbeiterWohnort.AutoSize = true;
            lblMitarbeiterWohnort.Location = new Point(7, 358);
            lblMitarbeiterWohnort.Name = "lblMitarbeiterWohnort";
            lblMitarbeiterWohnort.Size = new Size(86, 25);
            lblMitarbeiterWohnort.TabIndex = 18;
            lblMitarbeiterWohnort.Text = "Wohnort:";
            // 
            // txtMitarbeiterPLZ
            // 
            txtMitarbeiterPLZ.Location = new Point(247, 307);
            txtMitarbeiterPLZ.Name = "txtMitarbeiterPLZ";
            txtMitarbeiterPLZ.PlaceholderText = "9001";
            txtMitarbeiterPLZ.Size = new Size(182, 31);
            txtMitarbeiterPLZ.TabIndex = 8;
            // 
            // txtMitarbeiterAdresse
            // 
            txtMitarbeiterAdresse.Location = new Point(7, 307);
            txtMitarbeiterAdresse.Name = "txtMitarbeiterAdresse";
            txtMitarbeiterAdresse.PlaceholderText = "Musterstrasse 1";
            txtMitarbeiterAdresse.Size = new Size(182, 31);
            txtMitarbeiterAdresse.TabIndex = 7;
            // 
            // lblMitarbeiterPLZ
            // 
            lblMitarbeiterPLZ.AutoSize = true;
            lblMitarbeiterPLZ.Location = new Point(247, 284);
            lblMitarbeiterPLZ.Name = "lblMitarbeiterPLZ";
            lblMitarbeiterPLZ.Size = new Size(45, 25);
            lblMitarbeiterPLZ.TabIndex = 15;
            lblMitarbeiterPLZ.Text = "PLZ:";
            // 
            // lblMitarbeiterAdresse
            // 
            lblMitarbeiterAdresse.AutoSize = true;
            lblMitarbeiterAdresse.Location = new Point(7, 284);
            lblMitarbeiterAdresse.Name = "lblMitarbeiterAdresse";
            lblMitarbeiterAdresse.Size = new Size(79, 25);
            lblMitarbeiterAdresse.TabIndex = 14;
            lblMitarbeiterAdresse.Text = "Adresse:";
            // 
            // txtMitarbeiterAHV
            // 
            txtMitarbeiterAHV.Location = new Point(247, 232);
            txtMitarbeiterAHV.Name = "txtMitarbeiterAHV";
            txtMitarbeiterAHV.PlaceholderText = "756.1234.1234.12";
            txtMitarbeiterAHV.Size = new Size(182, 31);
            txtMitarbeiterAHV.TabIndex = 6;
            // 
            // cmbMitarbeiterKadder
            // 
            cmbMitarbeiterKadder.FormattingEnabled = true;
            cmbMitarbeiterKadder.Location = new Point(7, 231);
            cmbMitarbeiterKadder.Name = "cmbMitarbeiterKadder";
            cmbMitarbeiterKadder.Size = new Size(182, 33);
            cmbMitarbeiterKadder.TabIndex = 5;
            // 
            // lblMitarbeiterAHV
            // 
            lblMitarbeiterAHV.AutoSize = true;
            lblMitarbeiterAHV.Location = new Point(247, 209);
            lblMitarbeiterAHV.Name = "lblMitarbeiterAHV";
            lblMitarbeiterAHV.Size = new Size(129, 25);
            lblMitarbeiterAHV.TabIndex = 11;
            lblMitarbeiterAHV.Text = "AHV-Nummer:";
            // 
            // lblMitarbeiterKaderstufe
            // 
            lblMitarbeiterKaderstufe.AutoSize = true;
            lblMitarbeiterKaderstufe.Location = new Point(7, 209);
            lblMitarbeiterKaderstufe.Name = "lblMitarbeiterKaderstufe";
            lblMitarbeiterKaderstufe.Size = new Size(100, 25);
            lblMitarbeiterKaderstufe.TabIndex = 10;
            lblMitarbeiterKaderstufe.Text = "Kaderstufe:";
            // 
            // txtMitarbeiterNachname
            // 
            txtMitarbeiterNachname.Location = new Point(247, 91);
            txtMitarbeiterNachname.Name = "txtMitarbeiterNachname";
            txtMitarbeiterNachname.PlaceholderText = "Nachname";
            txtMitarbeiterNachname.Size = new Size(182, 31);
            txtMitarbeiterNachname.TabIndex = 1;
            // 
            // lblMitarbeiterRolle
            // 
            lblMitarbeiterRolle.AutoSize = true;
            lblMitarbeiterRolle.Location = new Point(247, 136);
            lblMitarbeiterRolle.Name = "lblMitarbeiterRolle";
            lblMitarbeiterRolle.Size = new Size(54, 25);
            lblMitarbeiterRolle.TabIndex = 6;
            lblMitarbeiterRolle.Text = "Rolle:";
            // 
            // lblMitarbeiterAbteilung
            // 
            lblMitarbeiterAbteilung.AutoSize = true;
            lblMitarbeiterAbteilung.Location = new Point(7, 137);
            lblMitarbeiterAbteilung.Name = "lblMitarbeiterAbteilung";
            lblMitarbeiterAbteilung.Size = new Size(93, 25);
            lblMitarbeiterAbteilung.TabIndex = 5;
            lblMitarbeiterAbteilung.Text = "Abteilung:";
            // 
            // txtMitarbeiterVorname
            // 
            txtMitarbeiterVorname.Location = new Point(7, 91);
            txtMitarbeiterVorname.Name = "txtMitarbeiterVorname";
            txtMitarbeiterVorname.PlaceholderText = "Vorname";
            txtMitarbeiterVorname.Size = new Size(182, 31);
            txtMitarbeiterVorname.TabIndex = 0;
            // 
            // lblMitarbeiterNachname
            // 
            lblMitarbeiterNachname.AutoSize = true;
            lblMitarbeiterNachname.Location = new Point(247, 68);
            lblMitarbeiterNachname.Name = "lblMitarbeiterNachname";
            lblMitarbeiterNachname.Size = new Size(100, 25);
            lblMitarbeiterNachname.TabIndex = 3;
            lblMitarbeiterNachname.Text = "Nachname:";
            // 
            // lblMitarbeiterVorname
            // 
            lblMitarbeiterVorname.AutoSize = true;
            lblMitarbeiterVorname.Location = new Point(7, 68);
            lblMitarbeiterVorname.Name = "lblMitarbeiterVorname";
            lblMitarbeiterVorname.Size = new Size(87, 25);
            lblMitarbeiterVorname.TabIndex = 2;
            lblMitarbeiterVorname.Text = "Vorname:";
            // 
            // lblMitarbeiterPK
            // 
            lblMitarbeiterPK.AutoSize = true;
            lblMitarbeiterPK.Location = new Point(7, 17);
            lblMitarbeiterPK.Name = "lblMitarbeiterPK";
            lblMitarbeiterPK.Size = new Size(169, 25);
            lblMitarbeiterPK.TabIndex = 0;
            lblMitarbeiterPK.Text = "Mitarbeiternummer:";
            // 
            // MitarbeiterForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(601, 631);
            Controls.Add(panel1);
            Controls.Add(pnlMitarbeiterContent);
            Controls.Add(pnlMitarbeiterFooter);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MitarbeiterForm";
            Text = "Mitarbeiter";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlMitarbeiterFooter.ResumeLayout(false);
            pnlMitarbeiterContent.ResumeLayout(false);
            pnlMitarbeiterContent.PerformLayout();
            ((ISupportInitialize)numMitarbeiterPensum).EndInit();
            ResumeLayout(false);

        }

        private void ckbMitarbeiterBefristet_CheckedChanged(object sender, EventArgs e)
        {
            bool istBefristet = ckbMitarbeiterBefristet.Checked;
            lblMitarbeiterAustritt.Visible = ckbMitarbeiterBefristet.Checked;
            dtpMitarbeiterAustritt.Visible = ckbMitarbeiterBefristet.Checked;

            if (istBefristet)
            {
                pnlMitarbeiterContent.ScrollControlIntoView(dtpMitarbeiterAustritt);
            }
        }

        private void btnMitarbeiterCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /// <summary>
        /// Validiert die Eingabe der Mobilnummer, sodass nur Ziffern, Steuerzeichen und das Pluszeichen erlaubt sind.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMitarbeiterMobil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Validierung der Telefonnummer (Methode)
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            phoneNumber = phoneNumber.Replace(" ", "");

            return System.Text.RegularExpressions.Regex.IsMatch(
                phoneNumber,
                @"^(0\d{9}|\+41\d{9})$"
            );
        }

        private void btnMitarbeiterFooterSpeichern_Click(object sender, EventArgs e)
        {
            // Pflichtfelder minimal prüfen
            if (string.IsNullOrWhiteSpace(txtMitarbeiterVorname.Text) ||
                string.IsNullOrWhiteSpace(txtMitarbeiterNachname.Text))
            {
                MessageBox.Show("Bitte mindestens Vorname und Nachname ausfüllen.");
                return;
            }

            // Mobilnummer prüfen (nur wenn etwas eingegeben wurde)
            if (!string.IsNullOrWhiteSpace(txtMitarbeiterMobil.Text) &&
                !IsValidPhoneNumber(txtMitarbeiterMobil.Text))
            {
                MessageBox.Show("Bitte geben Sie eine gültige Telefonnummer ein.");
                txtMitarbeiterMobil.Focus();
                return;
            }

            // Arbeitsbeginn darf nicht in der Vergangenheit liegen - nur beim Neuanlegen relevant
            if (_bearbeiteterMitarbeiter == null && dtpMitarbeiterEintritt.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Der Arbeitsbeginn darf nicht in der Vergangenheit liegen.");
                dtpMitarbeiterEintritt.Focus();
                return;
            }

            // Kaderstufe aus der ComboBox lesen (Text "0" bis "5"), sicher umwandeln
            var kaderWert = (Enums.Kaderstufe)cmbMitarbeiterKadder.SelectedItem;

            DateTime? austrittsDatum = ckbMitarbeiterBefristet.Checked
                ? dtpMitarbeiterAustritt.Value
                : (DateTime?)null;

            if (_bearbeiteterMitarbeiter != null)
            {
                if (!HatSichEtwasGeaendert())
                {
                    MessageBox.Show("Es wurden keine Änderungen vorgenommen.");
                    this.Close();
                    return;
                }

                // Änderungen ermitteln, BEVOR die neuen Werte übernommen werden
                var aenderungen = AenderungenErmitteln();

                // Bearbeiten-Modus: bestehendes Objekt aktualisieren statt ein neues anzulegen
                _bearbeiteterMitarbeiter.Vorname = txtMitarbeiterVorname.Text;
                _bearbeiteterMitarbeiter.Nachname = txtMitarbeiterNachname.Text;
                _bearbeiteterMitarbeiter.Abteilung = cmbMitarbeiterAbteilung.Text;
                _bearbeiteterMitarbeiter.Rolle = txtMitarbeiterRolle.Text;
                _bearbeiteterMitarbeiter.Kaderstufe = kaderWert;
                _bearbeiteterMitarbeiter.AhvNummer = txtMitarbeiterAHV.Text;
                _bearbeiteterMitarbeiter.Adresse = txtMitarbeiterAdresse.Text;
                _bearbeiteterMitarbeiter.Plz = txtMitarbeiterPLZ.Text;
                _bearbeiteterMitarbeiter.Wohnort = txtMitarbeiterOrt.Text;
                _bearbeiteterMitarbeiter.Nationalität = cmbMitarbeiterNationalität.Text;
                _bearbeiteterMitarbeiter.MobilNummer = txtMitarbeiterMobil.Text;
                _bearbeiteterMitarbeiter.EinstellungsDatum = dtpMitarbeiterEintritt.Value;
                _bearbeiteterMitarbeiter.KündigungsDatum = austrittsDatum;
                _bearbeiteterMitarbeiter.Pensum = numMitarbeiterPensum.Value;
                _bearbeiteterMitarbeiter.Status = rdbMitarbeiterAktiv.Checked ? Enums.Status.Aktiv : Enums.Status.Inaktiv;

                _mitarbeiterVerwaltung.Bearbeiten(_bearbeiteterMitarbeiter);
                _mitarbeiterVerwaltung.MutationenProtokollieren(_bearbeiteterMitarbeiter, aenderungen);
                _mitarbeiterVerwaltung.Speichern();

                MessageBox.Show("Mitarbeiter aktualisiert.");
                this.Close();
            }
            else
            {
                // Mitarbeiter aus den Eingabefeldern zusammenbauen
                Mitarbeiter mitarbeiter = new Mitarbeiter
                {
                    Vorname = txtMitarbeiterVorname.Text,
                    Nachname = txtMitarbeiterNachname.Text,
                    Abteilung = cmbMitarbeiterAbteilung.Text,
                    Rolle = txtMitarbeiterRolle.Text,
                    Kaderstufe = kaderWert,
                    AhvNummer = txtMitarbeiterAHV.Text,
                    Adresse = txtMitarbeiterAdresse.Text,
                    Plz = txtMitarbeiterPLZ.Text,
                    Wohnort = txtMitarbeiterOrt.Text,
                    Nationalität = cmbMitarbeiterNationalität.Text,
                    MobilNummer = txtMitarbeiterMobil.Text,
                    EinstellungsDatum = dtpMitarbeiterEintritt.Value,
                    KündigungsDatum = austrittsDatum,
                    Pensum = numMitarbeiterPensum.Value,
                    Status = rdbMitarbeiterAktiv.Checked ? Enums.Status.Aktiv : Enums.Status.Inaktiv
                };

                // An die Verwaltung übergeben und auf die Festplatte speichern
                _mitarbeiterVerwaltung.Hinzufuegen(mitarbeiter);
                _mitarbeiterVerwaltung.Speichern();

                MessageBox.Show("Mitarbeiter erfolgreich gespeichert.");
                FelderZuruecksetzenMitarbeiter();
            }
        }

        /// <summary>
        /// Setzt alle Eingabefelder auf den Ausgangszustand zurück,
        /// damit direkt der nächste Mitarbeiter erfasst werden kann.
        /// </summary>
        private void FelderZuruecksetzenMitarbeiter()
        {
            txtMitarbeiterVorname.Clear();
            txtMitarbeiterNachname.Clear();
            cmbMitarbeiterAbteilung.SelectedIndex = -1;
            txtMitarbeiterRolle.Clear();
            cmbMitarbeiterKadder.SelectedItem = Enums.Kaderstufe.Keine;
            txtMitarbeiterAHV.Text = "756.";
            txtMitarbeiterAdresse.Clear();
            txtMitarbeiterPLZ.Clear();
            txtMitarbeiterOrt.Clear();
            cmbMitarbeiterNationalität.SelectedIndex = -1;
            cmbMitarbeiterNationalität.Text = "Nationalität";
            txtMitarbeiterMobil.Clear();
            numMitarbeiterPensum.Value = 100;
            dtpMitarbeiterEintritt.Value = DateTime.Today;
            rdbMitarbeiterAktiv.Checked = false;
            rdbMitarbeiterInaktiv.Checked = false;

            ckbMitarbeiterBefristet.Checked = false;
            lblMitarbeiterAustritt.Visible = false;
            dtpMitarbeiterAustritt.Visible = false;

            txtMitarbeiterVorname.Focus();

            // Label mit der Nummer für den NÄCHSTEN Mitarbeiter aktualisieren
            lblMitarbeiterPK.Text = "Mitarbeiternummer: " + _mitarbeiterVerwaltung.NaechsteMitarbeiterNummer();
        }

        private void btnMitarbeiterVerwaltung_Click(object sender, EventArgs e)
        {
            if (_bearbeiteterMitarbeiter == null)
            {
                MessageBox.Show("Bitte zuerst speichern - Verlauf ist erst danach verfügbar.");
                return;
            }

            MitarbeiterVerwaltungForm verwaltungForm = new MitarbeiterVerwaltungForm(_mitarbeiterVerwaltung, _bearbeiteterMitarbeiter);
            verwaltungForm.ShowDialog();
        }

        private List<(string Feld, string AlterWert, string NeuerWert)> AenderungenErmitteln()
        {
            var aenderungen = new List<(string Feld, string AlterWert, string NeuerWert)>();

            if (_originalZustand == null)
                return aenderungen;

            void Vergleichen(string feld, string alterWert, string neuerWert)
            {
                if (alterWert != neuerWert)
                    aenderungen.Add((feld, alterWert, neuerWert));
            }

            var kaderWert = (Enums.Kaderstufe)cmbMitarbeiterKadder.SelectedItem;
            DateTime? austrittsDatum = ckbMitarbeiterBefristet.Checked ? dtpMitarbeiterAustritt.Value : (DateTime?)null;
            var neuerStatus = rdbMitarbeiterAktiv.Checked ? Enums.Status.Aktiv : Enums.Status.Inaktiv;

            Vergleichen("Vorname", _originalZustand.Vorname, txtMitarbeiterVorname.Text);
            Vergleichen("Nachname", _originalZustand.Nachname, txtMitarbeiterNachname.Text);
            Vergleichen("Abteilung", _originalZustand.Abteilung, cmbMitarbeiterAbteilung.Text);
            Vergleichen("Rolle", _originalZustand.Rolle, txtMitarbeiterRolle.Text);
            Vergleichen("Kaderstufe", _originalZustand.Kaderstufe.ToString(), kaderWert.ToString());
            Vergleichen("AHV-Nummer", _originalZustand.AhvNummer, txtMitarbeiterAHV.Text);
            Vergleichen("Adresse", _originalZustand.Adresse, txtMitarbeiterAdresse.Text);
            Vergleichen("PLZ", _originalZustand.Plz, txtMitarbeiterPLZ.Text);
            Vergleichen("Wohnort", _originalZustand.Wohnort, txtMitarbeiterOrt.Text);
            Vergleichen("Nationalität", _originalZustand.Nationalität, cmbMitarbeiterNationalität.Text);
            Vergleichen("Mobil", _originalZustand.MobilNummer, txtMitarbeiterMobil.Text);
            Vergleichen("Eintrittsdatum", _originalZustand.EinstellungsDatum.ToString("dd.MM.yyyy"), dtpMitarbeiterEintritt.Value.ToString("dd.MM.yyyy"));
            Vergleichen("Austrittsdatum", _originalZustand.KündigungsDatum?.ToString("dd.MM.yyyy") ?? "-", austrittsDatum?.ToString("dd.MM.yyyy") ?? "-");
            Vergleichen("Pensum", _originalZustand.Pensum.ToString(), numMitarbeiterPensum.Value.ToString());
            Vergleichen("Status", _originalZustand.Status.ToString(), neuerStatus.ToString());

            return aenderungen;
        }   

        private bool HatSichEtwasGeaendert()
        {
            if (_originalZustand == null)
                return true;

            var kaderWert = (Enums.Kaderstufe)cmbMitarbeiterKadder.SelectedItem;
            DateTime? austrittsDatum = ckbMitarbeiterBefristet.Checked ? dtpMitarbeiterAustritt.Value : (DateTime?)null;

            return
                _originalZustand.Vorname != txtMitarbeiterVorname.Text ||
                _originalZustand.Nachname != txtMitarbeiterNachname.Text ||
                _originalZustand.Abteilung != cmbMitarbeiterAbteilung.Text ||
                _originalZustand.Rolle != txtMitarbeiterRolle.Text ||
                _originalZustand.Kaderstufe != kaderWert ||
                _originalZustand.AhvNummer != txtMitarbeiterAHV.Text ||
                _originalZustand.Adresse != txtMitarbeiterAdresse.Text ||
                _originalZustand.Plz != txtMitarbeiterPLZ.Text ||
                _originalZustand.Wohnort != txtMitarbeiterOrt.Text ||
                _originalZustand.Nationalität != cmbMitarbeiterNationalität.Text ||
                _originalZustand.MobilNummer != txtMitarbeiterMobil.Text ||
                _originalZustand.EinstellungsDatum != dtpMitarbeiterEintritt.Value ||
                _originalZustand.KündigungsDatum != austrittsDatum ||
                _originalZustand.Pensum != numMitarbeiterPensum.Value ||
                _originalZustand.Status != (rdbMitarbeiterAktiv.Checked ? Enums.Status.Aktiv : Enums.Status.Inaktiv);
        }
    }
}
