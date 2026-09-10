using System;
using System.Reflection.Metadata.Ecma335;

public class ConsoleApp2
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj swoje imię");
        string imie = Console.ReadLine();
        int samogloski = LiczbaSamoglosek(imie);

        for (int i = 0; i < samogloski; i++)
        {
            Console.WriteLine(imie);
        }
    }

    static int LiczbaSamoglosek(string input)
    {
        int liczba = 0;
        string samogloski = "aeiouyAEIOUY";
        foreach (char c in input)
        {
            if (samogloski.Contains(c))
            {
                liczba++;
            };
        }
        return liczba -1;
    }
}