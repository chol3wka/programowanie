using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

abstract class Zagadka
{
    public string Opis { get; protected set; }
    public string Podpowiedz { get; protected set; }
    public abstract bool SprawdzOdpowiedz(string odp);
}

class HasloZagadka : Zagadka
{
    private string haslo;
    public HasloZagadka(string opis, string haslo, string podpowiedz)
    {
        Opis = opis;
        this.haslo = haslo.ToLower();
        Podpowiedz = podpowiedz;
    }
    public override bool SprawdzOdpowiedz(string odp) => odp.ToLower() == haslo;
}

class MatematycznaZagadka : Zagadka
{
    private int wynik;
    public MatematycznaZagadka(string opis, int wynik, string podpowiedz)
    {
        Opis = opis;
        this.wynik = wynik;
        Podpowiedz = podpowiedz;
    }
    public override bool SprawdzOdpowiedz(string odp)
    {
        return int.TryParse(odp, out int x) && x == wynik;
    }
}

class Pokoj
{
    public string Nazwa { get; set; }
    public string OpisWejscia { get; set; }
    public List<Zagadka> Zagadki { get; set; } = new List<Zagadka>();

    public bool Rozegraj(ref int punkty, ref int podpowiedzi, Stopwatch timer)
    {
        Console.WriteLine($"\n=== {Nazwa} ===");
        Console.WriteLine(OpisWejscia);

        foreach (var z in Zagadki)
        {
            while (true)
            {
                Console.WriteLine($"\nCzas: {FormatCzas(timer.Elapsed)} | Punkty: {punkty} | Podpowiedzi: {podpowiedzi}");
                Console.WriteLine(z.Opis);
                Console.WriteLine("UWAGA! Odpowiedzi wpisuj bez polskich znakow!");
                Console.Write("Odpowiedz (w razie trudnosci wpisz 'podpowiedz'): ");
                var odp = Console.ReadLine();

                if (odp.ToLower() == "podpowiedz")
                {
                    if (podpowiedzi > 0)
                    {
                        podpowiedzi--;
                        Console.WriteLine($"Podpowiedz: {z.Podpowiedz}");
                    }
                    else
                    {
                        Console.WriteLine("Nie masz juz podpowiedzi");
                    }
                    continue;
                }

                if (!z.SprawdzOdpowiedz(odp))
                    return false;

                punkty += 10;
                break;
            }
        }
        return true;
    }

    private string FormatCzas(TimeSpan t) => $"{t.Minutes:D2}:{t.Seconds:D2}";
}

class Gra
{
    private List<Pokoj> pokoje = new List<Pokoj>();
    private int punkty;
    private int podpowiedzi = 3;
    private Stopwatch timer = new Stopwatch();
    private int limitSekund;

    public Gra(int limitSekund)
    {
        this.limitSekund = limitSekund;
    }

    public void DodajPokoj(Pokoj p) => pokoje.Add(p);

    public void Start()
    {
        bool grajPonownie = true;

        while (grajPonownie)
        {
            punkty = 0;
            podpowiedzi = 3;
            timer.Reset();

            Console.Clear();
            Console.WriteLine("ESCAPE ROOM – STARY DOM");
            Console.WriteLine("Budzisz sie w starym, skrzypiaceym domu. Drzwi wejściowe sa zamkniete.\n");
            timer.Start();

            bool przegrana = false;

            foreach (var p in pokoje)
            {
                if (timer.Elapsed.TotalSeconds >= limitSekund)
                {
                    Przegrana("Czas minąl. Dom zatrzaskuje drzwi");
                    przegrana = true;
                    break;
                }

                if (!p.Rozegraj(ref punkty, ref podpowiedzi, timer))
                {
                    Przegrana("Mechanizm sie zacina. Zostajesz w domu na zawsze");
                    przegrana = true;
                    break;
                }

                if (p != pokoje[pokoje.Count - 1])
                    Console.WriteLine("\nDrzwi skrzypia i otwieraja sie dalej");
            }

            if (!przegrana)
                Wygrana();

            Console.Write("\nCzy chcesz sprobowac ponownie? (tak/nie): ");
            var odp = Console.ReadLine().ToLower();
            grajPonownie = odp == "tak";
        }
    }

