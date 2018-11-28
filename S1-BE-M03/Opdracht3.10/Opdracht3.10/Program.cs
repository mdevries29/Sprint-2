using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._101
{
    class Program
    {

        static void Main(string[] args)
        {
            TimeSpan interval = new TimeSpan(0, 0, 0);
            string naam;
            int leeftijd;
            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            Console.Write("Geef uw naam: ");
            naam = (Console.ReadLine());
            Console.Write("Geef uw leeftijd: ");
            leeftijd = Convert.ToInt32(Console.ReadLine());
            stopwatch.Stop();
            Console.WriteLine("je hebt er " + stopwatch.Elapsed.Seconds + " seconden over gedaan");
            Console.ReadLine();
        }
    }
}
