using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;
            int square = 1;
            int Getal;

            Console.WriteLine("Voer een getal in tussen de 10 en 20");
            Console.WriteLine("-------------------------------------");
            Getal = Convert.ToInt16(Console.ReadLine());

            for (counter = 1; counter <= Getal; counter++)
            {
                square = counter * counter;
                Console.WriteLine("{0}   {1}", counter, square);

            }
            Console.ReadLine();
        }
    }
}
