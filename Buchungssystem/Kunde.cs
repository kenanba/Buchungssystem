using System.Collections.Generic;

namespace Buchungssystem
{
     class Kunde
    {
        public string KundenNr { get; set; }
        public string Name { get; set; }
        public string Strasse { get; set; }
        public string PLZ { get; set; }
        public string Ort { get; set; }

        //TODO: Assoziation zur Bestellung
    }
}
