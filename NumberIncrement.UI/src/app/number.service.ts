import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Numeral } from './numeral';

@Injectable({
  providedIn: 'root'
})
export class NumberService {
  private readonly apiUrl = "https://localhost:7149/api/Increment";

  constructor(private http: HttpClient) { }

  getNumbers() : Observable<Numeral[]> {
    return this.http.get<Numeral[]>(`${this.apiUrl}/Numbers`);
  }
}