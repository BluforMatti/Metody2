using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody2
{/*
  * ověření, zda je dané číslo celé
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo");
            Console.WriteLine(JeCeleCislo(double.Parse(Console.ReadLine())));
        }
        public static bool JeCeleCislo(double x)
        {
            return x == (int)x;
        }
    }
}
