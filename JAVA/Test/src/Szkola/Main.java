package Szkola;

public class Main {
    public static  void  main(String[] args){
        Uczen uczen1 = new Uczen("Jan Kowalski", 27);
        Szkola szkola = new Szkola(uczen1);
        szkola.informalcjeOSzkole();
    }
}
