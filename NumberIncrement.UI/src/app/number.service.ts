import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Numeral } from './numeral';

@Injectable({
  providedIn: 'root'
})
export class NumberService {
  private readonly apiUrl = "https://localhost:7149/api/Increment";

  private httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(private http: HttpClient) { }

  getNumbers() : Observable<Numeral[]> {
    return this.http.get<Numeral[]>(`${this.apiUrl}/Numbers`);
  }

  incrementNumber(number: Numeral, increment: number) : Observable<any> {
    return this.http.put(
      (`${this.apiUrl}/IncrementationAsync/${number.id}`),
      increment,
      this.httpOptions
    );
  }

  updateDate(id: number, datetime: Date){
    return this.http.put(
      (`${this.apiUrl}/ÜpdateDateAsync/${id}`),
      datetime,
      this.httpOptions
    );
  }
}