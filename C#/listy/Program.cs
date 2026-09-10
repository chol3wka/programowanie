using System;

public class Listy
{
    public static void Main(string[] args) 
    {
        List<string>animals = new List<string>();

        animals.Add("piesek");
        animals.Add("kotek");
        animals.Add("żółw");
        animals.Add("świnka");

        Console.WriteLine(animals[2]);
    }
}  