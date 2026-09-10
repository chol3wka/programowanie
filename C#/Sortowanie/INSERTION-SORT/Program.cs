using System;

class INSERTION_SORT
{
  static void Main(string[] args)
  {
    int temp;
    int[] a = new int[] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };
    int L = a.Length;
    int j = L - 1;
    int i;
    while (j >= 0)
    {
      temp = a[j];
      i = j + 1;
      while ((i < L) && (temp > a[i]))
      {
        a[i - 1] = a[i];
        i++;
      }
      a[i - 1] = temp;
      j--;
    }
    foreach (int liczba in a)
    {
      Console.Write($" {liczba} ");
    }
  }
}