using ContactManager.Models;
using ContactManager.Services;

namespace ContactManager
{
    public partial class KundenForm : Form
    {
        // Draht zur Kundenverwaltung, damit das Formular den Kunden speichern kann
        private readonly KundenVerwaltung _kundenVerwaltung;
        private readonly Kunde? _bearbeiteterKunde; // null = neuer Kunde, sonst Bearbeiten-Modus
        private Kunde? _originalZustand; // Schnappschuss der Werte beim Öffnen, für die Änderungserkennung

        /// <summary>Konstruktor zum Anlegen eines neuen Kunden.</summary>
        public KundenForm(KundenVerwaltung kundenVerwaltung) : this(kundenVerwaltung, null)
        {
        }

        /// <summary>
        /// Konstruktor zum Bearbeiten eines bestehenden Kunden. Ist kunde null,
        /// verhält sich das Formular wie beim Neuanlegen.
        /// </summary>
        public KundenForm(KundenVerwaltung kundenVerwaltung, Kunde? kunde)
        {
            InitializeComponent();
            _kundenVerwaltung = kundenVerwaltung;
            _bearbeiteterKunde = kunde;
            ComboBoxenBefuellen();

            if (_bearbeiteterKunde != null)
                FelderAusKundeVorbefuellen(_bearbeiteterKunde);
            else
                lblKundenPK.Text = "Kundennummer: " + _kundenVerwaltung.NaechsteFreieNummer();
        }

        /// <summary>Füllt die Eingabefelder mit den Werten eines bestehenden Kunden.</summary>
        private void FelderAusKundeVorbefuellen(Kunde kunde)
        {
            lblKundenPK.Text = "Kundennummer: " + kunde.KundenNummer;
            txtKundeVorname.Text = kunde.Vorname;
            txtKundenNachname.Text = kunde.Nachname;
            txtKundeTel.Text = kunde.GeschäftsNummer;
            txtKundeMobil.Text = kunde.MobilNummer;
            txtKundeMail.Text = kunde.Email;
            dtpKundenContentGeburtsdatum.Value = kunde.Geburtsdatum;
            cmbKundenContentTitel.Text = kunde.Titel;
            cmbKundenContentAnrede.SelectedItem = kunde.Anrede;
            cmbKundenContentGeschlecht.SelectedItem = kunde.Geschlecht;
            rdbKundenContentActive.Checked = kunde.Status == Enums.Status.Aktiv;
            rdbKundenContentInactive.Checked = kunde.Status == Enums.Status.Inaktiv;

            // Schnappschuss der Ausgangswerte für die spätere Änderungserkennung.
            // Eigenes Objekt, nicht dieselbe Referenz wie "kunde" - sonst würde sich
            // der Schnappschuss mitverändern, sobald der Nutzer etwas eintippt.
            _originalZustand = new Kunde
            {
                Anrede = kunde.Anrede,
                Titel = kunde.Titel,
                Vorname = kunde.Vorname,
                Nachname = kunde.Nachname,
                Geburtsdatum = kunde.Geburtsdatum,
                Geschlecht = kunde.Geschlecht,
                GeschäftsNummer = kunde.GeschäftsNummer,
                MobilNummer = kunde.MobilNummer,
                Email = kunde.Email,
                Status = kunde.Status
            };
        }

        /// <summary>
        /// Prüft, ob sich mindestens ein Feld gegenüber dem Ausgangszustand geändert hat.
        /// Wird nur im Bearbeiten-Modus benötigt.
        /// </summary>
        private bool HatSichEtwasGeaendert()
        {
            if (_originalZustand == null)
                return true;

            return
                _originalZustand.Anrede != (Enums.Anrede)cmbKundenContentAnrede.SelectedItem ||
                _originalZustand.Titel != cmbKundenContentTitel.Text ||
                _originalZustand.Vorname != txtKundeVorname.Text ||
                _originalZustand.Nachname != txtKundenNachname.Text ||
                _originalZustand.Geburtsdatum != dtpKundenContentGeburtsdatum.Value ||
                _originalZustand.Geschlecht != (Enums.Geschlecht)cmbKundenContentGeschlecht.SelectedItem ||
                _originalZustand.GeschäftsNummer != txtKundeTel.Text ||
                _originalZustand.MobilNummer != txtKundeMobil.Text ||
                _originalZustand.Email != txtKundeMail.Text ||
                _originalZustand.Status != (rdbKundenContentActive.Checked ? Enums.Status.Aktiv : Enums.Status.Inaktiv);
        }

