using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class KundenForm : Form
    {
        public KundenForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            pnlKundenHeader = new Panel();
            lblKundeHeaderSubtitle = new Label();
            lblKundenHeaderTitle = new Label();
            tpnlKundenContent = new TableLayoutPanel();
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
            pnlKundenHeader.SuspendLayout();
            tpnlKundenContent.SuspendLayout();
            pnlKundenFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlKundenHeader
            // 
            pnlKundenHeader.Controls.Add(lblKundeHeaderSubtitle);
            pnlKundenHeader.Controls.Add(lblKundenHeaderTitle);
            pnlKundenHeader.Location = new Point(1, 1);
            pnlKundenHeader.Name = "pnlKundenHeader";
            pnlKundenHeader.Size = new Size(791, 50);
            pnlKundenHeader.TabIndex = 0;
            // 
            // lblKundeHeaderSubtitle
            // 
            lblKundeHeaderSubtitle.AutoSize = true;
            lblKundeHeaderSubtitle.Location = new Point(11, 25);
            lblKundeHeaderSubtitle.Name = "lblKundeHeaderSubtitle";
            lblKundeHeaderSubtitle.Size = new Size(246, 15);
            lblKundeHeaderSubtitle.TabIndex = 1;
            lblKundeHeaderSubtitle.Text = "Persönliche Daten und Kontaktinformationen";
            // 
            // lblKundenHeaderTitle
            // 
            lblKundenHeaderTitle.AutoSize = true;
            lblKundenHeaderTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKundenHeaderTitle.Location = new Point(11, 8);
            lblKundenHeaderTitle.Name = "lblKundenHeaderTitle";
            lblKundenHeaderTitle.Size = new Size(182, 17);
            lblKundenHeaderTitle.TabIndex = 0;
            lblKundenHeaderTitle.Text = "Kunde erfassen / bearbeiten";
            // 
            // tpnlKundenContent
            // 
            tpnlKundenContent.AutoScroll = true;
            tpnlKundenContent.ColumnCount = 2;
            tpnlKundenContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.0338173F));
            tpnlKundenContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.9661827F));
            tpnlKundenContent.Controls.Add(lblKundenContentTitle1, 0, 0);
            tpnlKundenContent.Controls.Add(lblKundenContentGeburtsdatum, 0, 6);
            tpnlKundenContent.Controls.Add(lblKundenContentGeschlecht, 1, 6);
            tpnlKundenContent.Controls.Add(lblKundenContentTitleKD, 0, 8);
            tpnlKundenContent.Controls.Add(lblKundenContentTel, 0, 10);
            tpnlKundenContent.Controls.Add(lblKundenContentMobil, 1, 10);
            tpnlKundenContent.Controls.Add(lblKundenContentMail, 0, 12);
            tpnlKundenContent.Controls.Add(lblKundenContentAnrede, 0, 2);
            tpnlKundenContent.Controls.Add(lblKundenContentTitel, 1, 2);
            tpnlKundenContent.Controls.Add(lblKundenContentNachname, 1, 4);
            tpnlKundenContent.Controls.Add(lblKundenContentStatus, 0, 14);
            tpnlKundenContent.Controls.Add(txtKundeMobil, 1, 11);
            tpnlKundenContent.Controls.Add(txtKundeMail, 0, 13);
            tpnlKundenContent.Controls.Add(txtKundeVorname, 0, 5);
            tpnlKundenContent.Controls.Add(txtKundenNachname, 1, 5);
            tpnlKundenContent.Controls.Add(lblKundenContentVorname, 0, 4);
            tpnlKundenContent.Controls.Add(txtKundeTel, 0, 11);
            tpnlKundenContent.Controls.Add(rdbKundenContentActive, 1, 14);
            tpnlKundenContent.Controls.Add(rdbKundenContentInactive, 1, 15);
            tpnlKundenContent.Controls.Add(cmbKundenContentAnrede, 0, 3);
            tpnlKundenContent.Controls.Add(cmbKundenContentTitel, 1, 3);
            tpnlKundenContent.Controls.Add(cmbKundenContentGeschlecht, 1, 7);
            tpnlKundenContent.Controls.Add(dtpKundenContentGeburtsdatum, 0, 7);
            tpnlKundenContent.Location = new Point(179, 57);
            tpnlKundenContent.Name = "tpnlKundenContent";
            tpnlKundenContent.RowCount = 16;
            tpnlKundenContent.RowStyles.Add(new RowStyle(SizeType.Percent, 68.62745F));
            tpnlKundenContent.RowStyles.Add(new RowStyle(SizeType.Percent, 31.37255F));
            tpnlKundenContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tpnlKundenContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tpnlKundenContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tpnlKundenContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tpnlKundenContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tpnlKundenContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tpnlKundenContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tpnlKundenContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tpnlKundenContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 14F));
            tpnlKundenContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tpnlKundenContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tpnlKundenContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tpnlKundenContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tpnlKundenContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tpnlKundenContent.Size = new Size(414, 462);
            tpnlKundenContent.TabIndex = 1;
            // 
            // lblKundenContentTitle1
            // 
            lblKundenContentTitle1.AutoSize = true;
            lblKundenContentTitle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKundenContentTitle1.Location = new Point(3, 0);
            lblKundenContentTitle1.Name = "lblKundenContentTitle1";
            lblKundenContentTitle1.Size = new Size(108, 15);
            lblKundenContentTitle1.TabIndex = 0;
            lblKundenContentTitle1.Text = "Persönliche Daten";
            // 
            // lblKundenContentGeburtsdatum
            // 
            lblKundenContentGeburtsdatum.AutoSize = true;
            lblKundenContentGeburtsdatum.Location = new Point(3, 142);
            lblKundenContentGeburtsdatum.Name = "lblKundenContentGeburtsdatum";
            lblKundenContentGeburtsdatum.Size = new Size(86, 15);
            lblKundenContentGeburtsdatum.TabIndex = 5;
            lblKundenContentGeburtsdatum.Text = "Geburtsdatum:";
            // 
            // lblKundenContentGeschlecht
            // 
            lblKundenContentGeschlecht.AutoSize = true;
            lblKundenContentGeschlecht.Location = new Point(206, 142);
            lblKundenContentGeschlecht.Name = "lblKundenContentGeschlecht";
            lblKundenContentGeschlecht.Size = new Size(68, 15);
            lblKundenContentGeschlecht.TabIndex = 6;
            lblKundenContentGeschlecht.Text = "Geschlecht:";
            // 
            // lblKundenContentTitleKD
            // 
            lblKundenContentTitleKD.AutoSize = true;
            lblKundenContentTitleKD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKundenContentTitleKD.Location = new Point(3, 227);
            lblKundenContentTitleKD.Name = "lblKundenContentTitleKD";
            lblKundenContentTitleKD.Size = new Size(84, 15);
            lblKundenContentTitleKD.TabIndex = 7;
            lblKundenContentTitleKD.Text = "Kontaktdaten";
            // 
            // lblKundenContentTel
            // 
            lblKundenContentTel.AutoSize = true;
            lblKundenContentTel.Location = new Point(3, 258);
            lblKundenContentTel.Name = "lblKundenContentTel";
            lblKundenContentTel.Size = new Size(98, 14);
            lblKundenContentTel.TabIndex = 8;
            lblKundenContentTel.Text = "Telefon Geschäft:";
            // 
            // lblKundenContentMobil
            // 
            lblKundenContentMobil.AutoSize = true;
            lblKundenContentMobil.Location = new Point(206, 258);
            lblKundenContentMobil.Name = "lblKundenContentMobil";
            lblKundenContentMobil.Size = new Size(41, 14);
            lblKundenContentMobil.TabIndex = 9;
            lblKundenContentMobil.Text = "Mobil:";
            // 
            // lblKundenContentMail
            // 
            lblKundenContentMail.AutoSize = true;
            lblKundenContentMail.Location = new Point(3, 319);
            lblKundenContentMail.Name = "lblKundenContentMail";
            lblKundenContentMail.Size = new Size(44, 15);
            lblKundenContentMail.TabIndex = 10;
            lblKundenContentMail.Text = "E-Mail:";
            // 
            // lblKundenContentAnrede
            // 
            lblKundenContentAnrede.AutoSize = true;
            lblKundenContentAnrede.Location = new Point(3, 26);
            lblKundenContentAnrede.Name = "lblKundenContentAnrede";
            lblKundenContentAnrede.Size = new Size(48, 15);
            lblKundenContentAnrede.TabIndex = 11;
            lblKundenContentAnrede.Text = "Anrede:";
            // 
            // lblKundenContentTitel
            // 
            lblKundenContentTitel.AutoSize = true;
            lblKundenContentTitel.Location = new Point(206, 26);
            lblKundenContentTitel.Name = "lblKundenContentTitel";
            lblKundenContentTitel.Size = new Size(33, 15);
            lblKundenContentTitel.TabIndex = 12;
            lblKundenContentTitel.Text = "Titel:";
            // 
            // lblKundenContentNachname
            // 
            lblKundenContentNachname.AutoSize = true;
            lblKundenContentNachname.Location = new Point(206, 78);
            lblKundenContentNachname.Name = "lblKundenContentNachname";
            lblKundenContentNachname.Size = new Size(68, 15);
            lblKundenContentNachname.TabIndex = 14;
            lblKundenContentNachname.Text = "Nachname:";
            // 
            // lblKundenContentStatus
            // 
            lblKundenContentStatus.AutoSize = true;
            lblKundenContentStatus.Location = new Point(3, 384);
            lblKundenContentStatus.Name = "lblKundenContentStatus";
            lblKundenContentStatus.Size = new Size(42, 15);
            lblKundenContentStatus.TabIndex = 15;
            lblKundenContentStatus.Text = "Status:";
            // 
            // txtKundeMobil
            // 
            txtKundeMobil.Location = new Point(206, 275);
            txtKundeMobil.Name = "txtKundeMobil";
            txtKundeMobil.Size = new Size(145, 23);
            txtKundeMobil.TabIndex = 19;
            txtKundeMobil.KeyPress += txtKundeMobil_KeyPress;
            // 
            // txtKundeMail
            // 
            txtKundeMail.Location = new Point(3, 337);
            txtKundeMail.Name = "txtKundeMail";
            txtKundeMail.Size = new Size(145, 23);
            txtKundeMail.TabIndex = 20;
            // 
            // txtKundeVorname
            // 
            txtKundeVorname.Location = new Point(3, 96);
            txtKundeVorname.Name = "txtKundeVorname";
            txtKundeVorname.Size = new Size(145, 23);
            txtKundeVorname.TabIndex = 16;
            // 
            // txtKundenNachname
            // 
            txtKundenNachname.Location = new Point(206, 96);
            txtKundenNachname.Name = "txtKundenNachname";
            txtKundenNachname.Size = new Size(145, 23);
            txtKundenNachname.TabIndex = 17;
            // 
            // lblKundenContentVorname
            // 
            lblKundenContentVorname.AutoSize = true;
            lblKundenContentVorname.Location = new Point(3, 78);
            lblKundenContentVorname.Name = "lblKundenContentVorname";
            lblKundenContentVorname.Size = new Size(57, 15);
            lblKundenContentVorname.TabIndex = 21;
            lblKundenContentVorname.Text = "Vorname:";
            // 
            // txtKundeTel
            // 
            txtKundeTel.Location = new Point(3, 275);
            txtKundeTel.Name = "txtKundeTel";
            txtKundeTel.Size = new Size(145, 23);
            txtKundeTel.TabIndex = 22;
            txtKundeTel.KeyPress += txtKundeTel_KeyPress;
            // 
            // rdbKundenContentActive
            // 
            rdbKundenContentActive.AutoSize = true;
            rdbKundenContentActive.Location = new Point(206, 387);
            rdbKundenContentActive.Name = "rdbKundenContentActive";
            rdbKundenContentActive.Size = new Size(52, 19);
            rdbKundenContentActive.TabIndex = 23;
            rdbKundenContentActive.TabStop = true;
            rdbKundenContentActive.Text = "Aktiv";
            rdbKundenContentActive.UseVisualStyleBackColor = true;
            // 
            // rdbKundenContentInactive
            // 
            rdbKundenContentInactive.AutoSize = true;
            rdbKundenContentInactive.Location = new Point(206, 414);
            rdbKundenContentInactive.Name = "rdbKundenContentInactive";
            rdbKundenContentInactive.Size = new Size(60, 19);
            rdbKundenContentInactive.TabIndex = 24;
            rdbKundenContentInactive.TabStop = true;
            rdbKundenContentInactive.Text = "Inaktiv";
            rdbKundenContentInactive.UseVisualStyleBackColor = true;
            // 
            // cmbKundenContentAnrede
            // 
            cmbKundenContentAnrede.FormattingEnabled = true;
            cmbKundenContentAnrede.Items.AddRange(new object[] { "Herr", "Frau", "Divers" });
            cmbKundenContentAnrede.Location = new Point(3, 44);
            cmbKundenContentAnrede.Name = "cmbKundenContentAnrede";
            cmbKundenContentAnrede.Size = new Size(145, 23);
            cmbKundenContentAnrede.TabIndex = 25;
            // 
            // cmbKundenContentTitel
            // 
            cmbKundenContentTitel.FormattingEnabled = true;
            cmbKundenContentTitel.Items.AddRange(new object[] { "Dr.", "Prof.", "Dr. med.", "Ing.", "MSc.", "BSc." });
            cmbKundenContentTitel.Location = new Point(206, 44);
            cmbKundenContentTitel.Name = "cmbKundenContentTitel";
            cmbKundenContentTitel.Size = new Size(145, 23);
            cmbKundenContentTitel.TabIndex = 26;
            // 
            // cmbKundenContentGeschlecht
            // 
            cmbKundenContentGeschlecht.FormattingEnabled = true;
            cmbKundenContentGeschlecht.Items.AddRange(new object[] { "Männlich", "Weiblich", "Divers" });
            cmbKundenContentGeschlecht.Location = new Point(206, 160);
            cmbKundenContentGeschlecht.Name = "cmbKundenContentGeschlecht";
            cmbKundenContentGeschlecht.Size = new Size(145, 23);
            cmbKundenContentGeschlecht.TabIndex = 27;
            // 
            // dtpKundenContentGeburtsdatum
            // 
            dtpKundenContentGeburtsdatum.Format = DateTimePickerFormat.Short;
            dtpKundenContentGeburtsdatum.Location = new Point(3, 160);
            dtpKundenContentGeburtsdatum.Name = "dtpKundenContentGeburtsdatum";
            dtpKundenContentGeburtsdatum.Size = new Size(145, 23);
            dtpKundenContentGeburtsdatum.TabIndex = 28;
            // 
            // pnlKundenFooter
            // 
            pnlKundenFooter.Controls.Add(btnKundenFooterSpeichern);
            pnlKundenFooter.Controls.Add(btnKundenFooterAbbrechen);
            pnlKundenFooter.Location = new Point(1, 525);
            pnlKundenFooter.Name = "pnlKundenFooter";
            pnlKundenFooter.Size = new Size(791, 50);
            pnlKundenFooter.TabIndex = 2;
            // 
            // btnKundenFooterSpeichern
            // 
            btnKundenFooterSpeichern.Location = new Point(687, 17);
            btnKundenFooterSpeichern.Name = "btnKundenFooterSpeichern";
            btnKundenFooterSpeichern.Size = new Size(90, 23);
            btnKundenFooterSpeichern.TabIndex = 1;
            btnKundenFooterSpeichern.Text = "Speichern";
            btnKundenFooterSpeichern.UseVisualStyleBackColor = true;
            btnKundenFooterSpeichern.Click += btnKundenFooterSpeichern_Click_1;
            // 
            // btnKundenFooterAbbrechen
            // 
            btnKundenFooterAbbrechen.Location = new Point(591, 17);
            btnKundenFooterAbbrechen.Name = "btnKundenFooterAbbrechen";
            btnKundenFooterAbbrechen.Size = new Size(90, 23);
            btnKundenFooterAbbrechen.TabIndex = 0;
            btnKundenFooterAbbrechen.Text = "Abbrechen";
            btnKundenFooterAbbrechen.UseVisualStyleBackColor = true;
            // 
            // KundenForm
            // 
            ClientSize = new Size(790, 577);
            Controls.Add(pnlKundenFooter);
            Controls.Add(tpnlKundenContent);
            Controls.Add(pnlKundenHeader);
            Name = "KundenForm";
            Text = "Kunden";
            pnlKundenHeader.ResumeLayout(false);
            pnlKundenHeader.PerformLayout();
            tpnlKundenContent.ResumeLayout(false);
            tpnlKundenContent.PerformLayout();
            pnlKundenFooter.ResumeLayout(false);
            ResumeLayout(false);

        }

        private void txtKundeTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        private void txtKundeMobil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        // Validierung der Telefonnummer (Methode)
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            phoneNumber = phoneNumber.Replace(" ", "");

            return System.Text.RegularExpressions.Regex.IsMatch(
                phoneNumber,
                @"^(0\d{9}|\+41\d{9})$"
            );
        }

        // Event-Handler für den Speichern-Button
        private void btnKundenFooterSpeichern_Click_1(object sender, EventArgs e)
        {
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

            // Weiterer Code zum Speichern:
        }
    }
}
