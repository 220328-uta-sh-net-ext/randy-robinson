import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ThisWebPageComponent } from './this-web-page.component';

describe('ThisWebPageComponent', () => {
  let component: ThisWebPageComponent;
  let fixture: ComponentFixture<ThisWebPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ThisWebPageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ThisWebPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
