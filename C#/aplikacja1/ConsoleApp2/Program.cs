using System;
using System.Net.NetworkInformation;

public class consoleapp2
{
    public static void Main(string[] args) 
    {
        float R, r, h;
        float V;

        Console.WriteLine("Podaj wartość R: ");
        R = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość r: ");
        r = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość h: ");
        h = float.Parse(Console.ReadLine());

        V= (float)((Math.PI*h)/15)*(8*(R*R)+(4*r*R)+3*(r*r));

        Console.WriteLine("Objętość wynosi: " + V);
    }
}  