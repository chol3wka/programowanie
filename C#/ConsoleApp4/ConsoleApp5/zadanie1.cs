//Weronika Cholewa

using System;
using System.Net.NetworkInformation;

public class zadanie1
{
    public static void Main(string[] args) 
    {
        int a,b;
        int s = 0;

        Console.WriteLine("Podaj wartość a (1-200):");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość b (1-200):");
        b = int.Parse(Console.ReadLine());

        if(a<1 || a>200 || b<1 || b>200){
            Console.WriteLine("Liczby muszą znajdować się w przedziale 1-200!");
        }
        else if(a<b){
            Console.WriteLine("Nieparzyste liczby w zakresie " + a + " do " + b + ":");
            for(int i=a; i<=b; i++){
                if (i%2!=0){
                    Console.WriteLine(i);
                    s+=i;
                }
            }
            Console.WriteLine("Suma nieparzystych liczb: " + s);
        }
        else if(a==b){
            Console.WriteLine("Te liczby są równe. Brak przedziału.");
        }
        else if(a>b){
            Console.WriteLine("Nieparzyste liczby w zakresie " + a + " do " + b + ":");
            for(int i=a; i>=b; i--){
                if (i%2!=0){
                    Console.WriteLine(i);
                    s+=i;
                }
            }
            Console.WriteLine("Suma nieparzystych liczb: " + s);
        }

    }
}