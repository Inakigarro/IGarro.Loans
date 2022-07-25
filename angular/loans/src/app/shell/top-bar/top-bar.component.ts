import { Component } from '@angular/core';
import { ShellService } from '../service/shell.service';
import { menuButtonClicked } from '../state/shell.actions';

@Component({
  selector: 'app-top-bar',
  templateUrl: './top-bar.component.html',
  styleUrls: ['./top-bar.component.css']
})
export class TopBarComponent {

  constructor(private service: ShellService) { }

  public menuButtonClicked() {
    this.service.dispatch(menuButtonClicked());
  }
}
