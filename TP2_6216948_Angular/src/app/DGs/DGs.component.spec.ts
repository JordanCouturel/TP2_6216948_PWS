/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { DGsComponent } from './DGs.component';

describe('DGsComponent', () => {
  let component: DGsComponent;
  let fixture: ComponentFixture<DGsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DGsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DGsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
