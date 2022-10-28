using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LA_Lernatelie_1301
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Wollen sie abnehmen (1), zunehmen (2) oder das Gewicht behalten? (3)");
            int richtigeeingabe = Convert.ToInt32(Console.ReadLine());
            while (richtigeeingabe != 1 && richtigeeingabe != 2 && richtigeeingabe != 3){
                Console.WriteLine("Wollen sie abnehmen (1), zunehmen (2) oder das Gewicht behalten? (3)");
                richtigeeingabe = Convert.ToInt32(Console.ReadLine());
            }
            

            Console.WriteLine("Geben sie folgende Daten ein");
            Console.WriteLine("Gewicht in Kg: ");
            string gewicht = Console.ReadLine();
            int gewichteingabe = Convert.ToInt32(gewicht);

            Console.WriteLine("Alter: ");
            string alter = Console.ReadLine();
            int altereingabe = Convert.ToInt32(alter);

            Console.WriteLine("Grösse in Cm: ");
            string groesse = Console.ReadLine();
            int groesseeingabe = Convert.ToInt32(groesse);

            string geschlecht="";
            while(geschlecht != "m" && geschlecht!="w") {
                Console.WriteLine("Geschlecht Männlich(m), Weiblich(w): ");
                geschlecht = Console.ReadLine();
            }
            
            
            Console.WriteLine("Das sind ihre Körperdaten: " + richtigeeingabe + " " + gewicht + "Kg" + " " + alter + "Jahre" + " " + groesse + "cm" + " " + geschlecht);


            Console.Clear();


            var formeln = new Formeln();

            
            double grundumsatz = formeln.Grundumsatz(gewichteingabe, groesseeingabe, altereingabe, geschlecht);
            int grundumsatzRunden = (int)Math.Round(grundumsatz, MidpointRounding.AwayFromZero);


            
            Console.WriteLine("Wie viel Energie verbraucht ihr Körper am Tag, nach dieser Skala, die die Belastung angibt: ");
            Console.WriteLine("ausschließlich sitzende/liegende Lebensweise (1.2)");
            Console.WriteLine("ausschließlich sitzende Tätigkeit wenig/keine körperliche Aktivität in der Freizeit (1.4)");
            Console.WriteLine("sitzende Tätigkeit, zusätzlicher Energieaufwand für zeitweilige gehende/stehende Tätigkeiten (1.6)");
            Console.WriteLine("überwiegend gehende/stehende Tätigkeit (1.8)");
            Console.WriteLine("körperlich anstrengende berufliche Arbeit (2)");
            string l = Console.ReadLine();
            double lumsatz = Convert.ToDouble(l);
            Console.Clear();


            var formeln2 = new Formeln();

            double leistungsUmsatz = formeln2.Leistungsumsatz(lumsatz);
            

            var formeln3 = new Formeln();

            double gesamt = formeln3.Gesamtbedarf(grundumsatzRunden, leistungsUmsatz);
            int gesamtBedarf = Convert.ToInt32(gesamt);

            if (richtigeeingabe == 1)
            {
                Console.WriteLine("Ihr Täglicher Gesamtbedarf beträgt " + gesamtBedarf + "kcal und somit müssen sie 300-500kcal pro Tag weniger essen, um 0.5kg pro Woche abzunehmen.\nTipps für Kalorienarmes Essen z.B Hackfleisch-Gemüse-Pfanne hat 332 kcal, einfacher Gurkensalat hat 88 kcal oder Kalorienarme Ei-Gemüse-Pfanne hat 342 kcal.");         
            }
            if (richtigeeingabe == 2)
            {
                Console.WriteLine("Ihr Täglicher Gesamtbedarf beträgt " + gesamtBedarf + "kcal und somit müssen sie 300-500kcal pro Tag mehr essen, um 0.5kg pro Woche zuzunehmen.\nTipps für Kalorienreiches Essen z.B verschieden Öle haben viel Kalorien, wie auch verschiedene Nüsse");
            }
            if (richtigeeingabe == 3)
            {
                Console.WriteLine("Ihr Täglicher Gesamtbedarf beträgt " + gesamtBedarf + "kcal und somit sollten sie diese Kalorienanzahl beibehalten");
            }










        }
    }
}
