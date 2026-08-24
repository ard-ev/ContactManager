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
            SuspendLayout();
            // 
            // MitarbeiterForm
            // 
            ClientSize = new Size(753, 471);
            Name = "MitarbeiterForm";
            Text = "Mitarbeiter";
            ResumeLayout(false);

        }
    }
}
