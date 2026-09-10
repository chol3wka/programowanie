using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

public class ConsoleApp7
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("Podaj liczbę");
        int liczba = int.Parse(Console.ReadLine());

        string[] Symbol = {"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"};
        int[] Wagi = {1000,900,500,400,100,90,50,40,10,9,5,4,1};
        string wynik = "";
        int n = 13;
        int i = 0;

        while(liczba >0){
            if(i<=n){
                if(Wagi[i]<=liczba){
                    wynik+=Symbol[i];
                    liczba-=Wagi[i];
                } else{
                    i++;
                }
            }
        }   
        Console.WriteLine("Liczba rzymska: " + wynik);
    }
}