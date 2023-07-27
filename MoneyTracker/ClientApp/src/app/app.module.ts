import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { NavLinkComponent } from './nav-menu/nav-link.component';
import { HomeComponent } from './home/home.component';
import { TransactionComponent } from './transaction/transaction.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import {ExpenseComponent} from "./expense/expense.component";
import {RevenueComponent} from "./revenue/revenue.component";

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    NavLinkComponent,
    HomeComponent,
    TransactionComponent,
    ExpenseComponent,
    RevenueComponent,
    FetchDataComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'expense', component: ExpenseComponent },
      { path: 'revenue', component: RevenueComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