        /// <summary>
        /// Befüllt die Enum-basierten ComboBoxen dynamisch aus den Enum-Werten,
        /// statt sie im Designer hart zu codieren.
        /// </summary>
        private void ComboBoxenBefuellen()
        {
            cmbKundenContentAnrede.DataSource = Enum.GetValues(typeof(Enums.Anrede));
            cmbKundenContentGeschlecht.DataSource = Enum.GetValues(typeof(Enums.Geschlecht));
        }

        /// <summary>
        /// Überprüft, ob alle erforderlichen Felder ausgefüllt sind.
        /// </summary>
        /// <returns></returns>
        private bool RequiredFieldsFilled()
        {
            bool valid = true;

            lblKundenRequiredVorname.Visible =
                string.IsNullOrWhiteSpace(txtKundeVorname.Text);
            lblKundenRequiredNachname.Visible =
                string.IsNullOrWhiteSpace(txtKundenNachname.Text);
            lblKundenRequiredMobil.Visible =
                string.IsNullOrWhiteSpace(txtKundeMobil.Text);
            lblKundenRequiredMail.Visible =
                string.IsNullOrWhiteSpace(txtKundeMail.Text);
            lblKundenRequiredStatus.Visible =
                !rdbKundenContentActive.Checked && !rdbKundenContentInactive.Checked;

            if (lblKundenRequiredVorname.Visible ||
                lblKundenRequiredNachname.Visible ||
                lblKundenRequiredMobil.Visible ||
                lblKundenRequiredMail.Visible)
            {
                valid = false;
            }

            return valid;
        }




