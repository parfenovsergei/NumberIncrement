import { Component, OnInit } from '@angular/core';

import { Numeral } from '../numeral';
import { NumberService } from '../number.service';

@Component({
  selector: 'app-number',
  templateUrl: './number.component.html',
  styleUrls: ['./number.component.css']
})
export class NumberComponent implements OnInit {
  numbers: Numeral [] = [];

  constructor(private numberService: NumberService){}

  ngOnInit(): void {
    this.getNumbers();
  }

  getNumbers() : void {
    this.numberService
      .getNumbers()
      .subscribe((result: Numeral[]) => (this.numbers = result));
  } 
 
}
