import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { OktaAuthModule, OKTA_CONFIG } from '@okta/okta-angular';
import { OktaAuth } from '@okta/okta-auth-js';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProfileComponent } from './profile/profile.component';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic'; 

const oktaAuth = new OktaAuth({
  issuer: 'https://dev-77390416.okta.com/oauth2/default',
  clientId: '0oa5aevt2ppy3b26c5d7',
  redirectUri: window.location.origin + '/login/callback'
});


@NgModule({
  declarations: [
    AppComponent,
    ProfileComponent, 
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    OktaAuthModule
  ],
  providers: [{ provide: OKTA_CONFIG, useValue: { oktaAuth } }],
  bootstrap: [AppComponent],
  
})
export class AppModule { }
