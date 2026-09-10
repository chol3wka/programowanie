using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        int[] tablica = new int[101];
        int parzyste = 0;
        int nieparzyste  = 0;

        for (int i = 0; i < 101; i++)
        {
            tablica[i] = i;
        }
        foreach (var liczba in tablica)
        {
            if (tablica[liczba] % 2 == 0)
            {

                parzyste += tablica[liczba];
            }
            else
            {
                nieparzyste += tablica[liczba];
            }
        }
        Console.WriteLine("Suma nieparzystych: " + nieparzyste);
        Console.WriteLine("Suma parzystych: " + parzyste);
    }
}