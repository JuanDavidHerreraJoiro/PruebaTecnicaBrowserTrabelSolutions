import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InputFiltroComponent } from './components/input-filtro/input-filtro.component';
import { SpinnerComponent } from './components/spinner/spinner.component';
import { FlexLayoutModule } from '@angular/flex-layout';
import { RouterModule } from '@angular/router';
import { PrimeNgModule } from 'src/app/design-modules/prime-ng.module';
import { MaterialModule } from 'src/app/design-modules/material.module';

@NgModule({
  declarations: [
    InputFiltroComponent,
    SpinnerComponent   
  ],
  imports: [
    CommonModule,
    RouterModule,
    MaterialModule,
    PrimeNgModule,
    FlexLayoutModule,
  ],
  exports: [
    InputFiltroComponent,
    SpinnerComponent
  ]
})
export class SharedModule { }
