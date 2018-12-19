using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.WriteLine("Wat is uw score? (0/100 punten):");
            score = Convert.ToInt32(Console.ReadLine());

            if (score > 100-1)
            {
                Console.WriteLine("U heeft een A++ gehaald, u heeft het vak gehaald");
            }
            else
            {
                if (score > 95 - 1)
                {
                    Console.WriteLine("U heeft een A+ gehaald, u heeft het vak gehaald");

                }
                else
                {
                    if (score > 90 - 1)
                    {
                        Console.WriteLine("U heeft een A gehaald, u heeft het vak gehaald");
                    }
                    else
                    {
                        if (score > 85 - 1)
                        {
                            Console.WriteLine("U heeft een A- gehaald, u heeft het vak gehaald");
                        }
                        else
                        {
                            if (score > 80 - 1)
                            {
                                Console.WriteLine("U heeft een B+ gehaald, u heeft het vak gehaald");
                            }
                            else
                            {
                                if (score > 75 - 1)
                                {
                                    Console.WriteLine("U heeft een B gehaald, u heeft het vak gehaald");
                                }
                                else
                                {
                                    if (score > 70 - 1)
                                    {
                                        Console.WriteLine("U heeft een B- gehaald, u heeft het vak gehaald");
                                    }
                                    else
                                    {
                                        if (score > 65 - 1)
                                        {
                                            Console.WriteLine("U heeft een C+ gehaald, u heeft het vak gehaald");
                                        }
                                        else
                                        {
                                            if (score > 60 - 1)
                                            {
                                                Console.WriteLine("U heeft een C gehaald, u heeft het vak gehaald");
                                            }
                                            else
                                            {
                                                if (score > 55 - 1)
                                                {
                                                    Console.WriteLine("U heeft een C- gehaald, u heeft het vak niet gehaald");
                                                }
                                                else
                                                {
                                                    if (score > 50 - 1)
                                                    {
                                                        Console.WriteLine("U heeft een D+ gehaald, u heeft het vak niet gehaald");
                                                    }
                                                    else
                                                    {
                                                        if (score > 45 - 1)
                                                        {
                                                            Console.WriteLine("U heeft een D gehaald, u heeft het vak niet gehaald");
                                                        }
                                                        else
                                                        {
                                                            if (score > 40 - 1)
                                                            {
                                                                Console.WriteLine("U heeft een D- gehaald, u heeft het vak niet gehaald");
                                                            }
                                                            else
                                                            {
                                                                if (score > 35 - 1)
                                                                {
                                                                    Console.WriteLine("U heeft een E+ gehaald, u heeft het vak niet gehaald");
                                                                }
                                                                else
                                                                {
                                                                    if (score > 30 - 1)
                                                                    {
                                                                        Console.WriteLine("U heeft een E gehaald, u heeft het vak niet gehaald");
                                                                    }
                                                                    else
                                                                    {
                                                                        if (score > 25 - 1)
                                                                        {
                                                                            Console.WriteLine("U heeft een E- gehaald, u heeft het vak niet gehaald");
                                                                        }
                                                                        else
                                                                        {
                                                                            if (score > 20 - 1)
                                                                            {
                                                                                Console.WriteLine("U heeft een F+ gehaald, u heeft het vak niet gehaald");
                                                                            }
                                                                            else
                                                                            {
                                                                                if (score > 10 - 1)
                                                                                {
                                                                                    Console.WriteLine("U heeft een F gehaald, u heeft het vak niet gehaald");
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (score > 5 - 1)
                                                                                    {
                                                                                        Console.WriteLine("U heeft een F- gehaald, u heeft het vak niet gehaald");
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (score > 0 - 1)
                                                                                        {
                                                                                            Console.WriteLine("U heeft een F-- gehaald, u heeft het vak niet gehaald");
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            Console.WriteLine("U heeft een F-- gehaald, u heeft het vak niet gehaald");
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
