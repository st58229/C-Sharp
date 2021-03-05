using System;
using System.Collections.Generic;
using System.Text;

namespace fei
{
    namespace BaseLib
    {
        public class ExtraMath
        {
            /// <summary>
            /// Function for solving Quadratic functions
            /// </summary>
            /// <param name="a">Input a</param>
            /// <param name="b">Input b</param>
            /// <param name="c">Input c</param>
            /// <param name="x1">Output x1</param>
            /// <param name="x2">Output x2</param>
            /// <returns>Value if result is in real numbers</returns>
            public static bool SolveQuadratic(double a, double b, double c, out double x1, out double x2)
            {
                double sqrtpart = b * b - 4 * a * c;

                if (sqrtpart > 0)
                {
                    x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                    x2 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
                    return true;
                }
                else if (sqrtpart < 0)
                {
                    sqrtpart = -sqrtpart;
                    x1 = -b / (2 * a);
                    x2 = System.Math.Sqrt(sqrtpart) / (2 * a);
                    return false;
                }
                else
                {
                    x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                    x2 = double.NaN;
                    return true;
                }
            }

            /// <summary>
            /// Give random double from range
            /// </summary>
            /// <param name="random">Instance of Random class</param>
            /// <param name="min">Minimal limit</param>
            /// <param name="max">Maximal limit</param>
            /// <returns>Number in specified range</returns>
            public static double RandomDouble(Random random, double min, double max)
            {
                return random.NextDouble() * (max - min) + min;
            }


        }
    }
}
