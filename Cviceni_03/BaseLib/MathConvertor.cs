using System;
using System.Collections.Generic;
using System.Text;

namespace fei
{
    namespace BaseLib
    {
        public class MathConvertor
        {
            /// <summary>
            /// General converting of any supported base
            /// </summary>
            /// <param name="input">String value</param>
            /// <param name="fromBase">From base</param>
            /// <param name="toBase">To base</param>
            /// <returns>String value of converted number</returns>
            public static string Calculate(string input, int fromBase, int toBase)
            {
                return Convert.ToString(Convert.ToInt32(input, fromBase), toBase);
            }

            /// <summary>
            /// Convert decimal to binary
            /// </summary>
            /// <param name="input">String input</param>
            /// <returns>Converted value</returns>
            public static string DecimalToBinary(string input)
            {
                return Calculate(input, 10, 2);
            }
            /// <summary>
            /// Convert Binary to Decimal
            /// </summary>
            /// <param name="input">String input</param>
            /// <returns>Converted value</returns>
            public static string BinaryToDecimal(string input)
            {
                return Calculate(input, 2, 10);
            }

            /// <summary>
            /// Dictionary of Roman numbers
            /// </summary>
            private static Dictionary<char, int> RomanMap = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            /// <summary>
            /// Decimal to Roman, limit 3999
            /// </summary>
            /// <param name="number">Input number</param>
            /// <returns>Roman number</returns>
            public static string DecimalToRoman(int number)
            {
                if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
                if (number < 1) return string.Empty;
                if (number >= 1000) return "M" + DecimalToRoman(number - 1000);
                if (number >= 900) return "CM" + DecimalToRoman(number - 900);
                if (number >= 500) return "D" + DecimalToRoman(number - 500);
                if (number >= 400) return "CD" + DecimalToRoman(number - 400);
                if (number >= 100) return "C" + DecimalToRoman(number - 100);
                if (number >= 90) return "XC" + DecimalToRoman(number - 90);
                if (number >= 50) return "L" + DecimalToRoman(number - 50);
                if (number >= 40) return "XL" + DecimalToRoman(number - 40);
                if (number >= 10) return "X" + DecimalToRoman(number - 10);
                if (number >= 9) return "IX" + DecimalToRoman(number - 9);
                if (number >= 5) return "V" + DecimalToRoman(number - 5);
                if (number >= 4) return "IV" + DecimalToRoman(number - 4);
                if (number >= 1) return "I" + DecimalToRoman(number - 1);
                throw new ArgumentOutOfRangeException("something bad happened");
            }

            /// <summary>
            /// Roman to Decimal convertion
            /// </summary>
            /// <param name="roman">String of roman number</param>
            /// <returns>Integr of value of Roman number</returns>
            public static int RomanToDecimal(string roman)
            {
                int number = 0;
                char previousChar = roman[0];
                foreach (char currentChar in roman)
                {
                    number += RomanMap[currentChar];
                    if (RomanMap[previousChar] < RomanMap[currentChar])
                    {
                        number -= RomanMap[previousChar] * 2;
                    }
                    previousChar = currentChar;
                }
                return number;
            }
        }
    }
}
