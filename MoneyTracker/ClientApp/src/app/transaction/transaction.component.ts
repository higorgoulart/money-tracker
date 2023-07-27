import {Attribute, Component, Inject} from '@angular/core';
import {HttpClient, HttpHeaders} from "@angular/common/http";

@Component({
  selector: 'app-transaction-component',
  templateUrl: './transaction.component.html'
})
export class TransactionComponent {
  public transaction: Transaction = new Transaction();
  public categories: ICategory[] = [];

  private readonly http: HttpClient;
  private readonly baseUrl: string;

  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    @Attribute('title') public title: string,
    @Attribute('subTitle') public subTitle: string,
    @Attribute('type') public type: string) {
    this.http = http;
    this.baseUrl = baseUrl;

    this.http
      .get<ICategory[]>(this.baseUrl + `category?type=${this.type}`)
      .subscribe(result => this.categories = result);
  }

  public onSubmit() {
    this.transaction.type = Number(this.type);

    const httpOptions = {
      headers: new HttpHeaders({'Content-Type': 'application/json'})
    };

    this.http
      .post<any>(this.baseUrl + 'transaction', JSON.stringify(this.transaction), httpOptions)
      .subscribe(() => this.transaction = new Transaction());
  }
}

class Transaction {
  value: number;
  date: Date;
  type: number;
  category: number;
  description: string;

  constructor() {
    this.value = 0;
    this.date = new Date();
    this.type = 0;
    this.category = 0;
    this.description = '';
  }
}

interface ICategory {
  id: number;
  name: string;
}
