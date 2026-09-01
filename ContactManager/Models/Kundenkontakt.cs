using System;
using System.Collections.Generic;
using System.Text;
using ContactManager.Enums;

namespace ContactManager.Models

{
    /// <summary>
    /// Ein einzelner protokollierter Kontakt mit einem Kunden
    /// (z.B. Telefonat, E-Mail, Besuch). Wird in Kunde.Kontakte gesammelt.
    /// </summary>
    public class Kundenkontakt
    {
        public int Id { get; set; }
        public DateTime KontaktDatum { get; set; }
        public string Notizen { get; set; } = string.Empty;

        /// <summary>
        /// Nummer des Mitarbeiters, der diesen Kontakt hatte. Bewusst die
        /// Nummer statt des Namens gespeichert für den fall, dass ein Mitarbeiter später
        /// umbenannt wird, bleibt die Historie trotzdem korrekt zuordenbar.
        /// </summary>
        public int MitarbeiterNummer { get; set; }
    }
}
