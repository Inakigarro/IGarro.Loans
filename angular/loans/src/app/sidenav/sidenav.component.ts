import { CommonModule } from '@angular/common';
import { Component, NgModule, OnInit } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatListModule } from '@angular/material/list';
import { MatSidenavModule } from '@angular/material/sidenav';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { EffectsModule } from '@ngrx/effects';
import { StoreModule } from '@ngrx/store';
import { SidenavService } from './service/sidenav.service';
import { SidenavEffects } from './state/sidenav.effects';
import { sidenavReducer, SIDENAV_FEATURE_KEY } from './state/sidenav.reducer';

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.css']
})
export class SidenavComponent {
 
  public expanded$ =  this.service.getExpanded$;

  constructor(private readonly service: SidenavService) { }

}

@NgModule({
  declarations:[
    SidenavComponent
  ],
  imports:[
    CommonModule,
    MatListModule,
    MatButtonModule,
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
