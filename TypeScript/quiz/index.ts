import readline = require("readline");
const rl = readline.createInterface({ 
  input: process.stdin, 
  output: process.stdout, 
}); 
type Pytanie = { 
  pytanie: string; 
  odpowiedzi: string[]; 
  poprawna: number; 
}; 
const kategorie: { [key: string]: Pytanie[] } = { 
  matematyka: [ 
    { pytanie: "Ile wynosi 2+2?", odpowiedzi: ["2", "4", "6"], poprawna: 1 }, 
    { pytanie: "Pierwiastek sześcienny z 27 to:", odpowiedzi: ["12", "18", "3"], poprawna: 2 }, 
    { pytanie: "Ile wynosi 5 * 6?", odpowiedzi: ["11", "30", "56"], poprawna: 1 }, 
    { pytanie: "Ile wynosi 10 / 2?", odpowiedzi: ["3", "5", "2"], poprawna: 1 },
    { pytanie: "Co to jest liczba pierwsza?", odpowiedzi: ["Dzieli się tylko przez 1 i siebie", "Ma parzystą ilość dzielników", "Jest większa niż 10"], poprawna: 0 },
    { pytanie: "Rozwiązanie równania 3x = 12 to:", odpowiedzi: ["x = 3", "x = 4", "x = 6"], poprawna: 1 },
    { pytanie: "Jaka jest wartość pierwiastka kwadratowego z 81?", odpowiedzi: ["7", "8", "9"], poprawna: 2 },
    { pytanie: "Ile stopni ma trójkąt równoboczny?", odpowiedzi: ["180", "360", "90"], poprawna: 0 },
    { pytanie: "Jak nazywa się wynik dodawania?", odpowiedzi: ["Iloczyn", "Suma", "Różnica"], poprawna: 1 },
    { pytanie: "Ile wynosi 7 - 3?", odpowiedzi: ["5", "4", "3"], poprawna: 1 },
  ], 
  chemia: [ 
    { pytanie: "P to symbol chemiczny:", odpowiedzi: ["Fosforu", "Potasu", "Fluoru"], poprawna: 0 }, 
    { pytanie: "Wzór chemiczny wody to:", odpowiedzi: ["CO2", "O2", "H2O"], poprawna: 2 }, 
    { pytanie: "Naładowanie elektronu to:", odpowiedzi: ["dodatnie", "ujemne", "obojętne"], poprawna: 1 },
    { pytanie: "Sól kuchenna to:", odpowiedzi: ["NaCl", "KCl", "H2O"], poprawna: 0 },
    { pytanie: "pH 7 oznacza roztwór:", odpowiedzi: ["kwaśny", "zasadniczy", "obojętny"], poprawna: 2 },
    { pytanie: "Gaz niezbędny do oddychania to:", odpowiedzi: ["Azot", "Tlen", "Dwutlenek węgla"], poprawna: 1 },
    { pytanie: "Najlżejszy pierwiastek to:", odpowiedzi: ["Hel", "Wodór", "Tlen"], poprawna: 1 },
    { pytanie: "Proces łączenia atomów to:", odpowiedzi: ["Reakcja", "Więzanie", "Stopienie"], poprawna: 1 },
    { pytanie: "Co oznacza symbol Na?", odpowiedzi: ["Sód", "Nikiel", "Azot"], poprawna: 0 },
    { pytanie: "Stan skupienia lodu w temperaturze pokojowej to:", odpowiedzi: ["Ciekły", "Gazowy", "Stały"], poprawna: 2 },
  ], 
  informatyka: [
    { pytanie: "Co oznacza skrót CPU?", odpowiedzi: ["Central Processing Unit", "Computer Personal Unit", "Central Programming Unit"], poprawna: 0 },
    { pytanie: "Język, w którym pisze się strony WWW to:", odpowiedzi: ["HTML", "Python", "SQL"], poprawna: 0 },
    { pytanie: "System operacyjny to:", odpowiedzi: ["Program do rysowania", "Oprogramowanie zarządzające zasobami komputera", "Przeglądarka internetowa"], poprawna: 1 },
    { pytanie: "Co to jest zmienna w programowaniu?", odpowiedzi: ["Stała wartość", "Miejsce do przechowywania danych", "Rodzaj funkcji"], poprawna: 1 },
    { pytanie: "Jak zapisać prawdę w logice binarnej?", odpowiedzi: ["0", "1", "2"], poprawna: 1 },
    { pytanie: "Co to jest HTML?", odpowiedzi: ["Język stylów", "Język znaczników", "Baza danych"], poprawna: 1 },
    { pytanie: "Co robi funkcja print()/console.log()?", odpowiedzi: ["Zapisuje plik", "Wyświetla dane na ekranie", "Tworzy bazę danych"], poprawna: 1 },
    { pytanie: "Jak nazywa się sieć łącząca komputery na dużym obszarze?", odpowiedzi: ["LAN", "WAN", "PAN"], poprawna: 1 },
    { pytanie: "Format zapisu obrazu bez strat to np.:", odpowiedzi: ["JPEG", "PNG", "MP3"], poprawna: 1 },
    { pytanie: "Co to jest algorytm?", odpowiedzi: ["Zbiór kroków rozwiązujących problem", "Język programowania", "Typ zmiennej"], poprawna: 0 },
  ],
  historia: [
    { pytanie: "W którym roku rozpoczęła się II wojna światowa?", odpowiedzi: ["1914", "1939", "1945"], poprawna: 1 },
    { pytanie: "Kto został pierwszym królem Polski według tradycji?", odpowiedzi: ["Mieszko I", "Bolesław Chrobry", "Kazimierz Wielki"], poprawna: 1 },
    { pytanie: "Starożytny Egipt słynął z budowy:", odpowiedzi: ["Akropolów", "Piramid", "Mostów"], poprawna: 1 },
    { pytanie: "Rewolucja francuska miała miejsce pod koniec:", odpowiedzi: ["XVIII wieku", "XIX wieku", "XVII wieku"], poprawna: 0 },
    { pytanie: "Jak nazywał się kontynent odkryty przez Krzysztofa Kolumba w 1492?", odpowiedzi: ["Australia", "Ameryka", "Azja"], poprawna: 1 },
    { pytanie: "W którym kraju powstało starożytne państwo Akadia?", odpowiedzi: ["Egipt", "Mezopotamia", "Grecja"], poprawna: 1 },
    { pytanie: "Co zakończyło średniowiecze i rozpoczęło epokę nowożytną?", odpowiedzi: ["Odkrycia geograficzne", "Wynalezienie koła", "Epoka lodowcowa"], poprawna: 0 },
    { pytanie: "Kto był słynnym wodzem rzymskim i dyktatorem (I w. p.n.e.)?", odpowiedzi: ["Cezar", "Aleksander", "Homer"], poprawna: 0 },
    { pytanie: "Bitwa pod Grunwaldem odbyła się w roku:", odpowiedzi: ["1410", "1610", "1310"], poprawna: 0 },
    { pytanie: "Co to była Magna Carta?", odpowiedzi: ["Traktat handlowy", "Karta praw ograniczająca władzę króla", "Mapa geograficzna"], poprawna: 1 },
  ],
  geografia: [
    { pytanie: "Stolicą Polski jest:", odpowiedzi: ["Kraków", "Warszawa", "Gdańsk"], poprawna: 1 },
    { pytanie: "Najdłuższa rzeka świata to:", odpowiedzi: ["Amazonka", "Nil", "Missisipi"], poprawna: 0 },
    { pytanie: "Najwyższy szczyt świata to:", odpowiedzi: ["K2", "Mount Everest", "Kilimandżaro"], poprawna: 1 },
    { pytanie: "Jak nazywa się największy ocean?", odpowiedzi: ["Atlantycki", "Spokojny (Pacyfik)", "Indyjski"], poprawna: 1 },
    { pytanie: "Kontynent, na którym leży Brazylia to:", odpowiedzi: ["Afryka", "Ameryka Południowa", "Europa"], poprawna: 1 },
    { pytanie: "Stolicą Francji jest:", odpowiedzi: ["Lyon", "Marsylia", "Paryż"], poprawna: 2 },
    { pytanie: "Państwo otoczone z każdej strony lądem to:", odpowiedzi: ["Wyspa", "Kraj śródlądowy", "Półwysep"], poprawna: 1 },
    { pytanie: "Co to jest archipelag?", odpowiedzi: ["Pojedyncza wyspa", "Zespół wysp", "Górzysty region"], poprawna: 1 },
    { pytanie: "Największe jezioro na świecie (powierzchniowo) to:", odpowiedzi: ["Morze Kaspijskie", "Jezioro Wiktorii", "Górne"], poprawna: 0 },
    { pytanie: "Jak nazywa się pasmo górskie w Europie, biegnące przez Francję i Włochy?", odpowiedzi: ["Alpy", "Andy", "Skandynawskie"], poprawna: 0 },
  ],
  biologia: [
    { pytanie: "Komórki są podstawową jednostką:", odpowiedzi: ["Budowy materii", "Życia", "Ziemi"], poprawna: 1 },
    { pytanie: "Materiał genetyczny to:", odpowiedzi: ["RNA", "DNA", "ATP"], poprawna: 1 },
    { pytanie: "Organizm, który przeprowadza fotosyntezę to:", odpowiedzi: ["Roślina", "Ssak", "Grzyb"], poprawna: 0 },
    { pytanie: "Gdzie zachodzi fotosynteza w komórce roślinnej?", odpowiedzi: ["Mitochondrium", "Chloroplasty", "Jądro komórkowe"], poprawna: 1 },
    { pytanie: "Jak nazywa się układ służący do transportu krwi?", odpowiedzi: ["Układ nerwowy", "Układ oddechowy", "Układ krążenia"], poprawna: 2 },
    { pytanie: "Jak nazywa się proces podziału komórki somatycznej?", odpowiedzi: ["Mejoza", "Mitologia", "Mitoza"], poprawna: 2 },
    { pytanie: "Jakie zwierzę jest ssakiem?", odpowiedzi: ["Karp", "Orzeł", "Delfin"], poprawna: 2 },
    { pytanie: "Co transportuje tlen w krwi człowieka?", odpowiedzi: ["Glukoza", "Hemoglobina", "Woda"], poprawna: 1 },
    { pytanie: "Jak nazywa się nauka o roślinach?", odpowiedzi: ["Zoologia", "Botanika", "Geologia"], poprawna: 1 },
    { pytanie: "Jak nazywa się największy narząd ludzkiego ciała?", odpowiedzi: ["Skóra", "Wątroba", "Płuca"], poprawna: 0 },
  ],
  sport: [
    { pytanie: "W piłce nożnej mecz trwa standardowo:", odpowiedzi: ["60 minut", "90 minut", "120 minut"], poprawna: 1 },
    { pytanie: "Ile punktów za rzut za trzy w koszykówce?", odpowiedzi: ["2", "3", "1"], poprawna: 1 },
    { pytanie: "Ile graczy jest na boisku w drużynie piłkarskiej (łącznie z bramkarzem)?", odpowiedzi: ["11", "9", "7"], poprawna: 0 },
    { pytanie: "Który sport rozgrywany jest na kortach?", odpowiedzi: ["Tenis", "Hokej", "Rugby"], poprawna: 0 },
    { pytanie: "Igrzyska olimpijskie odbywają się co ile lat?", odpowiedzi: ["2 lata", "4 lata", "5 lat"], poprawna: 1 },
    { pytanie: "W jakim sporcie zdobywa się 'home run'?", odpowiedzi: ["Baseball", "Koszykówka", "Piłka nożna"], poprawna: 0 },
    { pytanie: "W jakim sporcie używa się rakiety i shuttlecocka?", odpowiedzi: ["Badminton", "Tenis", "Squash"], poprawna: 0 },
    { pytanie: "Jak nazywa się tor dla wyścigów kolarskich w hali?", odpowiedzi: ["Autodrom", "Wielodrom (welodrom)", "Stadion"], poprawna: 1 },
    { pytanie: "Sport, w którym liczy się czas przejazdu na nartach to:", odpowiedzi: ["Narciarstwo alpejskie", "Skoki narciarskie", "Hokej"], poprawna: 0 },
    { pytanie: "Ile setów trzeba wygrać w meczu tenisowym mężczyzn w Wielkim Szlemie (standardowo)?", odpowiedzi: ["2 z 3", "3 z 5", "1 z 1"], poprawna: 1 },
  ],
  muzyka: [
    { pytanie: "Instrument z klawiszami i strunami to:", odpowiedzi: ["Skrzypce", "Fortepian", "Flet"], poprawna: 1 },
    { pytanie: "Ile nut podstawowych ma diatoniczna skala muzyczna?", odpowiedzi: ["7", "5", "12"], poprawna: 0 },
    { pytanie: "Jak nazywa się symbol oznaczający ciszę w muzyce?", odpowiedzi: ["Nutka", "Pauza", "Takt"], poprawna: 1 },
    { pytanie: "Który instrument jest dęty drewniany?", odpowiedzi: ["Trąbka", "Klarnet", "Wiolonczela"], poprawna: 1 },
    { pytanie: "Co to tempo w muzyce?", odpowiedzi: ["Wysokość dźwięku", "Szybkość wykonania", "Głośność"], poprawna: 1 },
    { pytanie: "Jak nazywa się pięcioliniowy system zapisu nut?", odpowiedzi: ["Takt", "Pięciolinia", "Klucz"], poprawna: 1 },
    { pytanie: "Który instrument ma struny i jest smyczkowy?", odpowiedzi: ["Gitara", "Skrzypce", "Flet"], poprawna: 1 },
    { pytanie: "Jak nazywa się osoba dyrygująca orkiestrą?", odpowiedzi: ["Konferansjer", "Dyrygent", "Kompozytor"], poprawna: 1 },
    { pytanie: "Co oznacza termin 'forte' w zapisie muzycznym?", odpowiedzi: ["Cicho", "Głośno", "Wolno"], poprawna: 1 },
    { pytanie: "Instrument klawiszowy elektroniczny to:", odpowiedzi: ["Syntezator", "Saksofon", "Obój"], poprawna: 0 },
  ],
};
function startQuiz(): void { 
  console.log("Witamy w naszym quizie!"); 
  console.log("Wybierz kategorię pytań:"); 
  
  Object.keys(kategorie).forEach((kategoria, index)  => { 
    console.log(`${index + 1}. ${kategoria}`); 
  }); 
  
  rl.question("Podaj numer kategorii: ", (input) => { 
    const numerKategorii = parseInt(input); 
    const nazwaKategorii =  
    Object.keys(kategorie)[numerKategorii - 1]; 
  
    if (!nazwaKategorii) { 
      console.log("Nieprawidłowy wybór kategorii. Uruchom grę ponownie."); 
      rl.close(); 
      return; 
    } 
  
    console.log(`Wybrano kategorię  ${nazwaKategorii}`); 
    gra(kategorie[nazwaKategorii]!); 
  }); 
} 
function gra(pytania: Pytanie[]): void { 
  let poprawneOdpowiedzi = 0; 
  let indeksPytania = 0; 
  
  function zapytaj(): void { 
    if (indeksPytania >= pytania.length) { 
      console.log(`Koniec quizu! Poprawne odpowiedzi: ${poprawneOdpowiedzi}/${pytania.length}`); 
      rl.close(); 
      return; 
    } 
  
    const aktualnePytanie = pytania[indeksPytania]; 
    console.log(`Pytanie ${indeksPytania + 1}: ${aktualnePytanie!.pytanie}`); 
    aktualnePytanie!.odpowiedzi.forEach((odpowiedz, index) => { 
      console.log(`${index + 1}. ${odpowiedz}`); 
    }); 
  
    rl.question("Podaj numer odpowiedzi: ", (input) => { 
      const wybranaOdpowiedz = parseInt(input) - 1; 
  
      if (wybranaOdpowiedz === aktualnePytanie!.poprawna) { 
        console.log("Brawo! Poprawna odpowiedź"); 
        poprawneOdpowiedzi++; 
      } else { 
        console.log("Niestety błędna odpowiedź"); 
      } 
      indeksPytania++; 
      zapytaj(); 
    }); 
  } 
  zapytaj(); 
} 
startQuiz();