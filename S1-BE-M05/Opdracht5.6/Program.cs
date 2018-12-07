using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int diceComplex;
            int diceSimple;
            int counterComplex = 0;
            int counterSimple = 0;
            int worpComplex;
            int worpSimple;
            int totalComplex = 0;
            int totalSimple = 0;
            double rawComplex;
            double gemiddeldeComplex;
            double gemiddeldeSimple;

            Console.WriteLine("Hoe vaak moet de dobbelsteen gooie? ");
            diceComplex = Convert.ToInt32(Console.ReadLine());

            Random generator = new Random();

            while (counterComplex < diceComplex)
            {
                rawComplex = generator.NextDouble();
                worpComplex = (int)(generator.NextDouble() * 6) + 1;
                Console.WriteLine("volgende worp: {0}", worpComplex);
                counterComplex++;
                totalComplex += worpComplex;
            }

            Console.WriteLine("Totaal is {0}", totalComplex);
            gemiddeldeComplex = Convert.ToDouble(totalComplex) / Convert.ToDouble(diceComplex);
            Console.WriteLine("Gemiddelde is {0}", gemiddeldeComplex);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Druk Enter om af te sluiten");
            Console.ReadLine();

        }
    }
}
