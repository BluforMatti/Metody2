using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody2
{    /*výpočet faktoriálu (vrací long)*/
    internal class Faktorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Faktorial(int.Parse(Console.ReadLine())));
        }
        static long Faktorial(int cislo)
        {
            if (cislo == 0) return 1;
            return cislo * Faktorial(cislo - 1);
        }
    }
}
