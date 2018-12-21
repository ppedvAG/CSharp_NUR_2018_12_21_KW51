using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wdh_OOP
{
    public class Tier
    {
        public string Name { get; set; }
        public int AnzahlBeine { get; set; }

        public Tier(string name, int anzB)
        {
            this.Name = name;
            this.AnzahlBeine = anzB;
        }
    }

    public class Hund : Tier
    {
        public string FellFarbe { get; set; }
        public Hund Kind { get; private set; }

        public Hund(string name, string farbe) : base(name, 4)
        {
            this.FellFarbe = farbe;
        }

        public void Gebären(string neuerName)
        {
            this.Kind = new Hund(neuerName, this.FellFarbe);
        }
    }

    public class Meise : Tier, IFlugfähig
    {
        public string FederFarbe { get; set; }
        public int AnzahlFlügel { get; set; }

        public Meise(string name, string farbe) : base(name, 2)
        {
            this.FederFarbe = farbe;
        }

        public void Abheben()
        {
            Console.WriteLine($"{this.Name} ist abgehoben.");
        }
    }

    public interface IFlugfähig
    {
        int AnzahlFlügel { get; set; }

        void Abheben();
    }



    class Program
    {
        static void Main(string[] args)
        {
            Hund hund = new Hund("Bello", "Braun");
            Meise meise = new Meise("Tschip", "Blau");

            Tier tier = hund;

            hund.FellFarbe = "Schwarz";
            tier.AnzahlBeine = 3;

            Hund hund2;

            if (tier is Hund)
                hund2 = (Hund)tier;

            hund.Gebären("Hasso");

            //hund.Kind = hund;


            meise.Abheben();

            tier = meise;

            tier.AnzahlBeine = 1;

            IFlugfähig flugfähigesObjekt = meise;

            flugfähigesObjekt.AnzahlFlügel = 1;

            Absturz(meise);

        }

        static void Absturz(IFlugfähig flugfähig)
        {
            if(flugfähig is Tier)
            {
                Tier tier1 = (Tier)flugfähig;
                Console.WriteLine($"{tier1.Name} ist abgestürzt.");

                Console.WriteLine($"{(flugfähig as Tier).Name} ist abgestürtzt.");
            }
            else
                Console.WriteLine("Etwas ist abgestürzt");
        }
    }
}