        private void InitializeComponent()
        {
            pnlKundenHeader = new Panel();
            lblKundeHeaderSubtitle = new Label();
            lblKundenHeaderTitle = new Label();
            lblKundenContentTitle1 = new Label();
            lblKundenContentGeburtsdatum = new Label();
            lblKundenContentGeschlecht = new Label();
            lblKundenContentTitleKD = new Label();
            lblKundenContentTel = new Label();
            lblKundenContentMobil = new Label();
            lblKundenContentMail = new Label();
            lblKundenContentAnrede = new Label();
            lblKundenContentTitel = new Label();
            lblKundenContentNachname = new Label();
            lblKundenContentStatus = new Label();
            txtKundeMobil = new TextBox();
            txtKundeMail = new TextBox();
            txtKundeVorname = new TextBox();
            txtKundenNachname = new TextBox();
            lblKundenContentVorname = new Label();
            txtKundeTel = new TextBox();
            rdbKundenContentActive = new RadioButton();
            rdbKundenContentInactive = new RadioButton();
            cmbKundenContentAnrede = new ComboBox();
            cmbKundenContentTitel = new ComboBox();
            cmbKundenContentGeschlecht = new ComboBox();
            dtpKundenContentGeburtsdatum = new DateTimePicker();
            pnlKundenFooter = new Panel();
            btnKundenFooterSpeichern = new Button();
            btnKundenFooterAbbrechen = new Button();
            pnlKundenContent = new Panel();
            lblKundenRequiredStatus = new Label();
            lblKundenPK = new Label();
            lblKundenRequiredMail = new Label();
            lblKundenRequiredMobil = new Label();
            lblKundenRequiredNachname = new Label();
            lblKundenRequiredVorname = new Label();
            pnlKundenHeader.SuspendLayout();
            pnlKundenFooter.SuspendLayout();
            pnlKundenContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlKundenHeader
            // 
            pnlKundenHeader.Controls.Add(lblKundeHeaderSubtitle);
            pnlKundenHeader.Controls.Add(lblKundenHeaderTitle);
            pnlKundenHeader.Location = new Point(0, 0);
            pnlKundenHeader.Name = "pnlKundenHeader";
            pnlKundenHeader.Size = new Size(601, 69);
            pnlKundenHeader.TabIndex = 0;
            // 
            // lblKundeHeaderSubtitle
            // 
            lblKundeHeaderSubtitle.AutoSize = true;
            lblKundeHeaderSubtitle.Location = new Point(11, 36);
            lblKundeHeaderSubtitle.Name = "lblKundeHeaderSubtitle";
            lblKundeHeaderSubtitle.Size = new Size(366, 25);
            lblKundeHeaderSubtitle.TabIndex = 1;
            lblKundeHeaderSubtitle.Text = "Persönliche Daten und Kontaktinformationen";
            // 
            // lblKundenHeaderTitle
            // 
            lblKundenHeaderTitle.AutoSize = true;
            lblKundenHeaderTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKundenHeaderTitle.Location = new Point(11, 8);
            lblKundenHeaderTitle.Name = "lblKundenHeaderTitle";
            lblKundenHeaderTitle.Size = new Size(280, 28);
            lblKundenHeaderTitle.TabIndex = 0;
            lblKundenHeaderTitle.Text = "Kunde erfassen / bearbeiten";
            // 
            // lblKundenContentTitle1
            // 
            lblKundenContentTitle1.AutoSize = true;
            lblKundenContentTitle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKundenContentTitle1.Location = new Point(105, 3);
            lblKundenContentTitle1.Name = "lblKundenContentTitle1";
            lblKundenContentTitle1.Size = new Size(165, 25);
            lblKundenContentTitle1.TabIndex = 3;
            lblKundenContentTitle1.Text = "Persönliche Daten";
            // 
            // lblKundenContentGeburtsdatum
            // 
            lblKundenContentGeburtsdatum.AutoSize = true;
            lblKundenContentGeburtsdatum.Location = new Point(105, 238);
            lblKundenContentGeburtsdatum.Name = "lblKundenContentGeburtsdatum";
            lblKundenContentGeburtsdatum.Size = new Size(130, 25);
            lblKundenContentGeburtsdatum.TabIndex = 5;
            lblKundenContentGeburtsdatum.Text = "Geburtsdatum:";
            // 
            // lblKundenContentGeschlecht
            // 
            lblKundenContentGeschlecht.AutoSize = true;
            lblKundenContentGeschlecht.Location = new Point(330, 238);
            lblKundenContentGeschlecht.Name = "lblKundenContentGeschlecht";
            lblKundenContentGeschlecht.Size = new Size(100, 25);
            lblKundenContentGeschlecht.TabIndex = 6;
            lblKundenContentGeschlecht.Text = "Geschlecht:";
            // 
            // lblKundenContentTitleKD
            // 
            lblKundenContentTitleKD.AutoSize = true;
            lblKundenContentTitleKD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKundenContentTitleKD.Location = new Point(105, 320);
            lblKundenContentTitleKD.Name = "lblKundenContentTitleKD";
            lblKundenContentTitleKD.Size = new Size(129, 25);
            lblKundenContentTitleKD.TabIndex = 7;
            lblKundenContentTitleKD.Text = "Kontaktdaten";
            // 
            // lblKundenContentTel
            // 
            lblKundenContentTel.AutoSize = true;
            lblKundenContentTel.Location = new Point(105, 350);
            lblKundenContentTel.Name = "lblKundenContentTel";
            lblKundenContentTel.Size = new Size(145, 25);
            lblKundenContentTel.TabIndex = 8;
            lblKundenContentTel.Text = "Telefon Geschäft:";
            // 
            // lblKundenContentMobil
            // 
            lblKundenContentMobil.AutoSize = true;
            lblKundenContentMobil.Location = new Point(330, 350);
            lblKundenContentMobil.Name = "lblKundenContentMobil";
            lblKundenContentMobil.Size = new Size(62, 25);
            lblKundenContentMobil.TabIndex = 9;
            lblKundenContentMobil.Text = "Mobil:";
            // 
            // lblKundenContentMail
            // 
            lblKundenContentMail.AutoSize = true;
            lblKundenContentMail.Location = new Point(330, 412);
            lblKundenContentMail.Name = "lblKundenContentMail";
            lblKundenContentMail.Size = new Size(65, 25);
            lblKundenContentMail.TabIndex = 10;
            lblKundenContentMail.Text = "E-Mail:";
            // 
            // lblKundenContentAnrede
            // 
            lblKundenContentAnrede.AutoSize = true;
            lblKundenContentAnrede.Location = new Point(105, 82);
            lblKundenContentAnrede.Name = "lblKundenContentAnrede";
            lblKundenContentAnrede.Size = new Size(73, 25);
            lblKundenContentAnrede.TabIndex = 11;
            lblKundenContentAnrede.Text = "Anrede:";
            // 
            // lblKundenContentTitel
            // 
            lblKundenContentTitel.AutoSize = true;
            lblKundenContentTitel.Location = new Point(330, 82);
            lblKundenContentTitel.Name = "lblKundenContentTitel";
            lblKundenContentTitel.Size = new Size(48, 25);
            lblKundenContentTitel.TabIndex = 12;
            lblKundenContentTitel.Text = "Titel:";
            // 
            // lblKundenContentNachname
            // 
            lblKundenContentNachname.AutoSize = true;
            lblKundenContentNachname.Location = new Point(330, 162);
            lblKundenContentNachname.Name = "lblKundenContentNachname";
            lblKundenContentNachname.Size = new Size(100, 25);
            lblKundenContentNachname.TabIndex = 14;
            lblKundenContentNachname.Text = "Nachname:";
            // 
            // lblKundenContentStatus
            // 
            lblKundenContentStatus.AutoSize = true;
            lblKundenContentStatus.Location = new Point(105, 412);
            lblKundenContentStatus.Name = "lblKundenContentStatus";
            lblKundenContentStatus.Size = new Size(64, 25);
            lblKundenContentStatus.TabIndex = 15;
            lblKundenContentStatus.Text = "Status:";
            // 
            // txtKundeMobil
            // 
            txtKundeMobil.Location = new Point(330, 377);
            txtKundeMobil.Name = "txtKundeMobil";
            txtKundeMobil.PlaceholderText = "0791234567";
            txtKundeMobil.Size = new Size(145, 31);
            txtKundeMobil.TabIndex = 7;
            txtKundeMobil.KeyPress += txtKundeMobil_KeyPress;
            // 
            // txtKundeMail
            // 
            txtKundeMail.Location = new Point(330, 439);
            txtKundeMail.Name = "txtKundeMail";
            txtKundeMail.PlaceholderText = "beispiel@mail.ch";
            txtKundeMail.Size = new Size(145, 31);
            txtKundeMail.TabIndex = 8;
            // 
            // txtKundeVorname
            // 
            txtKundeVorname.Location = new Point(105, 189);
            txtKundeVorname.Name = "txtKundeVorname";
            txtKundeVorname.PlaceholderText = "Vorname";
            txtKundeVorname.Size = new Size(145, 31);
            txtKundeVorname.TabIndex = 2;
            // 
            // txtKundenNachname
            // 
            txtKundenNachname.Location = new Point(330, 189);
            txtKundenNachname.Name = "txtKundenNachname";
            txtKundenNachname.PlaceholderText = "Nachname";
            txtKundenNachname.Size = new Size(145, 31);
            txtKundenNachname.TabIndex = 3;
            // 
            // lblKundenContentVorname
            // 
            lblKundenContentVorname.AutoSize = true;
            lblKundenContentVorname.Location = new Point(105, 162);
            lblKundenContentVorname.Name = "lblKundenContentVorname";
            lblKundenContentVorname.Size = new Size(87, 25);
            lblKundenContentVorname.TabIndex = 21;
            lblKundenContentVorname.Text = "Vorname:";
            // 
            // txtKundeTel
            // 
            txtKundeTel.Location = new Point(105, 377);
            txtKundeTel.Name = "txtKundeTel";
            txtKundeTel.PlaceholderText = "0791234567";
            txtKundeTel.Size = new Size(145, 31);
            txtKundeTel.TabIndex = 6;
            txtKundeTel.KeyPress += txtKundeTel_KeyPress;
            // 
            // rdbKundenContentActive
            // 
            rdbKundenContentActive.AutoSize = true;
            rdbKundenContentActive.Location = new Point(105, 441);
            rdbKundenContentActive.Name = "rdbKundenContentActive";
            rdbKundenContentActive.Size = new Size(77, 29);
            rdbKundenContentActive.TabIndex = 9;
            rdbKundenContentActive.TabStop = true;
            rdbKundenContentActive.Text = "Aktiv";
            rdbKundenContentActive.UseVisualStyleBackColor = true;
            // 
            // rdbKundenContentInactive
            // 
            rdbKundenContentInactive.AutoSize = true;
            rdbKundenContentInactive.Location = new Point(185, 441);
            rdbKundenContentInactive.Name = "rdbKundenContentInactive";
            rdbKundenContentInactive.Size = new Size(89, 29);
            rdbKundenContentInactive.TabIndex = 10;
            rdbKundenContentInactive.TabStop = true;
            rdbKundenContentInactive.Text = "Inaktiv";
            rdbKundenContentInactive.UseVisualStyleBackColor = true;
            // 
            // cmbKundenContentAnrede
            // 
            cmbKundenContentAnrede.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKundenContentAnrede.FormattingEnabled = true;
            cmbKundenContentAnrede.Location = new Point(105, 110);
            cmbKundenContentAnrede.Name = "cmbKundenContentAnrede";
            cmbKundenContentAnrede.Size = new Size(145, 33);
            cmbKundenContentAnrede.TabIndex = 0;
            // 
            // cmbKundenContentTitel
            // 
            cmbKundenContentTitel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKundenContentTitel.FormattingEnabled = true;
            cmbKundenContentTitel.Items.AddRange(new object[] { "Dr.", "Prof.", "Dr. med.", "Ing.", "MSc.", "BSc.", " " });
            cmbKundenContentTitel.Location = new Point(330, 110);
            cmbKundenContentTitel.Name = "cmbKundenContentTitel";
            cmbKundenContentTitel.Size = new Size(145, 33);
            cmbKundenContentTitel.TabIndex = 1;
            // 
            // cmbKundenContentGeschlecht
            // 
            cmbKundenContentGeschlecht.FormattingEnabled = true;
            cmbKundenContentGeschlecht.Location = new Point(330, 269);
            cmbKundenContentGeschlecht.Name = "cmbKundenContentGeschlecht";
            cmbKundenContentGeschlecht.Size = new Size(145, 33);
            cmbKundenContentGeschlecht.TabIndex = 5;
            // 
            // dtpKundenContentGeburtsdatum
            // 
            dtpKundenContentGeburtsdatum.Format = DateTimePickerFormat.Short;
            dtpKundenContentGeburtsdatum.Location = new Point(105, 269);
            dtpKundenContentGeburtsdatum.MaxDate = new DateTime(2026, 8, 30, 0, 0, 0, 0);
            dtpKundenContentGeburtsdatum.Name = "dtpKundenContentGeburtsdatum";
            dtpKundenContentGeburtsdatum.Size = new Size(145, 31);
            dtpKundenContentGeburtsdatum.TabIndex = 4;
            dtpKundenContentGeburtsdatum.Value = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // pnlKundenFooter
            // 
            pnlKundenFooter.Controls.Add(btnKundenFooterSpeichern);
            pnlKundenFooter.Controls.Add(btnKundenFooterAbbrechen);
            pnlKundenFooter.Location = new Point(0, 581);
            pnlKundenFooter.Name = "pnlKundenFooter";
            pnlKundenFooter.Size = new Size(601, 50);
            pnlKundenFooter.TabIndex = 2;
            // 
            // btnKundenFooterSpeichern
            // 
            btnKundenFooterSpeichern.Location = new Point(445, 6);
            btnKundenFooterSpeichern.Name = "btnKundenFooterSpeichern";
            btnKundenFooterSpeichern.Size = new Size(121, 34);
            btnKundenFooterSpeichern.TabIndex = 12;
            btnKundenFooterSpeichern.Text = "Speichern";
            btnKundenFooterSpeichern.UseVisualStyleBackColor = true;
            btnKundenFooterSpeichern.Click += btnKundenFooterSpeichern_Click_1;
            // 
            // btnKundenFooterAbbrechen
            // 
            btnKundenFooterAbbrechen.Location = new Point(318, 6);
            btnKundenFooterAbbrechen.Name = "btnKundenFooterAbbrechen";
            btnKundenFooterAbbrechen.Size = new Size(121, 34);
            btnKundenFooterAbbrechen.TabIndex = 11;
            btnKundenFooterAbbrechen.Text = "Abbrechen";
            btnKundenFooterAbbrechen.UseVisualStyleBackColor = true;
            btnKundenFooterAbbrechen.Click += btnKundenFooterAbbrechen_Click;
            // 
            // pnlKundenContent
            // 
            pnlKundenContent.Controls.Add(lblKundenRequiredStatus);
            pnlKundenContent.Controls.Add(lblKundenPK);
            pnlKundenContent.Controls.Add(lblKundenRequiredMail);
            pnlKundenContent.Controls.Add(lblKundenRequiredMobil);
            pnlKundenContent.Controls.Add(lblKundenRequiredNachname);
            pnlKundenContent.Controls.Add(lblKundenRequiredVorname);
            pnlKundenContent.Controls.Add(rdbKundenContentInactive);
            pnlKundenContent.Controls.Add(rdbKundenContentActive);
            pnlKundenContent.Controls.Add(lblKundenContentStatus);
            pnlKundenContent.Controls.Add(lblKundenContentMail);
            pnlKundenContent.Controls.Add(txtKundeMail);
            pnlKundenContent.Controls.Add(lblKundenContentMobil);
            pnlKundenContent.Controls.Add(lblKundenContentTel);
            pnlKundenContent.Controls.Add(txtKundeMobil);
            pnlKundenContent.Controls.Add(lblKundenContentTitleKD);
            pnlKundenContent.Controls.Add(lblKundenContentGeschlecht);
            pnlKundenContent.Controls.Add(lblKundenContentGeburtsdatum);
            pnlKundenContent.Controls.Add(lblKundenContentTitle1);
            pnlKundenContent.Controls.Add(txtKundeTel);
            pnlKundenContent.Controls.Add(lblKundenContentAnrede);
            pnlKundenContent.Controls.Add(cmbKundenContentAnrede);
            pnlKundenContent.Controls.Add(lblKundenContentTitel);
            pnlKundenContent.Controls.Add(cmbKundenContentTitel);
            pnlKundenContent.Controls.Add(lblKundenContentVorname);
            pnlKundenContent.Controls.Add(lblKundenContentNachname);
            pnlKundenContent.Controls.Add(txtKundeVorname);
            pnlKundenContent.Controls.Add(cmbKundenContentGeschlecht);
            pnlKundenContent.Controls.Add(txtKundenNachname);
            pnlKundenContent.Controls.Add(dtpKundenContentGeburtsdatum);
            pnlKundenContent.Location = new Point(0, 69);
            pnlKundenContent.Name = "pnlKundenContent";
            pnlKundenContent.Size = new Size(601, 512);
            pnlKundenContent.TabIndex = 3;
            // 
            // lblKundenRequiredStatus
            // 
            lblKundenRequiredStatus.AutoSize = true;
            lblKundenRequiredStatus.ForeColor = Color.Red;
            lblKundenRequiredStatus.Location = new Point(162, 413);
            lblKundenRequiredStatus.Name = "lblKundenRequiredStatus";
            lblKundenRequiredStatus.Size = new Size(20, 25);
            lblKundenRequiredStatus.TabIndex = 33;
            lblKundenRequiredStatus.Text = "*";
            // 
            // lblKundenPK
            // 
            lblKundenPK.AutoSize = true;
            lblKundenPK.Location = new Point(105, 44);
            lblKundenPK.Name = "lblKundenPK";
            lblKundenPK.Size = new Size(143, 25);
            lblKundenPK.TabIndex = 34;
            lblKundenPK.Text = "Kundennummer:";
            // 
            // lblKundenRequiredMail
            // 
            lblKundenRequiredMail.AutoSize = true;
            lblKundenRequiredMail.ForeColor = Color.Red;
            lblKundenRequiredMail.Location = new Point(479, 443);
            lblKundenRequiredMail.Name = "lblKundenRequiredMail";
            lblKundenRequiredMail.Size = new Size(20, 25);
            lblKundenRequiredMail.TabIndex = 32;
            lblKundenRequiredMail.Text = "*";
            // 
            // lblKundenRequiredMobil
            // 
            lblKundenRequiredMobil.AutoSize = true;
            lblKundenRequiredMobil.ForeColor = Color.Red;
            lblKundenRequiredMobil.Location = new Point(481, 381);
            lblKundenRequiredMobil.Name = "lblKundenRequiredMobil";
            lblKundenRequiredMobil.Size = new Size(20, 25);
            lblKundenRequiredMobil.TabIndex = 31;
            lblKundenRequiredMobil.Text = "*";
            // 
            // lblKundenRequiredNachname
            // 
            lblKundenRequiredNachname.AutoSize = true;
            lblKundenRequiredNachname.ForeColor = Color.Red;
            lblKundenRequiredNachname.Location = new Point(481, 193);
            lblKundenRequiredNachname.Name = "lblKundenRequiredNachname";
            lblKundenRequiredNachname.Size = new Size(20, 25);
            lblKundenRequiredNachname.TabIndex = 30;
            lblKundenRequiredNachname.Text = "*";
            // 
            // lblKundenRequiredVorname
            // 
            lblKundenRequiredVorname.AutoSize = true;
            lblKundenRequiredVorname.ForeColor = Color.Red;
            lblKundenRequiredVorname.Location = new Point(256, 193);
            lblKundenRequiredVorname.Name = "lblKundenRequiredVorname";
            lblKundenRequiredVorname.Size = new Size(20, 25);
            lblKundenRequiredVorname.TabIndex = 29;
            lblKundenRequiredVorname.Text = "*";
            // 
            // KundenForm
            // 
            ClientSize = new Size(601, 631);
            Controls.Add(pnlKundenContent);
            Controls.Add(pnlKundenFooter);
            Controls.Add(pnlKundenHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "KundenForm";
            Text = "Kunden";
            pnlKundenHeader.ResumeLayout(false);
            pnlKundenHeader.PerformLayout();
            pnlKundenFooter.ResumeLayout(false);
            pnlKundenContent.ResumeLayout(false);
            pnlKundenContent.PerformLayout();
            ResumeLayout(false);

        }

        /// <summary>
        /// Validates the email address format.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private bool IsValidEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(
                email.Trim(),
                @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"
            );
        }

