import { Component, OnInit } from '@angular/core';
import { Record } from './record';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Records';
  AllRecords: Array<Record>;

  // get all records from the DB
  ngOnInit(){
    // dummy data for now
    this.AllRecords = [
      new Record("The Wall", "Pink Flyod", 1979),
      new Record("Nevermind", "Nirvana", 1991),
      new Record("Blueprint", "Jz", 2003),
      new Record("The White Album", "Beattles", 1967)
    ]
  }
}
