using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ContactManager.Data;
using ContactManager.Models;

namespace ContactManager.Services
{
    /// <summary>
    /// Verwaltet Kunden: Erfassen, Bearbeiten, Löschen, (De)Aktivieren, Suchen.
    /// (De)Aktivieren, Suchen sowie Speichern/Laden auf Festplatte als JSON.
    /// Die GUI (KundenForm) ruft ausschliesslich diese Klasse auf und
    /// enthält selbst keine Geschäftslogik.
    /// </summary>
    public class KundenVerwaltung
    {
        // Private Feldnamen bewusst camelCase, da nicht von aussen sichtbar.
        private readonly List<Kunde> kunden = new();

        // Pfad zur Speicherdatei. Liegt im Programmverzeichnis.
        private const string Dateipfad = "kunden.json";

        /// <summary>Liefert eine schreibgeschützte Sicht auf alle Kunden (z.B. für DataGridView-Bindung).</summary>
        public IReadOnlyList<Kunde> Alle => kunden;

        /// <summary>Fügt einen neuen Kunden zur Liste hinzu.</summary>
        public void Hinzufuegen(Kunde kunde)
        {
            kunden.Add(kunde);
        }

        /// <summary>
        /// "Bearbeiten" heisst hier: der übergebene Kunde ist bereits die
        /// gleiche Objektreferenz aus der Liste (per Referenztyp), daher
        /// müssen die Properties nur direkt am Objekt geändert werden -
        /// diese Methode dient primär der Lesbarkeit/Konsistenz nach aussen.
        /// </summary>
        public void Bearbeiten(Kunde kunde)
        {
            // Bewusst leer: Änderungen an Properties wirken sich direkt aus,
            // da Kunde eine Klasse (Referenztyp) ist. Methode existiert als
            // klarer Ansprechpunkt, falls später Validierung ergänzt wird.
        }

        /// <summary>Entfernt einen Kunden endgültig aus der Liste.</summary>
        public void Loeschen(Kunde kunde)
        {
            kunden.Remove(kunde);
        }

        /// <summary>
        /// Setzt den Kunden auf inaktiv, statt ihn zu löschen.
        /// So bleiben Kontakthistorie und Referenzen erhalten.
        /// </summary>
        public void Deaktivieren(Kunde kunde)
        {
            kunde.Status = Enums.Status.Inactive;
        }

        public void Aktivieren(Kunde kunde)
        {
            kunde.Status = Enums.Status.Active;
        }

        /// <summary>
        /// Sucht Kunden anhand von Vorname, Nachname oder Geburtsdatum.
        /// Gross-/Kleinschreibung wird ignoriert.
        /// </summary>
        public List<Kunde> Suchen(string suchtext)
        {
            if (string.IsNullOrWhiteSpace(suchtext))
                return kunden.ToList();

            return kunden.Where(k =>
                k.Vorname.Contains(suchtext, System.StringComparison.OrdinalIgnoreCase) ||
                k.Nachname.Contains(suchtext, System.StringComparison.OrdinalIgnoreCase) ||
                k.Geburtsdatum.ToString("dd.MM.yyyy").Contains(suchtext)
            ).ToList();
        }

        /// <summary>Speichert alle Kunden als JSON-Datei auf der Festplatte.</summary>
        public void Speichern()
        {
            // WriteIndented macht die Datei lesbar (nützlich beim Debuggen).
            var optionen = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(kunden, optionen);
            File.WriteAllText(Dateipfad, json);
        }

        /// <summary>
        /// Lädt Kunden aus der JSON-Datei, falls vorhanden.
        /// Wird beim Programmstart aufgerufen.
        /// </summary>
        public void Laden()
        {
            if (!File.Exists(Dateipfad))
                return; // Erster Start: noch keine Datei vorhanden - kein Fehler.

            string json = File.ReadAllText(Dateipfad);
            var geladeneKunden = JsonSerializer.Deserialize<List<Kunde>>(json);

            kunden.Clear();
            if (geladeneKunden != null)
                kunden.AddRange(geladeneKunden);
        }
    }
}