import java.util.Scanner;

public class przelacznik {

        public static void main(String[] args) {

            Scanner input = new Scanner(System.in);
            System.out.println("Podaj dzień tygodnia 1-7");
            int dzien  = Integer.parseInt(input.nextLine());

            if(dzien<1 || dzien>7) {
                System.out.println("Podałeś złą liczbę");
            }else{
                switch(dzien){
                    case 1:
                        System.out.println("Jest poniedziałek");
                        break;
                    case 2:
                        System.out.println("Jest wtorek");
                        break;
                    case 3:
                        System.out.println("Jest środa");
                        break;
                    case 4:
                        System.out.println("Jest poniedziałek");
                        break;
                    case 5:
                        System.out.println("Jest poniedziałek");
                        break;
                    case 6:
                        System.out.println("Jest poniedziałek");
                        break;
                    case 7:
                        System.out.println("Jest poniedziałek");
                        break;
                    default:
                        System.out.println("Podaj dzień tygodnia 1-7");
                        break;
                }
                }
        }
    }

