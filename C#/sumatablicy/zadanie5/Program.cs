using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        int[] dane = new int[101];

        int suma = 0;

        for (int i = 0; i < 101; i++)
        {
            dane[i] = i;
        }
        foreach (var liczba in dane)
        {
            suma += dane[liczba];
        }
        Console.WriteLine("Suma z elementów: " + suma);
    }
}