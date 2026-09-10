using System;

public class ConsoleApp5
{
    public static bool Sprawdź(string pierwsze, string drugie)
    {
        if (pierwsze.Length != drugie.Length)
        {
            return false;
        }
        char[] pierwszetab = pierwsze.ToLower().ToCharArray();
        char[] drugietab = drugie.ToLower().ToCharArray();

        Array.Sort(pierwszetab);
        Array.Sort(drugietab);

        for (int i = 0; i < pierwszetab.Length; i++)
        {
            if (pierwszetab[i].ToString() != drugietab[i].ToString())
            {
                return false;
            }
            return true;
        }
    }

    public static void Main(string[] args)
    {
        string pierwsze, drugie;
        Console.WriteLine("Podaj pierwsze słowo.");
        pierwsze = Console.ReadLine();
        string pierwszebs = pierwsze.Replace(" ", "");

        Console.WriteLine("Podaj drugie słowo.");
        drugie = Console.ReadLine();
        string drugiebs = drugie.Replace(" ", "");


        if (Sprawdź(pierwsze, drugie) == true)
        {
            Console.WriteLine("Teksty są anagramami");
        }
        else
        {
            Console.WriteLine("Teksty nie są anagramami");
        }
    }
}

 