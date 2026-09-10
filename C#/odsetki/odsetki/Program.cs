using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        double K, n, p, k;
        double Kn;

        Console.WriteLine("Wprowadź kapitał początkowy");
        K = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj liczbę lat");
        n = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj stopę procentową");
        p = double.Parse(Console.ReadLine());   

        Console.WriteLine("Podaj liczbę kapitalizacji w ciągu roku");
        k = double.Parse(Console.ReadLine());

        Kn = K * Math.Pow(1.0 + (p / (100.0 * k)), n * k);

        Console.WriteLine("Kapitał końcowy: " + Math.Round(Kn,2));



    }
    
}