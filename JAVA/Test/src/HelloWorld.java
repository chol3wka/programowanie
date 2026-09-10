import java.util.Scanner;

public class HelloWorld {
    public static void main(String[] args) {
        System.out.println("Hello World!");
        Scanner input = new Scanner(System.in);
        System.out.println("Podaj imie");
        String imie = input.nextLine();
        System.out.println("Witaj, " + imie + "!");
    }
}
