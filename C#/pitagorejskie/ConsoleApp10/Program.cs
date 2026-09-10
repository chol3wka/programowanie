class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Podaj pierwszą liczbę.");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj drugą liczbę.");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj trzecią liczbę.");
        int c = int.Parse(Console.ReadLine());

        bool czypitagorejskie = Pitagorejskie(a,b,c);

        Console.WriteLine(czypitagorejskie);

    }
    public static bool Pitagorejskie(int a, int b, int c)
    {
        if (a * a + b * b == c * c)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}