import { Injectable } from "@angular/core";
import { Action, Store } from "@ngrx/store";
import * as ShellSelectors from '../state/shell.selectors'

@Injectable({
    providedIn: 'root'
})
export class ShellService {
    constructor(private readonly store: Store){}

    public getSidenavExpanded$ = this.store.select(
        ShellSelectors.selectExpanded
    );

    public getProfileExpanded$ = this.store.select(
        ShellSelectors.selectProfileExpanded
    );

    public dispatch(action: Action){
        this.store.dispatch(action);
    };
}