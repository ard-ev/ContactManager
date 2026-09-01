using System;
using System.Collections.Generic;
using System.Text;
using ContactManager.Enums;

namespace ContactManager.Models
{


    /// <summary>
    /// Repräsentiert einen Mitarbeiter. Erbt die allgemeinen Personendaten von Person
    /// und ergänzt mitarbeiterspezifische Felder wie Anstellung und Kaderstufe.
    /// </summary>
    public class Mitarbeiter : Person
    {
        public int MitarbeiterNummer { get; set; }
        public string Abteilung { get; set; } = string.Empty;
        public string AhvNummer { get; set; } = string.Empty;
        public string Wohnort { get; set; } = string.Empty;
        public string Nationalität { get; set; } = string.Empty;
        public string Adresse { get; set; } = string.Empty;
        public string Plz { get; set; } = string.Empty;
        public DateTime EinstellungsDatum { get; set; }
        // Kündigungsdatum ist nicht immer bekannt, daher ist es nullable
        public DateTime? KündigungsDatum { get; set; }
        public decimal Pensum { get; set; }
        public string Rolle { get; set; } = string.Empty;
        public Kaderstufe Kaderstufe { get; set; }
        public int Lehrjahre { get; set; }
        public int? AktuellesLehrjahr { get; set; }
        public string BusinessAdresse { get; set; } = string.Empty;

        /// <summary>
        /// Chronologische Liste aller Notizen zu diesem Mitarbeiter.
        /// Wird nie überschrieben, nur ergänzt.
        /// </summary>
        public List<MitarbeiterKontakt> Kontakte { get; set; } = new();

        /// <summary>
        /// Chronologische Liste aller Änderungen an den Stammdaten dieses Mitarbeiters
        /// (Mutationshistorie).
        /// </summary>
        public List<MitarbeiterMutation> Mutationen { get; set; } = new();



    }
}
