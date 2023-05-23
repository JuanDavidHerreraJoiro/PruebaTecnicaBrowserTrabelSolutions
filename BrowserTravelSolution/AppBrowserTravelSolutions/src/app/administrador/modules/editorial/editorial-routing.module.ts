import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ConsultarEditorialComponent } from './pages/consultar-editorial/consultar-editorial.component';

const routes: Routes = [
  {
    path: "consultar-editorial",
    component: ConsultarEditorialComponent
  },
  {
    path: '**',
    redirectTo: 'consultar-editorial'
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EditorialRoutingModule { }
