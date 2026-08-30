using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using ContactManager.Models;
using ContactManager.Services;

namespace ContactManager
{
    public partial class KundenForm : Form
    {
        // Draht zur Kundenverwaltung, damit das Formular den Kunden speichern kann
        private readonly KundenVerwaltung _kundenVerwaltung;
        public KundenForm(KundenVerwaltung kundenVerwaltung)
        {
            InitializeComponent();
            _kundenVerwaltung = kundenVerwaltung;
            ComboBoxenBefuellen();
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
            pnlKundenHeader.Location = new Point(1, 1);
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
            lblKundenContentTitle1.Location = new Point(3, 0);
            lblKundenContentTitle1.Name = "lblKundenContentTitle1";
            lblKundenContentTitle1.Size = new Size(165, 25);
            lblKundenContentTitle1.TabIndex = 0;
            lblKundenContentTitle1.Text = "Persönliche Daten";
            // 
            // lblKundenContentGeburtsdatum
            // 
            lblKundenContentGeburtsdatum.AutoSize = true;
            lblKundenContentGeburtsdatum.Location = new Point(3, 194);
            lblKundenContentGeburtsdatum.Name = "lblKundenContentGeburtsdatum";
            lblKundenContentGeburtsdatum.Size = new Size(130, 25);
            lblKundenContentGeburtsdatum.TabIndex = 5;
            lblKundenContentGeburtsdatum.Text = "Geburtsdatum:";
            // 
            // lblKundenContentGeschlecht
            // 
            lblKundenContentGeschlecht.AutoSize = true;
            lblKundenContentGeschlecht.Location = new Point(228, 194);
            lblKundenContentGeschlecht.Name = "lblKundenContentGeschlecht";
            lblKundenContentGeschlecht.Size = new Size(100, 25);
            lblKundenContentGeschlecht.TabIndex = 6;
            lblKundenContentGeschlecht.Text = "Geschlecht:";
            // 
            // lblKundenContentTitleKD
            // 
            lblKundenContentTitleKD.AutoSize = true;
            lblKundenContentTitleKD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKundenContentTitleKD.Location = new Point(5, 269);
            lblKundenContentTitleKD.Name = "lblKundenContentTitleKD";
            lblKundenContentTitleKD.Size = new Size(129, 25);
            lblKundenContentTitleKD.TabIndex = 7;
            lblKundenContentTitleKD.Text = "Kontaktdaten";
            // 
            // lblKundenContentTel
            // 
            lblKundenContentTel.AutoSize = true;
            lblKundenContentTel.Location = new Point(5, 299);
            lblKundenContentTel.Name = "lblKundenContentTel";
            lblKundenContentTel.Size = new Size(145, 25);
            lblKundenContentTel.TabIndex = 8;
            lblKundenContentTel.Text = "Telefon Geschäft:";
            // 
            // lblKundenContentMobil
            // 
            lblKundenContentMobil.AutoSize = true;
            lblKundenContentMobil.Location = new Point(228, 299);
            lblKundenContentMobil.Name = "lblKundenContentMobil";
            lblKundenContentMobil.Size = new Size(62, 25);
            lblKundenContentMobil.TabIndex = 9;
            lblKundenContentMobil.Text = "Mobil:";
            // 
            // lblKundenContentMail
            // 
            lblKundenContentMail.AutoSize = true;
            lblKundenContentMail.Location = new Point(5, 371);
            lblKundenContentMail.Name = "lblKundenContentMail";
            lblKundenContentMail.Size = new Size(65, 25);
            lblKundenContentMail.TabIndex = 10;
            lblKundenContentMail.Text = "E-Mail:";
            // 
            // lblKundenContentAnrede
            // 
            lblKundenContentAnrede.AutoSize = true;
            lblKundenContentAnrede.Location = new Point(3, 36);
            lblKundenContentAnrede.Name = "lblKundenContentAnrede";
            lblKundenContentAnrede.Size = new Size(73, 25);
            lblKundenContentAnrede.TabIndex = 11;
            lblKundenContentAnrede.Text = "Anrede:";
            // 
            // lblKundenContentTitel
            // 
            lblKundenContentTitel.AutoSize = true;
            lblKundenContentTitel.Location = new Point(228, 36);
            lblKundenContentTitel.Name = "lblKundenContentTitel";
            lblKundenContentTitel.Size = new Size(48, 25);
            lblKundenContentTitel.TabIndex = 12;
            lblKundenContentTitel.Text = "Titel:";
            // 
            // lblKundenContentNachname
            // 
            lblKundenContentNachname.AutoSize = true;
            lblKundenContentNachname.Location = new Point(228, 120);
            lblKundenContentNachname.Name = "lblKundenContentNachname";
            lblKundenContentNachname.Size = new Size(100, 25);
            lblKundenContentNachname.TabIndex = 14;
            lblKundenContentNachname.Text = "Nachname:";
            // 
            // lblKundenContentStatus
            // 
            lblKundenContentStatus.AutoSize = true;
            lblKundenContentStatus.Location = new Point(3, 437);
            lblKundenContentStatus.Name = "lblKundenContentStatus";
            lblKundenContentStatus.Size = new Size(64, 25);
            lblKundenContentStatus.TabIndex = 15;
            lblKundenContentStatus.Text = "Status:";
            // 
            // txtKundeMobil
            // 
            txtKundeMobil.Location = new Point(228, 327);
            txtKundeMobil.Name = "txtKundeMobil";
            txtKundeMobil.PlaceholderText = "079 123 45 67";
            txtKundeMobil.Size = new Size(145, 31);
            txtKundeMobil.TabIndex = 19;
            txtKundeMobil.KeyPress += txtKundeMobil_KeyPress;
            // 
            // txtKundeMail
            // 
            txtKundeMail.Location = new Point(5, 399);
            txtKundeMail.Name = "txtKundeMail";
            txtKundeMail.PlaceholderText = "beispiel@mail.ch";
            txtKundeMail.Size = new Size(196, 31);
            txtKundeMail.TabIndex = 20;
            // 
            // txtKundeVorname
            // 
            txtKundeVorname.Location = new Point(3, 148);
            txtKundeVorname.Name = "txtKundeVorname";
            txtKundeVorname.Size = new Size(145, 31);
            txtKundeVorname.TabIndex = 16;
            // 
            // txtKundenNachname
            // 
            txtKundenNachname.Location = new Point(228, 148);
            txtKundenNachname.Name = "txtKundenNachname";
            txtKundenNachname.Size = new Size(145, 31);
            txtKundenNachname.TabIndex = 17;
            // 
            // lblKundenContentVorname
            // 
            lblKundenContentVorname.AutoSize = true;
            lblKundenContentVorname.Location = new Point(3, 120);
            lblKundenContentVorname.Name = "lblKundenContentVorname";
            lblKundenContentVorname.Size = new Size(87, 25);
            lblKundenContentVorname.TabIndex = 21;
            lblKundenContentVorname.Text = "Vorname:";
            // 
            // txtKundeTel
            // 
            txtKundeTel.Location = new Point(5, 327);
            txtKundeTel.Name = "txtKundeTel";
            txtKundeTel.PlaceholderText = "079 123 45 67";
            txtKundeTel.Size = new Size(145, 31);
            txtKundeTel.TabIndex = 22;
            txtKundeTel.KeyPress += txtKundeTel_KeyPress;
            // 
            // rdbKundenContentActive
            // 
            rdbKundenContentActive.AutoSize = true;
            rdbKundenContentActive.Location = new Point(5, 468);
            rdbKundenContentActive.Name = "rdbKundenContentActive";
            rdbKundenContentActive.Size = new Size(77, 29);
            rdbKundenContentActive.TabIndex = 23;
            rdbKundenContentActive.TabStop = true;
            rdbKundenContentActive.Text = "Aktiv";
            rdbKundenContentActive.UseVisualStyleBackColor = true;
            // 
            // rdbKundenContentInactive
            // 
            rdbKundenContentInactive.AutoSize = true;
            rdbKundenContentInactive.Location = new Point(81, 468);
            rdbKundenContentInactive.Name = "rdbKundenContentInactive";
            rdbKundenContentInactive.Size = new Size(89, 29);
            rdbKundenContentInactive.TabIndex = 24;
            rdbKundenContentInactive.TabStop = true;
            rdbKundenContentInactive.Text = "Inaktiv";
            rdbKundenContentInactive.UseVisualStyleBackColor = true;
            // 
            // cmbKundenContentAnrede
            // 
            cmbKundenContentAnrede.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKundenContentAnrede.FormattingEnabled = true;
            cmbKundenContentAnrede.Location = new Point(3, 64);
            cmbKundenContentAnrede.Name = "cmbKundenContentAnrede";
            cmbKundenContentAnrede.Size = new Size(145, 33);
            cmbKundenContentAnrede.TabIndex = 25;
            // 
            // cmbKundenContentTitel
            // 
            cmbKundenContentTitel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKundenContentTitel.FormattingEnabled = true;
            cmbKundenContentTitel.Items.AddRange(new object[] { "Dr.", "Prof.", "Dr. med.", "Ing.", "MSc.", "BSc.", " " });
            cmbKundenContentTitel.Location = new Point(228, 64);
            cmbKundenContentTitel.Name = "cmbKundenContentTitel";
            cmbKundenContentTitel.Size = new Size(145, 33);
            cmbKundenContentTitel.TabIndex = 26;
            // 
            // cmbKundenContentGeschlecht
            // 
            cmbKundenContentGeschlecht.FormattingEnabled = true;
            cmbKundenContentGeschlecht.Location = new Point(228, 225);
            cmbKundenContentGeschlecht.Name = "cmbKundenContentGeschlecht";
            cmbKundenContentGeschlecht.Size = new Size(145, 33);
            cmbKundenContentGeschlecht.TabIndex = 27;
            // 
            // dtpKundenContentGeburtsdatum
            // 
            dtpKundenContentGeburtsdatum.Format = DateTimePickerFormat.Short;
            dtpKundenContentGeburtsdatum.Location = new Point(3, 225);
            dtpKundenContentGeburtsdatum.MaxDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dtpKundenContentGeburtsdatum.Name = "dtpKundenContentGeburtsdatum";
            dtpKundenContentGeburtsdatum.Size = new Size(145, 31);
            dtpKundenContentGeburtsdatum.TabIndex = 28;
            dtpKundenContentGeburtsdatum.Value = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // pnlKundenFooter
            // 
            pnlKundenFooter.Controls.Add(btnKundenFooterSpeichern);
            pnlKundenFooter.Controls.Add(btnKundenFooterAbbrechen);
            pnlKundenFooter.Location = new Point(1, 579);
            pnlKundenFooter.Name = "pnlKundenFooter";
            pnlKundenFooter.Size = new Size(601, 50);
            pnlKundenFooter.TabIndex = 2;
            // 
            // btnKundenFooterSpeichern
            // 
            btnKundenFooterSpeichern.Location = new Point(445, 6);
            btnKundenFooterSpeichern.Name = "btnKundenFooterSpeichern";
            btnKundenFooterSpeichern.Size = new Size(121, 34);
            btnKundenFooterSpeichern.TabIndex = 1;
            btnKundenFooterSpeichern.Text = "Speichern";
            btnKundenFooterSpeichern.UseVisualStyleBackColor = true;
            btnKundenFooterSpeichern.Click += btnKundenFooterSpeichern_Click_1;
            // 
            // btnKundenFooterAbbrechen
            // 
            btnKundenFooterAbbrechen.Location = new Point(318, 6);
            btnKundenFooterAbbrechen.Name = "btnKundenFooterAbbrechen";
            btnKundenFooterAbbrechen.Size = new Size(121, 34);
            btnKundenFooterAbbrechen.TabIndex = 0;
            btnKundenFooterAbbrechen.Text = "Abbrechen";
            btnKundenFooterAbbrechen.UseVisualStyleBackColor = true;
            btnKundenFooterAbbrechen.Click += btnKundenFooterAbbrechen_Click;
            // 
            // pnlKundenContent
            // 
            pnlKundenContent.Controls.Add(lblKundenRequiredStatus);
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
            pnlKundenContent.Location = new Point(91, 76);
            pnlKundenContent.Name = "pnlKundenContent";
            pnlKundenContent.Size = new Size(410, 497);
            pnlKundenContent.TabIndex = 3;
            // 
            // lblKundenRequiredStatus
            // 
            lblKundenRequiredStatus.AutoSize = true;
            lblKundenRequiredStatus.ForeColor = Color.Red;
            lblKundenRequiredStatus.Location = new Point(57, 437);
            lblKundenRequiredStatus.Name = "lblKundenRequiredStatus";
            lblKundenRequiredStatus.Size = new Size(20, 25);
            lblKundenRequiredStatus.TabIndex = 33;
            lblKundenRequiredStatus.Text = "*";
            // 
            // lblKundenRequiredMail
            // 
            lblKundenRequiredMail.AutoSize = true;
            lblKundenRequiredMail.ForeColor = Color.Red;
            lblKundenRequiredMail.Location = new Point(207, 402);
            lblKundenRequiredMail.Name = "lblKundenRequiredMail";
            lblKundenRequiredMail.Size = new Size(20, 25);
            lblKundenRequiredMail.TabIndex = 32;
            lblKundenRequiredMail.Text = "*";
            // 
            // lblKundenRequiredMobil
            // 
            lblKundenRequiredMobil.AutoSize = true;
            lblKundenRequiredMobil.ForeColor = Color.Red;
            lblKundenRequiredMobil.Location = new Point(379, 330);
            lblKundenRequiredMobil.Name = "lblKundenRequiredMobil";
            lblKundenRequiredMobil.Size = new Size(20, 25);
            lblKundenRequiredMobil.TabIndex = 31;
            lblKundenRequiredMobil.Text = "*";
            // 
            // lblKundenRequiredNachname
            // 
            lblKundenRequiredNachname.AutoSize = true;
            lblKundenRequiredNachname.ForeColor = Color.Red;
            lblKundenRequiredNachname.Location = new Point(379, 151);
            lblKundenRequiredNachname.Name = "lblKundenRequiredNachname";
            lblKundenRequiredNachname.Size = new Size(20, 25);
            lblKundenRequiredNachname.TabIndex = 30;
            lblKundenRequiredNachname.Text = "*";
            // 
            // lblKundenRequiredVorname
            // 
            lblKundenRequiredVorname.AutoSize = true;
            lblKundenRequiredVorname.ForeColor = Color.Red;
            lblKundenRequiredVorname.Location = new Point(154, 151);
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
            Name = "KundenForm";
            Text = "Kunden";
            pnlKundenHeader.ResumeLayout(false);
            pnlKundenHeader.PerformLayout();
            pnlKundenFooter.ResumeLayout(false);
            pnlKundenContent.ResumeLayout(false);
            pnlKundenContent.PerformLayout();
            ResumeLayout(false);

        }

        private bool IsValidEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(
                email.Trim(),
                @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"
            );
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
                @"^(0\d{9}|\+41\d{9})$"
            );
        }

        /// <summary>
        /// Event-Handler für den Speichern-Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKundenFooterSpeichern_Click_1(object sender, EventArgs e)
        {
            


            if (!RequiredFieldsFilled())
            {
                MessageBox.Show("Fülle alle Felder aus, die mit * markiert sind.");
                return;
            }


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



            // Weiterer Code zum Speichern:
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
