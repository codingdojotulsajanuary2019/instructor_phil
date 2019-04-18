import { Component, OnInit } from '@angular/core';
import { HttpService } from './http.service';
import { analyzeAndValidateNgModules } from '@angular/compiler';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'public';
  newCake: any;
  allCakesFromApp: any;

  constructor(private _httpService: HttpService){}
  ngOnInit(){
    this.getAll('hello');
  }
  getAll(str){
    console.log('in get all', str);
    let tempObservable = this._httpService.getAllCakes();
    tempObservable.subscribe(data => {
      this.allCakesFromApp = data["cakes"]
    })
  }
}
