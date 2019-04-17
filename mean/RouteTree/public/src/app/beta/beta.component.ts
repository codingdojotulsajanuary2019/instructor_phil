import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-beta',
  templateUrl: './beta.component.html',
  styleUrls: ['./beta.component.css']
})
export class BetaComponent implements OnInit {

  constructor(private _router: Router) { }

  ngOnInit() {
  }

  goHome(){
    console.log('another action');
    this._router.navigate(['/']);
  }

}
