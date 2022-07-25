import { Component } from '@angular/core';
import { HeaderService } from './service/header.service';
import { menuButtonClicked } from './state/header.actions';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {

  constructor(private service: HeaderService) { }

  public menuButtonClicked(){
    console.log('menu button clicked');
    this.service.dispatch(menuButtonClicked())
  }
}
