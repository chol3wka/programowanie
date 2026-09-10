package Obliczanie_pola;

public class FiguraGeometryczna {
    protected int bok;
    public FiguraGeometryczna(){
    }
    public FiguraGeometryczna(int bok){
        this.bok = bok;
    }
    public int obliczPole() {
        return bok;
    }

}
