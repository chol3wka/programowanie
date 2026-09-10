using System;
using System.Net.NetworkInformation;

public class consoleapp3
{
    public static void Main(string[] args){
    
    int sum = 0; 

    for (int i = 1; i <= 100; i++) 
    { 
    sum +=i;
    }
    Console.WriteLine("Suma wynosi: " + sum.ToString());
    }
}