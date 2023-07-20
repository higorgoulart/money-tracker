import { Component } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public transaction : Transaction = new Transaction();

  public currentCount = 0;

  public onSubmit() {
    
  }

  public incrementCounter() {
    this.currentCount++;
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
