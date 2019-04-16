import { Component, OnInit, Input } from '@angular/core';
import { Record } from '../record';

@Component({
  selector: 'app-record-add',
  templateUrl: './record-add.component.html',
  styleUrls: ['./record-add.component.css']
})
export class RecordAddComponent implements OnInit {
  @Input() variableInAddComponent:Array<Record>;
  NewRecord: Record = new Record();

  constructor() { }

  ngOnInit() {
  }

  addRecord(){
    console.log(this.NewRecord);
    this.variableInAddComponent.push(this.NewRecord);
    this.NewRecord = new Record();
  }

}
