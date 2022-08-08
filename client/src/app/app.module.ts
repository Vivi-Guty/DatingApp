import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
<<<<<<< HEAD
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
=======

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
>>>>>>> fc16c54585148279ea0d1e64310a8585ba029c8c

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
<<<<<<< HEAD
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule
=======
    AppRoutingModule
>>>>>>> fc16c54585148279ea0d1e64310a8585ba029c8c
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
