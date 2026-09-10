public class operatory_logiczne {
    public static void main(String[] args) {
        int liczba = 0;
        int a = 3;
        int b = 5;
        System.out.println(a == b);
        System.out.println(a != b);
        System.out.println(a > b);
        System.out.println(a < b);
        System.out.println(a <= b);
        System.out.println(a >= b);

        if(a==b && b==a){
            System.out.println("Tak");
        }else if(a>b || a>=b){
            System.out.println("Tak");
        }else{
            System.out.println("Nie");
        }

        if((liczba%2 == 0) && (liczba>10)){
            System.out.println("Nie");
        }
        System.out.println((liczba%2 == 0) && (liczba>10));
        System.out.println((liczba%2 != 0) || (liczba<5));
        System.out.println(!(liczba%2 != 0) || !(liczba<5));
    }



}
