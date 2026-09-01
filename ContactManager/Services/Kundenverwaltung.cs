using System.Collections.Generic;
using System.Linq;
using System;
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
            kunde.ZuletztGeaendert = DateTime.Now;    // <- Neu hinzugefügt, um das Änderungsdatum beim Erstellen zu setzen
            repository.Data.Kunden.Add(kunde);
        }

        /// <summary>
        /// Gibt die Nummer zurück, die der nächste neu erfasste Kunde erhalten würde.
        /// Wird genutzt, um sie dem Nutzer schon im Erfassungsformular anzuzeigen,
        /// bevor gespeichert wird.
        /// </summary>
        public int NaechsteFreieNummer()
        {
            return NaechsteKundenNummer();
        }

        /// <summary>
        /// Ermittelt die nächste freie Kundennummer basierend auf der höchsten
        /// bereits vergebenen Nummer. Bewusst NICHT als Zähler im Kunde-Objekt
        /// selbst gelöst, weil beim Laden aus der JSON-Datei sonst der Zähler
        /// wieder bei 0 anfangen würde und Nummern doppelt vergeben könnte
        /// </summary>

        public int NaechsteKundenNummer()
        {
            return Nummernvergabe.NaechsteNummer(
                repository.Data.Kunden.Select(k => k.KundenNummer),
                startPraefix: 1,
                maxPraefix: 4);
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
        /// Protokolliert eine neue Notiz zu einem Kunden. Der Eintrag bekommt
        /// automatisch den aktuellen Zeitpunkt und wird der Historie angehängt.
        /// Bestehende Einträge werden nie verändert, nur ergänzt.
        /// </summary>
        public void NotizHinzufuegen(Kunde kunde, string notiz, int mitarbeiterNummer)
        {
            if (string.IsNullOrWhiteSpace(notiz))
                return;

            Kundenkontakt kontakt = new Kundenkontakt
            {
                Id = NaechsteKontaktId(kunde),
                KontaktDatum = System.DateTime.Now,
                Notizen = notiz.Trim(),
                MitarbeiterNummer = mitarbeiterNummer
            };

            kunde.Kontakte.Add(kontakt);
            repository.Save();
        }

        /// <summary>
        /// Gibt die Kontakthistorie eines Kunden zurück, neueste Notiz zuerst.
        /// </summary>
        public IReadOnlyList<Kundenkontakt> Kontakthistorie(Kunde kunde)
        {
            return kunde.Kontakte
                .OrderByDescending(k => k.KontaktDatum)
                .ToList();
        }

        /// <summary>
        /// Ermittelt die nächste freie Id innerhalb der Kontakte eines Kunden.
        /// </summary>
        private int NaechsteKontaktId(Kunde kunde)
        {
            if (!kunde.Kontakte.Any())
                return 1;
            return kunde.Kontakte.Max(k => k.Id) + 1;
        }

        /// <summary>
        /// Protokolliert eine oder mehrere Feldänderungen an einem Kunden in der
        /// Mutationshistorie. Wird beim Speichern von KundenForm aufgerufen, nachdem
        /// die Änderungen gegenüber dem Ausgangszustand ermittelt wurden.
        /// Bestehende Einträge werden nie verändert, nur ergänzt.
        /// </summary>
        public void MutationenProtokollieren(Kunde kunde, IEnumerable<(string Feld, string AlterWert, string NeuerWert)> aenderungen)
        {
            int naechsteId = NaechsteMutationId(kunde);

            foreach (var (feld, alterWert, neuerWert) in aenderungen)
            {
                kunde.Mutationen.Add(new KundenMutation
                {
                    Id = naechsteId++,
                    Zeitpunkt = System.DateTime.Now,
                    Feld = feld,
                    AlterWert = alterWert,
                    NeuerWert = neuerWert
                });
            }

            repository.Save();
        }

        /// <summary>
        /// Gibt die Mutationshistorie eines Kunden zurück, neueste Änderung zuerst.
        /// </summary>
        public IReadOnlyList<KundenMutation> Mutationshistorie(Kunde kunde)
        {
            return kunde.Mutationen
                .OrderByDescending(m => m.Zeitpunkt)
                .ToList();
        }

        /// <summary>
        /// Ermittelt die nächste freie Id innerhalb der Mutationen eines Kunden.
        /// </summary>
        private int NaechsteMutationId(Kunde kunde)
        {
            if (!kunde.Mutationen.Any())
                return 1;
            return kunde.Mutationen.Max(m => m.Id) + 1;
        }

        /// <summary>
        /// Bewusst leer: Kunde ist ein Referenztyp, Änderungen an den Properties
        /// wirken sich direkt aus. Existiert als klarer Ansprechpunkt für später,
        /// falls noch Validierung ergänzt wird.
        /// </summary>
        public void Bearbeiten(Kunde kunde)
        {
            kunde.ZuletztGeaendert = DateTime.Now; // <- Neu hinzugefügt, um das Änderungsdatum beim Bearbeiten zu setzen
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
                k.Geburtsdatum.ToString("dd.MM.yyyy").Contains(suchtext) ||
                k.KundenNummer.ToString().Contains(suchtext)
            ).ToList();
        }


        /// <summary>
        /// Protokolliert einen neuen Kontakt (z.B. Anruf, E-Mail) mit dem Kunden,
        /// inklusive welcher Mitarbeiter den Kontakt hatte. Wird nie aus der
        /// Historie entfernt, nur ergänzt.
        /// </summary>
        public void KontaktHinzufuegen(Kunde kunde, int mitarbeiterNummer, string notiz)
        {
            int naechsteId = kunde.Kontakte.Any() ? kunde.Kontakte.Max(k => k.Id) + 1 : 1;

            kunde.Kontakte.Add(new Kundenkontakt
            {
                Id = naechsteId,
                KontaktDatum = DateTime.Now,
                Notizen = notiz,
                MitarbeiterNummer = mitarbeiterNummer
            });

            Speichern();
        }
    }
}