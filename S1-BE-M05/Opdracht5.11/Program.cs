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
            decimal rente, geldBedrag, eindBedrag, renteBedrag;
            eindBedrag = 0;

            Console.WriteLine("Geef uw geldbedrag:");
            geldBedrag = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Geef uw rente percentage %:");
            rente = Convert.ToDecimal(Console.ReadLine());

            renteBedrag = geldBedrag * rente;
            eindBedrag = geldBedrag + (10 * (renteBedrag - geldBedrag));

            Console.WriteLine("Na 10 jaar heeft u: " + eindBedrag);
            Console.ReadLine();
        }
    }
}
