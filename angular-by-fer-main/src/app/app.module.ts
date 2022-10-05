import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http'

import { AppComponent } from './app.component';
import { InicioComponent } from './components/inicio/inicio.component';
import { MenuComponent } from './components/menu/menu.component';
import { ArticuloFamiliasComponent } from './components/articulo-familias/articulo-familias.component';

import { RouterModule } from '@angular/router';
import {APP_BASE_HREF} from '@angular/common';
import { ArticulosComponent } from './components/articulos/articulos.component';

import { ReactiveFormsModule } from "@angular/forms";
import { NombreArticulosPipe } from './pipes/nombre-articulos.pipe';

@NgModule({
  declarations: [
    AppComponent,
    InicioComponent,
    ArticuloFamiliasComponent,
    MenuComponent,
    ArticulosComponent,
    NombreArticulosPipe
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', redirectTo: '/inicio', pathMatch: 'full' },
      { path: 'inicio', component: InicioComponent },
      { path: 'articulosfamilias', component: ArticuloFamiliasComponent },
      { path: 'articulos', component: ArticulosComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
