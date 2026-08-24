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
            SuspendLayout();
            // 
            // KundenForm
            // 
            ClientSize = new Size(748, 498);
            Name = "KundenForm";
            Text = "Kunden";
            ResumeLayout(false);

        }
    }
}
