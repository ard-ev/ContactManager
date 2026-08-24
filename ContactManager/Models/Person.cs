using System;
using System.Collections.Generic;
using System.Text;
using ContactManager.Enums;

namespace ContactManager.Models
{
    public abstract class Person
    {
        public string vorname { get; set; } = string.Empty;
        public string nachname { get; set; } = string.Empty;
        public DateTime geburtsdatum { get; set; }
        public Geschlecht geschlecht { get; set; }
        public string mobilNummer { get; set; } = string.Empty;
        public string geschäftsNummer { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public Status Status { get; set; }

    }
}
