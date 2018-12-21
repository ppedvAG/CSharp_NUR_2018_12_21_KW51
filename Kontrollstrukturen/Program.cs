using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration und Initialisierung von Beispiel-Variablen
            bool a = true;
            bool b = false;

            //IF-ELSEIF-ELSE-Block
            ///Das Programm wird den ersten Block ausführen, bei welchem er auf eine wahre Bedingung trifft und dann am Ende des Blocks mit
            ///dem Code weiter machen
            if (a)
                Console.WriteLine("A ist wahr");
            else if (b)
            {
                //Es kann beliebig viele ELSE-IF-Blöcke geben
                Console.WriteLine("B ist wahr");
            }
            else
            {
                //Wenn keine der Bedingungen wahr ist, wird der (optionale) ELSE-Block ausgeführt
                Console.WriteLine("A und B sind unwahr");
            }

            //WHILE-Schleife
            ///Die WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Ist die Bedingung von vornherein unwahr, dann wird die Schleife
            ///übersprungen
            while (a)
            {
                Console.WriteLine("While-Schleife");
                //Mit der BREAK-Anweisung wird die Schleife verlassen und der Code wird fortgesetzt.
                break;
            }

            //DO-WHILE-Schleife
            ///Auch die DO-WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Allerdings wird die Bedingung erst am Schleifen_
            ///ende geprüft, weshalb die Schleife mindestens einmal durchläuft.
            do
            {
                Console.WriteLine("Do-While-Schleife");
                //Der CONTINUE-Befehl beendet den aktuellen Schleifendurchlauf und lässt erneut die Bedingung prüfen. Ist die Bedingung wahr
                ///beginnt ein neuer Durchlauf
                continue;
                Console.WriteLine("Wird niemals ausgeführt");
            } while (b);

            //FOR-Schleife
            ///Der FOR-Schleife wird ein Laufindex (i) sowie eine Bedingung und eine Anweisung übergeben. Am Ende jedes Durchlaufes wird die
            ///Anweisung ausgeführt. Wenn die Bedingung nicht (mehr) wahr ist, wird kein (weiterer) Schleifendurchlauf begonnen.
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Durchlauf Nr. " + i);
            }

            //ARRAYS
            ///Arrays sind Collections, welche mehrere Variablen eines Datentyps speichern können. Die Größe des Arrays muss bei der
            ///Initialisierung entweder durch eine Zahl oder durch eine bestimmte Anzahl von spezifischen Elementen definiert werden.
            int[] zahlenArray_2 = new int[20];
            int[] zahlenArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Der Zurgiff auf einzelne Array-Positionen erfolgt durch einen Nullbasierten Index
            Console.WriteLine(zahlenArray[5]);
            zahlenArray[5] = 50;
            Console.WriteLine(zahlenArray[5]);

            //Iteration über ein Array mittels For-Schleife
            for (int i = 0; i < zahlenArray.Length; i++)
            {
                Console.WriteLine(zahlenArray[i]);
            }

            //FOREACH-Schleifen können über Collections laufen und sprechen dabei jedes Element genau einmal an
            foreach (var zahl in zahlenArray)
            {
                Console.WriteLine(zahl);
            }

            //Mehrdimensionales Array
            int[,] zweiDimArray = new int[3, 5];

            zweiDimArray[0, 0] = 70;
            zweiDimArray[0, 1] = 12;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    zweiDimArray[i, j] = i + j;
                    Console.WriteLine(zweiDimArray[i, j]);
                }
            }

            //Programmpause
            Console.ReadKey();
        }
    }
}
