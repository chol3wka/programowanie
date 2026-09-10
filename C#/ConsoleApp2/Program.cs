using System;

public class consoleapp2
{
    public static void Main(string[] args) 
    {
        float a;
        float b;
        float obwod;
        float pole;
        
        Console.WriteLine("Podaj wartość a: ");
        a = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość b: ");
        b = float.Parse(Console.ReadLine());
        
        obwod = 2*(a+b);
        pole = a*b;

        Console.WriteLine("Obwód: " + obwod);
        Console.WriteLine("Pole: " + pole);
    }
}  