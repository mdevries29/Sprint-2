using System;

namespace _3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Double dblprijs, dblbreete, dbllengte, dblmeters, dbljaren;
            string naam;

            Console.WriteLine("voer uw naam in ");
            naam = (Console.ReadLine());

            Console.WriteLine("voor hoe lang wilt uw de een contract");
            dbljaren = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("wat is de breete ");
            dblbreete = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("wat is de lengte ");
            dbllengte = Convert.ToDouble(Console.ReadLine());

            dblmeters = (dbllengte * dblbreete);
            dblprijs = (dblmeters * 1.50);

            if (dbljaren == 2)
            {
                dblprijs = dblprijs / 105 * 100;
            }
            if (dbljaren == 3)
            {
                dblprijs = dblprijs / 110 * 100;
            }

            Console.WriteLine("beste meneer " + naam + " uw wil een contract voor: " + dbljaren + " en de kosten daar voor zijn " + dblprijs);
            Console.ReadLine();
        }
    }
}
