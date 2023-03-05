import { Injectable, ViewChild } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

import { environment } from 'src/environments/environment';
import { Numeral } from './numeral';

@Injectable({
  providedIn: 'root'
})
export class NumberService {
  @ViewChild('picker') picker: any;
  private httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(private http: HttpClient) { }

  getNumbers() : Observable<Numeral[]> {
    return this.http.get<Numeral[]>(`${environment.apiUrl}/numbers`);
  }

  incrementNumber(number: Numeral, increment: number) : Observable<any> {
    return this.http.put(
      (`${environment.apiUrl}/numbers/${number.id}`),
      increment,
      this.httpOptions
    );
  }

  updateDate(id: number, datetime: Date){
    return this.http.put(
      (`${environment.apiUrl}/dates/${id}`),
      datetime,
      this.httpOptions
    );
  }
}