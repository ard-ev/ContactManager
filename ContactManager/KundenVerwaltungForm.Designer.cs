namespace ContactManager
{
    partial class KundenVerwaltungForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Panel pnlKVHeader;
        private Label lblKVHeaderTitle;
        private Label lblKVHeaderSubtitle;
        private TabControl tabKVHistorie;
        private TabPage tabKVNotizen;
        private TabPage tabKVMutationen;
        private Label lblKVNeueNotiz;
        private TextBox txtKVNeueNotiz;
        private Button btnKVNotizHinzufuegen;
        private DataGridView dgvKVNotizen;
        private DataGridView dgvKVMutationen;
        private Panel pnlKVFooter;
        private Button btnKVSchliessen;
    }
}