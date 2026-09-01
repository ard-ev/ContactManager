using System;
using System.Collections.Generic;
using System.Text;
using ContactManager.Enums;

namespace ContactManager.Models
{
    /// <summary>
    /// Abstrakte Basisklasse für alle Personen im System (Kunden und Mitarbeiter).
    /// Enthält alle Felder, die für beide Rollen gleich sind.
    /// Kann nicht direkt instanziiert werden - nur über Kunde oder Mitarbeiter.
    /// </summary>
    public abstract class Person
    {
        public string Vorname { get; set; } = string.Empty;
        public string Nachname { get; set; } = string.Empty;
        public DateTime Geburtsdatum { get; set; }
        public Geschlecht Geschlecht { get; set; }
        public string MobilNummer { get; set; } = string.Empty;
        public string GeschäftsNummer { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Zeitpunkt der letzten Erfassung oder Änderung. Wird von den
        /// Verwaltungsklassen automatisch gesetzt, nicht manuell im Formular.
        /// </summary>
        public DateTime ZuletztGeaendert { get; set; }

        /// <summary>
        /// Aktiv/Inaktiv-Status. Wird für "Deaktivieren statt Löschen verwendet,
        /// damit historie und Referenzen erhalten bleiben.
        /// </summary>
        public Status Status { get; set; }

        //Praktisch, für spätere anzeige in Listboxen, Comboboxen etc.
        public override string ToString() => $"{Vorname} {Nachname} ({Status})";

    }
}
