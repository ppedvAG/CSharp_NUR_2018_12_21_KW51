using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeratoren
{
    //ENUMERATOREN sind spezialisierte selbst-definierte Datentypen mit festgelegten möglichen Zuständen.
    ///Dabei ist jeder Zustand an einen Integer-Wert gekoppelt, wodurch eine explizite Umwandlung (Cast) möglich ist.
    enum Wochentag { Montag = 1, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag}

    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration und Initialisierung einer Variablen vom Enumerator-Typ
            Wochentag heutigerTag = Wochentag.Dienstag;
            heutigerTag = (Wochentag)5;

            //Cast: Int -> Wochentag
            Console.WriteLine((Wochentag)5);

            Console.WriteLine("Welchen Tag haben wir heute?");
            
            //For-Schleife über die möglichen Zustande des Enumerators
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine($"{i}: {(Wochentag)i}");
            }

            //Speichern einer Benutzereingabe (Int) als Enumerator
            heutigerTag = (Wochentag)int.Parse(Console.ReadLine());

            //SWITCHs sind eine verkürzte Schreibweise für IF-ELSE-Blöcke. Mögliche Zustände der übergebenen Variablen werden 
            //in den CASES definiert
            switch (heutigerTag)
            {
                case Wochentag.Montag:
                    Console.WriteLine("Schönen Wochenstart");
                    //Jeder speziell definierte CASE muss mit einer BREAK-Anweisung beendet werden
                    break;
                //Wenn in einem CASE keine Anweisungen geschrieben stehen kann auf den BREAK-Befehl verzichtet werden. In diesem Fall
                //springt das Programm in diesem CASE zum Nachfolgenden
                case Wochentag.Dienstag:
                case Wochentag.Mittwoch:
                case Wochentag.Donnerstag:
                    Console.WriteLine("Schöne Woche");
                    break;
                case Wochentag.Freitag:
                case Wochentag.Samstag:
                case Wochentag.Sonntag:
                    Console.WriteLine("Schönes Wochenende");
                    break;
                //Wenn die übergebene Variable keinen der vordefinierten Zustände erreicht, wird der DEFAULT-Fall ausgeführt
                default:
                    Console.WriteLine("Irgendwas ist da falsch gelaufen!");
                    break;
            }

            //Programmpause
            Console.ReadKey();
        }
    }
}
