using System;

class SELECTION_SORT
{
static void Main(string[] args)
  {
    int[] a = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
    int tmp;
    Console.WriteLine(" Tablica przed sortowaniem");
    foreach (int liczba in a)
    {
      Console.Write($" {liczba} ");
    }    
    for (int i = 0; i < a.Length; i++)
      {
      for (int j = i + 1; j < a.Length; j++)
        {
        if (a[i] > a[j])
          {             
          tmp = a[i];   
          a[i] = a[j];
          a[j] = tmp;
          }
        }
      }
     Console.WriteLine("");
     Console.WriteLine(" Tablica po sortowaniu");
     foreach (int liczba in a)
      {
      Console.Write($" {liczba} ");
      }
  }
}