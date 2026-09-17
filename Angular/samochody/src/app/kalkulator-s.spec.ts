import { TestBed } from '@angular/core/testing';

import { KalkulatorS } from './kalkulator-s';

describe('KalkulatorS', () => {
  let service: KalkulatorS;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(KalkulatorS);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
