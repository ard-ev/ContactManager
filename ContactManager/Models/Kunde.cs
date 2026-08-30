using System;
using System.Collections.Generic;
using System.Text;
using ContactManager.Enums;

namespace ContactManager.Models
{

    /// <summary>
    /// Repräsentiert einen Kunden. Erbt die allgemeinen Personendaten von Person
    /// und ergänzt kundenspezifische Felder sowie die Kontakthistorie.
    /// </summary>
    public class Kunde : Person
    {

        /// <summary>
        /// Wird automatisch von KundenVerwaltung vergeben, nicht manuell erfasst.
        /// </summary>
        public int KundenNummer { get; set; }
        public Anrede Anrede { get; set; }
        public string Titel { get; set; } = string.Empty;


        /// <summary>
        /// Chronologische Liste aller Kontaktaufnahmen mit diesem Kunden.
        /// Wird nie überschrieben, nur ergänzt - so bleibt die Historie
        /// vollständig nachvollziehbar (siehe Anforderung "Protokollierung inkl. Historie").
        /// </summary>
        public List<Kundenkontakt> Kontakte { get; set; } = new();
    }
}
