import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { FlexLayoutModule } from '@angular/flex-layout';
import { PrimeNgModule } from '../../../design-modules/prime-ng.module';
import { MaterialModule } from '../../../design-modules/material.module';
import { ConsultarLibroComponent } from './pages/consultar-libro/consultar-libro.component';
import { LibroRoutingModule } from './libro-routing.module';
import { DetalleAutorByLibroComponent } from './pages/detalle-autor-by-libro/detalle-autor-by-libro.component';


@NgModule({
  declarations: [
    ConsultarLibroComponent,
    DetalleAutorByLibroComponent
  ],
  imports: [
    CommonModule,
    LibroRoutingModule,
    ReactiveFormsModule,
    MaterialModule,
    PrimeNgModule,
    SharedModule,
    FlexLayoutModule
  ]
})
export class LibroModule { }
