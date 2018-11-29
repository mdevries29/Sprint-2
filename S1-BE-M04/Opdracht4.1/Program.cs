using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2;

            Console.WriteLine("voer getal1 in: ");
            getal1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("voer getal2 in: ");
            getal2 = Convert.ToInt16(Console.ReadLine());

            if (getal1 < getal2)
            {
                Console.WriteLine("Het tweede getal is het grootste");
                Console.ReadLine();
            }
            else if (getal1 > getal2)
            {
                Console.WriteLine("Het eerste getal is het grootste");
                Console.ReadLine();
            }
            else if (getal1 == getal2)
            {
                Console.WriteLine("De getallen zijn gelijk aan elkaar");
                Console.ReadLine();
            }
            else
                Console.WriteLine("geen geldige waarde");
            Console.ReadLine

        }
    }
}