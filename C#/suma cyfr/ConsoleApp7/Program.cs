class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Podaj liczbę");
        int liczba = int.Parse(Console.ReadLine());
        int suma = Calkowita(liczba);

        Console.WriteLine($"Suma cyfr tej liczby to {suma}");

        Console.ReadKey();
    }

    public static int Calkowita(int liczba)
    {
        int suma = 0;

        while (liczba > 0)
        {
            int cyfra = liczba % 10;
            suma += cyfra;
            liczba /= 10;
        }
        return suma;
    }
}


