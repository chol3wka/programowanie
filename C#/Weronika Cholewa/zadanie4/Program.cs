//Weronika Cholewa

using System;
using System.Net.NetworkInformation;

public class zadanie4
{
    public static void Main(string[] args) 
    {
        int a;
        Console.WriteLine("Podaj liczbę.");
        a = int.Parse(Console.ReadLine());
        int suma = 0;
        int iloraz = a;
        while(iloraz > 0){
            int r = iloraz%10;
            iloraz = iloraz/10;
            suma +=r;
        }
        Console.WriteLine("Suma cyfr liczby: " + suma);
            }
    }
