using System;
using System.ComponentModel.DataAnnotations;

public class ConsoleApp6
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("Podaj wyraz");
        string wyraz = Console.ReadLine();

        int i = 0;
        int j = wyraz.Length - 1;
        
        bool palindrom = true;

        while(i <j){
            if (wyraz[i] != wyraz[j]){
                palindrom = false;
                break;
            }
            i++;
            j--;
        } 
        if(palindrom){
            Console.WriteLine("Podany wyraz jest palindromem.");
        } else{
             Console.WriteLine("Podany wyraz nie jest palindromem.");
        }

    }
}