import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './header.component';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { StoreModule } from '@ngrx/store';
import * as Header from './state/header.reducer';



@NgModule({
  declarations: [
    HeaderComponent
  ],
  imports: [
    CommonModule,
    MatButtonModule,
    MatIconModule,
    StoreModule.forFeature(Header.HEADER_FEATURE_KEY, Header.headerReducer)
  ],
  exports: [
    HeaderComponent
  ]
})
export class HeaderModule { }
