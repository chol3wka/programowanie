using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int temp;
        int[] a = new int[] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };
        for (int p = 0; p <= a.Length - 2; p++)
        {
            for (int i = 0; i <= a.Length - 2; i++)
            {
                if (a[i] > a[i + 1])
                {
                    temp = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = temp;
                }
            }
        }
        foreach (int liczba in a)
        {
            Console.Write($"{liczba} ");
        }
    }
}