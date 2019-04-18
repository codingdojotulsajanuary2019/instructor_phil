import { Component, OnInit, Input } from '@angular/core';
import { Record } from '../record';
import { HttpService } from '../http.service';

@Component({
  selector: 'app-record-add',
  templateUrl: './record-add.component.html',
  styleUrls: ['./record-add.component.css']
})
export class RecordAddComponent implements OnInit {
  @Input() variableInAddComponent:Array<Record>;
  NewRecord: Record = new Record();

  constructor(private _service: HttpService) { }

  ngOnInit() {
  }

  addRecord(){
    console.log(this.NewRecord);
    // with a db, send record to server side, and on success add to record array
    this._service.addRecord(this.NewRecord).subscribe(response=>{
      if(response['status']){
        this.variableInAddComponent.push(response['record']);
      } else {
        console.log(response['err'])
      }
    })
    this.NewRecord = new Record();
  }

}
