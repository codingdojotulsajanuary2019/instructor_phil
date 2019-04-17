import { Component, OnInit, Input } from '@angular/core';
import { Record } from 'src/app/record';

@Component({
  selector: 'app-record-edit',
  templateUrl: './record-edit.component.html',
  styleUrls: ['./record-edit.component.css']
})
export class RecordEditComponent implements OnInit {
  @Input() recordToUpdate: Record;
  @Input() showRecord={status: false, record:{}};

  constructor() { }

  ngOnInit() {
  }

  updateRecord(){;
    this.recordToUpdate.Title = this.showRecord.record['Title'];
    this.recordToUpdate.Artist = this.showRecord.record['Artist'];
    this.recordToUpdate.Date = this.showRecord.record['Date'];
    this.showRecord.status = false;
    // this.recordToUpdate = this.showRecord;
  }

}
