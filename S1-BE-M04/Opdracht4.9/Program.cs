using System;

namespace _4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Double cijfer;


            Console.WriteLine("wat is het nummer van de maand: ");
            cijfer = Convert.ToDouble(Console.ReadLine());

            if (cijfer == 12)
            {
                Console.WriteLine("december");
                Console.ReadLine();
            }
            else if (cijfer == 11)
            {
                Console.WriteLine("november");
                Console.ReadLine();
            }
            else if (cijfer == 10)
            {
                Console.WriteLine("oktober");
                Console.ReadLine();
            }
            else if (cijfer == 9)
            {
                Console.WriteLine("september");
                Console.ReadLine();
            }
            else if (cijfer == 8)
            {
                Console.WriteLine("augustus");
                Console.ReadLine();
            }
            else if (cijfer == 7)
            {
                Console.WriteLine("juli");
                Console.ReadLine();
            }
            else if (cijfer == 6)
            {
                Console.WriteLine("juni");
                Console.ReadLine();
            }
            else if (cijfer == 5)
            {
                Console.WriteLine("mei");
                Console.ReadLine();
            }
            else if (cijfer == 4)
            {
                Console.WriteLine("april");
                Console.ReadLine();
            }
            else if (cijfer == 3)
            {
                Console.WriteLine("maart");
                Console.ReadLine();
            }
            else if (cijfer == 2)
            {
                Console.WriteLine("februari");
                Console.ReadLine();
            }
            else if (cijfer == 1)
            {
                Console.WriteLine("januari");
                Console.ReadLine();
            }
        }
    }
}