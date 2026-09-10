//Weronika Cholewa

using System;
using System.Net.NetworkInformation;

public class zadanie3
{
    public static void Main(string[] args) 
    {
        int h;
        Console.WriteLine("Podaj liczbę.");
        h = int.Parse(Console.ReadLine());
        for(int i =h; i>0;i--){
            for(int j =1; j<=i;j++){
            Console.Write("*");
        }
        Console.WriteLine("");
        }
    }
}