using System;
using System.Collections;
using System.Collections.Generic;
class Program
{

    private double a,b,c;
    private double x1, x2, delta;
    private int pierwiastki;
    
    static void Main(string[] args)
    {
        Program rownanie = new Program();
        rownanie.Czytaj_dane();
        rownanie.Przetworz_dane();
        rownanie.Wyswietl_wynik();
    }
    private void Czytaj_dane()
    {
        Console.WriteLine("Podaj wartość a");
        a = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("To nie jest równanie kwadatowe");
            Environment.Exit(0);
        }
        Console.WriteLine("Podaj wartość b");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wartość c");
        c = double.Parse(Console.ReadLine());
    }

    public void Przetworz_dane()
    {
        delta = (b * b) - 4 * a * c;
        if (delta > 0)
        {
            pierwiastki = 2;
            x1 = (b*(-1) - Math.Sqrt(delta)) / (2 * a);
            x2 = (b*(-1) + Math.Sqrt(delta)) / (2 * a);
        }
        else if (delta == 0)
        {
            pierwiastki = 1;
            x1 = (-b) / (2 * a);
        }
        else
        {
            pierwiastki = 0;
        }
        
    }
    public void Wyswietl_wynik()
    {
        switch (pierwiastki)
        {
            case 0:
                Console.WriteLine("Równanie nie ma pierwiastków (delta= " + delta + ", czyli jest mniejsza niż 0)");
                break;
            case 1:
                Console.WriteLine("Równanie ma jeden pierwiastek: x1= " + Math.Round(x1, 2));
                break;
            case 2:
                Console.WriteLine("Równanie ma dwa pierwiastki: x1 = " + Math.Round(x1, 2) + " x2= "+ Math.Round(x2, 2));
                break;
        }
    }
}