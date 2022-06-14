import { TestBed } from '@angular/core/testing';

import { NewSageService } from './new-sage.service';

describe('NewSageService', () => {
  let service: NewSageService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(NewSageService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
