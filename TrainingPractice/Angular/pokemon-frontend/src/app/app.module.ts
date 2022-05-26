import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ThisHomePageModule } from './this-home-page/this-home-page.module';
import { ThisWebPageComponent } from './this-web-page/this-web-page.component';
import { EarthHomeModule } from './earth-home/earth-home.module';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,
    ThisWebPageComponent
  ],
  imports: [
    BrowserModule,
    ThisHomePageModule,
    FormsModule,
    EarthHomeModule,
    Router
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
