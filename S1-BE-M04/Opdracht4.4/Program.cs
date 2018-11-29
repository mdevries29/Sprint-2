using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2, som;
            Console.WriteLine("Geef twee getallen:");
            getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tweede getal: " + getal1);
            getal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tweede getal: " + getal2);

            som = getal1 %= getal2;

            if (som < 1)
            {
                Console.WriteLine(som);
            }
            else
            {
                Environment.Exit(0);
            }
            Console.ReadLine();
        }
    }
}