    private void Przegrana(string powod)
    {
        timer.Stop();
        Console.WriteLine("\nPRZEGRANA");
        Console.WriteLine(powod);
        Console.WriteLine($"Punkty: {punkty}");
        Console.WriteLine($"Czas gry: {FormatCzas(timer.Elapsed)}");
        Console.WriteLine($"Wykorzystane podpowiedzi: {3 - podpowiedzi}");
        Zapisz("przegrana");
    }

    private void Wygrana()
    {
        timer.Stop();
        Console.WriteLine("\nWYGRANA");
        Console.WriteLine("Wychodzisz z domu. Drzwi zamykaja sie za Toba. Jestes wolny!");
        Console.WriteLine($"Punkty: {punkty}");
        Console.WriteLine($"Czas gry: {FormatCzas(timer.Elapsed)}");
        Console.WriteLine($"Wykorzystane podpowiedzi: {3 - podpowiedzi}");
        Zapisz("wygrana");
    }

    private void Zapisz(string status)
    {
        var dane = new
        {
            Status = status,
            Punkty = punkty,
            CzasSekundy = (int)timer.Elapsed.TotalSeconds,
            PozostalePodpowiedzi = podpowiedzi
        };
        File.WriteAllText("wynik.json", JsonSerializer.Serialize(dane, new JsonSerializerOptions { WriteIndented = true }));
    }

    private string FormatCzas(TimeSpan t) => $"{t.Minutes:D2}:{t.Seconds:D2}";
}

class Program
{
    static void Main()
    {
        var gra = new Gra(600);

        var hol = new Pokoj
        {
            Nazwa = "Hol",
            OpisWejscia = "Stoisz w ciemnym holu. Na wieszaku wisi stary plaszcz."
        };
        hol.Zagadki.Add(new HasloZagadka(
            "Co ma klucz, ale nie otwiera drzwi?",
            "fortepian",
            "To instrument muzyczny"));

        var kuchnia = new Pokoj
        {
            Nazwa = "Kuchnia",
            OpisWejscia = "W kuchni czuc zapach kurzu. Na stole lezy kartka."
        };
        kuchnia.Zagadki.Add(new MatematycznaZagadka(
            "Masz 5 kromek chleba. Zjadasz polowe. Ile zostaje?",
            5,
            "Pytanie jest podchwytliwe"));

        var lazienka = new Pokoj
        {
            Nazwa = "Lazienka",
            OpisWejscia = "Lustro jest zaparowane. Na kafelkach widac napis palcem."
        };
        lazienka.Zagadki.Add(new HasloZagadka(
            "Im bardziej mnie myjesz, tym bardziej jestem brudny. Co to?",
            "woda",
            "To cos, czym myjesz"));

        var sypialnia = new Pokoj
        {
            Nazwa = "Sypialnia",
            OpisWejscia = "Stare lozko skrzypi. Na stoliku nocnym lezy zegarek."
        };
        sypialnia.Zagadki.Add(new MatematycznaZagadka(
            "Jest 22:00. Ile godzin minie do polnocy?",
            2,
            "Polnoc to 00:00"));

        var strych = new Pokoj
        {
            Nazwa = "Strych",
            OpisWejscia = "Na strychu pelno pajeczyn. W skrzyni jest ostatni zamek."
        };
        strych.Zagadki.Add(new HasloZagadka(
            "Co nalezy do Ciebie, ale inni uzywaja tego czesciej?",
            "imie",
            "To cos, czym sie przedstawiasz"));

        var piwnica = new Pokoj
        {
            Nazwa = "Piwnica",
            OpisWejscia = "W piwnicy jest ciemno. Slyszysz kapanie wody."
        };
        piwnica.Zagadki.Add(new HasloZagadka(
            "Co mozna otworzyc tylko raz w zyciu?",
            "jajko",
            "Jest spozywcze"));

        var garaz = new Pokoj
        {
            Nazwa = "Garaz",
            OpisWejscia = "Garaz jest pelny starych narzedzi."
        };
        garaz.Zagadki.Add(new MatematycznaZagadka(
            "Masz 12 srub. Rozdzielasz je rownomiernie do 3 pudelek. Ile w kazdym pudeleczku?",
            4,
            "Podziel 12 przez 3"));

        gra.DodajPokoj(hol);
        gra.DodajPokoj(kuchnia);
        gra.DodajPokoj(lazienka);
        gra.DodajPokoj(sypialnia);
        gra.DodajPokoj(strych);
        gra.DodajPokoj(piwnica);
        gra.DodajPokoj(garaz);

        gra.Start();
    }
}
