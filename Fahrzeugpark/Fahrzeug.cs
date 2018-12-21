using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    //KLASSEN sind Vorlagen für OOP-Objekte. Hier wird das Aussehen , das Verhalten und der Startzustand für Objekte dieses Typs definiert.
    //Von einer als ABSTRACT gesetzten Klasse können keine Objekte instanziiert werden. Sie ist rein zur Vererbung gedacht.
    public abstract class Fahrzeug
    {
        #region StatischeMember
        //Als STATIC markierte Variablen und Methoden hängen an der Klasse selbst und nicht an instanziierten Objekten.
        public static int AnzahlFahrzeuge = 0;
        #endregion

        #region Felder/Eigenschaften
        //FELDER (Membervariablen) sind die Variablen einzelner Objekte, welche die Zustände dieser Objekte definieren
        private int maxGeschwindigkeit;
        //EIGENSCHAFTEN (Properties) definieren mittels Getter/Setter den Lese-/Schreibzugriff für jeweils ein Feld.
        ///In den Eigenschaften können bestimmte Bedingungen für das Lesen und Schreiben der Felder gesetzt werden, sowie der Zugriff
        ///für Lesen und Schreiben einzeln angepasst werden
        public int MaxGeschwindigkeit
        {
            get { return maxGeschwindigkeit; }
             set
            {
                if (value > 0)
                    //Das Schlüsselwort VALUE beschreibt in einer Set-Methode den übergebenen Wert
                    maxGeschwindigkeit = value;
            }
        }

        //Wird in einer Eigenschaft keine Spezifizierung angegeben, generiert das Programm das entsprechende Feld unsichtbar im Hintergrund
        public string Name { get;  set; }
        public double Preis { get;  set; }
        public int AktGeschwindigkeit { get;  set; }
        public bool Zustand { get;  set; } //True = Motor läuft 
        #endregion

        #region Konstruktor/Destruktor
        //KONSTRUKTOREN sind spezielle Methoden, welche ein neues Objekt instanziiert und den Anfangszustand festlegt. Sie definieren sich
        ///durch den Namen (derselbe, wie die Klasse) und den nicht vorhandenen Rückgabetyp (nicht mal void)
        public Fahrzeug(string name, int maxG, double preis)
        {
            this.Name = name;
            this.MaxGeschwindigkeit = maxG;
            this.Preis = preis;

            this.AktGeschwindigkeit = 0;
            this.Zustand = false;

            AnzahlFahrzeuge++;
        }

        //Es können mehrere Konstruktoren definiert werden, welche unterschiedliche Übergabeparameter haben (Überladung)
        public Fahrzeug()
        {
            //Ein Konstruktor ohne Übergabeparameter wird Standartkonstruktor genannt. Wid kein Konstruktor
            //definiert, wird automatisch ein Standartkonstruktor mit leerem Körper erzeugt
        }

        //Der DESTRUKTOR wird von der GarbageCollection aufgerufen, wenn ein Objekt aus dem Speicher gelöscht wird. Der Destruktor wird 
        ///automatisch (unsichtbar) erzeugt und muss nur selbst geschrieben werden, wenn neben der Objektzerstörung noch andere Anweisungen
        ///ausgeführt werden sollen.
        ~Fahrzeug()
        {
            Console.WriteLine($"{this.Name} wurde zerstört.");
        }
        #endregion

        #region Member-Methoden
        //MEMBERMETHODEN sind Funktionen, welche jedes Objekt einer Klasse besitzt und speziell dieses Objekt manipuliert
        public void Beschleunige(int a)
        {
            if (this.Zustand)
            {
                if (this.AktGeschwindigkeit + a > this.MaxGeschwindigkeit)
                    this.AktGeschwindigkeit = this.MaxGeschwindigkeit;
                else if (this.AktGeschwindigkeit + a < 0)
                    this.AktGeschwindigkeit = 0;
                else
                    this.AktGeschwindigkeit += a;
                Console.WriteLine($"{this.Name} bewegt sich jetzt mit {this.AktGeschwindigkeit}km/h.");
            }
            else
                Console.WriteLine($"Vor einer Beschleunigung muss der Motor von {this.Name} gestartet werden.");
        }

        public void StarteMotor()
        {
            if (this.Zustand)
                Console.WriteLine($"Der Motor von {this.Name} läuft bereits.");
            else
            {
                this.Zustand = true;
                Console.WriteLine($"Der Motor von {this.Name} läuft jetzt.");
            }
        }

        public void StoppeMotor()
        {
            if (!this.Zustand)
                Console.WriteLine($"Der Motor von {this.Name} ist bereits aus.");
            else
            {
                this.Zustand = false;
                this.AktGeschwindigkeit = 0;
                Console.WriteLine($"Der Motor von {this.Name} ist jetzt aus.");
            }
        }

        //Eine als VIRTUAL gesetzte Methode erlaubt den Kindklassen diese per OVERRIDE zu überschreiben
        public virtual string BeschreibeMich()
        {
            if (this.Zustand)
                return $"{this.Name} bewegt sich mit {this.AktGeschwindigkeit} von maximal {this.MaxGeschwindigkeit}km/h und kostet {this.Preis} Euro.";
            else
                return $"{this.Name} kann sich maximal mit {this.MaxGeschwindigkeit}km/h bewegen und kostet {this.Preis} Euro. Es steht momentan einfach nur herum.";
        }

        //Eine als ABSTRACT gesetzte Methode (nur in abstrakten Klassen möglich) beseht nur aus einem Methodenkopf und zwingt erbende
        public abstract void BaueUnfall();

        //Überschreibung der ToString()-Methode, welche jede Klasse von der Object-Klasse erbt
        public override string ToString()
        {
            return this.BeschreibeMich();
        }

        //Mittels des OPERATOR-Stichworts können für einzelne Klassen Operatoren definiert werden 
        public static bool operator ==(Fahrzeug fz1, Fahrzeug fz2)
        {
            return fz1.Name == fz2.Name;
        }
        public static bool operator !=(Fahrzeug fz1, Fahrzeug fz2)
        {
            return fz1.Name != fz2.Name;
        }
        #endregion

    }
}
