using System;

class Program
{
    static void Main(string[] args)
    {
        string[] przedmioty = { "Polski", "Matematyka", "Angielski", "Fizyka", "Chemia", "Biologia", "Geografia", "Historia", "WF", "Niemiecki" };

        double[,] oceny = new double[10, 50];
        int[] liczbaocen = new int[10];

        int wybor;

        do
        {
            Console.WriteLine("\n=== SYSTEM OCENIANIA UCZNIA ===");
            Console.WriteLine("1. Dodaj ocenę");
            Console.WriteLine("2. Wyświetl wszystkie oceny");
            Console.WriteLine("3. Oblicz średnią ocen");
            Console.WriteLine("4. Pokaż najwyższą i najniższą ocenę");
            Console.WriteLine("5. Wyszukaj oceny z przedmiotu");
            Console.WriteLine("6. Wyczyść dane");
            Console.WriteLine("0. Wyjście");

            wybor = WczytajInt("Wybierz opcję: ", 0, 6);

            switch (wybor)
            {
                case 1: 
                    DodajOcene(przedmioty, liczbaocen, oceny);
                    break;
                case 2:
                    WyswietlOceny(przedmioty, liczbaocen, oceny);
                    break;
                case 3: 
                    SredniaOcen(liczbaocen, oceny);
                    break;
                case 4: 
                    PokazMinMax(liczbaocen, oceny);
                    break;
                case 5: 
                    WyswietlOcenyPrzedmiot(przedmioty, liczbaocen, oceny);
                    break;
                case 6:
                    Array.Clear(oceny, 0, oceny.Length);
                    Array.Clear(liczbaocen, 0, liczbaocen.Length);
                    Console.WriteLine("Dane wyczyszczone.");
                    break;
                case 0:
                    Console.WriteLine("Zamykanie programu...");
                    break;
            }

        } while (wybor != 0);
    }

    static int WczytajInt(string tekst, int min, int max)
    {
        int liczba;

        while (true)
        {
            Console.Write(tekst);
            if (!int.TryParse(Console.ReadLine(), out liczba))
            {
                Console.WriteLine("Błąd: podaj liczbę.");
                continue;
            }

            if (liczba < min || liczba > max)
            {
                Console.WriteLine($"Błąd: liczba musi być z zakresu {min}-{max}.");
                continue;
            }

            return liczba;
        }
    }

    static double WczytajDouble(string tekst, double min, double max)
    {
        double liczba;

        while (true)
        {
            Console.Write(tekst);
            if (!double.TryParse(Console.ReadLine(), out liczba))
            {
                Console.WriteLine("Błąd: podaj liczbę.");
                continue;
            }

            if (liczba < min || liczba > max)
            {
                Console.WriteLine($"Błąd: liczba musi być z zakresu {min}-{max}.");
                continue;
            }

            return liczba;
        }
    }

    static void DodajOcene(string[] przedmioty, int[] liczbaocen, double[,] oceny)
    {
        bool kontynuuj = true;

        while (kontynuuj)
        {
            Console.WriteLine("Wybierz przedmiot:");

            for (int i = 0; i < przedmioty.Length; i++)
                Console.WriteLine($"{i + 1}. {przedmioty[i]}");

            int przedmiot = WczytajInt("Twój wybór: ", 1, przedmioty.Length) - 1;
            double ocena = WczytajDouble("Podaj ocenę (1-6): ", 1, 6);

            oceny[przedmiot, liczbaocen[przedmiot]] = ocena;
            liczbaocen[przedmiot]++;

            Console.WriteLine("Ocena dodana.");

            int decyzja = WczytajInt("1 - Dodaj kolejną, 2 - Powrót do menu: ", 1, 2);
            if (decyzja == 2) kontynuuj = false;
        }
    }

    static void WyswietlOceny(string[] przedmioty, int[] liczbaocen, double[,] oceny)
    {
        for (int i = 0; i < przedmioty.Length; i++)
        {
            Console.Write($"\n{przedmioty[i]}: ");

            if (liczbaocen[i] == 0)
            {
                Console.WriteLine("brak ocen");
                continue;
            }

            for (int j = 0; j < liczbaocen[i]; j++)
                Console.Write(oceny[i, j] + " ");

            Console.WriteLine();
        }
    }

    static void SredniaOcen(int[] liczbaocen, double[,] oceny)
    {
        double suma = 0;
        int ilosc = 0;

        for (int i = 0; i < liczbaocen.Length; i++)
            for (int j = 0; j < liczbaocen[i]; j++)
            {
                suma += oceny[i, j];
                ilosc++;
            }

        if (ilosc == 0)
        {
            Console.WriteLine("Brak ocen.");
            return;
        }

        Console.WriteLine($"Średnia ocen = {suma / ilosc:F2}");
    }

    static void PokazMinMax(int[] liczbaocen, double[,] oceny)
    {
        double min = 6;
        double max = 1;
        bool jest = false;

        for (int i = 0; i < liczbaocen.Length; i++)
        {
            for (int j = 0; j < liczbaocen[i]; j++)
            {
                double ocena = oceny[i, j];
                jest = true;

                if (ocena < min) min = ocena;
                if (ocena > max) max = ocena;
            }
        }

        if (!jest)
        {
            Console.WriteLine("Brak ocen.");
            return;
        }

        Console.WriteLine($"Najniższa: {min}, najwyższa: {max}");
    }

    static void WyswietlOcenyPrzedmiot(string[] przedmioty, int[] liczbaocen, double[,] oceny)
    {
        Console.WriteLine("Wybierz przedmiot:");

        for (int i = 0; i < przedmioty.Length; i++)
            Console.WriteLine($"{i + 1}. {przedmioty[i]}");

        int przedmiot = WczytajInt("Twój wybór: ", 1, przedmioty.Length) - 1;

        Console.WriteLine($"\nOceny z {przedmioty[przedmiot]}:");

        if (liczbaocen[przedmiot] == 0)
        {
            Console.WriteLine("Brak ocen");
            return;
        }

        for (int j = 0; j < liczbaocen[przedmiot]; j++)
            Console.Write(oceny[przedmiot, j] + " ");

        Console.WriteLine();
    }
}