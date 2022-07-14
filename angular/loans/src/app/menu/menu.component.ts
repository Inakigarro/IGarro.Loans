import { CommonModule } from '@angular/common';
import { Component, NgModule, OnInit } from '@angular/core';
import { MatMenuModule } from '@angular/material/menu'
import { MatIconModule } from '@angular/material/icon';
import { StoreModule } from '@ngrx/store';
import { MenuService } from './service/menu.service';
import * as MenuActions from './state/menu.actions';
import { MENU_FEATURE_KEY, menuReducer } from './state/menu.reducer';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  public isExpanded$ = this.service.getExpanded$;

  constructor(private readonly service: MenuService) { }

  ngOnInit(): void {
  }

  public profileButtonClicked(){
    console.log('profile button clicked');
    this.service.dispatch(MenuActions.profileButtonClicked())
  }
}

@NgModule({
  declarations:[MenuComponent],
  imports:[
    CommonModule,
    MatMenuModule,
    MatIconModule,
    StoreModule.forFeature(MENU_FEATURE_KEY, menuReducer)
  ],
  exports:[MenuComponent]
})
export class MenuModule{}
