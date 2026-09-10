package interfejs;

public class DzikaKaczka extends Kaczka implements Kwakanie{
    public  DzikaKaczka(String imie){
        super(imie);
    }

    @Override
    void Wyswietl() {
        System.out.println("Wyglądam jak prawdziwa kaczka");
    }

    public  void  kwacz(){
        System.out.println("Kwa! Kwa!");
    }

}