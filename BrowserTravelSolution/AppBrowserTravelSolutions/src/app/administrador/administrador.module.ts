import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdministradorRoutingModule } from './administrador-routing.module';
import { HomeComponent } from './home/home.component';
import { ReactiveFormsModule } from '@angular/forms';
import { MaterialModule } from '../design-modules/material.module';
import { FlexLayoutModule } from '@angular/flex-layout';
import { PrimeNgModule } from '../design-modules/prime-ng.module';

@NgModule({
  declarations: [
    HomeComponent
  ],
  imports: [
    CommonModule,
    AdministradorRoutingModule,
    MaterialModule,
    PrimeNgModule,
    FlexLayoutModule,
    ReactiveFormsModule
  ]
})

export class AdministradorModule { }
