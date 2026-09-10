using System;
using System.Net.NetworkInformation;

public class zadanie4
{
    public static void Main(string[] args) 
    {
        float a,b;
        float x;

        Console.WriteLine("Podaj wartość a.");
        a = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość b.");
        b = float.Parse(Console.ReadLine());

    if(a==0.0){
        Console.WriteLine("Błąd danych! a nie może być zerem!");
    }else{
        x = (-b)/a;
        Console.WriteLine("Wynik równania: " + x);
    }
}  
}