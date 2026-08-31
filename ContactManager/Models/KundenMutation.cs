using System;

namespace ContactManager.Models
{
    /// <summary>
    /// Ein einzelner protokollierter Änderungseintrag an den Stammdaten eines Kunden
    /// (z.B. Nachname geändert, Status auf inaktiv gesetzt). Wird in Kunde.Mutationen
    /// gesammelt und nie nachträglich verändert - so bleibt die Mutationshistorie
    /// lückenlos nachvollziehbar.
    /// </summary>
    public class KundenMutation
    {
        public int Id { get; set; }
        public DateTime Zeitpunkt { get; set; }

        /// <summary>Name des geänderten Feldes, z.B. "Nachname" oder "Status".</summary>
        public string Feld { get; set; } = string.Empty;

        public string AlterWert { get; set; } = string.Empty;
        public string NeuerWert { get; set; } = string.Empty;
    }
}