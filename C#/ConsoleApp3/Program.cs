using System;

public class consoleapp3
{
    public static void Main(string[] args) 
    {
        float a, b, c, p;
        float S;
        
        Console.WriteLine("Podaj wartość a: ");
        a = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość b: ");
        b = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość c: ");
        c = float.Parse(Console.ReadLine());
        
        p = (float) (a+b+c)/2;
        S= (float) Math.Sqrt(p*(p-a)*(p-b)*(p-c));

        Console.WriteLine("Pole wynosi: " + S);
    }
}  