using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string voornaam, tussenvoegsels, achternaam;
            int lengte;
            Console.WriteLine("voer uw naam in ");
            voornaam = (Console.ReadLine());

            Console.WriteLine("voer uw tussenvoegsels in ");
            tussenvoegsels = (Console.ReadLine());

            Console.WriteLine("voer uw achternaam ");
            achternaam = (Console.ReadLine());

            lengte = voornaam.Length + tussenvoegsels.Length + achternaam.Length;
            Console.WriteLine("lengte van uw naam is " + lengte);
            Console.ReadLine();
        }
    }
}
