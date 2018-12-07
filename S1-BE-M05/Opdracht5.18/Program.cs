using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer uw email in: ");

            string EmailToCheck = Console.ReadLine();

            if (IsValidEmail(EmailToCheck))
            {
                Console.WriteLine("Ja, dit is een goed e-mail adress!");
            }
            else
            {
                Console.WriteLine("Nee, dit is geen geldig e-mail adress!");
            }
            Main(args);
        }

        private static bool IsValidEmail(string EmailToCheck)
        {
            try
            {
                MailAddress mail = new MailAddress(EmailToCheck);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
