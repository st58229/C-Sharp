using System;

namespace fei
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Students list1 = new Students();
            list1.menuUI();*/


            bool vysledek = BaseLib.ExtraMath.SolveQuadratic(10, 10, 10, out double x1, out double x2);
            Console.WriteLine($"{vysledek} {x1} {x2}");

            Random random = new Random();
            Console.WriteLine(BaseLib.ExtraMath.RandomDouble(random, 0, 100));

            string temp = BaseLib.MathConvertor.DecimalToBinary("8");
            Console.WriteLine(temp);
            Console.WriteLine(BaseLib.MathConvertor.BinaryToDecimal("temp"));

            temp = BaseLib.MathConvertor.DecimalToRoman(2523);
            Console.WriteLine(temp);
            Console.WriteLine(BaseLib.MathConvertor.RomanToDecimal(temp));
        }
    }
}
