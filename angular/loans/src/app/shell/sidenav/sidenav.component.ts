import { Component } from "@angular/core";
import { ShellService } from "../service/shell.service";
import { backdropClicked } from "../state/shell.actions";

@Component({
    selector: 'app-sidenav',
    templateUrl: './sidenav.component.html'
})
export class SidenavComponent{
    public sidenavExpanded$ = this.service.getSidenavExpanded$;
    public profileDrawerExpanded$ = this.service.getProfileExpanded$

    constructor(private readonly service: ShellService){}

    backdropClicked(){
        this.service.dispatch(
            backdropClicked()
        );
    }
}