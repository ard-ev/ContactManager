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
            lblMitarbeiterHeaderTitel = new Label();
            lblMitarbeiterHeaderSubtitle = new Label();
            pnlMitarbeiterFooter = new Panel();
            btnMitarbeiterCancel = new Button();
            btnMitarbeiterFooterSpeichern = new Button();
            this.pnlMitarbeiterContent = new Panel();
            this.lblMitarbeiterPK = new Label();
            this.txtMitarbeiterPK = new TextBox();
            panel1.SuspendLayout();
            pnlMitarbeiterFooter.SuspendLayout();
            this.pnlMitarbeiterContent.SuspendLayout();
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
            // lblMitarbeiterHeaderSubtitle
            // 
            lblMitarbeiterHeaderSubtitle.AutoSize = true;
            lblMitarbeiterHeaderSubtitle.Location = new Point(11, 37);
            lblMitarbeiterHeaderSubtitle.Name = "lblMitarbeiterHeaderSubtitle";
            lblMitarbeiterHeaderSubtitle.Size = new Size(221, 25);
            lblMitarbeiterHeaderSubtitle.TabIndex = 1;
            lblMitarbeiterHeaderSubtitle.Text = "Mitarbeiterdaten eingeben";
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
            // btnMitarbeiterCancel
            // 
            btnMitarbeiterCancel.Location = new Point(320, 6);
            btnMitarbeiterCancel.Name = "btnMitarbeiterCancel";
            btnMitarbeiterCancel.Size = new Size(121, 34);
            btnMitarbeiterCancel.TabIndex = 0;
            btnMitarbeiterCancel.Text = "Abbrechen";
            btnMitarbeiterCancel.UseVisualStyleBackColor = true;
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
            // pnlMitarbeiterContent
            // 
            this.pnlMitarbeiterContent.AutoScroll = true;
            this.pnlMitarbeiterContent.Controls.Add(this.txtMitarbeiterPK);
            this.pnlMitarbeiterContent.Controls.Add(this.lblMitarbeiterPK);
            this.pnlMitarbeiterContent.Location = new Point(75, 77);
            this.pnlMitarbeiterContent.Name = "pnlMitarbeiterContent";
            this.pnlMitarbeiterContent.Size = new Size(449, 496);
            this.pnlMitarbeiterContent.TabIndex = 2;
            // 
            // lblMitarbeiterPK
            // 
            this.lblMitarbeiterPK.AutoSize = true;
            this.lblMitarbeiterPK.Location = new Point(18, 17);
            this.lblMitarbeiterPK.Name = "lblMitarbeiterPK";
            this.lblMitarbeiterPK.Size = new Size(169, 25);
            this.lblMitarbeiterPK.TabIndex = 0;
            this.lblMitarbeiterPK.Text = "Mitarbeiternummer:";
            // 
            // txtMitarbeiterPK
            // 
            this.txtMitarbeiterPK.Location = new Point(193, 14);
            this.txtMitarbeiterPK.Name = "txtMitarbeiterPK";
            this.txtMitarbeiterPK.Size = new Size(238, 31);
            this.txtMitarbeiterPK.TabIndex = 1;
            // 
            // MitarbeiterForm
            // 
            ClientSize = new Size(601, 631);
            Controls.Add(this.pnlMitarbeiterContent);
            Controls.Add(pnlMitarbeiterFooter);
            Controls.Add(panel1);
            Name = "MitarbeiterForm";
            Text = "Mitarbeiter";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlMitarbeiterFooter.ResumeLayout(false);
            this.pnlMitarbeiterContent.ResumeLayout(false);
            this.pnlMitarbeiterContent.PerformLayout();
            ResumeLayout(false);

        }
    }
}
