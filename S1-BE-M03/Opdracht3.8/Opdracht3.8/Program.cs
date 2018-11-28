using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string voornaam, tussenvoegsel, achternaam;
            int lengte;

            Console.WriteLine("Geef uw voornaam:");
            voornaam = (Console.ReadLine());

            Console.WriteLine("Geef uw tussenvoegsels:");
            tussenvoegsel = (Console.ReadLine());

            Console.WriteLine("Geef uw achternaam:");
            achternaam = (Console.ReadLine());

            lengte = voornaam.Length + tussenvoegsel.Length + achternaam.Length;
            string str = voornaam;
            str.Split(' ').ToList().ForEach(i => Console.Write(i[0] + tussenvoegsel + achternaam +lengte));
            Console.ReadLine();

        }
    }
}
