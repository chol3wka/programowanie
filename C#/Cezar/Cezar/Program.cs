using System;
using System.Collections.Generic;

public class Cezar
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj tekst do zaszyfrowania.");
        string tekst = Console.ReadLine();
        Console.WriteLine("Podaj przesunięcie.");
        int przesuniecie = int.Parse(Console.ReadLine());

        string tekst_zaszyfrowany = SzyfrCezara(tekst, przesuniecie);
        Console.WriteLine("Zaszyfrowany tekst: " + tekst_zaszyfrowany);
    }
    static string SzyfrCezara(string tekst, int przesuniecie)
    {
        string wynik = "";

        foreach (char znak in tekst)
        {
            if (char.IsLetter(znak))
            {

                char offset = char.IsUpper(znak) ? 'A' : 'a';
                char zaszyfrowany_znak = (char)(((znak - offset + przesuniecie) % 26) + offset);
                wynik += zaszyfrowany_znak;

            }
            else
            {
                wynik += znak;
            }
        }
        return wynik;
    }
}