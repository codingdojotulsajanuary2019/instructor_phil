import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { HttpService } from '../http.service';

@Component({
  selector: 'app-show-all-cake',
  templateUrl: './show-all-cake.component.html',
  styleUrls: ['./show-all-cake.component.css']
})
export class ShowAllCakeComponent implements OnInit {
  @Input() allCakes:any;
  @Output() parentMethod = new EventEmitter();
  cakeComment : Object = {comment: "", rating: 0};
  cakeCommentArray: any = [];
  commentStatus : String[] = [];
  color : String;
  cakeClicked : any;

  constructor(private _httpService: HttpService) { }

  ngOnInit() {
    this.cakeComment = {comment: "", rating: 0};
    for(let i = 0; i < this.allCakes.length; i++){
      this.cakeCommentArray[i] = {comment: "", rating: 0};
    }
  }


  trackCake(index, cake){
    console.log('index is, ', index);
    console.log('cake is, ', cake);
    return index;
  }

  addCommentToCake(cake, i){
    let cakeId = cake._id
    console.log(cake);
    console.log(this.allCakes[i]);
    let cakeCommentToChange = this.cakeCommentArray[i];
    let tempObservable = this._httpService.updateComment(cakeId, cakeCommentToChange );
    tempObservable.subscribe(data => {
      if(data["status"] == true){
        this.cakeCommentArray[i] = {comment: "", rating: 0};
        this.commentStatus[i] = "Succesful";
        this.color = "success";
        this.parentMethod.emit('test');
      }
      else{
        console.log(data);
        if(data["status"] == false){
          for(let x in data["error"].errors){
            this.commentStatus[i] = data["error"].errors[x].message;
            this.color = "danger";
          }
        }
      }
    })
  }

  // trackByFn(index, cake) {
  //   return index;
  // }

  showThisCake(cake){
    this.cakeClicked = cake;
    console.log(cake);
  }

  // populate(){
  //   this.cakeComment = {comment: "abc", rating: Number}
  // }

}
