using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę: ");
        int liczba =int.Parse(Console.ReadLine());

        Console.Write("Podaj potęgę: ");
        int potega =int.Parse(Console.ReadLine());

        int wynik = Potegowanie(liczba, potega);

        Console.WriteLine($"{liczba}^{potega} = {wynik}");
    }

    static int Potegowanie(int potega, int liczba)
    {

        if (liczba == 0)
        {
            return 1;
        }
        else if (liczba % 2 == 0)
        {
            int y = potega(potega, liczba / 2);
            return y * y;
        }
        else
        {
            return potega * potega(potega, liczba - 1);
        }
    }
}