using System;
using System.Collections;
using System.Collections.Generic;

class Uczen
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public int NumerWKsiedzeUcznia { get; set; }

    public Uczen(string imie, string nazwisko, int numerWKsiedze)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        NumerWKsiedzeUcznia = numerWKsiedze;
    }
    public void WyswietlDane()
    {
        Console.WriteLine($"Imie: {Imie}, Nazwisko: {Nazwisko}, Numer w księdze: {NumerWKsiedzeUcznia}");
    }
}
class Program
{
    static void Main(string[] args)
    {

        List<Uczen> Uczniowie = new List<Uczen>();
        bool dodawanieUczniow = true;

        while (dodawanieUczniow)
        {
            Console.WriteLine("Podaj imie ucznia: ");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj imie nazwisko: ");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj numer w księdze: ");
            int numer;

            while (!int.TryParse(Console.ReadLine(), out numer))
            {
                Console.WriteLine("Podaj poprawny numer!");
            }

            Uczniowie.Add(new Uczen(imie, nazwisko, numer));
            Console.WriteLine("Czy chcesz dodać kolejnego ucznia (tak/nie): ");
            string odpowiedz = Console.ReadLine().ToLower();
            if (odpowiedz != "tak")
            {
                dodawanieUczniow = false;
            }
        }
        Console.WriteLine("\nLista uczniów: ");
        foreach (var uczen in Uczniowie)
        {
            uczen.WyswietlDane();
        }
        Console.ReadKey();
    }
}