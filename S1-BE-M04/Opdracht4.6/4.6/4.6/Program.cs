using System;

namespace _4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string uren, jaren, storing;

            Console.WriteLine("heeft de draaibank meer dan 10.000 uur gewerkt?: ");
            uren = (Console.ReadLine());

            Console.WriteLine("is de draaibank al 7 jaar of meer oud?: ");
            jaren = (Console.ReadLine());

            Console.WriteLine("heeft de draaibank meer dan 25 storingen per jaar?: ");
            storing = (Console.ReadLine());

            if ((uren == "ja") || (jaren == "ja") || (storing == "ja"))
            {
                Console.WriteLine("de draaibank moet vervangen worden: ");
                storing = (Console.ReadLine());
            }
            else
            Console.WriteLine("nee uw draaibank is nog goed en hoeft niet vervangen worden");
            Console.ReadLine();
        }
    }
}
