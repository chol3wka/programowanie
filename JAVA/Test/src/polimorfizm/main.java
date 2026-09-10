package polimorfizm;

public class main {
    public static void main(String[] args){
        zwierze[] zwierzeta = new zwierze[2];
        zwierzeta[0]= new kot();
        zwierzeta[1] = new pies();

        ptak ptak = new sojka();
        for (zwierze zwierze : zwierzeta){
            zwierze.dajGlos();
        }
        ptak.lataj();
    }
}
