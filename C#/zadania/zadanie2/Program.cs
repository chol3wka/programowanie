using System;
using System.Net.NetworkInformation;

public class zadanie2
{
    public static void Main(string[] args) 
    {
        float a,b;

        Console.WriteLine("Podaj wartość a.");
        a = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość b.");
        b = float.Parse(Console.ReadLine());

        if(a>b){
        Console.WriteLine(a + " jest większe od "+ b);
    }  else if(b>a){
        Console.WriteLine(b + " jest większe od "+ a);
    } else{
        Console.WriteLine("Wartości " + a + " i " + b +" są równe." );
    }
}  
}