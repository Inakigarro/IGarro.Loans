import { Component, OnInit } from '@angular/core';
import { AppService } from './service/app.service';
import { initApp } from './state/app.actions';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  constructor(private readonly service: AppService){}

  ngOnInit(): void {
    this.service.dispatch(initApp())
  }
  
  title = 'loans';
}
