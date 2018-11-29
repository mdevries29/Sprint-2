using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dagen,dagen1,dagen2;
            DateTime dateOfBirthFemale;
            DateTime dateOfBirthMen;
            DateTime today = DateTime.Now;


            Console.WriteLine("Voer de geboorte datum in dd/mm/jjjj van de man:");
            dateOfBirthMen = Convert.ToDateTime(Console.ReadLine()).Date;
            Console.WriteLine("Voer de geboorte datum in dd/mm/jjjj van de vrouw:");
            dateOfBirthFemale = Convert.ToDateTime(Console.ReadLine()).Date;

            TimeSpan differencemen = today.Subtract(dateOfBirthMen);
            TimeSpan differencefemale = today.Subtract(dateOfBirthFemale);

            dagen1 = differencemen.Days;
            dagen2 = differencefemale.Days;
            dagen = Math.Abs (dagen1 - dagen2);

            Console.WriteLine("\r\n" + "De man is: " + dagen1 + " dagen oud" + "\r\n" + "De vrouw is: " + dagen2 + " dagen oud" + "\r\n" + "Het verschil tussen jullie leeftijd is: " + dagen + " dagen");
            Console.ReadLine();

        }
    }
}