package Obliczanie_pola;

public class Kolo extends FiguraGeometryczna {
    private int promien;

    public Kolo(int promien){
        this.promien = promien;
    }

    public int obliczPole(){
        return (int) (Math.PI * promien * promien);
    }
}
