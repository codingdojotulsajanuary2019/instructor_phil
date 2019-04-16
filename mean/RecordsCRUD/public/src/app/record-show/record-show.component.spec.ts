import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RecordShowComponent } from './record-show.component';

describe('RecordShowComponent', () => {
  let component: RecordShowComponent;
  let fixture: ComponentFixture<RecordShowComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RecordShowComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RecordShowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
