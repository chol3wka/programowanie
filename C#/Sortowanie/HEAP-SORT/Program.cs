public class HEAP_SORT
{
  static void Sterta(int[] array, int size, int index)
  {
    var largestIndex = index;
    var leftChild = 2 * index + 1;
    var rightChild = 2 * index + 2;

    if (leftChild < size && array[leftChild] > array[largestIndex])
    {
      largestIndex = leftChild;
    }

    if (rightChild < size && array[rightChild] > array[largestIndex])
    {
      largestIndex = rightChild;
    }

    if (largestIndex != index)
    {
      var tempVar = array[index];
      array[index] = array[largestIndex];
      array[largestIndex] = tempVar;

      Sterta(array, size, largestIndex);
    }
  }
  public static int[] HeapSort(ref int[] array, int size)
  {
    if (size <= 1)
      return array;

    for (int i = size / 2 - 1; i >= 0; i--)
    {
      Sterta(array, size, i);
    }

    for (int i = size - 1; i >= 0; i--)
    {
      var tempVar = array[0];
      array[0] = array[i];
      array[i] = tempVar;

      Sterta(array, i, 0);
    }
    return array;
  }
  public static void Main(string[] args)
  {
    int[] a = new int[]
    { 10, 9, 7, 5, 3, 2, 4, 6, 8, 1 };
    Console.WriteLine(" Przed sortowaniem");
    for (int i = 0; i < a.Length; i++)
      Console.Write(" " + a[i]);
    Console.Write("\n");
    var output = HeapSort(ref a, a.Length);
    Console.WriteLine(" Po sortowaniu");
    for (int i = 0; i < a.Length; i++)
      Console.Write(" "+a[i]);
    Console.Write("\n");
  }
}