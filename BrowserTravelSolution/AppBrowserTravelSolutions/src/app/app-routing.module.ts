import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path:'',
    redirectTo: "Travel",
    pathMatch: 'full'
  },
  {
    path: 'Travel',
    loadChildren: () => import('./administrador/administrador.module').then(m => m.AdministradorModule),
  },
  {
    path: '**',
    redirectTo: "Travel"
    
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
