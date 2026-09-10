class Klasa4 {
private String imie;

//Getter
    public String GetImie(){
        return imie;
    }
    //Setter
    public void setImie(String Noweimie){
        this.imie = Noweimie;
    }

    static void main(String[] args) {
        Klasa4 osoba = new Klasa4();
        osoba.setImie("Dawid");
        System.out.println("Imie tej osoby to: "+ osoba.GetImie());
    }

}
