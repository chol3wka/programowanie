import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class KalkulatorS {
  constructor() {}

  dodaj(...liczby: number[]): number {
    let wynik = 0;
    for(let wartosci of liczby){
      wynik += wartosci;
    }
    return wynik;
  }
  odejmij(...liczby: number[]): number{
    let wynik = liczby[0];
    for(let i = 1; i < liczby.length; i++){
      wynik -= liczby[i];
    }
    return wynik;
  }
  pomnoz(...liczby: number[]): number {
    let wynik = 1;
    for(let wartosci of liczby){
      wynik *= wartosci;
    }
    return wynik;
  }
  podziel(...liczby: number[]): number {
    let wynik = liczby[0];
    for(let i = 1; i < liczby.length; i++){
      wynik /= liczby[i];
    }
    return wynik;
  }
}
