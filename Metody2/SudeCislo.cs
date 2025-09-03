using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody2
{/*
  * zjištění, zda je číslo sudé (bool)
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SudeCislo(int.Parse(Console.ReadLine())));
        }
        static bool SudeCislo(int cislo)
        {
            if (cislo % 2 == 0) return true;
            return false;
        }
    }
}
