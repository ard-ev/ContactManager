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
            numMitarbeiterPensum = new NumericUpDown();
            lblMitarbeiterPensum = new Label();
            dtpMitarbeiterAustritt = new DateTimePicker();
            dtpMitarbeiterEintritt = new DateTimePicker();
            ckbBefristet = new CheckBox();
            lblMitarbeiterAustritt = new Label();
            lblMitarbeiterEintritt = new Label();
            txtMitarbeiterMobil = new TextBox();
            lblMitarbeiterMobilnummer = new Label();
            comboBox2 = new ComboBox();
            textBox3 = new TextBox();
            label1 = new Label();
            lblMitarbeiterWohnort = new Label();
            txtMitarbeiterPLZ = new TextBox();
            txtMitarbeiterAdresse = new TextBox();
            lblMitarbeiterPLZ = new Label();
            lblMitarbeiterAdresse = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            lblMitarbeiterAHV = new Label();
            lblMitarbeiterKaderstufe = new Label();
            textBox1 = new TextBox();
            txtMitarbeiterNachname = new TextBox();
            txtMitarbeiterAbteilung = new TextBox();
            lblMitarbeiterRolle = new Label();
            lblMitarbeiterAbteilung = new Label();
            txtMitarbeiterVorname = new TextBox();
            lblMitarbeiterNachname = new Label();
            lblMitarbeiterVorname = new Label();
            txtMitarbeiterPK = new TextBox();
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
            // 
            // pnlMitarbeiterContent
            // 
            pnlMitarbeiterContent.AutoScroll = true;
            pnlMitarbeiterContent.Controls.Add(numMitarbeiterPensum);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterPensum);
            pnlMitarbeiterContent.Controls.Add(dtpMitarbeiterAustritt);
            pnlMitarbeiterContent.Controls.Add(dtpMitarbeiterEintritt);
            pnlMitarbeiterContent.Controls.Add(ckbBefristet);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterAustritt);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterEintritt);
            pnlMitarbeiterContent.Controls.Add(txtMitarbeiterMobil);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterMobilnummer);
            pnlMitarbeiterContent.Controls.Add(comboBox2);
            pnlMitarbeiterContent.Controls.Add(textBox3);
            pnlMitarbeiterContent.Controls.Add(label1);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterWohnort);
            pnlMitarbeiterContent.Controls.Add(txtMitarbeiterPLZ);
            pnlMitarbeiterContent.Controls.Add(txtMitarbeiterAdresse);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterPLZ);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterAdresse);
            pnlMitarbeiterContent.Controls.Add(textBox2);
            pnlMitarbeiterContent.Controls.Add(comboBox1);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterAHV);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterKaderstufe);
            pnlMitarbeiterContent.Controls.Add(textBox1);
            pnlMitarbeiterContent.Controls.Add(txtMitarbeiterNachname);
            pnlMitarbeiterContent.Controls.Add(txtMitarbeiterAbteilung);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterRolle);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterAbteilung);
            pnlMitarbeiterContent.Controls.Add(txtMitarbeiterVorname);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterNachname);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterVorname);
            pnlMitarbeiterContent.Controls.Add(txtMitarbeiterPK);
            pnlMitarbeiterContent.Controls.Add(lblMitarbeiterPK);
            pnlMitarbeiterContent.Location = new Point(75, 77);
            pnlMitarbeiterContent.Name = "pnlMitarbeiterContent";
            pnlMitarbeiterContent.Size = new Size(449, 502);
            pnlMitarbeiterContent.TabIndex = 2;
            // 
            // numMitarbeiterPensum
            // 
            numMitarbeiterPensum.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numMitarbeiterPensum.Location = new Point(9, 711);
            numMitarbeiterPensum.Name = "numMitarbeiterPensum";
            numMitarbeiterPensum.Size = new Size(182, 23);
            numMitarbeiterPensum.TabIndex = 30;
            numMitarbeiterPensum.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // lblMitarbeiterPensum
            // 
            lblMitarbeiterPensum.AutoSize = true;
            lblMitarbeiterPensum.Location = new Point(9, 683);
            lblMitarbeiterPensum.Name = "lblMitarbeiterPensum";
            lblMitarbeiterPensum.Size = new Size(53, 15);
            lblMitarbeiterPensum.TabIndex = 29;
            lblMitarbeiterPensum.Text = "Pensum:";
            // 
            // dtpMitarbeiterAustritt
            // 
            dtpMitarbeiterAustritt.Format = DateTimePickerFormat.Short;
            dtpMitarbeiterAustritt.Location = new Point(264, 697);
            dtpMitarbeiterAustritt.Name = "dtpMitarbeiterAustritt";
            dtpMitarbeiterAustritt.Size = new Size(182, 23);
            dtpMitarbeiterAustritt.TabIndex = 28;
            // 
            // dtpMitarbeiterEintritt
            // 
            dtpMitarbeiterEintritt.Format = DateTimePickerFormat.Short;
            dtpMitarbeiterEintritt.Location = new Point(9, 622);
            dtpMitarbeiterEintritt.Name = "dtpMitarbeiterEintritt";
            dtpMitarbeiterEintritt.Size = new Size(178, 23);
            dtpMitarbeiterEintritt.TabIndex = 27;
            dtpMitarbeiterEintritt.Value = new DateTime(2026, 8, 30, 14, 9, 14, 0);
            // 
            // ckbBefristet
            // 
            ckbBefristet.AutoSize = true;
            ckbBefristet.Location = new Point(264, 626);
            ckbBefristet.Name = "ckbBefristet";
            ckbBefristet.Size = new Size(69, 19);
            ckbBefristet.TabIndex = 26;
            ckbBefristet.Text = "Befristet";
            ckbBefristet.UseVisualStyleBackColor = true;
            // 
            // lblMitarbeiterAustritt
            // 
            lblMitarbeiterAustritt.AutoSize = true;
            lblMitarbeiterAustritt.Location = new Point(264, 669);
            lblMitarbeiterAustritt.Name = "lblMitarbeiterAustritt";
            lblMitarbeiterAustritt.Size = new Size(49, 15);
            lblMitarbeiterAustritt.TabIndex = 25;
            lblMitarbeiterAustritt.Text = "Austritt:";
            // 
            // lblMitarbeiterEintritt
            // 
            lblMitarbeiterEintritt.AutoSize = true;
            lblMitarbeiterEintritt.Location = new Point(9, 594);
            lblMitarbeiterEintritt.Name = "lblMitarbeiterEintritt";
            lblMitarbeiterEintritt.Size = new Size(45, 15);
            lblMitarbeiterEintritt.TabIndex = 24;
            lblMitarbeiterEintritt.Text = "Eintritt:";
            // 
            // txtMitarbeiterMobil
            // 
            txtMitarbeiterMobil.Location = new Point(9, 528);
            txtMitarbeiterMobil.Name = "txtMitarbeiterMobil";
            txtMitarbeiterMobil.Size = new Size(178, 23);
            txtMitarbeiterMobil.TabIndex = 23;
            // 
            // lblMitarbeiterMobilnummer
            // 
            lblMitarbeiterMobilnummer.AutoSize = true;
            lblMitarbeiterMobilnummer.Location = new Point(9, 500);
            lblMitarbeiterMobilnummer.Name = "lblMitarbeiterMobilnummer";
            lblMitarbeiterMobilnummer.Size = new Size(87, 15);
            lblMitarbeiterMobilnummer.TabIndex = 22;
            lblMitarbeiterMobilnummer.Text = "Mobilnummer:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(264, 435);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 23);
            comboBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(9, 435);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 23);
            textBox3.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 407);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 19;
            label1.Text = "Nationalität:";
            // 
            // lblMitarbeiterWohnort
            // 
            lblMitarbeiterWohnort.AutoSize = true;
            lblMitarbeiterWohnort.Location = new Point(9, 407);
            lblMitarbeiterWohnort.Name = "lblMitarbeiterWohnort";
            lblMitarbeiterWohnort.Size = new Size(57, 15);
            lblMitarbeiterWohnort.TabIndex = 18;
            lblMitarbeiterWohnort.Text = "Wohnort:";
            // 
            // txtMitarbeiterPLZ
            // 
            txtMitarbeiterPLZ.Location = new Point(264, 354);
            txtMitarbeiterPLZ.Name = "txtMitarbeiterPLZ";
            txtMitarbeiterPLZ.Size = new Size(182, 23);
            txtMitarbeiterPLZ.TabIndex = 17;
            // 
            // txtMitarbeiterAdresse
            // 
            txtMitarbeiterAdresse.Location = new Point(9, 354);
            txtMitarbeiterAdresse.Name = "txtMitarbeiterAdresse";
            txtMitarbeiterAdresse.Size = new Size(182, 23);
            txtMitarbeiterAdresse.TabIndex = 16;
            // 
            // lblMitarbeiterPLZ
            // 
            lblMitarbeiterPLZ.AutoSize = true;
            lblMitarbeiterPLZ.Location = new Point(264, 318);
            lblMitarbeiterPLZ.Name = "lblMitarbeiterPLZ";
            lblMitarbeiterPLZ.Size = new Size(30, 15);
            lblMitarbeiterPLZ.TabIndex = 15;
            lblMitarbeiterPLZ.Text = "PLZ:";
            // 
            // lblMitarbeiterAdresse
            // 
            lblMitarbeiterAdresse.AutoSize = true;
            lblMitarbeiterAdresse.Location = new Point(9, 318);
            lblMitarbeiterAdresse.Name = "lblMitarbeiterAdresse";
            lblMitarbeiterAdresse.Size = new Size(51, 15);
            lblMitarbeiterAdresse.TabIndex = 14;
            lblMitarbeiterAdresse.Text = "Adresse:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 264);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 23);
            textBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(9, 263);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 23);
            comboBox1.TabIndex = 12;
            // 
            // lblMitarbeiterAHV
            // 
            lblMitarbeiterAHV.AutoSize = true;
            lblMitarbeiterAHV.Location = new Point(264, 236);
            lblMitarbeiterAHV.Name = "lblMitarbeiterAHV";
            lblMitarbeiterAHV.Size = new Size(87, 15);
            lblMitarbeiterAHV.TabIndex = 11;
            lblMitarbeiterAHV.Text = "AHV-Nummer:";
            // 
            // lblMitarbeiterKaderstufe
            // 
            lblMitarbeiterKaderstufe.AutoSize = true;
            lblMitarbeiterKaderstufe.Location = new Point(9, 236);
            lblMitarbeiterKaderstufe.Name = "lblMitarbeiterKaderstufe";
            lblMitarbeiterKaderstufe.Size = new Size(66, 15);
            lblMitarbeiterKaderstufe.TabIndex = 10;
            lblMitarbeiterKaderstufe.Text = "Kaderstufe:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(264, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 9;
            // 
            // txtMitarbeiterNachname
            // 
            txtMitarbeiterNachname.Location = new Point(246, 101);
            txtMitarbeiterNachname.Name = "txtMitarbeiterNachname";
            txtMitarbeiterNachname.Size = new Size(185, 23);
            txtMitarbeiterNachname.TabIndex = 8;
            // 
            // txtMitarbeiterAbteilung
            // 
            txtMitarbeiterAbteilung.Location = new Point(9, 177);
            txtMitarbeiterAbteilung.Name = "txtMitarbeiterAbteilung";
            txtMitarbeiterAbteilung.Size = new Size(182, 23);
            txtMitarbeiterAbteilung.TabIndex = 7;
            // 
            // lblMitarbeiterRolle
            // 
            lblMitarbeiterRolle.AutoSize = true;
            lblMitarbeiterRolle.Location = new Point(264, 149);
            lblMitarbeiterRolle.Name = "lblMitarbeiterRolle";
            lblMitarbeiterRolle.Size = new Size(36, 15);
            lblMitarbeiterRolle.TabIndex = 6;
            lblMitarbeiterRolle.Text = "Rolle:";
            // 
            // lblMitarbeiterAbteilung
            // 
            lblMitarbeiterAbteilung.AutoSize = true;
            lblMitarbeiterAbteilung.Location = new Point(9, 149);
            lblMitarbeiterAbteilung.Name = "lblMitarbeiterAbteilung";
            lblMitarbeiterAbteilung.Size = new Size(62, 15);
            lblMitarbeiterAbteilung.TabIndex = 5;
            lblMitarbeiterAbteilung.Text = "Abteilung:";
            // 
            // txtMitarbeiterVorname
            // 
            txtMitarbeiterVorname.Location = new Point(9, 101);
            txtMitarbeiterVorname.Name = "txtMitarbeiterVorname";
            txtMitarbeiterVorname.Size = new Size(182, 23);
            txtMitarbeiterVorname.TabIndex = 4;
            // 
            // lblMitarbeiterNachname
            // 
            lblMitarbeiterNachname.AutoSize = true;
            lblMitarbeiterNachname.Location = new Point(264, 73);
            lblMitarbeiterNachname.Name = "lblMitarbeiterNachname";
            lblMitarbeiterNachname.Size = new Size(68, 15);
            lblMitarbeiterNachname.TabIndex = 3;
            lblMitarbeiterNachname.Text = "Nachname:";
            // 
            // lblMitarbeiterVorname
            // 
            lblMitarbeiterVorname.AutoSize = true;
            lblMitarbeiterVorname.Location = new Point(9, 73);
            lblMitarbeiterVorname.Name = "lblMitarbeiterVorname";
            lblMitarbeiterVorname.Size = new Size(57, 15);
            lblMitarbeiterVorname.TabIndex = 2;
            lblMitarbeiterVorname.Text = "Vorname:";
            // 
            // txtMitarbeiterPK
            // 
            txtMitarbeiterPK.Location = new Point(193, 14);
            txtMitarbeiterPK.Name = "txtMitarbeiterPK";
            txtMitarbeiterPK.ReadOnly = true;
            txtMitarbeiterPK.Size = new Size(238, 23);
            txtMitarbeiterPK.TabIndex = 1;
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
            ClientSize = new Size(601, 631);
            Controls.Add(pnlMitarbeiterContent);
            Controls.Add(pnlMitarbeiterFooter);
            Controls.Add(panel1);
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
    }
}
