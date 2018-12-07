using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Getal2, Getal3;
            Console.WriteLine("Geef 2 getallen in: ");
            Getal2 = Convert.ToInt32(Console.ReadLine());
            Getal3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Druk op enter: ");

            Console.ReadLine();

            for (int i = Getal2; i < Getal3; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
