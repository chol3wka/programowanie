using System;

public class Slownik
{
    public static void Main(string[] args) 
    {
         Dictionary<string,int> numery = new Dictionary<string, int>(){
            {"Policja", 997},
            {"Straż", 998},
            {"Pogotowie", 999},
            {"Numer alarmowy", 112},
         };
        foreach (var element in numery){
            Console.WriteLine($"{element.Key} : {element.Value}");
        }
    }
}  