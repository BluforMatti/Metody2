using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody2
{/*
  * zjištění, zda je číslo dělitelné jiným beze zbytku (bool)
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DelitelnostBezZbytku(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
        static bool DelitelnostBezZbytku(int delitel, int cislo)
        {
            return cislo % delitel == 0;
        }

    }
}
