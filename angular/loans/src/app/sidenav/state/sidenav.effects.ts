import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { map, withLatestFrom } from "rxjs/operators";
import { initHeader } from "../../header/state/header.actions";
import {menuButtonClicked} from '../../shell/state/shell.actions'
import { profileButtonClicked } from '../../menu/state/menu.actions';
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
            withLatestFrom(this.service.getSidenavExpanded$),
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
        ));

    public profileButtonclicked$ = createEffect(() =>
        this.actions$.pipe(
            ofType(profileButtonClicked),
            withLatestFrom(this.service.getProfileExpanded$),
            map(([_, expanded]) => {
                if(expanded){
                    console.log(expanded);
                    return SidenavActions.hideProfile({
                        expanded: false
                    });
                }
                console.log(expanded);
                return SidenavActions.expandProfile({
                    expanded: true
                })
            })
        ))
    constructor(
        private readonly actions$: Actions,
        private readonly service: SidenavService){}
}