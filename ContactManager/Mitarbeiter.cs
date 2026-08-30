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
            txtMitarbeiterAbteilung = new TextBox();
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
            pnlMitarbeiterContent.Controls.Add(txtMitarbeiterAbteilung);
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
            cmbMitarbeiterNationalität.FormattingEnabled = true;
            cmbMitarbeiterNationalität.Location = new Point(247, 381);
            cmbMitarbeiterNationalität.Name = "cmbMitarbeiterNationalität";
            cmbMitarbeiterNationalität.Size = new Size(182, 23);
            cmbMitarbeiterNationalität.TabIndex = 9;
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
            txtMitarbeiterPLZ.Size = new Size(182, 23);
            txtMitarbeiterPLZ.TabIndex = 7;
            // 
            // txtMitarbeiterAdresse
            // 
            txtMitarbeiterAdresse.Location = new Point(7, 307);
            txtMitarbeiterAdresse.Name = "txtMitarbeiterAdresse";
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
            txtMitarbeiterNachname.Size = new Size(182, 23);
            txtMitarbeiterNachname.TabIndex = 1;
            // 
            // txtMitarbeiterAbteilung
            // 
            txtMitarbeiterAbteilung.Location = new Point(7, 159);
            txtMitarbeiterAbteilung.Name = "txtMitarbeiterAbteilung";
            txtMitarbeiterAbteilung.Size = new Size(182, 23);
            txtMitarbeiterAbteilung.TabIndex = 2;
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
            lblMitarbeiterPK.Location = new Point(18, 17);
            lblMitarbeiterPK.Name = "lblMitarbeiterPK";
            lblMitarbeiterPK.Size = new Size(114, 15);
            lblMitarbeiterPK.TabIndex = 0;
            lblMitarbeiterPK.Text = "Mitarbeiternummer:";
            // 
            // MitarbeiterForm
            // 
            ClientSize = new Size(601, 632);
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

        

        


    }
}
