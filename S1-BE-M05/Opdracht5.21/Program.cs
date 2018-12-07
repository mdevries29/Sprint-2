using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._21
{
    class Program
    {
        public static void Main()
        {
            int a, b, i, Som = 0;
            for (i = 1; i < 100; i++)
            {
                a = i % 3;
                b = i % 5;
                if (a == 0 || b == 0)
                {
                    Som = Som + i;
                }
            }
            Console.WriteLine("Veelvoud van 3 of 5 onder de 1000 = {0}", Som);
            Console.ReadLine();
        }
    }
}
