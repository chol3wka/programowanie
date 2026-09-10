//Weronika Cholewa

using System;
using System.Net.NetworkInformation;

public class zadanie5
{
    public static void Main(string[] args) 
    {
        int d = 0;
        Console.WriteLine("Podaj liczbę binarną.");
        string a =(Console.ReadLine());
        for(int i = 0; i < a.Length; i++){
            if (a[a.Length -i-1]=='1'){
                d+=(int)Math.Pow(2,i);
            }
        }
        Console.WriteLine("Liczba dziesiętna: " + d);
    }
}
