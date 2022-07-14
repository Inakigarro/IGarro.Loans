import { Injectable } from "@angular/core";
import { Action, Store } from "@ngrx/store";
import * as SidenavSelectors from '../state/sidenav.selectors';

@Injectable({
    providedIn: 'root'
})
export class SidenavService {
    constructor(private readonly store: Store){}

    public getLoaded$ = this.store.select(
        SidenavSelectors.selectLoaded
    );

    public getSidenavExpanded$ = this.store.select(
        SidenavSelectors.selectExpanded
    );

    public getProfileExpanded$ = this.store.select(
        SidenavSelectors.selectProfileExpanded
    )
    
    public dispatch(action: Action){
        this.store.dispatch(action);
    }
}