using System;
using System.Net.NetworkInformation;

public class ConsoleApp1
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Podaj liczbę rzymską");
        string rzymskie = Console.ReadLine().ToUpper();

        Dictionary<string, int> liczby = new Dictionary<string, int>
        {
            { "M", 1000 },
            { "CM", 900 },
            { "D", 500 },
            { "CD", 400 },
            { "C", 100 },
            { "XC", 90 },
            { "L", 50 },
            { "XL", 40 },
            { "X", 10 },
            { "IX", 9 },
            { "V", 5 }, 
            { "IV", 4 },
            { "I", 1 }
        };

        int wynik = 0;
        for (int i = 0; i < rzymskie.Length; i++)
        {
            if( i +1 < rzymskie.Length && liczby[rzymskie[i].ToString()] < liczby[rzymskie[i + 1].ToString()])
            {
                wynik -= liczby[rzymskie[i].ToString()];
            }
            else
            {
                wynik += liczby[rzymskie[i].ToString()];
            }
        }
        Console.WriteLine($"Liczba arabska: {wynik}");
    }
}