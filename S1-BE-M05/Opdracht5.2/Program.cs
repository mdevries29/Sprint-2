using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._2
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter;
            int square = 1;
            const int maxValue = 25;


            Console.WriteLine("Getal   kwadraad");
            Console.WriteLine("-------------------");
            Console.ReadLine();
            for (counter = 1; counter <= maxValue; counter++)
            {
                square = counter * counter;
                Console.WriteLine("{0}   {1}", counter, square);
            }
            Console.ReadLine();
        }
    }
}
