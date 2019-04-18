import { Component, OnInit, Input } from '@angular/core';
import { Record } from '../record';

@Component({
  selector: 'app-record-show',
  templateUrl: './record-show.component.html',
  styleUrls: ['./record-show.component.css']
})
export class RecordShowComponent implements OnInit {
  @Input() variableInShowComponent:Array<Record>;
  EditRecord: Record;
  ShowRecord = {status: false, record:{}};

  constructor() { }

  ngOnInit() {
  }

  sendRecordToEdit(record: Record){
    // create a copy of the record to change
    this.EditRecord = record;
    this.ShowRecord.status = true;
    this.ShowRecord.record = new Record(record.title, record.artist, record.date);
  }

}
