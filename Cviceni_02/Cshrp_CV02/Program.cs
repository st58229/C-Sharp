using System;
using fei.BaseLib;

namespace Cshrp_CV02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Reading.ReadChar();
            Console.WriteLine();
            Reading.ReadDouble();
            Console.WriteLine();
            Reading.ReadInt();
            Console.WriteLine();
            Reading.ReadString();*/

            /*Field pole = new Field(10);
            pole.add(15);
            pole.add(45);
            pole.add(45);
            pole.add(45);
            pole.add(45);
            pole.writeToConsole();
            pole.order(Field.Order.ACS);
            pole.order(Field.Order.DES);
            pole.min();
            pole.max();
            pole.firstIndexOfNumber(45);
            pole.lastIndexOfNumber(45);*/

            Field pole = new Field(5);
            pole.menuUI();
        }
    }
}
