import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AutorModule } from './modules/autor/autor.module';

const routes: Routes = [
  {
    path: '',
    component: HomeComponent,
    children: [
      {
        path: 'autor',
        loadChildren: () => import('../administrador/modules/autor/autor.module').then(m => m.AutorModule)
      },
      {
        path: 'libro',
        loadChildren: () => import('../administrador/modules/libro/libro.module').then(m => m.LibroModule)
      },
      {
        path: 'editorial',
        loadChildren: () => import('../administrador/modules/editorial/editorial.module').then(m => m.EditorialModule)
      },
      {
        path: '**',
        redirectTo: 'autor'
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdministradorRoutingModule { }
