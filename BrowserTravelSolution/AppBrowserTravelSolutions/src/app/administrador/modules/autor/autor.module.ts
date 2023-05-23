import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ConsultarAutorComponent } from './pages/consultar-autor/consultar-autor.component';
import { AutorRoutingModule } from './autor-routing.module';

import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { FlexLayoutModule } from '@angular/flex-layout';
import { PrimeNgModule } from '../../../design-modules/prime-ng.module';
import { MaterialModule } from '../../../design-modules/material.module';
import { DetalleLibroByAutorComponent } from './pages/detalle-libro-by-autor/detalle-libro-by-autor.component';


@NgModule({
  declarations: [
    ConsultarAutorComponent,
    DetalleLibroByAutorComponent
  ],
  imports: [
    CommonModule,
    AutorRoutingModule,
    ReactiveFormsModule,
    MaterialModule,
    PrimeNgModule,
    SharedModule,
    FlexLayoutModule,
  ]
})
export class AutorModule { }
