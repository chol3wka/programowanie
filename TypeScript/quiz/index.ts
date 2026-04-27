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
    { pytanie: "Ile wynosi 2+2?", odpowiedzi: ["3", "4", "5"], poprawna: 1 },
    { pytanie: "Pierwiastek kwadratowy z 16 to:", odpowiedzi: ["2", "4", "8"], poprawna: 1 },
    { pytanie: "Ile wynosi 7 * 8?", odpowiedzi: ["56", "48", "64"], poprawna: 0 },
    { pytanie: "Ile wynosi 100 / 4?", odpowiedzi: ["20", "25", "30"], poprawna: 1 },
    { pytanie: "Co to jest liczba pierwsza?", odpowiedzi: ["Dzieli się tylko przez 1 i siebie", "Jest parzysta", "Jest większa niż 10"], poprawna: 0 },
    { pytanie: "Ile wynosi 5^2?", odpowiedzi: ["10", "25", "15"], poprawna: 1 },
    { pytanie: "Ile wynosi 9 * 9?", odpowiedzi: ["81", "72", "99"], poprawna: 0 },
    { pytanie: "Ile wynosi 12 / 3?", odpowiedzi: ["4", "6", "3"], poprawna: 0 },
    { pytanie: "Ile wynosi 15 - 7?", odpowiedzi: ["8", "7", "6"], poprawna: 0 },
    { pytanie: "Ile wynosi 3 * 4?", odpowiedzi: ["12", "9", "16"], poprawna: 0 },
    { pytanie: "Ile wynosi 100 - 25?", odpowiedzi: ["75", "50", "25"], poprawna: 0 },
    { pytanie: "Ile wynosi 8 + 7?", odpowiedzi: ["15", "16", "14"], poprawna: 0 },
  ],
  chemia: [
    { pytanie: "H to symbol chemiczny:", odpowiedzi: ["Wodoru", "Helu", "Węgla"], poprawna: 0 },
    { pytanie: "Wzór chemiczny dwutlenku węgla to:", odpowiedzi: ["CO", "CO2", "C2O"], poprawna: 1 },
    { pytanie: "Naładowanie protonu to:", odpowiedzi: ["Dodatnie", "Ujemne", "Obojętne"], poprawna: 0 },
    { pytanie: "Woda w stanie ciekłym wrze w temperaturze:", odpowiedzi: ["0°C", "50°C", "100°C"], poprawna: 2 },
    { pytanie: "Gaz szlachetny to:", odpowiedzi: ["Tlen", "Hel", "Azot"], poprawna: 1 },
    { pytanie: "Symbol chemiczny sodu to:", odpowiedzi: ["Na", "S", "So"], poprawna: 0 },
    { pytanie: "Kwas siarkowy ma wzór:", odpowiedzi: ["H2SO4", "HCl", "H2O"], poprawna: 0 },
    { pytanie: "Stan skupienia tlenu w temperaturze pokojowej to:", odpowiedzi: ["Gaz", "Ciecz", "Ciało stałe"], poprawna: 0 },
    { pytanie: "Pierwiastek o liczbie atomowej 1 to:", odpowiedzi: ["Wodór", "Hel", "Lit"], poprawna: 0 },
    { pytanie: "Woda to związek:", odpowiedzi: ["H2O", "CO2", "O2"], poprawna: 0 },
    { pytanie: "Cząsteczka wody składa się z:", odpowiedzi: ["2 atomów wodoru i 1 tlenu", "1 atomu wodoru i 2 tlenu", "3 atomów wodoru"], poprawna: 0 },
    { pytanie: "pH 7 oznacza:", odpowiedzi: ["Obojętne", "Kwasowe", "Zasadowe"], poprawna: 0 },
  ],
  informatyka: [
    { pytanie: "Co oznacza skrót RAM?", odpowiedzi: ["Random Access Memory", "Read Access Memory", "Rapid Access Memory"], poprawna: 0 },
    { pytanie: "Język używany do stylizacji stron WWW to:", odpowiedzi: ["HTML", "CSS", "JavaScript"], poprawna: 1 },
    { pytanie: "System operacyjny to:", odpowiedzi: ["Windows", "Excel", "Chrome"], poprawna: 0 },
    { pytanie: "Co to jest zmienna w programowaniu?", odpowiedzi: ["Stała wartość", "Miejsce do przechowywania danych", "Rodzaj funkcji"], poprawna: 1 },
    { pytanie: "Co robi funkcja console.log() w JavaScript?", odpowiedzi: ["Wyświetla dane w konsoli", "Zapisuje dane do pliku", "Tworzy zmienną"], poprawna: 0 },
    { pytanie: "Skrót CPU oznacza:", odpowiedzi: ["Central Processing Unit", "Central Power Unit", "Control Processing Unit"], poprawna: 0 },
    { pytanie: "HTML to:", odpowiedzi: ["Język znaczników", "Język programowania", "System operacyjny"], poprawna: 0 },
    { pytanie: "CSS służy do:", odpowiedzi: ["Stylizacji stron", "Tworzenia baz danych", "Pisania algorytmów"], poprawna: 0 },
    { pytanie: "JavaScript to:", odpowiedzi: ["Język programowania", "Framework", "System operacyjny"], poprawna: 0 },
    { pytanie: "Co oznacza skrót API?", odpowiedzi: ["Application Programming Interface", "Advanced Programming Interface", "Application Process Interface"], poprawna: 0 },
    { pytanie: "Co to jest Git?", odpowiedzi: ["System kontroli wersji", "Język programowania", "Baza danych"], poprawna: 0 },
    { pytanie: "Co to jest IDE?", odpowiedzi: ["Zintegrowane środowisko programistyczne", "System operacyjny", "Framework"], poprawna: 0 },
  ],
  historia: [
    { pytanie: "W którym roku rozpoczęła się II wojna światowa?", odpowiedzi: ["1939", "1945", "1914"], poprawna: 0 },
    { pytanie: "Pierwszy król Polski to:", odpowiedzi: ["Mieszko I", "Bolesław Chrobry", "Kazimierz Wielki"], poprawna: 1 },
    { pytanie: "Rewolucja francuska miała miejsce w roku:", odpowiedzi: ["1789", "1815", "1848"], poprawna: 0 },
    { pytanie: "Kolumb odkrył Amerykę w roku:", odpowiedzi: ["1492", "1500", "1519"], poprawna: 0 },
    { pytanie: "Bitwa pod Grunwaldem miała miejsce w roku:", odpowiedzi: ["1410", "1400", "1420"], poprawna: 0 },
    { pytanie: "W którym roku upadło Cesarstwo Rzymskie?", odpowiedzi: ["476", "1453", "1492"], poprawna: 0 },
    { pytanie: "Kiedy Polska odzyskała niepodległość?", odpowiedzi: ["1918", "1920", "1939"], poprawna: 0 },
    { pytanie: "Kto był pierwszym prezydentem USA?", odpowiedzi: ["George Washington", "Abraham Lincoln", "Thomas Jefferson"], poprawna: 0 },
    { pytanie: "W którym roku wybuchła I wojna światowa?", odpowiedzi: ["1914", "1918", "1939"], poprawna: 0 },
    { pytanie: "Kiedy miała miejsce bitwa pod Waterloo?", odpowiedzi: ["1815", "1805", "1820"], poprawna: 0 },
    { pytanie: "Kto był wodzem wojsk napoleońskich?", odpowiedzi: ["Napoleon Bonaparte", "Juliusz Cezar", "Aleksander Wielki"], poprawna: 0 },
    { pytanie: "W którym roku miała miejsce Unia Lubelska?", odpowiedzi: ["1569", "1410", "1795"], poprawna: 0 },
  ],
  literatura: [
    { pytanie: "Kto napisał 'Pana Tadeusza'?", odpowiedzi: ["Adam Mickiewicz", "Juliusz Słowacki", "Henryk Sienkiewicz"], poprawna: 0 },
    { pytanie: "Autor 'Lalki' to:", odpowiedzi: ["Bolesław Prus", "Stefan Żeromski", "Henryk Sienkiewicz"], poprawna: 0 },
    { pytanie: "Kto napisał 'Krzyżaków'?", odpowiedzi: ["Henryk Sienkiewicz", "Adam Mickiewicz", "Juliusz Słowacki"], poprawna: 0 },
    { pytanie: "Kto jest autorem 'Dziadów'?", odpowiedzi: ["Adam Mickiewicz", "Juliusz Słowacki", "Cyprian Kamil Norwid"], poprawna: 0 },
    { pytanie: "Kto napisał 'Potop'?", odpowiedzi: ["Henryk Sienkiewicz", "Bolesław Prus", "Stefan Żeromski"], poprawna: 0 },
    { pytanie: "Kto jest autorem 'Ferdydurke'?", odpowiedzi: ["Witold Gombrowicz", "Bruno Schulz", "Stanisław Lem"], poprawna: 0 },
    { pytanie: "Kto napisał 'Wesele'?", odpowiedzi: ["Stanisław Wyspiański", "Juliusz Słowacki", "Adam Mickiewicz"], poprawna: 0 },
    { pytanie: "Kto jest autorem 'Chłopów'?", odpowiedzi: ["Władysław Reymont", "Henryk Sienkiewicz", "Bolesław Prus"], poprawna: 0 },
    { pytanie: "Kto napisał 'Zbrodnię i karę'?", odpowiedzi: ["Fiodor Dostojewski", "Lew Tołstoj", "Anton Czechow"], poprawna: 0 },
    { pytanie: "Kto jest autorem 'Mistrza i Małgorzaty'?", odpowiedzi: ["Michaił Bułhakow", "Fiodor Dostojewski", "Lew Tołstoj"], poprawna: 0 },
    { pytanie: "Kto napisał 'Hamleta'?", odpowiedzi: ["William Shakespeare", "Charles Dickens", "George Orwell"], poprawna: 0 },
    { pytanie: "Kto jest autorem 'Roku 1984'?", odpowiedzi: ["George Orwell", "Aldous Huxley", "Ray Bradbury"], poprawna: 0 },
  ],
  fizyka: [
    { pytanie: "Jednostka siły to:", odpowiedzi: ["Newton", "Joule", "Watt"], poprawna: 0 },
    { pytanie: "Prędkość światła wynosi:", odpowiedzi: ["300 000 km/s", "150 000 km/s", "100 000 km/s"], poprawna: 0 },
    { pytanie: "Prawo grawitacji sformułował:", odpowiedzi: ["Isaac Newton", "Albert Einstein", "Galileusz"], poprawna: 0 },
    { pytanie: "Jednostka energii to:", odpowiedzi: ["Joule", "Newton", "Watt"], poprawna: 0 },
    { pytanie: "Cząstka elementarna to:", odpowiedzi: ["Proton", "Atom", "Molekuła"], poprawna: 0 },
    { pytanie: "Co to jest praca w fizyce?", odpowiedzi: ["Energia przenoszona przez siłę", "Siła działająca na ciało", "Prędkość ciała"], poprawna: 0 },
    { pytanie: "Jednostka mocy to:", odpowiedzi: ["Watt", "Joule", "Newton"], poprawna: 0 },
    { pytanie: "Kto sformułował teorię względności?", odpowiedzi: ["Albert Einstein", "Isaac Newton", "Galileusz"], poprawna: 0 },
    { pytanie: "Fala elektromagnetyczna to:", odpowiedzi: ["Światło", "Dźwięk", "Ciepło"], poprawna: 0 },
    { pytanie: "Co to jest opór elektryczny?", odpowiedzi: ["Przeciwstawianie się przepływowi prądu", "Prąd elektryczny", "Napięcie elektryczne"], poprawna: 0 },
    { pytanie: "Jednostka napięcia to:", odpowiedzi: ["Volt", "Ampere", "Ohm"], poprawna: 0 },
    { pytanie: "Co to jest masa?", odpowiedzi: ["Ilość materii w ciele", "Siła działająca na ciało", "Prędkość ciała"], poprawna: 0 },
  ],
  sztuka: [
    { pytanie: "Kto namalował 'Mona Lisę'?", odpowiedzi: ["Leonardo da Vinci", "Vincent van Gogh", "Pablo Picasso"], poprawna: 0 },
    { pytanie: "Kto stworzył 'Dawida'?", odpowiedzi: ["Michał Anioł", "Leonardo da Vinci", "Donatello"], poprawna: 0 },
    { pytanie: "Kto namalował 'Gwiaździstą noc'?", odpowiedzi: ["Vincent van Gogh", "Claude Monet", "Salvador Dalí"], poprawna: 0 },
    { pytanie: "Kto jest autorem 'Krzyku'?", odpowiedzi: ["Edvard Munch", "Pablo Picasso", "Salvador Dalí"], poprawna: 0 },
    { pytanie: "Kto stworzył 'Ostatnią Wieczerzę'?", odpowiedzi: ["Leonardo da Vinci", "Michał Anioł", "Rafael"], poprawna: 0 },
    { pytanie: "Kto jest autorem 'Guerniki'?", odpowiedzi: ["Pablo Picasso", "Salvador Dalí", "Joan Miró"], poprawna: 0 },
    { pytanie: "Kto namalował 'Słoneczniki'?", odpowiedzi: ["Vincent van Gogh", "Claude Monet", "Paul Cézanne"], poprawna: 0 },
    { pytanie: "Kto stworzył 'Pocałunek'?", odpowiedzi: ["Gustav Klimt", "Edvard Munch", "Henri Matisse"], poprawna: 0 },
    { pytanie: "Kto jest autorem 'Narodzin Wenus'?", odpowiedzi: ["Sandro Botticelli", "Leonardo da Vinci", "Rafael"], poprawna: 0 },
    { pytanie: "Kto stworzył 'Kaplicę Sykstyńską'?", odpowiedzi: ["Michał Anioł", "Leonardo da Vinci", "Rafael"], poprawna: 0 },
    { pytanie: "Kto jest autorem 'Impresji, wschód słońca'?", odpowiedzi: ["Claude Monet", "Edgar Degas", "Pierre-Auguste Renoir"], poprawna: 0 },
    { pytanie: "Kto stworzył 'Myśliciela'?", odpowiedzi: ["Auguste Rodin", "Donatello", "Michał Anioł"], poprawna: 0 },
  ],
  astronomia: [
    { pytanie: "Największa planeta w Układzie Słonecznym to:", odpowiedzi: ["Jowisz", "Saturn", "Ziemia"], poprawna: 0 },
    { pytanie: "Słońce to:", odpowiedzi: ["Gwiazda", "Planeta", "Księżyc"], poprawna: 0 },
    { pytanie: "Księżyc Ziemi to:", odpowiedzi: ["Luna", "Europa", "Io"], poprawna: 0 },
    { pytanie: "Najbliższa gwiazda Ziemi to:", odpowiedzi: ["Słońce", "Proxima Centauri", "Alpha Centauri"], poprawna: 0 },
    { pytanie: "Pierścienie ma planeta:", odpowiedzi: ["Saturn", "Jowisz", "Uran"], poprawna: 0 },
    { pytanie: "Czerwona planeta to:", odpowiedzi: ["Mars", "Wenus", "Merkury"], poprawna: 0 },
    { pytanie: "Najmniejsza planeta w Układzie Słonecznym to:", odpowiedzi: ["Merkury", "Mars", "Pluton"], poprawna: 0 },
    { pytanie: "Planeta najbliższa Słońcu to:", odpowiedzi: ["Merkury", "Wenus", "Ziemia"], poprawna: 0 },
    { pytanie: "Galaktyka, w której znajduje się Ziemia to:", odpowiedzi: ["Droga Mleczna", "Andromeda", "Wielki Obłok Magellana"], poprawna: 0 },
    { pytanie: "Największy księżyc Jowisza to:", odpowiedzi: ["Ganimedes", "Europa", "Io"], poprawna: 0 },
    { pytanie: "Planeta znana jako 'Błękitny olbrzym' to:", odpowiedzi: ["Neptun", "Uran", "Saturn"], poprawna: 0 },
    { pytanie: "Kometa Halleya pojawia się co:", odpowiedzi: ["76 lat", "50 lat", "100 lat"], poprawna: 0 },
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