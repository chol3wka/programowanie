package Szkola;

public class Szkola {
    private  Uczen klasa1B;

    public Szkola(Uczen klasa1B){
        this.klasa1B = klasa1B;
    }
    public void informalcjeOSzkole(){
        System.out.println("Klasa 1B ma ucznia o imieniu; " + klasa1B.getImie());
    }

}
