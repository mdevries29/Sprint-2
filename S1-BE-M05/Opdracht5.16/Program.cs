using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef uw tekst:");
            string someString = Console.ReadLine();
            string newString = string.Concat(
                someString.ToLower().AsEnumerable().Select((c, i) => i % 2 == 0 ? c : char.ToUpper(c)));
            Console.WriteLine(newString);
            Console.ReadLine();
        }
    }
}
