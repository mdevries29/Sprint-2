using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._22
{
    class Program
    {
        static void Main(string[] args)
        {
            int intTeller, intFibo1, intFibo2, intFibo3;
            intFibo1 = 0;
            intFibo2 = 1;

            Console.Write(intFibo1.ToString() + " " + intFibo2.ToString() + " ");

            for (intTeller = 3; intTeller <= 4000000000; intTeller++)
            {
                intFibo3 = intFibo1 + intFibo2;
                intFibo1 = intFibo2;
                intFibo2 = intFibo3;

                Console.Write(intFibo3.ToString() + " ");
            }
            Console.ReadLine();
        }
    }
}
