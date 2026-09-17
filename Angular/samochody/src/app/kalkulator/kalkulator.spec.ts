import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Kalkulator } from './kalkulator';

describe('Kalkulator', () => {
  let component: Kalkulator;
  let fixture: ComponentFixture<Kalkulator>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Kalkulator],
    }).compileComponents();

    fixture = TestBed.createComponent(Kalkulator);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
