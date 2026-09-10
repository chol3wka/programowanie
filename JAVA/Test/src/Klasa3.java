class Klasa3 {
    static int odejmowanieliczb(int a, int b, int c){
        return a - b - c;
    }
    static int dodawanieLiczb(int a, int b, int c){
        return a + b + c;
    }
    public static void  main(String[] args){
        int wynikOdejmowania = odejmowanieliczb(3,6,1);
        int wynikDodawania = dodawanieLiczb(3,6,1);
        int wynikkoncowy = wynikDodawania - wynikOdejmowania;
        System.out.println(wynikkoncowy);
    }
}
