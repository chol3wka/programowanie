using System;
using System.Reflection.Metadata.Ecma335;

public class ConsoleApp3
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę początku zakresu: ");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj liczbę końca zakresu: ");
        float b = float.Parse(Console.ReadLine());
        float liczenie = 0;

        for (float i = a; i <= b; i++) {
            if (i % 2 != 0) {
                liczenie++;
    }
        }
        Console.WriteLine($"W zakresie liczb od {a} do {b} jest {liczenie} liczb nieparzystych.");
        Console.ReadLine();
    }
}