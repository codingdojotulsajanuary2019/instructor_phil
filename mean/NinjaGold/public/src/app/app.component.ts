import { Component, OnInit } from '@angular/core';
import { HttpService } from './http.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Ninja Gold';
  game:any;
  name:string;

  constructor(private _gameService: HttpService){}

  ngOnInit(){
  }
  
  createGame(event){
    console.log(event.target.value);
    let name = event.target.value;
    this.name = name;
    this._gameService.createGame(name).subscribe(game=>{
      this.game = game['game'];
      console.log(game);
    })
  }

  findGold(building:string){
    let buildings={
      farm: Math.floor((Math.random() * 11) + 10),
      cave: Math.floor((Math.random() * 6) + 5),
      house: Math.floor((Math.random() * 4) + 2),
      casino: Math.floor((Math.random() * 101) + -50),
    }
    this.game['score'] += buildings[building];
    this.game['log'].push(`You entered a ${building}, and earned/lost ${buildings[building]}`);
    console.log(buildings[building]);
    this._gameService.updateGame(this.game).subscribe(game => {
      console.log('game from the server', game)
      this.game = game['game'];
    })
  }
}
