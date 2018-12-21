using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    //PKW erbt mittels des :-Zeichens von der Fahrzeug-Klasse und übernimmt somit alle Eigenschaften und Methoden von dieser.
    //PKW hat das Interface IBewegbar implementiert, wodurch die Klasse zur Implementierung der dem Interface eigenen Methoden
    //und Eigenschaftet verpflichtet wird. 
    public class PKW : Fahrzeug, IBewegbar
    {
        //Zusätzliche PKW-eigene Eigenschaft
        public int AnzahlTüren { get; set; }

        //Durch Interface geforderte Eigenschaft
        public int Räderanzahl { get; set; }

        //PKW-Konstruktor, welcher per BASE-Stichwort den Konstruktor der Fahrzeugklasse aufruft. Dieser erstellt dann ein Fahrzeug, gibt dies
        ///an diesen Konstruktor zurück, welcher dann die zusätzlichen Eigenschaften einfügt
        public PKW(string name, int maxG, double preis, int türen) : base(name, maxG, preis)
        {
            this.AnzahlTüren = türen;
            this.Räderanzahl = 4;
        }

        //Per OVERRIDE werden virtuelle und abstrakte Methoden der Mutterklasse überschrieben. Bei dem Methodenaufruf wir die Methode der
        ///Kindklasse aufgerufen
        public override string BeschreibeMich()
        {
            //Mittels des BASE-Stichworts wird auf die Methode der Mutterklasse zugegriffen
            return "Der PKW " + base.BeschreibeMich() + $" Er hat {this.AnzahlTüren} Türen.";
        }

        //Durch Mutterklasse geforderte (weil als ABSTRACT gesetzte) Funktion
        public override void BaueUnfall()
        {
            Console.WriteLine("Bumm");
        }

        //Durch Interface geforderte Methode
        public void Bewegen()
        {
            Console.WriteLine("Brumm");
        }

        //Statischer Zufallszahlengenerator für die ErzeugeZufälligenPKW()-Methode
        private static Random generator = new Random();
        //Statische Methode (gilt für die gesamte Klasse) zur Erstellung eines zufälligen PKWs 
        public static PKW ErzeugeZufälligenPKW(string plusName = "")
        {
            string name;
            switch (generator.Next(1, 5))
            {
                case 1:
                    name = "BMW" + plusName;
                    break;
                case 2:
                    name = "Mercedes" + plusName;
                    break;
                case 3:
                    name = "Audi" + plusName;
                    break;
                default:
                    name = "VW" + plusName;
                    break;
            }
            return new PKW(name, generator.Next(15, 31) * 10, generator.Next(15, 30) * 1000, generator.Next(1, 3) == 1 ? 3 : 5);
        }
    }
}
