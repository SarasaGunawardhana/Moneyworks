import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { CardsService } from './cards.service'
import { AppComponent } from './app.component';
import { CardsComponent } from './cards/cards.component';

@NgModule({
  declarations: [
    AppComponent,
    CardsComponent
  ],
  imports: [
    FormsModule,
    HttpModule,
    BrowserModule
  ],
  providers: [CardsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
