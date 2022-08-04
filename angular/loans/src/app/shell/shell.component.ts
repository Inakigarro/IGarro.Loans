import { CommonModule } from '@angular/common';
import { Component, NgModule, OnInit } from '@angular/core';
import { StoreModule } from '@ngrx/store';
import { shellReducer, SHELL_FEATURE_KEY } from './state/shell.reducer';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatToolbarModule } from '@angular/material/toolbar';
import { ShellService } from './service/shell.service';
import { EffectsModule } from '@ngrx/effects';
import { ShellEffects } from './state/shell.effects';
import { FooterModule } from '../footer/footer.component';
import { TopBarComponent } from './top-bar/top-bar.component';
import { ProfileMenuComponent } from './profile-menu/profile-menu.component';
import { MatMenuModule } from '@angular/material/menu';
import { SidenavComponent } from '../sidenav/sidenav.component';
import { MatCardModule } from '@angular/material/card';
import { MatListModule } from '@angular/material/list';
import { MatSidenavModule } from '@angular/material/sidenav';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-shell',
  templateUrl: './shell.component.html',
  styleUrls: ['./shell.component.css']
})
export class ShellComponent implements OnInit {

  constructor(private readonly service: ShellService) { }

  ngOnInit(): void {
  }

}

const MaterialModules = [
  
]

@NgModule({
  declarations:[
    ShellComponent,
    TopBarComponent,
    ProfileMenuComponent,
    SidenavComponent
  ],
  imports: [
    CommonModule,
    FooterModule,
    MatButtonModule,
    MatIconModule,
    MatToolbarModule,
    MatMenuModule,
    MatCardModule,
    MatListModule,
    MatSidenavModule,
    FormsModule,
    BrowserAnimationsModule,
    BrowserModule,
    StoreModule.forFeature(SHELL_FEATURE_KEY, shellReducer),
    EffectsModule.forFeature([ShellEffects])
  ],
  exports:[
    ShellComponent
  ]
})
export class ShellModule{}
