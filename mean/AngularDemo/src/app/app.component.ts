import { Component, OnInit } from '@angular/core';
import { HttpService } from './http.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Mean Project';
  commentFromService: string;

  constructor(private _service: HttpService) {}

  ngOnInit() {
    //make a call to the services
    this.commentFromService = this._service.updateComment();
  }
}
