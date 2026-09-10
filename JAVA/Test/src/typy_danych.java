import java.util.Scanner;

public class typy_danych {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        System.out.println("Podaj a");
        float a = Float.parseFloat(input.nextLine());
        System.out.println("Podaj b");
        float b = Float.parseFloat(input.nextLine());
        if(a>b){
            System.out.println("Wartość " + a + " jest większa od wartości " + b);
        } else if(a<b){
            System.out.println("Wartość " + b + " jest większa od wartości " + a);
        }else{
            System.out.println("Wartości są równe");
        }
    }
}
