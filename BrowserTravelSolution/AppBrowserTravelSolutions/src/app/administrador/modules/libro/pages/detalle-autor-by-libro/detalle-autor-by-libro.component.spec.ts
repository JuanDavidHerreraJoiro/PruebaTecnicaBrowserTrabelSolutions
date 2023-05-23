import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetalleAutorByLibroComponent } from './detalle-autor-by-libro.component';

describe('DetalleAutorByLibroComponent', () => {
  let component: DetalleAutorByLibroComponent;
  let fixture: ComponentFixture<DetalleAutorByLibroComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DetalleAutorByLibroComponent]
    });
    fixture = TestBed.createComponent(DetalleAutorByLibroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
