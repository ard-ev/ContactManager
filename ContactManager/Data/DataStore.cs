using System.Collections.Generic;
using ContactManager.Models;

namespace ContactManager.Data
{
    /// <summary>
    /// Hält den gesamten Datenstamm der Anwendung im Speicher.
    /// Wird als Ganzes serialisiert und wieder geladen.
    /// </summary>
    public class DataStore
    {
        /// <summary>Alle erfassten Kunden.</summary>
        public List<Kunde> Kunden { get; set; } = new();

        /// <summary>Alle erfassten Mitarbeiter.</summary>
        public List<Mitarbeiter> Mitarbeiter { get; set; } = new();
    }
}