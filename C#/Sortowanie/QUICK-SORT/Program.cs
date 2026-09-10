using System;
public class QUICK_SORT
{
public static void Main(string[] args)
 {
 int[] a = new int[]
     { 100, 30, 10, 90, 20, 80, 40, 70, 50, 60 };
 Console.WriteLine(" Dane");
 for (int i = 0; i < a.Length; i++)
   Console.Write(" " + a[i]);
 Console.WriteLine();
 QuickSort(a, 0, a.Length - 1);
 Console.WriteLine(" Wynik");
 for (int i=0; i<a.Length; i++)
   Console.Write(" "+a[i]);
 Console.WriteLine();
 }
private static void QuickSort(int[] arr, int lewy, int prawy)
 {
 if (lewy < prawy)
  {
  int i = PodzielTab(arr, lewy, prawy);
  if (i > 1)
    QuickSort(arr, lewy, i - 1);
  if (i + 1 < prawy)
    QuickSort(arr, i + 1, prawy);
  }
 }
 private static int PodzielTab(int[] arr, int lewy, int prawy)
  {
  int i = arr[lewy];
  while (true)
  {
   while (arr[lewy] < i) lewy++;
   while (arr[prawy] > i) prawy--;
   if (lewy < prawy)
     {
     if (arr[lewy] == arr[prawy]) return prawy;
     int temp = arr[lewy];
     arr[lewy] = arr[prawy];
     arr[prawy] = temp;
     }
   else return prawy;
   }
  }
}