using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructVSClass
{
    //vgl. Modul 4 -> Fahrzeug
    class ClassPerson
    {
        public string Name { get; set; }
        public int Alter { get; set; }

        public ClassPerson(string name, int alter)
        {
            this.Name = name;
            this.Alter = alter;
        }
    }

    //STRUCTS sind Klassenähnliche Konstrukte, welche nicht, wie Klassen, als Referenztypen behandelt werden, sondern ein Wertetyp sind. D.h
    //bei Übergabe eines Structs an eine Methode oder Variable wird eine Kopie dieses Objekts erstellt
    struct StructPerson
    {
        public string Name { get; set; }
        public int Alter { get; set; }

        public StructPerson(string name, int alter)
        {
            this.Name = name;
            this.Alter = alter;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Erstellung von Objekten
            StructPerson person1 = new StructPerson("Hugo", 45);
            ClassPerson person2 = new ClassPerson("Anna", 45);

            //Ausgabe
            Console.WriteLine(person1.Alter);
            Console.WriteLine(person2.Alter);

            //Funktionsaufruf
            Altern(person1);
            Altern(person2);

            //Erneute Ausgabe: Nur das Klassenobjekt (Referenztyp) hat sich verändert. Das Structobjekt (Wertetyp) hat sich nicht verändert,
            //da bei der Übergabe an die Funktion nur eine Kopie des Objekts übergeben wurde.
            Console.WriteLine(person1.Alter);
            Console.WriteLine(person2.Alter);

            //Übergabe des Wertetyps als Refernz mittels Ref-Stichwort
            Altern2(ref person1);
            Console.WriteLine(person1.Alter);

            Console.ReadKey();
        }

        static void Altern(ClassPerson person)
        {
            person.Alter++;
        }

        static void Altern(StructPerson person)
        {
            person.Alter++;
        }

        //Mittels des REF-Stichworts können Wertetypen als Referenz an Methoden übergeben werden. D.h. die übergebene Speicherstelle selbst 
        ///wird manipuliert und nicht, wie normalerweise bei Wertetypen, eine Kopie des Werts.
        static void Altern2(ref StructPerson person)
        {
            person.Alter++;
        }

    }

}
