using System;

class BOGO_SORT
{

  private static bool JestPosortowana(ref int[] tab)
  {
    int c = tab.Length;
    while (--c >= 1)
      if (tab[c] < tab[c - 1]) return false;
    return true;
  }
  static void Main(string[] args)
  {    
    int[] a = new int[] { 9, 10, 8, 6, 1, 5, 3, 4, 2, 7 };
    Random rand = new Random();
    Console.WriteLine("Tablica przed sortowaniem");
    Console.WriteLine();
    foreach (int liczba in a)
    {
      Console.Write($"{liczba} ");
    }    
    int L = 10;
    int temp;
    bool posortowane = false;
    while (posortowane == false) 
    {      
      for (int r = 1; r<=3; r++)
      {
        int j = rand.Next(L);
        int k = rand.Next(L);
        temp = a[j];
        a[j] = a[k];
        a[k] = temp;
      }

      posortowane = JestPosortowana(ref a);
    }    
    
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Tablica po sortowaniu");
    Console.WriteLine();
    foreach (int liczba in a)
    {
      Console.Write($"{liczba} ");
    }
    Console.WriteLine();
  }
}

