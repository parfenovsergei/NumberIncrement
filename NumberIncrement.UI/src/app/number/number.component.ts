import { Component, OnInit, ViewChild } from '@angular/core';
import { Form, FormControl, FormGroup } from '@angular/forms';
import { ThemePalette } from '@angular/material/core';

import { Numeral } from '../numeral';
import { NumberService } from '../number.service';


@Component({
  selector: 'app-number',
  templateUrl: './number.component.html',
  styleUrls: ['./number.component.css']
})
export class NumberComponent implements OnInit {
  numbers: Numeral [] = [];
  @ViewChild('picker') picker: any;
  public minDate: Date = new Date(1990, 1, 1, 0, 0, 0);
  public maxDate: Date = new Date(2500, 1, 1, 0, 0, 0);
  dateControl: FormControl = new FormControl(null);

  constructor(private numberService: NumberService){}

  ngOnInit(): void {
    this.getNumbers();
  }

  getNumbers() : void {
    this.numberService
      .getNumbers()
      .subscribe((result: Numeral[]) => (this.numbers = result));
  }

  incrementNumber(number: Numeral, increment: number) : void {
    this.numberService
      .incrementNumber(number, increment)
      .subscribe(() => this.getNumbers());
  }

  updateDate(id: number, datetime: Date){
    this.numberService
      .updateDate(id, datetime)
      .subscribe(() => this.getNumbers()); 
    this.dateControl = new FormControl(null);
  }
}
