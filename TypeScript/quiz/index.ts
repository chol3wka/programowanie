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

const kategorie: Record<string, Pytanie[]> = {
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
    { pytanie: "Proces łączenia atomów to:", odpowiedzi: ["Reakcja", "Wiązanie", "Stopienie"], poprawna: 1 },
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
    { pytanie: "Co robi console.log()?", odpowiedzi: ["Zapisuje plik", "Wyświetla dane", "Tworzy bazę"], poprawna: 1 },
    { pytanie: "Sieć na dużym obszarze:", odpowiedzi: ["LAN", "WAN", "PAN"], poprawna: 1 },
    { pytanie: "Format bezstratny:", odpowiedzi: ["JPEG", "PNG", "MP3"], poprawna: 1 },
    { pytanie: "Algorytm to:", odpowiedzi: ["Zbiór kroków", "Język", "Zmienna"], poprawna: 0 },
  ],
  historia: [
    { pytanie: "II wojna światowa:", odpowiedzi: ["1914", "1939", "1945"], poprawna: 1 },
    { pytanie: "Pierwszy król Polski:", odpowiedzi: ["Mieszko I", "Bolesław Chrobry", "Kazimierz"], poprawna: 1 },
    { pytanie: "Egipt słynął z:", odpowiedzi: ["Akropolów", "Piramid", "Mostów"], poprawna: 1 },
    { pytanie: "Rewolucja francuska:", odpowiedzi: ["XVIII", "XIX", "XVII"], poprawna: 0 },
    { pytanie: "Kolumb odkrył:", odpowiedzi: ["Australia", "Ameryka", "Azja"], poprawna: 1 },
    { pytanie: "Akadia:", odpowiedzi: ["Egipt", "Mezopotamia", "Grecja"], poprawna: 1 },
    { pytanie: "Koniec średniowiecza:", odpowiedzi: ["Odkrycia", "Koło", "Lodowcowa"], poprawna: 0 },
    { pytanie: "Cezar był:", odpowiedzi: ["Cezar", "Aleksander", "Homer"], poprawna: 0 },
    { pytanie: "Grunwald:", odpowiedzi: ["1410", "1610", "1310"], poprawna: 0 },
    { pytanie: "Magna Carta:", odpowiedzi: ["Traktat", "Prawa króla", "Mapa"], poprawna: 1 },
  ],
  geografia: [
    { pytanie: "Stolica Polski:", odpowiedzi: ["Kraków", "Warszawa", "Gdańsk"], poprawna: 1 },
    { pytanie: "Najdłuższa rzeka:", odpowiedzi: ["Amazonka", "Nil", "Missisipi"], poprawna: 0 },
    { pytanie: "Najwyższy szczyt:", odpowiedzi: ["K2", "Everest", "Kilimandżaro"], poprawna: 1 },
    { pytanie: "Największy ocean:", odpowiedzi: ["Atlantycki", "Spokojny", "Indyjski"], poprawna: 1 },
    { pytanie: "Brazylia:", odpowiedzi: ["Afryka", "Ameryka Południowa", "Europa"], poprawna: 1 },
    { pytanie: "Paryż:", odpowiedzi: ["Lyon", "Marsylia", "Paryż"], poprawna: 2 },
    { pytanie: "Państwo śródlądowe:", odpowiedzi: ["Wyspa", "Kraj bez morza", "Półwysep"], poprawna: 1 },
    { pytanie: "Archipelag:", odpowiedzi: ["Wyspa", "Zespół wysp", "Góry"], poprawna: 1 },
    { pytanie: "Morze Kaspijskie:", odpowiedzi: ["Największe jezioro", "Rzeka", "Ocean"], poprawna: 0 },
    { pytanie: "Alpy:", odpowiedzi: ["Europa", "Azja", "Afryka"], poprawna: 0 },
  ],
  biologia: [
    { pytanie: "Komórka to jednostka:", odpowiedzi: ["Materii", "Życia", "Ziemi"], poprawna: 1 },
    { pytanie: "DNA to:", odpowiedzi: ["RNA", "DNA", "ATP"], poprawna: 1 },
    { pytanie: "Fotosynteza:", odpowiedzi: ["Roślina", "Ssak", "Grzyb"], poprawna: 0 },
    { pytanie: "Fotosynteza zachodzi w:", odpowiedzi: ["Mitochondria", "Chloroplasty", "Jądro"], poprawna: 1 },
    { pytanie: "Układ krążenia:", odpowiedzi: ["Nerwowy", "Oddechowy", "Krążenia"], poprawna: 2 },
    { pytanie: "Mitoza to:", odpowiedzi: ["Podział komórki", "Białko", "Tłuszcz"], poprawna: 0 },
    { pytanie: "Ssak:", odpowiedzi: ["Karp", "Orzeł", "Delfin"], poprawna: 2 },
    { pytanie: "Tlen w krwi:", odpowiedzi: ["Glukoza", "Hemoglobina", "Woda"], poprawna: 1 },
    { pytanie: "Botanika:", odpowiedzi: ["Rośliny", "Zwierzęta", "Góry"], poprawna: 0 },
    { pytanie: "Największy narząd:", odpowiedzi: ["Skóra", "Wątroba", "Płuca"], poprawna: 0 },
  ],
  sport: [
    { pytanie: "Piłka nożna:", odpowiedzi: ["60", "90", "120"], poprawna: 1 },
    { pytanie: "Koszykówka 3 pkt:", odpowiedzi: ["2", "3", "1"], poprawna: 1 },
    { pytanie: "Piłka nożna graczy:", odpowiedzi: ["11", "9", "7"], poprawna: 0 },
    { pytanie: "Kort:", odpowiedzi: ["Tenis", "Hokej", "Rugby"], poprawna: 0 },
    { pytanie: "Igrzyska:", odpowiedzi: ["2", "4", "5"], poprawna: 1 },
    { pytanie: "Home run:", odpowiedzi: ["Baseball", "Kosz", "Piłka"], poprawna: 0 },
    { pytanie: "Rakieta + lotka:", odpowiedzi: ["Badminton", "Tenis", "Squash"], poprawna: 0 },
    { pytanie: "Welodrom:", odpowiedzi: ["Autodrom", "Rower", "Stadion"], poprawna: 1 },
    { pytanie: "Narciarstwo:", odpowiedzi: ["Alpejskie", "Skoki", "Hokej"], poprawna: 0 },
    { pytanie: "Tenis GS:", odpowiedzi: ["2/3", "3/5", "1/1"], poprawna: 1 },
  ],
  muzyka: [
    { pytanie: "Fortepian to instrument:", odpowiedzi: ["Klawisz", "Dęty", "Smyczkowy"], poprawna: 0 },
    { pytanie: "Nuty:", odpowiedzi: ["7", "5", "12"], poprawna: 0 },
    { pytanie: "Pauza:", odpowiedzi: ["Dźwięk", "Cisza", "Rytm"], poprawna: 1 },
    { pytanie: "Klarnet to instrument:", odpowiedzi: ["Dęty", "Smyczkowy", "Elektroniczny"], poprawna: 0 },
    { pytanie: "Tempo:", odpowiedzi: ["Szybkość", "Głośność", "Wysokość"], poprawna: 0 },
    { pytanie: "Pięciolinia:", odpowiedzi: ["Zapis nut", "Instrument", "Dźwięk"], poprawna: 0 },
    { pytanie: "Skrzypce to instrument:", odpowiedzi: ["Smyczkowy", "Dęty", "Klawisz"], poprawna: 0 },
    { pytanie: "Dyrygent to:", odpowiedzi: ["Orkiestra", "Wokalista", "Kompozytor"], poprawna: 0 },
    { pytanie: "Forte:", odpowiedzi: ["Cicho", "Głośno", "Wolno"], poprawna: 1 },
    { pytanie: "Syntezator:", odpowiedzi: ["Elektroniczny", "Dęty", "Smyczkowy"], poprawna: 0 },
  ],
};

