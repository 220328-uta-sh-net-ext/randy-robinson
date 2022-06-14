import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { HomeComponent } from './home/home.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule} from '@angular/common/http';
import { SpeechToTextComponent } from './speech-to-text/speech-to-text.component';
import { LoginComponent } from './login/login.component';
import { FileocrComponent } from './fileocr/fileocr.component';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { LearningWordsComponent } from './learning-words/learning-words.component';

import { LeaderBoardComponent } from './leader-board/leader-board.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ThemeService } from './theme.service';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    HomeComponent,
    SpeechToTextComponent,
    LoginComponent,
    FileocrComponent,
    LearningWordsComponent,
    LeaderBoardComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatSlideToggleModule,
    
  ],
  providers: [ThemeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
