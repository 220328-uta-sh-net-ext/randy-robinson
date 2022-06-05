import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { OktaAuthStateService, OKTA_AUTH } from '@okta/okta-angular';
import { AuthState, OktaAuth } from '@okta/okta-auth-js';
import { filter, map, Observable } from 'rxjs';

const config = {
  issuer: 'https:/dev-90042899.okta.com//oauth2/default',
  clientId: '0oa59stlzeFqd0vB25d7',
  redirectUri: window.location.origin + '/login/callback'
}
const oktaAuth = new OktaAuth(config);

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Angular-okta';
  public isAuthenticated$!: Observable<boolean>;

  constructor(private _router: Router, private _oktaStateService: OktaAuthStateService, @Inject(OKTA_AUTH) private _oktaAuth: OktaAuth) { }
      
  public ngOnInit(): void {
    this.isAuthenticated$ = this._oktaStateService.authState$.pipe(
      filter((s: AuthState) => !!s),
      map((s: AuthState) => s.isAuthenticated ?? false)
    );
  }
  public async signIn() : Promise<void> {
    await this._oktaAuth.signInWithRedirect().then(
      _ => this._router.navigate(['/profile'])
    );
  }

  public async signOut(): Promise<void> {
    await this._oktaAuth.signOut();
  }
}
