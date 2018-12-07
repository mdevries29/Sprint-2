using System;
static class StringHelper
{
    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);

    }
}

class Program
{
    static void Main()
    {
        string tekst;
        Console.WriteLine("Geef uw tekst:");
        tekst = Console.ReadLine();
        Console.Write("\r\n");
        Console.WriteLine(StringHelper.ReverseString(tekst));
        Console.ReadLine();
    }
}