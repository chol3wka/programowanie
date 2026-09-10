using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int n = 10;
        int[,] tabliczka = new int[n, n];

        Console.WriteLine("Tabliczka mnożenia:\n");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                tabliczka[i, j] = (i + 1) * (j + 1);
                Console.Write($"{tabliczka[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}