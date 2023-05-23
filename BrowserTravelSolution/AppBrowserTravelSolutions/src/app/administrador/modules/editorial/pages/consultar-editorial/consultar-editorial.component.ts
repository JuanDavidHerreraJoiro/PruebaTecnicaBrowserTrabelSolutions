import { Component, OnInit } from '@angular/core';
import Swal from 'sweetalert2';
import { Editorial } from '../../class/editorial';
import { EditorialService } from '../../services/editorial.service';
import { switchMap } from 'rxjs';

@Component({
  selector: 'app-consultar-editorial',
  templateUrl: './consultar-editorial.component.html',
  styleUrls: ['./consultar-editorial.component.css']
})
export class ConsultarEditorialComponent implements OnInit  {
  
  editoriales: Editorial[] = [];

  constructor(private editorialService: EditorialService,) { }

  ngOnInit(): void {
    this.editorialService.get().subscribe(editoriales => {
      this.editoriales = editoriales;
    });
  }

  registrar(){
    
  }

  eliminar(editorial: Editorial) {
    
    this.editorialService.delete(editorial.id!)
    .pipe(
      switchMap((_) => this.editorialService.get())
    )
    .subscribe(resp => this.editoriales = resp);
  }

  mensajeError(){
    Swal.fire({
      icon: 'error',
      title: 'Oops...',
      text: 'Editorial eliminada'
    });
  }
}
