import { Libro } from "../../libro/class/libro";

export class Autor {
    id?: number=0;
    nombre?: string;
    apellido?: string;
    libros?: Libro[] = [];
}