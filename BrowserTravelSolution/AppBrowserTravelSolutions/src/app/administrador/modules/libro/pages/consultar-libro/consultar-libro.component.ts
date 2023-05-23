import { Component, OnInit } from '@angular/core';
import { Libro } from '../../class/libro';
import Swal from 'sweetalert2';
import { LibroService } from '../../services/libro.service';

@Component({
  selector: 'app-consultar-libro',
  templateUrl: './consultar-libro.component.html',
  styleUrls: ['./consultar-libro.component.css']
})
export class ConsultarLibroComponent implements OnInit {
  libros: Libro[] = [];

  constructor(private libroService: LibroService) { }

  ngOnInit(): void {
    this.libroService.get().subscribe(libros => {
      this.libros = libros;
    });
  }


  mensajeError(){
    Swal.fire({
      icon: 'error',
      title: 'Oops...',
      text: 'Autor eliminad@'
    });
  }
}
