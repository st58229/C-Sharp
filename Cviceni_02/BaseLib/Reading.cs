using System;

namespace fei
{
    namespace BaseLib
    {
        /// <summary>
        /// Class for reading/writing operations
        /// </summary>
        public class Reading
        {
            /// <summary>
            /// Reading and writing Int from/to console
            /// </summary>            
            /// <return>
            /// Value of user input (int)
            /// </return>
            public static int ReadInt()
            {
                Console.Write("Zapiště libovolné číslo formátu int: ");                
                int inp; 
                int.TryParse(Console.ReadLine(), out inp);
                //Console.WriteLine("Zadali jste číslo: {0}", inp);
                return inp;
            }
            /// <summary>
            /// Reading and writing Double from/to console
            /// </summary>
            /// <return>
            /// Value of user input (double)
            /// </return>
            public static double ReadDouble()
            {
                Console.Write("Zapiště libovolné číslo formátu double: ");
                double inp = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Zadali jste číslo: {0}", inp);
                return inp;
            }
            /// <summary>
            /// Reading and writing Char from/to console
            /// </summary>
            /// <return>
            /// Value of user input (char)
            /// </return>
            public static char ReadChar()
            {
                Console.Write("Zapiště libovolný jeden char: ");
                char inp = Console.ReadKey().KeyChar;
                //Console.WriteLine();
                //Console.WriteLine("Zadali jste char: '{0}'", inp);
                return inp;
            }
            /// <summary>
            /// Reading and writing String from/to console
            /// </summary>        
            /// <return>
            /// Value of user input (string)
            /// </return>
            public static string ReadString()
            {
                Console.Write("Zapiště libovolný text: ");
                string inp = Console.ReadLine();
                //Console.WriteLine("Zadali jste číslo: \"{0}\"", inp);
                return inp;
            }
        }
    }
}
