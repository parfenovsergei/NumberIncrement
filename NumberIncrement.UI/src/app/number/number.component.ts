import { Component } from '@angular/core';

import { Numeral } from '../numeral';

@Component({
  selector: 'app-number',
  templateUrl: './number.component.html',
  styleUrls: ['./number.component.css']
})
export class NumberComponent {
  numbers: Numeral [] = [{id: 1, value: 2}, {id: 2, value: 3}];
}
