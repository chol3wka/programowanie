class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj pierwszą liczbę");
        int liczba1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj drugą liczbę");
        int liczba2 = int.Parse(Console.ReadLine());

        int maksimum = Maksymalna(liczba1, liczba2);

        Console.WriteLine($"Maksimum z podanych liczb to {maksimum}");

        Console.ReadKey();  
    }

    public static int Maksymalna(int liczba1, int liczba2)
    {
        if (liczba1 > liczba2)
        {
            return liczba1;
        }
        else
        { 
            return liczba2;
        }
    }
}