using System;
using System.Collections.Generic;
using System.Text;
using ContactManager.Enums;

namespace ContactManager.Models
{
    public class Mitarbeiter : Person
    {
        public int mitarbeiterNummer { get; set; }
        public string abteilung { get; set; } = string.Empty;
        public string ahvNummer { get; set; } = string.Empty;
        public string wohnort { get; set; } = string.Empty;
        public string nationalität { get; set; } = string.Empty;
        public string adresse { get; set; } = string.Empty;
        public string plz { get; set; } = string.Empty;
        public DateTime einstellungsDatum { get; set; }
        // Kündigungsdatum ist nicht immer bekannt, daher ist es nullable
        public DateTime? kündigungsDatum { get; set; }
        public decimal pensum { get; set; }
        public string rolle { get; set; } = string.Empty;
        public ManagementLevel managementLevel { get; set; }
        public int lehrjahre { get; set; }
        public int? aktuellesLehrjahr { get; set; }
        public string buisnessAdresse { get; set; } = string.Empty;



    }
}
