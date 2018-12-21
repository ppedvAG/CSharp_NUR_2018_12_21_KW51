using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fahrzeugpark;

namespace Wdh_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> actionVar = Funktion1;

            actionVar += Funktion1;

            actionVar(45);

            actionVar -= Funktion1;

            actionVar(85);


            Func<int, int, string> funcVar = Funktion2;
            funcVar += Funktion2;


            Console.WriteLine(funcVar(12, 123));


            List<int> intList = new List<int>();

            for (int i = 0; i < 50; i++)
            {
                intList.Add(i * 3);
            }

            List<int>ergebnisse = intList.FindAll(delegate (int a)
            {
                return a % 2 == 0;
            });

            foreach (var item in ergebnisse)
            {
                Console.WriteLine(item);
            }

            List<Fahrzeug> fzList = new List<Fahrzeug>();

            for (int i = 0; i < 10; i++)
            {
                fzList.Add(PKW.ErzeugeZufälligenPKW());
            }

            Fahrzeug ErgFz = fzList.Find(fz => fz.Name.Equals("BMW"));


            Console.WriteLine(ErgFz.BeschreibeMich());

            Console.ReadKey();


        }


        static void Funktion1(int a)
        {
            Console.WriteLine(2*a);
        }

        static string Funktion2(int a, int b)
        {
            Console.WriteLine("Funktion2");
            return (a + b).ToString();
        }
    }
}
