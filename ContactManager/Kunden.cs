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
            lblKundenRequiredVorname = new Label();
            lblKundenRequiredNachname = new Label();
            lblKundenRequiredMobil = new Label();
            lblKundenRequiredMail = new Label();
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
            lblKundenContentGeburtsdatum.Location = new Point(3, 131);
            lblKundenContentGeburtsdatum.Name = "lblKundenContentGeburtsdatum";
            lblKundenContentGeburtsdatum.Size = new Size(86, 15);
            lblKundenContentGeburtsdatum.TabIndex = 5;
            lblKundenContentGeburtsdatum.Text = "Geburtsdatum:";
            // 
            // lblKundenContentGeschlecht
            // 
            lblKundenContentGeschlecht.AutoSize = true;
            lblKundenContentGeschlecht.Location = new Point(228, 131);
            lblKundenContentGeschlecht.Name = "lblKundenContentGeschlecht";
            lblKundenContentGeschlecht.Size = new Size(68, 15);
            lblKundenContentGeschlecht.TabIndex = 6;
            lblKundenContentGeschlecht.Text = "Geschlecht:";
            // 
            // lblKundenContentTitleKD
            // 
            lblKundenContentTitleKD.AutoSize = true;
            lblKundenContentTitleKD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKundenContentTitleKD.Location = new Point(5, 223);
            lblKundenContentTitleKD.Name = "lblKundenContentTitleKD";
            lblKundenContentTitleKD.Size = new Size(84, 15);
            lblKundenContentTitleKD.TabIndex = 7;
            lblKundenContentTitleKD.Text = "Kontaktdaten";
            // 
            // lblKundenContentTel
            // 
            lblKundenContentTel.AutoSize = true;
            lblKundenContentTel.Location = new Point(3, 248);
            lblKundenContentTel.Name = "lblKundenContentTel";
            lblKundenContentTel.Size = new Size(98, 15);
            lblKundenContentTel.TabIndex = 8;
            lblKundenContentTel.Text = "Telefon Geschäft:";
            // 
            // lblKundenContentMobil
            // 
            lblKundenContentMobil.AutoSize = true;
            lblKundenContentMobil.Location = new Point(228, 249);
            lblKundenContentMobil.Name = "lblKundenContentMobil";
            lblKundenContentMobil.Size = new Size(41, 15);
            lblKundenContentMobil.TabIndex = 9;
            lblKundenContentMobil.Text = "Mobil:";
            // 
            // lblKundenContentMail
            // 
            lblKundenContentMail.AutoSize = true;
            lblKundenContentMail.Location = new Point(5, 305);
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
            lblKundenContentTitel.Location = new Point(228, 26);
            lblKundenContentTitel.Name = "lblKundenContentTitel";
            lblKundenContentTitel.Size = new Size(33, 15);
            lblKundenContentTitel.TabIndex = 12;
            lblKundenContentTitel.Text = "Titel:";
            // 
            // lblKundenContentNachname
            // 
            lblKundenContentNachname.AutoSize = true;
            lblKundenContentNachname.Location = new Point(228, 78);
            lblKundenContentNachname.Name = "lblKundenContentNachname";
            lblKundenContentNachname.Size = new Size(68, 15);
            lblKundenContentNachname.TabIndex = 14;
            lblKundenContentNachname.Text = "Nachname:";
            // 
            // lblKundenContentStatus
            // 
            lblKundenContentStatus.AutoSize = true;
            lblKundenContentStatus.Location = new Point(5, 361);
            lblKundenContentStatus.Name = "lblKundenContentStatus";
            lblKundenContentStatus.Size = new Size(42, 15);
            lblKundenContentStatus.TabIndex = 15;
            lblKundenContentStatus.Text = "Status:";
            // 
            // txtKundeMobil
            // 
            txtKundeMobil.Location = new Point(228, 266);
            txtKundeMobil.Name = "txtKundeMobil";
            txtKundeMobil.Size = new Size(145, 23);
            txtKundeMobil.TabIndex = 19;
            txtKundeMobil.KeyPress += txtKundeMobil_KeyPress;
            // 
            // txtKundeMail
            // 
            txtKundeMail.Location = new Point(5, 323);
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
            txtKundenNachname.Location = new Point(228, 96);
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
            txtKundeTel.Location = new Point(5, 266);
            txtKundeTel.Name = "txtKundeTel";
            txtKundeTel.Size = new Size(145, 23);
            txtKundeTel.TabIndex = 22;
            txtKundeTel.KeyPress += txtKundeTel_KeyPress;
            // 
            // rdbKundenContentActive
            // 
            rdbKundenContentActive.AutoSize = true;
            rdbKundenContentActive.Location = new Point(8, 379);
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
            rdbKundenContentInactive.Location = new Point(66, 379);
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
            cmbKundenContentAnrede.Location = new Point(3, 44);
            cmbKundenContentAnrede.Name = "cmbKundenContentAnrede";
            cmbKundenContentAnrede.Size = new Size(145, 23);
            cmbKundenContentAnrede.TabIndex = 25;
            // 
            // cmbKundenContentTitel
            // 
            cmbKundenContentTitel.FormattingEnabled = true;
            cmbKundenContentTitel.Items.AddRange(new object[] { "Dr.", "Prof.", "Dr. med.", "Ing.", "MSc.", "BSc." });
            cmbKundenContentTitel.Location = new Point(228, 44);
            cmbKundenContentTitel.Name = "cmbKundenContentTitel";
            cmbKundenContentTitel.Size = new Size(145, 23);
            cmbKundenContentTitel.TabIndex = 26;
            // 
            // cmbKundenContentGeschlecht
            // 
            cmbKundenContentGeschlecht.FormattingEnabled = true;
            cmbKundenContentGeschlecht.Location = new Point(228, 149);
            cmbKundenContentGeschlecht.Name = "cmbKundenContentGeschlecht";
            cmbKundenContentGeschlecht.Size = new Size(145, 23);
            cmbKundenContentGeschlecht.TabIndex = 27;
            // 
            // dtpKundenContentGeburtsdatum
            // 
            dtpKundenContentGeburtsdatum.Format = DateTimePickerFormat.Short;
            dtpKundenContentGeburtsdatum.Location = new Point(3, 149);
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
            btnKundenFooterAbbrechen.Click += btnKundenFooterAbbrechen_Click;
            // 
            // pnlKundenContent
            // 
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
            pnlKundenContent.Location = new Point(91, 57);
            pnlKundenContent.Name = "pnlKundenContent";
            pnlKundenContent.Size = new Size(633, 462);
            pnlKundenContent.TabIndex = 3;
            // 
            // lblKundenRequiredVorname
            // 
            lblKundenRequiredVorname.AutoSize = true;
            lblKundenRequiredVorname.ForeColor = Color.Red;
            lblKundenRequiredVorname.Location = new Point(154, 99);
            lblKundenRequiredVorname.Name = "lblKundenRequiredVorname";
            lblKundenRequiredVorname.Size = new Size(12, 15);
            lblKundenRequiredVorname.TabIndex = 29;
            lblKundenRequiredVorname.Text = "*";
            // 
            // lblKundenRequiredNachname
            // 
            lblKundenRequiredNachname.AutoSize = true;
            lblKundenRequiredNachname.ForeColor = Color.Red;
            lblKundenRequiredNachname.Location = new Point(379, 99);
            lblKundenRequiredNachname.Name = "lblKundenRequiredNachname";
            lblKundenRequiredNachname.Size = new Size(12, 15);
            lblKundenRequiredNachname.TabIndex = 30;
            lblKundenRequiredNachname.Text = "*";
            // 
            // lblKundenRequiredMobil
            // 
            lblKundenRequiredMobil.AutoSize = true;
            lblKundenRequiredMobil.ForeColor = Color.Red;
            lblKundenRequiredMobil.Location = new Point(379, 269);
            lblKundenRequiredMobil.Name = "lblKundenRequiredMobil";
            lblKundenRequiredMobil.Size = new Size(12, 15);
            lblKundenRequiredMobil.TabIndex = 31;
            lblKundenRequiredMobil.Text = "*";
            // 
            // lblKundenRequiredMail
            // 
            lblKundenRequiredMail.AutoSize = true;
            lblKundenRequiredMail.ForeColor = Color.Red;
            lblKundenRequiredMail.Location = new Point(154, 326);
            lblKundenRequiredMail.Name = "lblKundenRequiredMail";
            lblKundenRequiredMail.Size = new Size(12, 15);
            lblKundenRequiredMail.TabIndex = 32;
            lblKundenRequiredMail.Text = "*";
            // 
            // KundenForm
            // 
            ClientSize = new Size(790, 577);
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

            if (!RequiredFieldsFilled())
            {
                return;
            }

            // Weiterer Code zum Speichern:
        }

        private void btnKundenFooterAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
