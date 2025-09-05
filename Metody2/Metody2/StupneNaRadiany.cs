using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody2
{/*
  * převod hodnoty úhlu ve stupních na radiány
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte hodnotu ve stupních.");
            Console.WriteLine($"Hotodna v radiánech je {StupneNaRadiany(double.Parse(Console.ReadLine()))}");
        }
        static double StupneNaRadiany(double stupne)
        {
            return stupne * Math.PI / 180;
        }
    }
}
