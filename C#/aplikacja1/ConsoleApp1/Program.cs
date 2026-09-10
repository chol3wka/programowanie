using System;

public class aplikacja1
{
    public static void Main(string[] args) 
    {
        float liczba1, liczba2, liczba3, liczba4;
        float suma;
        Console.WriteLine("Podaj pierwszą liczbę");
        liczba1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj drugą liczbę");
        liczba2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj trzecią liczbę");
        liczba3 = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj czwartą liczbę");
        liczba4 = float.Parse(Console.ReadLine());

        suma = liczba1 + liczba2 + liczba3 + liczba4;

        Console.WriteLine("Suma: " + suma);

    }
}  