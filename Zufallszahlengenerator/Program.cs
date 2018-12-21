﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zufallszahlengenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schleife zum Wdh des Programms
            do
            {
                //Deklaration und Initialisierung eines Random-Objekts mittels Konstruktor-Aufruf (vgl. Modul 04)
                Random generator = new Random();
                //Deklaration und (Alibi-)Initialisierung der in der Schleifenbedingung benötigten Variablen
                int benutzerZahl = 0;
                //Aufruf der Würfel-Funktion des Random-Objekts (beachte: 1. Grenze inklusiv / 2. Grenze exklusiv)
                int zufallsZahl = generator.Next(1, 6);

                //Schleife für erneuten Versuch (bei falsch geratener Zahl)
                do
                {
                    //Abfrage des Tipps des Benutzers
                    Console.Write("Bitte gib eine Zahl zwischen 1 und 5 ein: ");
                    benutzerZahl = int.Parse(Console.ReadLine());

                    //Vergleich Tipp <> Zufallszahl mittels If
                    if (benutzerZahl < zufallsZahl)
                    {
                        Console.WriteLine("Deine Zahl ist zu klein!");
                    }
                    else if (benutzerZahl > zufallsZahl)
                    {
                        Console.WriteLine("Deine Zahl ist zu groß!");
                    }
                    else
                    {
                        Console.WriteLine("Deine Zahl ist richtig!");
                    }
                    //Bedingung für neuen Versuch
                } while (benutzerZahl != zufallsZahl);

                Console.WriteLine("Wiederholen? (Y/N)");
                //Bedingung für Wiederholung (Benutzer muss Taste 'Y' drücken)
            } while (Console.ReadKey().Key == ConsoleKey.Y);
        }
    }
}
