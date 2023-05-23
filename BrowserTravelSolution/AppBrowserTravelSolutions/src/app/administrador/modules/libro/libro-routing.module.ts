import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ConsultarLibroComponent } from './pages/consultar-libro/consultar-libro.component';
import { DetalleAutorByLibroComponent } from './pages/detalle-autor-by-libro/detalle-autor-by-libro.component';

const routes: Routes = [
  {
    path: "consultar-libro",
    component: ConsultarLibroComponent
  },
  {
    path: 'detalle-autor-by-libro/:id',
    component: DetalleAutorByLibroComponent
  },
  {
    path: '**',
    redirectTo: 'consultar-libro'
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LibroRoutingModule { }
