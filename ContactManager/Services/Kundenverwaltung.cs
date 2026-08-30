using System.Collections.Generic;
using System.Linq;
using ContactManager.Data;
using ContactManager.Models;

namespace ContactManager.Services
{
    /// <summary>
    /// Verwaltet Kunden: Erfassen, Bearbeiten, Löschen, (De)Aktivieren, Suchen.
    /// Arbeitet direkt auf den Daten im übergebenen Repository, damit Kunden
    /// und Mitarbeiter gemeinsam in einer einzigen Datei gespeichert werden
    /// (statt jede Verwaltungsklasse mit einer eigenen Datei).
    /// </summary>
    public class KundenVerwaltung
    {
        private readonly Repository repository;

        /// <summary>
        /// Übernimmt ein bestehendes Repository, statt selbst eines zu erzeugen.
        /// So teilen sich KundenVerwaltung und MitarbeiterVerwaltung dieselbe
        /// Datenquelle (dasselbe Repository-Objekt).
        /// </summary>
        public KundenVerwaltung(Repository repository)
        {
            this.repository = repository;
        }

        /// <summary>Direkter Zugriff auf die aktuelle Kundenliste im Repository.</summary>
        public IReadOnlyList<Kunde> Alle => repository.Data.Kunden;

        public void Hinzufuegen(Kunde kunde)
        {
            kunde.KundenNummer = NaechsteKundenNummer();
            repository.Data.Kunden.Add(kunde);
        }

        /// <summary>
        /// Ermittelt die nächste freie Kundennummer basierend auf der höchsten
        /// bereits vergebenen Nummer. Bewusst NICHT als Zähler im Kunde-Objekt
        /// selbst gelöst, weil beim Laden aus der JSON-Datei sonst der Zähler
        /// wieder bei 0 anfangen würde und Nummern doppelt vergeben könnte
        /// </summary>

        private int NaechsteKundenNummer(){
            if (!repository.Data.Kunden.Any())
                return 1;
            return repository.Data.Kunden.Max(k => k.KundenNummer) + 1;
        }

        /// <summary>
        /// Schreibt den aktuellen Stand auf die Festplatte.
        /// Gibt die Aufgabe einfach ans Repository weiter.
        /// </summary>
        public void Speichern()
        {
            repository.Save();
        }

        /// <summary>
        /// Bewusst leer: Kunde ist ein Referenztyp, Änderungen an den Properties
        /// wirken sich direkt aus. Existiert als klarer Ansprechpunkt für später,
        /// falls noch Validierung ergänzt wird.
        /// </summary>
        public void Bearbeiten(Kunde kunde)
        {
        }

        public void Loeschen(Kunde kunde)
        {
            repository.Data.Kunden.Remove(kunde);
        }

        /// <summary>Setzt den Kunden auf inaktiv statt ihn zu löschen (Historie bleibt erhalten).</summary>
        public void Deaktivieren(Kunde kunde)
        {
            kunde.Status = Enums.Status.Inaktiv;
        }

        public void Aktivieren(Kunde kunde)
        {
            kunde.Status = Enums.Status.Aktiv;
        }

        /// <summary>Sucht Kunden anhand von Vorname, Nachname oder Geburtsdatum.</summary>
        public List<Kunde> Suchen(string suchtext)
        {
            if (string.IsNullOrWhiteSpace(suchtext))
                return repository.Data.Kunden.ToList();

            return repository.Data.Kunden.Where(k =>
                k.Vorname.Contains(suchtext, System.StringComparison.OrdinalIgnoreCase) ||
                k.Nachname.Contains(suchtext, System.StringComparison.OrdinalIgnoreCase) ||
                k.Geburtsdatum.ToString("dd.MM.yyyy").Contains(suchtext)
            ).ToList();
        }
    }
}