function tasuj<T>(t: T[]): T[] {
  const kopia = [...t];
  for (let i = kopia.length - 1; i > 0; i--) {
    const j = Math.floor(Math.random() * (i + 1));
    const temp = kopia[i];
    if (temp !== undefined) {
      kopia[i] = kopia[j] as T;
      kopia[j] = temp;
    }
  }
  return kopia;
}

function gra(pytania: Pytanie[]) {
  let pkt = 0;
  let i = 0;

  function next() {
    if (i >= pytania.length) {
      console.log(`\nKoniec quizu! Wynik: ${pkt}/${pytania.length}`);
      rl.close();
      return;
    }

    const q = pytania[i];
    if (!q) return;

    console.log(`\n${q.pytanie}`);
    q.odpowiedzi.forEach((o, idx) => console.log(`${idx + 1}. ${o}`));

    rl.question("Odpowiedź: ", (a) => {
      const wybor = parseInt(a) - 1;
      if (wybor === q.poprawna) {
        console.log("Dobrze!");
        pkt++;
      } else {
        console.log(`Błąd! Poprawna odpowiedź to: ${q.odpowiedzi[q.poprawna]}`);
      }
      i++;
      next();
    });
  }
  next();
}

function startQuiz(): void {
  console.log("1. Wybierz kategorię");
  console.log("2. Losowa kategoria");

  rl.question("Wybierz opcję: ", (w) => {
    const keys = Object.keys(kategorie);
    
    if (w === "2") {
      const losowa = keys[Math.floor(Math.random() * keys.length)];
      if (losowa) {
        const wybrane = kategorie[losowa];
        if (wybrane) {
          console.log(`Kategoria: ${losowa}`);
          gra(tasuj(wybrane));
        }
      }
    } else {
      keys.forEach((k, idx) => console.log(`${idx + 1}. ${k}`));
      rl.question("Podaj numer: ", (n) => {
        const key = keys[parseInt(n) - 1];
        if (key) {
          const wybrane = kategorie[key];
          if (wybrane) {
            gra(tasuj(wybrane));
          }
        } else {
          console.log("Nie ma takiej kategorii.");
          rl.close();
        }
      });
    }
  });
}

startQuiz();