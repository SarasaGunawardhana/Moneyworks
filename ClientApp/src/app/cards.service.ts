import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions, RequestMethod } from '@angular/http';
// import { Observable } from 'rxjs/Observable';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';
import { Cards } from'./Cards.model'

@Injectable({
  providedIn: 'root'
})
export class CardsService {
  cardList : Cards[];
  constructor(private http : Http) { }

  getCardList(){
    this.http.get('http://localhost:52159/api/GetCards_Result/')
    .map((data : Response) =>{
      return data.json() as Cards[];
    }).toPromise().then(x => {
      this.cardList = x;
    })
  }

  searchCardList(value){
    this.http.get('http://localhost:52159/api/searchCards_Result/' + value)
    .map((data : Response) =>{
      return data.json() as Cards[];
    }).toPromise().then(x => {
      this.cardList = x;
    })
  }
}
