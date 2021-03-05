using System;
using System.Collections.Generic;
using System.Text;

namespace fei
{
    class Students
    {
        public List<Student> List { get; set; } = new List<Student>();

        public void add()
        {
            Console.WriteLine("Zapište jméno studenta:");
            string name = BaseLib.Reading.ReadString();

            Console.WriteLine("Zapište id studenta:");
            int id = BaseLib.Reading.ReadInt();

            Console.WriteLine("Zapište fakultu studenta:");
            Student.Fac fac = Student.FacultyFromString(BaseLib.Reading.ReadString());
            
            List.Add(new Student(name, id, fac));
        }

        public void writeToConsole()
        {
            List.ForEach(i => Console.WriteLine("{0}\n", i));
        }

        public void menuUI()
        {
            char choice = '-';

            do
            {
                switch (choice)
                {
                    case '1':
                        add();
                        choice = '-';
                        break;
                    case '2':
                        writeToConsole();
                        choice = '-';
                        break;
                    case '3':
                        List.Sort();
                        writeToConsole();
                        choice = '-';
                        break;
                    case '4':
                        List.Sort(delegate (Student a, Student b) 
                        {
                            if (a.Name == null && b.Name == null) return 0;
                            else if (a.Name == null) return -1;
                            else if (b.Name == null) return 1;
                            else return a.Name.CompareTo(b.Name);
                        });
                        writeToConsole();
                        choice = '-';
                        break;
                    case '5':
                        List.Sort(delegate (Student a, Student b)
                        {
                            return a.Faculty.CompareTo(b.Faculty);
                        });
                        writeToConsole();
                        choice = '-';
                        break;
                    case '0':
                        return;
                    default:
                        Console.WriteLine("1 - Přidej");
                        Console.WriteLine("2 - Vypis");
                        Console.WriteLine("3 - Serad podle cisla");
                        Console.WriteLine("4 - Serad podle jmena");
                        Console.WriteLine("5 - Serad podle fakulty");
                        Console.WriteLine("0 - Konec");

                        Console.WriteLine("Zapište volbu:");
                        choice = Console.ReadKey().KeyChar;
                        break;
                }
            }
            while (true);

        }

    }
}
