using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._7
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Ochtend.
            TimeSpan startochtend = new TimeSpan(00, 0, 0);
            TimeSpan endochtend = new TimeSpan(12, 0, 0);
            TimeSpan nowochtend = DateTime.Now.TimeOfDay;

            //Middag.
            TimeSpan startmiddag = new TimeSpan(12, 0, 0);
            TimeSpan endmiddag = new TimeSpan(18, 0, 0);
            TimeSpan nowmiddag = DateTime.Now.TimeOfDay;

            //Middag.
            TimeSpan startavond = new TimeSpan(12, 0, 0);
            TimeSpan endavond = new TimeSpan(18, 0, 0);
            TimeSpan nowavond = DateTime.Now.TimeOfDay;

            if (nowochtend < endochtend)
            {
                Console.WriteLine("Goedeochtend!");
            }
            else
            {
                if (nowmiddag < endmiddag)
                {
                    Console.WriteLine("Goedemiddag!");
                }
                else
                {
                    if ((dayToday == DayOfWeek.Saturday) && (dayToday == DayOfWeek.Sunday))
                    {
                        if (nowavond < endavond)
                        {
                            Console.WriteLine("Goedemiddag het is vandaag weekend ");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
