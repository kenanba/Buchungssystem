using System;

namespace Buchungssystem
{
    public class BestellPosition
    {
        public int PositionsNr { get; set; }
        public int Anzahl { get; set; }
        public BestellPosition(int positionsNr, int anzahl)
        {
            PositionsNr = positionsNr;
            Anzahl = anzahl;
        }

        //TODO: Assoziation zum Artikel
    }
}