import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ConsultarAutorComponent } from './pages/consultar-autor/consultar-autor.component';
import { DetalleLibroByAutorComponent } from './pages/detalle-libro-by-autor/detalle-libro-by-autor.component';

const routes: Routes = [
  {
    path: "consultar-autor",
    component: ConsultarAutorComponent
  },
  {
    path: 'detalle-libro-by-autor/:id',
    component: DetalleLibroByAutorComponent
  },
  {
    path: '**',
    redirectTo: 'consultar-autor'
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AutorRoutingModule { }
