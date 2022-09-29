import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { InicioComponent } from './components/inicio/inicio.component';
import { ArticuloFamiliasComponent } from './components/articulo-familias/articulo-familias.component';

import { NgbPaginationModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  imports: [BrowserModule, FormsModule, NgbPaginationModule, HttpClientModule],
  declarations: [AppComponent, InicioComponent, ArticuloFamiliasComponent],
  bootstrap: [AppComponent],
})
export class AppModule {}
