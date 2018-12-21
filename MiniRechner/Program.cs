using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRechner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration der Variablen
            int intZahl;
            double doubleZahl;

            //Initialisierung der Variablen über Benutzereingabe
            Console.Write("Bitte gib eine ganze Zahl ein: ");
            intZahl = int.Parse(Console.ReadLine());
            Console.Write("Bitte gib eine Kommazahl ein: ");
            doubleZahl = double.Parse(Console.ReadLine());

            //Berechnung und Ausgabe der Summen:
            Console.WriteLine($"\nSumme als Integer: {(int)(intZahl + doubleZahl)}");
            Console.WriteLine($"Summe als Double: {intZahl + doubleZahl}\n");

            //Berechnung und Ausgabe der Division:
            double max = Math.Max(intZahl, doubleZahl);
            double min = Math.Min(intZahl, doubleZahl);
            double erg = max / min;
            Console.WriteLine($"{max} / {min} = {erg}");
            //Alternative:
            Console.WriteLine($"{Math.Max(intZahl, doubleZahl)} / {Math.Min(intZahl, doubleZahl)} = {Math.Max(intZahl, doubleZahl) / Math.Min(intZahl, doubleZahl)}");

            //Programmpause
            Console.ReadKey();
        }
    }
}
