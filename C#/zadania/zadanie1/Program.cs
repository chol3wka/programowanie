using System;
using System.Net.NetworkInformation;

public class zadanie1
{
    public static void Main(string[] args) 
    {
        float a;

        Console.WriteLine("Podaj liczbę.");
        a = float.Parse(Console.ReadLine());

        if(a%2==0){
            Console.WriteLine("To jest liczba parzysta");
        }
        else{
            Console.WriteLine("To nie jest liczba parzysta");
        }
    }
}  