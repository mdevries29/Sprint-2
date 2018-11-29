using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2, getal3;
            Console.WriteLine("Geef 3 getallen in:");
            getal1 = Convert.ToInt32(Console.ReadLine());
            getal2 = Convert.ToInt32(Console.ReadLine());
            getal3 = Convert.ToInt32(Console.ReadLine());
            if (getal1 > getal3 && getal2 > getal3)
            {
                Console.WriteLine("Het derde getal is het kleinste van de drie");

            }
            else
            {
                Console.WriteLine("Het derde getal is niet het kleinste van de drie");
            }
            Console.ReadLine();
        }
    }
}
