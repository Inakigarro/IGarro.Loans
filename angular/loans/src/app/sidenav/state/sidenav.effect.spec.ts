import { TestBed } from "@angular/core/testing";
import { provideMockActions } from "@ngrx/effects/testing";
import { Action } from "@ngrx/store";
import { provideMockStore } from "@ngrx/store/testing";
import { Observable } from "rxjs";
import { SidenavService } from "../service/sidenav.service";
import { SidenavEffects } from "./sidenav.effects";

function configureTestingModule(
    actions: Observable<Action>
){
    TestBed.configureTestingModule({
        providers: [
            SidenavService,
            SidenavEffects,
            provideMockActions(() => actions),
            provideMockStore(),
        ]
    })
}