using System;

class STUPID_SORT
{
  static void Main(string[] args)
  {
    int[] a = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

    Console.WriteLine(" Tablica przed sortowaniem");
    Console.WriteLine();
    foreach (int liczba in a)
    {
      Console.Write($" {liczba} ");
    }
    int L = 10, i = 0;
    int temp;
    while (i < (L - 1))
    {
      if (a[i] > a[i + 1])
      {
        temp = a[i];
        a[i] = a[i + 1];
        a[i + 1] = temp;
        i = 0;
      }
      else { i++; }
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine(" Tablica po sortowaniu");
    Console.WriteLine();
    foreach (int liczba in a)
    {
      Console.Write($" {liczba} ");
    }
  }
}

