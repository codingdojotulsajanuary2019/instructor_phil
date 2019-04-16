import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RecordShowComponent } from './record-show/record-show.component';
import { RecordAddComponent } from './record-add/record-add.component';
import { RecordEditComponent } from './record-show/record-edit/record-edit.component';

@NgModule({
  declarations: [
    AppComponent,
    RecordShowComponent,
    RecordAddComponent,
    RecordEditComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