        // Validiert die Eingabe der Telefonnummer, sodass nur Ziffern, Steuerzeichen und das Pluszeichen erlaubt sind.
        private void txtKundeTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Validiert die Eingabe der Mobilnummer, sodass nur Ziffern, Steuerzeichen und das Pluszeichen erlaubt sind.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKundeMobil_KeyPress(object sender, KeyPressEventArgs e)
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
                @"^0\d{9}$"
            );
        }

        /// <summary>
        /// Event-Handler für den Speichern-Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKundenFooterSpeichern_Click_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtKundeTel.Text))

                // Validierung der Telefonnummer
                if (!IsValidPhoneNumber(txtKundeTel.Text))
                {
                    MessageBox.Show("Bitte geben Sie eine gültige Telefonnummer ein.");
                    txtKundeTel.Focus();
                    return;
                }


            // Validierung der Mobilnummer
            if (!IsValidPhoneNumber(txtKundeMobil.Text))
            {
                MessageBox.Show("Bitte geben Sie eine gültige Telefonnummer ein.");
                txtKundeMobil.Focus();
                return;
            }


            // Validierung der E-Mail-Adresse
            if (!IsValidEmail(txtKundeMail.Text))
            {
                MessageBox.Show("Bitte geben Sie eine gültige E-Mail-Adresse ein.");
                txtKundeMail.Focus();
                return;
            }


            if (!RequiredFieldsFilled())
            {
                MessageBox.Show("Fülle alle Felder aus, die mit * markiert sind.");
                return;
            }

            if (_bearbeiteterKunde != null)
            {
                if (!HatSichEtwasGeaendert())
                {
                    MessageBox.Show("Es wurden keine Änderungen vorgenommen.");
                    Close();
                    return;
                }

                _bearbeiteterKunde.Anrede = (Enums.Anrede)cmbKundenContentAnrede.SelectedItem;
                _bearbeiteterKunde.Titel = cmbKundenContentTitel.Text;
                _bearbeiteterKunde.Vorname = txtKundeVorname.Text;
                _bearbeiteterKunde.Nachname = txtKundenNachname.Text;
                _bearbeiteterKunde.Geburtsdatum = dtpKundenContentGeburtsdatum.Value;
                _bearbeiteterKunde.Geschlecht = (Enums.Geschlecht)cmbKundenContentGeschlecht.SelectedItem;
                _bearbeiteterKunde.GeschäftsNummer = txtKundeTel.Text;
                _bearbeiteterKunde.MobilNummer = txtKundeMobil.Text;
                _bearbeiteterKunde.Email = txtKundeMail.Text;
                _bearbeiteterKunde.Status = rdbKundenContentActive.Checked ? Enums.Status.Aktiv : Enums.Status.Inaktiv;

                _kundenVerwaltung.Bearbeiten(_bearbeiteterKunde);
                _kundenVerwaltung.Speichern();

                MessageBox.Show("Kunde aktualisiert.");
                Close();
            }
            else
            {
                Kunde kunde = new Kunde
                {
                    Anrede = (Enums.Anrede)cmbKundenContentAnrede.SelectedItem,
                    Titel = cmbKundenContentTitel.Text,
                    Vorname = txtKundeVorname.Text,
                    Nachname = txtKundenNachname.Text,
                    Geburtsdatum = dtpKundenContentGeburtsdatum.Value,
                    Geschlecht = (Enums.Geschlecht)cmbKundenContentGeschlecht.SelectedItem,
                    GeschäftsNummer = txtKundeTel.Text,
                    MobilNummer = txtKundeMobil.Text,
                    Email = txtKundeMail.Text,
                    Status = rdbKundenContentActive.Checked ? Enums.Status.Aktiv : Enums.Status.Inaktiv
                };

                _kundenVerwaltung.Hinzufuegen(kunde);
                _kundenVerwaltung.Speichern();

                MessageBox.Show("Kunde erfolgreich gespeichert.");
                FelderZuruecksetzen();
            }
        }

        /// <summary>
        /// Setzt alle Eingabefelder auf den Ausgangszustand zurück,
        /// damit direkt der nächste Kunde erfasst werden kann.
        /// </summary>
        private void FelderZuruecksetzen()
        {
            txtKundeVorname.Clear();
            txtKundenNachname.Clear();
            txtKundeTel.Clear();
            txtKundeMobil.Clear();
            txtKundeMail.Clear();
            cmbKundenContentTitel.SelectedIndex = -1;
            cmbKundenContentAnrede.SelectedIndex = 0;
            cmbKundenContentGeschlecht.SelectedIndex = 0;
            // MaxDate statt DateTime.Now, weil das Feld nur Daten bis 2025 zulässt
            dtpKundenContentGeburtsdatum.Value = dtpKundenContentGeburtsdatum.MaxDate;
            rdbKundenContentActive.Checked = false;
            rdbKundenContentInactive.Checked = false;
            // Fokus zurück auf das erste Feld, damit man gleich lostippen kann
            txtKundeVorname.Focus();

            //Neu: Label mit der Nummer für den NàCHSTEN Kunden aktualisieren,
            //sonst zeigt es nach dem Speicher weiterhin die alte (bereits vergebene) Nummer an.
            lblKundenPK.Text = "Kundennummer: " + _kundenVerwaltung.NaechsteFreieNummer();
        }

        /// <summary>
        /// Event-Handler für den Abbrechen-Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKundenFooterAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
