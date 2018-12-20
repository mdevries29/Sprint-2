        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._5
{
    class Program
    {
        static void Main()
        {
            int intTeller, intSom;
            intSom = 0;

            for (intTeller = 100; intTeller <= 1000; intTeller++)
            {
                intSom = intSom + intTeller;
            }
            Console.WriteLine("De som van 100 tot 1000 is met al zijn voorgaande getallen is " + intSom.ToString());
            Console.ReadLine();
        }   
    }
}
