public class zakres_zmiennych {
    int licznik = 100; // zmienna instancyjna (dostępna w całej klasie)

    public void przykladZakresu(int n) {

        int suma = 0; // zmienna lokalna metody

        for (int i = 0; i < n; i++) { // i – zmienna blokowa pętli
            int temp = i * 2; // zmienna blokowa

            suma += temp;
            System.out.println("i = " + i + ", temp = " + temp);
        }

        // i oraz temp NIE są już dostępne
        System.out.println("Suma = " + suma);
        System.out.println("Licznik = " + licznik);

        if (suma > 10) {
            String komunikat = "Suma większa od 10";
            System.out.println(komunikat);
        }

        // komunikat NIE jest już dostępny
    }
}
