import { Component, OnInit } from '@angular/core';
import { CardsService } from '../cards.service';
import { Cards } from '../cards.model';

@Component({
  selector: 'app-cards',
  templateUrl: './cards.component.html',
  styleUrls: ['./cards.component.css']
})
export class CardsComponent implements OnInit {

  public key: string;
  result : any;
  constructor(private cardsService : CardsService) { }

  ngOnInit() {
    console.log("Get Cards :",this.cardsService.getCardList());
    this.result = this.cardsService.getCardList();
  }

  search(){
    console.log("searching........");
    this.result = this.cardsService.searchCardList(this.key);
  }

}
