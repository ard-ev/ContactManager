using System;
using System.Collections.Generic;
using System.Text;
using ContactManager.Enums;

namespace ContactManager.Models

    /// <summary>
    /// Ein einzelner protokollierter Kontakt mit einem Kunden
    /// (z.B. Telefonat, E-Mail, Besuch). Wird in Kunde.Kontakte gesammelt.
    /// </summary>
{
    public class Kundenkontakt
    {
        public int Id { get; set; }
        public DateTime KontaktDatum { get; set; }
        public string Notizen { get; set; } = string.Empty;
    }
}
