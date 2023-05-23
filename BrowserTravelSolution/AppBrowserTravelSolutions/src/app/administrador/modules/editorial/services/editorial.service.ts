import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, Subject, catchError, map, of } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Editorial } from '../class/editorial';

@Injectable({
  providedIn: 'root'
})

export class EditorialService {

  baseUrl: string = environment.baseUrl;
  private _refrescar$ = new Subject<void>();

  constructor(private http: HttpClient) { }

  get refrescar$(){
    return this._refrescar$;
  }

  get():Observable<Editorial[]> {
    return this.http.get<Editorial[]>(`${ this.baseUrl }/Editor`)
      .pipe(
        map(resp => {
          return resp;
        }),
        catchError(error => of(error))
      );
  }  

  getId(id: number) {
    return this.http.get<Editorial>(`${ this.baseUrl }/Editor/${ id }`)
      .pipe(
        map(resp => {
          return resp;
        }),
        catchError(error => of(error))
      );
  }

  post(editorial: Editorial) {
    return this.http.post<Editorial>(`${ this.baseUrl }/Editor`, editorial)
      .pipe(
        map(resp => {
          return resp;
        }),
        catchError(error => of(error))
      );
  }

  put(editorial: Editorial) {
    return this.http.put<Editorial>(`${ this.baseUrl }/Editor/${editorial.id}`, editorial)
      .pipe(
        map(resp => {
          return resp;
        }),
        catchError(error => of(error))
      );
  }

  delete(id: number) {
    return this.http.delete<string>(`${ this.baseUrl }/Editor/${ id }`)
      .pipe(
        map(resp => {
          return resp;
        }),
        catchError(error => of(error))
      );
  }
}
