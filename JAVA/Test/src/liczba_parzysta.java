import java.util.Scanner;

public class liczba_parzysta {

        public static void main(String[] args) {

            Scanner input = new Scanner(System.in);
            System.out.println("Podaj liczbę całkowitą");
            int liczba  = Integer.parseInt(input.nextLine());
            if (liczba > 0){
                if(liczba%2==0){
                    System.out.println("Twoja liczba jest parzysta");
                }else
                {
                    System.out.println("Twoja liczba jest nieparzysta");
                }
            }
            else{
                System.out.println("Twoja liczba jest ujemna lub równa 0");
            }

        }
    }
