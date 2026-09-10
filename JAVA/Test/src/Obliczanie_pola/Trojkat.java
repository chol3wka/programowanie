package Obliczanie_pola;

public class Trojkat extends FiguraGeometryczna {
    private int bok;
    private int wysokosc;

    public Trojkat(int bok, int wysokosc){
        this.bok = bok;
        this.wysokosc = wysokosc;
    }

    public int obliczPole() {
        return (bok * wysokosc) / 2;
    }
}
