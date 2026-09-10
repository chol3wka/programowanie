using System;

class Program
{
    static void Main(string[] args)
    {
        double wejscie = 0, wyjscie = 0;
        int wybor;

            Console.WriteLine("\n=== Wybierz jednostkę (przeliczanie na metry) ===");
            Console.WriteLine("1. Cale");
            Console.WriteLine("2. Stopy");
            Console.WriteLine("3. Yardy");
            Console.WriteLine("4. Mile");
            Console.WriteLine("0. Wyjście");

            wybor = int.Parse(Console.ReadLine());

            PrzeliczanieDlugosci(wejscie, wyjscie, wybor);
           
    }
    static void PrzeliczanieDlugosci(double wejscie, double wyjscie, int wybor)
    {
                switch (wybor)
                {
                    case 1:
                        Console.WriteLine("Podaj wartość w calach");
                        wejscie = double.Parse(Console.ReadLine());
                        wyjscie = (wejscie * 2.54) / 100;
                        Console.WriteLine(wejscie + " cali to "+ wyjscie + "m");
                        break;
                    case 2:
                        Console.WriteLine("Podaj wartość w stopach");
                        wejscie = double.Parse(Console.ReadLine());
                        wyjscie = (wejscie * 30.48) / 100;
                        Console.WriteLine(wejscie + " stóp to " + wyjscie + "m");
                        break;
                    case 3:
                        Console.WriteLine("Podaj wartość w yardach");
                        wejscie = double.Parse(Console.ReadLine());
                        wyjscie = (wejscie * 91.44) / 100;
                        Console.WriteLine(wejscie + " yardów to " + wyjscie + "m");
                        break;
                    case 4:
                        Console.WriteLine("Podaj wartość w milach");
                        wejscie = double.Parse(Console.ReadLine());
                        wyjscie = (wejscie * 1609);
                        Console.WriteLine(wejscie + " mil to " + wyjscie + "m");
                        break;
                    case 0:
                        Console.WriteLine("Zamykanie programu...");
                        break;
                    default:
                        Console.WriteLine("Niepoprawny wybor.");
                        break;
                }

            }
        }

