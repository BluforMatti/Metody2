using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody2
{/*
  * nalezení nejmenšího čísla v nesetříděném poli
  * výpočet aritmetického průměru z hodnot uložených v poli
  *výpočet geometrického průměru z hodnot uložených v poli
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] ints = new int[5];

            for (int i = 0; i < ints.Length; i++)
            { 
                ints[i] = random.Next(1,101);
                Console.Write($"{ints[i]} ");
            }
            
            Console.WriteLine($"\n\nNejmenší hodnota v poli je {Nejmensi(ints)}");
            Console.WriteLine($"\nPrůměrná hodnota pole je {Prumer(ints)}");
            Console.WriteLine($"\nGeoMetrický průměr hodnot pole je {GeoPrumer(ints)}");
        }
        static int Nejmensi(int[] x)
        {
            return x.Min();
        }
        static double Prumer(int[] x)
        {
            return x.Average();
        }
        static int GeoPrumer(int[] x)
        {
            int rada = 1;
            for (int i = 0;i < x.Length;i++)
            {
                rada *= x[i];
            }
            return rada;
        }
    }
}
