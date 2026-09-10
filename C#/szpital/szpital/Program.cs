using System;
using System.Collections.Generic;

class Program
{
    class Zabieg
    {
        public string Nazwa { get; set; }
        public string Wymagania { get; set; }
        public int CzasTrwania { get; set; }
        public DateTime Termin { get; set; }
        public Lekarz Lekarz { get; set; }

        public Zabieg(string nazwa, string wymagania, int czas, DateTime termin)
        {
            Nazwa = nazwa;
            Wymagania = wymagania;
            CzasTrwania = czas;
            Termin = termin;
        }
        public string Opis()
        {
            return $"{Nazwa} ({Wymagania}) - {Termin}, {CzasTrwania} min, Lekarz: {(Lekarz?.Nazwisko ?? "brak")}";
        }
        class Pacjent
        {
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public string PESEL { get; set; }
            public string Status { get; set; }
            public List<Zabieg> Zabiegi { get; set; }

            public Pacjent(string imie, string nazwisko, string pesel)
            {
                Imie = imie;
                Nazwisko = nazwisko;
                PESEL = pesel;
            }
            public void DodajZabieg(Zabieg z)
            {
                Zabiegi.Add(z);
            }
            public void Wypisz()
            {
                Status = "wypisany";
            }
            public string Opis()
            {
                return $"{Imie} {Nazwisko} ({PESEL}) - {Status}";
            }

        }
        class Lekarz
        {
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public string Specjalizacja { get; set; }
            public Lekarz(string imie, string nazwisko, string specjalizacja)
            {
                Imie = imie;
                Nazwisko = nazwisko;
                Specjalizacja = specjalizacja;
            }
            public string Opis()
            {
                return $"{Imie} {Nazwisko} - {Specjalizacja}";
            }
        }

    }
    public class Oddzial
    {
        public string nazwa { get; set; }
        public int LiczbaLozek { get; set; }
        public List<string> Lekarze { get; set; } = new List<string>();
        public List<string> Pacjenci { get; set; } = new List<string>();

        public Oddzial(string NazwaOddzialu, int LiczbaLozek)
        {
            NazwaOddzialu = nazwa;
            LiczbaLozek = lozka;

        }
        public bool CzySaWolneLozka()
        {
            return Pacjenci.Count(p => p.Status == "Przyjęty") < LiczbaLozek;
        }
        public void DodajLekarza(Lekarz 1)
        {
            Lekarze.Add(1);
        }
        public bool PrzyjmijPacjenta(Pacjent p)
        {
            if (!CzySaWolneLozka())
                return false;

            Pacjenci.Add(p);
            return true;
        }
        public void WypiszPacjenta(string pesel)
        {
            var p = Pacjenci.FirstOrDefault(x => x.PESEL == pesel);
            if (p != null) p.Wypisz();
        }
        public void PokazStan()
        {
            Console.WriteLine($"\n Oddział: {nazwa}");
            Console.WriteLine($"Łóżka: {Pacjenci.Count(p => p.Status == "przyjęty")}/{LiczbaLozek}");

            Console.WriteLine("\nPacjenci: ");
            foreach (var p in Pacjenci)
                Console.WriteLine(p.Opis());
            foreach (var l in Lekarze)
                Console.WriteLine(l.Opis());
        }
    }


    public class Szpital
    {
        public List<string> Oddzialy { get; set; } = new List<Oddzial>();
        public void DodajOddzial (Oddzial o)
        {
            Oddzialy.Add(o);
        }
        public void ZnajdzOddzial(string nazwa)
        {

        }
        public void PokazStan()
        {
            foreach(var o in Oddzialy) {
                o.PokazStan();
        }
    }
      
       

        public static void Main(string[] args)
    {

        while (true){

            Console.WriteLine("====SZPITAL====");
            Console.WriteLine("Wybierz opcję z poniższych:");
            Console.WriteLine("1. Dodaj oddział");
            Console.WriteLine("2. Dodaj lekarza");
            Console.WriteLine("3. Dodaj pacjenta");
            Console.WriteLine("4. Zaplanuj zabieg");
            Console.WriteLine("5. Wypisz pacjenta z oddziału");
            Console.WriteLine("6. Pokaż stan szpitala");
            Console.WriteLine("0. Wyjście");

            var wybor = Console.ReadLine();


                switch (wybor) {
                    case (1):
                        void DodajOddzial() {
                            Console.WriteLine("Podaj nazwę oddziału");
                            string NazwaOdzialu = Console.ReadLine();
                            Console.WriteLine("Podaj ilość łóżek");
                            int LiczbaLozek = int.Parse(Console.ReadLine());
                            Szpital.DodajOddzial(new Oddzial(NazwaOdzialu, LiczbaLozek));
                            break;
                        }
                    case (2):
                        {
                            Console.WriteLine("Oddział: ");
                            var Oddzial = Szpital.ZnajdzOddzial(Console.ReadLine);
                            if (Oddzial == null) break;

                            Console.WriteLine("Imie: ");
                            var imie = Console.ReadLine();
                            Console.WriteLine("Nazwisko: ");
                            var nazwisko = Console.ReadLine();
                            Console.WriteLine("Specjalizacja: ");
                            var specjalizacja = Console.ReadLine();

                            Oddzial.DodajLekarza(new Lekarz(imie, nazwisko, specjalizacja));
                            break;
                        }
                    case (3):
                        {
                            Console.WriteLine("Oddział: ");
                            var Oddzial = Szpital.ZnajdzOddzial(Console.ReadLine);
                            if (Oddzial == null) break;

                            Console.WriteLine("Imie: ");
                            var imie = Console.ReadLine();
                            Console.WriteLine("Nazwisko: ");
                            var nazwisko = Console.ReadLine();
                            Console.WriteLine("PESEL: ");
                            var pesel = Console.ReadLine();

                            if (!Oddzial.PrzyjmijPacjenta((new Pacjent(imie, nazwisko, pesel)){
                                Console.WriteLine("Brak wolnych łóżek.");
                            }
                            break;
                        }
                    case (4):
                        { 
                        Console.WriteLine("Oddział: ");
                        var Oddzial = Szpital.ZnajdzOddzial(Console.ReadLine);
                        if (Oddzial == null) break;

                        Console.WriteLine("Podaj PESEL pacjenta: ");
                        var pesel = Console.ReadLine();

                        var Pacjent = Oddzial.Pacjenci.FirstOrDefault(p => p.pesel == pesel);
                        if (Pacjent == null) break;

                        Console.WriteLine("Nazwa zabiegu: ");
                        var nazwaZabiegu = Console.ReadLine();
                        var Zabieg = new Zabieg(nazwaZabiegu, "ogólne", 60, DateTime.Now.AddDays(1));
                        Pacjent.DodajZabieg(Zabieg);
                        break;
                        }
                    case (5):
                        {
                            Console.WriteLine("Oddział: ");
                            var Oddzial = Szpital.ZnajdzOddzial(Console.ReadLine);
                            if (Oddzial == null) break;

                            Console.WriteLine("Podaj PESEL: ");
                            var pesel = Console.ReadLine();

                            Oddzial.WypiszPacjenta(pesel);
                            break;
                        }
                    case (6):
                        {
                            Szpital.PokazStan();
                            break;
                        }
                    case (0):
                        {
                            return;
                        }
                }
        }

    }

}

}