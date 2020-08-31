    using System;

namespace Buchungssystem
{
    public class Rechnung
    {
        public string RechnungsNr { get; set; }
        public DateTime RechnungsDatum { get; set; }
        public double SummeNetto { get; set; }
        public double RabattProzent { get; set; }
        public double RabattPreis { get; private set; }
        public double NettoMitRabatt { get; private set; }
        public double UstProzent { get; set; } = 0.19;
        public double UstAufschlag { get; private set; }
        public double SummeBrutto { get; private set; }

        public void Berechne()
        {
            double nettoBezoglichRabatt = this.SummeNetto - this.RabattPreis;
           SummeBrutto = nettoBezoglichRabatt - (nettoBezoglichRabatt * this.UstProzent);
             
        }
        //TODO: Assoziation zur Bestellung

        //TODO Folgeauftrag
        //Hinweis: Für das Überprüfen Ihrer Lösung können Sie auch ein Testobjekt in der
        //Main-Methode erstellen.
    }
}