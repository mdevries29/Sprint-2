using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef uw getal in: ");
            int e1 = Convert.ToInt32(Console.ReadLine());

            int e2 = e1 * e1;

            String e3 = e1 + "";
            String e4 = e2 + "";

            if (e4.EndsWith(e3))
            {
                Console.WriteLine("" + e1 + " is een automorf getal, want de uitkomst is " + e4 + "");
            }
            else
            {
                Console.WriteLine("" + e1 + " is geen automorf getal, want de uitkomst is " + e4 + "");
            }
            Console.ReadLine();
        }
    }
}