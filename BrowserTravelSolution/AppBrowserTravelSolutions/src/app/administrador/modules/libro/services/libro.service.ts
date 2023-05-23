import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, Subject, catchError, map, of } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Libro } from '../class/libro';


@Injectable({
  providedIn: 'root'
})

export class LibroService {

  baseUrl: string = environment.baseUrl;
  private _refrescar$ = new Subject<void>();

  constructor(private http: HttpClient) { }

  get refrescar$(){
    return this._refrescar$;
  }

  get():Observable<Libro[]> {
    return this.http.get<Libro[]>(`${ this.baseUrl }/Libro`)
      .pipe(
        map(resp => {
          return resp;
        }),
        catchError(error => of(error))
      );
  }  

  getId(id: number) {
    return this.http.get<Libro>(`${ this.baseUrl }/Libro/${ id }`)
      .pipe(
        map(resp => {
          return resp;
        }),
        catchError(error => of(error))
      );
  }

  post(libro: Libro) {
    return this.http.post<Libro>(`${ this.baseUrl }/Libro`, libro)
      .pipe(
        map(resp => {
          return resp;
        }),
        catchError(error => of(error))
      );
  }

  put(libro: Libro) {
    return this.http.put<Libro>(`${ this.baseUrl }/Libro/${libro.isbn}`, libro)
      .pipe(
        map(resp => {
          return resp;
        }),
        catchError(error => of(error))
      );
  }

  delete(id: number) {
    return this.http.delete<string>(`${ this.baseUrl }/Libro/${ id }`)
      .pipe(
        map(resp => {
          return resp;
        }),
        catchError(error => of(error))
      );
  }
}
