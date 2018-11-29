using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int jaar, maand;

            Console.WriteLine("Geef uw Jaartal");
            jaar = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Geef uw Maand");
            maand = Convert.ToInt16(Console.ReadLine());

            int dagenInMaand = System.DateTime.DaysInMonth(jaar, maand);
            Console.WriteLine("Het aantal dagen in deze maand is " + dagenInMaand.ToString());
            Console.ReadLine();
        }
    }
}
