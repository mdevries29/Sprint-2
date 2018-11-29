using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int Taal;
            DateTime d = DateTime.Now;
            DateTime dateTime = DateTime.UtcNow.Date;
            Console.WriteLine("Kies uw taal:");
            Console.WriteLine("1 = Nederlands");
            Console.WriteLine("2 = Duits");
            Console.WriteLine("3 = Engels");
            Console.WriteLine("4 = Frans");
            Console.WriteLine("5 = Spaans");
            Console.WriteLine("6 = Indonesisch");
            Taal = Convert.ToInt16(Console.ReadLine());
            
            switch (Taal)
            {
                case 1:
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("nl-NL");
                    Console.WriteLine("\r\n" + "De huidige maand is " + DateTime.Now.ToString("MMMM"));
                    break;
                case 2:
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
                    Console.WriteLine("\r\n" + "Der aktuelle Monat ist " + DateTime.Now.ToString("MMMM"));
                    break;
                case 3:
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    Console.WriteLine("\r\n" + "The current month is " + DateTime.Now.ToString("MMMM"));
                    break;
                case 4:
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
                    Console.WriteLine("\r\n" + "Le mois en cours est " + DateTime.Now.ToString("MMMM"));
                    break;
                case 5:
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");
                    Console.WriteLine("\r\n" + "El mes actual es " + DateTime.Now.ToString("MMMM"));
                    break;
                case 6:
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("id-ID");
                    Console.WriteLine("\r\n" + "Bulan saat ini adalah " + DateTime.Now.ToString("MMMM"));
                    break;
            }
            Console.ReadLine();
        }
    }
}
