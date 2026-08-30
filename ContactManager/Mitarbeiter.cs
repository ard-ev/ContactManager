using ContactManager.Models;
using ContactManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class MitarbeiterForm : Form
    {
        public MitarbeiterForm()
        {
            InitializeComponent();
            lblMitarbeiterAustritt.Visible = false;
            dtpMitarbeiterAustritt.Visible = false;
            txtMitarbeiterAHV.Text = "756.";
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblMitarbeiterHeaderSubtitle = new Label();
            lblMitarbeiterHeaderTitel = new Label();
            pnlMitarbeiterFooter = new Panel();
            btnMitarbeiterFooterSpeichern = new Button();
            btnMitarbeiterCancel = new Button();
            pnlMitarbeiterContent = new Panel();
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
            this.rdbMitarbeiterAktiv = new RadioButton();
            this.rdbMitarbeiterInaktiv = new RadioButton();
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
            lblMitarbeiterHeaderSubtitle.Size = new Size(147, 15);
            lblMitarbeiterHeaderSubtitle.TabIndex = 1;
            lblMitarbeiterHeaderSubtitle.Text = "Mitarbeiterdaten eingeben";
            // 
            // lblMitarbeiterHeaderTitel
            // 
            lblMitarbeiterHeaderTitel.AutoSize = true;
            lblMitarbeiterHeaderTitel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMitarbeiterHeaderTitel.Location = new Point(10, 7);
            lblMitarbeiterHeaderTitel.Name = "lblMitarbeiterHeaderTitel";
            lblMitarbeiterHeaderTitel.Size = new Size(231, 19);
            lblMitarbeiterHeaderTitel.TabIndex = 0;
            lblMitarbeiterHeaderTitel.Text = "Mitarbeiter erfassen / bearbeiten";
            // 
            // pnlMitarbeiterFooter
            // 
            pnlMitarbeiterFooter.Controls.Add(btnMitarbeiterFooterSpeichern);
            pnlMitarbeiterFooter.Controls.Add(btnMitarbeiterCancel);
            pnlMitarbeiterFooter.Location = new Point(2, 579);
            pnlMitarbeiterFooter.Name = "pnlMitarbeiterFooter";
            pnlMitarbeiterFooter.Size = new Size(598, 50);
            pnlMitarbeiterFooter.TabIndex = 1;
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
            pnlMitarbeiterContent.Controls.Add(this.rdbMitarbeiterInaktiv);
            pnlMitarbeiterContent.Controls.Add(this.rdbMitarbeiterAktiv);
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
            // lblMitarbeiterStatus
            // 
            lblMitarbeiterStatus.AutoSize = true;
            lblMitarbeiterStatus.Location = new Point(247, 438);
            lblMitarbeiterStatus.Name = "lblMitarbeiterStatus";
            lblMitarbeiterStatus.Size = new Size(42, 15);
            lblMitarbeiterStatus.TabIndex = 31;
            lblMitarbeiterStatus.Text = "Status:";
            // 
            // cmbMitarbeiterAbteilung
            // 
            cmbMitarbeiterAbteilung.FormattingEnabled = true;
            cmbMitarbeiterAbteilung.Location = new Point(7, 159);
            cmbMitarbeiterAbteilung.Name = "cmbMitarbeiterAbteilung";
            cmbMitarbeiterAbteilung.Size = new Size(182, 23);
            cmbMitarbeiterAbteilung.TabIndex = 30;
            // 
            // ckbMitarbeiterBefristet
            // 
            ckbMitarbeiterBefristet.AutoSize = true;
            ckbMitarbeiterBefristet.Location = new Point(247, 543);
            ckbMitarbeiterBefristet.Name = "ckbMitarbeiterBefristet";
            ckbMitarbeiterBefristet.Size = new Size(69, 19);
            ckbMitarbeiterBefristet.TabIndex = 12;
            ckbMitarbeiterBefristet.Text = "Befristet";
            ckbMitarbeiterBefristet.UseVisualStyleBackColor = true;
            ckbMitarbeiterBefristet.CheckedChanged += ckbMitarbeiterBefristet_CheckedChanged;
            // 
            // cmbMitarbeiterNationalität
            // 
            cmbMitarbeiterNationalität.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cmbMitarbeiterNationalität.FormattingEnabled = true;
            cmbMitarbeiterNationalität.Items.AddRange(new object[] { "Afghanistan", "Ägypten", "Albanien", "Algerien", "Andorra", "Angola", "Antigua und Barbuda", "Äquatorialguinea", "Argentinien", "Armenien", "Aserbaidschan", "Äthiopien", "Australien", "Bahamas", "Bahrain", "Bangladesch", "Barbados", "Belarus", "Belgien", "Belize", "Benin", "Bhutan", "Bolivien", "Bosnien und Herzegowina", "Botswana", "Brasilien", "Brunei", "Bulgarien", "Burkina Faso", "Burundi", "Chile", "China", "Costa Rica", "Dänemark", "Deutschland", "Dominica", "Dominikanische Republik", "Dschibuti", "Ecuador", "El Salvador", "Elfenbeinküste", "Eritrea", "Estland", "Eswatini", "Fidschi", "Finnland", "Frankreich", "Gabun", "Gambia", "Georgien", "Ghana", "Grenada", "Griechenland", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Indien", "Indonesien", "Irak", "Iran", "Irland", "Island", "Israel", "Italien", "Jamaika", "Japan", "Jemen", "Jordanien", "Kambodscha", "Kamerun", "Kanada", "Kap Verde", "Kasachstan", "Katar", "Kenia", "Kirgisistan", "Kiribati", "Kolumbien", "Komoren", "Kongo, Demokratische Republik", "Kongo, Republik", "Kroatien", "Kuba", "Kuwait", "Laos", "Lesotho", "Lettland", "Libanon", "Liberia", "Libyen", "Liechtenstein", "Litauen", "Luxemburg", "Madagaskar", "Malawi", "Malaysia", "Malediven", "Mali", "Malta", "Marokko", "Marshallinseln", "Mauretanien", "Mauritius", "Mexiko", "Mikronesien", "Moldau", "Monaco", "Mongolei", "Montenegro", "Mosambik", "Myanmar", "Namibia", "Nauru", "Nepal", "Neuseeland", "Nicaragua", "Niederlande", "Niger", "Nigeria", "Nordkorea", "Nordmazedonien", "Norwegen", "Oman", "Österreich", "Pakistan", "Palästina", "Palau", "Panama", "Papua-Neuguinea", "Paraguay", "Peru", "Philippinen", "Polen", "Portugal", "Ruanda", "Rumänien", "Russland", "Salomonen", "Sambia", "Samoa", "San Marino", "São Tomé und Príncipe", "Saudi-Arabien", "Schweden", "Schweiz", "Senegal", "Serbien", "Seychellen", "Sierra Leone", "Simbabwe", "Singapur", "Slowakei", "Slowenien", "Somalia", "Spanien", "Sri Lanka", "St. Kitts und Nevis", "St. Lucia", "St. Vincent und die Grenadinen", "Südafrika", "Sudan", "Südkorea", "Südsudan", "Suriname", "Syrien", "Tadschikistan", "Tansania", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad und Tobago", "Tschad", "Tschechien", "Tunesien", "Türkei", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "Ungarn", "Uruguay", "Usbekistan", "Vanuatu", "Vatikanstadt", "Venezuela", "Vereinigte Arabische Emirate", "Vereinigte Staaten", "Vereinigtes Königreich", "Vietnam", "Zentralafrikanische Republik", "Zypern" });
            cmbMitarbeiterNationalität.Location = new Point(247, 381);
            cmbMitarbeiterNationalität.Name = "cmbMitarbeiterNationalität";
            cmbMitarbeiterNationalität.Size = new Size(182, 23);
            cmbMitarbeiterNationalität.TabIndex = 9;
            cmbMitarbeiterNationalität.Text = "Nationalität";
            // 
            // txtMitarbeiterRolle
            // 
            txtMitarbeiterRolle.Location = new Point(247, 159);
            txtMitarbeiterRolle.Name = "txtMitarbeiterRolle";
            txtMitarbeiterRolle.Size = new Size(182, 23);
            txtMitarbeiterRolle.TabIndex = 3;
            // 
            // txtMitarbeiterOrt
            // 
            txtMitarbeiterOrt.Location = new Point(7, 381);
            txtMitarbeiterOrt.Name = "txtMitarbeiterOrt";
            txtMitarbeiterOrt.PlaceholderText = "Wohnort";
            txtMitarbeiterOrt.Size = new Size(182, 23);
            txtMitarbeiterOrt.TabIndex = 8;
            // 
            // numMitarbeiterPensum
            // 
            numMitarbeiterPensum.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numMitarbeiterPensum.Location = new Point(7, 607);
            numMitarbeiterPensum.Name = "numMitarbeiterPensum";
            numMitarbeiterPensum.Size = new Size(182, 23);
            numMitarbeiterPensum.TabIndex = 13;
            numMitarbeiterPensum.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // lblMitarbeiterPensum
            // 
            lblMitarbeiterPensum.AutoSize = true;
            lblMitarbeiterPensum.Location = new Point(7, 589);
            lblMitarbeiterPensum.Name = "lblMitarbeiterPensum";
            lblMitarbeiterPensum.Size = new Size(53, 15);
            lblMitarbeiterPensum.TabIndex = 29;
            lblMitarbeiterPensum.Text = "Pensum:";
            // 
            // dtpMitarbeiterAustritt
            // 
            dtpMitarbeiterAustritt.Format = DateTimePickerFormat.Short;
            dtpMitarbeiterAustritt.Location = new Point(247, 607);
            dtpMitarbeiterAustritt.Name = "dtpMitarbeiterAustritt";
            dtpMitarbeiterAustritt.Size = new Size(182, 23);
            dtpMitarbeiterAustritt.TabIndex = 14;
            // 
            // dtpMitarbeiterEintritt
            // 
            dtpMitarbeiterEintritt.Format = DateTimePickerFormat.Short;
            dtpMitarbeiterEintritt.Location = new Point(7, 543);
            dtpMitarbeiterEintritt.Name = "dtpMitarbeiterEintritt";
            dtpMitarbeiterEintritt.Size = new Size(178, 23);
            dtpMitarbeiterEintritt.TabIndex = 11;
            dtpMitarbeiterEintritt.Value = new DateTime(2026, 8, 30, 14, 9, 14, 0);
            // 
            // lblMitarbeiterAustritt
            // 
            lblMitarbeiterAustritt.AutoSize = true;
            lblMitarbeiterAustritt.Location = new Point(247, 589);
            lblMitarbeiterAustritt.Name = "lblMitarbeiterAustritt";
            lblMitarbeiterAustritt.Size = new Size(49, 15);
            lblMitarbeiterAustritt.TabIndex = 25;
            lblMitarbeiterAustritt.Text = "Austritt:";
            // 
            // lblMitarbeiterEintritt
            // 
            lblMitarbeiterEintritt.AutoSize = true;
            lblMitarbeiterEintritt.Location = new Point(7, 525);
            lblMitarbeiterEintritt.Name = "lblMitarbeiterEintritt";
            lblMitarbeiterEintritt.Size = new Size(45, 15);
            lblMitarbeiterEintritt.TabIndex = 24;
            lblMitarbeiterEintritt.Text = "Eintritt:";
            // 
            // txtMitarbeiterMobil
            // 
            txtMitarbeiterMobil.Location = new Point(7, 456);
            txtMitarbeiterMobil.Name = "txtMitarbeiterMobil";
            txtMitarbeiterMobil.PlaceholderText = "0791234567";
            txtMitarbeiterMobil.Size = new Size(178, 23);
            txtMitarbeiterMobil.TabIndex = 10;
            // 
            // lblMitarbeiterMobilnummer
            // 
            lblMitarbeiterMobilnummer.AutoSize = true;
            lblMitarbeiterMobilnummer.Location = new Point(7, 438);
            lblMitarbeiterMobilnummer.Name = "lblMitarbeiterMobilnummer";
            lblMitarbeiterMobilnummer.Size = new Size(87, 15);
            lblMitarbeiterMobilnummer.TabIndex = 22;
            lblMitarbeiterMobilnummer.Text = "Mobilnummer:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 363);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 19;
            label1.Text = "Nationalität:";
            // 
            // lblMitarbeiterWohnort
            // 
            lblMitarbeiterWohnort.AutoSize = true;
            lblMitarbeiterWohnort.Location = new Point(7, 363);
            lblMitarbeiterWohnort.Name = "lblMitarbeiterWohnort";
            lblMitarbeiterWohnort.Size = new Size(57, 15);
            lblMitarbeiterWohnort.TabIndex = 18;
            lblMitarbeiterWohnort.Text = "Wohnort:";
            // 
            // txtMitarbeiterPLZ
            // 
            txtMitarbeiterPLZ.Location = new Point(247, 307);
            txtMitarbeiterPLZ.Name = "txtMitarbeiterPLZ";
            txtMitarbeiterPLZ.PlaceholderText = "9001";
            txtMitarbeiterPLZ.Size = new Size(182, 23);
            txtMitarbeiterPLZ.TabIndex = 7;
            // 
            // txtMitarbeiterAdresse
            // 
            txtMitarbeiterAdresse.Location = new Point(7, 307);
            txtMitarbeiterAdresse.Name = "txtMitarbeiterAdresse";
            txtMitarbeiterAdresse.PlaceholderText = "Musterstrasse 1";
            txtMitarbeiterAdresse.Size = new Size(182, 23);
            txtMitarbeiterAdresse.TabIndex = 6;
            // 
            // lblMitarbeiterPLZ
            // 
            lblMitarbeiterPLZ.AutoSize = true;
            lblMitarbeiterPLZ.Location = new Point(247, 289);
            lblMitarbeiterPLZ.Name = "lblMitarbeiterPLZ";
            lblMitarbeiterPLZ.Size = new Size(30, 15);
            lblMitarbeiterPLZ.TabIndex = 15;
            lblMitarbeiterPLZ.Text = "PLZ:";
            // 
            // lblMitarbeiterAdresse
            // 
            lblMitarbeiterAdresse.AutoSize = true;
            lblMitarbeiterAdresse.Location = new Point(7, 289);
            lblMitarbeiterAdresse.Name = "lblMitarbeiterAdresse";
            lblMitarbeiterAdresse.Size = new Size(51, 15);
            lblMitarbeiterAdresse.TabIndex = 14;
            lblMitarbeiterAdresse.Text = "Adresse:";
            // 
            // txtMitarbeiterAHV
            // 
            txtMitarbeiterAHV.Location = new Point(247, 232);
            txtMitarbeiterAHV.Name = "txtMitarbeiterAHV";
            txtMitarbeiterAHV.PlaceholderText = "756.1234.1234.12";
            txtMitarbeiterAHV.Size = new Size(182, 23);
            txtMitarbeiterAHV.TabIndex = 5;
            // 
            // cmbMitarbeiterKadder
            // 
            cmbMitarbeiterKadder.FormattingEnabled = true;
            cmbMitarbeiterKadder.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5" });
            cmbMitarbeiterKadder.Location = new Point(7, 231);
            cmbMitarbeiterKadder.Name = "cmbMitarbeiterKadder";
            cmbMitarbeiterKadder.Size = new Size(182, 23);
            cmbMitarbeiterKadder.TabIndex = 4;
            cmbMitarbeiterKadder.Text = "0";
            // 
            // lblMitarbeiterAHV
            // 
            lblMitarbeiterAHV.AutoSize = true;
            lblMitarbeiterAHV.Location = new Point(247, 214);
            lblMitarbeiterAHV.Name = "lblMitarbeiterAHV";
            lblMitarbeiterAHV.Size = new Size(87, 15);
            lblMitarbeiterAHV.TabIndex = 11;
            lblMitarbeiterAHV.Text = "AHV-Nummer:";
            // 
            // lblMitarbeiterKaderstufe
            // 
            lblMitarbeiterKaderstufe.AutoSize = true;
            lblMitarbeiterKaderstufe.Location = new Point(7, 214);
            lblMitarbeiterKaderstufe.Name = "lblMitarbeiterKaderstufe";
            lblMitarbeiterKaderstufe.Size = new Size(66, 15);
            lblMitarbeiterKaderstufe.TabIndex = 10;
            lblMitarbeiterKaderstufe.Text = "Kaderstufe:";
            // 
            // txtMitarbeiterNachname
            // 
            txtMitarbeiterNachname.Location = new Point(247, 91);
            txtMitarbeiterNachname.Name = "txtMitarbeiterNachname";
            txtMitarbeiterNachname.PlaceholderText = "Nachname";
            txtMitarbeiterNachname.Size = new Size(182, 23);
            txtMitarbeiterNachname.TabIndex = 1;
            // 
            // lblMitarbeiterRolle
            // 
            lblMitarbeiterRolle.AutoSize = true;
            lblMitarbeiterRolle.Location = new Point(247, 141);
            lblMitarbeiterRolle.Name = "lblMitarbeiterRolle";
            lblMitarbeiterRolle.Size = new Size(36, 15);
            lblMitarbeiterRolle.TabIndex = 6;
            lblMitarbeiterRolle.Text = "Rolle:";
            // 
            // lblMitarbeiterAbteilung
            // 
            lblMitarbeiterAbteilung.AutoSize = true;
            lblMitarbeiterAbteilung.Location = new Point(7, 141);
            lblMitarbeiterAbteilung.Name = "lblMitarbeiterAbteilung";
            lblMitarbeiterAbteilung.Size = new Size(62, 15);
            lblMitarbeiterAbteilung.TabIndex = 5;
            lblMitarbeiterAbteilung.Text = "Abteilung:";
            // 
            // txtMitarbeiterVorname
            // 
            txtMitarbeiterVorname.Location = new Point(7, 91);
            txtMitarbeiterVorname.Name = "txtMitarbeiterVorname";
            txtMitarbeiterVorname.PlaceholderText = "Vorname";
            txtMitarbeiterVorname.Size = new Size(182, 23);
            txtMitarbeiterVorname.TabIndex = 0;
            // 
            // lblMitarbeiterNachname
            // 
            lblMitarbeiterNachname.AutoSize = true;
            lblMitarbeiterNachname.Location = new Point(247, 73);
            lblMitarbeiterNachname.Name = "lblMitarbeiterNachname";
            lblMitarbeiterNachname.Size = new Size(68, 15);
            lblMitarbeiterNachname.TabIndex = 3;
            lblMitarbeiterNachname.Text = "Nachname:";
            // 
            // lblMitarbeiterVorname
            // 
            lblMitarbeiterVorname.AutoSize = true;
            lblMitarbeiterVorname.Location = new Point(7, 73);
            lblMitarbeiterVorname.Name = "lblMitarbeiterVorname";
            lblMitarbeiterVorname.Size = new Size(57, 15);
            lblMitarbeiterVorname.TabIndex = 2;
            lblMitarbeiterVorname.Text = "Vorname:";
            // 
            // lblMitarbeiterPK
            // 
            lblMitarbeiterPK.AutoSize = true;
            lblMitarbeiterPK.Location = new Point(7, 17);
            lblMitarbeiterPK.Name = "lblMitarbeiterPK";
            lblMitarbeiterPK.Size = new Size(114, 15);
            lblMitarbeiterPK.TabIndex = 0;
            lblMitarbeiterPK.Text = "Mitarbeiternummer:";
            // 
            // rdbMitarbeiterAktiv
            // 
            this.rdbMitarbeiterAktiv.AutoSize = true;
            this.rdbMitarbeiterAktiv.Location = new Point(247, 460);
            this.rdbMitarbeiterAktiv.Name = "rdbMitarbeiterAktiv";
            this.rdbMitarbeiterAktiv.Size = new Size(52, 19);
            this.rdbMitarbeiterAktiv.TabIndex = 32;
            this.rdbMitarbeiterAktiv.TabStop = true;
            this.rdbMitarbeiterAktiv.Text = "Aktiv";
            this.rdbMitarbeiterAktiv.UseVisualStyleBackColor = true;
            // 
            // rdbMitarbeiterInaktiv
            // 
            this.rdbMitarbeiterInaktiv.AutoSize = true;
            this.rdbMitarbeiterInaktiv.Location = new Point(317, 460);
            this.rdbMitarbeiterInaktiv.Name = "rdbMitarbeiterInaktiv";
            this.rdbMitarbeiterInaktiv.Size = new Size(60, 19);
            this.rdbMitarbeiterInaktiv.TabIndex = 33;
            this.rdbMitarbeiterInaktiv.TabStop = true;
            this.rdbMitarbeiterInaktiv.Text = "Inaktiv";
            this.rdbMitarbeiterInaktiv.UseVisualStyleBackColor = true;
            // 
            // MitarbeiterForm
            // 
            ClientSize = new Size(601, 631);
            Controls.Add(panel1);
            Controls.Add(pnlMitarbeiterContent);
            Controls.Add(pnlMitarbeiterFooter);
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
            lblMitarbeiterAustritt.Visible = ckbMitarbeiterBefristet.Checked;
            dtpMitarbeiterAustritt.Visible = ckbMitarbeiterBefristet.Checked;
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
                @"^(0\d{9}$"
            );
        }

        private void btnMitarbeiterFooterSpeichern_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMitarbeiterMobil.Text))

                // Validierung der Mobilnummer
                if (!IsValidPhoneNumber(txtMitarbeiterMobil.Text))
                {
                    MessageBox.Show("Bitte geben Sie eine gültige Telefonnummer ein.");
                    txtMitarbeiterMobil.Focus();
                    return;
                }

            // Kunde aus den Eingabefeldern zusammenbauen
            Mitarbeiter mitarbeiter = new Mitarbeiter
            {
                Vorname = txtMitarbeiterVorname.Text,
                Nachname = txtMitarbeiterNachname.Text,
                Geburtsdatum = dtpMitarbeiterGeburtsdatum.Value,
                MobilNummer = txtMitarbeiterMobil.Text,
                Status = ckbMitarbeiterAktiv.Checked ? Enums.Status.Aktiv : Enums.Status.Inaktiv
            };

            // An die Verwaltung übergeben und auf die Festplatte speichern
            _mitarbeiterVerwaltung.Hinzufuegen(mitarbeiter);
            _mitarbeiterVerwaltung.Speichern();

            // Rückmeldung geben und Formular für den nächsten Mitarbeiter zurücksetzen
            MessageBox.Show("Mitarbeiter     erfolgreich gespeichert.");
            FelderZuruecksetzen();
        }

        /// <summary>
        /// Setzt alle Eingabefelder auf den Ausgangszustand zurück,
        /// damit direkt der nächste Kunde erfasst werden kann.
        /// </summary>
        private void FelderZuruecksetzen()
        {
            txtMitarbeiterVorname.Clear();
            txtMitarbeiterNachname.Clear();
            txtMitarbeiterMobil.Clear();
            txtMitarbeiterMail.Clear();
            // MaxDate statt DateTime.Now, weil das Feld nur Daten bis 2025 zulässt
            dtpMitarbeiterGeburtsdatum.Value = dtpMitarbeiterGeburtsdatum.MaxDate;
            rdbMitarbeiterActive.Checked = false;
            rdbMitarbeiterInactive.Checked = false;
            // Fokus zurück auf das erste Feld, damit man gleich lostippen kann
            txtMitarbeiterVorname.Focus();
        }



    }
    }
}
