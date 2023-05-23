import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ConsultarEditorialComponent } from './pages/consultar-editorial/consultar-editorial.component';
import { FlexLayoutModule } from '@angular/flex-layout';
import { ReactiveFormsModule } from '@angular/forms';
import { EditorialRoutingModule } from './editorial-routing.module';
import { SharedModule } from '../shared/shared.module';
import { PrimeNgModule } from '../../../design-modules/prime-ng.module';
import { MaterialModule } from '../../../design-modules/material.module';

@NgModule({
  declarations: [
    ConsultarEditorialComponent
  ],
  imports: [
    CommonModule,
    EditorialRoutingModule,
    ReactiveFormsModule,
    MaterialModule,
    PrimeNgModule,
    SharedModule,
    FlexLayoutModule,
  ]
})
export class EditorialModule { }
