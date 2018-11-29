using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            double weekNumber;
            DateTime d = DateTime.Now;
            DateTime dateTime = DateTime.UtcNow.Date;
            weekNumber = (DateTime.Now.DayOfYear / 6.895833333333333);
            Console.WriteLine(d.Year);
            Console.WriteLine(DateTime.Now.ToString("MMMM"));
            Console.WriteLine(d.DayOfWeek);
            Console.WriteLine(dateTime.ToString("dd"));
            Console.WriteLine(weekNumber);
            Console.WriteLine(d.DayOfYear);
            Console.ReadLine();
        }
    }
}
