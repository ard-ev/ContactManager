using System;
using System.Collections.Generic;
using System.Text;
using ContactManager.Enums;

namespace ContactManager.Models
{
    public abstract class Person
    {
        public string Vorname { get; set; } = string.Empty;
        public string Nachname { get; set; } = string.Empty;
        public DateTime Geburtsdatum { get; set; }
        public Geschlecht Geschlecht { get; set; }
        public string MobilNummer { get; set; } = string.Empty;
        public string GeschäftsNummer { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Status Status { get; set; }

    }
}
