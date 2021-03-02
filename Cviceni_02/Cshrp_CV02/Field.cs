using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cshrp_CV02
{
    class Field
    {
        private int[] numbers;

        public enum Order { ACS, DES };        

        public Field(int size)
        {
            numbers = new int[size];
        }

        public void add(int number)
        {
            numbers.Append(number);
        }

        public void writeToConsole()
        {
            Console.Write('[');
            for(int i = 0; i < numbers.Length; i++)
            {
                if (i < numbers.Length - 1) Console.Write(numbers[i] + ", ");
                else Console.Write(numbers[i]);                    
            }
            Console.WriteLine(']');
        }

        public void order(Order order)
        {
            Array.Sort(numbers);

            if (order == Order.ACS) Array.Sort(numbers);
            else if (order == Order.DES)
            {
                Array.Sort(numbers);
                Array.Reverse(numbers);
            }
            else throw new Exception();

            Console.WriteLine("Pole seřazeno!");                    
        }

        public void min()
        {
           Console.WriteLine("Nejmenší číslo z pole bylo nalezeno a je to {0}.",numbers.Min());
        }

        public void max()
        {
            Console.WriteLine("Největší číslo z pole bylo nalezeno a je to {0}.", numbers.Max());
        }

        public void firstIndexOfNumber(int find)
        {
            Console.WriteLine("První výskyt čísla {0} byl nalezen na indexu {1}.", find, Array.IndexOf(numbers, find));
        }

        public void lastIndexOfNumber(int find)
        {
            Console.WriteLine("První výskyt čísla {0} byl nalezen na indexu {1}.", find, Array.LastIndexOf(numbers, find));
        }

        public void menuUI()
        {
            char choice = '-';

            do
            {
                switch (choice)
                {
                    case '1':
                        add(fei.BaseLib.Reading.ReadInt());
                        choice = '-';
                        break;
                    case '2':
                        writeToConsole();
                        choice = '-';
                        break;
                    case '3':
                        order(Order.ACS);
                        writeToConsole();
                        choice = '-';
                        break;
                    case '4':
                        min();
                        choice = '-';
                        break;
                    case '5':
                        max();
                        choice = '-';
                        break;
                    case '6':
                        firstIndexOfNumber(fei.BaseLib.Reading.ReadInt());
                        choice = '-';
                        break;
                    case '7':
                        lastIndexOfNumber(fei.BaseLib.Reading.ReadInt());
                        choice = '-';
                        break;                    
                    case '0':
                        return;
                    default:
                        Console.WriteLine("1 - Přidej");
                        Console.WriteLine("2 - Vypis");
                        Console.WriteLine("3 - Serad");
                        Console.WriteLine("4 - min");
                        Console.WriteLine("5 - max");
                        Console.WriteLine("5 - first index");
                        Console.WriteLine("6 - last index");

                        Console.WriteLine("Zapište volbu:");
                        choice = Console.ReadKey().KeyChar;
                        break;                     
                }
            }
            while (true);
            
        }
      
    }
}
