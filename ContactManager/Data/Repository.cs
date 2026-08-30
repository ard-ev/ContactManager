using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContactManager.Data
{
    /// <summary>
    /// Kümmert sich ums Speichern und Laden unserer Daten.
    /// Schreibt den ganzen Datenstamm als JSON-Datei auf die Festplatte
    /// und liest ihn beim Start wieder ein.
    /// </summary>
    public class Repository
    {
        // Wo die Datei auf der Festplatte liegt
        private readonly string _pfad;

        // Ein paar Einstellungen fürs Speichern (schön lesbar, Enums als Text)
        private readonly JsonSerializerOptions _optionen;

        /// <summary>Unsere Daten, solange das Programm läuft.</summary>
        public DataStore Data { get; private set; } = new();

        /// <summary>
        /// Legt das Repository an. Wenn kein Pfad angegeben wird,
        /// speichern wir die Datei einfach neben dem Programm.
        /// </summary>
        public Repository(string? pfad = null)
        {
            _pfad = pfad ?? Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "ContactManager",
                "contactmanager_json");

            Directory.CreateDirectory(Path.GetDirectoryName(_pfad)!);

            _optionen = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter() }
            };
        }

        /// <summary>
        /// Lädt die Daten von der Festplatte.
        /// Gibt es noch keine Datei, fangen wir einfach leer an.
        /// </summary>
        public void Load()
        {
            if (!File.Exists(_pfad))
            {
                // Noch keine eigene Datei vorhanden (z.B. beim allerersten Start
                // auf diesem Rechner). Startet dann mit den mitgelieferten
                // Testdaten aus der Seed-Datei, damit alle im Team mit
                // denselben Ausgangsdaten arbeiten.
                string seedPfad = Path.Combine(AppContext.BaseDirectory, "SeedData", "contactmanager.seed.json");
                if (File.Exists(seedPfad))
                {
                    string seedJson = File.ReadAllText(seedPfad);
                    Data = JsonSerializer.Deserialize<DataStore>(seedJson, _optionen) ?? new DataStore();
                    return;
                }

                Data = new DataStore();
                return;
            }

            string json = File.ReadAllText(_pfad);
            Data = JsonSerializer.Deserialize<DataStore>(json, _optionen) ?? new DataStore();
        }

        /// <summary>
        /// Speichert die aktuellen Daten als JSON-Datei auf die Festplatte.
        /// </summary>
        public void Save()
        {
            string json = JsonSerializer.Serialize(Data, _optionen);
            File.WriteAllText(_pfad, json);
        }
    }
}