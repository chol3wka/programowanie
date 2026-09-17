import { Component } from '@angular/core';
import { KalkulatorS } from '../kalkulator-s';

@Component({
  selector: 'app-kalkulator',
  templateUrl: './kalkulator.html',
  styleUrl: './kalkulator.css',
  providers: [KalkulatorS]
})
export class Kalkulator {
  title = 'Kalkulator';
  dodawanie: number = 0;
  odejmowanie: number = 0;
  mnozenie: number = 0;
  dzielenie: number = 0;

  constructor(private kalkulatorService: KalkulatorS) {
    this.dodawanie = kalkulatorService.dodaj(3,6,7)
    this.odejmowanie = kalkulatorService.odejmij(7,6);
    this.mnozenie = kalkulatorService.pomnoz(3,6);
    this.dzielenie = kalkulatorService.podziel(9,3);
  }

}
