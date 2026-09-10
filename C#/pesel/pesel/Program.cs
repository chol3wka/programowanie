//Weronika Cholewa

using System;
using System.Linq;

public class zpesel
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("Podaj pesel");
        string pesel = Console.ReadLine();
        if (pesel.Length !=11){
            Console.WriteLine("Podano nieprawidłowy pesel");
            return;
        }
        if(!pesel.All(char.IsDigit)){
            Console.WriteLine("Podano nieprawidłowy pesel - musi składać się z samych cyfr");
            return;
        }
        if(pesel[9]%2==0){
            Console.WriteLine("Kobieta");
        }else if(pesel[9]%2!=0){
            Console.WriteLine("Mężczyzna");

        }
    int[] waga = {1,3,5,7,9,1,3,5,7,9,1,3};
    int suma = 0;
    for (int i=0; i<10; i++){
        suma +=waga[i]* (pesel[i]-'0');
    }
    int cyfraKontrolna = 10 - suma%10;
    if (cyfraKontrolna ==10){
        cyfraKontrolna = 0;
    }
    if (cyfraKontrolna != pesel[10] - '1'){
        Console.WriteLine("Podano nieprawidłowy pesel");
        return;
    }else{
        Console.WriteLine("Podano prawidłowy pesel");
    }
    }
}
   
