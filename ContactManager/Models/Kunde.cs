using System;
using System.Collections.Generic;
using System.Text;
using ContactManager.Enums;

namespace ContactManager.Models
{
    public class Kunde : Person
    {
        public Anrede anrede { get; set; }
        public string Titel { get; set; } = string.Empty;

        public List<Kundenkontakt> Contacts { get; set; } = new();
    }
}
