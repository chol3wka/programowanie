using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        int[,] macierz = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            macierz[i, 0] = i;
            macierz[i, 1] = i * i;
            
            for (int j = 0; j < 10; j++)
            {
                
                Console.Write(macierz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}