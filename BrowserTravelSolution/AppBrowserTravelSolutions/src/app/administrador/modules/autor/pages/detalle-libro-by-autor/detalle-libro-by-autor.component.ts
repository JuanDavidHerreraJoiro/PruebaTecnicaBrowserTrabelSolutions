import { Component } from '@angular/core';
import { Autor } from '../../class/autor';
import { Libro } from '../../../libro/class/libro';
import { ActivatedRoute } from '@angular/router';
import { AutorService } from '../../services/autor.service';
import { switchMap } from 'rxjs';

@Component({
  selector: 'app-detalle-libro-by-autor',
  templateUrl: './detalle-libro-by-autor.component.html',
  styleUrls: ['./detalle-libro-by-autor.component.css']
})
export class DetalleLibroByAutorComponent {

  autor?: Autor;
  nombreAutor:string = "";
  libros: Libro[] = [];

  constructor(private autorService: AutorService,
              private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.activatedRoute.params
      .pipe(
        switchMap(({id}) => this.autorService.getId(id))
      )
      .subscribe(autor => {
        this.libros = autor.libros;
        this.nombreAutor = autor.nombre +" "+autor.apellido;
    });
  }

}
