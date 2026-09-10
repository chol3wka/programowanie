using System;
using System.Data;

public class ConsoleApp9
{
    static void Main(string[] args){

        string[] wyrazy ={"zyrafa","slon","aligator","nosorozec","szympans"};
        Random random = new Random();
        string haslo = wyrazy[random.Next(wyrazy.Length)];
        string odgadniecie = new string ('#', haslo.Length);
        int proby =  10;
        while(odgadniecie != haslo && proby >0){
            Console.WriteLine("Zgadnij słowo");
            Console.WriteLine("Pozostało prób: "+ proby);
            Wisielec(proby);
            Console.WriteLine("Podaj literę");

            char odpowiedz = Console.ReadLine()[0];

            if(haslo.Contains(odpowiedz)){
                char[] odpowiedzi = odgadniecie.ToCharArray();

                for(int i=0; i< haslo.Length;i++){
                    if(haslo[i] == odpowiedz){
                        odpowiedzi[i] = odpowiedz;
                    }
                }
                odgadniecie = new string(odgadniecie);
            }else{
                proby--;
            }

        }
        if(haslo ==odgadniecie){
            Console.WriteLine("Gratulacje! Udało Ci się zgadnąć ");
    }else{
        Console.WriteLine("Nie udało ci się zgadnąć. :( Hasło to: "+ haslo);
        Wisielec(0);
    }
        Console.WriteLine("Podaj liczbę prób: ");
        int proba = int.Parse(Console.ReadLine());
        Wisielec(proba);
    } 
    static void Wisielec(int proba) 
    {
        if(proba == 9){
            Console.WriteLine("---------");
        }else if(proba ==8){
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");

            Console.WriteLine("---------");
        }else if(proba ==7){
            Console.WriteLine("+---+");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");

            Console.WriteLine("---------");

        }else if(proba ==6){

            Console.WriteLine("+---+");
            Console.WriteLine(" |  |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");

            Console.WriteLine("---------");

        }else if(proba ==5){

            Console.WriteLine("+---+");
            Console.WriteLine(" |  |");
            Console.WriteLine(" |  o");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");

            Console.WriteLine("---------");

        }else if(proba ==4){

            Console.WriteLine("+---+");
            Console.WriteLine(" |  |");
            Console.WriteLine(" |  o");
            Console.WriteLine(" |  |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");

            Console.WriteLine("---------");

        }else if(proba ==3){

            Console.WriteLine("+---+");
            Console.WriteLine(" |  |");
            Console.WriteLine(" |  o");
            Console.WriteLine(" | /|");
            Console.WriteLine(" | ");
            Console.WriteLine(" |");

            Console.WriteLine("---------");

        }else if(proba ==2){

            Console.WriteLine("+---+");
            Console.WriteLine(" |  |");
            Console.WriteLine(" |  o");
            Console.WriteLine(" | /|\\");
            Console.WriteLine(" |");
            Console.WriteLine(" |");

            Console.WriteLine("---------");

        }else if(proba ==1){

            Console.WriteLine("+---+");
            Console.WriteLine(" |  |");
            Console.WriteLine(" |  o");
            Console.WriteLine(" | /|\\");
            Console.WriteLine(" | /");
            Console.WriteLine(" |");

            Console.WriteLine("---------");

        }else if(proba ==0){

            Console.WriteLine("+---+");
            Console.WriteLine(" |  |");
            Console.WriteLine(" |  o");
            Console.WriteLine(" | /|\\");
            Console.WriteLine(" | / \\");
            Console.WriteLine(" |");

            Console.WriteLine("---------");

        }
        
    }
}