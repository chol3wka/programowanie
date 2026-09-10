using System;
public class IOString
{
    private string tekst;

    static void Main()
    {
        IOString io = new IOString();
        io.GetString();
        io.PrintString();
        io.IsPalindrome();
    }


    public void GetString()
    {
        Console.WriteLine("Podaj tekst: ");
        tekst = Console.ReadLine();

    }

    public void PrintString()
    {
        Console.WriteLine(tekst.ToUpper());
    }

    public void IsPalindrome()
    {

        int i = 0;
        int j = tekst.Length - 1;

        bool palindrom = true;

        while (i < j)
        {
            if (tekst[i] != tekst[j])
            {
                palindrom = false;
                break;
            }
            i++;
            j--;
        }
        if (palindrom)
        {
            Console.WriteLine("PRAWDA");
        }
        else
        {
            Console.WriteLine("FAŁSZ");
        }

    }
}

