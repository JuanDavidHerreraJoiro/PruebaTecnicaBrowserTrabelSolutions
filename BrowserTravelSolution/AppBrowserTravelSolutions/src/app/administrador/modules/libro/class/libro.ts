import { Autor } from "../../autor/class/autor";
import { Editorial } from "../../editorial/class/editorial";

export class Libro {
    isbn?: number=0;
    editoriales_id?: number=0;
    editorial?: Editorial;
    titulo?:string;
    sinopsis?:string;
    n_paginas?:string;
    autores?: Autor[] = [];
    id_Autores?:any
}