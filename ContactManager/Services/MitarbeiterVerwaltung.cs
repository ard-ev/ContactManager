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
            mitarbeiter.ZuletztGeaendert = DateTime.Now;    // <- Neu hinzugefügt, um das Änderungsdatum beim Erstellen zu setzen
            repository.Data.Mitarbeiter.Add(mitarbeiter);
        }

        /// <summary>
        /// Schreibt den aktuellen Stand auf die Festplatte.
        /// Gibt die Aufgabe ans Repository weiter.
        /// </summary>
        public void Speichern()
        {
            repository.Save();
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
            mitarbeiter.ZuletztGeaendert = DateTime.Now; // <- Neu hinzugefügt, um das Änderungsdatum beim Bearbeiten zu setzen
        }

        /// <summary>
        /// Protokolliert eine neue Notiz zu einem Mitarbeiter. Der Eintrag bekommt
        /// automatisch den aktuellen Zeitpunkt und wird der Historie angehängt.
        /// </summary>
        public void NotizHinzufuegen(Mitarbeiter mitarbeiter, string notiz)
        {
            if (string.IsNullOrWhiteSpace(notiz))
                return;

            int naechsteId = mitarbeiter.Kontakte.Any() ? mitarbeiter.Kontakte.Max(k => k.Id) + 1 : 1;

            mitarbeiter.Kontakte.Add(new MitarbeiterKontakt
            {
                Id = naechsteId,
                KontaktDatum = DateTime.Now,
                Notizen = notiz.Trim()
            });

            repository.Save();
        }

        /// <summary>Gibt die Notizhistorie eines Mitarbeiters zurück, neueste Notiz zuerst.</summary>
        public IReadOnlyList<MitarbeiterKontakt> Notizhistorie(Mitarbeiter mitarbeiter)
        {
            return mitarbeiter.Kontakte
                .OrderByDescending(k => k.KontaktDatum)
                .ToList();
        }

        /// <summary>
        /// Protokolliert eine oder mehrere Feldänderungen an einem Mitarbeiter in der
        /// Mutationshistorie.
        /// </summary>
        public void MutationenProtokollieren(Mitarbeiter mitarbeiter, IEnumerable<(string Feld, string AlterWert, string NeuerWert)> aenderungen)
        {
            int naechsteId = mitarbeiter.Mutationen.Any() ? mitarbeiter.Mutationen.Max(m => m.Id) + 1 : 1;

            foreach (var (feld, alterWert, neuerWert) in aenderungen)
            {
                mitarbeiter.Mutationen.Add(new MitarbeiterMutation
                {
                    Id = naechsteId++,
                    Zeitpunkt = DateTime.Now,
                    Feld = feld,
                    AlterWert = alterWert,
                    NeuerWert = neuerWert
                });
            }

            repository.Save();
        }

        /// <summary>Gibt die Mutationshistorie eines Mitarbeiters zurück, neueste Änderung zuerst.</summary>
        public IReadOnlyList<MitarbeiterMutation> Mutationshistorie(Mitarbeiter mitarbeiter)
        {
            return mitarbeiter.Mutationen
                .OrderByDescending(m => m.Zeitpunkt)
                .ToList();
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
                m.Geburtsdatum.ToString("dd.MM.yyyy").Contains(suchtext) ||
                m.MitarbeiterNummer.ToString().Contains(suchtext)
            ).ToList();
        }
    }
}
