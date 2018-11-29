using System;

namespace Opdracht2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Getal1, Getal2, Som1, Som2, Som3, Som4, Som5, keuze;

            Console.Write("Geef getal 1: ");
            Getal1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Geef getal 2: ");
            Getal2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\r\n"+"Kies uw berekening:");
            Console.WriteLine("1 = Optellen");
            Console.WriteLine("2 = Aftrekken");
            Console.WriteLine("3 = Vermedigvuldigen");
            Console.WriteLine("4 = Delen");
            Console.WriteLine("5 = Modulus");
            keuze = Convert.ToInt16(Console.ReadLine());

            switch (keuze)
            {
                case 1:
                    Som1 = Getal1 + Getal2;
                    Console.WriteLine("\r\n" + "Eerste getal plus tweede getal " + Som1.ToString());
                    break;
                case 2:
                    Som2 = Getal1 - Getal2;
                    Console.WriteLine("\r\n" + "Tweede getal min eerste getal " + Som2.ToString());
                    break;
                case 3:
                    Som3 = Getal1 * Getal2;
                    Console.WriteLine("\r\n" + "Eerste getal maal tweede getal " + Som3.ToString());
                    break;
                case 4:
                    if (Getal2 == 0)
                    {
                        Console.WriteLine("\r\n" + "Delen door nul is flauwekul");
                    }
                    else
                    {
                        Som4 = Getal1 / Getal2;
                        Console.WriteLine("\r\n" + "Eerste getal gedeeld door tweede getal " + Som4.ToString());
                    }
                    break;
                case 5:
                    if (Getal2 == 0)
                    {
                        Console.WriteLine("\r\n" + "Niet mogelijk");
                    }
                    else
                    {
                        Som5 = Getal1 %= Getal2;
                        Console.WriteLine("\r\n" + "Restant van eerste getal gedeeld door tweede getal " + Som5.ToString());
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}