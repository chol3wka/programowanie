package interfejs;

abstract class Kaczka {
         String imie;

         Kaczka(String imie){
             this.imie = imie;
         }
         void plyn(){
             System.out.println(imie + "*Pluskanie*");
         }
         abstract void Wyswietl();

}
