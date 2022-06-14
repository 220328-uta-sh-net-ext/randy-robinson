import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { ThemeService } from './theme.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  isDarkTheme: Observable<boolean> | undefined;
  constructor(private themeService: ThemeService){}
  toggleDarkTheme(checked: boolean) {
    //this.themeService.setDarkTheme(checked);
    //Adding if statement to toggle dark theme.
    if(!this.isDarkTheme){
        this.themeService.setDarkTheme(checked)
    }
    else{
        this.themeService.setDarkTheme(!checked)
    }
  }
  ngOnInit(){
   // this.isDarkTheme!= this.themeService.isDarkTheme;
  }
  title = 'translagenix';
}
