using System.ComponentModel.DataAnnotations;

class tablica
{
    public static void Main()
    {
        int[] tablica = {10,2,9,3,8,4,7,5,6,1};
        int n=10;
        int max=tablica[0];

        for (int i=1; i<n; i++){
            if (max<tablica[i]){
                max=tablica[i];
            }
        }
            Console.WriteLine("Najwiekszy element tablicy: " + max);
        }
    }
   