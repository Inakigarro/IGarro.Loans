import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { map, withLatestFrom } from "rxjs/operators";
import { initHeader, menuButtonClicked } from "../../header/state/header.actions";
import { SidenavService } from "../service/sidenav.service";
import { initSidenav } from "./sidenav.actions";
import * as SidenavActions from './sidenav.actions';

@Injectable()
export class SidenavEffects {
    public initSidenav$ = createEffect(() =>
        this.actions$.pipe(
            ofType(initHeader),
            map(() => initSidenav())
        ));
    
    public menuButtonClicked$ = createEffect(() =>
        this.actions$.pipe(
            ofType(menuButtonClicked),
            withLatestFrom(this.service.getExpanded$),
            map(([_, expanded]) => {
                if(expanded){
                    console.log(expanded);
                    return SidenavActions.hideSidenav({
                        expanded: false
                    });
                }
                console.log(expanded);
                return SidenavActions.expandSidenav({
                    expanded: true
                });
            })
        ))
    constructor(
        private readonly actions$: Actions,
        private readonly service: SidenavService){}
}