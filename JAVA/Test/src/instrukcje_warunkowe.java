import java.util.Scanner;

public class instrukcje_warunkowe {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        System.out.println("Podaj liczbe");
        int liczba = Integer.parseInt(input.nextLine());

        if (liczba > 0) {
            System.out.println("Twoja liczba jest dodatnia");
        } else if (liczba < 0) {
            System.out.println("Twoja liczba jest ujemna");
        } else {
            System.out.println("Twoja liczba jest równa 0");
        }
    }
}
