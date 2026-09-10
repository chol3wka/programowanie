using System;
using System.Collections;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
        int[] tab = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        int n = 13;
        double p = Math.Sqrt(n);
        int k = 2;
        double max = Math.Truncate(p);


        while(k<=n){
            tab[k] = k;
            k++;
    }
        k = 2;
        while (k <= max)
        {
            if (tab[k] != 0)
            {
                int j = k + k;
                if (j <= n)
                {
                    tab[j] = 0;
                    j = j + k;

                }
            }
            else
            {
                k++;
            }
        }
        Console.WriteLine(tab);
}