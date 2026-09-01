using System;

namespace ContactManager.Models
{
    /// <summary>
    /// Eine einzelne protokollierte Notiz zu einem Mitarbeiter
    /// (z.B. Feedback, Vorfall, Bemerkung). Wird in Mitarbeiter.Kontakte gesammelt.
    /// </summary>
    public class MitarbeiterKontakt
    {
        public int Id { get; set; }
        public DateTime KontaktDatum { get; set; }
        public string Notizen { get; set; } = string.Empty;
    }
}