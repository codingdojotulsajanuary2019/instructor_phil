import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Record } from './record';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) { }

  getAllRecords(){
    return this._http.get('/api/records');
  }
  getOneRecords(record_id: number){
    return this._http.get(`/api/records/${record_id}`);
  }
  addRecord(record: Record){
    return this._http.post('/api/records', record);
  }
  updateRecord(record_id: number, record: Record){
    return this._http.put(`/api/records/${record_id}`, record);
  }
  deleteRecord(record_id: number){
    return this._http.delete(`/api/records/${record_id}`);
  }
}
