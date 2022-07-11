import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './header.component';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatToolbarModule } from '@angular/material/toolbar';
import { StoreModule } from '@ngrx/store';
import * as Header from './state/header.reducer';
import { EffectsModule } from '@ngrx/effects';
import { HeaderEffects } from './state/header.effects';
import { MenuModule } from '../menu/menu.component';



@NgModule({
  declarations: [
    HeaderComponent
  ],
  imports: [
    CommonModule,
    MatToolbarModule,
    MatButtonModule,
    MatIconModule,
    MenuModule,
    StoreModule.forFeature(Header.HEADER_FEATURE_KEY, Header.headerReducer),
    EffectsModule.forFeature([HeaderEffects])
  ],
  exports: [
    HeaderComponent
  ]
})
export class HeaderModule { }
