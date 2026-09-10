public class bloki_try {
    public static void main(String[] args) {
        try {
            String tekst = "123";
            int x = Integer.parseInt(tekst);

            int[] tablica = {1, 2, 3};
            int y = tablica[5];

            int wynik = x / 0;
            System.out.println(wynik);

        } catch (NumberFormatException e) {
            System.out.println("Blad konwersji tekstu na liczbe");
        } catch (ArrayIndexOutOfBoundsException e) {
            System.out.println("Blad indeksu tablicy");
        } catch (ArithmeticException e) {
            System.out.println("Blad arytmetyczny");
        } finally {
            System.out.println("Blok finally zostal wykonany");
        }
    }
}
