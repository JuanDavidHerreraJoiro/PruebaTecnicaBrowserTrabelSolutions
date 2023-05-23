import { Component } from '@angular/core';
import { Libro } from '../../class/libro';
import { Autor } from '../../../autor/class/autor';
import { ActivatedRoute } from '@angular/router';
import { LibroService } from '../../services/libro.service';
import { switchMap } from 'rxjs';

@Component({
  selector: 'app-detalle-autor-by-libro',
  templateUrl: './detalle-autor-by-libro.component.html',
  styleUrls: ['./detalle-autor-by-libro.component.css']
})
export class DetalleAutorByLibroComponent {

  libro: any;
  nombreLibro:string = "";
  autores: Autor[] = [];

  constructor(private libroService: LibroService,
              private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.activatedRoute.params
      .pipe(
        switchMap(({id}) => this.libroService.getId(id))
      )
      .subscribe(libro => {
        this.libro = libro;
        this.autores = libro.autores;
        this.nombreLibro = libro.titulo;
    });
  }
}
