import { CommonModule } from '@angular/common';
import { Component, NgModule, OnInit } from '@angular/core';
import { StoreModule } from '@ngrx/store';
import { shellReducer, SHELL_FEATURE_KEY } from './state/shell.reducer';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { ShellService } from './service/shell.service';
import { SidenavModule } from '../sidenav/sidenav.component';
import { HeaderModule } from '../header/header.module';
import { EffectsModule } from '@ngrx/effects';
import { ShellEffects } from './state/shell.effects';
import { FooterModule } from '../footer/footer.component';

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

@NgModule({
  declarations:[
    ShellComponent
  ],
  imports: [
    CommonModule,
    HeaderModule,
    SidenavModule,
    FooterModule,
    MatButtonModule,
    MatIconModule,
    StoreModule.forFeature(SHELL_FEATURE_KEY, shellReducer),
    EffectsModule.forFeature([ShellEffects])
  ],
  exports:[
    ShellComponent
  ]
})
export class ShellModule{}
