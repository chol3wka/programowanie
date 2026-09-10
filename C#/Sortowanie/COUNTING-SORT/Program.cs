using System;
class COUNTING_SORT
{
  static void Main(string[] args)
  {    
    int[] a = new int[] { 
      10, 5, 7, 6, 9, 1, 9, 6, 8, 5, 8, 
      7, 8, 7, 6, 3, 6, 7, 6, 2, 4, 5 };
    int[] count = new int[] 
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    int L = a.Length;
    int N = count.Length;
    Console.WriteLine(" Przed sortowaniem");
    foreach (int liczba in a)
    {
      Console.Write($" {liczba}");
    }
    for (int i = 0; i < L; i++) 
    {
      count[a[i]]++;
    }
    Console.WriteLine();
    Console.WriteLine(" Tablica count");
    for (int index=0; index<N; index++)
    {
      Console.WriteLine($" count[{index}]={count[index]} ");
    }
    int c = 1;
    for (int i = 1; i < N; i++)
    {
      if(count[i]>0)
      {
        for (int k=1; k <= count[i]; k++)
        {
          a[c-1] = i;
          c++;
        }
      }
    }
    Console.WriteLine();
    Console.WriteLine(" Po sortowaniu");
    foreach (int liczba in a)
    {
      Console.Write($" {liczba}");
    }
  }
}

