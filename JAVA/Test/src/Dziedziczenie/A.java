package Dziedziczenie;
// trzy rodzaje dziediczenia w jawie
// -- pojedyncze - klasa A dziedziczy po klasie B
// -- wielokrotne - klasa C dziedziczy po klasie B, a klasa B dziedziczy po klasie A
// -- hierarchiczne - klasa C i klasa B dziedziczą po klasie A

public class A {
    void metodaA(){
        System.out.println("MetodaA klasy A");
    }
}

class B extends A {
    void metodaB() {
        System.out.println("MetodaB klasy B");
    }
}


