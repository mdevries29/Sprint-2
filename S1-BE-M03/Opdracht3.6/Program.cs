using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ned1, ned2, eng1, eng2, wis1, wis2, dbd1, dbd2, alg1, alg2, prg1, prg2, nedcijf, engcijf, wiscijf, dbdcijf, algcijf, prgcijf;
            string voorenachternaam;
            int studentnummer;

            Console.WriteLine("Wat is uw Studentnummer?");
            studentnummer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wat is uw Voor- en Achternaam?");
            voorenachternaam = (Console.ReadLine());

            Console.WriteLine("\r\n" + "Wat is de eerste cijfer voor NED? (Geef in als decimalen)");
            ned1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Wat is de tweede cijfer voor NED? (Geef in als decimalen)");
            ned2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\r\n" + "Wat is de eerste cijfer voor ENG? (Geef in als decimalen)");
            eng1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Wat is de tweede cijfer voor ENG? (Geef in als decimalen)");
            eng2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\r\n" + "Wat is de eerste cijfer voor WIS? (Geef in als decimalen)");
            wis1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Wat is de tweede cijfer voor WIS? (Geef in als decimalen)");
            wis2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\r\n" + "Wat is de eerste cijfer voor DBD? (Geef in als decimalen)");
            dbd1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Wat is de tweede cijfer voor DBD? (Geef in als decimalen)");
            dbd2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\r\n" + "Wat is de eerste cijfer voor ALG? (Geef in als decimalen)");
            alg1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Wat is de tweede cijfer voor ALG? (Geef in als decimalen)");
            alg2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\r\n" + "Wat is de eerste cijfer voor PRG? (Geef in als decimalen)");
            prg1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Wat is de tweede cijfer voor PRG? (Geef in als decimalen)");
            prg2 = decimal.Parse(Console.ReadLine());

            nedcijf = (ned1 + ned2) / 2;
            engcijf = (eng1 + eng2) / 2;
            wiscijf = (wis1 + wis2) / 2;
            dbdcijf = (dbd1 + dbd2) / 2;
            algcijf = (alg1 + alg2) / 2;
            prgcijf = (prg1 + prg2) / 2;

            Console.WriteLine("\r\n" + "Raport van " + voorenachternaam + " | Studentnummer = " + "0" + studentnummer);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("VAK |  1e  /  2e  /  Gemiddeld");
            Console.WriteLine("NED |  " + ned1 + " /  " + ned2 + " /     " + nedcijf);
            Console.WriteLine("ENG |  " + eng1 + " /  " + eng2 + " /     " + engcijf);
            Console.WriteLine("WIS |  " + wis1 + " /  " + wis2 + " /     " + wiscijf);
            Console.WriteLine("DBD |  " + dbd1 + " /  " + dbd2 + " /     " + dbdcijf);
            Console.WriteLine("ALG |  " + alg1 + " /  " + alg2 + " /     " + algcijf);
            Console.WriteLine("PRG |  " + prg1 + " /  " + prg2 + " /     " + prgcijf);
            Console.ReadLine();
        }
    }
}
