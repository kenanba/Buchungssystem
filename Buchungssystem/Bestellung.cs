using System;
using System.Collections.Generic;

namespace Buchungssystem
{
    class Bestellung
    {
        public string BestellNr { get; set; }
        public DateTime BestellDatum { get; set; }
        public Bestellung(string bestellNr, DateTime bestellDatum)
        {
            BestellDatum = bestellDatum;
            BestellNr = bestellNr;


            //Rechnung test = new Rechnung(12, 12);
            //test.SummeNetto = 12;
            //test.Berechne
        }

        //TODO: Assoziation zur BestellPosition, Kunde und Rechnung

        //TODO: Methode zum Hinzufügen einer einzelnen BestellPosition
        //TODO: Folgeauftrag Berechnung der SummeNetto
    }
}