using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Podaj długość pola: ");
            string dlText = Console.ReadLine();
            if (dlText.Contains("."))
            {
                Console.WriteLine("Nie uzywaj kropek! Użyj przecinka");
                return;
            }

            Console.Write("Podaj szerokość pola: ");
            string szText = Console.ReadLine();
            if (szText.Contains("."))
            {
                Console.WriteLine("Nie uzywaj kropek! Użyj przecinka");
                return;
            }


            float dlugosc = float.Parse(dlText, CultureInfo.InvariantCulture);
            float szerokosc = float.Parse(szText, CultureInfo.InvariantCulture);

            SprawdzWartosc(dlugosc, "Długość");
            SprawdzWartosc(szerokosc, "Szerokość");

            float pole = ObliczPole(dlugosc, szerokosc);
            float obwod = ObliczObwod(dlugosc, szerokosc);

            Console.WriteLine($"\nPole = {pole}");
            Console.WriteLine($"Obwód = {obwod}");
        }

        catch (FormatException)
        {
            ObslugaBleduFormatu();
        }
        catch (ArgumentException ex)
        {
            ObslugaBleduZakresu(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Inny błąd: " + ex.Message);
        }

        static float ObliczPole(float a, float b)
        {
            return a * b;
        }

        static float ObliczObwod(float a, float b)
        {
            return 2 * (a + b);
        }

        static void SprawdzWartosc(float wartosc, string nazwa)
        {
            if (wartosc <= 0)
            {
                throw new ArgumentException($"{nazwa} musi być dodatnia.");
            }

            if (wartosc > 100)
            {
                throw new ArgumentException($"{nazwa} nie może być większa od 100.");
            }
        }

        static void ObslugaBleduFormatu()
        {
            Console.WriteLine("Błąd formatu danych.");
            Console.WriteLine("Podaj liczbę rzeczywistą z przecinkiem, np. 12,3");
        }

        static void ObslugaBleduZakresu(string komunikat)
        {
            Console.WriteLine("Błąd zakresu danych.");
            Console.WriteLine(komunikat);
        }
    }
}