using System;
using System.Net.NetworkInformation;

public class consoleapp4
{
    public static void Main(string[] args){
        float o, p;
    Console.WriteLine("Podaj a: "); 
    int a = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Podaj b: "); 
    int b = Convert.ToInt32(Console.ReadLine()); 
     Console.WriteLine("Podaj c: "); 
    int c = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Podaj h: "); 
    int h = Convert.ToInt32(Console.ReadLine());

    if (a+b>c && b+c>a && a+c>b ){
     o = a+b+c;
     p = (a*h)/2;
     Console.WriteLine("obwód wynosi:", o);
     Console.WriteLine("pole wynosi:", p);
    } else {
        Console.WriteLine("Nie można skonstruować trójkąta");
    }
    }
}  