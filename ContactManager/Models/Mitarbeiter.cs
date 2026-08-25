using System;
using System.Collections.Generic;
using System.Text;
using ContactManager.Enums;

namespace ContactManager.Models

    /// <summary>
    /// Repräsentiert einen Mitarbeiter. Erbt die allgemeinen Personendaten von Person
    /// und ergänzt mitarbeiterspezifische Felder wie Anstellung und Kaderstufe.
    /// </summary>
{
    public class Mitarbeiter : Person
    {
        // Wird automatisch vergeben, wenn ein neuer Mitarbeiter erstellt wird. Dient als eindeutige Identifikation.
        public int MitarbeiterNummer { get; set; }
        public string Abteilung { get; set; } = string.Empty;
        public string AhvNummer { get; set; } = string.Empty;
        public string Wohnort { get; set; } = string.Empty;
        public string Nationalität { get; set; } = string.Empty;
        public string Adresse { get; set; } = string.Empty;
        public string Plz { get; set; } = string.Empty;
        public DateTime EinstellungsDatum { get; set; }

        // Ein aktiver Mitarbeiter kann kein Kündigungsdatum haben, daher Nullable
        public DateTime? KündigungsDatum { get; set; }

        // Beschäftigungsgrad in Prozent, z.B. 1.0m für 100%, 0.5m für 50%.
        public decimal Pensum { get; set; }
        public string Rolle { get; set; } = string.Empty;
        public ManagementLevel ManagementLevel { get; set; }

        // Anzahl Lehrjahre der Ausbildung (0, wenn kein Lernender).
        public int Lehrjahre { get; set; }

        /// <summary>
        /// Nullable, da nur für aktuell Lernende relevant - reguläre
        /// Mitarbeiter haben keinen Wert hier.
        /// </summary>
        public int? AktuellesLehrjahr { get; set; }
        public string GeschäftsAdresse { get; set; } = string.Empty;



    }
}
