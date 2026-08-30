using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactManager.Data;
using ContactManager.Models;


namespace ContactManager.Services
{

    /// <summary>
    /// Verwaltet Mitarbeiter: Erfassen, Bearbeiten, Löschen, (De)Aktivieren, Suchen.
    /// Arbeitet direkt auf den im übergebenen Repository, analog zur Kundenverwaltung.
    /// </summary>
    public class MitarbeiterVerwaltung
    {
        private readonly Repository repository;

        public MitarbeiterVerwaltung(Repository repository)
        {
            this.repository = repository;
        }

        public IReadOnlyList<Mitarbeiter> Alle => repository.Data.Mitarbeiter;

        public void Hinzufuegen(Mitarbeiter mitarbeiter)
        {
            mitarbeiter.MitarbeiterNummer = NaechsteMitarbeiterNummer();
            repository.Data.Mitarbeiter.Add(mitarbeiter);
        }

        /// <summary>
        /// Ermittelt die nächste freie Mitarbeiternummer basierend auf der höchsten
        /// bereits vergebenen Nummer. Bewusst NICHT als zähler im Mitarbeiter-Objekt
        /// selbst gelöst, weil beim Laden aus der JSON-Datei sonst der Zähler
        /// wieder bei 0 anfangen würde und Nummern doppelt vergeben könnte
        /// </summary>

        public int NaechsteMitarbeiterNummer()
        {
            return Nummernvergabe.NaechsteNummer(
                repository.Data.Mitarbeiter.Select(m => m.MitarbeiterNummer),
                startPraefix: 6,
                maxPraefix: 9);
        }

        public void Bearbeiten(Mitarbeiter mitarbeiter)
        {
            // Bewusst leer: Mitarbeiter ist ein Referenztyp, Änderungen an den
            // Properties des Objekts wirken sich direkt auf das Objekt in der Liste aus.
        }

        public void Loeschen(Mitarbeiter mitarbeiter)
        {
            repository.Data.Mitarbeiter.Remove(mitarbeiter);
        }

        public void Deaktivieren(Mitarbeiter mitarbeiter)
        {
            mitarbeiter.Status = Enums.Status.Inaktiv;
        }

        public void Aktivieren(Mitarbeiter mitarbeiter)
        {
            mitarbeiter.Status = Enums.Status.Aktiv;
        }

        /// <summary> Sucht einen Mitarbeiter anhand von Namen, Nachname oder Geburtsdatum.</summary>
        
        public List<Mitarbeiter> Suchen(string suchtext)
        {
            if (string.IsNullOrWhiteSpace(suchtext))
                return repository.Data.Mitarbeiter.ToList();

            return repository.Data.Mitarbeiter.Where(m =>
               m.Vorname.Contains(suchtext, System.StringComparison.OrdinalIgnoreCase) ||
                m.Nachname.Contains(suchtext, System.StringComparison.OrdinalIgnoreCase) ||
                m.Geburtsdatum.ToString("dd.MM.yyyy").Contains(suchtext)
            ).ToList();
        }
    }
}
