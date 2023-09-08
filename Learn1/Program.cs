using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Kostyukovich
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = -100;
            sbyte b = Math.Abs(a);
            Console.WriteLine($"abs a = {b}");

            sbyte val1 = 50;
            sbyte val2 = -30;
            sbyte c = Math.Max(val1, val2);
            Console.WriteLine($"Max c = {c}");

            double val3 = 144;
            double d = Math.Sqrt(val3);
            Console.WriteLine($"sqrt d = {d}");

            double val4 = 1.23;
            double e = Math.Truncate(val4);
            Console.WriteLine($"Truncate e = {e}");

            double pi = Math.Sin(3.14);
            double pi2 = Math.PI;
            bool EQ = Math.Equals(pi, pi2);
            Console.WriteLine($"pi = {pi}");
            Console.WriteLine($"pi2 = {pi2}");
            Console.WriteLine($"Equals = {EQ}");
        }
    }
}
