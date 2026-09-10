class Program
{
    static void Main(String[] args)
    {
        DrawTriangle(5);
    }
    static void DrawTriangle(uint height)
    {
        for (uint i = 0; i <= height; i++)

    {
            for (uint j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}