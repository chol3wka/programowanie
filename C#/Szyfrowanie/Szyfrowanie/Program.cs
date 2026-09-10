using System;
using System.IO;

class Program
{
 
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj tekst do zaszyfrowania");
        string text = Console.ReadLine();
        File.WriteAllText("szyfr.txt", "Tekst do zaszyfrowania: " + text + "\n" );
        char[] arr = text.ToCharArray();
        Console.WriteLine("Zaszyfrowany tekst: ");
        string cezara = SzyfrCezara(arr);
        File.AppendAllText("szyfr.txt", "Szyfr Cezara: " + cezara + "\n");
        Console.WriteLine("Szyfr Cezara: " + cezara);
        string przestawieniowy = SzyfrPrzestawieniowy(arr);
        File.AppendAllText("szyfr.txt", "Szyfr Przestawieniowy: " + przestawieniowy + "\n");
        Console.WriteLine("Szyfr Przestawieniowy: " + przestawieniowy);
        string gaderypoluci = SzyfrGaderypoluci(arr);
        File.AppendAllText("szyfr.txt", "Szyfr Gaderypoluci: " + gaderypoluci + "\n");
        Console.WriteLine("Szyfr Gaderypoluci: " + gaderypoluci);
    }

    /// SzyfrCezara
    /// Szyfruje tekst, przesuwając każdą literę o pięć pozycji w alfabecie.
    /// Argumenty: arr - tablica znaków przechowująca tekst do zaszyfrowania.
    /// Typ zwracany: string - zaszyfrowany tekst.
    static string SzyfrCezara(char[] arr)
    {
        char[] wynik = (char[])arr.Clone();

        for (int i = 0; i < wynik.Length; i++)
        {
            if (wynik[i] >= 'A' && wynik[i] <= 'Z')
            {
                wynik[i] = (char)('A' + (wynik[i] - 'A' + 5) % 26);
            }
            else if (wynik[i] >= 'a' && wynik[i] <= 'z')
            {
                wynik[i] = (char)('a' + (wynik[i] - 'a' + 5) % 26);
            }
        }

        return new string(wynik);
    }

    /// SzyfrPrzestawieniowy
    /// Zamienia miejscami sąsiednie znaki tekstu w parach.
    /// Argumenty: arr - tablica znaków przechowująca tekst do zaszyfrowania.
    /// Typ zwracany: string - tekst z przestawionymi znakami.
    static string SzyfrPrzestawieniowy(char[] arr)
    {
        char[] wynik = (char[])arr.Clone();

        for (int i = 0; i + 1 < wynik.Length; i += 2)
        {
            char znak = wynik[i];
            wynik[i] = wynik[i + 1];
            wynik[i + 1] = znak;
        }

        return new string(wynik);
    }

    /// SzyfrGaderypoluci
    /// Zamienia litery według par GA, DE, RY, PO, LU, KI.
    /// Argumenty: arr - tablica znaków przechowująca tekst do zaszyfrowania.
    /// Typ zwracany: string - tekst zaszyfrowany szyfrem GADERYPOLUKI.
    static string SzyfrGaderypoluci(char[] arr)
    {
        const string pierwszy = "GADERYPOLUKI";
        const string drugi = "AGEDYROPULIK";
        char[] wynik = (char[])arr.Clone();

        for (int i = 0; i < wynik.Length; i++)
        {
            bool malaLitera = char.IsLower(wynik[i]);
            char znak = char.ToUpper(wynik[i]);
            int indeks = pierwszy.IndexOf(znak);

            if (indeks >= 0)
            {
                znak = drugi[indeks];
            }
            else
            {
                indeks = drugi.IndexOf(znak);
                if (indeks >= 0)
                {
                    znak = pierwszy[indeks];
                }
            }

            wynik[i] = malaLitera ? char.ToLower(znak) : znak;
        }

        return new string(wynik);
    }
}