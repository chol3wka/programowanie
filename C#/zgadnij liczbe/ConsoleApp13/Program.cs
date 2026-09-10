using System;

class Program
{
    static void Main(String[] args)
    {
        Random random = new Random();

        int wylosowanaLiczba = random.Next(0, 100);
        int proby = 0;

        List<int> zgadniecia = new List<int>();

        Console.WriteLine("Podaj swoje imie");
        string imie =Console.ReadLine();

        Console.WriteLine($"Witaj, {imie}! Spróbuj odgadnąć liczbę z zakresu 0-99.");

        while (true)
        {
            Console.WriteLine("Podaj liczbę");
            string proba = Console.ReadLine();
            if (int.TryParse(proba, out int sprawdzanaliczba))
            {
                zgadniecia.Add(sprawdzanaliczba);
                proby++;
                if (sprawdzanaliczba < wylosowanaLiczba)
                {
                    Console.WriteLine("Szukana liczba jest większa. Spróbuj ponownie.");
                }
                else if (sprawdzanaliczba > wylosowanaLiczba)
                {
                    Console.WriteLine("Szukana liczba jest mniejsza. Spróbuj ponownie.");
                }
                else
                {
                    Console.WriteLine($"Brawo {imie}! Udało Ci się odgadnąć liczbę {wylosowanaLiczba}!");
                    Console.WriteLine("Podsumowanie: ");
                    Console.WriteLine($" - Liczba prób: {proby}");
                    Console.WriteLine(" - Twoje sprawdzane liczby: " + string.Join(", ", zgadniecia));
                    Console.WriteLine("Naciśnij dowolny klawisz aby zakończyć.");
                    Console.ReadKey();
                }

            }
            else
            {
                Console.WriteLine("Wpisano niepoprawną liczbę. Spróbuj ponownie.");
            }
        }
    }
}