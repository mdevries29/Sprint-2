using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._21
{
    class Program
    {
        static void Main(string[] args)
        {

            int graden = 0;
            Console.WriteLine("Geef een temperatuur tussen -30 en 50 °C");
            graden = int.Parse(Console.ReadLine());

            Console.WriteLine("-30  -20  -10  0  10  20  30  40  50 °C");
            Console.WriteLine("---------------------------------------");
            goto y;
        start:
            graden = int.Parse(Console.ReadLine());


        y:
            if (graden > -30 && graden < -20 || graden == -30 || graden == -20)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine(graden + "        ");
                Console.ResetColor();
            }
            else if (graden > -20 && graden < -10 || graden == -10)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("             ");
                Console.ResetColor();
            }
            else if (graden > -10 && graden < 0 || graden == 0)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                ");
                Console.ResetColor();
            }
            else if (graden > 0 && graden < 10 || graden == 10)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("                    ");
                Console.ResetColor();
            }
            else if (graden > 10 && graden < 20 || graden == 20)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                        ");
                Console.ResetColor();
            }
            else if (graden > 20 && graden < 30 || graden == 30)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("                            ");
                Console.ResetColor();
            }
            else if (graden > 30 && graden < 50 || graden == 50)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("                                    ");
                Console.ResetColor();
            }
            else
                Console.WriteLine("Geen een tempereatuur tussen -30 en 50 °C");
            goto start;
        }
    }
}
