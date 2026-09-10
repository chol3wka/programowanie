using System;

public class ConsoleApp8
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("Podaj liczbę");
        int a = int.Parse(Console.ReadLine());
         Console.WriteLine("Podaj różnicę");
        int r = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj ilość liczb");
        int n = int.Parse(Console.ReadLine());

        int i = 1;

        while(i<=n){
            Console.WriteLine($"Liczba {i}: {a} ");
            a = a+r;
            i++;
        }
    }
}