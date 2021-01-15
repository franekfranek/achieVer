import { ComponentFixture, TestBed } from '@angular/core/testing';
import { NgForm }   from '@angular/forms';

import { NavComponent } from './nav.component';

describe('NavComponent', () => {
  let component: NavComponent;
  let fixture: ComponentFixture<NavComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NavComponent, NgForm ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NavComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

it('should show navbar', () => {
    expect(fixture.nativeElement.querySelector("[data-test='navbar']")).toBeTruthy();
  });
  it('should show login form', () => {
    expect(fixture.nativeElement.querySelector("[data-test='loginForm']")).toBeTruthy();
  });
});
