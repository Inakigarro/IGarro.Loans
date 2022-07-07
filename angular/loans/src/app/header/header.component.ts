import { Component, OnInit } from '@angular/core';
import { Store } from '@ngrx/store';
import * as HeaderActions from './state/header.actions';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private store: Store) { }

  ngOnInit(): void {
    this.store.dispatch(HeaderActions.testAction());
  }

}
