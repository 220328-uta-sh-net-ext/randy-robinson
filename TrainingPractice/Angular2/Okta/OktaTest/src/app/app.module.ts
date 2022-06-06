import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { OktaAuthModule, OKTA_CONFIG } from '@okta/okta-angular';
import { OktaAuth } from '@okta/okta-auth-js';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProfileComponent } from './profile/profile.component';
import { AuthInterceptor } from './auth.interceptor';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
//---- import { SecureComponent } from './secure/secure.component';

const oktaAuth = new OktaAuth({
  issuer: 'https://dev-77390416.okta.com/oauth2/default',
  clientId: '0oa5afwmcm1PkMWX75d7',
  redirectUri: window.location.origin + '/login/callback'
});


@NgModule({
  declarations: [
    AppComponent,
    ProfileComponent,
//---- When I was Debugging the OktaTest App noticed that secure module was added twice. 
//---- Commenting out referance to SecureComponent in delaration field and imports.    
//---- SecureComponent, 
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    OktaAuthModule,
    HttpClientModule
  ],
  providers: [
    { provide: OKTA_CONFIG, useValue: { oktaAuth } },
    { provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true }
  ],
  bootstrap: [AppComponent],
  
})
export class AppModule { }
