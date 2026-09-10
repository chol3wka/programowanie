class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine(Sum(5));
    }
    static int Sum(int n)
    {
        if (n > 0)
        {
            return n + Sum(n - 1);
        }
        else
        {
            return 0;
        }
    }
}