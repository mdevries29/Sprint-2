using System;

public class Program
{
    public static void Main()
    {



        decimal Cube_Length, Volume;
        Console.Write("Lengte van de kubus : ");
        Cube_Length = Convert.ToDecimal(Console.ReadLine());

        decimal Cube_Width;
        Console.Write("Breedte van de kubus : ");
        Cube_Width = Convert.ToDecimal(Console.ReadLine());

        decimal Cube_Hight;
        Console.Write("Hoogte van kubus : ");
        Cube_Hight = Convert.ToDecimal(Console.ReadLine());

        Volume = (Cube_Length * Cube_Width * Cube_Hight);

        Console.Write("\nVolume van cubus is : " + Volume);
        Console.ReadLine();
    }
}