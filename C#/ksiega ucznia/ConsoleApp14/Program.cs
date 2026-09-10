using System;

class Uczen
{
    public string Imie { get; set;  }
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

    Uczen uczen1 = new Uczen("Jan", "Kowalski", 123);
    Uczen uczen2 = new Uczen("Jan", "Kowalski", 456);

        uczen1.WyswietlDane();
        uczen2.WyswietlDane();
    }
}