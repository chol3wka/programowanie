package interfejs;

public class Main {
    public static void main(String[] args){
        DzikaKaczka DzikaKaczka = new DzikaKaczka("Stasia");
        System.out.println("Jestem "+ DzikaKaczka.imie);
        DzikaKaczka.kwacz();
        DzikaKaczka.Wyswietl();
        GumowaKaczka GumowaKaczka = new GumowaKaczka("Frania");
        System.out.println("Jestem "+ GumowaKaczka.imie);
        GumowaKaczka.Wyswietl();
        GumowaKaczka.kwacz();
    }

}
