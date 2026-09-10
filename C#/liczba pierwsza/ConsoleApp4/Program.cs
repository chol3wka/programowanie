using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

public class ConsoleApp4
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę.");
        int n = int.Parse(Console.ReadLine());

        
        if(czyPierwsza(n)) {
            {
                Console.WriteLine("Liczba jest liczbą pierwszą");
            }
            else {
                Console.WriteLine("Liczba nie jest liczbą pierwszą");
            }
        }
    }
    public static bool czyPierwsza(int n)
    {
        int liczbapodzielnikow = 0;
        int podzielnik = 2;

        while (podzielnik <= n)
        {
            if (n % podzielnik == 0)
            {
                liczbapodzielnikow++;
            }
            podzielnik++;
    }