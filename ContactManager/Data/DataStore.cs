using System.Collections.Generic;
using ContactManager.Models;

namespace ContactManager.Data
{
    /// <summary>
    /// Hier liegen alle unsere Daten drin, während das Programm läuft.
    /// Genau dieses Objekt schreiben wir später in eine Datei und lesen es wieder ein.
    /// </summary>
    public class DataStore
    {
        /// <summary>Liste mit allen Kunden.</summary>
        public List<Kunde> Kunden { get; set; } = new();

        /// <summary>Liste mit allen Mitarbeitern.</summary>
        public List<Mitarbeiter> Mitarbeiter { get; set; } = new();
    }
}