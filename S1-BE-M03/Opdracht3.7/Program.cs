using System;

namespace ConsoleApp21
{
    class progrm
    {
        public static string Tekst1 { get; private set; }
        public static string Tekst2 { get; private set; }

        private static void Main()
        {

            Console.WriteLine("Voer hier uw tekst in");
            Tekst1 = Console.ReadLine();

            string text = Tekst1;
            Tekst1 = Tekst1.Replace("a", "*");
            Tekst1 = Tekst1.Replace("e", "*");
            Tekst1 = Tekst1.Replace("o", "*");
            Tekst1 = Tekst1.Replace("u", "*");
            Tekst1 = Tekst1.Replace("A", "*");
            Tekst1 = Tekst1.Replace("e", "*");
            Tekst1 = Tekst1.Replace("O", "*");
            Tekst1 = Tekst1.Replace("U", "*");
            Console.WriteLine("Tekst zonder klinkers");
            Console.Write(Tekst1);
            Tekst2 = Console.ReadLine();

        }
    }
}
