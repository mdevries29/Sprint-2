using System;

namespace _4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Double cijfer;

            Console.WriteLine("wat is het nummer van de dag?: ");
            cijfer = Convert.ToDouble(Console.ReadLine());

            if (cijfer == 7)
            {
                Console.WriteLine("zondag");
                Console.ReadLine();
            }
            else if (cijfer == 6)
            {
                Console.WriteLine("zaterdag");
                Console.ReadLine();
            }
            else if (cijfer == 5)
            {
                Console.WriteLine("vrijdag");
                Console.ReadLine();
            }
            else if (cijfer == 4)
            {
                Console.WriteLine("donderdag");
                Console.ReadLine();
            }
            else if (cijfer == 3)
            {
                Console.WriteLine("woensdag");
                Console.ReadLine();
            }
            else if (cijfer == 2)
            {
                Console.WriteLine("dinsdag");
                Console.ReadLine();
            }
            else if (cijfer == 1)
            {
                Console.WriteLine("maandag");
                Console.ReadLine();
            }
        }
    }
}