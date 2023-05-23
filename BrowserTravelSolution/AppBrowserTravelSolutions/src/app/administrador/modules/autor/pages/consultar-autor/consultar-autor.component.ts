import { Component, OnInit } from '@angular/core';
import { Autor } from '../../class/autor';
import { AutorService } from '../../services/autor.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-consultar-autor',
  templateUrl: './consultar-autor.component.html',
  styleUrls: ['./consultar-autor.component.css']
})
export class ConsultarAutorComponent implements OnInit{
  autores: Autor[] = [];

  constructor(private autorService: AutorService) { }

  ngOnInit(): void {
    this.autorService.get().subscribe(autores => {
      this.autores = autores;
    });
  }

  registrar(){
    
  }

  mensajeError(){
    Swal.fire({
      icon: 'error',
      title: 'Oops...',
      text: 'Autor eliminad@'
    });
  }
}
