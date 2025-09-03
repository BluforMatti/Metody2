using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody2
{/*
  * zjištění, zda je dané číslo prvočíslo (vrací bool)
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JePrvocislo(long.Parse(Console.ReadLine())));
        }
        static bool JePrvocislo(long cislo)
        {
            if (cislo < 2) return false;
            for (int i = 2; i <= Math.Sqrt(cislo); i++)
            {
                if (cislo % i == 0) return false;
            }
            return true;
        }
    }
}
