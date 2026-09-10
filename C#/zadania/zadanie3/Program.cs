using System;
using System.Net.NetworkInformation;

public class zadanie3
{
    public static void Main(string[] args) 
    {
        float a;

        Console.WriteLine("Podaj wartość a.");
        a = float.Parse(Console.ReadLine());

        Console.WriteLine("Wartością bezwzględną a jest " + Math.Abs(a));
        
}
}