using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //Ein DELEGATE ist eine Variable, in welcher man Funktionen mit einem gleichen Methodenkopf speichern kann. Eigene Delegate-Typen müssen
    ///vorher definiert werden.
    public delegate int MeinDelegate(int zahl, int zahl2);

    class Program
    {
        static void Main(string[] args)
        {
            //Zuweisung der Addiere()-Methode zur einer Variablen vom Typ MyDelegate
            MeinDelegate delegateVariable = new MeinDelegate(Addiere);
            //Ausführung der Delegate-Variablen
            int erg = delegateVariable(12, 45);
            Console.WriteLine(erg);

            //Neuzuweisung der Variablen mittels Kurzschreibweise
            delegateVariable = Subtrahiere;

            erg = delegateVariable(12, 45);
            Console.WriteLine(erg);

            //Zuweisung einer zweiten Methode zur Delegate-Variablen. Die Ausführung erfolgt in der Reihenfolge der Zuweisung. Nur der Rückgabewert
            ///der zuletzt ausgeführten Methode wird an den Aufrufer zurückgegeben.
            delegateVariable += Addiere;

            erg = delegateVariable(12, 45);
            Console.WriteLine(erg);

            //Erstellen einer Liste der in der Variablen gespeicherten Methode
            var delegateMethoden = delegateVariable.GetInvocationList().ToList();
            //Ausgabe dieser Liste
            foreach (var item in delegateMethoden)
            {
                Console.WriteLine(item.Method);
            }

            delegateVariable -= Subtrahiere;

            //FUNC<> / ACTION<> /PREDICATE<> sind die von C# vordefinierten Delegate-Typen
            Func<int, int, int> myFunc = Addiere;
            myFunc += Subtrahiere;

            erg = myFunc(12, 23);
            Console.WriteLine(erg);

            FühreAus(Addiere);


            List<string> stringListe = new List<string>();
            stringListe.Add("Hallo");
            stringListe.Add("Ciao");
            stringListe.Add("Moin");
            stringListe.Add("Guten Morgen");

            //ANONYME METHODEN sind Methoden, welche nicht mit Kopf und Körper geschrieben stehen, sondern nur innerhalb von Delegate-Variablen
            ///existieren

            //Übergabe einer Methode an eine andere Methode
            string ergebnis = stringListe.Find(SucheWortMitM);
            Console.WriteLine(ergebnis);

            //Übergabe der Methode als anonyme Methode
            ergebnis = stringListe.Find(delegate (string input)
            {
                return input[0].Equals('M');
            });

            //Übergabe der anonymen Methode in LAMBDA-Schreibweise
            ergebnis = stringListe.Find((string input) => { return input[0].Equals('M'); });

            //Übergabe der anonymen Methode in vollständig gekürzter LAMBDA-Schreibweise
            ergebnis = stringListe.Find(input => input[0].Equals('M'));

            Console.ReadKey();
        }

        static bool SucheWortMitM(string input)
        {
            return input[0].Equals('M') ? true : false;
        }

        //Funktion mit Delegate-Übergabeparameter
        public static void FühreAus(Func<int, int, int> funky)
        {
            funky(12, 23);
        }

        //Funktion mit Delegate-Rückgabewert
        public static Func<int, int, int> BaueFunc()
        {
            return Addiere;
        }

        //Bsp-Methoden für obiges Bsp
        public static int Addiere(int a, int b) { Console.WriteLine("Addiere:" + (a + b)); return a + b; }

        public static int Subtrahiere(int a, int b) { Console.WriteLine("Subtrahiere:" + (a - b)); return a - b; }

    }
}
