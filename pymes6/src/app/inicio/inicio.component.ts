import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-inicio',
  templateUrl: './inicio.component.html',
  styleUrls: ['./inicio.component.css']
})
export class InicioComponent implements OnInit {
  numero = 100;
  nombreEditable = 'Maria';
  casaPropia = false;
  obtenerNombre(){
    return 'juan';
  }

  cambiarNombre(){
    this.nombreEditable = 'Patricia';
  }

  casaPropiaCheck(){
    this.casaPropia = !this.casaPropia;
  }

  constructor() { }

  ngOnInit(): void {
  }

}
