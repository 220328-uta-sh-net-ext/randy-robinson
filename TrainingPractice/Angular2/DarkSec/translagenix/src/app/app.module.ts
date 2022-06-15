import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { HomeComponent } from './home/home.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import { SpeechToTextComponent } from './speech-to-text/speech-to-text.component';
import { LoginComponent } from './login/login.component';
import { FileocrComponent } from './fileocr/fileocr.component';
import { OktaAuthModule, OKTA_CONFIG } from '@okta/okta-angular';
import { OktaAuth } from '@okta/okta-auth-js';
import { ProfileComponent } from './profile/profile.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { AuthInterceptor } from './auth.interceptor';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { LearningWordsComponent } from './learning-words/learning-words.component';
import { ThemeService } from './theme.service';
import { LeaderBoardComponent } from './leader-board/leader-board.component';

const oktaAuth = new OktaAuth({
  issuer: 'https://dev-32904001.okta.com/oauth2/default',
  clientId: '0oa5blk56g7GvMBNN5d7',
  // redirectUri: window.location.origin + '/login/callback'
  //create new app on octa side once we deployed(or in production)
  redirectUri: 'http://localhost:4200/login/callback',
  pkce:true,
});



@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    HomeComponent,
    SpeechToTextComponent,
    LoginComponent,
    FileocrComponent,
    ProfileComponent,
    LearningWordsComponent,
    LeaderBoardComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    OktaAuthModule,
    MatSlideToggleModule,
    MatToolbarModule,
  ],
  providers: [
    ThemeService,
    { provide: OKTA_CONFIG, useValue: { oktaAuth } },
    { provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }