using System;

namespace _4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double cijfer;

            Console.WriteLine("voer hier een getal in tussen de 1 en 4: ");
            cijfer = Convert.ToDouble(Console.ReadLine());


            if (cijfer == 4)
            {
                Console.WriteLine("schoppen");
                Console.ReadLine();
            }
            else if (cijfer == 3)
            {
                Console.WriteLine("harten");
                Console.ReadLine();
            }
            else if (cijfer == 2)
            {
                Console.WriteLine("ruiten");
                Console.ReadLine();
            }
            else if (cijfer == 1)
            {
                Console.WriteLine("klaver");
                Console.ReadLine();
            }
            else
                Console.WriteLine("geen geldige waarde!");
            Console.ReadLine();
        }
    }
}
