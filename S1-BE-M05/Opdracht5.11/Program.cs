using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef uw geldbedrag:");
            decimal geldBedrag = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Geef uw rente percentage %:");
            decimal rente = Convert.ToDecimal(Console.ReadLine());

            decimal rentePercentage = (rente / 100) + 1; ;

            Console.Write("\r\n");
            Console.WriteLine("Waarde na elk jaar:" + "\r\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Na " + (i + 1)+ " jaar" + "\t\t" + Rounding((rentePercentage * geldBedrag)));
                geldBedrag = rentePercentage * geldBedrag;
            }
            Console.ReadLine();
        }

        private static decimal Rounding(decimal _geldBedrag)
        {
            return Math.Round(_geldBedrag, 2);
        }
    }
}