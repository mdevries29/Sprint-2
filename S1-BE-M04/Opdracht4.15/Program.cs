using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._15
{
    class Program
    {
        static void Main(string[] args)
        {
            int wiscijf, nacijf, schcijf, totaal;
            Console.WriteLine("Score voor Wiskunde: ");
            wiscijf = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Score voor Natuurkunde: ");
            nacijf = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Score voor Scheikunde: ");
            schcijf = Convert.ToInt32(Console.ReadLine());

            totaal = wiscijf + nacijf + schcijf;
            
            if (totaal == 180)
            {
                if (wiscijf > 39)
                {
                    if (nacijf > 39)
                    {
                        if (schcijf > 39)
                        {
                            Console.WriteLine("\r\n" + "U kunt deelnemen aan het examen");
                        }
                        else
                        {
                            Console.WriteLine("\r\n" + "U kunt niet deelnemen aan het examen");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\r\n" + "U kunt niet deelnemen aan het examen");
                    }
                }
                else
                {
                    Console.WriteLine("\r\n" + "U kunt niet deelnemen aan het examen");
                }
            }
            else
            {
                Console.WriteLine("\r\n" + "U kunt niet deelnemen aan het examen");
            }
            Console.ReadLine();
        }
    }
}
