import readline = require("readline");

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
})

function losujLiczbe(min: number, max: number): number{
    return Math.floor(Math.random()*(max - min +1))
    +min;
}
function startGra(): void{
    console.log("Witaj w grze `Zgadnij liczbe!`");
    console.log("Wybierz poziom trudności:");
    console.log("1. Łatwy (1-10, 5 prób)");
    console.log("2. Średni (1-50, 7 prób)");
    console.log("3. Trudny (1-100, 10 prób)");

    rl.question("Podaj numer poziomu (1,2 lub 3): ",(input)=>{
        const poziom = parseInt(input);
        let zakres: {min: number; max: number};
        let maxProby: number;
        switch (poziom){
            case 1:
                zakres = {min: 1, max: 10};
                maxProby = 5;
                break;
            case 2:
                zakres = {min: 1, max: 50};
                maxProby = 7;
                break;
            case 3:
                zakres = {min: 1, max: 100};
                maxProby = 10;
                break;
            default:
                console.log("Nieprawidłowy wybór, uruchom ponownie grę.");
                rl.close();
                return;

        }
        gra(zakres.min, zakres.max, maxProby);
    });
}

function gra(min: number, max: number, maxProby: number): void{
    const wylosowanaLiczba = losujLiczbe(min,max);
    let pozostaleProby = maxProby;
    console.log(`Wylosowano liczbę z zakresu ${min} do ${max}. Masz ${maxProby} prób.`);

    function zapytaj(): void { 
      if (pozostaleProby === 0) { 
         console.log("Niestety, skończyły Ci się próby! Przegrałeś!"); 
         console.log(`Poprawna liczba to: ${wylosowanaLiczba}`); 
         rl.close(); 
         return;
      }
       rl.question(`Podaj swoją propozycję (pozostało prób: ${pozostaleProby}): `, (input) => { 
         const propozycja = parseInt(input); 
         if (isNaN(propozycja)) { 
            console.log("Podana wartość nie jestliczbą. Spróbuj ponownie."); 
         } else if (propozycja < wylosowanaLiczba) { 
            console.log("Za mało!"); 
            pozostaleProby--; 
         } else if (propozycja > wylosowanaLiczba) { 
            console.log("Za dużo!"); 
            pozostaleProby--; 
         } else { 
            console.log("Brawo! Zgadłeś liczbę!"); 
            console.log(`Liczba prób, które Ci zostały: ${pozostaleProby - 1}`); 
            rl.close(); 
            return; 
         }
        zapytaj(); 
      }); 
   } 
    zapytaj(); 
} 
startGra(); 
