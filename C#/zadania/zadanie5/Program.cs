using System;
using System.Net.NetworkInformation;

public class zadanie5
{
    public static void Main(string[] args) 
    {
        float a,b,c;

        Console.WriteLine("Podaj wartość a.");
        a = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość b.");
        b = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość c.");
        c = float.Parse(Console.ReadLine());

    if(a<=b){
        if(c<=a){
            Console.WriteLine(c + ","+ a + ","+ b);
        } else if(b<=c){
            Console.WriteLine(a + ","+ b + ","+ c);
        } else{
            Console.WriteLine(a + ","+ c + ","+ b);
        }
    }else if(c<=b){
        Console.WriteLine(c +","+ b + ","+ a);
    }else if(c<=a){
        Console.WriteLine(b +","+ c +","+ a);
    }else{
        Console.WriteLine(b +","+ a +","+ c);
    }
}  
}