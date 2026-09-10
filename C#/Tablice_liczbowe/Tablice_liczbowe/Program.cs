using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj ilość liczb do wygenerowania. (Zakres 10-50)");
        int iloscLiczb = int.Parse(Console.ReadLine());
        

        if (iloscLiczb > 50 || iloscLiczb < 10)
        {
            Console.WriteLine("Podaj poprawną ilość liczb według zakresu 10-50.");
            return;
        }
        else
        {
            int[] Liczby = new int[iloscLiczb];
            File.WriteAllText("tablica.txt", "Rozmiar tablicy: " + iloscLiczb + "\n");
            for (int i = 0; i < iloscLiczb; i++)
            {
                Liczby[i] = new Random().Next(1, 200);
            }
            Console.WriteLine("- Wygenerowane liczby: ");
            int x = 0;
            foreach (int Liczba in Liczby)
            {
                Console.Write(" " + Liczba + " ");
                x++;
                if (x % 5 == 0)
                {
                    Console.WriteLine("");
                }
 
            }
            File.AppendAllText("tablica.txt", "Wygenerowane liczby " +  string.Join(", ", Liczby) + "\n");
            Console.WriteLine("");
            Console.WriteLine("- Średnia z liczb:" + Liczby.Average());
            File.AppendAllText("tablica.txt", "Średnia liczb: " + Liczby.Average() + "\n");
            Console.WriteLine("- Suma liczb: " + Liczby.Sum());
            File.AppendAllText("tablica.txt", "Suma liczb: " + Liczby.Sum() + "\n");
            Console.WriteLine("- Największa liczba: " + Liczby.Max());
            File.AppendAllText("tablica.txt", "Największa z liczb: " + Liczby.Max() + "\n");
            Console.WriteLine("- Najmniejsza liczba: " + Liczby.Min());
            File.AppendAllText("tablica.txt", "Najmniejsza z liczb: " + Liczby.Min() + "\n");
            Liczby.Sort();
            Console.WriteLine("");
            Console.WriteLine("- Posortowane liczby: ");
            x = 0;
            foreach (int Liczba in Liczby)
            {
                x++;
                Console.Write(" " + Liczba + " ");
                if (x % 5 == 0) Console.WriteLine("");
            }
            File.AppendAllText("tablica.txt", "Posortowane liczby: " + string.Join(", ", Liczby) + "\n");
        }
    }
}