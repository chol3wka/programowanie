import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Rodzaj, Samochod } from './interfejs_samochod';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [CommonModule, FormsModule, RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  samochody: Samochod[] = [
    {
      marka: "McLaren",
      model: "720S",
      zdjecie: "/images/mclaren.jpg",
      dane: [
        "do setki 3,5 s",
        "cena 0,5 mln euro"
      ],
      type: Rodzaj.sportowy
    },
    {
      marka: "Hummer",
      model: "H5",
      zdjecie: "/images/hummer.jpg",
      dane: [
        "do setki 18 s",
        "cena 250 000 euro"
      ],
      type: Rodzaj.terenowy
    },
    {
      marka: "Mercedes",
      model: "Vario Mobil Signature",
      zdjecie: "/images/mercedes.jpg",
      dane: [
        "do setki 32 s",
        "cena 0,8 mln euro"
      ],
      type: Rodzaj.kamper
    }
  ];

  samochod: Samochod = this.samochody[0];
  kolorback: string = "white";
  kolortekst: string = "black";
  aktywna: boolean = true;
  pokazZdjecie: boolean = false;
  
  Rodzaj = Rodzaj; 

  constructor() {}

  zmienKolor() {
    this.kolorback = this.kolorback === "white" ? "black" : "white";
    this.kolortekst = this.kolortekst === "black" ? "white" : "black";
  }
}
