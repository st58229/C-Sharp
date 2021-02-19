using System;

namespace Cshrp_CV01
{
    class Program
    {
        static void Main(string[] args)
        {
            //A();
            //B();
            C();
            //Console.WriteLine(C1());
            //Console.WriteLine(C2());
            //D();
        }

        static void A()
        {
            Console.WriteLine("Josef Novák\nJindřišská 16\n111 50, Praha 1");            
        }

        static void B()
        {
            for (var i = 'A'; i <= 'Z'; i++) 
            {
                Console.WriteLine(i);
            }            
        }

        static void C()
        {
            string input;
            Console.WriteLine("Zadejte rodné číslo:");
            input = Console.ReadLine();

            string y = input.Substring(0, 2);
            string d = input.Substring(2, 4);      
            string m = (Convert.ToInt32(input.Substring(2, 2)) > 50 ? Convert.ToInt32(input.Substring(2, 2)) - 50 : Convert.ToInt32(input.Substring(2, 2))).ToString();
            bool w = Convert.ToInt32(input.Substring(2, 2)) > 50;

            if (w) Console.WriteLine("Jedná se o rodné číslo ženy.");
            else Console.WriteLine("Jedná se o rodné číslo muže."); 
        }

        static string C1()
        {
            string input;
            Console.WriteLine("Zadejte rodné číslo:");
            input = Console.ReadLine();

            bool w = Convert.ToInt32(input.Substring(2, 2)) > 50;

            if (w) Console.WriteLine("Jedná se o rodné číslo ženy.");
            else Console.WriteLine("Jedná se o rodné číslo muže.");

            return input;
        }

        static ulong C2()
        {
            string input;
            Console.WriteLine("Zadejte rodné číslo:");
            input = Console.ReadLine();

            bool w = Convert.ToInt32(input.Substring(2, 2)) > 50;

            if (w) Console.WriteLine("Jedná se o rodné číslo ženy.");
            else Console.WriteLine("Jedná se o rodné číslo muže.");

            return Convert.ToUInt64(input);
        }

        static void D()
        {
            bool game = true;
            while (game)
            {
                Random rnd = new Random();
                int nmb = rnd.Next(0, 101);
                int inp = -1;

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Tipněte si číslo, na které myslím. Je mezi 0 a 100.");
                    inp = Convert.ToInt32(Console.ReadLine());
                    if (inp == nmb)
                    {
                        Console.WriteLine("Gratuluji, uhodl jste číslo na {0} pokus!", i);
                        Console.WriteLine("Chcete dále pokračovat? ano/ne");
                        if (Console.ReadLine().Equals("ano")) break;
                        else
                        {
                            game = false;
                            break;
                        }
                    }
                    else if (inp > nmb) Console.WriteLine("Číslo, na které myslím je MENŠÍ, než to, které hádáš.");
                    else if (inp < nmb) Console.WriteLine("Číslo, na které myslím je VĚTŠÍ, než to, které hádáš.");
                    else Console.WriteLine("Nechápu, co děláš, ale nech toho a hraj!");
                }

            }          
        }
    }
}
