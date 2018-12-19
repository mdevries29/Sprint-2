using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            string maand;

            Console.WriteLine("van welke maand wil de aantal dagen weten?: ");
            maand = (Console.ReadLine());

            if (maand == "januari")
            {
                Console.WriteLine("januari heeft 31 dagen");
                Console.ReadLine();
            }
            else if (maand == "fabruari")
            {
                Console.WriteLine("februari heeft 28 dagen. In een schrikkeljaar is het aantal dagen in februari 29");
                Console.ReadLine();
            }
            else if (maand == "maart")
            {
                Console.WriteLine("maart heeft 31 dagen");
                Console.ReadLine();
            }
            else if (maand == "april")
            {
                Console.WriteLine("april heeft 30 dagen");
                Console.ReadLine();
            }
            else if (maand == "mei")
            {
                Console.WriteLine("mei heeft 31 dagen");
                Console.ReadLine();
            }
            else if (maand == "june")
            {
                Console.WriteLine("june heeft 30 dagen");
                Console.ReadLine();
            }
            else if (maand == "juli")
            {
                Console.WriteLine("juli heeft 31 dagen");
                Console.ReadLine();
            }
            else if (maand == "augustus")
            {
                Console.WriteLine("augustus heeft 30 dagen");
                Console.ReadLine();
            }
            else if (maand == "september")
            {
                Console.WriteLine("september heeft 31 dagen");
                Console.ReadLine();
            }
            else if (maand == "oktober")
            {
                Console.WriteLine("oktober heeft 30 dagen");
                Console.ReadLine();
            }
            else if (maand == "november")
            {
                Console.WriteLine("november heeft 31 dagen");
                Console.ReadLine();
            }
            else if (maand == "december")
            {
                Console.WriteLine("december heeft 30 dagen");
                Console.ReadLine();
            }
        }
    }
}