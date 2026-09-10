package Obliczanie_pola;

public class Kwadrat extends FiguraGeometryczna {
    private int bok;
    public Kwadrat(int bok) {
        this.bok = bok;
    }

    public int obliczPole() {
        return bok * bok;
    }
}
