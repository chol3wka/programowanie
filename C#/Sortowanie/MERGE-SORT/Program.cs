
class MERGE_SORT
{
  const int N = 20;
  static int[] Dane = new int[N];
  static int[] DanePom = new int[N];

  static void Scalaj(int Początek, int Koniec)
  {    
    for (int i = Początek; i <= Koniec; i++)
    {
      DanePom[i] = Dane[i];
    }    
    int p = Początek;
    int q = (Początek + Koniec) / 2 + 1;
    int r = Początek;
    while (p <= (Początek + Koniec) / 2 && q <= Koniec)
    {
      if (DanePom[p] < DanePom[q])
      {
        Dane[r] = DanePom[p];
        r++;
        p++;
      }
      else
      {
        Dane[r] = DanePom[q];
        r++;
        q++;
      }
    }
    
    while (p <= (Początek + Koniec) / 2)
    {
      Dane[r] = DanePom[p];
      r++;
      p++;
    }
  }
  static void MergeSort(int Początek, int Koniec)
  {
    if (Początek < Koniec)
    {
      MergeSort(Początek, (Początek + Koniec) / 2);
      MergeSort((Początek + Koniec) / 2 + 1, Koniec);      
      Scalaj(Początek, Koniec);
    }
  }
  
  static void Main()
  {
    Random r = new Random();
    for (int i = 0; i < N; i++)
    {
      Dane[i] = r.Next(1001);
    }
    Console.WriteLine(" Wylosowane liczby");
    for (int i = 0; i < N; i++)
    {
      Console.Write(" {0}", Dane[i]);
      if (i == 9)
        Console.WriteLine();
    }
    MergeSort(0, N - 1);
    Console.WriteLine("\n");
    Console.WriteLine(" Liczby posortowane");
    for (int i = 0; i < N; i++)
    {
      Console.Write(" {0}", Dane[i]);
      if (i == 9)
        Console.WriteLine();
    }
    
  }
}