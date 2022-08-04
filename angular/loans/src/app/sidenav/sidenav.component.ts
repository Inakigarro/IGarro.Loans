import { CommonModule } from '@angular/common';
import { Component, NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatListModule } from '@angular/material/list';
import { MatSidenavModule } from '@angular/material/sidenav';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { StoreModule } from '@ngrx/store';
import { SidenavService } from './service/sidenav.service';
import { sidenavReducer, SIDENAV_FEATURE_KEY } from './state/sidenav.reducer';
import { MatCardModule } from '@angular/material/card';
import * as SidenavActions from './state/sidenav.actions'
import { FormsModule } from '@angular/forms';
import { FooterModule } from '../footer/footer.component';

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.css']
})
export class SidenavComponent { 
  public sidenaveExpanded$ =  this.service.getSidenavExpanded$;
  public profileDrawerExpanded$ = this.service.getProfileExpanded$

  constructor(private readonly service: SidenavService) { }

  backdropClicked(){
    console.log('sarasa');
    this.service.dispatch(
      SidenavActions.backdropClicked()
    );
  }
}

@NgModule({
  imports:[
    CommonModule,
    FooterModule,
    MatListModule,
    MatButtonModule,
    MatCardModule,
    FormsModule,
    BrowserModule,
    BrowserAnimationsModule,
    MatSidenavModule,
    StoreModule.forFeature(SIDENAV_FEATURE_KEY, sidenavReducer),
  ],
})
export class SidenavModule{}
