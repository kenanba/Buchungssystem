using System;

namespace Buchungssystem
{
    class Program
    {
        static void Main(string[] args)
        {
          
            

            var kundenVerwaltung = new KundenVerwaltung();
            var konsolenDrucker = new KonsolenDrucker();

            foreach (var kunde in kundenVerwaltung.Kunden)
                konsolenDrucker.RechnungsAusgabe(kunde);

            Console.ReadLine();
        }
        //TODO: Attribut Preis einfügen
    }
}
