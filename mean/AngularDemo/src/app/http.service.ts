import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  comment: string = 'Message from the service';

  constructor() { }

  updateComment():string {
    console.log("in service method");
    return this.comment;
  }
}
