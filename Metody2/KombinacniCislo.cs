using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody2
{/*
  * výpočet kombinačního čísla n nad k (long)
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (n < k)
            {
                Console.WriteLine("n musí být větší nebo rovno k");
                return;
            }
            Console.WriteLine(KombinacniCislo(n,k));
        }
        static long KombinacniCislo(int n, int k)
        {
                return Faktorial(n) / (Faktorial(k) * Faktorial(n - k));
        }

        static long Faktorial(int cislo)
        {
            if (cislo == 0) return 1;
            return cislo * Faktorial(cislo - 1);
        }
    }
}
