
using System;

class BUCKET_SORT
{
  public static void BucketSort(ref int[] dane)
  {
    int Minimum = dane[0];
    int Maksimum = dane[0];
    for (int i = 1; i < dane.Length; i++)
    {
      if (dane[i] > Maksimum)
        Maksimum = dane[i];
      if (dane[i] < Minimum)
        Minimum = dane[i];
    }   
    List<int>[] Kubełek = new List<int>[Maksimum - Minimum + 1];    
    for (int i = 0; i < Kubełek.Length; i++)
    {
      Kubełek[i] = new List<int>();
    }
    for (int i = 0; i < dane.Length; i++)
    {
      Kubełek[dane[i] - Minimum].Add(dane[i]);
    }
    int k = 0;
    for (int i = 0; i < Kubełek.Length; i++)
    {
      if (Kubełek[i].Count > 0)
      {
        for (int j = 0; j < Kubełek[i].Count; j++)
        {
          dane[k] = Kubełek[i][j];
          k++;
        }
      }
    }
  }
    static void Main(string[] args)
  {
    int[] a = new int[] { 9, 10, 8, 6, 1, 5, 3, 4, 2, 7 };        
    
    Console.WriteLine(" Tablica przed sortowaniem");    
    foreach (int liczba in a)
    {
      Console.Write($" {liczba} ");
    }   
    BucketSort(ref a);
    Console.WriteLine();
    Console.WriteLine(" Tablica po sortowaniu");    
    foreach (int liczba in a)
    {
      Console.Write($" {liczba} ");
    }
    Console.WriteLine();
  }
}

