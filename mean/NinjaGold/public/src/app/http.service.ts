import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) { }

  getGames(){
    return this._http.get('/ningaGold');
  }
  getGame(id: string){
    return this._http.get(`/ninjaGold/${id}`);
  }
  updateGame(game: any){
    return this._http.put(`/ninjaGold/${game._id}`, game);
  }
  createGame(name){
    return this._http.post('/ninjaGold',{name:name});
  }
}
