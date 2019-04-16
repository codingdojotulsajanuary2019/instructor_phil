import { Component, OnInit, Input } from '@angular/core';
import { Record } from 'src/app/record';

@Component({
  selector: 'app-record-edit',
  templateUrl: './record-edit.component.html',
  styleUrls: ['./record-edit.component.css']
})
export class RecordEditComponent implements OnInit {
  @Input() recordToUpdate: Record;
  @Input() showRecord: Record;

  constructor() { }

  ngOnInit() {
  }

  updateRecord(){;
    this.recordToUpdate.Title = this.showRecord.Title;
    this.recordToUpdate.Artist = this.showRecord.Artist;
    this.recordToUpdate.Date = this.showRecord.Date;
    this.showRecord = undefined;
  }

}
