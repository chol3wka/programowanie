//Weronika Cholewa

using System;
using System.Net.NetworkInformation;

public class zadanie2
{
    public static void Main(string[] args) 
    {
        int a;
        Console.WriteLine("Podaj liczbę.");
        a = int.Parse(Console.ReadLine());
        string b ="";
        for(int i=a; i>0; i/=2){
                int r = i%2;
                b = r + b;
                }
                Console.WriteLine("Liczba binarna: " + b);
            }
    }
