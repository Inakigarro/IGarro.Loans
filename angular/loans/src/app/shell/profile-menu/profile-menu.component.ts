import { Component } from '@angular/core';
import { ShellService } from '../service/shell.service';
import { profileButtonClicked } from '../state/shell.actions';

@Component({
  selector: 'app-profile-menu',
  templateUrl: './profile-menu.component.html',
  styleUrls: ['./profile-menu.component.css']
})
export class ProfileMenuComponent {

  public isExpanded$ = this.service.getProfileExpanded$;

  constructor(private readonly service: ShellService) { }

  public profileButtonClicked(){
    this.service.dispatch(profileButtonClicked())
  }
}
