using System;

namespace ContactManager.Models
{
    /// <summary>
    /// Ein einzelner protokollierter Änderungseintrag an den Stammdaten eines Mitarbeiters
    /// (z.B. Abteilung geändert, Pensum angepasst). Wird in Mitarbeiter.Mutationen
    /// gesammelt und nie nachträglich verändert - so bleibt die Mutationshistorie
    /// lückenlos nachvollziehbar.
    /// </summary>
    public class MitarbeiterMutation
    {
        public int Id { get; set; }
        public DateTime Zeitpunkt { get; set; }

        /// <summary>Name des geänderten Feldes, z.B. "Abteilung" oder "Pensum".</summary>
        public string Feld { get; set; } = string.Empty;

        public string AlterWert { get; set; } = string.Empty;
        public string NeuerWert { get; set; } = string.Empty;
    }
}