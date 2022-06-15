import { NgModule } from '@angular/core';
import { CommonModule } from "@angular/common";
import { RouterModule, Routes } from '@angular/router';
import { FileocrComponent } from './fileocr/fileocr.component';
import { HomeComponent } from './home/home.component';
import { LeaderBoardComponent } from './leader-board/leader-board.component';
//import { SpeechToTextComponent } from './speech-to-text/speech-to-text.component';

import { OktaAuthGuard,  OktaCallbackComponent } from '@okta/okta-angular';
import { ProfileComponent } from './profile/profile.component';
import { LoginComponent } from './login/login.component';
//import { LearningWordsComponent } from './learning-words/learning-words.component';

const routes:Routes = [
  
  {path: 'home', component: HomeComponent, canActivate: [OktaAuthGuard]},
  {path: 'login', component: LoginComponent},
  {path: 'FileOCR', component: FileocrComponent},
  {path: 'LeaderBoard', component: LeaderBoardComponent},
 // commenting out to remove errors for dark mode test.
  //{path: 'SpeechToText', component: SpeechToTextComponent}, 
  //{path: 'LearningWords', component: LearningWordsComponent}, 
  {path: 'protected',
    loadChildren: () => import('./protected.module').then(m => m.ProtectedModule),
    canActivate: [OktaAuthGuard]},
  {path: 'profile', component: ProfileComponent, canActivate: [OktaAuthGuard] },
  {path: 'login/callback', component: OktaCallbackComponent }

]


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }