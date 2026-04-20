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
    { 
      pytanie: "Ile wynosi 2+2?", 
      odpowiedzi: ["2", "4", "6"], 
     poprawna: 1, 
    }, 
    { 
      pytanie: "Pierwiastek sześcienny z 27 to:", 
      odpowiedzi: ["12", "18", "3"], 
      poprawna: 2, 
    }, 
  ], 
  chemia: [ 
    { 
      pytanie: "P to symbol chemiczny:", 
      odpowiedzi: ["Fosforu", "Potasu", "Fluoru"], 
      poprawna: 0, 
    }, 
    { 
      pytanie: "Wzór chemiczny wody to:", 
      odpowiedzi: ["CO2", "O2", "H2O"], 
      poprawna: 2, 
    }, 
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