import { Component, OnInit } from '@angular/core';
import { Record } from './record';
import { HttpService } from './http.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Records';
  AllRecords: Array<Record>;

  constructor(private _service: HttpService) {}
  // get all records from the DB
  ngOnInit(){
    // dummy data for now
    // this.AllRecords = [
    //   new Record("The Wall", "Pink Flyod", 1979),
    //   new Record("Nevermind", "Nirvana", 1991),
    //   new Record("Blueprint", "Jz", 2003),
    //   new Record("The White Album", "Beattles", 1967)
    // ]
    this.getAllRecords();
  }
  getAllRecords(){
      this._service.getAllRecords().subscribe(response=>{
        if(response['status']){
          this.AllRecords = response['records'];
        } else {
          console.log(response['err'])
        }
      })
  }
}
