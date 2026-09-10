package interfejs;

public class GumowaKaczka extends Kaczka implements Kwakanie{
    public GumowaKaczka(String imie){
        super(imie);
    }
    public  void  kwacz(){

        System.out.println("Piiisk! Piiisk!");
    }
    @Override
    void Wyswietl() {
        System.out.println("Jestem żółta i gumowa");
    }
}