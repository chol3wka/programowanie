package Obliczanie_pola;

public class Main {
    public static void main(String[] args){
        FiguraGeometryczna figura = new FiguraGeometryczna(2);
        Kwadrat kwadrat = new Kwadrat(5);
        Trojkat trojkat = new Trojkat(5,6);
        Kolo kolo = new Kolo(7);
        System.out.println("Pole figury wynosi: " + figura.obliczPole());
        System.out.println("Pole kwadratu wynosi: " + kwadrat.obliczPole());
        System.out.println("Pole trójkąta wynosi: " + trojkat.obliczPole());
        System.out.println("Pole koła wynosi: " + kolo.obliczPole());
    }
}
