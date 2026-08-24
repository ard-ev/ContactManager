using System;
using System.Collections.Generic;
using System.Text;
using ContactManager.Enums;

namespace ContactManager.Models
{
    public class Kundenkontakt
    {
        public int ID { get; set; }
        public DateTime KontaktDatum { get; set; }
        public string Notizen { get; set; } = string.Empty;
    }
}
