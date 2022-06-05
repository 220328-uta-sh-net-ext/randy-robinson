import { OktaAuthModule, OKTA_CONFIG } from '@okta/okta-angular';
import { OktaAuth } from '@okta/okta-auth-js';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

const config = {
  issuer: 'https:/dev-90042899.okta.com//oauth2/default',
  clientId: '0oa59stlzeFqd0vB25d7',
  redirectUri: window.location.origin + '/login/callback'
}
const oktaAuth = new OktaAuth(config);

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
  ],
  providers: [{provide: OKTA_CONFIG, useValue:{oktaAuth}}],
  bootstrap: [AppComponent]
})
export class AppModule { }
