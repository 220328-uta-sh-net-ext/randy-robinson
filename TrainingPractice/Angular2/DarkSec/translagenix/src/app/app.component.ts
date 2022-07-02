import { Component, Inject, OnInit } from '@angular/core';
import { ThemeService } from './theme.service';
import { Router } from '@angular/router';
import { OktaAuthStateService, OKTA_AUTH } from '@okta/okta-angular';
import { AuthState, OktaAuth } from '@okta/okta-auth-js';
import { filter, map, Observable } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css', '../custom-theme.scss']
})
export class AppComponent implements OnInit {
  title = 'website';
  isDarkTheme: Observable<boolean> | undefined;
  public isAuthenticated$!: Observable<boolean>;

  constructor(private _router: Router,
    private _oktaStateService: OktaAuthStateService,
    @Inject(OKTA_AUTH) private _oktaAuth: OktaAuth,
    private themeService: ThemeService) { }
  toggleDarkTheme(checked: boolean) {
    this.themeService.setDarkTheme(checked);
    /**if (!this.isDarkTheme) {
      this.themeService.setDarkTheme(checked)
    }
    else {
      this.themeService.setDarkTheme(!checked)
    }
  **/
   }
  public ngOnInit(): void {
    this.isDarkTheme = this.themeService.isDarkTheme;
    this.isAuthenticated$ = this._oktaStateService.authState$.pipe(
      filter((s: AuthState) => !!s),
      map((s: AuthState) => s.isAuthenticated ?? false)
    );
  }

  public async signIn(): Promise<void> {
    await this._oktaAuth.signInWithRedirect().then(
      _ => this._router.navigate(['/home'])
    );

  }

  public async signOut(): Promise<void> {
    await this._oktaAuth.signOut();
  }
}

