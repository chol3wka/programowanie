//Weronika Cholewa

using System;
using System.Net.NetworkInformation;

public class zadanie1
{
    public static void Main(string[] args) 
    {
        int n;
        Console.WriteLine("Podaj liczbę.");
        n = int.Parse(Console.ReadLine());
        for(int i=1; i<=n; i++){
                if (i%2!=0){
                    Console.WriteLine(i);
                }
            }
    }
}