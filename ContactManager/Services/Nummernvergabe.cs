using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Services
{
    /// <summary>
    /// Generische Hilfsklasse für die blockweise Nummernvergabe.
    /// Kunden und Mitarbeiter nutzen dasselbe Prinzip mit unterschiedlichen
    /// Start-Ziffern, damit man an der ersten Ziffer sofort erkennt, ob eine
    /// Nummer zu einem Kunden oder einem Mitarbeiter gehört
    /// </summary>
    internal static class Nummernvergabe
    {
        // Jeder Block fasst 100000 Nummern, z.B. 100000-199999.
        private const int Blockgroesse = 100_000;

        ///<summary>
        ///Ermittelt die nächste freie Nummer. startPraefix legt fest, mit
        ///welcher Ziffer der Nummernbereich beginnt (z.B. 1 für kunden: 100001 aufwärts)
        ///Ist ein Block voll (99999 Nummern vergeben), wird automatisch der nächste Präfix verwendet (z.B. 2, dann 3, 4).
        ///maxPraefix begrenzt, wie viele Blöcke maximal genutzt werden dürfen.
        /// </summary>
        
        public static int NaechsteNummer(IEnumerable<int> bestehendeNummern, int startPraefix, int maxPraefix)
        {
            var nummern = bestehendeNummern.Where(n => n >= startPraefix * Blockgroesse).ToList();

            if (!nummern.Any())
                return startPraefix * Blockgroesse + 1;

            int hoechste = nummern.Max();
            int aktuellerBlockStart = (hoechste / Blockgroesse) * Blockgroesse;
            int naechsteImBlock = hoechste + 1;

            //ist im aktuellen Block noch Platz (unter der Blockgrenze)?
            if (naechsteImBlock < aktuellerBlockStart + Blockgroesse)
                return naechsteImBlock;

            //Block ist voll -> nächster Block (z.B. von 100000 auf 200000)
            int naechsterBlockStart = aktuellerBlockStart + Blockgroesse;
            int naechsterPraefix = naechsterBlockStart / Blockgroesse;

            if (naechsterPraefix > maxPraefix)
                throw new InvalidOperationException("Keine weiteren Nummern in diesem Bereich verfügbar.");

            return naechsterBlockStart + 1;
        }
    }
}
