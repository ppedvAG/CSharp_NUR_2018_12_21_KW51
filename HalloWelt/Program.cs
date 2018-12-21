//Mittels der USING-Anweisungen kann ein vereinfachter Zugriff auf Programm-Externe Klassen ermöglicht werden. Es muss nun nicht mehr der
///vollständige Pfad angegeben werden, sondern es reicht der Klassenbezeichner
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NAMESPACE: Die Umgebung unseres aktuellen Programms: Alles innerhalb des Namespaces gehört zu dem Programm
namespace HalloWelt
{
    //Die PROGRAM-Klasse beinhaltet den Einstiegspunkt des Programms und muss in jedem C#-Programm vorhanden sein
    class Program
    {
        //Die MAIN()-Methode ist der Einstiegspunkt jedes C#-Programms: Hier beginnt das Programm IMMER
        static void Main(string[] args)
        {   
            //Ausgabe eines String-Literals (fester String-Wert) in der Konsole
            Console.WriteLine("Hallo Welt");

            //Deklaration einer Integer-Variable 
            int Alter;
            //Initialisierung der Integer-Variablen
            Alter = 29;
            //Gleichzeitige Deklaration und Initialisierung einer String-Variablen
            string Stadt = "Nürnberg";

            ///Einfügen dynamischer Inhalte in Strings
            //'traditionell'
            Console.WriteLine("Ich bin " + Alter + " und wohne in " + Stadt + ".");
            //Index
            Console.WriteLine("Ich bin {0} und wohne in {1}.", Alter, Stadt);
            //$-Operator
            Console.WriteLine($"Ich bin {Alter} und wohne in {Stadt}.");

            //String-Formatierung mittels Escape-Sequenzen
            Console.WriteLine("Dies ist ein Zeilenumbruch \nund dies ein \tTabulator");

            //String-Formatierung mittels VerbaTim-String (einleitung mittels @/Escape-Sequenzen sind nicht möglich, 
            ///dynamische Inhalte mittels $ schon)
            Console.WriteLine($@"Dies ist ein Zeilenumbruch
und dies ein    Tabulator. Dynamischer Inhalt:{Alter}");


            //Eingabe eines Strings durch den Benutzer und Abspeichern in einer String-Variablen
            string input = Console.ReadLine();
            Console.WriteLine("Du hast folgendes eingegeben: " + input);

            //Umwandlung einer Doublezahl in eine Integerzahl per Cast (erlaubte, expliziete Umwandlung)
            double kommazahl = 45.99;
            int ganzeZahl = (int)kommazahl;
            Console.WriteLine(ganzeZahl);

            //Die Funktion READKEY dient eigentlich der Erkennung einer gedrückten Taste, wird hier aber zur 
            //Pausierung des Programms, bis der Benutzer eine Taste drückt
            Console.ReadKey();

        }
    }
}
