using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody2
{
    /*
     * výpočet funkce sinus úhlu vyjádřeného ve stupních
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej ůhel ve stupních");
            Console.WriteLine(Sinus(double.Parse(Console.ReadLine())));
        }

        public static double Sinus(double x)
        {
            x = x * (Math.PI / 180); // převedení na radiány
            double rada = 0;
            double clen = x;
            int i = 1;

            while (Math.Abs(clen) > 1e-15)
            {
                rada += clen;
                i++;
                clen *= -1 * x * x / ((2 * i - 2) * (2 * i - 1));
            }
            return rada;
        }
    }
}
