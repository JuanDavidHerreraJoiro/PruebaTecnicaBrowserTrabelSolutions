import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsultarEditorialComponent } from './consultar-editorial.component';

describe('ConsultarEditorialComponent', () => {
  let component: ConsultarEditorialComponent;
  let fixture: ComponentFixture<ConsultarEditorialComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ConsultarEditorialComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ConsultarEditorialComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
