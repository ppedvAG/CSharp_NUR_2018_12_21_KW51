using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fahrzeugpark;

namespace TesteFahrzeugpark
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Modul04 - OOP
            ////vgl. Fahrzeugpark.Fahrzeug

            ////Deklaration und Initialisierung von Fahrzeugvariablen.
            ////Mittels des NEW-Stichworts wird der Konstruktor der Klasse aufgerufen und neue
            ////Fahrzeugobjekte instanziert.
            //Fahrzeug fz1 = new Fahrzeug("Audi", 200);
            //Fahrzeug fz2 = new Fahrzeug("BMW", 230);

            ////Zugriff auf den Getter der Name-Eigenschaft des Fahrzuegs in der Variable fz1
            //Console.WriteLine(fz1.Name);
            ////Zugriff auf den Setter der Name-Eigenschaft des Fahrzuegs in der Variable fz1
            //fz1.Name = "VW";
            //Console.WriteLine(fz1.Name);

            //Console.WriteLine(fz2.Name);

            ////Zugriff auf die BeschreibeMich()-Methode des Fahrzeugs in der Variable fz1
            //Console.WriteLine(fz1.BeschreibeMich()); 
            #endregion

            #region Lab04 - Fahrzeug-Klasse
            ////vgl. Fahrzeugpark.Fahrzeug

            ////Deklaration einer Fahrzeug-Variablen und Initialisierung über der Fahrzeug-Konstruktor
            //Fahrzeug fz1 = new Fahrzeug("BMW", 230, 26999.0);
            ////Aufruf der BeschreibeMich()-Methode des Fahrzeugs
            //Console.WriteLine(fz1.BeschreibeMich());
            ////Testen verschiedener Member-Methoden des Fahrzeugs
            //fz1.Beschleunige(15);

            //fz1.StarteMotor();

            //fz1.Beschleunige(300);

            //fz1.Beschleunige(-45);

            //Console.WriteLine(fz1.BeschreibeMich());
            #endregion

            #region Modul05 - Vererbung
            ////Erzeugung von PKW-Objekten als vom Fahrzeug erbende Objekte
            //PKW pkw1 = new PKW("BMW", 250, 24000.0, 5);
            //PKW pkw2 = new PKW("BMW", 250, 24000.0, 5);
            //PKW pkw3 = new PKW("BMW", 250, 24000.0, 5);

            ////Ausgabe der PKW-eigenen (weil mit virtual/override markierten) BeschreibeMich()-Funktion
            //Console.WriteLine(pkw1.BeschreibeMich());

            ////Ausgabe einer statischen Eigenschaft der Fahrzeug-Klasse
            //Console.WriteLine(Fahrzeug.AnzahlFahrzeuge); 
            #endregion

            #region Lab05 - Vererbung(2)
            ////Erzeugung von spezifischen Fahrzeugobjekten
            //PKW pkw1 = new PKW("BMW", 250, 26999.99, 5);
            //Schiff schiff1 = new Schiff("Titanic", 40, 3500000.00, Schiff.Treibstoffart.Dampf);
            //Flugzeug flugzeug1 = new Flugzeug("Boing 747", 990, 3000000.00, 9990);

            ////Aufruf der spezifischen BeschreibeMich()-Funktionen
            //Console.WriteLine(pkw1.BeschreibeMich());
            //Console.WriteLine(schiff1.BeschreibeMich());
            //Console.WriteLine(flugzeug1.BeschreibeMich());

            ////Ausgabe der statischen Variablen der Fahrzeugklasse
            //Console.WriteLine("Es wurden " + Fahrzeug.AnzahlFahrzeuge + " Fahrzeuge erzeugt."); 
            #endregion

            #region Modul06 - Polymorphismus
            ////Betrachtung eines PKW durch verschiedene Variablen

            ////In einer PKW-Variablen kann auf alle Eigenschaften/Funktionen der PKW-Klasse, 
            ////darin implementierter Interfaces sowie der vererbenden Klassen zugrgriffen werden.
            //PKW pkw1 = new PKW("Audi", 250, 20000.0, 5);
            //Console.WriteLine(pkw1.AnzahlTüren);

            ////In einer Fahrzeug-Variablen kann auf alle Eigenschaften/Funktionen der Fahrzeug-Klasse
            ////zugegriffen werden, auch, wenn wir immer noch ein PKW-Objekt betrachten (da nicht zwangsläufig 
            ////ein PKW-Objekt in der Variablen steckt.
            //Fahrzeug fz1 = pkw1;
            //fz1.StarteMotor();

            ////In einer IBewegbar-Variablen kann auf alle Eigenschaften/Funktionen zugegriffen werden, 
            ////welche durch das Interface definiert werden
            //IBewegbar bewegbaresObjekt = pkw1;
            //bewegbaresObjekt.Bewegen();

            ////Einer Methode, welche ein Interfaceobjekt erwartet, kann ein Objekt übergeben werde, welches
            ////dieses Interface implementiert hat (gilt auch für vererbende Klassen)
            //RadAb(bewegbaresObjekt); 
            #endregion

            #region Lab06 - IBeladbar
            ////Deklarierung und Initialisierung von Variablen
            //PKW pkw1 = new PKW("BMW", 230, 23000.0, 5);
            //Flugzeug flugzeug1 = new Flugzeug("Boing", 890, 3500000.0, 9980);
            //Schiff schiff1 = new Schiff("Titanic", 40, 3000000.0, Schiff.Treibstoffart.Dampf);

            ////Aufrufe der statischen Funktion zur Beladung zweier Fahrzeuge
            //BeladeFahrzeuge(pkw1, flugzeug1);
            //BeladeFahrzeuge(flugzeug1, schiff1);
            //BeladeFahrzeuge(schiff1, pkw1);

            ////Ausgabe der BeschreibeMich()-Funktion des Schiffs
            //Console.WriteLine(schiff1.BeschreibeMich());
            #endregion

            #region Modul07 - Generische Listen
            ////Die List-Klasse ist ein generischer Datentyp (ein Datentyp, welchem bei Initialisierung ein
            ////anderer Datentyp zugeordnet werden muss), mit dem gleichtypige Objekte in einer Liste dynamisch
            ////zusammengefasst werden können
            //List<Fahrzeug> fzListe = new List<Fahrzeug>();

            ////Mittels der Count-Eigenschaft der Liste kann die Anzahl der Elemente in der Liste aus
            //Console.WriteLine(fzListe.Count);

            ////Über die Add
            //fzListe.Add(new PKW("BMW", 230, 23000.0, 5));
            //fzListe.Add(new Flugzeug("Boing", 990, 3000000, 9980));

            //Console.WriteLine(fzListe.Count);

            //Console.WriteLine(fzListe[1].Name);

            //fzListe.RemoveAt(0);

            //Console.WriteLine(fzListe.Count);
            //Console.WriteLine(fzListe[0].Name);

            //PKW pkw1 = new PKW("BMW", 230, 23000.0, 5);
            //PKW pkw2 = new PKW("BMW", 230, 23000.0, 5);


            //Dictionary<Fahrzeug, string> fzDict = new Dictionary<Fahrzeug, string>();

            //fzDict.Add(pkw1, "Hallo");
            //fzDict.Add(pkw2, "Ciao");

            //if (!fzDict.ContainsKey(pkw1))
            //    fzDict.Add(pkw1, "Moin");

            //Console.WriteLine(fzDict[pkw2]);
            #endregion

            #region Lab07 - Zufällige Fahrzeuglisten
            ////Deklaration der benötigten Variablen und und Initialisierung mit Instanzen der benötigten Objekte
            //Random generator = new Random();
            //Queue<Fahrzeug> fzQueue = new Queue<Fahrzeug>();
            //Stack<Fahrzeug> fzStack = new Stack<Fahrzeug>();
            //Dictionary<Fahrzeug, Fahrzeug> fzDict = new Dictionary<Fahrzeug, Fahrzeug>();
            ////Deklaration und Initialisierung einer Variablen zur Bestimmung der Anzahl der Durchläufe 
            //int AnzahlFZs = 10000;

            ////Schleife zur zufälligen Befüllung von Queue und Stack
            //for (int i = 0; i < AnzahlFZs; i++)
            //{
            //    //Würfeln einer zufälligen Zahl im Switch
            //    switch (generator.Next(1, 4))
            //    {
            //        //Erzeugung von Objekten je nach zufälliger Zahl
            //        case 1:
            //            fzQueue.Enqueue(new Flugzeug($"Boing_Q{i}", 800, 3600000, 9999));
            //            fzStack.Push(new Flugzeug($"Boing_S{i}", 800, 3600000, 9999));
            //            break;
            //        case 2:
            //            fzQueue.Enqueue(new Schiff($"Titanic_Q{i}", 40, 3500000, Schiff.Treibstoffart.Dampf));
            //            fzStack.Push(new Schiff($"Titanic_S{i}", 40, 3500000, Schiff.Treibstoffart.Dampf));
            //            break;
            //        case 3:
            //            fzQueue.Enqueue(PKW.ErzeugeZufälligenPKW($"_Q{i}"));
            //            fzStack.Push(PKW.ErzeugeZufälligenPKW($"_S{i}"));
            //            break;
            //    }
            //}

            ////Schleife zur Prüfung auf das Interface und Befüllung des Dictionaries
            //for (int i = 0; i < AnzahlFZs; i++)
            //{
            //    //Prüfung, ob das Interface vorhanden ist (mittels Peek(), da die Objekte noch benötigt werden)...
            //    if (fzQueue.Peek() is IBeladbar)
            //    {
            //        //...wenn ja, dann Cast in das Interface und Ausführung der Belade()-Methode (mittels Peek())...
            //        ((IBeladbar)fzQueue.Peek()).Belade(fzStack.Peek());
            //        //...sowie Hinzufügen zum Dictionary (mittels Pop()/Dequeue(), um beim nächsten Durchlauf andere Objekte an den Spitzen zu haben)
            //        fzDict.Add(fzQueue.Dequeue(), fzStack.Pop());
            //    }
            //    else
            //    {
            //        //... wenn nein, dann Löschung der obersten Objekte (mittels Pop()/Dequeue())
            //        fzQueue.Dequeue();
            //        fzStack.Pop();
            //    }
            //}

            ////Programmpause
            //Console.ReadKey();
            //Console.WriteLine("\n----------LADELISTE----------");

            ////Schleife zur Ausgabe des Dictionaries
            //foreach (var fz in fzDict)
            //{
            //    Console.WriteLine($"'{fz.Key.Name}' hat '{fz.Value.Name}' geladen.");
            //} 
            #endregion

            #region Weitere Themen
            //Erstellung von Bsp-Objekten
            PKW pkw1 = new PKW("BMW", 230, 3000, 4);
            PKW pkw2 = new PKW("BMW", 230, 3000, 4);
            PKW pkw3 = new PKW("VW", 230, 3000, 4);

            //Benutzung der in der Fahrzeug-Klasse definierten Vergleichsoperatoren
            Console.WriteLine(pkw1 == pkw2);
            Console.WriteLine(pkw1 == pkw3);

            //Verwendung der unten stehenden Erweiterungsmethode der Random-Klasse
            Random generator = new Random();
            Console.WriteLine(generator.NextInclusive(1, 4));

            //Verwendung des in der Schiff-Klasse definierten IEnumerable
            Schiff schiff = new Schiff("ww", 2, 2, Schiff.Treibstoffart.Dampf);
            schiff.Ladungsliste.Add(new Schiff("ww", 2, 2, Schiff.Treibstoffart.Dampf));
            schiff.Ladungsliste.Add(new Schiff("ww", 2, 2, Schiff.Treibstoffart.Dampf));
            schiff.Ladungsliste.Add(new Schiff("ww", 2, 2, Schiff.Treibstoffart.Dampf));
            schiff.Ladungsliste.Add(new Schiff("ww", 2, 2, Schiff.Treibstoffart.Dampf));

            foreach (var item in schiff)
            {
                Console.WriteLine(item);
            } 
            #endregion

            //Programmpause
            Console.ReadKey();
        }

        //Methode aus Lab06
        public static void BeladeFahrzeuge(Fahrzeug fz1, Fahrzeug fz2)
        {
            //Prüfung, ob fz1 das Interface implementiert hat
            if (fz1 is IBeladbar)
                //Wenn ja, Cast in Interfaceobjekt und Ausführung der Belade()-Methode
                (fz1 as IBeladbar).Belade(fz2);
            //Wenn nein, Prüfung, ob fz2 das Interface implementiert hat
            else if (fz2 is IBeladbar)
                //Wenn ja, (alternativer) Cast in Interfaceobjekt und Ausführung der Belade()-Methode
                ((IBeladbar)fz2).Belade(fz1);
            //Wenn nein, Ausgabe einer Fehlermeldung
            else
                Console.WriteLine("Kein Fahrzeug kann auf das jeweils andere geladen werden.");
        }

        //Bsp-Methode Modul06 (Methode erwartet Objekt einer Klasse, die IBewegbar implementiert hat, als Übergabeparameter)
        //vgl. oben stehende Methode BeladeFahrzeuge()
        public static void RadAb(IBewegbar bewegbar)
        {
            bewegbar.Räderanzahl--;

            if (bewegbar is PKW)
            {
                PKW pkw1 = (PKW)bewegbar;

                pkw1.AnzahlTüren--;

                (bewegbar as PKW).AnzahlTüren--;
            }
        }


    }

    public static class Hilfsmethoden
    {
        //ERWEITERUNGSMETHODEN sind Funktionen, welche in einer beliebingen Klasse stehen, aber durch das THIS-Stichwort in der Parameter-
        ///übergabe einer bestimmten Klasse zugrordnet sind
        public static int NextInclusive(this Random generator, int untergrenze, int obergrenze)
        {
            return generator.Next(untergrenze, obergrenze + 1);
        }
    }


}
