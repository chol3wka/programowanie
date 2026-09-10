using System;
using System.Collections;
using System.Collections.Generic;

class Osoba
{
    String nazwisko, imie, ulica, kod, miasto;
    public void Wczytaj()
    {
        Console.WriteLine("Wprowadzamy dane.");
        Console.WriteLine("=================");
        Console.WriteLine("Podaj nazwisko.");
        nazwisko = Console.ReadLine();
        Console.WriteLine("Podaj imie.");
        imie = Console.ReadLine();
        Console.WriteLine("Podaj ulice.");
        ulica = Console.ReadLine();
        Console.WriteLine("Podaj kod.");
        kod = Console.ReadLine();
        Console.WriteLine("Podaj miasto.");
        miasto = Console.ReadLine();
        Console.WriteLine();
    }

    public void Wyswietl()
    {
        Console.WriteLine("Wyświetlanie danych.");
        Console.WriteLine("====================");
        Console.WriteLine("Nazwisko: " + nazwisko);
        Console.WriteLine("Imie: " + imie);
        Console.WriteLine("Ulica: " + ulica);
        Console.WriteLine("Kod: " + kod);
        Console.WriteLine("Miasto: " + miasto);

    }

    static void Main(string[] args)
    {
        Kadra stanowisko = new Kadra();

        stanowisko.Wczytaj1();
        stanowisko.Wyswietl1();
  


    }
}
class Kadra : Osoba
{
    String wyksztalcenie, stanowisko;

    public void Wczytaj1()
    {
        Wczytaj();
        Console.WriteLine("Podaj wykształcenie.");
        wyksztalcenie = Console.ReadLine();
        Console.WriteLine("Podaj stanowisko.");
        stanowisko = Console.ReadLine();

    }
    public void Wyswietl1()
    {
        Wyswietl();
        Console.WriteLine("Wykształcenie: " + wyksztalcenie);
        Console.WriteLine("Stanowisko: " + stanowisko);
        Console.WriteLine();
    }
}
