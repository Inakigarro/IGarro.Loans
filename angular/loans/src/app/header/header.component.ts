import { Component, OnInit } from '@angular/core';
import { HeaderService } from './service/header.service';
import * as HeaderActions from './state/header.actions';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private service: HeaderService) { }

  ngOnInit(): void {
    this.service.dispatch(HeaderActions.testAction());
  }

}
