using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionen
{
    class Program
    {
        //Jede Funktion/Methode besteht aus einem Kopf und einem Körper
        ///Der Kopf (Signatur) besteht aus den MODIFIERN (public static), dem RÜCKGABEWERT (int), dem NAMEN (Addiere) sowie den ÜBERGABEPARAMETERN
        ///Wird einem Parameter mittels =-Zeichen ein Defaultwert zugewiesen wird dieser Parameter OPTIONAL und muss bei Aufruf nicht zwangs-
        ///läufig mitgegeben werden. OPTIONALE Parameter müssen am Ende der Parameter stehen.
        static int addiere(int a, int b, int c = 0, int d = 0)
        {
            //Im Körper wird der Programmablauf, welcher während der Ausführung der Methode durchgeführt wird, definiert.

            //Der RETURN-Befehl weist der Methode einen Wert als Rückgabewert zu, der an den Aufrufe zurückzugeben wird. Dieser muss vom Typ
            //des in der Signatur angegebenen Rückgabetyps sein. Dabei wird die Methode gleichzeitig beendet.
            //In Methoden mit einem anderen Rückgabetyp als void ist die Verwendung von return in allen Programmpfaden obligatorisch.
            return a + b + c + d;
        }

        //Funktionen, welche keinen Wert an ihren Ausrufer zurückgeben sollen, sondern nur eine Bündelung
        //von Anweisungen sind, erhalten als Übergabeparameter den (Fake-)Typ VOID
        static void addiereUndGibAus(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        //Funktion, welche den gleichen Bezeichner haben, nennt man ÜBERLADENE Funktionen. Diese müssen sich in Anzahl und/oder Art der 
        ///Übergabeparameter unterscheiden, damit der Aufruf eindeutig ist.
        static void addiereUndGibAus(int a, int b, int c)
        {
            Console.WriteLine(a + b);
        }

        //Das OUT-Stichwort ermöglich einer Methode mehr als einen Rückgabewert zu haben. Dabei kann die Variable direkt in der Funktions-
        ///übergabe deklariert werden.
        static int addiereUndSubtrahiere(int a, int b, out int differenz)
        {
            differenz = a - b;
            return a + b;
        }

        static void Main(string[] args)
        {
            //Funktionsaufruf mit zwei Übergabeparametern und Speichern des Rückgabewerts
            int summe = addiere(5, 2);
            Console.WriteLine(summe);

            //Aufruf der void-Funktion
            addiereUndGibAus(2, 3);

            //Aufruf der out-Funktion. Die Variable Diff wird in der Parameterübergabe
            //deklariert, innerhalb der Funktion initialisiert und beinhaltet nach dem
            //Funktionsaufruf die Differenz der beiden Zahlen.
            summe = addiereUndSubtrahiere(1, 2, out int Diff);

            Console.WriteLine("Summe: " + summe);
            Console.WriteLine("Differenz: " + Diff);


            //TryParse() als (sinnvolles) Bsp für Out-Verwendung
            if (int.TryParse("kjhkjg", out int ausgabe))
            {
                int erg = ausgabe + 45;
            }

            Console.ReadKey();
        }

    }
}
