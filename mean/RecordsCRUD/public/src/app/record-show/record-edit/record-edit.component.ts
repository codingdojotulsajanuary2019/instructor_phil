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
    this.recordToUpdate.title = this.showRecord.record['title'];
    this.recordToUpdate.artist = this.showRecord.record['artist'];
    this.recordToUpdate.date = this.showRecord.record['date'];
    this.showRecord.status = false;
    // this.recordToUpdate = this.showRecord;
  }

}
