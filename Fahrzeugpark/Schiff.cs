using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    //vgl. auch PKW
    //Mittels des IEnumeable-Interfaces können Klassen die GetEnumerator()-Methode implementieren, welche von foreach-Schleifen aufgerufen wird 
    public class Schiff : Fahrzeug, IBeladbar, IEnumerable
    {
        //Klassen-eigener Enumerator
        public enum Treibstoffart { Dampf = 1, Diesel, Strom, Windkraft }

        public Treibstoffart Treibstoff { get; set; }
        public Fahrzeug Ladung { get; set; }

        public List<Fahrzeug> Ladungsliste { get; set; }

        public Schiff(string name, int maxG, double preis, Treibstoffart treibstoff) : base(name, maxG, preis)
        {
            this.Treibstoff = treibstoff;
            this.Ladungsliste = new List<Fahrzeug>();
        }

        public override string BeschreibeMich()
        {
            string appendix = " und der Laderaum ist leer.";
            if (this.Ladung is Fahrzeug)
                appendix = $"und es hat {this.Ladung.Name} geladen.";
            return "Das Schiff " + base.BeschreibeMich() + $" Es wird mit {this.Treibstoff} betrieben {appendix}";
        }
        
        public override void BaueUnfall()
        {
            Console.WriteLine("BlubbBlubb");
        }

        public void Belade(Fahrzeug fz)
        {
            if (this.Ladung is Fahrzeug)
                Console.WriteLine($"Ladeplatz von {this.Name} schon von {this.Ladung.Name} belegt");
            else
            {
                this.Ladung = fz;
                Console.WriteLine($"{this.Ladung.Name} wurde auf {this.Name} geladen.");
            }
        }

        public void Entlade()
        {
            if (this.Ladung is Fahrzeug)
            {
                Console.WriteLine($"{this.Ladung.Name} wurde von {this.Name} geladen.");
                this.Ladung = null;
            }
            else
                Console.WriteLine($"Der Ladeplatz von {this.Name} ist leer.");

        }
         
        //Durch IEnumerator geforderte Methode (wird bei Verwendung der foreach-Schleife aufgerufen)
        public IEnumerator GetEnumerator()
        {
            foreach (var item in this.Ladungsliste)
            {
                //Das YIELD-Stichwort gibt in jedem Schleifendurchlauf einen Wert zurück, ohne dass die Methode beendet wird
                yield return item;
            }
        }
    }
}
