import { Component, OnInit, ViewChild } from '@angular/core';
import { MatSidenav } from '@angular/material/sidenav';
import { BreakpointObserver, Breakpoints, BreakpointState } from '@angular/cdk/layout';
import { delay } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  @ViewChild(MatSidenav) sidenav!: MatSidenav;

  sticky: boolean = false;
  cambiar: boolean = true;
  nombre: string = "Juan David Herrera Joiro";

  constructor(
    private breakpointObserver: BreakpointObserver,

  ) { }

  ngOnInit(): void {
    this.breakpointObserver
      .observe([
        Breakpoints.Medium,
        Breakpoints.Small,
        Breakpoints.XSmall
      ])
      .pipe(delay(1))
      .subscribe((state: BreakpointState) => {
        if (this.sidenav) {
          if (state.matches) {
            this.sidenav.mode = 'over';
            this.sidenav.close();
          } else {
            this.sidenav.mode = 'side';
            this.sidenav.open();
          }
        }
      });
  }

  cerrarSidenav() {
    if (this.sidenav.mode === "over") {
      this.sidenav.toggle()
    }
  }

  CambiarIcono() {
    return this.cambiar = this.cambiar ? false : true;
  }
}
