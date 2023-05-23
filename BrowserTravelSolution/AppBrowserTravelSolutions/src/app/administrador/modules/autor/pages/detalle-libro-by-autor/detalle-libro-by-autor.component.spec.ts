import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetalleLibroByAutorComponent } from './detalle-libro-by-autor.component';

describe('DetalleLibroByAutorComponent', () => {
  let component: DetalleLibroByAutorComponent;
  let fixture: ComponentFixture<DetalleLibroByAutorComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DetalleLibroByAutorComponent]
    });
    fixture = TestBed.createComponent(DetalleLibroByAutorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
