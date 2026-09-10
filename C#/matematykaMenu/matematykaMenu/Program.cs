using System;

class Program
{
    static void Main(string[] args)
    {
        int wybor;
        float p, v, k, r, h, l, R;
        bool kontynuuj = true;
        string wynik;

        do
        {
            Console.WriteLine("\n=== OBLICZANIE PÓL I KRAWĘDZI ===");
            Console.WriteLine("1. Prostopadłościan ");
            Console.WriteLine("2. Kula ");
            Console.WriteLine("3. Stożek ");
            Console.WriteLine("4. Walec ");
            Console.WriteLine("5. Beczka ");
            Console.WriteLine("6. Wyjście ");

            wybor = WczytajInt("Wybierz opcję: ", 1, 6);

            switch (wybor)
            {

                case 1:
                    bool kontynuuj1 = true;
                    while (kontynuuj1)
                    {

                        float a = WczytajFloat("Podaj a\n");
                        float b = WczytajFloat("Podaj b\n");
                        float c = WczytajFloat("Podaj c\n");

                        v = a * b * c;
                        p = 2 * ((a * b) + (b * c) + (a * c));
                        k = 4 * (a + b + c);
                        wynik = $"======Prostopadłościan======\nObjętość wynosi: {Math.Round(v, 2)}m³. \nPole powierzchni wynosi: {Math.Round(p, 2)}m². \nSuma krawędzi: {Math.Round(k, 2)}cm.\n";
                        Console.WriteLine(wynik);
                        File.AppendAllText("wynik.txt", wynik);

                        Console.WriteLine("Liczyć dalej? (1/2)");
                        int decyzja = WczytajInt("1 - Tak, 2 - Powrót do menu: ", 1, 2);
                        if (decyzja == 2) kontynuuj1 = false;
                    }
                    break;
                case 2:
                    bool kontynuuj2 = true;
                    while (kontynuuj2)
                    {
                        
                        r = WczytajFloat("Podaj promień kuli\n");

                        v = (float)((4.0 / 3.0) * Math.PI * Math.Pow(r, 3));
                        p = (float)(4 * Math.PI * (r * r));
                        wynik = $"======Kula======\nObjętość wynosi: {Math.Round(v, 2)}m³. \nPole powierzchni wynosi: {Math.Round(p, 2)}m².\n";
                        Console.WriteLine(wynik);
                        File.AppendAllText("wynik.txt", wynik);
                        Console.WriteLine("Liczyć dalej? (1/2)");
                        int decyzja = WczytajInt("1 - Tak, 2 - Powrót do menu: ", 1, 2);
                        if (decyzja == 2) kontynuuj2 = false;

                    }

                    break;
                case 3:
                    bool kontynuuj3 = true;
                    while (kontynuuj3)
                    {
                        r = WczytajFloat("Podaj promień.\n");
                        h=WczytajFloat("Podaj wysokość.\n");
                        l=WczytajFloat("Podaj krawędź boczną.\n");
                        
                        v = (float)((1f / 3f) * Math.PI * (r * r) * h);
                        p = (float)((Math.PI * (r * r)) + (Math.PI * r * l));

                        wynik = $"======Stożek======\nObjętość wynosi: {Math.Round(v, 2)}m³. \nPole powierzchni wynosi: {Math.Round(p, 2)}m².\n";
                        Console.WriteLine(wynik);
                        File.AppendAllText("wynik.txt", wynik);

                        Console.WriteLine("Liczyć dalej? (1/2)");
                        int decyzja = WczytajInt("1 - Tak, 2 - Powrót do menu: ", 1, 2);
                        if (decyzja == 2) kontynuuj3 = false;

                    }

                    break;
                case 4:
                    bool kontynuuj4 = true;
                    while (kontynuuj4)
                    {
                        r = WczytajFloat("Podaj promień.\n");
                        h = WczytajFloat("Podaj wysokość.\n");

                        v = (float)(Math.PI * (r * r) * h);

                        p = (float)(((2 * Math.PI) * (r * r)) + ((2 * Math.PI) * r * h));
                        wynik = $"======Walec======\nObjętość wynosi: {Math.Round(v, 2)} m³.\nPole powierzchni wynosi:  {Math.Round(p, 2)}m².\n";
                        Console.WriteLine(wynik);
                        File.AppendAllText("wynik.txt", wynik);

                        Console.WriteLine("Liczyć dalej? (1/2)");
                        int decyzja = WczytajInt("1 - Tak, 2 - Powrót do menu: ", 1, 2);
                        if (decyzja == 2) kontynuuj4 = false;
                    }
                    break;
                case 5:
                    bool kontynuuj5 = true;
                    while (kontynuuj5)
                    {
                        h = WczytajFloat("Podaj wysokość.\n");
                        r = WczytajFloat("Podaj promień beczki w najwęższym punkcie.\n");
                        R = WczytajFloat("Podaj promień beczki w najszerszym punkcie.\n");
                        
                        v = (float)(((Math.PI * h) / 15) * ((8 *(R*R)) + (4 * r * R) + (3 * (r*r))));

                        wynik = $"======Beczka======\nObjętość wynosi: {Math.Round(v,2)}m³.\n";
                        Console.WriteLine(wynik);
                        File.AppendAllText("wynik.txt", wynik);

                        Console.WriteLine("Liczyć dalej? (1/2)");
                        int decyzja = WczytajInt("1 - Tak, 2 - Powrót do menu: ", 1, 2);
                        if (decyzja == 2) kontynuuj5 = false;
                    }
                    break;
                case 6:
                    Console.WriteLine("Zamykanie programu.");
                    return;
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
    static float WczytajFloat(string tekst)
    {
        float liczba;
        while (true)
        {
            Console.Write(tekst);

            if (!float.TryParse(Console.ReadLine(), out liczba))
            {
                Console.WriteLine("Błąd. Podaj liczbę.");
                continue;
            }
            return liczba;
        }
    }
}