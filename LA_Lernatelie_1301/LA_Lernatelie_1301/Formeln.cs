using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_Lernatelie_1301
{
    public class Formeln
    {

       
        public double Grundumsatz(int gewicht, int groesse, int alter, string geschlecht)
        {
            double grundumsatz;
            if (geschlecht == "m")
            {
                grundumsatz = 66.47 + (13.7 * gewicht) + (5 * groesse) - (6.8 * alter);
            }
            else if (geschlecht == "w")
            {
                grundumsatz = 655.1 + (9.6 * gewicht) + (1.8 * groesse) - (4.7 * alter);
            }
            else
            {
                throw new Exception("Dieses Geschlecht kenne ich nicht.");
            }
            return grundumsatz;

        }

        public double Leistungsumsatz(double lumsatz)
        {
            double leistungsumsatz = ((8 * 0.95) + (16 * lumsatz)) / 24;
            return leistungsumsatz;
        }

        public double Gesamtbedarf(double grundumsatzRunden, double leistungsUmsatz)
        {
            double gesamtbedarf = grundumsatzRunden * leistungsUmsatz;
            return gesamtbedarf;
        }


       
        


    }
}
