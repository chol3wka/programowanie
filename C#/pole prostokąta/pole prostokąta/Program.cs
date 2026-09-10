using System;
public class Prostokat
{
    private double a;
    private double b;
    private double pole;

    static void Main()
    {
        Prostokat io = new Prostokat();
        io.czytaj_dane();
        io.przetworz_dane();
        io.wyswietl_wynik();
    }


    public void czytaj_dane()
    {
        Console.WriteLine("Podaj wartość a");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wartość b");
        b = double.Parse(Console.ReadLine());
    }

    public void przetworz_dane()
    {
        pole = a * b;
    }

    public void wyswietl_wynik()
    {
        Console.WriteLine("Pole wynosi: " + pole);
    }
}
