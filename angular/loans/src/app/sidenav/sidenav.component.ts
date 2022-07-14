import { CommonModule } from '@angular/common';
import { Component, NgModule, OnInit, ViewChild } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatListModule } from '@angular/material/list';
import { MatDrawer, MatSidenav, MatSidenavModule } from '@angular/material/sidenav';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { EffectsModule } from '@ngrx/effects';
import { StoreModule } from '@ngrx/store';
import { SidenavService } from './service/sidenav.service';
import { SidenavEffects } from './state/sidenav.effects';
import { sidenavReducer, SIDENAV_FEATURE_KEY } from './state/sidenav.reducer';
import { MatCardModule } from '@angular/material/card';
import * as SidenavActions from './state/sidenav.actions'
import { FormsModule } from '@angular/forms';
import { ThisReceiver } from '@angular/compiler';
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
  declarations:[
    SidenavComponent
  ],
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
    EffectsModule.forFeature([SidenavEffects])
  ],
  exports:[
    SidenavComponent
  ]
})
export class SidenavModule{}
