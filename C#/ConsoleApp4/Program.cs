using System;
using System.Net.NetworkInformation;

public class consoleapp3
{
    public static void Main(string[] args) 
    {
        float r, h;
        float V;

        Console.WriteLine("Podaj wartość r: ");
        r = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość h: ");
        h = float.Parse(Console.ReadLine());

        V= (float)Math.PI*(r*r)* h;

        Console.WriteLine("Objętość wynosi: " + V);
    }
}  