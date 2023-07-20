import { Component, Inject } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public transactions: Transaction[] = [];
  private readonly http: HttpClient;
  private readonly baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;

    this.http
      .get<Transaction[]>(this.baseUrl + 'transaction')
      .subscribe(result => this.transactions = result);
  }

  public insert = () => {
    const httpOptions = {
      headers: new HttpHeaders({'Content-Type': 'application/json'})
    }
    const a: Transaction = {
      value: 15.7,
      date: new Date(),
      type: 1,
      category: 0,
      description: 'testeeeaaa',
    };
    this.http
      .post<any>(this.baseUrl + 'transaction', JSON.stringify(a), httpOptions)
      .subscribe(result => this.transactions.push(result));
  }
}

interface Transaction {
  value: number;
  date: Date;
  type: number;
  category: number;
  description: string;
}
