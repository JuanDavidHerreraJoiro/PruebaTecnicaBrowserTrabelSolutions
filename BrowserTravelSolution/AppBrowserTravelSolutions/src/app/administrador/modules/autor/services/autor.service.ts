import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, Subject, catchError, map, of } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Autor } from '../class/autor';

@Injectable({
  providedIn: 'root'
})

export class AutorService {

  baseUrl: string = environment.baseUrl;
  private _refrescar$ = new Subject<void>();

  constructor(private http: HttpClient) { }

  get refrescar$(){
    return this._refrescar$;
  }

  get():Observable<Autor[]> {
    return this.http.get<Autor[]>(`${ this.baseUrl }/Autor`)
      .pipe(
        map(resp => {
          return resp;
        }),
        catchError(error => of(error))
      );
  }  

  getId(id: number) {
    return this.http.get<Autor>(`${ this.baseUrl }/Autor/${ id }`)
      .pipe(
        map(resp => {
          return resp;
        }),
        catchError(error => of(error))
      );
  }

  post(autor: Autor) {
    return this.http.post<Autor>(`${ this.baseUrl }/Autor`, autor)
      .pipe(
        map(resp => {
          return resp;
        }),
        catchError(error => of(error))
      );
  }

  put(autor: Autor) {
    return this.http.put<Autor>(`${ this.baseUrl }/Autor/${autor.id}`, autor)
      .pipe(
        map(resp => {
          return resp;
        }),
        catchError(error => of(error))
      );
  }

  delete(id: number) {
    return this.http.delete<string>(`${ this.baseUrl }/Autor/${ id }`)
      .pipe(
        map(resp => {
          return resp;
        }),
        catchError(error => of(error))
      );
  }
}
