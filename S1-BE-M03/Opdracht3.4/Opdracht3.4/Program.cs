/*
 * C# Program to Perfom Currency Conversions
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Enter your Choice :\n 1- Euro to Rupee \n ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Double Euro, rupe, valu;
                    Console.WriteLine("Enter the Euro Amount :");
                    Euro = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Euro Value :");
                    valu = double.Parse(Console.ReadLine());
                    rupe = Euro * valu;
                    Console.WriteLine("{0} Euro Equals {1} Rupees", Euro, rupe);
                    break;
            }
            Console.ReadLine();
        }
    }
}
